// Namespace: 
[DefaultMemberAttribute] // RVA: 0x27A570 Offset: 0x27A671 VA: 0x27A570
public struct ControllerSupportArg.Color4u8Array8 : IList<Color4u8>, ICollection<Color4u8>, IEnumerable<Color4u8>, IEnumerable // TypeDefIndex: 14618
{
	// Fields
	private const int _Length = 8;
	private Color4u8 _value0; // 0x0
	private Color4u8 _value1; // 0x4
	private Color4u8 _value2; // 0x8
	private Color4u8 _value3; // 0xC
	private Color4u8 _value4; // 0x10
	private Color4u8 _value5; // 0x14
	private Color4u8 _value6; // 0x18
	private Color4u8 _value7; // 0x1C

	// Properties
	public int Length { get; }
	public Color4u8 Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1E0AD60 Offset: 0x1E0AE61 VA: 0x1E0AD60
	public int get_Length() { }

	// RVA: 0x1E0AD70 Offset: 0x1E0AE71 VA: 0x1E0AD70 Slot: 4
	public Color4u8 get_Item(int index) { }

	// RVA: 0x1E0AE60 Offset: 0x1E0AF61 VA: 0x1E0AE60 Slot: 5
	public void set_Item(int index, Color4u8 value) { }

	// RVA: 0x1E0AF50 Offset: 0x1E0B051 VA: 0x1E0AF50 Slot: 9
	public int get_Count() { }

	// RVA: 0x1E0AF60 Offset: 0x1E0B061 VA: 0x1E0AF60 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1E0AF70 Offset: 0x1E0B071 VA: 0x1E0AF70 Slot: 13
	public bool Contains(Color4u8 item) { }

	// RVA: 0x1E0B040 Offset: 0x1E0B141 VA: 0x1E0B040 Slot: 6
	public int IndexOf(Color4u8 item) { }

	// RVA: 0x1E0B180 Offset: 0x1E0B281 VA: 0x1E0B180 Slot: 14
	public void CopyTo(Color4u8[] array, int arrayIndex) { }

	// RVA: 0x1E0B330 Offset: 0x1E0B431 VA: 0x1E0B330 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D1200 Offset: 0x2D1301 VA: 0x2D1200
	// RVA: 0x1E0B640 Offset: 0x1E0B741 VA: 0x1E0B640 Slot: 16
	public IEnumerator<Color4u8> GetEnumerator() { }

	// RVA: 0x1E0B6C0 Offset: 0x1E0B7C1 VA: 0x1E0B6C0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E0B740 Offset: 0x1E0B841 VA: 0x1E0B740 Slot: 11
	public void Add(Color4u8 item) { }

	// RVA: 0x1E0B780 Offset: 0x1E0B881 VA: 0x1E0B780 Slot: 12
	public void Clear() { }

	// RVA: 0x1E0B7C0 Offset: 0x1E0B8C1 VA: 0x1E0B7C0 Slot: 7
	public void Insert(int index, Color4u8 item) { }

	// RVA: 0x1E0B800 Offset: 0x1E0B901 VA: 0x1E0B800 Slot: 15
	public bool Remove(Color4u8 item) { }

	// RVA: 0x1E0B840 Offset: 0x1E0B941 VA: 0x1E0B840 Slot: 8
	public void RemoveAt(int index) { }
}

