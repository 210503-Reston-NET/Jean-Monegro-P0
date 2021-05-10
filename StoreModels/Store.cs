using System;

namespace StoreModels
{
    public class Store
    {
        public Product Product;

        public Store(string city, string state, string country)
        {
            this.City = city;
            this.State = state;
            this.Country = country;
        }
        public Store()
        {

        }
        public string City{get;}
        public string State{get;}
        public string Country{get;}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
