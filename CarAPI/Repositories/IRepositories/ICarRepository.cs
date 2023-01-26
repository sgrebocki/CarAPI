using CarAPI.Models;

namespace CarAPI.Repositories.IRepositories
{
    public interface ICarRepository
    {
        Car GetCarById(int Id);
        IEnumerable<Car> GetAll();
        void CreateCar(Car car);
        void DeleteCar(int Id);
        void UpdateCar(Car car);
    }
}
