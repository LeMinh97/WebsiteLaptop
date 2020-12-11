using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.IRepositories;
using WebsiteLaptop.Infrastructure.Interfaces;
using WebsiteLaptop.Service.Interfaces;
using WebsiteLaptop.Service.ViewModels.Common;
using WebsiteLaptop.Utilities.Constants;

namespace WebsiteLaptop.Service.Implementation
{
    public class CommonService : ICommonService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;
        ISlideRepository _slideRepository;
        private readonly IMapper _mapper;
        public CommonService(IFooterRepository footerRepository,
            IUnitOfWork unitOfWork, IMapper mapper,
            ISlideRepository slideRepository)
        {
            _footerRepository = footerRepository;
            _unitOfWork = unitOfWork;
            _slideRepository = slideRepository;
            _mapper = mapper;
        }

        public FooterViewModel GetFooter()
        {
            return _mapper.Map<Footer, FooterViewModel>(_footerRepository.FindSingle(x => x.Id ==
            CommonConstants.DefaultFooterId));
        }

        public List<SlideViewModel> GetSlides(string groupAlias)
        {
            return _mapper.ProjectTo<SlideViewModel>(_slideRepository.FindAll(x => x.Status && x.GroupAlias == groupAlias)).ToList();
        }
    }
}
