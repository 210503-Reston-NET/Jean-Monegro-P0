using System;

namespace StoreModels
{
    public class Product
    {
        public Product(){
            
        }
        public string Item{get;set;}
        public double Price{get;set;}

        public override string ToString()
        {
            return $"\t Item: {Item} \n\t Price: {Price}";
        }
    }
}