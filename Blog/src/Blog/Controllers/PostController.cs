using Blog.Entities;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    //[Authorize]
    public class PostController : Controller
    {
        private BlogDbContext _dbContext;

        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public PostController(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Blog.ToList());
        }


        [HttpGet][Authorize]
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


        //IDENTITY VIDEOS
        public PostController(UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Username };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                        return RedirectToAction("Index", "Home");

                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();
        }

        private void SignInAsync(User user, bool v)
        {
            throw new NotImplementedException();
        }
    }
}
