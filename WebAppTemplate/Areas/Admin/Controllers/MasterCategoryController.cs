using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Extensions;
using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;
using WebAppTemplate.Repository;

namespace WebAppTemplate.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize]
    public class MasterCategoryController : Controller
    {

        iRepository<MasterCategory> iMasterCategoryRepository;

        public MasterCategoryController(iRepository<MasterCategory> iMasterCategoryRepository)
        {
            this.iMasterCategoryRepository = iMasterCategoryRepository;
        }

        // GET: MasterCategoryController
        public ActionResult Index()
        {
            return View(iMasterCategoryRepository.View().ToViewModelList());
        }

        // GET: MasterCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View(iMasterCategoryRepository.Find(id).ToViewModel());
        }

        // GET: MasterCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterCategoryViewModel collection)
        {
            try
            {
                iMasterCategoryRepository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(iMasterCategoryRepository.Find(id).ToViewModel());
        }

        // POST: MasterCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterCategoryViewModel collection)
        {
            try
            {
                iMasterCategoryRepository.Update(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(iMasterCategoryRepository.Find(id).ToViewModel());
        }

        // POST: MasterCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                iMasterCategoryRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: MasterCategoryController/Delete/5
        public ActionResult ActivationsStatus(int id)
        {
            return View(iMasterCategoryRepository.Find(id).ToViewModel());
        }

        // POST: MasterCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, IFormCollection collection)
        {
            try
            {
                iMasterCategoryRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
