using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterPositionsExtensions
    {
        public static MasterPositionsViewModel ToViewModel(this MasterPositions Model)
        {
            return new MasterPositionsViewModel
            {
                Id = Model.Id,
                Name = Model.Name,
                isPrimary = Model.isPrimary,
                isActive = Model.isActive
            };
        }
        public static MasterPositions ToModel(this MasterPositionsViewModel Model)
        {
            return new MasterPositions
            {
                Id = Model.Id,
                Name = Model.Name,
                isPrimary = Model.isPrimary,
                isActive = Model.isActive
            };
        }
        public static List<MasterPositionsViewModel> ToViewModelList(this List<MasterPositions> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterPositions> ToModelList(this List<MasterPositionsViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
