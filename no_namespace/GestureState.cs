// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A630 Offset: 0x27A731 VA: 0x27A630
private sealed class GestureState.GesturePointArray4.<GetEnumerator>d__18 : IEnumerator<GesturePoint>, IEnumerator, IDisposable // TypeDefIndex: 14633
{
	// Fields
	private int <>1__state; // 0x10
	private GesturePoint <>2__current; // 0x14
	public GestureState.GesturePointArray4 <>4__this; // 0x1C

	// Properties
	private GesturePoint System.Collections.Generic.IEnumerator<nn.hid.GesturePoint>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2D1330 Offset: 0x2D1431 VA: 0x2D1330
	// RVA: 0x1DC9860 Offset: 0x1DC9961 VA: 0x1DC9860
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1340 Offset: 0x2D1441 VA: 0x2D1340
	// RVA: 0x1DC9890 Offset: 0x1DC9991 VA: 0x1DC9890 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DC98A0 Offset: 0x1DC99A1 VA: 0x1DC98A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1350 Offset: 0x2D1451 VA: 0x2D1350
	// RVA: 0x1DC9910 Offset: 0x1DC9A11 VA: 0x1DC9910 Slot: 4
	private GesturePoint System.Collections.Generic.IEnumerator<nn.hid.GesturePoint>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1360 Offset: 0x2D1461 VA: 0x2D1360
	// RVA: 0x1DC9920 Offset: 0x1DC9A21 VA: 0x1DC9920 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1370 Offset: 0x2D1471 VA: 0x2D1370
	// RVA: 0x1DC9960 Offset: 0x1DC9A61 VA: 0x1DC9960 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x27A5F0 Offset: 0x27A6F1 VA: 0x27A5F0
public struct GestureState.GesturePointArray4 : IList<GesturePoint>, ICollection<GesturePoint>, IEnumerable<GesturePoint>, IEnumerable // TypeDefIndex: 14634
{
	// Fields
	private const int _Length = 4;
	private GesturePoint _value0; // 0x0
	private GesturePoint _value1; // 0x8
	private GesturePoint _value2; // 0x10
	private GesturePoint _value3; // 0x18

	// Properties
	public int Length { get; }
	public GesturePoint Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x22ECAB0 Offset: 0x22ECBB1 VA: 0x22ECAB0
	public int get_Length() { }

	// RVA: 0x22ECAC0 Offset: 0x22ECBC1 VA: 0x22ECAC0 Slot: 4
	public GesturePoint get_Item(int index) { }

	// RVA: 0x22ECB60 Offset: 0x22ECC61 VA: 0x22ECB60 Slot: 5
	public void set_Item(int index, GesturePoint value) { }

	// RVA: 0x22ECC00 Offset: 0x22ECD01 VA: 0x22ECC00 Slot: 9
	public int get_Count() { }

	// RVA: 0x22ECC10 Offset: 0x22ECD11 VA: 0x22ECC10 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x22ECC20 Offset: 0x22ECD21 VA: 0x22ECC20 Slot: 13
	public bool Contains(GesturePoint item) { }

	// RVA: 0x22ECCA0 Offset: 0x22ECDA1 VA: 0x22ECCA0 Slot: 6
	public int IndexOf(GesturePoint item) { }

	// RVA: 0x22ECD50 Offset: 0x22ECE51 VA: 0x22ECD50 Slot: 14
	public void CopyTo(GesturePoint[] array, int arrayIndex) { }

	// RVA: 0x22ECE80 Offset: 0x22ECF81 VA: 0x22ECE80 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D12C0 Offset: 0x2D13C1 VA: 0x2D12C0
	// RVA: 0x22ED060 Offset: 0x22ED161 VA: 0x22ED060 Slot: 16
	public IEnumerator<GesturePoint> GetEnumerator() { }

	// RVA: 0x22ED0E0 Offset: 0x22ED1E1 VA: 0x22ED0E0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x22ED160 Offset: 0x22ED261 VA: 0x22ED160 Slot: 11
	public void Add(GesturePoint item) { }

	// RVA: 0x22ED1A0 Offset: 0x22ED2A1 VA: 0x22ED1A0 Slot: 12
	public void Clear() { }

	// RVA: 0x22ED1E0 Offset: 0x22ED2E1 VA: 0x22ED1E0 Slot: 7
	public void Insert(int index, GesturePoint item) { }

	// RVA: 0x22ED220 Offset: 0x22ED321 VA: 0x22ED220 Slot: 15
	public bool Remove(GesturePoint item) { }

	// RVA: 0x22ED260 Offset: 0x22ED361 VA: 0x22ED260 Slot: 8
	public void RemoveAt(int index) { }
}

