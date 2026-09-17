using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterSkillsExtensions
    {

        public static MasterSkillsViewModel ToViewModel(this MasterSkills Model)
        {
            return new MasterSkillsViewModel
            {
                Id = Model.Id,
                isActive = Model.isActive,
                isCoding = Model.isCoding,
                isDesign = Model.isDesign,
                orderNumber = Model.orderNumber,
                Percentage = Model.Percentage,
                SkillName = Model.SkillName,
                                
            };
        }
        public static MasterSkills ToModel(this MasterSkillsViewModel Model)
        {
            return new MasterSkills
            {
                Id = Model.Id,
                isActive = Model.isActive,
                isCoding = Model.isCoding,
                isDesign = Model.isDesign,
                orderNumber = Model.orderNumber,
                Percentage = Model.Percentage,
                SkillName = Model.SkillName,
            };
        }
        public static List<MasterSkillsViewModel> ToViewModelList(this List<MasterSkills> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterSkills> ToModelList(this List<MasterSkillsViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
