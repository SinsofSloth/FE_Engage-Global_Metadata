// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 1214
{
	// Fields
	private MonoMethod method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Type[] methodSignature; // 0x68
	private Identity identity; // 0x70
	internal static string CallContextKey; // 0x0
	internal static string UriKey; // 0x8

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x34FA110 Offset: 0x34FA211 VA: 0x34FA110
	internal void InitMessage(MonoMethod method, object[] out_args) { }

	// RVA: 0x34FA470 Offset: 0x34FA571 VA: 0x34FA470
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x34FA560 Offset: 0x34FA661 VA: 0x34FA560
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x34FA6B0 Offset: 0x34FA7B1 VA: 0x34FA6B0
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x34FA780 Offset: 0x34FA881 VA: 0x34FA780
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x34FA820 Offset: 0x34FA921 VA: 0x34FA820 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x34FA8C0 Offset: 0x34FA9C1 VA: 0x34FA8C0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x34FAA60 Offset: 0x34FAB61 VA: 0x34FAA60 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x34FAA70 Offset: 0x34FAB71 VA: 0x34FAA70 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x34FAA80 Offset: 0x34FAB81 VA: 0x34FAA80
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x34FAA90 Offset: 0x34FAB91 VA: 0x34FAA90 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x34FAAA0 Offset: 0x34FABA1 VA: 0x34FAAA0 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x34FAB50 Offset: 0x34FAC51 VA: 0x34FAB50 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x34FAC80 Offset: 0x34FAD81 VA: 0x34FAC80 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x34FAD40 Offset: 0x34FAE41 VA: 0x34FAD40 Slot: 19
	public string get_Uri() { }

	// RVA: 0x34FAD50 Offset: 0x34FAE51 VA: 0x34FAD50 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x34FAD60 Offset: 0x34FAE61 VA: 0x34FAD60 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x34FADB0 Offset: 0x34FAEB1 VA: 0x34FADB0 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x34FADC0 Offset: 0x34FAEC1 VA: 0x34FADC0 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x34FAE40 Offset: 0x34FAF41 VA: 0x34FAE40 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x34FAFF0 Offset: 0x34FB0F1 VA: 0x34FAFF0 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x34FB000 Offset: 0x34FB101 VA: 0x34FB000 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x34FB010 Offset: 0x34FB111 VA: 0x34FB010 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x34FB020 Offset: 0x34FB121 VA: 0x34FB020
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x34FA9A0 Offset: 0x34FAAA1 VA: 0x34FA9A0
	internal CallType get_CallType() { }

	// RVA: 0x34FB030 Offset: 0x34FB131 VA: 0x34FB030
	public bool NeedsOutProcessing(out int outCount) { }

	// RVA: 0x34FB0D0 Offset: 0x34FB1D1 VA: 0x34FB0D0
	private static void .cctor() { }
}

