// Namespace: System.Xml
internal abstract class IncrementalReadDecoder // TypeDefIndex: 1643
{
	// Properties
	internal abstract bool IsFull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool get_IsFull();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int Decode(char[] chars, int startPos, int len);

	// RVA: 0x323EEF0 Offset: 0x323EFF1 VA: 0x323EEF0
	protected void .ctor() { }
}

