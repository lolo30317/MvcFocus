using Business.Concrete;
using Business.Validation;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetList()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            //cm.CategoryAdd(c);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult validationResult= categoryValidator.Validate(c);
            if(validationResult.IsValid)
            {
                cm.CategoryAdd(c);
                return RedirectToAction("GetList");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                    
                }
               
            }
            return View();
        }
    }
}