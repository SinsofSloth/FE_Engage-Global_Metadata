// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13320 Offset: 0x13421 VA: 0x13320
private sealed class ObserveExtensions.<PublishPocoValueChanged>d__4<TSource, TProperty> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6733
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public TProperty firstValue; // 0x0
	public WeakReference sourceReference; // 0x0
	public Func<TSource, TProperty> propertySelector; // 0x0
	public IObserver<TProperty> observer; // 0x0
	public IEqualityComparer<TProperty> comparer; // 0x0
	public CancellationToken cancellationToken; // 0x0
	private TProperty <prevValue>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x16E20 Offset: 0x16F21 VA: 0x16E20
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31525F0 Offset: 0x31526F1 VA: 0x31525F0
	|-ObserveExtensions.<PublishPocoValueChanged>d__4<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16E30 Offset: 0x16F31 VA: 0x16E30
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152620 Offset: 0x3152721 VA: 0x3152620
	|-ObserveExtensions.<PublishPocoValueChanged>d__4<object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152630 Offset: 0x3152731 VA: 0x3152630
	|-ObserveExtensions.<PublishPocoValueChanged>d__4<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16E40 Offset: 0x16F41 VA: 0x16E40
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152A70 Offset: 0x3152B71 VA: 0x3152A70
	|-ObserveExtensions.<PublishPocoValueChanged>d__4<object, object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16E50 Offset: 0x16F51 VA: 0x16E50
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152A80 Offset: 0x3152B81 VA: 0x3152A80
	|-ObserveExtensions.<PublishPocoValueChanged>d__4<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16E60 Offset: 0x16F61 VA: 0x16E60
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152AC0 Offset: 0x3152BC1 VA: 0x3152AC0
	|-ObserveExtensions.<PublishPocoValueChanged>d__4<object, object>.System.Collections.IEnumerator.get_Current
	*/
}

