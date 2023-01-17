// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 1198
{
	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x3B5FC90 Offset: 0x3B5FD91 VA: 0x3B5FC90
	public void .ctor() { }

	// RVA: 0x3B5FD00 Offset: 0x3B5FE01 VA: 0x3B5FD00 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x3B5FD10 Offset: 0x3B5FE11 VA: 0x3B5FD10 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x3B5FD20 Offset: 0x3B5FE21 VA: 0x3B5FD20 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x3B5FD30 Offset: 0x3B5FE31 VA: 0x3B5FD30 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x3B5FD80 Offset: 0x3B5FE81 VA: 0x3B5FD80 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x3B5FD90 Offset: 0x3B5FE91 VA: 0x3B5FD90 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x3B5FDA0 Offset: 0x3B5FEA1 VA: 0x3B5FDA0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x3B5FDF0 Offset: 0x3B5FEF1 VA: 0x3B5FDF0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x3B5FE00 Offset: 0x3B5FF01 VA: 0x3B5FE00 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x3B5FE10 Offset: 0x3B5FF11 VA: 0x3B5FE10 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }
}

