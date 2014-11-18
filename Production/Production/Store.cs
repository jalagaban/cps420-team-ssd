// Represents a store location from which bad checks are received

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public class Store
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }

        public override bool Equals(System.Object obj)
        {
            if (obj is Store)
            {
                Store store = (Store)obj;
                
                // Return true if the fields match:
                return (ID.Equals(store.ID)) &&
                       (Name.Equals(store.Name)) &&
                       (Street.Equals(store.Street)) &&
                       (City.Equals(store.City)) &&
                       (State.Equals(store.State)) &&
                       (Zipcode.Equals(store.Zipcode));
            }
            else
            {
                return false;
            } 
        }
    }
}
