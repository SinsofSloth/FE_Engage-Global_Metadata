// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 1192
{
	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x33A5EE0 Offset: 0x33A5FE1 VA: 0x33A5EE0
	public void .ctor(Context ctx) { }

	// RVA: 0x33A5F20 Offset: 0x33A6021 VA: 0x33A5F20 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x33A6160 Offset: 0x33A6261 VA: 0x33A6160 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

