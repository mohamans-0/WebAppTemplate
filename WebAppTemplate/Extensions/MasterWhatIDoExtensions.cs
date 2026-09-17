
using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterWhatIDoExtensions
    {
        public static MasterWhatIDoViewModel ToViewModel(this MasterWhatIDo Model)
        {
            return new MasterWhatIDoViewModel
            {
                Id = Model.Id,
                isActive = Model.isActive,
                Icon = Model.Icon,
                Title = Model.Title,
                Desc = Model.Desc
            };
        }
        public static MasterWhatIDo ToModel(this MasterWhatIDoViewModel Model)
        {
            return new MasterWhatIDo
            {
                Id = Model.Id,
                isActive = Model.isActive,
                Icon = Model.Icon,
                Title = Model.Title,
                Desc = Model.Desc
            };
        }
        public static List<MasterWhatIDoViewModel> ToViewModelList(this List<MasterWhatIDo> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterWhatIDo> ToModelList(this List<MasterWhatIDoViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
