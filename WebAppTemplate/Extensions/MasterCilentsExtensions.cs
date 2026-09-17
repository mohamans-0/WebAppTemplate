using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterClientsExtensions
    {

        public static MasterCilentsViewModel ToViewModel(this MasterCilents Model)
        {
            return new MasterCilentsViewModel
            {
                Id = Model.Id,
                isActive = Model.isActive,
                imageURL= Model.imageURL,
                URL = Model.URL,
            };
        }
        public static MasterCilents ToModel(this MasterCilentsViewModel Model)
        {
            return new MasterCilents
            {
                Id = Model.Id,
                isActive = Model.isActive,
                imageURL = Model.imageURL,
                URL = Model.URL,
            };
        }
        public static List<MasterCilentsViewModel> ToViewModelList(this List<MasterCilents> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterCilents> ToModelList(this List<MasterCilentsViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
