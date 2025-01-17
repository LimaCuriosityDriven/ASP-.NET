﻿using GestaoDeResiduos.Services;
using GestaoDeResiduos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GestaoDeResiduos.ViewModels.Responses;

namespace GestaoDeResiduos.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;


        public AuthController(IAuthService authService,  IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserViewModel request)
        {
            var user = await _authService.RegisterUserAsync(request);
            return Ok(new BaseApiResponse<UserViewModelResponse>("Usuário registrado com sucesso.", user));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel request)
        {
            var userViewModel = _mapper.Map<UserViewModel>(request);
            var loginResponse = await _authService.LoginUserAsync(userViewModel);

            return Ok(new BaseApiResponse<LoginViewModelResponse>("Login realizado com sucesso.", loginResponse));
            
        }
    }
}
