// Namespace: System.Runtime.Remoting.Proxies
internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 1124
{
	// Fields
	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x321C560 Offset: 0x321C661 VA: 0x321C560
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x321C5C0 Offset: 0x321C6C1 VA: 0x321C5C0
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x321C620 Offset: 0x321C721 VA: 0x321C620 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x321CDD0 Offset: 0x321CED1 VA: 0x321CDD0
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x321D060 Offset: 0x321D161 VA: 0x321D060
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x321D150 Offset: 0x321D251 VA: 0x321D150 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x321D290 Offset: 0x321D391 VA: 0x321D290 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x321D4B0 Offset: 0x321D5B1 VA: 0x321D4B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x321D800 Offset: 0x321D901 VA: 0x321D800
	private static void .cctor() { }
}

