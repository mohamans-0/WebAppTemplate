using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterCertificatesExtensions
    {

        public static MasterCertificatesViewModel ToViewModel(this MasterCertificates Model)
        {
            return new MasterCertificatesViewModel
            {
                Id = Model.Id, 
                CertificationName = Model.CertificationName,
                ImageURL = Model.ImageURL,
                Date = Model.Date,
                Keyword = Model.Keyword,
                isActive = Model.isActive,
                MemberId = Model.MemberId,                      
            };
        }
        public static MasterCertificates ToModel(this MasterCertificatesViewModel Model)
        {
            return new MasterCertificates
            {
                Id = Model.Id,
                CertificationName = Model.CertificationName,
                ImageURL = Model.ImageURL,
                Date = Model.Date,
                Keyword = Model.Keyword,
                isActive = Model.isActive,
                MemberId = Model.MemberId,
            };
        }
        public static List<MasterCertificatesViewModel> ToViewModelList(this List<MasterCertificates> Model)
        {
            return Model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<MasterCertificates> ToModelList(this List<MasterCertificatesViewModel> Model)
        {
            return Model.Select(x => x.ToModel()).ToList();
        }
    }
}
