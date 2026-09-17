using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterSocialMdeiaExtensions
    {
        public static MasterSocialMediaViewModel ToViewModel(this MasterSocialMedia Model)
        {
            return new MasterSocialMediaViewModel
            {
                Id = Model.Id,
                Icon = Model.Icon,
                Url = Model.Url,
                isActive = Model.isActive,
                isSocialMedia = Model.isSocialMedia,
                Keyword = Model.Keyword,
                Title = Model.Title,
            };
        }
        public static MasterSocialMedia ToModel(this MasterSocialMediaViewModel Model)
        {
            return new MasterSocialMedia
            {
                Id = Model.Id,
                Icon = Model.Icon,
                Url = Model.Url,
                isActive = Model.isActive,
                isSocialMedia = Model.isSocialMedia,
                Keyword = Model.Keyword,
                Title = Model.Title,

            };
        }
        public static List<MasterSocialMediaViewModel> ToViewModelList (this List<MasterSocialMedia> Model)
        {
            return Model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<MasterSocialMedia> ToModelList(this List<MasterSocialMediaViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
