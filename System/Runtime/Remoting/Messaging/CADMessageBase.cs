// Namespace: System.Runtime.Remoting.Messaging
internal class CADMessageBase // TypeDefIndex: 1189
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x350E960 Offset: 0x350EA61 VA: 0x350E960
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x350EE60 Offset: 0x350EF61 VA: 0x350EE60
	internal MethodBase GetMethod() { }

	// RVA: 0x350F360 Offset: 0x350F461 VA: 0x350F360
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x350F590 Offset: 0x350F691 VA: 0x350F590
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x350FC60 Offset: 0x350FD61 VA: 0x350FC60
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x350FDA0 Offset: 0x350FEA1 VA: 0x350FDA0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x350FF90 Offset: 0x3510091 VA: 0x350FF90
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x3510200 Offset: 0x3510301 VA: 0x3510200
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x35108D0 Offset: 0x35109D1 VA: 0x35108D0
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x35109E0 Offset: 0x3510AE1 VA: 0x35109E0
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x3510AF0 Offset: 0x3510BF1 VA: 0x3510AF0
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x3510D40 Offset: 0x3510E41 VA: 0x3510D40
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

