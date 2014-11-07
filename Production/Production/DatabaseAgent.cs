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

        public Check GetCheck(Tuple<string, string, string> key);

        public void AddCheck(Check check);

        public void UpdateCheck(Check check);

        public void DeleteCheck(Tuple<string, string, string> key);

        
        /* A list containing the primary keys of all accounts in the database. 
        Each key is a tuple containing the two identifiying attributes of an account.
        These attributes as ordered in the tuple are the RoutingNum and AccountNum. */
        public List<Tuple<string, string>> AccountKeys;
        
        public Account GetAccount(Tuple<string, string> key);

        public void AddAccount(Account account);

        public void UpdateAccount(Account account);

        public void DeleteAccount(Tuple<string, string> key);


        /* A list containing the primary keys of all stores in the database. 
         The primary key for a store is equivalent to its StoreNum. */
        public string StoreKeys;

        public Store GetStore(string storeNum);

        public void AddStore(Store store);

        public void UpdateStore(Store store);

        public void DeleteStore(string storeNum);
    }
}
