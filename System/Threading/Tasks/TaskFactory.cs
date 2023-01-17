// Namespace: System.Threading.Tasks
public class TaskFactory<TResult> // TypeDefIndex: 828
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C5110 Offset: 0x34C5211 VA: 0x34C5110
	|-TaskFactory<Nullable<int>>..ctor
	|
	|-RVA: 0x34C5F10 Offset: 0x34C6011 VA: 0x34C5F10
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x34C6D30 Offset: 0x34C6E31 VA: 0x34C6D30
	|-TaskFactory<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x34C7B30 Offset: 0x34C7C31 VA: 0x34C7B30
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x3980990 Offset: 0x3980A91 VA: 0x3980990
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x3981810 Offset: 0x3981911 VA: 0x3981810
	|-TaskFactory<bool>..ctor
	|
	|-RVA: 0x3982610 Offset: 0x3982711 VA: 0x3982610
	|-TaskFactory<int>..ctor
	|
	|-RVA: 0x3983410 Offset: 0x3983511 VA: 0x3983410
	|-TaskFactory<long>..ctor
	|
	|-RVA: 0x3984210 Offset: 0x3984311 VA: 0x3984210
	|-TaskFactory<object>..ctor
	|
	|-RVA: 0x3985010 Offset: 0x3985111 VA: 0x3985010
	|-TaskFactory<SceneInstance>..ctor
	|
	|-RVA: 0x3985E30 Offset: 0x3985F31 VA: 0x3985E30
	|-TaskFactory<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C5140 Offset: 0x34C5241 VA: 0x34C5140
	|-TaskFactory<Nullable<int>>..ctor
	|
	|-RVA: 0x34C5F40 Offset: 0x34C6041 VA: 0x34C5F40
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x34C6D60 Offset: 0x34C6E61 VA: 0x34C6D60
	|-TaskFactory<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x34C7B60 Offset: 0x34C7C61 VA: 0x34C7B60
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x39809C0 Offset: 0x3980AC1 VA: 0x39809C0
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x3981840 Offset: 0x3981941 VA: 0x3981840
	|-TaskFactory<bool>..ctor
	|
	|-RVA: 0x3982640 Offset: 0x3982741 VA: 0x3982640
	|-TaskFactory<int>..ctor
	|
	|-RVA: 0x3983440 Offset: 0x3983541 VA: 0x3983440
	|-TaskFactory<long>..ctor
	|
	|-RVA: 0x3984240 Offset: 0x3984341 VA: 0x3984240
	|-TaskFactory<object>..ctor
	|
	|-RVA: 0x3985040 Offset: 0x3985141 VA: 0x3985040
	|-TaskFactory<SceneInstance>..ctor
	|
	|-RVA: 0x3985E60 Offset: 0x3985F61 VA: 0x3985E60
	|-TaskFactory<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C51C0 Offset: 0x34C52C1 VA: 0x34C51C0
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0x34C5FC0 Offset: 0x34C60C1 VA: 0x34C5FC0
	|-TaskFactory<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x34C6DE0 Offset: 0x34C6EE1 VA: 0x34C6DE0
	|-TaskFactory<ValueTuple<int, int>>.StartNew
	|
	|-RVA: 0x34C7BE0 Offset: 0x34C7CE1 VA: 0x34C7BE0
	|-TaskFactory<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x3980A40 Offset: 0x3980B41 VA: 0x3980A40
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x39818C0 Offset: 0x39819C1 VA: 0x39818C0
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0x39826C0 Offset: 0x39827C1 VA: 0x39826C0
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0x39834C0 Offset: 0x39835C1 VA: 0x39834C0
	|-TaskFactory<long>.StartNew
	|
	|-RVA: 0x39842C0 Offset: 0x39843C1 VA: 0x39842C0
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0x39850C0 Offset: 0x39851C1 VA: 0x39850C0
	|-TaskFactory<SceneInstance>.StartNew
	|
	|-RVA: 0x3985EE0 Offset: 0x3985FE1 VA: 0x3985EE0
	|-TaskFactory<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C5300 Offset: 0x34C5401 VA: 0x34C5300
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x34C6100 Offset: 0x34C6201 VA: 0x34C6100
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x34C6F20 Offset: 0x34C7021 VA: 0x34C6F20
	|-TaskFactory<ValueTuple<int, int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x34C7D20 Offset: 0x34C7E21 VA: 0x34C7D20
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x3980B80 Offset: 0x3980C81 VA: 0x3980B80
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x3981A00 Offset: 0x3981B01 VA: 0x3981A00
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x3982800 Offset: 0x3982901 VA: 0x3982800
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x3983600 Offset: 0x3983701 VA: 0x3983600
	|-TaskFactory<long>.FromAsyncCoreLogic
	|
	|-RVA: 0x3984400 Offset: 0x3984501 VA: 0x3984400
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x3985200 Offset: 0x3985301 VA: 0x3985200
	|-TaskFactory<SceneInstance>.FromAsyncCoreLogic
	|
	|-RVA: 0x3986020 Offset: 0x3986121 VA: 0x3986020
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C5740 Offset: 0x34C5841 VA: 0x34C5740
	|-TaskFactory<Nullable<int>>.FromAsync
	|
	|-RVA: 0x34C6560 Offset: 0x34C6661 VA: 0x34C6560
	|-TaskFactory<ValueTuple<bool, object>>.FromAsync
	|
	|-RVA: 0x34C7360 Offset: 0x34C7461 VA: 0x34C7360
	|-TaskFactory<ValueTuple<int, int>>.FromAsync
	|
	|-RVA: 0x34C81D0 Offset: 0x34C82D1 VA: 0x34C81D0
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsync
	|
	|-RVA: 0x3981030 Offset: 0x3981131 VA: 0x3981030
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsync
	|
	|-RVA: 0x3981E40 Offset: 0x3981F41 VA: 0x3981E40
	|-TaskFactory<bool>.FromAsync
	|
	|-RVA: 0x3982C40 Offset: 0x3982D41 VA: 0x3982C40
	|-TaskFactory<int>.FromAsync
	|
	|-RVA: 0x3983A40 Offset: 0x3983B41 VA: 0x3983A40
	|-TaskFactory<long>.FromAsync
	|
	|-RVA: 0x3984840 Offset: 0x3984941 VA: 0x3984840
	|-TaskFactory<object>.FromAsync
	|-TaskFactory<WebResponse>.FromAsync
	|
	|-RVA: 0x3985660 Offset: 0x3985761 VA: 0x3985660
	|-TaskFactory<SceneInstance>.FromAsync
	|
	|-RVA: 0x3986460 Offset: 0x3986561 VA: 0x3986460
	|-TaskFactory<VoidTaskResult>.FromAsync
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C5770 Offset: 0x34C5871 VA: 0x34C5770
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x34C6590 Offset: 0x34C6691 VA: 0x34C6590
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncImpl
	|
	|-RVA: 0x34C7390 Offset: 0x34C7491 VA: 0x34C7390
	|-TaskFactory<ValueTuple<int, int>>.FromAsyncImpl
	|
	|-RVA: 0x34C8200 Offset: 0x34C8301 VA: 0x34C8200
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncImpl
	|
	|-RVA: 0x3981060 Offset: 0x3981161 VA: 0x3981060
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncImpl
	|
	|-RVA: 0x3981E70 Offset: 0x3981F71 VA: 0x3981E70
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x3982C70 Offset: 0x3982D71 VA: 0x3982C70
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x3983A70 Offset: 0x3983B71 VA: 0x3983A70
	|-TaskFactory<long>.FromAsyncImpl
	|
	|-RVA: 0x3984870 Offset: 0x3984971 VA: 0x3984870
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x3985690 Offset: 0x3985791 VA: 0x3985690
	|-TaskFactory<SceneInstance>.FromAsyncImpl
	|
	|-RVA: 0x3986490 Offset: 0x3986591 VA: 0x3986490
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25553E0 Offset: 0x25554E1 VA: 0x25553E0
	|-TaskFactory<object>.FromAsyncImpl<object>
	|
	|-RVA: 0x2555CA0 Offset: 0x2555DA1 VA: 0x2555CA0
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25551D0 Offset: 0x25552D1 VA: 0x25551D0
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|-TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|
	|-RVA: 0x2555AA0 Offset: 0x2555BA1 VA: 0x2555AA0
	|-TaskFactory<object>.FromAsyncTrim<object, object>
	|
	|-RVA: 0x2556360 Offset: 0x2556461 VA: 0x2556360
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	*/
}

// Namespace: System.Threading.Tasks
public class TaskFactory // TypeDefIndex: 862
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x10
	private TaskScheduler m_defaultScheduler; // 0x18
	private TaskCreationOptions m_defaultCreationOptions; // 0x20
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x24

	// Methods

	// RVA: 0x36688B0 Offset: 0x36689B1 VA: 0x36688B0
	public void .ctor() { }

	// RVA: 0x366A220 Offset: 0x366A321 VA: 0x366A220
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x366A3F0 Offset: 0x366A4F1 VA: 0x366A3F0
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	// RVA: 0x366A460 Offset: 0x366A561 VA: 0x366A460
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20258A0 Offset: 0x20259A1 VA: 0x20258A0
	|-TaskFactory.StartNew<bool>
	|
	|-RVA: 0x20259E0 Offset: 0x2025AE1 VA: 0x20259E0
	|-TaskFactory.StartNew<object>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2025860 Offset: 0x2025961 VA: 0x2025860
	|-TaskFactory.FromAsync<EndPoint>
	|-TaskFactory.FromAsync<object>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2025880 Offset: 0x2025981 VA: 0x2025880
	|-TaskFactory.FromAsync<object>
	*/

	// RVA: 0x366A520 Offset: 0x366A621 VA: 0x366A520
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	// RVA: 0x3667D70 Offset: 0x3667E71 VA: 0x3667D70
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	// RVA: 0x366A2F0 Offset: 0x366A3F1 VA: 0x366A2F0
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }
}

