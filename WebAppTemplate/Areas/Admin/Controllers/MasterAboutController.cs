using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Helpers.Email;
using WebAppTemplate.Extensions;
using WebAppTemplate.Helpers.File;
using WebAppTemplate.Models;
using WebAppTemplate.Repository;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]

    public class MasterAboutController : Controller
    {
        iRepository<MasterAbout> _masterAboutRepository;
        iFileHelper iFileHelper;
        iEmailService iEmailService;

        public MasterAboutController(iRepository<MasterAbout> masterAboutRepository, iFileHelper iFileHelper, iEmailService iEmailService)
        {
            _masterAboutRepository = masterAboutRepository;
            this.iFileHelper = iFileHelper;
            this.iEmailService = iEmailService;
        }


        // GET: MasterAboutController
        public ActionResult Index()
        {
            return View(_masterAboutRepository.View().ToViewModelList());
        }

        // GET: MasterAboutController/Details/5
        public ActionResult Details(int id)
        {
            return View(_masterAboutRepository.Find(id).ToViewModel());
        }

        // GET: MasterAboutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterAboutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterAboutViewModel collection)
        {
            try
            {
                var imageName = iFileHelper.SaveImage(collection.imageFile, "MasterAboutImages", null);
                var CVName = iFileHelper.SavePDF(collection.cvFile, "MasterAboutPDF", null);

                var data = collection.ToModel();    
                data.CV_URL = CVName;
                data.ImageUrl= imageName;
                data.CreateUser = User.Identity.Name;

                _masterAboutRepository.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterAboutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_masterAboutRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterAboutViewModel collection)
        {
            try
            {
                var imageName = iFileHelper.SaveImage(collection.imageFile, "MasterAboutImages", collection.ImageUrl);
                var CVName = iFileHelper.SaveImage(collection.cvFile, "MasterAboutPDF", collection.CV_URL);

                var data = collection.ToModel();
                data.CV_URL = CVName;
                data.ImageUrl = imageName;
                data.EditUser = User.Identity.Name;

                _masterAboutRepository.Update(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterAboutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_masterAboutRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _masterAboutRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: MasterAboutController/Delete/5
        public ActionResult ActivationsStatus(int id)
        {
            return View(_masterAboutRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, IFormCollection collection)
        {
            try
            {
                _masterAboutRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}
