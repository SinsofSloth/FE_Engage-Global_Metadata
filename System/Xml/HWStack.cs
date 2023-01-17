// Namespace: System.Xml
[DefaultMemberAttribute] // RVA: 0x46E90 Offset: 0x46F91 VA: 0x46E90
internal class HWStack : ICloneable // TypeDefIndex: 1720
{
	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Properties
	internal object Item { get; set; }
	internal int Length { get; }

	// Methods

	// RVA: 0x323AEC0 Offset: 0x323AFC1 VA: 0x323AEC0
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x323EBC0 Offset: 0x323ECC1 VA: 0x323EBC0
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x323CC70 Offset: 0x323CD71 VA: 0x323CC70
	internal object Push() { }

	// RVA: 0x323CE50 Offset: 0x323CF51 VA: 0x323CE50
	internal object Pop() { }

	// RVA: 0x323CEA0 Offset: 0x323CFA1 VA: 0x323CEA0
	internal object Peek() { }

	// RVA: 0x323CDC0 Offset: 0x323CEC1 VA: 0x323CDC0
	internal void AddToTop(object o) { }

	// RVA: 0x323EC50 Offset: 0x323ED51 VA: 0x323EC50
	internal object get_Item(int index) { }

	// RVA: 0x323ECD0 Offset: 0x323EDD1 VA: 0x323ECD0
	internal void set_Item(int index, object value) { }

	// RVA: 0x323ED90 Offset: 0x323EE91 VA: 0x323ED90
	internal int get_Length() { }

	// RVA: 0x323EDA0 Offset: 0x323EEA1 VA: 0x323EDA0
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x323EE00 Offset: 0x323EF01 VA: 0x323EE00 Slot: 4
	public object Clone() { }
}

