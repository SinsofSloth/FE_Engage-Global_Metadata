// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseSink : IMessageSink // TypeDefIndex: 1130
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x341D850 Offset: 0x341D951 VA: 0x341D850
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x341D890 Offset: 0x341D991 VA: 0x341D890 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x341DC10 Offset: 0x341DD11 VA: 0x341DC10 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x341D950 Offset: 0x341DA51 VA: 0x341D950
	private void RenewLease(IMessage msg) { }
}

