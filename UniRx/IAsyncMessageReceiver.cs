// Namespace: UniRx
public interface IAsyncMessageReceiver // TypeDefIndex: 6566
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDisposable Subscribe<T>(Func<T, IObservable<Unit>> asyncMessageReceiver);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncMessageReceiver.Subscribe<object>
	*/
}

