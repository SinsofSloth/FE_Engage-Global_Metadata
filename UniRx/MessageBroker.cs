// Namespace: UniRx
public class MessageBroker : IMessageBroker, IMessagePublisher, IMessageReceiver, IDisposable // TypeDefIndex: 6568
{
	// Fields
	public static readonly IMessageBroker Default; // 0x0
	private bool isDisposed; // 0x10
	private readonly Dictionary<Type, object> notifiers; // 0x18

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Publish<T>(T message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29668E0 Offset: 0x29669E1 VA: 0x29668E0
	|-MessageBroker.Publish<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IObservable<T> Receive<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2966B40 Offset: 0x2966C41 VA: 0x2966B40
	|-MessageBroker.Receive<object>
	*/

	// RVA: 0x19D5DE0 Offset: 0x19D5EE1 VA: 0x19D5DE0 Slot: 6
	public void Dispose() { }

	// RVA: 0x19D5EF0 Offset: 0x19D5FF1 VA: 0x19D5EF0
	public void .ctor() { }

	// RVA: 0x19D5F80 Offset: 0x19D6081 VA: 0x19D5F80
	private static void .cctor() { }
}

