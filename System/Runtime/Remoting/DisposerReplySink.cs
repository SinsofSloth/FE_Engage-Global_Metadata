// Namespace: System.Runtime.Remoting
internal class DisposerReplySink : IMessageSink // TypeDefIndex: 1111
{
	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x372A070 Offset: 0x372A171 VA: 0x372A070
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x372A0C0 Offset: 0x372A1C1 VA: 0x372A0C0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x372A1F0 Offset: 0x372A2F1 VA: 0x372A1F0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

