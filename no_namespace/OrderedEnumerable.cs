// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F890 Offset: 0x3F991 VA: 0x3F890
private sealed class OrderedEnumerable.<GetEnumerator>d__1<TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 2748
{
	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable<TElement> <>4__this; // 0x0
	private Buffer<TElement> <buffer>5__1; // 0x0
	private int[] <map>5__2; // 0x0
	private int <i>5__3; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x419D0 Offset: 0x41AD1 VA: 0x419D0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314F900 Offset: 0x314FA01 VA: 0x314F900
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x314FB60 Offset: 0x314FC61 VA: 0x314FB60
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>..ctor
	|
	|-RVA: 0x314FDF0 Offset: 0x314FEF1 VA: 0x314FDF0
	|-OrderedEnumerable.<GetEnumerator>d__1<int>..ctor
	|
	|-RVA: 0x3150040 Offset: 0x3150141 VA: 0x3150040
	|-OrderedEnumerable.<GetEnumerator>d__1<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x419E0 Offset: 0x41AE1 VA: 0x419E0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314F930 Offset: 0x314FA31 VA: 0x314F930
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.IDisposable.Dispose
	|
	|-RVA: 0x314FB90 Offset: 0x314FC91 VA: 0x314FB90
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.IDisposable.Dispose
	|
	|-RVA: 0x314FE20 Offset: 0x314FF21 VA: 0x314FE20
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x3150070 Offset: 0x3150171 VA: 0x3150070
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314F940 Offset: 0x314FA41 VA: 0x314F940
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x314FBA0 Offset: 0x314FCA1 VA: 0x314FBA0
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x314FE30 Offset: 0x314FF31 VA: 0x314FE30
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.MoveNext
	|
	|-RVA: 0x3150080 Offset: 0x3150181 VA: 0x3150080
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x419F0 Offset: 0x41AF1 VA: 0x419F0
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314FAC0 Offset: 0x314FBC1 VA: 0x314FAC0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x314FD30 Offset: 0x314FE31 VA: 0x314FD30
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x314FFA0 Offset: 0x31500A1 VA: 0x314FFA0
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x31501F0 Offset: 0x31502F1 VA: 0x31501F0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41A00 Offset: 0x41B01 VA: 0x41A00
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314FAD0 Offset: 0x314FBD1 VA: 0x314FAD0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x314FD50 Offset: 0x314FE51 VA: 0x314FD50
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x314FFB0 Offset: 0x31500B1 VA: 0x314FFB0
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3150200 Offset: 0x3150301 VA: 0x3150200
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41A10 Offset: 0x41B11 VA: 0x41A10
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314FB10 Offset: 0x314FC11 VA: 0x314FB10
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x314FD90 Offset: 0x314FE91 VA: 0x314FD90
	|-OrderedEnumerable.<GetEnumerator>d__1<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x314FFF0 Offset: 0x31500F1 VA: 0x314FFF0
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3150240 Offset: 0x3150341 VA: 0x3150240
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	*/
}

