using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Data.Entities;

namespace ForumApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumAppDbContext data;

        public PostsController(ForumAppDbContext data)
            => this.data = data;

        public IActionResult All()
        {
            var posts = this.data
                .Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                })
                .ToList();

            return View(posts);
        }

        public IActionResult Add()
            => View();

        [HttpPost]
        public IActionResult Add(PostFormModel model)
        {
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            data.Posts.Add(post);
            data.SaveChanges();

            return RedirectToAction("All");
        }

        public IActionResult Edit(int id)
        {
            var post = data.Posts.Find(id);

            return View(new PostFormModel()
            {
                Title = post.Title,
                Content = post.Content
            });
        }

        [HttpPost]
        public IActionResult Edit
            (int Id, PostFormModel model)
        {
            var post = data.Posts.Find(Id);

            post.Title = model.Title;
            post.Content = model.Content;

            data.SaveChanges();

            return RedirectToAction("All");
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var post = this.data.Posts.Find(Id);

            this.data.Posts.Remove(post);
            this.data.SaveChanges();

            return RedirectToAction("All");
        }

    }
}
