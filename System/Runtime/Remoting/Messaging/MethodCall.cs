// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliantAttribute] // RVA: 0x475280 Offset: 0x475381 VA: 0x475280
[ComVisibleAttribute] // RVA: 0x475280 Offset: 0x475381 VA: 0x475280
[Serializable]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1208
{
	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x34EDB00 Offset: 0x34EDC01 VA: 0x34EDB00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34EDBA0 Offset: 0x34EDCA1 VA: 0x34EDBA0
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x34EDD10 Offset: 0x34EDE11 VA: 0x34EDD10
	internal void .ctor() { }

	// RVA: 0x34EDD20 Offset: 0x34EDE21 VA: 0x34EDD20
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x34EE0D0 Offset: 0x34EE1D1 VA: 0x34EE0D0 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x34EE4E0 Offset: 0x34EE5E1 VA: 0x34EE4E0 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34EE930 Offset: 0x34EEA31 VA: 0x34EE930 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x34EE940 Offset: 0x34EEA41 VA: 0x34EE940 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x34EE950 Offset: 0x34EEA51 VA: 0x34EE950 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x34EE9E0 Offset: 0x34EEAE1 VA: 0x34EE9E0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x34EF260 Offset: 0x34EF361 VA: 0x34EF260 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x34EF2C0 Offset: 0x34EF3C1 VA: 0x34EF2C0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x34EF430 Offset: 0x34EF531 VA: 0x34EF430 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x34EF480 Offset: 0x34EF581 VA: 0x34EF480 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x34EF530 Offset: 0x34EF631 VA: 0x34EF530 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x34EF5A0 Offset: 0x34EF6A1 VA: 0x34EF5A0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x34EF5B0 Offset: 0x34EF6B1 VA: 0x34EF5B0
	public void set_Uri(string value) { }

	// RVA: 0x34EF5C0 Offset: 0x34EF6C1 VA: 0x34EF5C0 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x34EF5D0 Offset: 0x34EF6D1 VA: 0x34EF5D0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x34EF5E0 Offset: 0x34EF6E1 VA: 0x34EF5E0 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x34EF620 Offset: 0x34EF721 VA: 0x34EF620 Slot: 23
	public virtual void Init() { }

	// RVA: 0x34EEA50 Offset: 0x34EEB51 VA: 0x34EEA50
	public void ResolveMethod() { }

	// RVA: 0x34EF630 Offset: 0x34EF731 VA: 0x34EF630
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x34EF8F0 Offset: 0x34EF9F1 VA: 0x34EF8F0
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x34EF9A0 Offset: 0x34EFAA1 VA: 0x34EF9A0 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x34EF9B0 Offset: 0x34EFAB1 VA: 0x34EF9B0 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x34EF850 Offset: 0x34EF951 VA: 0x34EF850
	private Type[] get_GenericArguments() { }
}

