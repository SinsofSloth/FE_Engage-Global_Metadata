// Namespace: UniRx
public class CoroutineAsyncBridge<T> : INotifyCompletion // TypeDefIndex: 6671
{
	// Fields
	private readonly T result; // 0x0
	private Action continuation; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13B70 Offset: 0x13C71 VA: 0x13B70
	private bool <IsCompleted>k__BackingField; // 0x0

	// Properties
	public bool IsCompleted { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x16480 Offset: 0x16581 VA: 0x16480
	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DA20 Offset: 0x250DB21 VA: 0x250DA20
	|-CoroutineAsyncBridge<object>.get_IsCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x16490 Offset: 0x16591 VA: 0x16490
	// RVA: -1 Offset: -1
	private void set_IsCompleted(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DA30 Offset: 0x250DB31 VA: 0x250DA30
	|-CoroutineAsyncBridge<object>.set_IsCompleted
	*/

	// RVA: -1 Offset: -1
	private void .ctor(T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DA40 Offset: 0x250DB41 VA: 0x250DA40
	|-CoroutineAsyncBridge<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static CoroutineAsyncBridge<T> Start(T awaitTarget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DAA0 Offset: 0x250DBA1 VA: 0x250DAA0
	|-CoroutineAsyncBridge<object>.Start
	*/

	[IteratorStateMachineAttribute] // RVA: 0x164A0 Offset: 0x165A1 VA: 0x164A0
	// RVA: -1 Offset: -1
	private IEnumerator Run(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DC20 Offset: 0x250DD21 VA: 0x250DC20
	|-CoroutineAsyncBridge<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DCB0 Offset: 0x250DDB1 VA: 0x250DCB0
	|-CoroutineAsyncBridge<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	public T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DCC0 Offset: 0x250DDC1 VA: 0x250DCC0
	|-CoroutineAsyncBridge<object>.GetResult
	*/
}

