// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMemberAttribute] // RVA: 0x4748D0 Offset: 0x4749D1 VA: 0x4748D0
[Serializable]
internal sealed class SizedArray : ICloneable // TypeDefIndex: 1081
{
	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x3825EA0 Offset: 0x3825FA1 VA: 0x3825EA0
	internal void .ctor() { }

	// RVA: 0x3825F30 Offset: 0x3826031 VA: 0x3825F30
	internal void .ctor(int length) { }

	// RVA: 0x3825FC0 Offset: 0x38260C1 VA: 0x3825FC0
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x3826090 Offset: 0x3826191 VA: 0x3826090 Slot: 4
	public object Clone() { }

	// RVA: 0x3826100 Offset: 0x3826201 VA: 0x3826100
	internal object get_Item(int index) { }

	// RVA: 0x3826190 Offset: 0x3826291 VA: 0x3826190
	internal void set_Item(int index, object value) { }

	// RVA: 0x38262A0 Offset: 0x38263A1 VA: 0x38262A0
	internal void IncreaseCapacity(int index) { }
}

