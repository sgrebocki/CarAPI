using AutoMapper;
using CarAPI.Models;
using CarAPI.Repositories.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        // GET: /Car
        [HttpGet ("/Car")]
        public ActionResult Index()
        {
            var result = carRepository.GetAll();
            return View(result);
        }

        // GET: /Car/{id}
        [HttpGet ("/Car/{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = carRepository.GetCarById(id);
            return View(result);
        }

        // GET: /Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Car/Create
        [HttpPost ("/Car/Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Car car)
        {

            if (ModelState.IsValid)
            {
                carRepository.CreateCar(car);
                return View(car);
            }
            return View();
        }

        // GET: Car/Edit
        public ActionResult Edit()
        {
            return View();
        }

        // PUT: CarController/Edit
        [HttpPut ("/Car/Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Car car)
        {
            try
            {
                carRepository.UpdateCar(car);
                return View(car);
            }
            catch
            {
                return View();
            }
        }

        // GET: Car/Delete
        public ActionResult Delete()
        {
            return View();
        }

        // DELETE: Car/Delete/{id}
        [HttpDelete ("/Car/Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
               carRepository.DeleteCar(id);
               return View(id);
            }
            catch
            {
                return View();
            }
        }
    }
}
