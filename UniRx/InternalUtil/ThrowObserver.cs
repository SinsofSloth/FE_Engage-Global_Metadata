// Namespace: UniRx.InternalUtil
public class ThrowObserver<T> : IObserver<T> // TypeDefIndex: 7238
{
	// Fields
	public static readonly ThrowObserver<T> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399CA10 Offset: 0x399CB11 VA: 0x399CA10
	|-ThrowObserver<object>..ctor
	|
	|-RVA: 0x399CB30 Offset: 0x399CC31 VA: 0x399CB30
	|-ThrowObserver<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399CA20 Offset: 0x399CB21 VA: 0x399CA20
	|-ThrowObserver<object>.OnCompleted
	|
	|-RVA: 0x399CB40 Offset: 0x399CC41 VA: 0x399CB40
	|-ThrowObserver<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399CA30 Offset: 0x399CB31 VA: 0x399CA30
	|-ThrowObserver<object>.OnError
	|
	|-RVA: 0x399CB50 Offset: 0x399CC51 VA: 0x399CB50
	|-ThrowObserver<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399CA40 Offset: 0x399CB41 VA: 0x399CA40
	|-ThrowObserver<object>.OnNext
	|
	|-RVA: 0x399CB60 Offset: 0x399CC61 VA: 0x399CB60
	|-ThrowObserver<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399CA50 Offset: 0x399CB51 VA: 0x399CA50
	|-ThrowObserver<object>..cctor
	|
	|-RVA: 0x399CB70 Offset: 0x399CC71 VA: 0x399CB70
	|-ThrowObserver<Unit>..cctor
	*/
}

