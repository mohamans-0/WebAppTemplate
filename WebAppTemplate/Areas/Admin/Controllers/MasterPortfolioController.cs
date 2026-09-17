using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Extensions;
using WebAppTemplate.Models;
using WebAppTemplate.Repository;

namespace WebAppTemplate.Areas.Admin.Controllers
{


    [Area("Admin")]
    [Authorize]
    public class MasterPortfolioController : Controller
    {

        iRepository<MasterPortfolio> iMasterPortfolioRepository;
        iRepository<MasterCategory> iMasterCategoryRepository;

        public MasterPortfolioController(iRepository<MasterPortfolio> iMasterPortfolioRepository, iRepository<MasterCategory> iMasterCategoryRepository)
        {
            this.iMasterPortfolioRepository = iMasterPortfolioRepository;
            this.iMasterCategoryRepository = iMasterCategoryRepository;
        }


        // GET: MasterPortfolioController
        public ActionResult Index()
        {
            return View(iMasterPortfolioRepository.View().ToViewModelList());
        }

        // GET: MasterPortfolioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MasterPortfolioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterPortfolioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterPortfolioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MasterPortfolioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterPortfolioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MasterPortfolioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
