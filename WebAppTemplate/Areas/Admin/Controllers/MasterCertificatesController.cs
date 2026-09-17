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
    public class MasterCertificatesController : Controller
    {

        iRepository<MasterCertificates> iMasterCertificatesRepository;
        iFileHelper iFileHelper;
        public MasterCertificatesController(iRepository<MasterCertificates> iMasterCertificatesRepository, iFileHelper iFileHelper)
        {
            this.iMasterCertificatesRepository = iMasterCertificatesRepository;
            this.iFileHelper = iFileHelper;
        }

        // GET: MasterCertificatesController
        public ActionResult Index()
        {
            return View(iMasterCertificatesRepository.View().ToViewModelList());
        }

        // GET: MasterCertificatesController/Details/5
        public ActionResult Details(int id)
        {
            return View(iMasterCertificatesRepository.Find(id).ToViewModel());
        }

        // GET: MasterCertificatesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterCertificatesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterCertificatesViewModel collection)
        {
            try
            {
                var imageName = iFileHelper.SaveImage(collection.ImageFile, "CertificatesImages", null);
                var data = collection.ToModel();
                data.ImageURL = imageName;
                iMasterCertificatesRepository.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCertificatesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(iMasterCertificatesRepository.Find(id).ToViewModel());
        }

        // POST: MasterCertificatesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterCertificatesViewModel collection)
        {
            try
            {
                var imageName = iFileHelper.SaveImage(collection.ImageFile, "CertificatesImages", collection.ImageURL);
                var data = collection.ToModel();
                data.ImageURL = imageName;
                iMasterCertificatesRepository.Update(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCertificatesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(iMasterCertificatesRepository.Find(id).ToViewModel());
        }

        // POST: MasterCertificatesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterCertificatesViewModel collection)
        {
            try
            {
                iMasterCertificatesRepository.Delete(id);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: MasterCertificatesController/Delete/5
        public ActionResult ActivationsStatus(int id)
        {
            return View(iMasterCertificatesRepository.Find(id).ToViewModel());
        }

        // POST: MasterCertificatesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActivationsStatus(int id, MasterCertificatesViewModel collection)
        {
            try
            {
                iMasterCertificatesRepository.changeStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
