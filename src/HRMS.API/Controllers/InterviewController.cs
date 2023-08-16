using AutoMapper;
using HRMS.Entity.Entities;
using HRMS.ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.API.Controllers
{
    public class InterviewController : ControllerBase
    {
        private IMapper _mapper;
        private ILogger<InterviewController> _logger;
        public InterviewController(IMapper mapper, ILogger<InterviewController> logger)
        {

            _logger = logger;
            _mapper = mapper;

        }
        

        public List<InterViewDetailsViewModel> getAllData (InterViewDetailsViewModel interViewDetailsViewModel) {
            InterviewDetails data = _mapper.Map<InterviewDetails>(interViewDetailsViewModel);

            return new List<InterViewDetailsViewModel>();
        }
    }

}
