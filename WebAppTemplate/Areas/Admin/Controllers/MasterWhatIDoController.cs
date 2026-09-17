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
    public class MasterWhatIDoController : Controller
    {
        iRepository<MasterWhatIDo> iMasterWhatIDoRepository;

        public MasterWhatIDoController(iRepository<MasterWhatIDo> iMasterWhatIDoRepository)
        {
            this.iMasterWhatIDoRepository = iMasterWhatIDoRepository;
        }


        // GET: MasterWhatIDoController
        public ActionResult Index()
        {
            return View(iMasterWhatIDoRepository.View().ToViewModelList());
        }

        // GET: MasterWhatIDoController/Details/5
        public ActionResult Details(int id)
        {
            return View(iMasterWhatIDoRepository.Find(id).ToViewModel());
        }

        // GET: MasterWhatIDoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterWhatIDoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterWhatIDoViewModel collection)
        {
            try
            {
                iMasterWhatIDoRepository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterWhatIDoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(iMasterWhatIDoRepository.Find(id).ToViewModel());
        }

        // POST: MasterWhatIDoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterWhatIDoViewModel collection)
        {
            try
            {
                iMasterWhatIDoRepository.Update(collection.ToModel());  
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterWhatIDoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(iMasterWhatIDoRepository.Find(id).ToViewModel());
        }

        // POST: MasterWhatIDoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterWhatIDoViewModel collection)
        {
            try
            {
                iMasterWhatIDoRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ActivationsStatus(int id)
        {
            return View(iMasterWhatIDoRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, IFormCollection collection)
        {
            try
            {
                iMasterWhatIDoRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
