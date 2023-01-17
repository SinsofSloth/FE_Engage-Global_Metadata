// Namespace: System.Runtime.Serialization
internal class ObjectHolderList // TypeDefIndex: 1004
{
	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x3864DD0 Offset: 0x3864ED1 VA: 0x3864DD0
	internal void .ctor() { }

	// RVA: 0x3864E40 Offset: 0x3864F41 VA: 0x3864E40
	internal void .ctor(int startingSize) { }

	// RVA: 0x3864EB0 Offset: 0x3864FB1 VA: 0x3864EB0 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x3865050 Offset: 0x3865151 VA: 0x3865050
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x3864FC0 Offset: 0x38650C1 VA: 0x3864FC0
	private void EnlargeArray() { }

	// RVA: 0x3865130 Offset: 0x3865231 VA: 0x3865130
	internal int get_Version() { }

	// RVA: 0x3865140 Offset: 0x3865241 VA: 0x3865140
	internal int get_Count() { }
}

