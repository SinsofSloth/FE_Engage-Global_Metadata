// Namespace: System.Runtime.Remoting
[ComVisibleAttribute] // RVA: 0x474AD0 Offset: 0x474BD1 VA: 0x474AD0
public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 1116
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	// Properties
	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }

	// Methods

	// RVA: 0x34D1090 Offset: 0x34D1191 VA: 0x34D1090
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x34D1200 Offset: 0x34D1301 VA: 0x34D1200
	public string get_ApplicationUrl() { }

	// RVA: 0x34D1210 Offset: 0x34D1311 VA: 0x34D1210
	public Type get_ObjectType() { }

	// RVA: 0x34D1220 Offset: 0x34D1321 VA: 0x34D1220
	public string get_ObjectUrl() { }

	// RVA: 0x34D1230 Offset: 0x34D1331 VA: 0x34D1230 Slot: 3
	public override string ToString() { }
}

