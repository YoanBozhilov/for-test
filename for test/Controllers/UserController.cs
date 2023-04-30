﻿using for_test.DTOs;
using for_test.Models;
using Microsoft.AspNetCore.Mvc;
using for_test.Services;

namespace for_test.Controllers
{
    public class UserController : Controller
    {
        private UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<UserDTO> users = userService.GetAll();

            return View(users);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            User user = userService.GetById(id);

            return View(user);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            userService.Create(user);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            User user = userService.GetById(id);

            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            userService.Edit(user);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            User user = userService.GetById(id);

            return View(user);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            userService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
