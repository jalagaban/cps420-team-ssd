// The core model-layer class. Mediates access between the application and the server-side database.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public class DatabaseAgent
    {
        /* A list containing the primary keys of all checks in the database. 
         Each key is a tuple containing the three identifiying attributes of a check.
         These attributes as ordered in the tuple are the RoutingNum, AccountNum, and CheckNum. */
        public List<Tuple<string, string, string>> CheckKeys;

        public Check GetCheck(Tuple<string, string, string> key)
        {
            // Get check from database where check.RoutingNum == key[0], check.AccountNum == key[1], and check.CheckNum == key[2] 
        }

        public void AddCheck(Check check)
        {
            // Insert check into database
        }

        public void UpdateCheck(Check check)
        {
            // Replace Check table row in database with check where RoutNum column == check.RoutingNum, AcctNum column == check.AccountNum, and  ChkNum column == check.CheckNum
        }

        public void DeleteCheck(Tuple<string, string, string> key)
        {
            // Delete check from database where check.RoutingNum == key[0], check.AccountNum == key[1], and check.CheckNum == key[2] 
        }

        
        /* A list containing the primary keys of all accounts in the database. 
        Each key is a tuple containing the two identifiying attributes of an account.
        These attributes as ordered in the tuple are the RoutingNum and AccountNum. */
        public List<Tuple<string, string>> AccountKeys;

        public Account GetAccount(Tuple<string, string> key)
        {
            // Get account from database where account.RoutingNum == key[0] and account.AccountNum == key[1]
        }

        public void AddAccount(Account account)
        {
            // Insert account into database
        }

        public void UpdateAccount(Account account)
        {
            // Replace Account table row in database with account where RoutNum column == account.RoutingNum and AcctNum column == account.AccountNum
        }

        public void DeleteAccount(Tuple<string, string> key)
        {
            // Delete account from database where account.RoutingNum == key[0] and account.AccountNum == key[1]
        }


        /* A list containing the primary keys of all stores in the database. 
         The primary key for a store is equivalent to its StoreNum. */
        public string StoreKeys;

        public Store GetStore(string storeNum)
        {
            // Get store from database where store.ID == storeNum
        }

        public void AddStore(Store store)
        {
            // Insert store into database
        }

        public void UpdateStore(Store store)
        {
            // Replace STore table row in database with store where StoreID column == store.ID
        }

        public void DeleteStore(string storeNum)
        {
            // Delete store from database where store.ID == storeNum

        }
    }
}
