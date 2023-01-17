// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliantAttribute] // RVA: 0x475300 Offset: 0x475401 VA: 0x475300
[ComVisibleAttribute] // RVA: 0x475300 Offset: 0x475401 VA: 0x475300
[Serializable]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1212
{
	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x34EFC30 Offset: 0x34EFD31 VA: 0x34EFC30
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x34EFD80 Offset: 0x34EFE81 VA: 0x34EFD80
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x34EFEA0 Offset: 0x34EFFA1 VA: 0x34EFEA0
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x34F0180 Offset: 0x34F0281 VA: 0x34F0180
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34F0200 Offset: 0x34F0301 VA: 0x34F0200
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x34F0660 Offset: 0x34F0761 VA: 0x34F0660 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x34F0680 Offset: 0x34F0781 VA: 0x34F0680 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x34F0690 Offset: 0x34F0791 VA: 0x34F0690 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x34F06A0 Offset: 0x34F07A1 VA: 0x34F06A0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x34F0730 Offset: 0x34F0831 VA: 0x34F0730 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x34F09E0 Offset: 0x34F0AE1 VA: 0x34F09E0 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x34F0BC0 Offset: 0x34F0CC1 VA: 0x34F0BC0 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x34F0D00 Offset: 0x34F0E01 VA: 0x34F0D00 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x34F0DE0 Offset: 0x34F0EE1 VA: 0x34F0DE0 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x34F0FF0 Offset: 0x34F10F1 VA: 0x34F0FF0 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x34F0AD0 Offset: 0x34F0BD1 VA: 0x34F0AD0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x34F1000 Offset: 0x34F1101 VA: 0x34F1000 Slot: 14
	public string get_Uri() { }

	// RVA: 0x34F10F0 Offset: 0x34F11F1 VA: 0x34F10F0
	public void set_Uri(string value) { }

	// RVA: 0x34F1100 Offset: 0x34F1201 VA: 0x34F1100 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x34F11F0 Offset: 0x34F12F1 VA: 0x34F11F0 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x34F1200 Offset: 0x34F1301 VA: 0x34F1200 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x34F1250 Offset: 0x34F1351 VA: 0x34F1250 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34F16B0 Offset: 0x34F17B1 VA: 0x34F16B0 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x34F16C0 Offset: 0x34F17C1 VA: 0x34F16C0 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

