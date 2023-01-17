// Namespace: 
private sealed class TaskFactory.FromAsyncTrimPromise<TResult, TInstance> : Task<TResult> // TypeDefIndex: 823
{
	// Fields
	internal static readonly AsyncCallback s_completeFromAsyncResult; // 0x0
	private TInstance m_thisRef; // 0x0
	private Func<TInstance, IAsyncResult, TResult> m_endMethod; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DF660 Offset: 0x33DF761 VA: 0x33DF660
	|-TaskFactory.FromAsyncTrimPromise<int, object>..ctor
	|
	|-RVA: 0x33DFC40 Offset: 0x33DFD41 VA: 0x33DFC40
	|-TaskFactory.FromAsyncTrimPromise<object, object>..ctor
	|
	|-RVA: 0x33E0220 Offset: 0x33E0321 VA: 0x33E0220
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DF740 Offset: 0x33DF841 VA: 0x33DF740
	|-TaskFactory.FromAsyncTrimPromise<int, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x33DFD20 Offset: 0x33DFE21 VA: 0x33DFD20
	|-TaskFactory.FromAsyncTrimPromise<object, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x33E0300 Offset: 0x33E0401 VA: 0x33E0300
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.CompleteFromAsyncResult
	*/

	// RVA: -1 Offset: -1
	internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DFA10 Offset: 0x33DFB11 VA: 0x33DFA10
	|-TaskFactory.FromAsyncTrimPromise<int, object>.Complete
	|
	|-RVA: 0x33DFFF0 Offset: 0x33E00F1 VA: 0x33DFFF0
	|-TaskFactory.FromAsyncTrimPromise<object, object>.Complete
	|
	|-RVA: 0x33E05D0 Offset: 0x33E06D1 VA: 0x33E05D0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.Complete
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DFB80 Offset: 0x33DFC81 VA: 0x33DFB80
	|-TaskFactory.FromAsyncTrimPromise<int, object>..cctor
	|
	|-RVA: 0x33E0160 Offset: 0x33E0261 VA: 0x33E0160
	|-TaskFactory.FromAsyncTrimPromise<object, object>..cctor
	|
	|-RVA: 0x33E0750 Offset: 0x33E0851 VA: 0x33E0750
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..cctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x473800 Offset: 0x473901 VA: 0x473800
private sealed class TaskFactory.<>c__DisplayClass35_0<TResult> // TypeDefIndex: 824
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C400 Offset: 0x2B3C501 VA: 0x2B3C400
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>..ctor
	|
	|-RVA: 0x2B3C440 Offset: 0x2B3C541 VA: 0x2B3C440
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2B3C480 Offset: 0x2B3C581 VA: 0x2B3C480
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2B3C4C0 Offset: 0x2B3C5C1 VA: 0x2B3C4C0
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2B3C500 Offset: 0x2B3C601 VA: 0x2B3C500
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2B3C540 Offset: 0x2B3C641 VA: 0x2B3C540
	|-TaskFactory.<>c__DisplayClass35_0<bool>..ctor
	|
	|-RVA: 0x2B3C580 Offset: 0x2B3C681 VA: 0x2B3C580
	|-TaskFactory.<>c__DisplayClass35_0<int>..ctor
	|
	|-RVA: 0x2B3C5C0 Offset: 0x2B3C6C1 VA: 0x2B3C5C0
	|-TaskFactory.<>c__DisplayClass35_0<long>..ctor
	|
	|-RVA: 0x2B3C600 Offset: 0x2B3C701 VA: 0x2B3C600
	|-TaskFactory.<>c__DisplayClass35_0<object>..ctor
	|
	|-RVA: 0x2B3C640 Offset: 0x2B3C741 VA: 0x2B3C640
	|-TaskFactory.<>c__DisplayClass35_0<SceneInstance>..ctor
	|
	|-RVA: 0x2B3C680 Offset: 0x2B3C781 VA: 0x2B3C680
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C410 Offset: 0x2B3C511 VA: 0x2B3C410
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C450 Offset: 0x2B3C551 VA: 0x2B3C450
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<bool, object>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C490 Offset: 0x2B3C591 VA: 0x2B3C490
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<int, int>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C4D0 Offset: 0x2B3C5D1 VA: 0x2B3C4D0
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, object, int>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C510 Offset: 0x2B3C611 VA: 0x2B3C510
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, bool, bool, object, object>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C550 Offset: 0x2B3C651 VA: 0x2B3C550
	|-TaskFactory.<>c__DisplayClass35_0<bool>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C590 Offset: 0x2B3C691 VA: 0x2B3C590
	|-TaskFactory.<>c__DisplayClass35_0<int>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C5D0 Offset: 0x2B3C6D1 VA: 0x2B3C5D0
	|-TaskFactory.<>c__DisplayClass35_0<long>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C610 Offset: 0x2B3C711 VA: 0x2B3C610
	|-TaskFactory.<>c__DisplayClass35_0<object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C650 Offset: 0x2B3C751 VA: 0x2B3C650
	|-TaskFactory.<>c__DisplayClass35_0<SceneInstance>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3C690 Offset: 0x2B3C791 VA: 0x2B3C690
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>.<FromAsyncImpl>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x473810 Offset: 0x473911 VA: 0x473810
private sealed class TaskFactory.<>c__DisplayClass35_1<TResult> // TypeDefIndex: 825
{
	// Fields
	public AtomicBoolean invoked; // 0x0
	public TaskFactory.<>c__DisplayClass35_0<TResult> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C6C0 Offset: 0x2B3C7C1 VA: 0x2B3C6C0
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<int>>..ctor
	|
	|-RVA: 0x2B3C740 Offset: 0x2B3C841 VA: 0x2B3C740
	|-TaskFactory.<>c__DisplayClass35_1<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2B3C7C0 Offset: 0x2B3C8C1 VA: 0x2B3C7C0
	|-TaskFactory.<>c__DisplayClass35_1<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2B3C840 Offset: 0x2B3C941 VA: 0x2B3C840
	|-TaskFactory.<>c__DisplayClass35_1<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2B3C8C0 Offset: 0x2B3C9C1 VA: 0x2B3C8C0
	|-TaskFactory.<>c__DisplayClass35_1<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2B3C940 Offset: 0x2B3CA41 VA: 0x2B3C940
	|-TaskFactory.<>c__DisplayClass35_1<bool>..ctor
	|
	|-RVA: 0x2B3C9C0 Offset: 0x2B3CAC1 VA: 0x2B3C9C0
	|-TaskFactory.<>c__DisplayClass35_1<int>..ctor
	|
	|-RVA: 0x2B3CA40 Offset: 0x2B3CB41 VA: 0x2B3CA40
	|-TaskFactory.<>c__DisplayClass35_1<long>..ctor
	|
	|-RVA: 0x2B3CAC0 Offset: 0x2B3CBC1 VA: 0x2B3CAC0
	|-TaskFactory.<>c__DisplayClass35_1<object>..ctor
	|
	|-RVA: 0x2B3CB40 Offset: 0x2B3CC41 VA: 0x2B3CB40
	|-TaskFactory.<>c__DisplayClass35_1<SceneInstance>..ctor
	|
	|-RVA: 0x2B3CBC0 Offset: 0x2B3CCC1 VA: 0x2B3CBC0
	|-TaskFactory.<>c__DisplayClass35_1<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C6D0 Offset: 0x2B3C7D1 VA: 0x2B3C6D0
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<int>>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3C750 Offset: 0x2B3C851 VA: 0x2B3C750
	|-TaskFactory.<>c__DisplayClass35_1<ValueTuple<bool, object>>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3C7D0 Offset: 0x2B3C8D1 VA: 0x2B3C7D0
	|-TaskFactory.<>c__DisplayClass35_1<ValueTuple<int, int>>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3C850 Offset: 0x2B3C951 VA: 0x2B3C850
	|-TaskFactory.<>c__DisplayClass35_1<ValueTuple<object, object, int>>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3C8D0 Offset: 0x2B3C9D1 VA: 0x2B3C8D0
	|-TaskFactory.<>c__DisplayClass35_1<ValueTuple<object, bool, bool, object, object>>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3C950 Offset: 0x2B3CA51 VA: 0x2B3C950
	|-TaskFactory.<>c__DisplayClass35_1<bool>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3C9D0 Offset: 0x2B3CAD1 VA: 0x2B3C9D0
	|-TaskFactory.<>c__DisplayClass35_1<int>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3CA50 Offset: 0x2B3CB51 VA: 0x2B3CA50
	|-TaskFactory.<>c__DisplayClass35_1<long>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3CAD0 Offset: 0x2B3CBD1 VA: 0x2B3CAD0
	|-TaskFactory.<>c__DisplayClass35_1<object>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3CB50 Offset: 0x2B3CC51 VA: 0x2B3CB50
	|-TaskFactory.<>c__DisplayClass35_1<SceneInstance>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3CBD0 Offset: 0x2B3CCD1 VA: 0x2B3CBD0
	|-TaskFactory.<>c__DisplayClass35_1<VoidTaskResult>.<FromAsyncImpl>b__1
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x473820 Offset: 0x473921 VA: 0x473820
private sealed class TaskFactory.<>c__DisplayClass38_0<TResult, TArg1> // TypeDefIndex: 826
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3CC70 Offset: 0x2B3CD71 VA: 0x2B3CC70
	|-TaskFactory.<>c__DisplayClass38_0<object, object>..ctor
	|
	|-RVA: 0x2B3CCB0 Offset: 0x2B3CDB1 VA: 0x2B3CCB0
	|-TaskFactory.<>c__DisplayClass38_0<VoidTaskResult, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3CC80 Offset: 0x2B3CD81 VA: 0x2B3CC80
	|-TaskFactory.<>c__DisplayClass38_0<object, object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x2B3CCC0 Offset: 0x2B3CDC1 VA: 0x2B3CCC0
	|-TaskFactory.<>c__DisplayClass38_0<VoidTaskResult, object>.<FromAsyncImpl>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x473830 Offset: 0x473931 VA: 0x473830
private sealed class TaskFactory.<>c__DisplayClass38_1<TResult, TArg1> // TypeDefIndex: 827
{
	// Fields
	public AtomicBoolean invoked; // 0x0
	public TaskFactory.<>c__DisplayClass38_0<TResult, TArg1> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3CCF0 Offset: 0x2B3CDF1 VA: 0x2B3CCF0
	|-TaskFactory.<>c__DisplayClass38_1<object, object>..ctor
	|
	|-RVA: 0x2B3CD70 Offset: 0x2B3CE71 VA: 0x2B3CD70
	|-TaskFactory.<>c__DisplayClass38_1<VoidTaskResult, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3CD00 Offset: 0x2B3CE01 VA: 0x2B3CD00
	|-TaskFactory.<>c__DisplayClass38_1<object, object>.<FromAsyncImpl>b__1
	|
	|-RVA: 0x2B3CD80 Offset: 0x2B3CE81 VA: 0x2B3CD80
	|-TaskFactory.<>c__DisplayClass38_1<VoidTaskResult, object>.<FromAsyncImpl>b__1
	*/
}

// Namespace: 
internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 861
{
	// Fields
	private IList<Task> _tasks; // 0x58
	private int m_firstTaskAlreadyCompleted; // 0x60

	// Methods

	// RVA: 0x1C06BA0 Offset: 0x1C06CA1 VA: 0x1C06BA0
	public void .ctor(IList<Task> tasks) { }

	// RVA: 0x1C06CF0 Offset: 0x1C06DF1 VA: 0x1C06CF0 Slot: 20
	public void Invoke(Task completingTask) { }
}

