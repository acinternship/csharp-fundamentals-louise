﻿using Microsoft.AspNetCore.Mvc;
using OdeToFood.Entities;
using OdeToFood.ViewModels;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(
            IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public ViewResult index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, RestaurantEditViewModel input)
        {
            var restaurant = _restaurantData.Get(id);
            if(restaurant != null && ModelState.IsValid)
            {
                restaurant.Name    = input.Name;
                restaurant.Cuisine = input.Cuisine;
                _restaurantData.Commit();
                
                return RedirectToAction("Details", new { id = restaurant.Id });
            }

            return View(restaurant);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var restaurant = new Restaurant();
                restaurant.Name = model.Name;
                restaurant.Cuisine = model.Cuisine;

                _restaurantData.Add(restaurant);

                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View();
        }   


        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
