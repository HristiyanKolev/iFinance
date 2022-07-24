using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace iFinanceAPI.Controllers
{
    /// <summary>
    /// Finance Control functionality
    /// </summary>
    [Route("/api/[Controller]")]
    [ApiController]
    public class FinanceControlController : ControllerBase
    {
        private readonly IMapper _mapper;

    }
}
