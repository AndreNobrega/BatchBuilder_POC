using MediatR;

namespace Application.Memo.Commands;

public record InsertMemoCommand : IRequest<Domain.Entities.Memo>;

internal class InsertMemoCommandHandler : IRequestHandler<InsertMemoCommand, Domain.Entities.Memo>
{
	public Task<Domain.Entities.Memo> Handle(InsertMemoCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}