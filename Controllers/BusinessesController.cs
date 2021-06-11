using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BizzWhizzApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BizzWhizzApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BusinessesController : ControllerBase
    {
        private readonly BizzWhizzApiContext _db;

        public BusinessesController(BizzWhizzApiContext db)
        {
            _db = db; 
        }
    }

}
