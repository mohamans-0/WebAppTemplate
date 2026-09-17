using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterFunFactsExtensions
    {
        public static MasterFunFactsViewModel ToViewModel(this MasterFunFacts Model)
        {
            return new MasterFunFactsViewModel
            {
                Id = Model.Id,
                isActive = Model.isActive,
                Icon = Model.Icon,
                Title = Model.Title,
                Number = Model.Number,
                Keyword = Model.Keyword,
            };
        }
        public static MasterFunFacts ToModel(this MasterFunFactsViewModel Model)
        {
            return new MasterFunFacts
            {
                Id = Model.Id,
                isActive = Model.isActive,
                Icon = Model.Icon,
                Title = Model.Title,
                Number = Model.Number,
                Keyword = Model.Keyword,
            };
        }
        public static List<MasterFunFactsViewModel> ToViewModelList(this List<MasterFunFacts> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterFunFacts> ToModelList(this List<MasterFunFactsViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
