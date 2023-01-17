// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 1193
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0x33A5B80 Offset: 0x33A5C81 VA: 0x33A5B80
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x33A5BD0 Offset: 0x33A5CD1 VA: 0x33A5BD0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x33A5EA0 Offset: 0x33A5FA1 VA: 0x33A5EA0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

