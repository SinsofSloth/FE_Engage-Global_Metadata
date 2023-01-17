// Namespace: System.Threading.Tasks
internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 846
{
	// Fields
	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF92A0 Offset: 0x2DF93A1 VA: 0x2DF92A0
	|-UnwrapPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9480 Offset: 0x2DF9581 VA: 0x2DF9480
	|-UnwrapPromise<object>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9590 Offset: 0x2DF9691 VA: 0x2DF9590
	|-UnwrapPromise<object>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9600 Offset: 0x2DF9701 VA: 0x2DF9600
	|-UnwrapPromise<object>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9800 Offset: 0x2DF9901 VA: 0x2DF9800
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9960 Offset: 0x2DF9A61 VA: 0x2DF9960
	|-UnwrapPromise<object>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9C30 Offset: 0x2DF9D31 VA: 0x2DF9C30
	|-UnwrapPromise<object>.ProcessInnerTask
	*/
}

