using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PalindromWord.Api.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromWord.services.Controllers
{
    public class BaseApiController : Controller
    {
        protected readonly IUnitOfWork UnitOfWork = null;
        protected readonly IMapper Mapper;
        protected internal BaseApiController()
        {

        }
        public BaseApiController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.UnitOfWork = unitOfWork;
            this.Mapper = mapper;
          
        }
    }
}
