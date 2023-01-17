// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x43E450 Offset: 0x43E551 VA: 0x43E450
[AttributeUsageAttribute] // RVA: 0x43E450 Offset: 0x43E551 VA: 0x43E450
public sealed class ContextMenu : Attribute // TypeDefIndex: 3576
{
	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x2F1B7B0 Offset: 0x2F1B8B1 VA: 0x2F1B7B0
	public void .ctor(string itemName) { }

	// RVA: 0x2F1B800 Offset: 0x2F1B901 VA: 0x2F1B800
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x2F1B860 Offset: 0x2F1B961 VA: 0x2F1B860
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }
}

