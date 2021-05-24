using Entity = CarLotDL.Entities;
using Model = CarLotModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CarLotDL;
using System.Linq;
using System;
using Xunit;
using CarLotModels;
namespace CarLotTests
{
    public class CarTest
    {

        private readonly DbContextOptions<Entity.PracticeContext> options;

        [Fact]
        public void GetCarShouldReturnCar()
        {
            using (var context = new Entity.PracticeContext(options))
            {
                IRepository _repo = new RepoDB(context);
                var cars = _repo.GetAllCars();
            }
        }
        // [Fact]
        // public void AddLocationShouldAddLocation()
        // {
        //     using(var context = new Entity.PracticeContext(options))
        //     {
        //         Location _repo = new RepoDB(context);
        //         _repo.AddLocation
        //         (
        //             new Model.Location("Ciy", "State", "USA")
        //         );
        //     }
        //     using(var assertContext = new Entity.PracticeContext(options))
        // }
        [Fact]
        public void ModelShouldSetValidData()
        {
            string model = "Honda";
            Car test = new Car();

            test.Model = model;

            Assert.Equal(model, test.Model);
        }
        [Theory]
        [InlineData("2345678i")]
        [InlineData("6756868i")]
        public void ModelShouldNotSetInvalidData(string input)
        {
            Car test = new Car();

            Assert.Throws<Exception>(() => test.Model = input);
        }
        [Fact]
        public void AddCarShouldAddCar()
        {
            using (var context = new Entity.PracticeContext(options))
            {
                IRepository _repo = new RepoDB(context);
                //Act with a test context
                _repo.AddCar
                (
                    new Model.Car("Scion", "tc", 2008)
                );
            }
        }
    }
}