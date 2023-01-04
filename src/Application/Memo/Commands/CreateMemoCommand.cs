using Domain.Entities;
using MediatR;

namespace Application.Memo.Commands;

public record CreateMemoCommand : IRequest<int>
{
	public Person? Owner { get; internal set; }
	public string? Title { get; internal set; }
	public string? Content { get; internal set; }
	public List<Person> Recipients { get; internal set; } = new List<Person>();
}

//internal class CreateMemoCommandHandler : IRequestHandler<CreateMemoCommand, int>
//{
//	private readonly IApplicationDbContext _context;

//	public CreateMemoCommandHandler(IApplicationDbContext context)
//	{
//		_context = context;
//	}

//	public async Task<int> Handle(CreateMemoCommand request, CancellationToken cancellationToken)
//	{
//		var entity = new Domain.Entities.Memo
//		{
//			Title = request.Title,
//			Content = request.Content,
//			Owner = request.Owner,
//			Recipients = request.Recipients
//		};

//		_context.Memos.Add(entity);
//		await _context.SaveChangesAsync(cancellationToken);

//		return entity.Id;
//	}
//}