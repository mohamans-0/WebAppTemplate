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
    public class MasterSocailMediaController : Controller
    {
        iRepository<MasterSocialMedia> _MasterSocailMediaRepository;

        public MasterSocailMediaController(iRepository<MasterSocialMedia> MasterSocailMediaRepository)
        {
            _MasterSocailMediaRepository = MasterSocailMediaRepository;
        }


        // GET: MasterSocailMediaController
        public ActionResult Index()
        {
            return View(_MasterSocailMediaRepository.View().ToViewModelList());
        }

        // GET: MasterSocailMediaController/Details/5
        public ActionResult Details(int id)
        {
            return View(_MasterSocailMediaRepository.Find(id).ToViewModel());
        }

        // GET: MasterSocailMediaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterSocailMediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterSocialMediaViewModel collection)
        {
            try
            {
                _MasterSocailMediaRepository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSocailMediaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_MasterSocailMediaRepository.Find(id).ToViewModel());
        }

        // POST: MasterSocailMediaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterSocialMediaViewModel collection)
        {
            try
            {
                _MasterSocailMediaRepository.Update(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSocailMediaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_MasterSocailMediaRepository.Find(id).ToViewModel());
        }

        // POST: MasterSocailMediaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _MasterSocailMediaRepository.Delete(id);
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
            return View(_MasterSocailMediaRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, MasterSocialMediaViewModel collection)
        {
            try
            {
                _MasterSocailMediaRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
