using Application.Memo.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
	public class MemoController : ApiControllerBase
	{
		[HttpPost]
		public async Task<ActionResult<int>> Create(CreateMemoCommand createMemoCommand)
		{
			return await Mediator.Send(createMemoCommand);
		}
	}
}
