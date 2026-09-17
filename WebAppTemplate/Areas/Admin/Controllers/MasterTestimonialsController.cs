using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Extensions;
using WebAppTemplate.Helpers.File;
using WebAppTemplate.Models;
using WebAppTemplate.Repository;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize]
    public class MasterTestimonialsController : Controller
    {
        iRepository<MasterTestimonials> iMasterTestimonialsRepository;
        iFileHelper iFileHelper;

        public MasterTestimonialsController(iRepository<MasterTestimonials> iMasterTestimonialsRepository, iFileHelper iFileHelper)
        {
            this.iMasterTestimonialsRepository = iMasterTestimonialsRepository;
            this.iFileHelper = iFileHelper;
        }

        // GET: MasterTestimonialsController
        public ActionResult Index()
        {
            return View(iMasterTestimonialsRepository.View().ToViewModelList());
        }

        // GET: MasterTestimonialsController/Details/5
        public ActionResult Details(int id)
        {
            return View(iMasterTestimonialsRepository.Find(id).ToViewModel());
        }

        // GET: MasterTestimonialsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterTestimonialsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterTestimonialsViewModel collection)
        {
            try
            {
                var imageName = iFileHelper.SaveImage(collection.imageFile, "MasterAboutImages", null);
                var data = collection.ToModel();
                data.ImageUrl = imageName;
                iMasterTestimonialsRepository.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterTestimonialsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(iMasterTestimonialsRepository.Find(id).ToViewModel());
        }

        // POST: MasterTestimonialsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterTestimonialsViewModel collection)
        {
            try
            {

                var data = iMasterTestimonialsRepository.Find(id);


                data.Name = collection.Name;
                data.Company = collection.Company;
                data.Desc = collection.Desc;
                data.isActive = collection.isActive;

                if (collection.imageFile != null)
                {
                    var imageName = iFileHelper.SaveImage(collection.imageFile, "MasterAboutImages", null);


                    data.ImageUrl = imageName;
                }
                iMasterTestimonialsRepository.Update(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterTestimonialsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(iMasterTestimonialsRepository.Find(id).ToViewModel());
        }

        // POST: MasterTestimonialsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                iMasterTestimonialsRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ActivationsStatus(int id)
        {
            return View(iMasterTestimonialsRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, IFormCollection collection)
        {
            try
            {
                iMasterTestimonialsRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
