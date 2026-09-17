using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterAboutExtensions
    {
        public static MasterAboutViewModel ToViewModel(this MasterAbout Model)
        {
            return new MasterAboutViewModel
            {
                Id = Model.Id,
                Name = Model.Name,
                ImageUrl = Model.ImageUrl,
                CV_URL = Model.CV_URL,
                Desc = Model.Desc,
                DateOfBirth = Model.DateOfBirth,
                Country = Model.Country,
                Address = Model.Address,
                Email = Model.Email,
                isActive = Model.isActive,
                Phone = Model.Phone
            };
        }
        public static MasterAbout ToModel(this MasterAboutViewModel Model)
        {
            return new MasterAbout
            {
                Id = Model.Id,
                Name = Model.Name,
                ImageUrl = Model.ImageUrl,
                CV_URL = Model.CV_URL,
                Desc = Model.Desc,
                DateOfBirth = Model.DateOfBirth,
                Country = Model.Country,
                Address = Model.Address,
                Email = Model.Email,
                isActive = Model.isActive,
                Phone = Model.Phone
            };
        }
        public static List<MasterAbout> ToModelList(this List<MasterAboutViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
        public static List<MasterAboutViewModel> ToViewModelList(this List<MasterAbout> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
    }
}
