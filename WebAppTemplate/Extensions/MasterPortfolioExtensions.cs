using System.Collections.Generic;
using System.Linq;
using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;
namespace WebAppTemplate.Extensions
{
    public static class MasterPortfolioExtensions
    {

        public static MasterPortfolioViewModel ToViewModel(this MasterPortfolio Model)
        {
            return new MasterPortfolioViewModel
            {
                Id = Model.Id,
                CategoryId = Model.CategoryId,
                FirstImage = Model.FirstImage,
                Icon = Model.Icon,
                isActive = Model.isActive,
                SecondImage = Model.SecondImage,
                Title = Model.Title,
                Keyword = Model.Keyword,
            };
        }
        public static MasterPortfolio ToModel(this MasterPortfolioViewModel Model)
        {
            return new MasterPortfolio
            {
                Id = Model.Id,
                CategoryId = Model.CategoryId,
                FirstImage = Model.FirstImage,
                Icon = Model.Icon,
                isActive = Model.isActive,
                SecondImage = Model.SecondImage,
                Title = Model.Title,
                Keyword = Model.Keyword,

            };
        }
        public static List<MasterPortfolioViewModel> ToViewModelList(this List<MasterPortfolio> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterPortfolio> ToModelList(this List<MasterPortfolioViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
