// Namespace: System.Runtime.Remoting
internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 1108
{
	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0x33A56E0 Offset: 0x33A57E1 VA: 0x33A56E0
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x33A56F0 Offset: 0x33A57F1 VA: 0x33A56F0
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x33A5700 Offset: 0x33A5801 VA: 0x33A5700
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0x33A5710 Offset: 0x33A5811 VA: 0x33A5710 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0x33A5790 Offset: 0x33A5891 VA: 0x33A5790 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x33A5A70 Offset: 0x33A5B71 VA: 0x33A5A70 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

