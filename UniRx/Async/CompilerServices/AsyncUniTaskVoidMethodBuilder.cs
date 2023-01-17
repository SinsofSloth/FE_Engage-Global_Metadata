// Namespace: UniRx.Async.CompilerServices
public struct AsyncUniTaskVoidMethodBuilder // TypeDefIndex: 5229
{
	// Fields
	private Action moveNext; // 0x0

	// Properties
	public UniTaskVoid Task { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2EC10 Offset: 0x2ED11 VA: 0x2EC10
	// RVA: 0x2E7D1F0 Offset: 0x2E7D2F1 VA: 0x2E7D1F0
	public static AsyncUniTaskVoidMethodBuilder Create() { }

	// RVA: 0x2E7D200 Offset: 0x2E7D301 VA: 0x2E7D200
	public UniTaskVoid get_Task() { }

	[DebuggerHiddenAttribute] // RVA: 0x2EC20 Offset: 0x2ED21 VA: 0x2EC20
	// RVA: 0x2E7D210 Offset: 0x2E7D311 VA: 0x2E7D210
	public void SetException(Exception exception) { }

	[DebuggerHiddenAttribute] // RVA: 0x2EC30 Offset: 0x2ED31 VA: 0x2EC30
	// RVA: 0x2E7D640 Offset: 0x2E7D741 VA: 0x2E7D640
	public void SetResult() { }

	[DebuggerHiddenAttribute] // RVA: 0x2EC40 Offset: 0x2ED41 VA: 0x2EC40
	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x273A6D0 Offset: 0x273A7D1 VA: 0x273A6D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitOnCompleted<object, object>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EC50 Offset: 0x2ED51 VA: 0x2EC50
	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x273A830 Offset: 0x273A931 VA: 0x273A830
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>, UniTask.UnitWhenAnyPromise.<RunTask0>d__9<ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x273A9D0 Offset: 0x273AAD1 VA: 0x273A9D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<ValueTuple<bool, object>>, UniTask.UnitWhenAnyPromise.<RunTask0>d__9<ValueTuple<bool, object>>>
	|
	|-RVA: 0x273AB80 Offset: 0x273AC81 VA: 0x273AB80
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<bool>, CancellationTokenSourceExtensions.<CancelAfterCore>d__2>
	|
	|-RVA: 0x273AD20 Offset: 0x273AE21 VA: 0x273AD20
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskObservableExtensions.<Fire>d__3<object>>
	|
	|-RVA: 0x273AEC0 Offset: 0x273AFC1 VA: 0x273AEC0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<ForgetCore>d__23<object>>
	|
	|-RVA: 0x273B060 Offset: 0x273B161 VA: 0x273B060
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<ForgetCoreWithCatch>d__24<object>>
	|
	|-RVA: 0x273B200 Offset: 0x273B301 VA: 0x273B200
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask0>d__10<object, object>>
	|
	|-RVA: 0x273B3A0 Offset: 0x273B4A1 VA: 0x273B3A0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask0>d__11<object, object, object>>
	|
	|-RVA: 0x273B540 Offset: 0x273B641 VA: 0x273B540
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask0>d__12<object, object, object, object>>
	|
	|-RVA: 0x273B6E0 Offset: 0x273B7E1 VA: 0x273B6E0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask0>d__13<object, object, object, object, object>>
	|
	|-RVA: 0x273B880 Offset: 0x273B981 VA: 0x273B880
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask0>d__14<object, object, object, object, object, object>>
	|
	|-RVA: 0x273BA20 Offset: 0x273BB21 VA: 0x273BA20
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask0>d__15<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273BBC0 Offset: 0x273BCC1 VA: 0x273BBC0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask0>d__16<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273BD60 Offset: 0x273BE61 VA: 0x273BD60
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.UnitWhenAnyPromise.<RunTask0>d__9<object>>
	|
	|-RVA: 0x273BF00 Offset: 0x273C001 VA: 0x273BF00
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask1>d__11<object, object>>
	|
	|-RVA: 0x273C0A0 Offset: 0x273C1A1 VA: 0x273C0A0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask1>d__12<object, object, object>>
	|
	|-RVA: 0x273C240 Offset: 0x273C341 VA: 0x273C240
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask1>d__13<object, object, object, object>>
	|
	|-RVA: 0x273C3E0 Offset: 0x273C4E1 VA: 0x273C3E0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask1>d__14<object, object, object, object, object>>
	|
	|-RVA: 0x273C580 Offset: 0x273C681 VA: 0x273C580
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask1>d__15<object, object, object, object, object, object>>
	|
	|-RVA: 0x273C720 Offset: 0x273C821 VA: 0x273C720
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask1>d__16<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273C8C0 Offset: 0x273C9C1 VA: 0x273C8C0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask1>d__17<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273CA60 Offset: 0x273CB61 VA: 0x273CA60
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask1Async>d__10<object, object, object>>
	|
	|-RVA: 0x273CC00 Offset: 0x273CD01 VA: 0x273CC00
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask1Async>d__11<object, object, object, object>>
	|
	|-RVA: 0x273CDA0 Offset: 0x273CEA1 VA: 0x273CDA0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask1Async>d__12<object, object, object, object, object>>
	|
	|-RVA: 0x273CF40 Offset: 0x273D041 VA: 0x273CF40
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask1Async>d__13<object, object, object, object, object, object>>
	|
	|-RVA: 0x273D0E0 Offset: 0x273D1E1 VA: 0x273D0E0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask1Async>d__14<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273D280 Offset: 0x273D381 VA: 0x273D280
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask1Async>d__9<object, object>>
	|
	|-RVA: 0x273D420 Offset: 0x273D521 VA: 0x273D420
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask2>d__13<object, object, object>>
	|
	|-RVA: 0x273D5C0 Offset: 0x273D6C1 VA: 0x273D5C0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask2>d__14<object, object, object, object>>
	|
	|-RVA: 0x273D760 Offset: 0x273D861 VA: 0x273D760
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask2>d__15<object, object, object, object, object>>
	|
	|-RVA: 0x273D900 Offset: 0x273DA01 VA: 0x273D900
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask2>d__16<object, object, object, object, object, object>>
	|
	|-RVA: 0x273DAA0 Offset: 0x273DBA1 VA: 0x273DAA0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask2>d__17<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273DC40 Offset: 0x273DD41 VA: 0x273DC40
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask2>d__18<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273DDE0 Offset: 0x273DEE1 VA: 0x273DDE0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask2Async>d__11<object, object>>
	|
	|-RVA: 0x273DF80 Offset: 0x273E081 VA: 0x273DF80
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask2Async>d__12<object, object, object>>
	|
	|-RVA: 0x273E120 Offset: 0x273E221 VA: 0x273E120
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask2Async>d__13<object, object, object, object>>
	|
	|-RVA: 0x273E2C0 Offset: 0x273E3C1 VA: 0x273E2C0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask2Async>d__14<object, object, object, object, object>>
	|
	|-RVA: 0x273E460 Offset: 0x273E561 VA: 0x273E460
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask2Async>d__15<object, object, object, object, object, object>>
	|
	|-RVA: 0x273E600 Offset: 0x273E701 VA: 0x273E600
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask2Async>d__16<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273E7A0 Offset: 0x273E8A1 VA: 0x273E7A0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask3>d__15<object, object, object, object>>
	|
	|-RVA: 0x273E940 Offset: 0x273EA41 VA: 0x273E940
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask3>d__16<object, object, object, object, object>>
	|
	|-RVA: 0x273EAE0 Offset: 0x273EBE1 VA: 0x273EAE0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask3>d__17<object, object, object, object, object, object>>
	|
	|-RVA: 0x273EC80 Offset: 0x273ED81 VA: 0x273EC80
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask3>d__18<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273EE20 Offset: 0x273EF21 VA: 0x273EE20
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask3>d__19<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273EFC0 Offset: 0x273F0C1 VA: 0x273EFC0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask3Async>d__14<object, object, object>>
	|
	|-RVA: 0x273F160 Offset: 0x273F261 VA: 0x273F160
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask3Async>d__15<object, object, object, object>>
	|
	|-RVA: 0x273F300 Offset: 0x273F401 VA: 0x273F300
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask3Async>d__16<object, object, object, object, object>>
	|
	|-RVA: 0x273F4A0 Offset: 0x273F5A1 VA: 0x273F4A0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask3Async>d__17<object, object, object, object, object, object>>
	|
	|-RVA: 0x273F640 Offset: 0x273F741 VA: 0x273F640
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask3Async>d__18<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273F7E0 Offset: 0x273F8E1 VA: 0x273F7E0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask4>d__17<object, object, object, object, object>>
	|
	|-RVA: 0x273F980 Offset: 0x273FA81 VA: 0x273F980
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask4>d__18<object, object, object, object, object, object>>
	|
	|-RVA: 0x273FB20 Offset: 0x273FC21 VA: 0x273FB20
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask4>d__19<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273FCC0 Offset: 0x273FDC1 VA: 0x273FCC0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask4>d__20<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x273FE60 Offset: 0x273FF61 VA: 0x273FE60
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask4Async>d__17<object, object, object, object>>
	|
	|-RVA: 0x2740000 Offset: 0x2740101 VA: 0x2740000
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask4Async>d__18<object, object, object, object, object>>
	|
	|-RVA: 0x27401A0 Offset: 0x27402A1 VA: 0x27401A0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask4Async>d__19<object, object, object, object, object, object>>
	|
	|-RVA: 0x2740340 Offset: 0x2740441 VA: 0x2740340
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask4Async>d__20<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2290510 Offset: 0x2290611 VA: 0x2290510
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask5>d__19<object, object, object, object, object, object>>
	|
	|-RVA: 0x22906B0 Offset: 0x22907B1 VA: 0x22906B0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask5>d__20<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2290850 Offset: 0x2290951 VA: 0x2290850
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask5>d__21<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x22909F0 Offset: 0x2290AF1 VA: 0x22909F0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask5Async>d__20<object, object, object, object, object>>
	|
	|-RVA: 0x2290B90 Offset: 0x2290C91 VA: 0x2290B90
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask5Async>d__21<object, object, object, object, object, object>>
	|
	|-RVA: 0x2290D30 Offset: 0x2290E31 VA: 0x2290D30
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask5Async>d__22<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2290ED0 Offset: 0x2290FD1 VA: 0x2290ED0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask6>d__21<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2291070 Offset: 0x2291171 VA: 0x2291070
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask6>d__22<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2291210 Offset: 0x2291311 VA: 0x2291210
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask6Async>d__23<object, object, object, object, object, object>>
	|
	|-RVA: 0x22913B0 Offset: 0x22914B1 VA: 0x22913B0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask6Async>d__24<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2291550 Offset: 0x2291651 VA: 0x2291550
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask7>d__23<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x22916F0 Offset: 0x22917F1 VA: 0x22916F0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask7Async>d__26<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2291890 Offset: 0x2291991 VA: 0x2291890
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAllPromise.<RunTask>d__6<object>>
	|
	|-RVA: 0x2291A30 Offset: 0x2291B31 VA: 0x2291A30
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTask.WhenAnyPromise.<RunTask>d__8<object>>
	|
	|-RVA: 0x2291BD0 Offset: 0x2291CD1 VA: 0x2291BD0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__8<object>>
	|
	|-RVA: 0x2291D70 Offset: 0x2291E71 VA: 0x2291D70
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x2291ED0 Offset: 0x2291FD1 VA: 0x2291ED0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<SwitchToMainThreadAwaitable.Awaiter, UniTaskExtensions.<ForgetCoreWithCatch>d__24<object>>
	|
	|-RVA: 0x2291FD0 Offset: 0x22920D1 VA: 0x2291FD0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<SwitchToMainThreadAwaitable.Awaiter, UniTaskExtensions.<ForgetCoreWithCatch>d__20>
	|
	|-RVA: 0x22920D0 Offset: 0x22921D1 VA: 0x22920D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTask.UnitWhenAnyPromise.<RunTask1>d__10<ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x22921D0 Offset: 0x22922D1 VA: 0x22921D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTask.UnitWhenAnyPromise.<RunTask1>d__10<ValueTuple<bool, object>>>
	|
	|-RVA: 0x22922D0 Offset: 0x22923D1 VA: 0x22922D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTask.UnitWhenAnyPromise.<RunTask1>d__10<object>>
	|
	|-RVA: 0x22923D0 Offset: 0x22924D1 VA: 0x22923D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<ForgetCore>d__19>
	|
	|-RVA: 0x22924D0 Offset: 0x22925D1 VA: 0x22924D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<ForgetCoreWithCatch>d__20>
	|
	|-RVA: 0x22925D0 Offset: 0x22926D1 VA: 0x22925D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskObservableExtensions.<Fire>d__4>
	|
	|-RVA: 0x22926D0 Offset: 0x22927D1 VA: 0x22926D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTask.WhenAllPromise.<RunTask>d__6>
	|
	|-RVA: 0x22927D0 Offset: 0x22928D1 VA: 0x22927D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTask.WhenAnyPromise.<RunTask>d__7>
	|
	|-RVA: 0x22928D0 Offset: 0x22929D1 VA: 0x22928D0
	|-AsyncUniTaskVoidMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__6>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EC60 Offset: 0x2ED61 VA: 0x2EC60
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22929D0 Offset: 0x2292AD1 VA: 0x22929D0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTaskObservableExtensions.<Fire>d__3<object>>
	|
	|-RVA: 0x2292AF0 Offset: 0x2292BF1 VA: 0x2292AF0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTaskExtensions.<ForgetCore>d__23<object>>
	|
	|-RVA: 0x2292C00 Offset: 0x2292D01 VA: 0x2292C00
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTaskExtensions.<ForgetCoreWithCatch>d__24<object>>
	|
	|-RVA: 0x2292D40 Offset: 0x2292E41 VA: 0x2292D40
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask0>d__10<object, object>>
	|
	|-RVA: 0x2292E60 Offset: 0x2292F61 VA: 0x2292E60
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask0>d__11<object, object, object>>
	|
	|-RVA: 0x2292F80 Offset: 0x2293081 VA: 0x2292F80
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask0>d__12<object, object, object, object>>
	|
	|-RVA: 0x22930A0 Offset: 0x22931A1 VA: 0x22930A0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask0>d__13<object, object, object, object, object>>
	|
	|-RVA: 0x22931C0 Offset: 0x22932C1 VA: 0x22931C0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask0>d__14<object, object, object, object, object, object>>
	|
	|-RVA: 0x22932E0 Offset: 0x22933E1 VA: 0x22932E0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask0>d__15<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2293400 Offset: 0x2293501 VA: 0x2293400
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask0>d__16<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2293520 Offset: 0x2293621 VA: 0x2293520
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.UnitWhenAnyPromise.<RunTask0>d__9<ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x2293640 Offset: 0x2293741 VA: 0x2293640
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.UnitWhenAnyPromise.<RunTask0>d__9<ValueTuple<bool, object>>>
	|
	|-RVA: 0x2293770 Offset: 0x2293871 VA: 0x2293770
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.UnitWhenAnyPromise.<RunTask0>d__9<object>>
	|
	|-RVA: 0x2293890 Offset: 0x2293991 VA: 0x2293890
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.UnitWhenAnyPromise.<RunTask1>d__10<ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x22939A0 Offset: 0x2293AA1 VA: 0x22939A0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.UnitWhenAnyPromise.<RunTask1>d__10<ValueTuple<bool, object>>>
	|
	|-RVA: 0x2293AB0 Offset: 0x2293BB1 VA: 0x2293AB0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.UnitWhenAnyPromise.<RunTask1>d__10<object>>
	|
	|-RVA: 0x2293BC0 Offset: 0x2293CC1 VA: 0x2293BC0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask1>d__11<object, object>>
	|
	|-RVA: 0x2293CE0 Offset: 0x2293DE1 VA: 0x2293CE0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask1>d__12<object, object, object>>
	|
	|-RVA: 0x2293E00 Offset: 0x2293F01 VA: 0x2293E00
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask1>d__13<object, object, object, object>>
	|
	|-RVA: 0x2293F20 Offset: 0x2294021 VA: 0x2293F20
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask1>d__14<object, object, object, object, object>>
	|
	|-RVA: 0x2294040 Offset: 0x2294141 VA: 0x2294040
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask1>d__15<object, object, object, object, object, object>>
	|
	|-RVA: 0x2294160 Offset: 0x2294261 VA: 0x2294160
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask1>d__16<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2294280 Offset: 0x2294381 VA: 0x2294280
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask1>d__17<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x22943A0 Offset: 0x22944A1 VA: 0x22943A0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask1Async>d__10<object, object, object>>
	|
	|-RVA: 0x22944C0 Offset: 0x22945C1 VA: 0x22944C0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask1Async>d__11<object, object, object, object>>
	|
	|-RVA: 0x22945E0 Offset: 0x22946E1 VA: 0x22945E0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask1Async>d__12<object, object, object, object, object>>
	|
	|-RVA: 0x2294700 Offset: 0x2294801 VA: 0x2294700
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask1Async>d__13<object, object, object, object, object, object>>
	|
	|-RVA: 0x2294820 Offset: 0x2294921 VA: 0x2294820
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask1Async>d__14<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2294940 Offset: 0x2294A41 VA: 0x2294940
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask1Async>d__9<object, object>>
	|
	|-RVA: 0x2294A60 Offset: 0x2294B61 VA: 0x2294A60
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask2>d__13<object, object, object>>
	|
	|-RVA: 0x2294B80 Offset: 0x2294C81 VA: 0x2294B80
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask2>d__14<object, object, object, object>>
	|
	|-RVA: 0x2294CA0 Offset: 0x2294DA1 VA: 0x2294CA0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask2>d__15<object, object, object, object, object>>
	|
	|-RVA: 0x2294DC0 Offset: 0x2294EC1 VA: 0x2294DC0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask2>d__16<object, object, object, object, object, object>>
	|
	|-RVA: 0x2294EE0 Offset: 0x2294FE1 VA: 0x2294EE0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask2>d__17<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2295000 Offset: 0x2295101 VA: 0x2295000
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask2>d__18<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2295120 Offset: 0x2295221 VA: 0x2295120
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask2Async>d__11<object, object>>
	|
	|-RVA: 0x2295240 Offset: 0x2295341 VA: 0x2295240
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask2Async>d__12<object, object, object>>
	|
	|-RVA: 0x2295360 Offset: 0x2295461 VA: 0x2295360
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask2Async>d__13<object, object, object, object>>
	|
	|-RVA: 0x2295480 Offset: 0x2295581 VA: 0x2295480
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask2Async>d__14<object, object, object, object, object>>
	|
	|-RVA: 0x22955A0 Offset: 0x22956A1 VA: 0x22955A0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask2Async>d__15<object, object, object, object, object, object>>
	|
	|-RVA: 0x22956C0 Offset: 0x22957C1 VA: 0x22956C0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask2Async>d__16<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x22957E0 Offset: 0x22958E1 VA: 0x22957E0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask3>d__15<object, object, object, object>>
	|
	|-RVA: 0x2295900 Offset: 0x2295A01 VA: 0x2295900
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask3>d__16<object, object, object, object, object>>
	|
	|-RVA: 0x2295A20 Offset: 0x2295B21 VA: 0x2295A20
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask3>d__17<object, object, object, object, object, object>>
	|
	|-RVA: 0x2295B40 Offset: 0x2295C41 VA: 0x2295B40
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask3>d__18<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2295C60 Offset: 0x2295D61 VA: 0x2295C60
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask3>d__19<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2295D80 Offset: 0x2295E81 VA: 0x2295D80
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask3Async>d__14<object, object, object>>
	|
	|-RVA: 0x2295EA0 Offset: 0x2295FA1 VA: 0x2295EA0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask3Async>d__15<object, object, object, object>>
	|
	|-RVA: 0x2295FC0 Offset: 0x22960C1 VA: 0x2295FC0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask3Async>d__16<object, object, object, object, object>>
	|
	|-RVA: 0x22960E0 Offset: 0x22961E1 VA: 0x22960E0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask3Async>d__17<object, object, object, object, object, object>>
	|
	|-RVA: 0x2296200 Offset: 0x2296301 VA: 0x2296200
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask3Async>d__18<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2296320 Offset: 0x2296421 VA: 0x2296320
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask4>d__17<object, object, object, object, object>>
	|
	|-RVA: 0x2296440 Offset: 0x2296541 VA: 0x2296440
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask4>d__18<object, object, object, object, object, object>>
	|
	|-RVA: 0x2296560 Offset: 0x2296661 VA: 0x2296560
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask4>d__19<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2296680 Offset: 0x2296781 VA: 0x2296680
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask4>d__20<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x22967A0 Offset: 0x22968A1 VA: 0x22967A0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask4Async>d__17<object, object, object, object>>
	|
	|-RVA: 0x22968C0 Offset: 0x22969C1 VA: 0x22968C0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask4Async>d__18<object, object, object, object, object>>
	|
	|-RVA: 0x22969E0 Offset: 0x2296AE1 VA: 0x22969E0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask4Async>d__19<object, object, object, object, object, object>>
	|
	|-RVA: 0x2296B00 Offset: 0x2296C01 VA: 0x2296B00
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask4Async>d__20<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2296C20 Offset: 0x2296D21 VA: 0x2296C20
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask5>d__19<object, object, object, object, object, object>>
	|
	|-RVA: 0x2296D40 Offset: 0x2296E41 VA: 0x2296D40
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask5>d__20<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2296E60 Offset: 0x2296F61 VA: 0x2296E60
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask5>d__21<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2296F80 Offset: 0x2297081 VA: 0x2296F80
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask5Async>d__20<object, object, object, object, object>>
	|
	|-RVA: 0x22970A0 Offset: 0x22971A1 VA: 0x22970A0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask5Async>d__21<object, object, object, object, object, object>>
	|
	|-RVA: 0x22971C0 Offset: 0x22972C1 VA: 0x22971C0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask5Async>d__22<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x22972E0 Offset: 0x22973E1 VA: 0x22972E0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask6>d__21<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2297400 Offset: 0x2297501 VA: 0x2297400
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask6>d__22<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2297520 Offset: 0x2297621 VA: 0x2297520
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask6Async>d__23<object, object, object, object, object, object>>
	|
	|-RVA: 0x2297640 Offset: 0x2297741 VA: 0x2297640
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask6Async>d__24<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2297760 Offset: 0x2297861 VA: 0x2297760
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask7>d__23<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2297880 Offset: 0x2297981 VA: 0x2297880
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask7Async>d__26<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x22979A0 Offset: 0x2297AA1 VA: 0x22979A0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask>d__6<object>>
	|
	|-RVA: 0x2297AC0 Offset: 0x2297BC1 VA: 0x2297AC0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask>d__8<object>>
	|
	|-RVA: 0x2297BE0 Offset: 0x2297CE1 VA: 0x2297BE0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__8<object>>
	|
	|-RVA: 0x2297D00 Offset: 0x2297E01 VA: 0x2297D00
	|-AsyncUniTaskVoidMethodBuilder.Start<object>
	|
	|-RVA: 0x2297DB0 Offset: 0x2297EB1 VA: 0x2297DB0
	|-AsyncUniTaskVoidMethodBuilder.Start<CancellationTokenSourceExtensions.<CancelAfterCore>d__2>
	|
	|-RVA: 0x2297DC0 Offset: 0x2297EC1 VA: 0x2297DC0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTaskExtensions.<ForgetCore>d__19>
	|
	|-RVA: 0x2297DD0 Offset: 0x2297ED1 VA: 0x2297DD0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTaskExtensions.<ForgetCoreWithCatch>d__20>
	|
	|-RVA: 0x2297DE0 Offset: 0x2297EE1 VA: 0x2297DE0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTaskObservableExtensions.<Fire>d__4>
	|
	|-RVA: 0x2297DF0 Offset: 0x2297EF1 VA: 0x2297DF0
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAllPromise.<RunTask>d__6>
	|
	|-RVA: 0x2297E00 Offset: 0x2297F01 VA: 0x2297E00
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTask.WhenAnyPromise.<RunTask>d__7>
	|
	|-RVA: 0x2297E10 Offset: 0x2297F11 VA: 0x2297E10
	|-AsyncUniTaskVoidMethodBuilder.Start<UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__6>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EC70 Offset: 0x2ED71 VA: 0x2EC70
	// RVA: 0x2E7D650 Offset: 0x2E7D751 VA: 0x2E7D650
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

