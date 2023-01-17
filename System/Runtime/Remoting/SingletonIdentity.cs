// Namespace: System.Runtime.Remoting
internal class SingletonIdentity : ServerIdentity // TypeDefIndex: 1109
{
	// Methods

	// RVA: 0x3825980 Offset: 0x3825A81 VA: 0x3825980
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x3825990 Offset: 0x3825A91 VA: 0x3825990
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x3825BA0 Offset: 0x3825CA1 VA: 0x3825BA0 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x3825CA0 Offset: 0x3825DA1 VA: 0x3825CA0 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

