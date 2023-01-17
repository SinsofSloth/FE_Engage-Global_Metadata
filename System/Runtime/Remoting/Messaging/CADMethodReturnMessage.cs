// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 1191
{
	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x3511490 Offset: 0x3511591 VA: 0x3511490
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x3511520 Offset: 0x3511621 VA: 0x3511520
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x35119B0 Offset: 0x3511AB1 VA: 0x35119B0
	internal ArrayList GetArguments() { }

	// RVA: 0x3511AB0 Offset: 0x3511BB1 VA: 0x3511AB0
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x3511AC0 Offset: 0x3511BC1 VA: 0x3511AC0
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x3511AD0 Offset: 0x3511BD1 VA: 0x3511AD0
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x3511B90 Offset: 0x3511C91 VA: 0x3511B90
	internal int get_PropertiesCount() { }
}

