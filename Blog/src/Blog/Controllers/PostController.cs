using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        private static List<BlogPost> _posts = new List<BlogPost>
        {
            new BlogPost {Id = 1, Title = "Post1", CreatedAt = DateTime.Now,
                Content = "Teste"},
            new BlogPost {Id = 2, Title = "Post2", CreatedAt = DateTime.Now,
                Content = "Teste2"}
        };

        public IActionResult Index()
        {
            return View(_posts);
        }


        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogPost post)
        {
            /*if (ModelState.IsValid)
            {
            }*/

            post.CreatedAt = DateTime.Now;
            _posts.Add(post);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model =_posts.FirstOrDefault(p => p.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(BlogPost post)
        {
            var model = _posts.FirstOrDefault(p => p.Id == post.Id);
            model.Title = post.Title;
            model.Content = post.Content;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            //var model = _posts.FirstOrDefault(p => p.Id == id); //verficar se model existe
            //_posts.Remove(model);

            _posts.RemoveAll(p => p.Id == id);
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
