using System;

namespace StoreModels
{
    public class Product
    {
        public string Item{get;set;}
        public string Description{get;set;}

        public override string ToString()
        {
            return $"\t Item: {Item} \n\t Description: {Description}";
        }
    }
}