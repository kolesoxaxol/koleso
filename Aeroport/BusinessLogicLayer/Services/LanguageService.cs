using AirModel.SiteLocalization;
using BusinessLogicLayer.Services.IServices;
using BusinessLogicLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class LanguageService : ILanguageService
    {

        private readonly IUnitOfWork _unitOfWork;

        public LanguageService(IUnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        public Language Get(string langCode)
        {
            return _unitOfWork.LanguageRepository.Get().FirstOrDefault(x => x.Code == langCode);
        }

        public List<Language> GetAllLanguages()
        {
            return _unitOfWork.LanguageRepository.Get(a => a.Code != "en").ToList();
        }

    }
}
