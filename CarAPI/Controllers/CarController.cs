using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    public class CarController : ControllerBase
    {
        private static List<Car> cars = new List<Car>()
        {
             new Car
             {
                 Id = 1,
                 Brand = "Dodge",
                 Model = "Challanger SRT",
                 Power = 707,
                 ProductionYear = 2020
             },

             new Car
             {
                 Id = 2,
                 Brand = "BMW",
                 Model = "M3",
                 Power = 350,
                 ProductionYear = 2016
             }
        };

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            var car = cars.Find(x => x.Id == id);
            if (car == null)
                return NotFound("Car not found");
            return Ok(cars);
        }

        [HttpPost]
        public async Task<ActionResult<List<Car>>> AddCar(Car car)
        {
            cars.Add(car);
            return Ok(cars);
        }

        [HttpPut]
        public async Task<ActionResult<List<Car>>> UpdateCar(Car update)
        {
            var car = cars.Find(x => x.Id == update.Id);

            car.Brand = update.Brand;
            car.Model = update.Model;
            car.Power = update.Power;
            car.ProductionYear = update.ProductionYear;

            return Ok(cars);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Car>>> DeleteCar(int id)
        {
            var car = cars.Find(x => x.Id == id);
            if (car == null)
                return NotFound("Car not found");

            cars.Remove(car);
            return Ok(cars);
        }
    }
}
