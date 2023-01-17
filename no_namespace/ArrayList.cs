// Namespace: 
[Serializable]
private sealed class ArrayList.ArrayListEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 1336
{
	// Fields
	private ArrayList list; // 0x10
	private int index; // 0x18
	private int version; // 0x1C
	private object currentElement; // 0x20
	private bool isArrayList; // 0x28
	private static object dummyObject; // 0x0

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x35E1F30 Offset: 0x35E2031 VA: 0x35E1F30
	internal void .ctor(ArrayList list) { }

	// RVA: 0x35E2060 Offset: 0x35E2161 VA: 0x35E2060 Slot: 7
	public object Clone() { }

	// RVA: 0x35E2070 Offset: 0x35E2171 VA: 0x35E2070 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x35E2260 Offset: 0x35E2361 VA: 0x35E2260 Slot: 5
	public object get_Current() { }

	// RVA: 0x35E2350 Offset: 0x35E2451 VA: 0x35E2350 Slot: 6
	public void Reset() { }

	// RVA: 0x35E2430 Offset: 0x35E2531 VA: 0x35E2430
	private static void .cctor() { }
}

