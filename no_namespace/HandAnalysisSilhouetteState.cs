// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A4C0 Offset: 0x27A5C1 VA: 0x27A4C0
private sealed class HandAnalysisSilhouetteState.ShapeArray16.<GetEnumerator>d__30 : IEnumerator<Shape>, IEnumerator, IDisposable // TypeDefIndex: 14584
{
	// Fields
	private int <>1__state; // 0x10
	private Shape <>2__current; // 0x14
	public HandAnalysisSilhouetteState.ShapeArray16 <>4__this; // 0x28

	// Properties
	private Shape System.Collections.Generic.IEnumerator<nn.irsensor.Shape>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2D1010 Offset: 0x2D1111 VA: 0x2D1010
	// RVA: 0x1DCDE80 Offset: 0x1DCDF81 VA: 0x1DCDE80
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1020 Offset: 0x2D1121 VA: 0x2D1020
	// RVA: 0x1DCDEB0 Offset: 0x1DCDFB1 VA: 0x1DCDEB0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DCDEC0 Offset: 0x1DCDFC1 VA: 0x1DCDEC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1030 Offset: 0x2D1131 VA: 0x2D1030
	// RVA: 0x1DCDFD0 Offset: 0x1DCE0D1 VA: 0x1DCDFD0 Slot: 4
	private Shape System.Collections.Generic.IEnumerator<nn.irsensor.Shape>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1040 Offset: 0x2D1141 VA: 0x2D1040
	// RVA: 0x1DCDFF0 Offset: 0x1DCE0F1 VA: 0x1DCDFF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1050 Offset: 0x2D1151 VA: 0x2D1050
	// RVA: 0x1DCE030 Offset: 0x1DCE131 VA: 0x1DCE030 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x27A480 Offset: 0x27A581 VA: 0x27A480
public struct HandAnalysisSilhouetteState.ShapeArray16 : IList<Shape>, ICollection<Shape>, IEnumerable<Shape>, IEnumerable // TypeDefIndex: 14585
{
	// Fields
	private const int _Length = 16;
	private Shape _value0; // 0x0
	private Shape _value1; // 0x14
	private Shape _value2; // 0x28
	private Shape _value3; // 0x3C
	private Shape _value4; // 0x50
	private Shape _value5; // 0x64
	private Shape _value6; // 0x78
	private Shape _value7; // 0x8C
	private Shape _value8; // 0xA0
	private Shape _value9; // 0xB4
	private Shape _value10; // 0xC8
	private Shape _value11; // 0xDC
	private Shape _value12; // 0xF0
	private Shape _value13; // 0x104
	private Shape _value14; // 0x118
	private Shape _value15; // 0x12C

	// Properties
	public int Length { get; }
	public Shape Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1FA8BA0 Offset: 0x1FA8CA1 VA: 0x1FA8BA0
	public int get_Length() { }

	// RVA: 0x1FA8BB0 Offset: 0x1FA8CB1 VA: 0x1FA8BB0 Slot: 4
	public Shape get_Item(int index) { }

	// RVA: 0x1FA8D10 Offset: 0x1FA8E11 VA: 0x1FA8D10 Slot: 5
	public void set_Item(int index, Shape value) { }

	// RVA: 0x1FA8F40 Offset: 0x1FA9041 VA: 0x1FA8F40 Slot: 9
	public int get_Count() { }

	// RVA: 0x1FA8F50 Offset: 0x1FA9051 VA: 0x1FA8F50 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1FA8F60 Offset: 0x1FA9061 VA: 0x1FA8F60 Slot: 13
	public bool Contains(Shape item) { }

	// RVA: 0x1FA8FF0 Offset: 0x1FA90F1 VA: 0x1FA8FF0 Slot: 6
	public int IndexOf(Shape item) { }

	// RVA: 0x1FA9080 Offset: 0x1FA9181 VA: 0x1FA9080 Slot: 14
	public void CopyTo(Shape[] array, int arrayIndex) { }

	// RVA: 0x1FA94A0 Offset: 0x1FA95A1 VA: 0x1FA94A0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D0FA0 Offset: 0x2D10A1 VA: 0x2D0FA0
	// RVA: 0x1FA9AC0 Offset: 0x1FA9BC1 VA: 0x1FA9AC0 Slot: 16
	public IEnumerator<Shape> GetEnumerator() { }

	// RVA: 0x1FA9B40 Offset: 0x1FA9C41 VA: 0x1FA9B40 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1FA9BC0 Offset: 0x1FA9CC1 VA: 0x1FA9BC0 Slot: 11
	public void Add(Shape item) { }

	// RVA: 0x1FA9C00 Offset: 0x1FA9D01 VA: 0x1FA9C00 Slot: 12
	public void Clear() { }

	// RVA: 0x1FA9C40 Offset: 0x1FA9D41 VA: 0x1FA9C40 Slot: 7
	public void Insert(int index, Shape item) { }

	// RVA: 0x1FA9C80 Offset: 0x1FA9D81 VA: 0x1FA9C80 Slot: 15
	public bool Remove(Shape item) { }

	// RVA: 0x1FA9CC0 Offset: 0x1FA9DC1 VA: 0x1FA9CC0 Slot: 8
	public void RemoveAt(int index) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A510 Offset: 0x27A611 VA: 0x27A510
private sealed class HandAnalysisSilhouetteState.HandArray2.<GetEnumerator>d__16 : IEnumerator<Hand>, IEnumerator, IDisposable // TypeDefIndex: 14586
{
	// Fields
	private int <>1__state; // 0x10
	private Hand <>2__current; // 0x14
	public HandAnalysisSilhouetteState.HandArray2 <>4__this; // 0x118

	// Properties
	private Hand System.Collections.Generic.IEnumerator<nn.irsensor.Hand>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2D10D0 Offset: 0x2D11D1 VA: 0x2D10D0
	// RVA: 0x1DCDD10 Offset: 0x1DCDE11 VA: 0x1DCDD10
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2D10E0 Offset: 0x2D11E1 VA: 0x2D10E0
	// RVA: 0x1DCDD40 Offset: 0x1DCDE41 VA: 0x1DCDD40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DCDD50 Offset: 0x1DCDE51 VA: 0x1DCDD50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D10F0 Offset: 0x2D11F1 VA: 0x2D10F0
	// RVA: 0x1DCDDC0 Offset: 0x1DCDEC1 VA: 0x1DCDDC0 Slot: 4
	private Hand System.Collections.Generic.IEnumerator<nn.irsensor.Hand>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1100 Offset: 0x2D1201 VA: 0x2D1100
	// RVA: 0x1DCDDD0 Offset: 0x1DCDED1 VA: 0x1DCDDD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D1110 Offset: 0x2D1211 VA: 0x2D1110
	// RVA: 0x1DCDE10 Offset: 0x1DCDF11 VA: 0x1DCDE10 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

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

