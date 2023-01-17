// Namespace: System.Runtime.Remoting
[ComVisibleAttribute] // RVA: 0x474950 Offset: 0x474A51 VA: 0x474950
public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 1089
{
	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x3559980 Offset: 0x3559A81 VA: 0x3559980
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x3559B30 Offset: 0x3559C31 VA: 0x3559B30
	public string get_ApplicationUrl() { }

	// RVA: 0x3559B40 Offset: 0x3559C41 VA: 0x3559B40
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x3559B50 Offset: 0x3559C51 VA: 0x3559B50
	public Type get_ObjectType() { }

	// RVA: 0x3559B60 Offset: 0x3559C61 VA: 0x3559B60 Slot: 3
	public override string ToString() { }
}

