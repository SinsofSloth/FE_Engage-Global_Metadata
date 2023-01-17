// Namespace: 
private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 1137
{
	// Fields
	private IMessageSink _next; // 0x10
	private Context _context; // 0x18
	private IMessage _call; // 0x20

	// Methods

	// RVA: 0x35E6BC0 Offset: 0x35E6CC1 VA: 0x35E6BC0
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x35E6C30 Offset: 0x35E6D31 VA: 0x35E6C30 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x35E6F10 Offset: 0x35E7011 VA: 0x35E6F10 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

