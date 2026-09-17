using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Extensions;
using WebAppTemplate.Models;
using WebAppTemplate.Repository;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        iRepository<MasterAbout> _MasterAboutRepository;
        iRepository<MasterTitles> _MasterTitlesRepository;
        iRepository<MasterSocialMedia> _MasterSocialMediaRepository;
        iRepository<MasterPositions> _MasterPositionsRepository;
        iRepository<MasterTestimonials> _MasterTestimonialsRepository;
        iRepository<MasterCilents> _MasterCilentsRepository;
        iRepository<MasterWhatIDo> _MasterWhatIDoRepository;
        iRepository<MasterFunFacts> _MasterFunFactsRepository;
        iRepository<MasterEducationAndExperience> _MasterEducationAndExperienceExtensionsRepository;
        iRepository<MasterSkills> _MasterSkillsRepository;
        iRepository<MasterCertificates> iMasterCertificatesRepository;

        public HomeController(ILogger<HomeController> logger, iRepository<MasterAbout> masterAboutRepository, iRepository<MasterTitles> masterTitlesRepository, iRepository<MasterSocialMedia> masterSocialMediaRepository, iRepository<MasterPositions> masterPositionsRepository, iRepository<MasterTestimonials> masterTestimonialsRepository, iRepository<MasterCilents> masterCilentsRepository, iRepository<MasterWhatIDo> masterWhatIDoRepository, iRepository<MasterFunFacts> masterFunFactsRepository, iRepository<MasterEducationAndExperience> masterEducationAndExperienceExtensionsRepository, iRepository<MasterSkills> masterSkillsRepository, iRepository<MasterCertificates> iMasterCertificatesRepository)
        {
            _logger = logger;
            _MasterAboutRepository = masterAboutRepository;
            _MasterTitlesRepository = masterTitlesRepository;
            _MasterSocialMediaRepository = masterSocialMediaRepository;
            _MasterPositionsRepository = masterPositionsRepository;
            _MasterTestimonialsRepository = masterTestimonialsRepository;
            _MasterCilentsRepository = masterCilentsRepository;
            _MasterWhatIDoRepository = masterWhatIDoRepository;
            _MasterFunFactsRepository = masterFunFactsRepository;
            _MasterEducationAndExperienceExtensionsRepository = masterEducationAndExperienceExtensionsRepository;
            _MasterSkillsRepository = masterSkillsRepository;
            this.iMasterCertificatesRepository = iMasterCertificatesRepository;
        }

        public IActionResult Index()
        {
            var obj = new HomeViewModel
            {
                MasterAboutViewModel = _MasterAboutRepository.ViewClinet().ToViewModelList().FirstOrDefault(),
                MasterTitles = _MasterTitlesRepository.ViewClinet().ToViewModelList(),
                MasterPositions = _MasterPositionsRepository.ViewClinet().ToViewModelList(),
                MasterSocialMedia = _MasterSocialMediaRepository.ViewClinet().ToViewModelList(),
                MasterTestimonials = _MasterTestimonialsRepository.ViewClinet().ToViewModelList(),
                MasterCilents = _MasterCilentsRepository.ViewClinet().ToViewModelList(),
                MasterWhatIDo = _MasterWhatIDoRepository.ViewClinet().ToViewModelList(),
                MasterFunFacts = _MasterFunFactsRepository.ViewClinet().ToViewModelList(),
                masterEducationAndExperienceViewModels = _MasterEducationAndExperienceExtensionsRepository.ViewClinet().ToViewModelList(),
                MasterSkills = _MasterSkillsRepository.ViewClinet().ToViewModelList(),
                MasterCertificates = iMasterCertificatesRepository.ViewClinet().ToViewModelList(),   

            };

            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
