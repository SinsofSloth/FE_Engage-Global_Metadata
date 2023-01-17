// Namespace: System.Runtime.Remoting.Contexts
internal class DynamicPropertyCollection // TypeDefIndex: 1135
{
	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x372BDF0 Offset: 0x372BEF1 VA: 0x372BDF0
	public bool get_HasProperties() { }

	// RVA: 0x372BE20 Offset: 0x372BF21 VA: 0x372BE20
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x372C2A0 Offset: 0x372C3A1 VA: 0x372C2A0
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x372C410 Offset: 0x372C511 VA: 0x372C410
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x372C120 Offset: 0x372C221 VA: 0x372C120
	private int FindProperty(string name) { }

	// RVA: 0x372C9A0 Offset: 0x372CAA1 VA: 0x372C9A0
	public void .ctor() { }
}

