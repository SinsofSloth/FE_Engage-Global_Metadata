// Namespace: 
[Serializable]
private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1372
{
	// Fields
	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x35F2950 Offset: 0x35F2A51 VA: 0x35F2950
	internal void .ctor(Queue q) { }

	// RVA: 0x35F29E0 Offset: 0x35F2AE1 VA: 0x35F29E0 Slot: 7
	public object Clone() { }

	// RVA: 0x35F29F0 Offset: 0x35F2AF1 VA: 0x35F29F0 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x35F2AE0 Offset: 0x35F2BE1 VA: 0x35F2AE0 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x35F2B80 Offset: 0x35F2C81 VA: 0x35F2B80 Slot: 10
	public virtual void Reset() { }
}

// Namespace: 
internal class Queue.QueueDebugView // TypeDefIndex: 1373
{}

// Namespace: 
[Serializable]
public struct Queue.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 2415
{
	// Fields
	private readonly Queue<T> _q; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Queue<T> q) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAEAF0 Offset: 0x2EAEBF1 VA: 0x2EAEAF0
	|-Queue.Enumerator<TimeInterval<object>>..ctor
	|
	|-RVA: 0x2EAEE40 Offset: 0x2EAEF41 VA: 0x2EAEE40
	|-Queue.Enumerator<Timestamped<object>>..ctor
	|
	|-RVA: 0x2EB0430 Offset: 0x2EB0531 VA: 0x2EB0430
	|-Queue.Enumerator<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x2EB2120 Offset: 0x2EB2221 VA: 0x2EB2120
	|-Queue.Enumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EB6590 Offset: 0x2EB6691 VA: 0x2EB6590
	|-Queue.Enumerator<int>..ctor
	|
	|-RVA: 0x2EB9810 Offset: 0x2EB9911 VA: 0x2EB9810
	|-Queue.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAEB30 Offset: 0x2EAEC31 VA: 0x2EAEB30
	|-Queue.Enumerator<TimeInterval<object>>.Dispose
	|
	|-RVA: 0x2EAEE80 Offset: 0x2EAEF81 VA: 0x2EAEE80
	|-Queue.Enumerator<Timestamped<object>>.Dispose
	|
	|-RVA: 0x2EB0470 Offset: 0x2EB0571 VA: 0x2EB0470
	|-Queue.Enumerator<ValueTuple<object, float>>.Dispose
	|
	|-RVA: 0x2EB2160 Offset: 0x2EB2261 VA: 0x2EB2160
	|-Queue.Enumerator<AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x2EB65D0 Offset: 0x2EB66D1 VA: 0x2EB65D0
	|-Queue.Enumerator<int>.Dispose
	|
	|-RVA: 0x2EB9850 Offset: 0x2EB9951 VA: 0x2EB9850
	|-Queue.Enumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAEB40 Offset: 0x2EAEC41 VA: 0x2EAEB40
	|-Queue.Enumerator<TimeInterval<object>>.MoveNext
	|
	|-RVA: 0x2EAEEA0 Offset: 0x2EAEFA1 VA: 0x2EAEEA0
	|-Queue.Enumerator<Timestamped<object>>.MoveNext
	|
	|-RVA: 0x2EB0480 Offset: 0x2EB0581 VA: 0x2EB0480
	|-Queue.Enumerator<ValueTuple<object, float>>.MoveNext
	|
	|-RVA: 0x2EB2180 Offset: 0x2EB2281 VA: 0x2EB2180
	|-Queue.Enumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x2EB65E0 Offset: 0x2EB66E1 VA: 0x2EB65E0
	|-Queue.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2EB9860 Offset: 0x2EB9961 VA: 0x2EB9860
	|-Queue.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAEC60 Offset: 0x2EAED61 VA: 0x2EAEC60
	|-Queue.Enumerator<TimeInterval<object>>.get_Current
	|
	|-RVA: 0x2EAEFD0 Offset: 0x2EAF0D1 VA: 0x2EAEFD0
	|-Queue.Enumerator<Timestamped<object>>.get_Current
	|
	|-RVA: 0x2EB05A0 Offset: 0x2EB06A1 VA: 0x2EB05A0
	|-Queue.Enumerator<ValueTuple<object, float>>.get_Current
	|
	|-RVA: 0x2EB22B0 Offset: 0x2EB23B1 VA: 0x2EB22B0
	|-Queue.Enumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x2EB66F0 Offset: 0x2EB67F1 VA: 0x2EB66F0
	|-Queue.Enumerator<int>.get_Current
	|
	|-RVA: 0x2EB9970 Offset: 0x2EB9A71 VA: 0x2EB9970
	|-Queue.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAECA0 Offset: 0x2EAEDA1 VA: 0x2EAECA0
	|-Queue.Enumerator<TimeInterval<object>>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EAF020 Offset: 0x2EAF121 VA: 0x2EAF020
	|-Queue.Enumerator<Timestamped<object>>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EB05E0 Offset: 0x2EB06E1 VA: 0x2EB05E0
	|-Queue.Enumerator<ValueTuple<object, float>>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EB2300 Offset: 0x2EB2401 VA: 0x2EB2300
	|-Queue.Enumerator<AsyncOperationHandle>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EB6730 Offset: 0x2EB6831 VA: 0x2EB6730
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EB99B0 Offset: 0x2EB9AB1 VA: 0x2EB99B0
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAED10 Offset: 0x2EAEE11 VA: 0x2EAED10
	|-Queue.Enumerator<TimeInterval<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EAF090 Offset: 0x2EAF191 VA: 0x2EAF090
	|-Queue.Enumerator<Timestamped<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB0650 Offset: 0x2EB0751 VA: 0x2EB0650
	|-Queue.Enumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB2370 Offset: 0x2EB2471 VA: 0x2EB2370
	|-Queue.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB67A0 Offset: 0x2EB68A1 VA: 0x2EB67A0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB9A20 Offset: 0x2EB9B21 VA: 0x2EB9A20
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAEDC0 Offset: 0x2EAEEC1 VA: 0x2EAEDC0
	|-Queue.Enumerator<TimeInterval<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EAF140 Offset: 0x2EAF241 VA: 0x2EAF140
	|-Queue.Enumerator<Timestamped<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB0700 Offset: 0x2EB0801 VA: 0x2EB0700
	|-Queue.Enumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB2420 Offset: 0x2EB2521 VA: 0x2EB2420
	|-Queue.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB6840 Offset: 0x2EB6941 VA: 0x2EB6840
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB9A80 Offset: 0x2EB9B81 VA: 0x2EB9A80
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/
}

