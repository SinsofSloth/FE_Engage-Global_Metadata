// Namespace: UniRx
public class AsyncMessageBroker : IAsyncMessageBroker, IAsyncMessagePublisher, IAsyncMessageReceiver, IDisposable // TypeDefIndex: 6570
{
	// Fields
	public static readonly IAsyncMessageBroker Default; // 0x0
	private bool isDisposed; // 0x10
	private readonly Dictionary<Type, object> notifiers; // 0x18

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public IObservable<Unit> PublishAsync<T>(T message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2735010 Offset: 0x2735111 VA: 0x2735010
	|-AsyncMessageBroker.PublishAsync<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IDisposable Subscribe<T>(Func<T, IObservable<Unit>> asyncMessageReceiver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27353E0 Offset: 0x27354E1 VA: 0x27353E0
	|-AsyncMessageBroker.Subscribe<object>
	*/

	// RVA: 0x19CCAD0 Offset: 0x19CCBD1 VA: 0x19CCAD0 Slot: 6
	public void Dispose() { }

	// RVA: 0x19CCBE0 Offset: 0x19CCCE1 VA: 0x19CCBE0
	public void .ctor() { }

	// RVA: 0x19CCC70 Offset: 0x19CCD71 VA: 0x19CCC70
	private static void .cctor() { }
}

