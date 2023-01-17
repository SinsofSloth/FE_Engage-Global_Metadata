// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMemberAttribute] // RVA: 0x474910 Offset: 0x474A11 VA: 0x474910
[Serializable]
internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 1082
{
	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x34111B0 Offset: 0x34112B1 VA: 0x34111B0
	public void .ctor() { }

	// RVA: 0x3411240 Offset: 0x3411341 VA: 0x3411240
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x3411350 Offset: 0x3411451 VA: 0x3411350 Slot: 4
	public object Clone() { }

	// RVA: 0x34113C0 Offset: 0x34114C1 VA: 0x34113C0
	internal int get_Item(int index) { }

	// RVA: 0x3411440 Offset: 0x3411541 VA: 0x3411440
	internal void set_Item(int index, int value) { }

	// RVA: 0x34114F0 Offset: 0x34115F1 VA: 0x34114F0
	internal void IncreaseCapacity(int index) { }
}

