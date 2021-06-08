using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;

namespace CleanArchitechture.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;


        public BlogController(IBlogService blogService, ICategoryService categoryService , ITagService tagService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _tagService = tagService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            ViewBag.Categories =  _categoryService.GetAll();
            ViewBag.Tags = _tagService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Add(BlogViewModel model)
        {
            _blogService.AddWithTags(model);
            _blogService.AddWithCategories(model);
           
            return View();
        }
    }
}
