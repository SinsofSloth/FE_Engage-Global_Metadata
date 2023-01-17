// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A3D0 Offset: 0x27A4D1 VA: 0x27A3D0
private sealed class ClusteringProcessorState.ClusteringDataArray16.<GetEnumerator>d__30 : IEnumerator<ClusteringData>, IEnumerator, IDisposable // TypeDefIndex: 14565
{
	// Fields
	private int <>1__state; // 0x10
	private ClusteringData <>2__current; // 0x14
	public ClusteringProcessorState.ClusteringDataArray16 <>4__this; // 0x2C

	// Properties
	private ClusteringData System.Collections.Generic.IEnumerator<nn.irsensor.ClusteringData>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2D0DD0 Offset: 0x2D0ED1 VA: 0x2D0DD0
	// RVA: 0x1DC1540 Offset: 0x1DC1641 VA: 0x1DC1540
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0DE0 Offset: 0x2D0EE1 VA: 0x2D0DE0
	// RVA: 0x1DC1570 Offset: 0x1DC1671 VA: 0x1DC1570 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DC1580 Offset: 0x1DC1681 VA: 0x1DC1580 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0DF0 Offset: 0x2D0EF1 VA: 0x2D0DF0
	// RVA: 0x1DC1690 Offset: 0x1DC1791 VA: 0x1DC1690 Slot: 4
	private ClusteringData System.Collections.Generic.IEnumerator<nn.irsensor.ClusteringData>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0E00 Offset: 0x2D0F01 VA: 0x2D0E00
	// RVA: 0x1DC16B0 Offset: 0x1DC17B1 VA: 0x1DC16B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0E10 Offset: 0x2D0F11 VA: 0x2D0E10
	// RVA: 0x1DC16F0 Offset: 0x1DC17F1 VA: 0x1DC16F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x27A390 Offset: 0x27A491 VA: 0x27A390
public struct ClusteringProcessorState.ClusteringDataArray16 : IList<ClusteringData>, ICollection<ClusteringData>, IEnumerable<ClusteringData>, IEnumerable // TypeDefIndex: 14566
{
	// Fields
	private const int _Length = 16;
	private ClusteringData _value0; // 0x0
	private ClusteringData _value1; // 0x18
	private ClusteringData _value2; // 0x30
	private ClusteringData _value3; // 0x48
	private ClusteringData _value4; // 0x60
	private ClusteringData _value5; // 0x78
	private ClusteringData _value6; // 0x90
	private ClusteringData _value7; // 0xA8
	private ClusteringData _value8; // 0xC0
	private ClusteringData _value9; // 0xD8
	private ClusteringData _value10; // 0xF0
	private ClusteringData _value11; // 0x108
	private ClusteringData _value12; // 0x120
	private ClusteringData _value13; // 0x138
	private ClusteringData _value14; // 0x150
	private ClusteringData _value15; // 0x168

	// Properties
	public int Length { get; }
	public ClusteringData Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1E07FF0 Offset: 0x1E080F1 VA: 0x1E07FF0
	public int get_Length() { }

	// RVA: 0x1E08000 Offset: 0x1E08101 VA: 0x1E08000 Slot: 4
	public ClusteringData get_Item(int index) { }

	// RVA: 0x1E08140 Offset: 0x1E08241 VA: 0x1E08140 Slot: 5
	public void set_Item(int index, ClusteringData value) { }

	// RVA: 0x1E08370 Offset: 0x1E08471 VA: 0x1E08370 Slot: 9
	public int get_Count() { }

	// RVA: 0x1E08380 Offset: 0x1E08481 VA: 0x1E08380 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1E08390 Offset: 0x1E08491 VA: 0x1E08390 Slot: 13
	public bool Contains(ClusteringData item) { }

	// RVA: 0x1E08420 Offset: 0x1E08521 VA: 0x1E08420 Slot: 6
	public int IndexOf(ClusteringData item) { }

	// RVA: 0x1E084B0 Offset: 0x1E085B1 VA: 0x1E084B0 Slot: 14
	public void CopyTo(ClusteringData[] array, int arrayIndex) { }

	// RVA: 0x1E088E0 Offset: 0x1E089E1 VA: 0x1E088E0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D0D60 Offset: 0x2D0E61 VA: 0x2D0D60
	// RVA: 0x1E08EE0 Offset: 0x1E08FE1 VA: 0x1E08EE0 Slot: 16
	public IEnumerator<ClusteringData> GetEnumerator() { }

	// RVA: 0x1E08F60 Offset: 0x1E09061 VA: 0x1E08F60 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E08FE0 Offset: 0x1E090E1 VA: 0x1E08FE0 Slot: 11
	public void Add(ClusteringData item) { }

	// RVA: 0x1E09020 Offset: 0x1E09121 VA: 0x1E09020 Slot: 12
	public void Clear() { }

	// RVA: 0x1E09060 Offset: 0x1E09161 VA: 0x1E09060 Slot: 7
	public void Insert(int index, ClusteringData item) { }

	// RVA: 0x1E090A0 Offset: 0x1E091A1 VA: 0x1E090A0 Slot: 15
	public bool Remove(ClusteringData item) { }

	// RVA: 0x1E090E0 Offset: 0x1E091E1 VA: 0x1E090E0 Slot: 8
	public void RemoveAt(int index) { }
}

