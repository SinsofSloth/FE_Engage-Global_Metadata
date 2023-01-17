// Namespace: System.Runtime.InteropServices
[AttributeUsageAttribute] // RVA: 0x476010 Offset: 0x476111 VA: 0x476010
[ComVisibleAttribute] // RVA: 0x476010 Offset: 0x476111 VA: 0x476010
public sealed class ComCompatibleVersionAttribute : Attribute // TypeDefIndex: 1303
{
	// Fields
	internal int _major; // 0x10
	internal int _minor; // 0x14
	internal int _build; // 0x18
	internal int _revision; // 0x1C

	// Methods

	// RVA: 0x33A81E0 Offset: 0x33A82E1 VA: 0x33A81E0
	public void .ctor(int major, int minor, int build, int revision) { }
}

