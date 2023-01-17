// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 1223
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0x361C4E0 Offset: 0x361C5E1 VA: 0x361C4E0
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x361C530 Offset: 0x361C631 VA: 0x361C530 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x361C600 Offset: 0x361C701 VA: 0x361C600 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

