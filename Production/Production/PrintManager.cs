//Manages printing out letters for each unpaid check

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Production
{
    public class PrintManager
    {
        private static PrintManager defaultPrintManager;

        public static PrintManager DefaultPrintManager
        {
            get
            {
                if (defaultPrintManager == null)
                {
                    defaultPrintManager = new PrintManager();
                }
                return defaultPrintManager;
            }
        }
        //Pull information from database then put into Document object
        public Document GenerateDoc(Tuple<string, string, string> i)
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            Config config = Config.GlobalConfig;

            Check chk = db.GetCheck(i); // get Check from database

            Account ac = new Account();
            if (db.AccountExists(Tuple.Create(i.Item1, i.Item2)) == true)
            {
                ac = db.GetAccount(Tuple.Create(i.Item1, i.Item2)); // get Account from database
            }

            Store str = new Store();
            if (db.StoreExists(chk.StoreID))
            {
                str = db.GetStore(chk.StoreID); //get store name
            }

            Document doc = new Document();
            doc.FirstName = ac.FirstName;
            doc.LastName = ac.LastName;
            doc.Street = ac.Street;
            doc.City = ac.City;
            doc.State = ac.State;
            doc.Zip = ac.Zipcode;

            doc.ChkAmt = chk.Amount;
            doc.ChkDate = chk.Date;

            doc.StoreName = str.Name;

            doc.CompName = config.GetValue("company_name");
            doc.CompStreet = config.GetValue("company_street");
            doc.CompCity = config.GetValue("company_city");
            doc.CompState = config.GetValue("company_state");
            doc.CompZip = config.GetValue("company_zip");
            string fee = config.GetValue("company_fee");
            if (fee == null)
                doc.CompFee = 0;
            else
                doc.CompFee = Convert.ToInt32(fee);

            doc.total = doc.ChkAmt + doc.CompFee;
            doc.CompPhoneNum = config.GetValue("company_phone");
            doc.DueDate = getDate(chk);
            return doc;
        }
        public DateTime getDate(Check chk)
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;

            DateTime curDate = DateTime.Now;
            
            DateTime dueDate = curDate.AddDays(20); //return latest due date (curDate + 20 days)
            //Find latest date to send letter
            if (chk.LetterADate == null)
            {
                chk.LetterADate = dueDate;
                db.UpdateCheck(chk);
                return (DateTime)chk.LetterADate;
            }
            else if (chk.LetterBDate == null && (curDate - (DateTime)chk.LetterADate).TotalDays >= 20)
            {
                chk.LetterBDate = dueDate;
                db.UpdateCheck(chk);
                return (DateTime)chk.LetterBDate;
            }
            else if (chk.LetterCDate == null && (curDate - (DateTime)chk.LetterBDate).TotalDays >= 20)
            {
                chk.LetterCDate = dueDate;
                db.UpdateCheck(chk);
                return (DateTime)chk.LetterCDate;
            }

            return dueDate;
        }
        //Determines if check is paid or not
        public bool PaidBool(Tuple<string, string, string> i)
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            if (db.CheckExists(i) == true)
            {
                Check chk = db.GetCheck(i);
                if (chk.IsPaid == true) { return true; }
            }
            else { return true; }
            return false;
        }

        //Get list of documents of letter to be printed based on if check is paid
        public List<Document> GetLettersToPrint()
        {
            List<Document> letters = new List<Document>();

            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            List<Tuple<string, string, string>> keys = db.CheckKeys;
            foreach (Tuple<string, string, string> i in keys)
            {
                if (PaidBool(i) == false)
                {
                    //Generate document if not paid then add to list
                    Document doc = GenerateDoc(i);
                    letters.Add(doc);
                }
            }

            return letters;
        }
    }
}
