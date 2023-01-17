// Namespace: 
[DefaultMemberAttribute] // RVA: 0x27A4D0 Offset: 0x27A5D1 VA: 0x27A4D0
public struct HandAnalysisSilhouetteState.HandArray2 : IList<Hand>, ICollection<Hand>, IEnumerable<Hand>, IEnumerable // TypeDefIndex: 14587
{
	// Fields
	private const int _Length = 2;
	private Hand _value0; // 0x0
	private Hand _value1; // 0x104

	// Properties
	public int Length { get; }
	public Hand Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1FA8410 Offset: 0x1FA8511 VA: 0x1FA8410
	public int get_Length() { }

	// RVA: 0x1FA8420 Offset: 0x1FA8521 VA: 0x1FA8420 Slot: 4
	public Hand get_Item(int index) { }

	// RVA: 0x1FA8490 Offset: 0x1FA8591 VA: 0x1FA8490 Slot: 5
	public void set_Item(int index, Hand value) { }

	// RVA: 0x1FA8500 Offset: 0x1FA8601 VA: 0x1FA8500 Slot: 9
	public int get_Count() { }

	// RVA: 0x1FA8510 Offset: 0x1FA8611 VA: 0x1FA8510 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1FA8520 Offset: 0x1FA8621 VA: 0x1FA8520 Slot: 13
	public bool Contains(Hand item) { }

	// RVA: 0x1FA8610 Offset: 0x1FA8711 VA: 0x1FA8610 Slot: 6
	public int IndexOf(Hand item) { }

	// RVA: 0x1FA8700 Offset: 0x1FA8801 VA: 0x1FA8700 Slot: 14
	public void CopyTo(Hand[] array, int arrayIndex) { }

	// RVA: 0x1FA8890 Offset: 0x1FA8991 VA: 0x1FA8890 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D1060 Offset: 0x2D1161 VA: 0x2D1060
	// RVA: 0x1FA8960 Offset: 0x1FA8A61 VA: 0x1FA8960 Slot: 16
	public IEnumerator<Hand> GetEnumerator() { }

	// RVA: 0x1FA89E0 Offset: 0x1FA8AE1 VA: 0x1FA89E0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1FA8A60 Offset: 0x1FA8B61 VA: 0x1FA8A60 Slot: 11
	public void Add(Hand item) { }

	// RVA: 0x1FA8AA0 Offset: 0x1FA8BA1 VA: 0x1FA8AA0 Slot: 12
	public void Clear() { }

	// RVA: 0x1FA8AE0 Offset: 0x1FA8BE1 VA: 0x1FA8AE0 Slot: 7
	public void Insert(int index, Hand item) { }

	// RVA: 0x1FA8B20 Offset: 0x1FA8C21 VA: 0x1FA8B20 Slot: 15
	public bool Remove(Hand item) { }

	// RVA: 0x1FA8B60 Offset: 0x1FA8C61 VA: 0x1FA8B60 Slot: 8
	public void RemoveAt(int index) { }
}

