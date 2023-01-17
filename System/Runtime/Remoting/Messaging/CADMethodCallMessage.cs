// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 1190
{
	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x3510DE0 Offset: 0x3510EE1 VA: 0x3510DE0
	internal string get_Uri() { }

	// RVA: 0x3510DF0 Offset: 0x3510EF1 VA: 0x3510DF0
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x3510E80 Offset: 0x3510F81 VA: 0x3510E80
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x3511100 Offset: 0x3511201 VA: 0x3511100
	internal ArrayList GetArguments() { }

	// RVA: 0x3511300 Offset: 0x3511401 VA: 0x3511300
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x3511310 Offset: 0x3511411 VA: 0x3511310
	internal int get_PropertiesCount() { }
}

