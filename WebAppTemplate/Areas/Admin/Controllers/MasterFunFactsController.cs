using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Extensions;
using WebAppTemplate.Models;
using WebAppTemplate.Repository;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize]
    public class MasterFunFactsController : Controller
    {

        iRepository<MasterFunFacts> iMasterFunFactsRepository;

        public MasterFunFactsController(iRepository<MasterFunFacts> iMasterFunFactsRepository)
        {
            this.iMasterFunFactsRepository = iMasterFunFactsRepository;
        }

        // GET: MasterFunFactsController
        public ActionResult Index()
        {
            return View(iMasterFunFactsRepository.View().ToViewModelList());
        }

        // GET: MasterFunFactsController/Details/5
        public ActionResult Details(int id)
        {
            return View(iMasterFunFactsRepository.Find(id).ToViewModel());
        }

        // GET: MasterFunFactsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterFunFactsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterFunFactsViewModel collection)
        {
            try
            {
                iMasterFunFactsRepository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterFunFactsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(iMasterFunFactsRepository.Find(id).ToViewModel());
        }

        // POST: MasterFunFactsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterFunFactsViewModel collection)
        {
            try
            {
                iMasterFunFactsRepository.Update(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterFunFactsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(iMasterFunFactsRepository.Find(id).ToViewModel());
        }

        // POST: MasterFunFactsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                iMasterFunFactsRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterFunFactsController/Delete/5
        public ActionResult ActivationsStatus(int id)
        {
            return View(iMasterFunFactsRepository.Find(id).ToViewModel());
        }

        // POST: MasterFunFactsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, IFormCollection collection)
        {
            try
            {
                iMasterFunFactsRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
