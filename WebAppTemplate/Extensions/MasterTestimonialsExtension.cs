using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterTestimonialsExtensions
    {
        public static MasterTestimonialsViewModel ToViewModel(this MasterTestimonials Model)
        {
            return new MasterTestimonialsViewModel
            {
                Id = Model.Id,
                Name = Model.Name,
                isActive = Model.isActive,
                ImageUrl = Model.ImageUrl,
                Desc = Model.Desc,
                Company = Model.Company,
                Keyword = Model.Keyword,
            };
        }
        public static MasterTestimonials ToModel(this MasterTestimonialsViewModel Model)
        {
            return new MasterTestimonials
            {
                Id = Model.Id,
                Name = Model.Name,
                isActive = Model.isActive,
                ImageUrl = Model.ImageUrl,
                Desc = Model.Desc,
                Company = Model.Company,
                Keyword = Model.Keyword,
            };
        }
        public static List<MasterTestimonialsViewModel> ToViewModelList(this List<MasterTestimonials> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterTestimonials> ToModelList(this List<MasterTestimonialsViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
