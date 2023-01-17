// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x4753A0 Offset: 0x4754A1 VA: 0x4753A0
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1220
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x321CBF0 Offset: 0x321CCF1 VA: 0x321CBF0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x321E830 Offset: 0x321E931 VA: 0x321E830
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x3227350 Offset: 0x3227451 VA: 0x3227350 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x3227360 Offset: 0x3227461 VA: 0x3227360 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x3227370 Offset: 0x3227471 VA: 0x3227370 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x3227400 Offset: 0x3227501 VA: 0x3227400 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x3227410 Offset: 0x3227511 VA: 0x3227410 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x3227480 Offset: 0x3227581 VA: 0x3227480 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x32275D0 Offset: 0x32276D1 VA: 0x32275D0 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x3227670 Offset: 0x3227771 VA: 0x3227670 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x32276F0 Offset: 0x32277F1 VA: 0x32276F0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x3227700 Offset: 0x3227801 VA: 0x3227700
	public void set_Uri(string value) { }

	// RVA: 0x3227710 Offset: 0x3227811 VA: 0x3227710 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x3227720 Offset: 0x3227821 VA: 0x3227720 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x3227730 Offset: 0x3227831 VA: 0x3227730 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x3227770 Offset: 0x3227871 VA: 0x3227770 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x3227780 Offset: 0x3227881 VA: 0x3227780 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x3227850 Offset: 0x3227951 VA: 0x3227850 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x3227860 Offset: 0x3227961 VA: 0x3227860 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x3227870 Offset: 0x3227971 VA: 0x3227870 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

