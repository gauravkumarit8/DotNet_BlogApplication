using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	public class PostController : Controller
	{
		private readonly ApplicationDbContext _db;

		public PostController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			List<Post> allPost = _db.Posts.ToList();
			return View(allPost);
		}

		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Post post)
		{
			if (ModelState.IsValid)
			{
				_db.Posts.Add(post);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}

		public IActionResult Edit(int? id)
		{
			if(id == null && id == 0)
			{
				return NotFound();
			}
			Post post= _db.Posts.Find(id);
			if (post == null)
			{
				return NotFound();
			}
			return View(post);
		}
		[HttpPost]
		public IActionResult Edit(Post post) {
			if(ModelState.IsValid)
			{
				_db.Posts.Update(post);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View() ;
		}

		public IActionResult Delete(int? id)
		{
			if(ModelState.IsValid && id == null)
			{
				return NotFound();
			}
			Post post = _db.Posts.Find(id);
			if (post == null)
			{
				return NotFound();
			}
			return View(post);
		}
		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePost(int? id)
		{
			Post? post = _db.Posts.Find(id);
			if(post == null)
			{
				return NotFound();
			}
			_db.Posts.Remove(post);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
		
	}
}
