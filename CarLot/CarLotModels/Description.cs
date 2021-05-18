using System;
namespace CarLotModels
{
    public class Description
    {
        private int _year;
        /// <summary>
        /// This describes the overall numeric rating of a restaurant
        /// </summary>
        /// <value></value>
        public Description(int year, string mpg)
        {
            this.Year = year;
            this.Mpg = Mpg;
        }
        public Description()
        { }
        public int Year
        {
            get { return _year; }
            set
            {
                //Setting validation logic in properties
                if (_year < 0)
                {
                    throw new Exception("Rating should be greater tha zero.");
                }
                _year = value;
            }
        }
        /// <summary>
        /// Verbose description of the dining experience
        /// </summary>
        /// <value></value>
        public string Mpg { get; set; }

        public override string ToString()
        {
            return $"\t Rating: {Year} \n\t Description: {Mpg}";
        }
    }
}