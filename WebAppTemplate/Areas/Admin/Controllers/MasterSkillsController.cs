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
    public class MasterSkillsController : Controller
    {
        iRepository<MasterSkills> iMasterSkillsRepository;

        public MasterSkillsController(iRepository<MasterSkills> iMasterSkillsRepository)
        {
            this.iMasterSkillsRepository = iMasterSkillsRepository;
        }

        // GET: MasterSkillsController
        public ActionResult Index()
        {
            return View(iMasterSkillsRepository.View().ToViewModelList());
        }

        // GET: MasterSkillsController/Details/5
        public ActionResult Details(int id)
        {
            return View(iMasterSkillsRepository.Find(id).ToViewModel());
        }

        // GET: MasterSkillsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterSkillsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterSkillsViewModel collection)
        {
            try
            {
                iMasterSkillsRepository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSkillsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(iMasterSkillsRepository.Find(id).ToViewModel());
        }

        // POST: MasterSkillsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterSkillsViewModel collection)
        {
            try
            {
                iMasterSkillsRepository.Update(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSkillsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(iMasterSkillsRepository.Find(id).ToViewModel());
        }

        // POST: MasterSkillsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterSkillsViewModel collection)
        {
            try
            {
                iMasterSkillsRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ActivationsStatus(int id)
        {
            return View(iMasterSkillsRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, IFormCollection collection)
        {
            try
            {
                iMasterSkillsRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
