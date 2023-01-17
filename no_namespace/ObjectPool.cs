// Namespace: 
public struct ObjectPool.PooledObject<T> : IDisposable // TypeDefIndex: 4531
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly ObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T value, ObjectPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61750 Offset: 0x2A61851 VA: 0x2A61750
	|-ObjectPool.PooledObject<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61790 Offset: 0x2A61891 VA: 0x2A61790
	|-ObjectPool.PooledObject<object>.System.IDisposable.Dispose
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x138C0 Offset: 0x139C1 VA: 0x138C0
private sealed class ObjectPool.<>c__DisplayClass14_0<T> // TypeDefIndex: 6839
{
	// Fields
	public ObjectPool<T> <>4__this; // 0x0
	public float instanceCountRatio; // 0x0
	public int minSize; // 0x0
	public bool callOnBeforeRent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B383F0 Offset: 0x2B384F1 VA: 0x2B383F0
	|-ObjectPool.<>c__DisplayClass14_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <StartShrinkTimer>b__0(long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38400 Offset: 0x2B38501 VA: 0x2B38400
	|-ObjectPool.<>c__DisplayClass14_0<object>.<StartShrinkTimer>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <StartShrinkTimer>b__1(long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38420 Offset: 0x2B38521 VA: 0x2B38420
	|-ObjectPool.<>c__DisplayClass14_0<object>.<StartShrinkTimer>b__1
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x138D0 Offset: 0x139D1 VA: 0x138D0
private sealed class ObjectPool.<>c__DisplayClass15_0<T> // TypeDefIndex: 6840
{
	// Fields
	public ObjectPool<T> <>4__this; // 0x0
	public int preloadCount; // 0x0
	public int threshold; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38850 Offset: 0x2B38951 VA: 0x2B38850
	|-ObjectPool.<>c__DisplayClass15_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <PreloadAsync>b__0(IObserver<Unit> observer, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38860 Offset: 0x2B38961 VA: 0x2B38860
	|-ObjectPool.<>c__DisplayClass15_0<object>.<PreloadAsync>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x138E0 Offset: 0x139E1 VA: 0x138E0
private sealed class ObjectPool.<PreloadCore>d__16<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6841
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public int preloadCount; // 0x0
	public ObjectPool<T> <>4__this; // 0x0
	public int threshold; // 0x0
	public IObserver<Unit> observer; // 0x0
	public CancellationToken cancellationToken; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x17EA0 Offset: 0x17FA1 VA: 0x17EA0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31521A0 Offset: 0x31522A1 VA: 0x31521A0
	|-ObjectPool.<PreloadCore>d__16<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x17EB0 Offset: 0x17FB1 VA: 0x17EB0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31521D0 Offset: 0x31522D1 VA: 0x31521D0
	|-ObjectPool.<PreloadCore>d__16<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31521E0 Offset: 0x31522E1 VA: 0x31521E0
	|-ObjectPool.<PreloadCore>d__16<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x17EC0 Offset: 0x17FC1 VA: 0x17EC0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152590 Offset: 0x3152691 VA: 0x3152590
	|-ObjectPool.<PreloadCore>d__16<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x17ED0 Offset: 0x17FD1 VA: 0x17ED0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31525A0 Offset: 0x31526A1 VA: 0x31525A0
	|-ObjectPool.<PreloadCore>d__16<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x17EE0 Offset: 0x17FE1 VA: 0x17EE0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31525E0 Offset: 0x31526E1 VA: 0x31525E0
	|-ObjectPool.<PreloadCore>d__16<object>.System.Collections.IEnumerator.get_Current
	*/
}

