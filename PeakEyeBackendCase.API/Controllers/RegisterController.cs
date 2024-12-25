using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PeakEyeBackendCase.EntityLayer.Entities;

namespace PeakEyeBackendCase.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Register : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;

    public RegisterController(UserManager<User> userManager, IMapper mapper)
    {
        _mapper = mapper;
        _userManager = userManager;
    }
}