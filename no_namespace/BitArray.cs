// Namespace: 
[Serializable]
private class BitArray.BitArrayEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 1339
{
	// Fields
	private BitArray bitarray; // 0x10
	private int index; // 0x18
	private int version; // 0x1C
	private bool currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x35E5AD0 Offset: 0x35E5BD1 VA: 0x35E5AD0
	internal void .ctor(BitArray bitarray) { }

	// RVA: 0x35E5B20 Offset: 0x35E5C21 VA: 0x35E5B20 Slot: 7
	public object Clone() { }

	// RVA: 0x35E5B30 Offset: 0x35E5C31 VA: 0x35E5B30 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x35E5C00 Offset: 0x35E5D01 VA: 0x35E5C00 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x35E5CE0 Offset: 0x35E5DE1 VA: 0x35E5CE0 Slot: 6
	public void Reset() { }
}

