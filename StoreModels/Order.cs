namespace StoreModels
{
    public class Order
    {
        public Customer Customer{get;set;}
        public Location Location{get;set;}

        public double Total{get;set;}

    }
}