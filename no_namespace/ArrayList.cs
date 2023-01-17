// Namespace: 
[DefaultMemberAttribute] // RVA: 0x476A70 Offset: 0x476B71 VA: 0x476A70
[Serializable]
private class ArrayList.ReadOnlyArrayList : ArrayList // TypeDefIndex: 1335
{
	// Fields
	private ArrayList _list; // 0x28

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override int Capacity { set; }

	// Methods

	// RVA: 0x35E24B0 Offset: 0x35E25B1 VA: 0x35E24B0
	internal void .ctor(ArrayList l) { }

	// RVA: 0x35E2530 Offset: 0x35E2631 VA: 0x35E2530 Slot: 21
	public override int get_Count() { }

	// RVA: 0x35E2550 Offset: 0x35E2651 VA: 0x35E2550 Slot: 22
	public override bool get_IsReadOnly() { }

	// RVA: 0x35E2560 Offset: 0x35E2661 VA: 0x35E2560 Slot: 23
	public override bool get_IsSynchronized() { }

	// RVA: 0x35E2580 Offset: 0x35E2681 VA: 0x35E2580 Slot: 25
	public override object get_Item(int index) { }

	// RVA: 0x35E25A0 Offset: 0x35E26A1 VA: 0x35E25A0 Slot: 26
	public override void set_Item(int index, object value) { }

	// RVA: 0x35E2600 Offset: 0x35E2701 VA: 0x35E2600 Slot: 24
	public override object get_SyncRoot() { }

	// RVA: 0x35E2620 Offset: 0x35E2721 VA: 0x35E2620 Slot: 27
	public override int Add(object obj) { }

	// RVA: 0x35E2680 Offset: 0x35E2781 VA: 0x35E2680 Slot: 28
	public override void AddRange(ICollection c) { }

	// RVA: 0x35E26E0 Offset: 0x35E27E1 VA: 0x35E26E0 Slot: 20
	public override void set_Capacity(int value) { }

	// RVA: 0x35E2740 Offset: 0x35E2841 VA: 0x35E2740 Slot: 29
	public override void Clear() { }

	// RVA: 0x35E27A0 Offset: 0x35E28A1 VA: 0x35E27A0 Slot: 30
	public override object Clone() { }

	// RVA: 0x35E28E0 Offset: 0x35E29E1 VA: 0x35E28E0 Slot: 31
	public override bool Contains(object obj) { }

	// RVA: 0x35E2900 Offset: 0x35E2A01 VA: 0x35E2900 Slot: 33
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x35E2920 Offset: 0x35E2A21 VA: 0x35E2920 Slot: 34
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x35E2940 Offset: 0x35E2A41 VA: 0x35E2940 Slot: 35
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x35E2960 Offset: 0x35E2A61 VA: 0x35E2960 Slot: 36
	public override int IndexOf(object value) { }

	// RVA: 0x35E2980 Offset: 0x35E2A81 VA: 0x35E2980 Slot: 37
	public override void Insert(int index, object obj) { }

	// RVA: 0x35E29E0 Offset: 0x35E2AE1 VA: 0x35E29E0 Slot: 38
	public override void InsertRange(int index, ICollection c) { }

	// RVA: 0x35E2A40 Offset: 0x35E2B41 VA: 0x35E2A40 Slot: 39
	public override void Remove(object value) { }

	// RVA: 0x35E2AA0 Offset: 0x35E2BA1 VA: 0x35E2AA0 Slot: 40
	public override void RemoveAt(int index) { }

	// RVA: 0x35E2B00 Offset: 0x35E2C01 VA: 0x35E2B00 Slot: 41
	public override void RemoveRange(int index, int count) { }

	// RVA: 0x35E2B60 Offset: 0x35E2C61 VA: 0x35E2B60 Slot: 42
	public override object[] ToArray() { }

	// RVA: 0x35E2B80 Offset: 0x35E2C81 VA: 0x35E2B80 Slot: 43
	public override Array ToArray(Type type) { }
}

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

// Namespace: 
internal class ArrayList.ArrayListDebugView // TypeDefIndex: 1337
{}

