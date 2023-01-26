using CarAPI.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService carService;
        public CarController(ICarService carService)
        {
            this.carService = carService;
        }
    
        // GET: CarController
        public ActionResult Index()
        {
            var result = carService.GetAll();
            return View(result);
        }

        // GET: CarController/Details/5
        public ActionResult GetById(int id)
        {
            var result = carService.GetCarById(id);
            return View(result);
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            var result = carService.CreateCar;
            return View(result);
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ICarService carService)
                    public ActionResult Create(IFormCollection collection)
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

        // GET: CarController/Edit/5
        public ActionResult Edit()
        {
            var result = carService.UpdateCar;
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
