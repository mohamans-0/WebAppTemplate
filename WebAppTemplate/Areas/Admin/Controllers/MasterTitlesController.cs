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
    public class MasterTitlesController : Controller
    {
        iRepository<MasterTitles> _masterTitlesRepository;

        public MasterTitlesController(iRepository<MasterTitles> masterTitlesRepository)
        {
            _masterTitlesRepository = masterTitlesRepository;
        }


        // GET: MasterTitlesController
        public ActionResult Index()
        {
            return View(_masterTitlesRepository.View().ToViewModelList());
        }

        // GET: MasterTitlesController/Details/5
        public ActionResult Details(int id)
        {
            return View(_masterTitlesRepository.Find(id).ToViewModel());
        }

        // GET: MasterTitlesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterTitlesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterTitlesViewModel collection)
        {
            try
            {
                _masterTitlesRepository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterTitlesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_masterTitlesRepository.Find(id).ToViewModel());
        }

        // POST: MasterTitlesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterTitlesViewModel collection)
        {
            try
            {
                _masterTitlesRepository.Update(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterTitlesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_masterTitlesRepository.Find(id).ToViewModel());
        }

        // POST: MasterTitlesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterTitlesViewModel collection)
        {
            try
            {
                _masterTitlesRepository.Delete(id);
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
            return View(_masterTitlesRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, MasterTitlesViewModel collection)
        {
            try
            {
                _masterTitlesRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
