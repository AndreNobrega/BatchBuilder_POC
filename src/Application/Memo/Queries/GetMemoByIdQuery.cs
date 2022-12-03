using MediatR;

namespace Application.Memo.Queries
{
	public record GetMemoByIdQuery() : IRequest<Domain.Entities.Memo>;
}
