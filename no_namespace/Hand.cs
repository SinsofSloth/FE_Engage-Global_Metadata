// Namespace: 
[DefaultMemberAttribute] // RVA: 0x27A430 Offset: 0x27A531 VA: 0x27A430
public struct Hand.Fingers : IList<Finger>, ICollection<Finger>, IEnumerable<Finger>, IEnumerable // TypeDefIndex: 14581
{
	// Fields
	private const int _Length = 5;
	public Finger thumb; // 0x0
	public Finger index; // 0x1C
	public Finger middle; // 0x38
	public Finger ring; // 0x54
	public Finger little; // 0x70

	// Properties
	public int Length { get; }
	public Finger Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1FA6BA0 Offset: 0x1FA6CA1 VA: 0x1FA6BA0
	public int get_Length() { }

	// RVA: 0x1FA6BB0 Offset: 0x1FA6CB1 VA: 0x1FA6BB0 Slot: 4
	public Finger get_Item(int index) { }

	// RVA: 0x1FA6C80 Offset: 0x1FA6D81 VA: 0x1FA6C80 Slot: 5
	public void set_Item(int index, Finger value) { }

	// RVA: 0x1FA6DA0 Offset: 0x1FA6EA1 VA: 0x1FA6DA0 Slot: 9
	public int get_Count() { }

	// RVA: 0x1FA6DB0 Offset: 0x1FA6EB1 VA: 0x1FA6DB0 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1FA6DC0 Offset: 0x1FA6EC1 VA: 0x1FA6DC0 Slot: 13
	public bool Contains(Finger item) { }

	// RVA: 0x1FA6FA0 Offset: 0x1FA70A1 VA: 0x1FA6FA0 Slot: 6
	public int IndexOf(Finger item) { }

	// RVA: 0x1FA71C0 Offset: 0x1FA72C1 VA: 0x1FA71C0 Slot: 14
	public void CopyTo(Finger[] array, int arrayIndex) { }

	// RVA: 0x1FA7430 Offset: 0x1FA7531 VA: 0x1FA7430 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D0EE0 Offset: 0x2D0FE1 VA: 0x2D0EE0
	// RVA: 0x1FA76C0 Offset: 0x1FA77C1 VA: 0x1FA76C0 Slot: 16
	public IEnumerator<Finger> GetEnumerator() { }

	// RVA: 0x1FA7740 Offset: 0x1FA7841 VA: 0x1FA7740 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1FA77C0 Offset: 0x1FA78C1 VA: 0x1FA77C0 Slot: 11
	public void Add(Finger item) { }

	// RVA: 0x1FA7800 Offset: 0x1FA7901 VA: 0x1FA7800 Slot: 12
	public void Clear() { }

	// RVA: 0x1FA7840 Offset: 0x1FA7941 VA: 0x1FA7840 Slot: 7
	public void Insert(int index, Finger item) { }

	// RVA: 0x1FA7880 Offset: 0x1FA7981 VA: 0x1FA7880 Slot: 15
	public bool Remove(Finger item) { }

	// RVA: 0x1FA78C0 Offset: 0x1FA79C1 VA: 0x1FA78C0 Slot: 8
	public void RemoveAt(int index) { }
}

