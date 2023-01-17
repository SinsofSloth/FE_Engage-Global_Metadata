// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12FB0 Offset: 0x130B1 VA: 0x12FB0
private sealed class AsyncOperationExtensions.<>c__DisplayClass0_0 // TypeDefIndex: 6664
{
	// Fields
	public AsyncOperation asyncOperation; // 0x10
	public IProgress<float> progress; // 0x18

	// Methods

	// RVA: 0x1AFD1F0 Offset: 0x1AFD2F1 VA: 0x1AFD1F0
	public void .ctor() { }

	// RVA: 0x1AFD200 Offset: 0x1AFD301 VA: 0x1AFD200
	internal IEnumerator <AsObservable>b__0(IObserver<AsyncOperation> observer, CancellationToken cancellation) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12FC0 Offset: 0x130C1 VA: 0x12FC0
private sealed class AsyncOperationExtensions.<>c__DisplayClass1_0<T> // TypeDefIndex: 6665
{
	// Fields
	public T asyncOperation; // 0x0
	public IProgress<float> progress; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A6E0 Offset: 0x2B3A7E1 VA: 0x2B3A6E0
	|-AsyncOperationExtensions.<>c__DisplayClass1_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <AsAsyncOperationObservable>b__0(IObserver<T> observer, CancellationToken cancellation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A6F0 Offset: 0x2B3A7F1 VA: 0x2B3A6F0
	|-AsyncOperationExtensions.<>c__DisplayClass1_0<object>.<AsAsyncOperationObservable>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12FD0 Offset: 0x130D1 VA: 0x12FD0
private sealed class AsyncOperationExtensions.<AsObservableCore>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6666
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public IProgress<float> reportProgress; // 0x0
	public T asyncOperation; // 0x0
	public IObserver<T> observer; // 0x0
	public CancellationToken cancel; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x16350 Offset: 0x16451 VA: 0x16350
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45420 Offset: 0x2B45521 VA: 0x2B45420
	|-AsyncOperationExtensions.<AsObservableCore>d__2<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16360 Offset: 0x16461 VA: 0x16360
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45450 Offset: 0x2B45551 VA: 0x2B45450
	|-AsyncOperationExtensions.<AsObservableCore>d__2<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45460 Offset: 0x2B45561 VA: 0x2B45460
	|-AsyncOperationExtensions.<AsObservableCore>d__2<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16370 Offset: 0x16471 VA: 0x16370
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45920 Offset: 0x2B45A21 VA: 0x2B45920
	|-AsyncOperationExtensions.<AsObservableCore>d__2<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16380 Offset: 0x16481 VA: 0x16380
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45930 Offset: 0x2B45A31 VA: 0x2B45930
	|-AsyncOperationExtensions.<AsObservableCore>d__2<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16390 Offset: 0x16491 VA: 0x16390
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45970 Offset: 0x2B45A71 VA: 0x2B45970
	|-AsyncOperationExtensions.<AsObservableCore>d__2<object>.System.Collections.IEnumerator.get_Current
	*/
}

