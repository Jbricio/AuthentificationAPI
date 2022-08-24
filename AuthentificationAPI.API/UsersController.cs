using AuthentificationAPI.Contracts;
using AuthentificationAPI.DTOS;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IUsersService _userService;
		private IMapper _mapper;

		public UsersController(IUsersService usersService, IMapper mapper)
		{
			_userService = usersService;
			_mapper=mapper;
		}

		[AllowAnonymous]
		[HttpPost]
		[Route("authenticate")]
		
		public IActionResult GetAuthentication(UserRequest user,CancellationToken cancellation)
		{
			/*var obtainedUser = await _UserService.GetUser(user);
			return Ok(obtainedAssignment);*/
			//implementar automapper
			/*var comparedUser = await _repository.Company.GetById(company => company.Id == id);
			CompanyResponse companyResponse = _mapper.Map<CompanyResponse>(obtainedCompany);
			return companyResponse;
			var token = _jWTManager.Authenticate(user);

			if (token == null)
			{
				return Unauthorized();
			}

			return Ok(token);*/
			var validationUser=_userService.ValidateUser(user,cancellation);
			return Ok(validationUser);
		}
	}
}
