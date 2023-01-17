// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x476B90 Offset: 0x476C91 VA: 0x476B90
[Serializable]
public sealed class Comparer : IComparer, ISerializable // TypeDefIndex: 1344
{
	// Fields
	private CompareInfo m_compareInfo; // 0x10
	public static readonly Comparer Default; // 0x0
	public static readonly Comparer DefaultInvariant; // 0x8

	// Methods

	// RVA: 0x33AA100 Offset: 0x33AA201 VA: 0x33AA100
	private void .ctor() { }

	// RVA: 0x33AA130 Offset: 0x33AA231 VA: 0x33AA130
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x33AA1C0 Offset: 0x33AA2C1 VA: 0x33AA1C0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33AA350 Offset: 0x33AA451 VA: 0x33AA350 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x33AA590 Offset: 0x33AA691 VA: 0x33AA590 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33AA650 Offset: 0x33AA751 VA: 0x33AA650
	private static void .cctor() { }
}

