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
    public class MasterEducationAndExperienceController : Controller
    {
        iRepository<MasterEducationAndExperience> iMasterEducationAndExperienceRepository;

        public MasterEducationAndExperienceController(iRepository<MasterEducationAndExperience> iMasterEducationAndExperienceRepository)
        {
            this.iMasterEducationAndExperienceRepository = iMasterEducationAndExperienceRepository;
        }


        // GET: MasterEducationAndExperienceController
        public ActionResult Index()
        {
            return View(iMasterEducationAndExperienceRepository.View().ToViewModelList());
        }

        // GET: MasterEducationAndExperienceController/Details/5
        public ActionResult Details(int id)
        {
            return View(iMasterEducationAndExperienceRepository.Find(id).ToViewModel());
        }

        // GET: MasterEducationAndExperienceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterEducationAndExperienceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterEducationAndExperienceViewModel collection)
        {
            try
            {
                iMasterEducationAndExperienceRepository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterEducationAndExperienceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(iMasterEducationAndExperienceRepository.Find(id).ToViewModel());
        }

        // POST: MasterEducationAndExperienceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterEducationAndExperienceViewModel collection)
        {
            try
            {
                iMasterEducationAndExperienceRepository.Update(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterEducationAndExperienceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(iMasterEducationAndExperienceRepository.Find(id).ToViewModel());
        }

        // POST: MasterEducationAndExperienceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterEducationAndExperienceViewModel collection)
        {
            try
            {
                iMasterEducationAndExperienceRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: MasterEducationAndExperienceController/Delete/5
        public ActionResult ActivationsStatus(int id)
        {
            return View(iMasterEducationAndExperienceRepository.Find(id).ToViewModel());
        }

        // POST: MasterEducationAndExperienceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, MasterEducationAndExperienceViewModel collection)
        {
            try
            {
                iMasterEducationAndExperienceRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
