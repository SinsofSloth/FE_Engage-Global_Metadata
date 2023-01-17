// Namespace: System.Runtime.Remoting.Proxies
[ComVisibleAttribute] // RVA: 0x474BB0 Offset: 0x474CB1 VA: 0x474BB0
public abstract class RealProxy // TypeDefIndex: 1123
{
	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x3B72070 Offset: 0x3B72171 VA: 0x3B72070
	protected void .ctor() { }

	// RVA: 0x3B72080 Offset: 0x3B72181 VA: 0x3B72080
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x3B72200 Offset: 0x3B72301 VA: 0x3B72200
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x3B720E0 Offset: 0x3B721E1 VA: 0x3B720E0
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x3B72270 Offset: 0x3B72371 VA: 0x3B72270
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x3B72280 Offset: 0x3B72381 VA: 0x3B72280
	public Type GetProxiedType() { }

	// RVA: 0x3B72330 Offset: 0x3B72431 VA: 0x3B72330 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3B723D0 Offset: 0x3B724D1 VA: 0x3B723D0
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x3B723E0 Offset: 0x3B724E1 VA: 0x3B723E0
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x3B723F0 Offset: 0x3B724F1 VA: 0x3B723F0
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x3B733A0 Offset: 0x3B734A1 VA: 0x3B733A0 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x3B733B0 Offset: 0x3B734B1 VA: 0x3B733B0 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x3B73560 Offset: 0x3B73661 VA: 0x3B73560
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x3B73570 Offset: 0x3B73671 VA: 0x3B73570
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x3B73580 Offset: 0x3B73681 VA: 0x3B73580
	internal object GetAppDomainTarget() { }

	// RVA: 0x3B72CC0 Offset: 0x3B72DC1 VA: 0x3B72CC0
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }
}

