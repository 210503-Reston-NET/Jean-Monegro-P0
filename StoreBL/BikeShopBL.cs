namespace StoreBL
{
    public class BikeShopBL
    {
        private IRepository _repo;
        public RestaurantBL(IRepository repo)
        {
            _repo = repo;
        }

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            if (_repo.GetRestaurant(restaurant) != null)
            {
                throw new Exception("Restaurant already exists :<");
            }
            return _repo.AddRestaurant(restaurant);
        }

        public List<Restaurant> GetAllRestaurants()
        {

            return _repo.GetAllRestaurants();
        }
    }
}