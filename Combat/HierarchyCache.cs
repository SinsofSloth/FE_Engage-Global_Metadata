// Namespace: Combat
[DefaultMemberAttribute] // RVA: 0x274860 Offset: 0x274961 VA: 0x274860
public sealed class HierarchyCache // TypeDefIndex: 8808
{
	// Fields
	private Dictionary<string, Transform> dic; // 0x10

	// Properties
	public Dictionary<string, Transform> Dic { get; }
	public Transform Item { get; }

	// Methods

	// RVA: 0x26668F0 Offset: 0x26669F1 VA: 0x26668F0
	public Dictionary<string, Transform> get_Dic() { }

	// RVA: 0x2666900 Offset: 0x2666A01 VA: 0x2666900
	public Transform get_Item(string name) { }

	// RVA: 0x2666980 Offset: 0x2666A81 VA: 0x2666980
	public void .ctor(Transform root) { }

	// RVA: 0x2666A30 Offset: 0x2666B31 VA: 0x2666A30
	public void AddRange(Transform root) { }
}

