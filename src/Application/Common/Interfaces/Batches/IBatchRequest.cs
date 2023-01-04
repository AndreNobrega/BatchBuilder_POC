using Domain.Enums;

namespace Application.Common.Interfaces.Batches
{
	public interface IBatchRequest
	{
		public string? BatchId { get; set; }
		public BatchType BatchType { get; set; }
	}
}
