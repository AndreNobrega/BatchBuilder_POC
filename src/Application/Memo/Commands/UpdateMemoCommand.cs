using MediatR;

namespace Application.Memo.Commands
{
	public record UpdateMemoCommand : IRequest<Domain.Entities.Memo>;
}
