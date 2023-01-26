using CarAPI.Models;
using CarAPI.Repositories.IRepositories;
using CarAPI.Service.IService;
using Microsoft.IdentityModel.Tokens;

namespace CarAPI.Service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void CreateCar(Car car)
        {
            _carRepository.CreateCar(car);
        }

        public void DeleteCar(int Id)
        {
            _carRepository.DeleteCar(Id);
        }

        public IEnumerable<Car> GetAll()
        {
            var result = _carRepository.GetAll();
            return result;
        }

        public Car GetCarById(int Id)
        {
            var result = _carRepository.GetCarById(Id);
            return result;
        }

        public void UpdateCar(Car car)
        {
            _carRepository.UpdateCar(car);
        }
    }
}
