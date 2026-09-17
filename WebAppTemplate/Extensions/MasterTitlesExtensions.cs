using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterTitlesExtensions
    {
        public static MasterTitlesViewModel ToViewModel(this MasterTitles Model)
        {
            return new MasterTitlesViewModel
            {
                Id = Model.Id,
                Title = Model.Title,
                keyword = Model.keyword,
                isActive = Model.isActive
            };
        }
        public static MasterTitles ToModel(this MasterTitlesViewModel Model)
        {
            return new MasterTitles
            {
                Id = Model.Id,
                Title = Model.Title,
                keyword = Model.keyword,
                isActive = Model.isActive

            };
        }
        public static List<MasterTitlesViewModel> ToViewModelList(this List<MasterTitles> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterTitles> ToModelList(this List<MasterTitlesViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
