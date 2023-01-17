// Namespace: 
[DefaultMemberAttribute] // RVA: 0x27AC20 Offset: 0x27AD21 VA: 0x27AC20
public struct UserSelectionSettings.UidArray8 : IList<Uid>, ICollection<Uid>, IEnumerable<Uid>, IEnumerable // TypeDefIndex: 14783
{
	// Fields
	private const int _Length = 8;
	private Uid _value0; // 0x0
	private Uid _value1; // 0x10
	private Uid _value2; // 0x20
	private Uid _value3; // 0x30
	private Uid _value4; // 0x40
	private Uid _value5; // 0x50
	private Uid _value6; // 0x60
	private Uid _value7; // 0x70

	// Properties
	public int Length { get; }
	public Uid Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1EDC890 Offset: 0x1EDC991 VA: 0x1EDC890
	public int get_Length() { }

	// RVA: 0x1EDC8A0 Offset: 0x1EDC9A1 VA: 0x1EDC8A0 Slot: 4
	public Uid get_Item(int index) { }

	// RVA: 0x1EDC970 Offset: 0x1EDCA71 VA: 0x1EDC970 Slot: 5
	public void set_Item(int index, Uid value) { }

	// RVA: 0x1EDCA60 Offset: 0x1EDCB61 VA: 0x1EDCA60 Slot: 9
	public int get_Count() { }

	// RVA: 0x1EDCA70 Offset: 0x1EDCB71 VA: 0x1EDCA70 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1EDCA80 Offset: 0x1EDCB81 VA: 0x1EDCA80 Slot: 13
	public bool Contains(Uid item) { }

	// RVA: 0x1EDCB80 Offset: 0x1EDCC81 VA: 0x1EDCB80 Slot: 6
	public int IndexOf(Uid item) { }

	// RVA: 0x1EDCD10 Offset: 0x1EDCE11 VA: 0x1EDCD10 Slot: 14
	public void CopyTo(Uid[] array, int arrayIndex) { }

	// RVA: 0x1EDCEC0 Offset: 0x1EDCFC1 VA: 0x1EDCEC0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D2040 Offset: 0x2D2141 VA: 0x2D2040
	// RVA: 0x1EDD1D0 Offset: 0x1EDD2D1 VA: 0x1EDD1D0 Slot: 16
	public IEnumerator<Uid> GetEnumerator() { }

	// RVA: 0x1EDD250 Offset: 0x1EDD351 VA: 0x1EDD250 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1EDD2D0 Offset: 0x1EDD3D1 VA: 0x1EDD2D0 Slot: 11
	public void Add(Uid item) { }

	// RVA: 0x1EDD310 Offset: 0x1EDD411 VA: 0x1EDD310 Slot: 12
	public void Clear() { }

	// RVA: 0x1EDD350 Offset: 0x1EDD451 VA: 0x1EDD350 Slot: 7
	public void Insert(int index, Uid item) { }

	// RVA: 0x1EDD390 Offset: 0x1EDD491 VA: 0x1EDD390 Slot: 15
	public bool Remove(Uid item) { }

	// RVA: 0x1EDD3D0 Offset: 0x1EDD4D1 VA: 0x1EDD3D0 Slot: 8
	public void RemoveAt(int index) { }
}

