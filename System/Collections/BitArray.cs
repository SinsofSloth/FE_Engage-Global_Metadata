// Namespace: System.Collections
[DefaultMemberAttribute] // RVA: 0x476AB0 Offset: 0x476BB1 VA: 0x476AB0
[ComVisibleAttribute] // RVA: 0x476AB0 Offset: 0x476BB1 VA: 0x476AB0
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1340
{
	// Fields
	private const int BitsPerInt32 = 32;
	private const int BytesPerInt32 = 4;
	private const int BitsPerByte = 8;
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _ShrinkThreshold = 256;

	// Properties
	public bool Item { get; }
	public int Length { get; }
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x3508CD0 Offset: 0x3508DD1 VA: 0x3508CD0
	private void .ctor() { }

	// RVA: 0x3508CE0 Offset: 0x3508DE1 VA: 0x3508CE0
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x3508E60 Offset: 0x3508F61 VA: 0x3508E60
	public void .ctor(int[] values) { }

	// RVA: 0x3509010 Offset: 0x3509111 VA: 0x3509010
	public bool get_Item(int index) { }

	// RVA: 0x3509020 Offset: 0x3509121 VA: 0x3509020
	public bool Get(int index) { }

	// RVA: 0x35090E0 Offset: 0x35091E1 VA: 0x35090E0
	public void Set(int index, bool value) { }

	// RVA: 0x35091C0 Offset: 0x35092C1 VA: 0x35091C0
	public void SetAll(bool value) { }

	// RVA: 0x3509240 Offset: 0x3509341 VA: 0x3509240
	public int get_Length() { }

	// RVA: 0x3509250 Offset: 0x3509351 VA: 0x3509250 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x35095F0 Offset: 0x35096F1 VA: 0x35095F0 Slot: 5
	public int get_Count() { }

	// RVA: 0x3509600 Offset: 0x3509701 VA: 0x3509600 Slot: 9
	public object Clone() { }

	// RVA: 0x3509680 Offset: 0x3509781 VA: 0x3509680 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x3509710 Offset: 0x3509811 VA: 0x3509710 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x3509720 Offset: 0x3509821 VA: 0x3509720 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x3508E40 Offset: 0x3508F41 VA: 0x3508E40
	private static int GetArrayLength(int n, int div) { }
}

