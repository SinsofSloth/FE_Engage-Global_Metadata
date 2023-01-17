// Namespace: UniRx
public interface IAsyncMessagePublisher // TypeDefIndex: 6565
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IObservable<Unit> PublishAsync<T>(T message);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncMessagePublisher.PublishAsync<object>
	*/
}

