// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A420 Offset: 0x27A521 VA: 0x27A420
private sealed class Hand.ProtrusionArray8.<GetEnumerator>d__22 : IEnumerator<Protrusion>, IEnumerator, IDisposable // TypeDefIndex: 14578
{
	// Fields
	private int <>1__state; // 0x10
	private Protrusion <>2__current; // 0x14
	public Hand.ProtrusionArray8 <>4__this; // 0x1C

	// Properties
	private Protrusion System.Collections.Generic.IEnumerator<nn.irsensor.Protrusion>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2D0E90 Offset: 0x2D0F91 VA: 0x2D0E90
	// RVA: 0x1DCDB80 Offset: 0x1DCDC81 VA: 0x1DCDB80
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0EA0 Offset: 0x2D0FA1 VA: 0x2D0EA0
	// RVA: 0x1DCDBB0 Offset: 0x1DCDCB1 VA: 0x1DCDBB0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DCDBC0 Offset: 0x1DCDCC1 VA: 0x1DCDBC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0EB0 Offset: 0x2D0FB1 VA: 0x2D0EB0
	// RVA: 0x1DCDC60 Offset: 0x1DCDD61 VA: 0x1DCDC60 Slot: 4
	private Protrusion System.Collections.Generic.IEnumerator<nn.irsensor.Protrusion>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0EC0 Offset: 0x2D0FC1 VA: 0x2D0EC0
	// RVA: 0x1DCDC70 Offset: 0x1DCDD71 VA: 0x1DCDC70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0ED0 Offset: 0x2D0FD1 VA: 0x2D0ED0
	// RVA: 0x1DCDCB0 Offset: 0x1DCDDB1 VA: 0x1DCDCB0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x27A3E0 Offset: 0x27A4E1 VA: 0x27A3E0
public struct Hand.ProtrusionArray8 : IList<Protrusion>, ICollection<Protrusion>, IEnumerable<Protrusion>, IEnumerable // TypeDefIndex: 14579
{
	// Fields
	private const int _Length = 8;
	private Protrusion _value0; // 0x0
	private Protrusion _value1; // 0x8
	private Protrusion _value2; // 0x10
	private Protrusion _value3; // 0x18
	private Protrusion _value4; // 0x20
	private Protrusion _value5; // 0x28
	private Protrusion _value6; // 0x30
	private Protrusion _value7; // 0x38

	// Properties
	public int Length { get; }
	public Protrusion Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1FA7900 Offset: 0x1FA7A01 VA: 0x1FA7900
	public int get_Length() { }

	// RVA: 0x1FA7910 Offset: 0x1FA7A11 VA: 0x1FA7910 Slot: 4
	public Protrusion get_Item(int index) { }

	// RVA: 0x1FA7A00 Offset: 0x1FA7B01 VA: 0x1FA7A00 Slot: 5
	public void set_Item(int index, Protrusion value) { }

	// RVA: 0x1FA7AE0 Offset: 0x1FA7BE1 VA: 0x1FA7AE0 Slot: 9
	public int get_Count() { }

	// RVA: 0x1FA7AF0 Offset: 0x1FA7BF1 VA: 0x1FA7AF0 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1FA7B00 Offset: 0x1FA7C01 VA: 0x1FA7B00 Slot: 13
	public bool Contains(Protrusion item) { }

	// RVA: 0x1FA7BD0 Offset: 0x1FA7CD1 VA: 0x1FA7BD0 Slot: 6
	public int IndexOf(Protrusion item) { }

	// RVA: 0x1FA7D10 Offset: 0x1FA7E11 VA: 0x1FA7D10 Slot: 14
	public void CopyTo(Protrusion[] array, int arrayIndex) { }

	// RVA: 0x1FA7EC0 Offset: 0x1FA7FC1 VA: 0x1FA7EC0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D0E20 Offset: 0x2D0F21 VA: 0x2D0E20
	// RVA: 0x1FA81D0 Offset: 0x1FA82D1 VA: 0x1FA81D0 Slot: 16
	public IEnumerator<Protrusion> GetEnumerator() { }

	// RVA: 0x1FA8250 Offset: 0x1FA8351 VA: 0x1FA8250 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1FA82D0 Offset: 0x1FA83D1 VA: 0x1FA82D0 Slot: 11
	public void Add(Protrusion item) { }

	// RVA: 0x1FA8310 Offset: 0x1FA8411 VA: 0x1FA8310 Slot: 12
	public void Clear() { }

	// RVA: 0x1FA8350 Offset: 0x1FA8451 VA: 0x1FA8350 Slot: 7
	public void Insert(int index, Protrusion item) { }

	// RVA: 0x1FA8390 Offset: 0x1FA8491 VA: 0x1FA8390 Slot: 15
	public bool Remove(Protrusion item) { }

	// RVA: 0x1FA83D0 Offset: 0x1FA84D1 VA: 0x1FA83D0 Slot: 8
	public void RemoveAt(int index) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A470 Offset: 0x27A571 VA: 0x27A470
private sealed class Hand.Fingers.<GetEnumerator>d__19 : IEnumerator<Finger>, IEnumerator, IDisposable // TypeDefIndex: 14580
{
	// Fields
	private int <>1__state; // 0x10
	private Finger <>2__current; // 0x14
	public Hand.Fingers <>4__this; // 0x30

	// Properties
	private Finger System.Collections.Generic.IEnumerator<nn.irsensor.Finger>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2D0F50 Offset: 0x2D1051 VA: 0x2D0F50
	// RVA: 0x1DCD9D0 Offset: 0x1DCDAD1 VA: 0x1DCD9D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0F60 Offset: 0x2D1061 VA: 0x2D0F60
	// RVA: 0x1DCDA00 Offset: 0x1DCDB01 VA: 0x1DCDA00 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DCDA10 Offset: 0x1DCDB11 VA: 0x1DCDA10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0F70 Offset: 0x2D1071 VA: 0x2D0F70
	// RVA: 0x1DCDAA0 Offset: 0x1DCDBA1 VA: 0x1DCDAA0 Slot: 4
	private Finger System.Collections.Generic.IEnumerator<nn.irsensor.Finger>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0F80 Offset: 0x2D1081 VA: 0x2D0F80
	// RVA: 0x1DCDAC0 Offset: 0x1DCDBC1 VA: 0x1DCDAC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0F90 Offset: 0x2D1091 VA: 0x2D0F90
	// RVA: 0x1DCDB00 Offset: 0x1DCDC01 VA: 0x1DCDB00 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

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

