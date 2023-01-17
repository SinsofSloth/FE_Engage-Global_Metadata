// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x132F0 Offset: 0x133F1 VA: 0x132F0
private sealed class ObserveExtensions.<>c__DisplayClass2_0<TSource, TProperty> // TypeDefIndex: 6730
{
	// Fields
	public Object unityObject; // 0x0
	public Func<TSource, TProperty> propertySelector; // 0x0
	public IEqualityComparer<TProperty> comparer; // 0x0
	public bool fastDestroyCheck; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3B820 Offset: 0x2B3B921 VA: 0x2B3B820
	|-ObserveExtensions.<>c__DisplayClass2_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <ObserveEveryValueChanged>b__0(IObserver<TProperty> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3B830 Offset: 0x2B3B931 VA: 0x2B3B830
	|-ObserveExtensions.<>c__DisplayClass2_0<object, object>.<ObserveEveryValueChanged>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13300 Offset: 0x13401 VA: 0x13300
private sealed class ObserveExtensions.<>c__DisplayClass2_1<TSource, TProperty> // TypeDefIndex: 6731
{
	// Fields
	public WeakReference reference; // 0x0
	public ObserveExtensions.<>c__DisplayClass2_0<TSource, TProperty> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3BBA0 Offset: 0x2B3BCA1 VA: 0x2B3BBA0
	|-ObserveExtensions.<>c__DisplayClass2_1<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <ObserveEveryValueChanged>b__1(IObserver<TProperty> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3BBB0 Offset: 0x2B3BCB1 VA: 0x2B3BBB0
	|-ObserveExtensions.<>c__DisplayClass2_1<object, object>.<ObserveEveryValueChanged>b__1
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13310 Offset: 0x13411 VA: 0x13310
private sealed class ObserveExtensions.<EmptyEnumerator>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6732
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x16DD0 Offset: 0x16ED1 VA: 0x16DD0
	// RVA: 0x1B044E0 Offset: 0x1B045E1 VA: 0x1B044E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x16DE0 Offset: 0x16EE1 VA: 0x16DE0
	// RVA: 0x1B04510 Offset: 0x1B04611 VA: 0x1B04510 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B04520 Offset: 0x1B04621 VA: 0x1B04520 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x16DF0 Offset: 0x16EF1 VA: 0x16DF0
	// RVA: 0x1B04540 Offset: 0x1B04641 VA: 0x1B04540 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x16E00 Offset: 0x16F01 VA: 0x16E00
	// RVA: 0x1B04550 Offset: 0x1B04651 VA: 0x1B04550 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x16E10 Offset: 0x16F11 VA: 0x16E10
	// RVA: 0x1B04590 Offset: 0x1B04691 VA: 0x1B04590 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13330 Offset: 0x13431 VA: 0x13330
private sealed class ObserveExtensions.<PublishUnityObjectValueChanged>d__5<TSource, TProperty> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6734
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public TProperty firstValue; // 0x0
	public Object unityObject; // 0x0
	public bool fastDestroyCheck; // 0x0
	public Func<TSource, TProperty> propertySelector; // 0x0
	public IObserver<TProperty> observer; // 0x0
	public IEqualityComparer<TProperty> comparer; // 0x0
	public CancellationToken cancellationToken; // 0x0
	private TProperty <prevValue>5__2; // 0x0
	private TSource <source>5__3; // 0x0
	private ObservableDestroyTrigger <destroyTrigger>5__4; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x16E70 Offset: 0x16F71 VA: 0x16E70
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152AD0 Offset: 0x3152BD1 VA: 0x3152AD0
	|-ObserveExtensions.<PublishUnityObjectValueChanged>d__5<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16E80 Offset: 0x16F81 VA: 0x16E80
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152B00 Offset: 0x3152C01 VA: 0x3152B00
	|-ObserveExtensions.<PublishUnityObjectValueChanged>d__5<object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152B10 Offset: 0x3152C11 VA: 0x3152B10
	|-ObserveExtensions.<PublishUnityObjectValueChanged>d__5<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16E90 Offset: 0x16F91 VA: 0x16E90
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153300 Offset: 0x3153401 VA: 0x3153300
	|-ObserveExtensions.<PublishUnityObjectValueChanged>d__5<object, object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16EA0 Offset: 0x16FA1 VA: 0x16EA0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153310 Offset: 0x3153411 VA: 0x3153310
	|-ObserveExtensions.<PublishUnityObjectValueChanged>d__5<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16EB0 Offset: 0x16FB1 VA: 0x16EB0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153350 Offset: 0x3153451 VA: 0x3153350
	|-ObserveExtensions.<PublishUnityObjectValueChanged>d__5<object, object>.System.Collections.IEnumerator.get_Current
	*/
}

