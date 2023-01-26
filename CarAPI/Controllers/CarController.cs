using AutoMapper;
using CarAPI.Models;
using CarAPI.Repositories.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarAPI.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;
        private readonly IMapper mapper;
        public CarController(ICarRepository carRepository, IMapper mapper)
        {
            this.carRepository = carRepository;
            this.mapper = mapper;
        }
    
        // GET: CarController
        public ActionResult Index()
        {
            var result = carRepository.GetAll();
            return View(result);
        }

        // GET: CarController/Details/5
        // [HttpGet ("{id}")]
        public ActionResult GetById(int id)
        {
            var result = carRepository.GetCarById(id);
            return View(result);
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: CarController/Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {

            if (ModelState.IsValid)
            {
                carRepository.CreateCar(car);
                return View(car);
            }

            return this.StatusCode(StatusCodes.Status500InternalServerError);
        }

        // GET: CarController/Edit/5
        public ActionResult Edit()
        {
            var result = carRepository.UpdateCar;
            return View(result);
        }

        // POST: CarController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
