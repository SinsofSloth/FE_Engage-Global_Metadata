// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class EnvoyTerminatorSink : IMessageSink // TypeDefIndex: 1197
{
	// Fields
	public static EnvoyTerminatorSink Instance; // 0x0

	// Methods

	// RVA: 0x3B5F8F0 Offset: 0x3B5F9F1 VA: 0x3B5F8F0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x3B5F9B0 Offset: 0x3B5FAB1 VA: 0x3B5F9B0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x3B5FA80 Offset: 0x3B5FB81 VA: 0x3B5FA80
	public void .ctor() { }

	// RVA: 0x3B5FA90 Offset: 0x3B5FB91 VA: 0x3B5FA90
	private static void .cctor() { }
}

