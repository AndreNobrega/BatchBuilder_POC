namespace Application.Common.Interfaces.Batches
{
	internal interface IBatchBuilderDirector
	{
		internal BatchBase BuildBatch(IBatchRequest request);
	}
}
