// Namespace: System.Threading.Tasks
public class TaskCompletionSource<TResult> // TypeDefIndex: 848
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3D50 Offset: 0x34C3E51 VA: 0x34C3D50
	|-TaskCompletionSource<ValueTuple<bool, object>>..ctor
	|-TaskCompletionSource<ValueTuple<bool, WebOperation>>..ctor
	|
	|-RVA: 0x34C4140 Offset: 0x34C4241 VA: 0x34C4140
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x34C4540 Offset: 0x34C4641 VA: 0x34C4540
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0x34C4930 Offset: 0x34C4A31 VA: 0x34C4930
	|-TaskCompletionSource<object>..ctor
	|-TaskCompletionSource<WebRequestStream>..ctor
	|-TaskCompletionSource<WebResponseStream>..ctor
	|-TaskCompletionSource<WebCompletionSource.Result>..ctor
	|
	|-RVA: 0x34C4D20 Offset: 0x34C4E21 VA: 0x34C4D20
	|-TaskCompletionSource<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3DD0 Offset: 0x34C3ED1 VA: 0x34C3DD0
	|-TaskCompletionSource<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x34C41C0 Offset: 0x34C42C1 VA: 0x34C41C0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x34C45C0 Offset: 0x34C46C1 VA: 0x34C45C0
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0x34C49B0 Offset: 0x34C4AB1 VA: 0x34C49B0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x34C4DA0 Offset: 0x34C4EA1 VA: 0x34C4DA0
	|-TaskCompletionSource<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3DF0 Offset: 0x34C3EF1 VA: 0x34C3DF0
	|-TaskCompletionSource<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x34C41E0 Offset: 0x34C42E1 VA: 0x34C41E0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x34C45E0 Offset: 0x34C46E1 VA: 0x34C45E0
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0x34C49D0 Offset: 0x34C4AD1 VA: 0x34C49D0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x34C4DC0 Offset: 0x34C4EC1 VA: 0x34C4DC0
	|-TaskCompletionSource<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3E80 Offset: 0x34C3F81 VA: 0x34C3E80
	|-TaskCompletionSource<ValueTuple<bool, object>>.get_Task
	|-TaskCompletionSource<ValueTuple<bool, WebOperation>>.get_Task
	|
	|-RVA: 0x34C4270 Offset: 0x34C4371 VA: 0x34C4270
	|-TaskCompletionSource<bool>.get_Task
	|
	|-RVA: 0x34C4670 Offset: 0x34C4771 VA: 0x34C4670
	|-TaskCompletionSource<long>.get_Task
	|
	|-RVA: 0x34C4A60 Offset: 0x34C4B61 VA: 0x34C4A60
	|-TaskCompletionSource<object>.get_Task
	|-TaskCompletionSource<WebRequestStream>.get_Task
	|-TaskCompletionSource<WebResponseStream>.get_Task
	|-TaskCompletionSource<WebCompletionSource.Result>.get_Task
	|
	|-RVA: 0x34C4E50 Offset: 0x34C4F51 VA: 0x34C4E50
	|-TaskCompletionSource<SceneInstance>.get_Task
	*/

	// RVA: -1 Offset: -1
	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3E90 Offset: 0x34C3F91 VA: 0x34C3E90
	|-TaskCompletionSource<ValueTuple<bool, object>>.SpinUntilCompleted
	|
	|-RVA: 0x34C4280 Offset: 0x34C4381 VA: 0x34C4280
	|-TaskCompletionSource<bool>.SpinUntilCompleted
	|
	|-RVA: 0x34C4680 Offset: 0x34C4781 VA: 0x34C4680
	|-TaskCompletionSource<long>.SpinUntilCompleted
	|
	|-RVA: 0x34C4A70 Offset: 0x34C4B71 VA: 0x34C4A70
	|-TaskCompletionSource<object>.SpinUntilCompleted
	|
	|-RVA: 0x34C4E60 Offset: 0x34C4F61 VA: 0x34C4E60
	|-TaskCompletionSource<SceneInstance>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3EE0 Offset: 0x34C3FE1 VA: 0x34C3EE0
	|-TaskCompletionSource<ValueTuple<bool, object>>.TrySetException
	|-TaskCompletionSource<ValueTuple<bool, WebOperation>>.TrySetException
	|
	|-RVA: 0x34C42D0 Offset: 0x34C43D1 VA: 0x34C42D0
	|-TaskCompletionSource<bool>.TrySetException
	|
	|-RVA: 0x34C46D0 Offset: 0x34C47D1 VA: 0x34C46D0
	|-TaskCompletionSource<long>.TrySetException
	|
	|-RVA: 0x34C4AC0 Offset: 0x34C4BC1 VA: 0x34C4AC0
	|-TaskCompletionSource<object>.TrySetException
	|-TaskCompletionSource<WebRequestStream>.TrySetException
	|-TaskCompletionSource<WebResponseStream>.TrySetException
	|
	|-RVA: 0x34C4EB0 Offset: 0x34C4FB1 VA: 0x34C4EB0
	|-TaskCompletionSource<SceneInstance>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3FA0 Offset: 0x34C40A1 VA: 0x34C3FA0
	|-TaskCompletionSource<ValueTuple<bool, object>>.TrySetResult
	|-TaskCompletionSource<ValueTuple<bool, WebOperation>>.TrySetResult
	|
	|-RVA: 0x34C4390 Offset: 0x34C4491 VA: 0x34C4390
	|-TaskCompletionSource<bool>.TrySetResult
	|
	|-RVA: 0x34C4790 Offset: 0x34C4891 VA: 0x34C4790
	|-TaskCompletionSource<long>.TrySetResult
	|
	|-RVA: 0x34C4B80 Offset: 0x34C4C81 VA: 0x34C4B80
	|-TaskCompletionSource<object>.TrySetResult
	|-TaskCompletionSource<WebRequestStream>.TrySetResult
	|-TaskCompletionSource<WebResponseStream>.TrySetResult
	|-TaskCompletionSource<WebCompletionSource.Result>.TrySetResult
	|
	|-RVA: 0x34C4F70 Offset: 0x34C5071 VA: 0x34C4F70
	|-TaskCompletionSource<SceneInstance>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C4020 Offset: 0x34C4121 VA: 0x34C4020
	|-TaskCompletionSource<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x34C4410 Offset: 0x34C4511 VA: 0x34C4410
	|-TaskCompletionSource<bool>.SetResult
	|
	|-RVA: 0x34C4810 Offset: 0x34C4911 VA: 0x34C4810
	|-TaskCompletionSource<long>.SetResult
	|
	|-RVA: 0x34C4C00 Offset: 0x34C4D01 VA: 0x34C4C00
	|-TaskCompletionSource<object>.SetResult
	|
	|-RVA: 0x34C4FF0 Offset: 0x34C50F1 VA: 0x34C4FF0
	|-TaskCompletionSource<SceneInstance>.SetResult
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C40A0 Offset: 0x34C41A1 VA: 0x34C40A0
	|-TaskCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x34C44A0 Offset: 0x34C45A1 VA: 0x34C44A0
	|-TaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0x34C4890 Offset: 0x34C4991 VA: 0x34C4890
	|-TaskCompletionSource<long>.TrySetCanceled
	|
	|-RVA: 0x34C4C80 Offset: 0x34C4D81 VA: 0x34C4C80
	|-TaskCompletionSource<object>.TrySetCanceled
	|-TaskCompletionSource<WebRequestStream>.TrySetCanceled
	|-TaskCompletionSource<WebResponseStream>.TrySetCanceled
	|
	|-RVA: 0x34C5070 Offset: 0x34C5171 VA: 0x34C5070
	|-TaskCompletionSource<SceneInstance>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C40C0 Offset: 0x34C41C1 VA: 0x34C40C0
	|-TaskCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x34C44C0 Offset: 0x34C45C1 VA: 0x34C44C0
	|-TaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0x34C48B0 Offset: 0x34C49B1 VA: 0x34C48B0
	|-TaskCompletionSource<long>.TrySetCanceled
	|
	|-RVA: 0x34C4CA0 Offset: 0x34C4DA1 VA: 0x34C4CA0
	|-TaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x34C5090 Offset: 0x34C5191 VA: 0x34C5090
	|-TaskCompletionSource<SceneInstance>.TrySetCanceled
	*/
}

