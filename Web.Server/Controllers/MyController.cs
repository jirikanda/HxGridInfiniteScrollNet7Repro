using System.Security.Claims;
using Havit.NewProjectTemplate.Contracts.Infrastructure.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Havit.NewProjectTemplate.Web.Server.Controllers;

[AllowAnonymous]
public class MyController : ControllerBase
{
	[HttpGet("/slow")]
	public async Task Get(CancellationToken cancellationToken)
	{
		await Task.Delay(50, cancellationToken);
	}
}
