using Microsoft.AspNetCore.Mvc;
using Application.Memo.Commands;

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
