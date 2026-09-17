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
    public class MasterPositionsController : Controller
    {
        iRepository<MasterPositions> _masterPositionsRepository;

        public MasterPositionsController(iRepository<MasterPositions> masterPositionsRepository)
        {
            _masterPositionsRepository = masterPositionsRepository;
        }


        // GET: MasterPositionsController
        public ActionResult Index()
        {
            return View(_masterPositionsRepository.View().ToViewModelList());
        }

        // GET: MasterPositionsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_masterPositionsRepository.Find(id).ToViewModel());
        }

        // GET: MasterPositionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterPositionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterPositionsViewModel collection)
        {
            try
            {
                _masterPositionsRepository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterPositionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_masterPositionsRepository.Find(id).ToViewModel());
        }

        // POST: MasterPositionsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterPositionsViewModel collection)
        {
            try
            {
                _masterPositionsRepository.Update(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterPositionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_masterPositionsRepository.Find(id).ToViewModel());
        }

        // POST: MasterPositionsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _masterPositionsRepository.Delete(id);
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
            return View(_masterPositionsRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, IFormCollection collection)
        {
            try
            {
                _masterPositionsRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
