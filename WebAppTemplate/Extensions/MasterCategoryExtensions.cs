using System.Collections.Generic;
using System.Linq;
using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterCategoryExtensions
    {

        public static MasterCategoryViewModel ToViewModel(this MasterCategory Model)
        {
            return new MasterCategoryViewModel
            {
                Id = Model.Id,
                CategoryName = Model.CategoryName,
                isActive = Model.isActive,
                Keywrod = Model.Keywrod,
            };
        }
        public static MasterCategory ToModel(this MasterCategoryViewModel Model)
        {
            return new MasterCategory
            {
                Id = Model.Id,
                CategoryName = Model.CategoryName,
                isActive = Model.isActive,
                Keywrod = Model.Keywrod,

            };
        }
        public static List<MasterCategoryViewModel> ToViewModelList(this List<MasterCategory> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterCategory> ToModelList(this List<MasterCategoryViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
