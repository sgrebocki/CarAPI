using CarAPI.Models;
using CarAPI.Repositories;
using CarAPI.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarAPI.Controllers
{
    [Route("Car/[action]")]
    public class CarController : Controller
    {
        private readonly ICarRepositories _repo;

        public CarController(ICarRepositories repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cars = _repo.GetAll();
            return View(cars);
        }

        [HttpGet]
        public IActionResult List()
        {
            var products = _repo.GetAll();
            return View(products);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _repo.GetCarById(id);
            return View(result);
        }

        [Authorize]
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Create()
        {
            return View();
        }

      

        [HttpPost]
        public IActionResult Create(Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.CreateCar(car);
                    return RedirectToAction(nameof(Index));
                }
                return View(car);
            }
            catch (Exception)
            {
                return View();
            }
        }
        [Authorize]
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Edit(int id)
        {
            var car = _repo.GetCarById(id);
            return View(car);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Edit(Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.UpdateCar(car);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }

        //[HttpGet]
        //[ApiExplorerSettings(IgnoreApi = true)]
        //public IActionResult Delete(int id)
        //{
        //    var car = _repo.GetCarById(id);
        //    return View(car);
        //}
        [Authorize]
        [Route("{id}")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                _repo.DeleteCar(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }           
        }
    }
}
