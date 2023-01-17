// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CADMethodRef // TypeDefIndex: 1188
{
	// Fields
	private bool ctor; // 0x10
	private string typeName; // 0x18
	private string methodName; // 0x20
	private string[] param_names; // 0x28
	private string[] generic_arg_names; // 0x30

	// Methods

	// RVA: 0x3511320 Offset: 0x3511421 VA: 0x3511320
	private Type[] GetTypes(string[] typeArray) { }

	// RVA: 0x350EF80 Offset: 0x350F081 VA: 0x350EF80
	public MethodBase Resolve() { }

	// RVA: 0x350EA00 Offset: 0x350EB01 VA: 0x350EA00
	public void .ctor(IMethodMessage msg) { }
}

