// Namespace: System.Runtime.Serialization
[Serializable]
internal class LongList // TypeDefIndex: 1003
{
	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x3421CE0 Offset: 0x3421DE1 VA: 0x3421CE0
	internal void .ctor() { }

	// RVA: 0x3421D60 Offset: 0x3421E61 VA: 0x3421D60
	internal void .ctor(int startingSize) { }

	// RVA: 0x3421DE0 Offset: 0x3421EE1 VA: 0x3421DE0
	internal void Add(long value) { }

	// RVA: 0x3421F70 Offset: 0x3422071 VA: 0x3421F70
	internal int get_Count() { }

	// RVA: 0x3421F80 Offset: 0x3422081 VA: 0x3421F80
	internal void StartEnumeration() { }

	// RVA: 0x3421F90 Offset: 0x3422091 VA: 0x3421F90
	internal bool MoveNext() { }

	// RVA: 0x3421FF0 Offset: 0x34220F1 VA: 0x3421FF0
	internal long get_Current() { }

	// RVA: 0x3422030 Offset: 0x3422131 VA: 0x3422030
	internal bool RemoveElement(long value) { }

	// RVA: 0x3421EE0 Offset: 0x3421FE1 VA: 0x3421EE0
	private void EnlargeArray() { }
}

