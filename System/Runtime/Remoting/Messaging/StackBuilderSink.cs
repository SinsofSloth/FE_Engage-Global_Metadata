// Namespace: System.Runtime.Remoting.Messaging
internal class StackBuilderSink : IMessageSink // TypeDefIndex: 1224
{
	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x382F6E0 Offset: 0x382F7E1 VA: 0x382F6E0
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x382F7D0 Offset: 0x382F8D1 VA: 0x382F7D0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x382FCB0 Offset: 0x382FDB1 VA: 0x382FCB0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x382FDF0 Offset: 0x382FEF1 VA: 0x382FDF0
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x382F8C0 Offset: 0x382F9C1 VA: 0x382F8C0
	private void CheckParameters(IMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x47D2C0 Offset: 0x47D3C1 VA: 0x47D2C0
	// RVA: 0x3830020 Offset: 0x3830121 VA: 0x3830020
	private void <AsyncProcessMessage>b__4_0(object data) { }
}

