using HouseRentingSystem.Core.Models.House;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class HouseController : Controller
    {
        public async Task<IActionResult> All()
        {
            var model = new HousesQueryModel();

            return View(model);
        }

        public async Task<IActionResult> Mine()
        {
            var model = new HousesQueryModel();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = new HouseDetailsModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(HouseModel model)
        {
            int id = 1;

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new HouseModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, HouseModel model)
        {
            //TODO edits

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, HouseModel model)
        {
            //TODO Delete

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id, HouseModel model)
        {
            //TODO Delete

            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id, HouseModel model)
        {
            //TODO Delete

            return RedirectToAction(nameof(Mine));
        }
    }
}
