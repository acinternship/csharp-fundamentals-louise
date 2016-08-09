using Blog.Entities;
using Blog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Blog.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private BlogDbContext _dbContext;
        public PostController(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Blog.ToList());
        }


        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogPost post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            post.CreatedAt = DateTime.Now;
            _dbContext.Blog.Add(post);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var model = _dbContext.Blog.FirstOrDefault(item => item.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(BlogPost post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }
            var model = _dbContext.Blog.FirstOrDefault(p => p.Id == post.Id);
            model.Title = post.Title;
            model.Content = post.Content;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            //var model = _posts.FirstOrDefault(p => p.Id == id); //verficar se model existe
            //_posts.Remove(model);
            /*if ()
            {

            }*/

            var post = _dbContext.Blog.FirstOrDefault(P => P.Id == id);
            _dbContext.Blog.Remove(post);
            return RedirectToAction("Index");
        }

        /*public IActionResult Details(int id)
        {
            var model = .Get(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }*/



    }
}
