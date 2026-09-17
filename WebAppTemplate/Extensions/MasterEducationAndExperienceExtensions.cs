using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterEducationAndExperienceExtensions
    {

        public static MasterEducationAndExperienceViewModel ToViewModel(this MasterEducationAndExperience Model)
        {
            return new MasterEducationAndExperienceViewModel
            {
                Id = Model.Id,
                Year = Model.Year,
                UniName = Model.UniName,
                Major = Model.Major,
                Keywrod = Model.Keywrod,
                Desc = Model.Desc,
                IsEdu = Model.IsEdu,
                isActive = Model.isActive,
            };
        }
        public static MasterEducationAndExperience ToModel(this MasterEducationAndExperienceViewModel Model)
        {
            return new MasterEducationAndExperience
            {
                Id = Model.Id,
                Year = Model.Year,
                UniName = Model.UniName,
                Major = Model.Major,
                Keywrod = Model.Keywrod,
                Desc = Model.Desc,
                IsEdu = Model.IsEdu,
                isActive = Model.isActive,
                    
            };
        }
        public static List<MasterEducationAndExperienceViewModel> ToViewModelList(this List<MasterEducationAndExperience> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterEducationAndExperience> ToModelList(this List<MasterEducationAndExperienceViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
