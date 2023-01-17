// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FED0 Offset: 0x46FFD1 VA: 0x46FED0
[Serializable]
public sealed class CharEnumerator : IEnumerator, ICloneable, IEnumerator<char>, IDisposable // TypeDefIndex: 183
{
	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private char currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x33A1CE0 Offset: 0x33A1DE1 VA: 0x33A1CE0
	internal void .ctor(string str) { }

	// RVA: 0x33A1D20 Offset: 0x33A1E21 VA: 0x33A1D20 Slot: 7
	public object Clone() { }

	// RVA: 0x33A1D30 Offset: 0x33A1E31 VA: 0x33A1D30 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x33A1D90 Offset: 0x33A1E91 VA: 0x33A1D90 Slot: 9
	public void Dispose() { }

	// RVA: 0x33A1DB0 Offset: 0x33A1EB1 VA: 0x33A1DB0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x33A1E90 Offset: 0x33A1F91 VA: 0x33A1E90 Slot: 8
	public char get_Current() { }

	// RVA: 0x33A1F30 Offset: 0x33A2031 VA: 0x33A1F30 Slot: 6
	public void Reset() { }

	// RVA: 0x33A1F40 Offset: 0x33A2041 VA: 0x33A1F40
	internal void .ctor() { }
}

