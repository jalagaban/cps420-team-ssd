//Handles Print click event

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using Production;

namespace CpS_420_Inception_Project
{
    class PrintLetters
    {
        private static PrintLetters printAgent;

        public static PrintLetters PrintAgent
        {
            get
            {
                if (printAgent == null)
                {
                    printAgent = new PrintLetters();
                }
                return printAgent;
            }
        }
        private int counter = 0;
        private List<Document> documents;

        //Used: http://www.codeproject.com/Tips/453871/Simple-Receipt-Like-Printing-Using-the-Csharp-Prin as reference
        public void PrintDocuments(List<Document> d)
        {
            documents = d;
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            Font font = new Font("Calibri", 12);

            PaperSize psize = new PaperSize("Custom", 100, 200);

            pd.Document = doc;
            pd.Document.DefaultPageSettings.PaperSize = psize;

            doc.DefaultPageSettings.PaperSize.Height = 820;
            doc.DefaultPageSettings.PaperSize.Width = 520;

            doc.PrintPage += new PrintPageEventHandler(GeneratePage);
            DialogResult result = pd.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = doc;
                result = pp.ShowDialog();
               if (result == DialogResult.OK)
                {
                    doc.Print();
                }
            }
        }

        public void GeneratePage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Calibri", 12);
            float fontHeight = font.GetHeight();
            SolidBrush sb = new SolidBrush(Color.Black);

            int startX = 50;
            int startY = 55;
            int Offset = 0;

            graphics.DrawString("DEMAND LETTER", new Font("Calibri", 18), sb, startX, startY);

            while (counter < documents.Count)
            {
                //Debtor address
                Offset = Offset + 45;
                graphics.DrawString( DateTime.Now.ToString("MM/dd/yyyy"), font, sb, startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(documents[counter].FirstName + ' ' + documents[counter].LastName, font, sb, startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(documents[counter].Street, font, sb, startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(documents[counter].City + ", " + documents[counter].State + ' ' + documents[counter].Zip, font, sb, startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("RE: Demand for Payment", new Font("Calibri", 16, FontStyle.Bold), sb, startX, startY + Offset);
                Offset = Offset + 30;

                //Letter body
                graphics.DrawString("To whom it may concern,", font, sb, startX, startY + Offset);
                Offset = Offset + 30;
                graphics.DrawString("Please be advised that " + documents[counter].FirstName + ' ' + documents[counter].LastName + " owes " + documents[counter].CompName + " the sum of \n$" + documents[counter].total +
                                    " due to writing a bad check to " + documents[counter].StoreName + " on " + documents[counter].ChkDate.Date.ToString("MM/dd/yyyy") + ".\nThis total amount includes the check amount of $" + documents[counter].ChkAmt +
                                    " \nand a fee of $" + documents[counter].CompFee + '.', font, sb, startX, startY + Offset); // first paragraph
                Offset = Offset + 100;
                graphics.DrawString(documents[counter].CompName + " requires full payment to be delivered in the amount of \n$" + documents[counter].total + " to be delivered to:\n", font, sb, startX, startY + Offset);
                Offset = Offset + 45;
                graphics.DrawString(documents[counter].CompName + " Checks Receiving", font, sb, startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(documents[counter].CompStreet, font, sb, startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString(documents[counter].CompCity + ", " + documents[counter].CompState + ' ' + documents[counter].CompZip, font, sb, startX, startY + Offset);
                Offset = Offset + 30;

                graphics.DrawString("Please contact us on or before " + documents[counter].DueDate.Date.ToString("MM/dd/yyyy") + " with any questions.", font, sb, startX, startY + Offset);
                Offset = Offset + 30;

                graphics.DrawString("Based on the foregoing, " + documents[counter].CompName + " expects payment in the \namount of $" + documents[counter].total + " made payable to " + documents[counter].CompName +
                                     " no later than \n" + documents[counter].DueDate.Date.ToString("MM/dd/yyyy") + '.', font, sb, startX, startY + Offset);
                Offset = Offset + 70;
                graphics.DrawString("If you have any further questions, you may contact the office at \n" + documents[counter].CompPhoneNum + '.', font, sb, startX, startY + Offset);

                Offset = Offset + 70;

                //Salutation
                graphics.DrawString("Sincerely,", font, sb, startX, startY + Offset);
                Offset = Offset + 45;
                graphics.DrawString(documents[counter].CompName, font, sb, startX, startY + Offset);

                //Goes to next page
                if (counter == documents.Count - 1) { e.HasMorePages = false; break; }
                else
                {
                    e.HasMorePages = true;
                    counter++; 
                    return;
                }

            }

        }
        /*public void PrintLetters()
        {
            PrintManager pm = PrintManager.DefaultPrintManager;
            List<Document> documents = pm.GetLettersToPrint();
            foreach (Document doc in documents)
            {
                PrintDocuments(doc);
            }
        }*/
    }
}
