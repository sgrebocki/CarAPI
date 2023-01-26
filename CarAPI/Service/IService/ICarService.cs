using CarAPI.Models;

namespace CarAPI.Service.IService
{
    public interface ICarService
    {
        Car GetCarById(int Id);
        IEnumerable<Car> GetAll();
        void CreateCar(Car car);
        void DeleteCar(int Id);
        void UpdateCar(Car car);
    }
}
