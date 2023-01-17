// Namespace: UniRx.Async.Triggers
public class AsyncTriggerPromise<T> : ReusablePromise<T>, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise, ICancelablePromise // TypeDefIndex: 5189
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29CE0 Offset: 0x29DE1 VA: 0x29CE0
	private CancellationToken <RegisteredCancellationToken>k__BackingField; // 0x0

	// Properties
	public CancellationToken RegisteredCancellationToken { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2E0D0 Offset: 0x2E1D1 VA: 0x2E0D0
	// RVA: -1 Offset: -1 Slot: 18
	public CancellationToken get_RegisteredCancellationToken() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F53F10 Offset: 0x2F54011 VA: 0x2F53F10
	|-AsyncTriggerPromise<AsyncUnit>.get_RegisteredCancellationToken
	|
	|-RVA: 0x2F54170 Offset: 0x2F54271 VA: 0x2F54170
	|-AsyncTriggerPromise<int>.get_RegisteredCancellationToken
	|
	|-RVA: 0x2F543D0 Offset: 0x2F544D1 VA: 0x2F543D0
	|-AsyncTriggerPromise<object>.get_RegisteredCancellationToken
	|
	|-RVA: 0x2F54630 Offset: 0x2F54731 VA: 0x2F54630
	|-AsyncTriggerPromise<float>.get_RegisteredCancellationToken
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2E0E0 Offset: 0x2E1E1 VA: 0x2E0E0
	// RVA: -1 Offset: -1
	private void set_RegisteredCancellationToken(CancellationToken value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F53F20 Offset: 0x2F54021 VA: 0x2F53F20
	|-AsyncTriggerPromise<AsyncUnit>.set_RegisteredCancellationToken
	|
	|-RVA: 0x2F54180 Offset: 0x2F54281 VA: 0x2F54180
	|-AsyncTriggerPromise<int>.set_RegisteredCancellationToken
	|
	|-RVA: 0x2F543E0 Offset: 0x2F544E1 VA: 0x2F543E0
	|-AsyncTriggerPromise<object>.set_RegisteredCancellationToken
	|
	|-RVA: 0x2F54640 Offset: 0x2F54741 VA: 0x2F54640
	|-AsyncTriggerPromise<float>.set_RegisteredCancellationToken
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F53F30 Offset: 0x2F54031 VA: 0x2F53F30
	|-AsyncTriggerPromise<AsyncUnit>..ctor
	|
	|-RVA: 0x2F54190 Offset: 0x2F54291 VA: 0x2F54190
	|-AsyncTriggerPromise<int>..ctor
	|
	|-RVA: 0x2F543F0 Offset: 0x2F544F1 VA: 0x2F543F0
	|-AsyncTriggerPromise<object>..ctor
	|
	|-RVA: 0x2F54650 Offset: 0x2F54751 VA: 0x2F54650
	|-AsyncTriggerPromise<float>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F53FC0 Offset: 0x2F540C1 VA: 0x2F53FC0
	|-AsyncTriggerPromise<AsyncUnit>..ctor
	|
	|-RVA: 0x2F54220 Offset: 0x2F54321 VA: 0x2F54220
	|-AsyncTriggerPromise<int>..ctor
	|
	|-RVA: 0x2F54480 Offset: 0x2F54581 VA: 0x2F54480
	|-AsyncTriggerPromise<object>..ctor
	|
	|-RVA: 0x2F546E0 Offset: 0x2F547E1 VA: 0x2F546E0
	|-AsyncTriggerPromise<float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F54020 Offset: 0x2F54121 VA: 0x2F54020
	|-AsyncTriggerPromise<AsyncUnit>.GetResult
	|
	|-RVA: 0x2F54280 Offset: 0x2F54381 VA: 0x2F54280
	|-AsyncTriggerPromise<int>.GetResult
	|
	|-RVA: 0x2F544E0 Offset: 0x2F545E1 VA: 0x2F544E0
	|-AsyncTriggerPromise<object>.GetResult
	|
	|-RVA: 0x2F54740 Offset: 0x2F54841 VA: 0x2F54740
	|-AsyncTriggerPromise<float>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override bool TrySetResult(T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F54080 Offset: 0x2F54181 VA: 0x2F54080
	|-AsyncTriggerPromise<AsyncUnit>.TrySetResult
	|
	|-RVA: 0x2F542E0 Offset: 0x2F543E1 VA: 0x2F542E0
	|-AsyncTriggerPromise<int>.TrySetResult
	|
	|-RVA: 0x2F54540 Offset: 0x2F54641 VA: 0x2F54540
	|-AsyncTriggerPromise<object>.TrySetResult
	|
	|-RVA: 0x2F547A0 Offset: 0x2F548A1 VA: 0x2F547A0
	|-AsyncTriggerPromise<float>.TrySetResult
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F54110 Offset: 0x2F54211 VA: 0x2F54110
	|-AsyncTriggerPromise<AsyncUnit>.TrySetCanceled
	|
	|-RVA: 0x2F54370 Offset: 0x2F54471 VA: 0x2F54370
	|-AsyncTriggerPromise<int>.TrySetCanceled
	|
	|-RVA: 0x2F545D0 Offset: 0x2F546D1 VA: 0x2F545D0
	|-AsyncTriggerPromise<object>.TrySetCanceled
	|
	|-RVA: 0x2F54830 Offset: 0x2F54931 VA: 0x2F54830
	|-AsyncTriggerPromise<float>.TrySetCanceled
	*/
}

