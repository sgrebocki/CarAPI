using CarAPI.Models;
using CarAPI.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CarAPI.Repositories
{
    public class CarRepositories : ICarRepository
    {
        private readonly DataContext _context;
        public CarRepositories(DataContext context)
        {
              _context= context;
        }

        public void CreateCar(Car car)
        {
            _context.Cars.Add(car);
        }

        public void DeleteCar(int Id)
        {
            var CarToDelete = GetCarById(Id);
            if (CarToDelete != null)
            {
                _context.Cars.Remove(CarToDelete);
                _context.SaveChanges();
            }
            if(CarToDelete is null) 
            {
                throw new Exception("Car not found");
                
            }
        }

        public IEnumerable<Car> GetAll()
        {
            
            var cars = _context.Cars.ToList();
            return cars;
        }

        public Car GetCarById(int Id)
        {
            var result = _context.Cars.FirstOrDefault(x => x.Id == Id);
            return result;
        }

        public void UpdateCar(Car car)
        {
            Car CarToUpdate = _context.Cars.Where(c => c.Id == car.Id).FirstOrDefault();
            if (CarToUpdate != null)
            {
                _context.Cars.Update(car);
                _context.SaveChanges();
            }          
        }
    }
}
