using AutoMapper;
using HRMS.Entity.Entities;
using HRMS.ViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Services.AutoMapperService
{
    public class AutoMapperService: Profile
    {
        public AutoMapperService()
        {
            CreateMap<InterviewDetails, InterViewDetailsViewModel>().ReverseMap();
        }
    }
}
