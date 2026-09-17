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
    public class MasterCilentsController : Controller
    {
        iRepository<MasterCilents> iMasterCilentsRepository;
        iFileHelper iFileHelper;

        public MasterCilentsController(iRepository<MasterCilents> iMasterCilentsRepository, iFileHelper iFileHelper)
        {
            this.iMasterCilentsRepository = iMasterCilentsRepository;
            this.iFileHelper = iFileHelper;
        }

        // GET: MasterCilentsController
        public ActionResult Index()
        {
            return View(iMasterCilentsRepository.View().ToViewModelList());
        }

        // GET: MasterCilentsController/Details/5
        public ActionResult Details(int id)
        {
            return View(iMasterCilentsRepository.Find(id).ToViewModel());
        }

        // GET: MasterCilentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterCilentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterCilentsViewModel collection)
        {
            try
            {
                var imageName = iFileHelper.SaveImage(collection.imageFile, "MasterClientsImages", null);
                var data = collection.ToModel();
                data.imageURL = imageName;

                iMasterCilentsRepository.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCilentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(iMasterCilentsRepository.Find(id).ToViewModel());
        }

        // POST: MasterCilentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterCilentsViewModel collection)
        {
            try
            {
                var data = iMasterCilentsRepository.Find(id);

                data.URL = collection.URL;
                data.isActive = collection.isActive;

                if (collection.imageFile != null)
                {
                    var imageName = iFileHelper.SaveImage(
                        collection.imageFile,
                        "MasterClientsImages",
                        null
                    );

                    data.imageURL = imageName;
                }

                iMasterCilentsRepository.Update(data);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }
        

        // GET: MasterCilentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(iMasterCilentsRepository.Find(id).ToViewModel());
        }

        // POST: MasterCilentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterCilentsViewModel collection)
        {
            try
            {
                iMasterCilentsRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ActivationsStatus(int id)
        {
            return View(iMasterCilentsRepository.Find(id).ToViewModel());
        }

        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, IFormCollection collection)
        {
            try
            {
                iMasterCilentsRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
