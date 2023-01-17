// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 1222
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x361C640 Offset: 0x361C741 VA: 0x361C640
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x361C680 Offset: 0x361C781 VA: 0x361C680 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x361C800 Offset: 0x361C901 VA: 0x361C800 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

