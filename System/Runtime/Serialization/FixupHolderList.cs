// Namespace: System.Runtime.Serialization
[Serializable]
internal class FixupHolderList // TypeDefIndex: 1002
{
	// Fields
	internal FixupHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Methods

	// RVA: 0x38B38B0 Offset: 0x38B39B1 VA: 0x38B38B0
	internal void .ctor() { }

	// RVA: 0x38B3930 Offset: 0x38B3A31 VA: 0x38B3930
	internal void .ctor(int startingSize) { }

	// RVA: 0x38B39B0 Offset: 0x38B3AB1 VA: 0x38B39B0 Slot: 4
	internal virtual void Add(FixupHolder fixup) { }

	// RVA: 0x38B3AC0 Offset: 0x38B3BC1 VA: 0x38B3AC0
	private void EnlargeArray() { }
}

