using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/// <summary>
/// Namespace for the models/custom data structures involved in Restaurant Reviews
/// </summary>
namespace CarLotModels
{
    /// <summary>
    /// Data structure used to define a restaurant 
    /// </summary>
    public class Car
    {
        // Class Members
        // 1. Constructor - use this to create an instance of the class
        // 2. Fields - defines the characteristics of a class
        // 3. Methods - defines the behavior of a class
        // 4. Properties - also known as smart fields, are accessor methods used to access private backing fields (private fields)
        // *Note that properties are analogous to Java getter and setter
        // * Property naming convention uses PascalCase (like methods)
        private string _year;
        public Car(string name, string year, string mpg)
        {
            this.Name = name;
            this.Year = year;
            this.Mpg = mpg;
        }
        public Car(int id, string name, string year, string mpg) : this(name, year, mpg)
        {
            this.Id = id;
        }
        public Car()
        {

        }
        /// <summary>
        /// This describes the name of your restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// This describes the location
        /// </summary>
        /// <value></value>
        public string Year
        {
            get { return _year; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$")) throw new Exception("City cannot have numbers!");
                _year = value;
            }
        }
        /// <summary>
        /// This describes the location
        /// </summary>
        /// <value></value>
        public string Mpg { get; set; }
        /// <summary>
        /// This contains the review of a particular restaurant
        /// </summary>
        /// <value></value>
        public List<Description> Descriptions { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} \n Location: {Year}, {Mpg}";
        }
        public bool Equals(Car car)
        {
            return this.Name.Equals(car.Name) && this.Year.Equals(car.Year) && this.Mpg.Equals(car.Mpg);
        }

        public int Id { get; set; }

    }
}