// Namespace: UniRx
public class CoroutineAsyncBridge : INotifyCompletion // TypeDefIndex: 6669
{
	// Fields
	private Action continuation; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x13B60 Offset: 0x13C61 VA: 0x13B60
	private bool <IsCompleted>k__BackingField; // 0x18

	// Properties
	public bool IsCompleted { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x163A0 Offset: 0x164A1 VA: 0x163A0
	// RVA: 0x19CF8E0 Offset: 0x19CF9E1 VA: 0x19CF8E0
	public bool get_IsCompleted() { }

	[CompilerGeneratedAttribute] // RVA: 0x163B0 Offset: 0x164B1 VA: 0x163B0
	// RVA: 0x19CF8F0 Offset: 0x19CF9F1 VA: 0x19CF8F0
	private void set_IsCompleted(bool value) { }

	// RVA: 0x19CF900 Offset: 0x19CFA01 VA: 0x19CF900
	private void .ctor() { }

	// RVA: -1 Offset: -1
	public static CoroutineAsyncBridge Start<T>(T awaitTarget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D610 Offset: 0x229D711 VA: 0x229D610
	|-CoroutineAsyncBridge.Start<Coroutine>
	|-CoroutineAsyncBridge.Start<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x163C0 Offset: 0x164C1 VA: 0x163C0
	// RVA: -1 Offset: -1
	private IEnumerator Run<T>(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D580 Offset: 0x229D681 VA: 0x229D580
	|-CoroutineAsyncBridge.Run<object>
	*/

	// RVA: 0x19CF930 Offset: 0x19CFA31 VA: 0x19CF930 Slot: 4
	public void OnCompleted(Action continuation) { }

	// RVA: 0x19CF940 Offset: 0x19CFA41 VA: 0x19CF940
	public void GetResult() { }
}

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

