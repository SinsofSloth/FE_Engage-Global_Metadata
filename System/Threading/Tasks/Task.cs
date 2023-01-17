// Namespace: System.Threading.Tasks
[DebuggerDisplayAttribute] // RVA: 0x473760 Offset: 0x473861 VA: 0x473760
[DebuggerTypeProxyAttribute] // RVA: 0x473760 Offset: 0x473861 VA: 0x473760
public class Task<TResult> : Task // TypeDefIndex: 821
{
	// Fields
	internal TResult m_result; // 0x0
	private static readonly TaskFactory<TResult> s_Factory; // 0x0
	internal static readonly Func<Task<Task>, Task<TResult>> TaskWhenAnyCast; // 0x0

	// Properties
	[DebuggerBrowsableAttribute] // RVA: 0x47E110 Offset: 0x47E211 VA: 0x47E110
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987DB0 Offset: 0x3987EB1 VA: 0x3987DB0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x39895F0 Offset: 0x39896F1 VA: 0x39895F0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398AEB0 Offset: 0x398AFB1 VA: 0x398AEB0
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398C6F0 Offset: 0x398C7F1 VA: 0x398C6F0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E050 Offset: 0x398E151 VA: 0x398E050
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x398F9D0 Offset: 0x398FAD1 VA: 0x398F9D0
	|-Task<bool>..ctor
	|
	|-RVA: 0x3991220 Offset: 0x3991321 VA: 0x3991220
	|-Task<int>..ctor
	|
	|-RVA: 0x3992A60 Offset: 0x3992B61 VA: 0x3992A60
	|-Task<long>..ctor
	|
	|-RVA: 0x39942A0 Offset: 0x39943A1 VA: 0x39942A0
	|-Task<object>..ctor
	|-Task<Task>..ctor
	|
	|-RVA: 0x3995B40 Offset: 0x3995C41 VA: 0x3995B40
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997400 Offset: 0x3997501 VA: 0x3997400
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987E20 Offset: 0x3987F21 VA: 0x3987E20
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x3989660 Offset: 0x3989761 VA: 0x3989660
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398AF20 Offset: 0x398B021 VA: 0x398AF20
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398C760 Offset: 0x398C861 VA: 0x398C760
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E0C0 Offset: 0x398E1C1 VA: 0x398E0C0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x398FA40 Offset: 0x398FB41 VA: 0x398FA40
	|-Task<bool>..ctor
	|
	|-RVA: 0x3991290 Offset: 0x3991391 VA: 0x3991290
	|-Task<int>..ctor
	|
	|-RVA: 0x3992AD0 Offset: 0x3992BD1 VA: 0x3992AD0
	|-Task<long>..ctor
	|
	|-RVA: 0x3994310 Offset: 0x3994411 VA: 0x3994310
	|-Task<object>..ctor
	|
	|-RVA: 0x3995BB0 Offset: 0x3995CB1 VA: 0x3995BB0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997470 Offset: 0x3997571 VA: 0x3997470
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987EB0 Offset: 0x3987FB1 VA: 0x3987EB0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x39896F0 Offset: 0x39897F1 VA: 0x39896F0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398AFB0 Offset: 0x398B0B1 VA: 0x398AFB0
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398C7F0 Offset: 0x398C8F1 VA: 0x398C7F0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E150 Offset: 0x398E251 VA: 0x398E150
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x398FAD0 Offset: 0x398FBD1 VA: 0x398FAD0
	|-Task<bool>..ctor
	|
	|-RVA: 0x3991320 Offset: 0x3991421 VA: 0x3991320
	|-Task<int>..ctor
	|
	|-RVA: 0x3992B60 Offset: 0x3992C61 VA: 0x3992B60
	|-Task<long>..ctor
	|
	|-RVA: 0x39943A0 Offset: 0x39944A1 VA: 0x39943A0
	|-Task<object>..ctor
	|
	|-RVA: 0x3995C40 Offset: 0x3995D41 VA: 0x3995C40
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997500 Offset: 0x3997601 VA: 0x3997500
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987F40 Offset: 0x3988041 VA: 0x3987F40
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x3989790 Offset: 0x3989891 VA: 0x3989790
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398B040 Offset: 0x398B141 VA: 0x398B040
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398C890 Offset: 0x398C991 VA: 0x398C890
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E1F0 Offset: 0x398E2F1 VA: 0x398E1F0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x398FB60 Offset: 0x398FC61 VA: 0x398FB60
	|-Task<bool>..ctor
	|
	|-RVA: 0x39913B0 Offset: 0x39914B1 VA: 0x39913B0
	|-Task<int>..ctor
	|
	|-RVA: 0x3992BF0 Offset: 0x3992CF1 VA: 0x3992BF0
	|-Task<long>..ctor
	|
	|-RVA: 0x3994430 Offset: 0x3994531 VA: 0x3994430
	|-Task<object>..ctor
	|
	|-RVA: 0x3995CE0 Offset: 0x3995DE1 VA: 0x3995CE0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997590 Offset: 0x3997691 VA: 0x3997590
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987FF0 Offset: 0x39880F1 VA: 0x3987FF0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x3989860 Offset: 0x3989961 VA: 0x3989860
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398B0F0 Offset: 0x398B1F1 VA: 0x398B0F0
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398C960 Offset: 0x398CA61 VA: 0x398C960
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E2D0 Offset: 0x398E3D1 VA: 0x398E2D0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x398FC10 Offset: 0x398FD11 VA: 0x398FC10
	|-Task<bool>..ctor
	|
	|-RVA: 0x3991460 Offset: 0x3991561 VA: 0x3991460
	|-Task<int>..ctor
	|
	|-RVA: 0x3992CA0 Offset: 0x3992DA1 VA: 0x3992CA0
	|-Task<long>..ctor
	|
	|-RVA: 0x3994500 Offset: 0x3994601 VA: 0x3994500
	|-Task<object>..ctor
	|
	|-RVA: 0x3995DB0 Offset: 0x3995EB1 VA: 0x3995DB0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997640 Offset: 0x3997741 VA: 0x3997640
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39880E0 Offset: 0x39881E1 VA: 0x39880E0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x3989950 Offset: 0x3989A51 VA: 0x3989950
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398B1E0 Offset: 0x398B2E1 VA: 0x398B1E0
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398CA50 Offset: 0x398CB51 VA: 0x398CA50
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E3C0 Offset: 0x398E4C1 VA: 0x398E3C0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x398FD00 Offset: 0x398FE01 VA: 0x398FD00
	|-Task<bool>..ctor
	|
	|-RVA: 0x3991550 Offset: 0x3991651 VA: 0x3991550
	|-Task<int>..ctor
	|
	|-RVA: 0x3992D90 Offset: 0x3992E91 VA: 0x3992D90
	|-Task<long>..ctor
	|
	|-RVA: 0x39945F0 Offset: 0x39946F1 VA: 0x39945F0
	|-Task<object>..ctor
	|
	|-RVA: 0x3995EA0 Offset: 0x3995FA1 VA: 0x3995EA0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997730 Offset: 0x3997831 VA: 0x3997730
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39881C0 Offset: 0x39882C1 VA: 0x39881C0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x3989A30 Offset: 0x3989B31 VA: 0x3989A30
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398B2C0 Offset: 0x398B3C1 VA: 0x398B2C0
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398CB30 Offset: 0x398CC31 VA: 0x398CB30
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E4A0 Offset: 0x398E5A1 VA: 0x398E4A0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x398FDE0 Offset: 0x398FEE1 VA: 0x398FDE0
	|-Task<bool>..ctor
	|
	|-RVA: 0x3991630 Offset: 0x3991731 VA: 0x3991630
	|-Task<int>..ctor
	|
	|-RVA: 0x3992E70 Offset: 0x3992F71 VA: 0x3992E70
	|-Task<long>..ctor
	|
	|-RVA: 0x39946D0 Offset: 0x39947D1 VA: 0x39946D0
	|-Task<object>..ctor
	|
	|-RVA: 0x3995F80 Offset: 0x3996081 VA: 0x3995F80
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997810 Offset: 0x3997911 VA: 0x3997810
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<object, TResult> valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39882F0 Offset: 0x39883F1 VA: 0x39882F0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x3989B60 Offset: 0x3989C61 VA: 0x3989B60
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398B3F0 Offset: 0x398B4F1 VA: 0x398B3F0
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398CC60 Offset: 0x398CD61 VA: 0x398CC60
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E5D0 Offset: 0x398E6D1 VA: 0x398E5D0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x398FF10 Offset: 0x3990011 VA: 0x398FF10
	|-Task<bool>..ctor
	|
	|-RVA: 0x3991760 Offset: 0x3991861 VA: 0x3991760
	|-Task<int>..ctor
	|
	|-RVA: 0x3992FA0 Offset: 0x39930A1 VA: 0x3992FA0
	|-Task<long>..ctor
	|
	|-RVA: 0x3994800 Offset: 0x3994901 VA: 0x3994800
	|-Task<object>..ctor
	|
	|-RVA: 0x39960B0 Offset: 0x39961B1 VA: 0x39960B0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997940 Offset: 0x3997A41 VA: 0x3997940
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39883E0 Offset: 0x39884E1 VA: 0x39883E0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x3989C50 Offset: 0x3989D51 VA: 0x3989C50
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x398B4E0 Offset: 0x398B5E1 VA: 0x398B4E0
	|-Task<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x398CD50 Offset: 0x398CE51 VA: 0x398CD50
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x398E6C0 Offset: 0x398E7C1 VA: 0x398E6C0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x3990000 Offset: 0x3990101 VA: 0x3990000
	|-Task<bool>..ctor
	|
	|-RVA: 0x3991850 Offset: 0x3991951 VA: 0x3991850
	|-Task<int>..ctor
	|
	|-RVA: 0x3993090 Offset: 0x3993191 VA: 0x3993090
	|-Task<long>..ctor
	|
	|-RVA: 0x39948F0 Offset: 0x39949F1 VA: 0x39948F0
	|-Task<object>..ctor
	|
	|-RVA: 0x39961A0 Offset: 0x39962A1 VA: 0x39961A0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x3997A30 Offset: 0x3997B31 VA: 0x3997A30
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988510 Offset: 0x3988611 VA: 0x3988510
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x3989D80 Offset: 0x3989E81 VA: 0x3989D80
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x398B610 Offset: 0x398B711 VA: 0x398B610
	|-Task<ValueTuple<int, int>>.StartNew
	|
	|-RVA: 0x398CE80 Offset: 0x398CF81 VA: 0x398CE80
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x398E7F0 Offset: 0x398E8F1 VA: 0x398E7F0
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x3990130 Offset: 0x3990231 VA: 0x3990130
	|-Task<bool>.StartNew
	|
	|-RVA: 0x3991980 Offset: 0x3991A81 VA: 0x3991980
	|-Task<int>.StartNew
	|
	|-RVA: 0x39931C0 Offset: 0x39932C1 VA: 0x39931C0
	|-Task<long>.StartNew
	|
	|-RVA: 0x3994A20 Offset: 0x3994B21 VA: 0x3994A20
	|-Task<object>.StartNew
	|
	|-RVA: 0x39962D0 Offset: 0x39963D1 VA: 0x39962D0
	|-Task<SceneInstance>.StartNew
	|
	|-RVA: 0x3997B60 Offset: 0x3997C61 VA: 0x3997B60
	|-Task<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988700 Offset: 0x3988801 VA: 0x3988700
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x3989F70 Offset: 0x398A071 VA: 0x3989F70
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x398B800 Offset: 0x398B901 VA: 0x398B800
	|-Task<ValueTuple<int, int>>.StartNew
	|
	|-RVA: 0x398D070 Offset: 0x398D171 VA: 0x398D070
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x398E9E0 Offset: 0x398EAE1 VA: 0x398E9E0
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x3990320 Offset: 0x3990421 VA: 0x3990320
	|-Task<bool>.StartNew
	|
	|-RVA: 0x3991B70 Offset: 0x3991C71 VA: 0x3991B70
	|-Task<int>.StartNew
	|
	|-RVA: 0x39933B0 Offset: 0x39934B1 VA: 0x39933B0
	|-Task<long>.StartNew
	|
	|-RVA: 0x3994C10 Offset: 0x3994D11 VA: 0x3994C10
	|-Task<object>.StartNew
	|
	|-RVA: 0x39964C0 Offset: 0x39965C1 VA: 0x39964C0
	|-Task<SceneInstance>.StartNew
	|
	|-RVA: 0x3997D50 Offset: 0x3997E51 VA: 0x3997D50
	|-Task<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988900 Offset: 0x3988A01 VA: 0x3988900
	|-Task<Nullable<int>>.TrySetResult
	|
	|-RVA: 0x398A170 Offset: 0x398A271 VA: 0x398A170
	|-Task<ValueTuple<bool, object>>.TrySetResult
	|
	|-RVA: 0x398BA00 Offset: 0x398BB01 VA: 0x398BA00
	|-Task<ValueTuple<int, int>>.TrySetResult
	|
	|-RVA: 0x398D270 Offset: 0x398D371 VA: 0x398D270
	|-Task<ValueTuple<object, object, int>>.TrySetResult
	|
	|-RVA: 0x398EBE0 Offset: 0x398ECE1 VA: 0x398EBE0
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetResult
	|
	|-RVA: 0x3990520 Offset: 0x3990621 VA: 0x3990520
	|-Task<bool>.TrySetResult
	|
	|-RVA: 0x3991D70 Offset: 0x3991E71 VA: 0x3991D70
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x39935B0 Offset: 0x39936B1 VA: 0x39935B0
	|-Task<long>.TrySetResult
	|
	|-RVA: 0x3994E10 Offset: 0x3994F11 VA: 0x3994E10
	|-Task<object>.TrySetResult
	|-Task<Task>.TrySetResult
	|
	|-RVA: 0x39966C0 Offset: 0x39967C1 VA: 0x39966C0
	|-Task<SceneInstance>.TrySetResult
	|
	|-RVA: 0x3997F50 Offset: 0x3998051 VA: 0x3997F50
	|-Task<VoidTaskResult>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39889B0 Offset: 0x3988AB1 VA: 0x39889B0
	|-Task<Nullable<int>>.DangerousSetResult
	|
	|-RVA: 0x398A230 Offset: 0x398A331 VA: 0x398A230
	|-Task<ValueTuple<bool, object>>.DangerousSetResult
	|
	|-RVA: 0x398BAB0 Offset: 0x398BBB1 VA: 0x398BAB0
	|-Task<ValueTuple<int, int>>.DangerousSetResult
	|
	|-RVA: 0x398D340 Offset: 0x398D441 VA: 0x398D340
	|-Task<ValueTuple<object, object, int>>.DangerousSetResult
	|
	|-RVA: 0x398ECB0 Offset: 0x398EDB1 VA: 0x398ECB0
	|-Task<ValueTuple<object, bool, bool, object, object>>.DangerousSetResult
	|
	|-RVA: 0x39905D0 Offset: 0x39906D1 VA: 0x39905D0
	|-Task<bool>.DangerousSetResult
	|
	|-RVA: 0x3991E20 Offset: 0x3991F21 VA: 0x3991E20
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x3993660 Offset: 0x3993761 VA: 0x3993660
	|-Task<long>.DangerousSetResult
	|
	|-RVA: 0x3994ED0 Offset: 0x3994FD1 VA: 0x3994ED0
	|-Task<object>.DangerousSetResult
	|
	|-RVA: 0x3996780 Offset: 0x3996881 VA: 0x3996780
	|-Task<SceneInstance>.DangerousSetResult
	|
	|-RVA: 0x3998000 Offset: 0x3998101 VA: 0x3998000
	|-Task<VoidTaskResult>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988A10 Offset: 0x3988B11 VA: 0x3988A10
	|-Task<Nullable<int>>.get_Result
	|
	|-RVA: 0x398A2A0 Offset: 0x398A3A1 VA: 0x398A2A0
	|-Task<ValueTuple<bool, object>>.get_Result
	|-Task<ValueTuple<bool, WebOperation>>.get_Result
	|
	|-RVA: 0x398BB10 Offset: 0x398BC11 VA: 0x398BB10
	|-Task<ValueTuple<int, int>>.get_Result
	|
	|-RVA: 0x398D3E0 Offset: 0x398D4E1 VA: 0x398D3E0
	|-Task<ValueTuple<object, object, int>>.get_Result
	|
	|-RVA: 0x398ED60 Offset: 0x398EE61 VA: 0x398ED60
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Result
	|
	|-RVA: 0x3990640 Offset: 0x3990741 VA: 0x3990640
	|-Task<bool>.get_Result
	|
	|-RVA: 0x3991E80 Offset: 0x3991F81 VA: 0x3991E80
	|-Task<int>.get_Result
	|
	|-RVA: 0x39936C0 Offset: 0x39937C1 VA: 0x39936C0
	|-Task<long>.get_Result
	|
	|-RVA: 0x3994F40 Offset: 0x3995041 VA: 0x3994F40
	|-Task<object>.get_Result
	|-Task<Task>.get_Result
	|-Task<WebResponse>.get_Result
	|-Task<WebCompletionSource.Result>.get_Result
	|
	|-RVA: 0x39967F0 Offset: 0x39968F1 VA: 0x39967F0
	|-Task<SceneInstance>.get_Result
	|
	|-RVA: 0x3998060 Offset: 0x3998161 VA: 0x3998060
	|-Task<VoidTaskResult>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988A80 Offset: 0x3988B81 VA: 0x3988A80
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|
	|-RVA: 0x398A320 Offset: 0x398A421 VA: 0x398A320
	|-Task<ValueTuple<bool, object>>.get_ResultOnSuccess
	|
	|-RVA: 0x398BB80 Offset: 0x398BC81 VA: 0x398BB80
	|-Task<ValueTuple<int, int>>.get_ResultOnSuccess
	|
	|-RVA: 0x398D470 Offset: 0x398D571 VA: 0x398D470
	|-Task<ValueTuple<object, object, int>>.get_ResultOnSuccess
	|
	|-RVA: 0x398EDF0 Offset: 0x398EEF1 VA: 0x398EDF0
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_ResultOnSuccess
	|
	|-RVA: 0x39906B0 Offset: 0x39907B1 VA: 0x39906B0
	|-Task<bool>.get_ResultOnSuccess
	|
	|-RVA: 0x3991EF0 Offset: 0x3991FF1 VA: 0x3991EF0
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x3993730 Offset: 0x3993831 VA: 0x3993730
	|-Task<long>.get_ResultOnSuccess
	|
	|-RVA: 0x3994FB0 Offset: 0x39950B1 VA: 0x3994FB0
	|-Task<object>.get_ResultOnSuccess
	|
	|-RVA: 0x3996870 Offset: 0x3996971 VA: 0x3996870
	|-Task<SceneInstance>.get_ResultOnSuccess
	|
	|-RVA: 0x39980D0 Offset: 0x39981D1 VA: 0x39980D0
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988A90 Offset: 0x3988B91 VA: 0x3988A90
	|-Task<Nullable<int>>.GetResultCore
	|
	|-RVA: 0x398A330 Offset: 0x398A431 VA: 0x398A330
	|-Task<ValueTuple<bool, object>>.GetResultCore
	|
	|-RVA: 0x398BB90 Offset: 0x398BC91 VA: 0x398BB90
	|-Task<ValueTuple<int, int>>.GetResultCore
	|
	|-RVA: 0x398D490 Offset: 0x398D591 VA: 0x398D490
	|-Task<ValueTuple<object, object, int>>.GetResultCore
	|
	|-RVA: 0x398EE10 Offset: 0x398EF11 VA: 0x398EE10
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetResultCore
	|
	|-RVA: 0x39906C0 Offset: 0x39907C1 VA: 0x39906C0
	|-Task<bool>.GetResultCore
	|
	|-RVA: 0x3991F00 Offset: 0x3992001 VA: 0x3991F00
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x3993740 Offset: 0x3993841 VA: 0x3993740
	|-Task<long>.GetResultCore
	|
	|-RVA: 0x3994FC0 Offset: 0x39950C1 VA: 0x3994FC0
	|-Task<object>.GetResultCore
	|
	|-RVA: 0x3996880 Offset: 0x3996981 VA: 0x3996880
	|-Task<SceneInstance>.GetResultCore
	|
	|-RVA: 0x39980E0 Offset: 0x39981E1 VA: 0x39980E0
	|-Task<VoidTaskResult>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetException(object exceptionObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988B30 Offset: 0x3988C31 VA: 0x3988B30
	|-Task<Nullable<int>>.TrySetException
	|
	|-RVA: 0x398A3D0 Offset: 0x398A4D1 VA: 0x398A3D0
	|-Task<ValueTuple<bool, object>>.TrySetException
	|
	|-RVA: 0x398BC30 Offset: 0x398BD31 VA: 0x398BC30
	|-Task<ValueTuple<int, int>>.TrySetException
	|
	|-RVA: 0x398D540 Offset: 0x398D641 VA: 0x398D540
	|-Task<ValueTuple<object, object, int>>.TrySetException
	|
	|-RVA: 0x398EEC0 Offset: 0x398EFC1 VA: 0x398EEC0
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetException
	|
	|-RVA: 0x3990760 Offset: 0x3990861 VA: 0x3990760
	|-Task<bool>.TrySetException
	|
	|-RVA: 0x3991FA0 Offset: 0x39920A1 VA: 0x3991FA0
	|-Task<int>.TrySetException
	|
	|-RVA: 0x39937E0 Offset: 0x39938E1 VA: 0x39937E0
	|-Task<long>.TrySetException
	|
	|-RVA: 0x3995060 Offset: 0x3995161 VA: 0x3995060
	|-Task<object>.TrySetException
	|
	|-RVA: 0x3996920 Offset: 0x3996A21 VA: 0x3996920
	|-Task<SceneInstance>.TrySetException
	|
	|-RVA: 0x3998180 Offset: 0x3998281 VA: 0x3998180
	|-Task<VoidTaskResult>.TrySetException
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988BB0 Offset: 0x3988CB1 VA: 0x3988BB0
	|-Task<Nullable<int>>.TrySetCanceled
	|
	|-RVA: 0x398A450 Offset: 0x398A551 VA: 0x398A450
	|-Task<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x398BCB0 Offset: 0x398BDB1 VA: 0x398BCB0
	|-Task<ValueTuple<int, int>>.TrySetCanceled
	|
	|-RVA: 0x398D5C0 Offset: 0x398D6C1 VA: 0x398D5C0
	|-Task<ValueTuple<object, object, int>>.TrySetCanceled
	|
	|-RVA: 0x398EF40 Offset: 0x398F041 VA: 0x398EF40
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetCanceled
	|
	|-RVA: 0x39907E0 Offset: 0x39908E1 VA: 0x39907E0
	|-Task<bool>.TrySetCanceled
	|
	|-RVA: 0x3992020 Offset: 0x3992121 VA: 0x3992020
	|-Task<int>.TrySetCanceled
	|
	|-RVA: 0x3993860 Offset: 0x3993961 VA: 0x3993860
	|-Task<long>.TrySetCanceled
	|
	|-RVA: 0x39950E0 Offset: 0x39951E1 VA: 0x39950E0
	|-Task<object>.TrySetCanceled
	|
	|-RVA: 0x39969A0 Offset: 0x3996AA1 VA: 0x39969A0
	|-Task<SceneInstance>.TrySetCanceled
	|
	|-RVA: 0x3998200 Offset: 0x3998301 VA: 0x3998200
	|-Task<VoidTaskResult>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988BD0 Offset: 0x3988CD1 VA: 0x3988BD0
	|-Task<Nullable<int>>.TrySetCanceled
	|
	|-RVA: 0x398A470 Offset: 0x398A571 VA: 0x398A470
	|-Task<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x398BCD0 Offset: 0x398BDD1 VA: 0x398BCD0
	|-Task<ValueTuple<int, int>>.TrySetCanceled
	|
	|-RVA: 0x398D5E0 Offset: 0x398D6E1 VA: 0x398D5E0
	|-Task<ValueTuple<object, object, int>>.TrySetCanceled
	|
	|-RVA: 0x398EF60 Offset: 0x398F061 VA: 0x398EF60
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetCanceled
	|
	|-RVA: 0x3990800 Offset: 0x3990901 VA: 0x3990800
	|-Task<bool>.TrySetCanceled
	|
	|-RVA: 0x3992040 Offset: 0x3992141 VA: 0x3992040
	|-Task<int>.TrySetCanceled
	|
	|-RVA: 0x3993880 Offset: 0x3993981 VA: 0x3993880
	|-Task<long>.TrySetCanceled
	|
	|-RVA: 0x3995100 Offset: 0x3995201 VA: 0x3995100
	|-Task<object>.TrySetCanceled
	|
	|-RVA: 0x39969C0 Offset: 0x3996AC1 VA: 0x39969C0
	|-Task<SceneInstance>.TrySetCanceled
	|
	|-RVA: 0x3998220 Offset: 0x3998321 VA: 0x3998220
	|-Task<VoidTaskResult>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988C50 Offset: 0x3988D51 VA: 0x3988C50
	|-Task<Nullable<int>>.get_Factory
	|
	|-RVA: 0x398A4F0 Offset: 0x398A5F1 VA: 0x398A4F0
	|-Task<ValueTuple<bool, object>>.get_Factory
	|
	|-RVA: 0x398BD50 Offset: 0x398BE51 VA: 0x398BD50
	|-Task<ValueTuple<int, int>>.get_Factory
	|
	|-RVA: 0x398D660 Offset: 0x398D761 VA: 0x398D660
	|-Task<ValueTuple<object, object, int>>.get_Factory
	|
	|-RVA: 0x398EFE0 Offset: 0x398F0E1 VA: 0x398EFE0
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Factory
	|
	|-RVA: 0x3990880 Offset: 0x3990981 VA: 0x3990880
	|-Task<bool>.get_Factory
	|
	|-RVA: 0x39920C0 Offset: 0x39921C1 VA: 0x39920C0
	|-Task<int>.get_Factory
	|
	|-RVA: 0x3993900 Offset: 0x3993A01 VA: 0x3993900
	|-Task<long>.get_Factory
	|
	|-RVA: 0x3995180 Offset: 0x3995281 VA: 0x3995180
	|-Task<object>.get_Factory
	|-Task<WebResponse>.get_Factory
	|
	|-RVA: 0x3996A40 Offset: 0x3996B41 VA: 0x3996A40
	|-Task<SceneInstance>.get_Factory
	|
	|-RVA: 0x39982A0 Offset: 0x39983A1 VA: 0x39982A0
	|-Task<VoidTaskResult>.get_Factory
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988D80 Offset: 0x3988E81 VA: 0x3988D80
	|-Task<Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x398A620 Offset: 0x398A721 VA: 0x398A620
	|-Task<ValueTuple<bool, object>>.InnerInvoke
	|
	|-RVA: 0x398BE80 Offset: 0x398BF81 VA: 0x398BE80
	|-Task<ValueTuple<int, int>>.InnerInvoke
	|
	|-RVA: 0x398D790 Offset: 0x398D891 VA: 0x398D790
	|-Task<ValueTuple<object, object, int>>.InnerInvoke
	|
	|-RVA: 0x398F110 Offset: 0x398F211 VA: 0x398F110
	|-Task<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|
	|-RVA: 0x39909B0 Offset: 0x3990AB1 VA: 0x39909B0
	|-Task<bool>.InnerInvoke
	|
	|-RVA: 0x39921F0 Offset: 0x39922F1 VA: 0x39921F0
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x3993A30 Offset: 0x3993B31 VA: 0x3993A30
	|-Task<long>.InnerInvoke
	|
	|-RVA: 0x39952B0 Offset: 0x39953B1 VA: 0x39952B0
	|-Task<object>.InnerInvoke
	|-Task<Task>.InnerInvoke
	|
	|-RVA: 0x3996B70 Offset: 0x3996C71 VA: 0x3996B70
	|-Task<SceneInstance>.InnerInvoke
	|
	|-RVA: 0x39983D0 Offset: 0x39984D1 VA: 0x39983D0
	|-Task<VoidTaskResult>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988E40 Offset: 0x3988F41 VA: 0x3988E40
	|-Task<Nullable<int>>.GetAwaiter
	|
	|-RVA: 0x398A700 Offset: 0x398A801 VA: 0x398A700
	|-Task<ValueTuple<bool, object>>.GetAwaiter
	|
	|-RVA: 0x398BF40 Offset: 0x398C041 VA: 0x398BF40
	|-Task<ValueTuple<int, int>>.GetAwaiter
	|
	|-RVA: 0x398D8A0 Offset: 0x398D9A1 VA: 0x398D8A0
	|-Task<ValueTuple<object, object, int>>.GetAwaiter
	|
	|-RVA: 0x398F220 Offset: 0x398F321 VA: 0x398F220
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|
	|-RVA: 0x3990A70 Offset: 0x3990B71 VA: 0x3990A70
	|-Task<bool>.GetAwaiter
	|
	|-RVA: 0x39922B0 Offset: 0x39923B1 VA: 0x39922B0
	|-Task<int>.GetAwaiter
	|
	|-RVA: 0x3993AF0 Offset: 0x3993BF1 VA: 0x3993AF0
	|-Task<long>.GetAwaiter
	|
	|-RVA: 0x3995390 Offset: 0x3995491 VA: 0x3995390
	|-Task<object>.GetAwaiter
	|-Task<WebRequestStream>.GetAwaiter
	|-Task<WebResponseStream>.GetAwaiter
	|
	|-RVA: 0x3996C50 Offset: 0x3996D51 VA: 0x3996C50
	|-Task<SceneInstance>.GetAwaiter
	|
	|-RVA: 0x3998490 Offset: 0x3998591 VA: 0x3998490
	|-Task<VoidTaskResult>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988E70 Offset: 0x3988F71 VA: 0x3988E70
	|-Task<Nullable<int>>.ConfigureAwait
	|
	|-RVA: 0x398A730 Offset: 0x398A831 VA: 0x398A730
	|-Task<ValueTuple<bool, object>>.ConfigureAwait
	|-Task<ValueTuple<bool, WebOperation>>.ConfigureAwait
	|
	|-RVA: 0x398BF70 Offset: 0x398C071 VA: 0x398BF70
	|-Task<ValueTuple<int, int>>.ConfigureAwait
	|
	|-RVA: 0x398D8D0 Offset: 0x398D9D1 VA: 0x398D8D0
	|-Task<ValueTuple<object, object, int>>.ConfigureAwait
	|-Task<ValueTuple<WebHeaderCollection, byte[], int>>.ConfigureAwait
	|
	|-RVA: 0x398F250 Offset: 0x398F351 VA: 0x398F250
	|-Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfigureAwait
	|-Task<ValueTuple<object, bool, bool, object, object>>.ConfigureAwait
	|
	|-RVA: 0x39953C0 Offset: 0x39954C1 VA: 0x39953C0
	|-Task<AsyncProtocolResult>.ConfigureAwait
	|-Task<BufferOffsetSize>.ConfigureAwait
	|-Task<object>.ConfigureAwait
	|-Task<Stream>.ConfigureAwait
	|-Task<Task>.ConfigureAwait
	|-Task<WebRequestStream>.ConfigureAwait
	|-Task<WebResponse>.ConfigureAwait
	|-Task<WebCompletionSource.Result>.ConfigureAwait
	|
	|-RVA: 0x3990AA0 Offset: 0x3990BA1 VA: 0x3990AA0
	|-Task<bool>.ConfigureAwait
	|
	|-RVA: 0x39922E0 Offset: 0x39923E1 VA: 0x39922E0
	|-Task<int>.ConfigureAwait
	|
	|-RVA: 0x3993B20 Offset: 0x3993C21 VA: 0x3993B20
	|-Task<long>.ConfigureAwait
	|
	|-RVA: 0x3996C80 Offset: 0x3996D81 VA: 0x3996C80
	|-Task<SceneInstance>.ConfigureAwait
	|
	|-RVA: 0x39984C0 Offset: 0x39985C1 VA: 0x39984C0
	|-Task<VoidTaskResult>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988EB0 Offset: 0x3988FB1 VA: 0x3988EB0
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x398A770 Offset: 0x398A871 VA: 0x398A770
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x398BFB0 Offset: 0x398C0B1 VA: 0x398BFB0
	|-Task<ValueTuple<int, int>>.ContinueWith
	|
	|-RVA: 0x398D910 Offset: 0x398DA11 VA: 0x398D910
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x398F290 Offset: 0x398F391 VA: 0x398F290
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x3990AE0 Offset: 0x3990BE1 VA: 0x3990AE0
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x3992320 Offset: 0x3992421 VA: 0x3992320
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x3993B60 Offset: 0x3993C61 VA: 0x3993B60
	|-Task<long>.ContinueWith
	|
	|-RVA: 0x3995400 Offset: 0x3995501 VA: 0x3995400
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x3996CC0 Offset: 0x3996DC1 VA: 0x3996CC0
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0x3998500 Offset: 0x3998601 VA: 0x3998500
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3988F70 Offset: 0x3989071 VA: 0x3988F70
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x398A830 Offset: 0x398A931 VA: 0x398A830
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x398C070 Offset: 0x398C171 VA: 0x398C070
	|-Task<ValueTuple<int, int>>.ContinueWith
	|
	|-RVA: 0x398D9D0 Offset: 0x398DAD1 VA: 0x398D9D0
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x398F350 Offset: 0x398F451 VA: 0x398F350
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x3990BA0 Offset: 0x3990CA1 VA: 0x3990BA0
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x39923E0 Offset: 0x39924E1 VA: 0x39923E0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x3993C20 Offset: 0x3993D21 VA: 0x3993C20
	|-Task<long>.ContinueWith
	|
	|-RVA: 0x39954C0 Offset: 0x39955C1 VA: 0x39954C0
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x3996D80 Offset: 0x3996E81 VA: 0x3996D80
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0x39985C0 Offset: 0x39986C1 VA: 0x39985C0
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3989120 Offset: 0x3989221 VA: 0x3989120
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x398A9E0 Offset: 0x398AAE1 VA: 0x398A9E0
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x398C220 Offset: 0x398C321 VA: 0x398C220
	|-Task<ValueTuple<int, int>>.ContinueWith
	|
	|-RVA: 0x398DB80 Offset: 0x398DC81 VA: 0x398DB80
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x398F500 Offset: 0x398F601 VA: 0x398F500
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x3990D50 Offset: 0x3990E51 VA: 0x3990D50
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x3992590 Offset: 0x3992691 VA: 0x3992590
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x3993DD0 Offset: 0x3993ED1 VA: 0x3993DD0
	|-Task<long>.ContinueWith
	|
	|-RVA: 0x3995670 Offset: 0x3995771 VA: 0x3995670
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x3996F30 Offset: 0x3997031 VA: 0x3996F30
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0x3998770 Offset: 0x3998871 VA: 0x3998770
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3989160 Offset: 0x3989261 VA: 0x3989160
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x398AA20 Offset: 0x398AB21 VA: 0x398AA20
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x398C260 Offset: 0x398C361 VA: 0x398C260
	|-Task<ValueTuple<int, int>>.ContinueWith
	|
	|-RVA: 0x398DBC0 Offset: 0x398DCC1 VA: 0x398DBC0
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x398F540 Offset: 0x398F641 VA: 0x398F540
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x3990D90 Offset: 0x3990E91 VA: 0x3990D90
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x39925D0 Offset: 0x39926D1 VA: 0x39925D0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x3993E10 Offset: 0x3993F11 VA: 0x3993E10
	|-Task<long>.ContinueWith
	|
	|-RVA: 0x39956B0 Offset: 0x39957B1 VA: 0x39956B0
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x3996F70 Offset: 0x3997071 VA: 0x3996F70
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0x39987B0 Offset: 0x39988B1 VA: 0x39987B0
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2556570 Offset: 0x2556671 VA: 0x2556570
	|-Task<ValueTuple<int, int>>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x25567D0 Offset: 0x25568D1 VA: 0x25567D0
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x2556890 Offset: 0x2556991 VA: 0x2556890
	|-Task<object>.ContinueWith<object>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2556630 Offset: 0x2556731 VA: 0x2556630
	|-Task<ValueTuple<int, int>>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x2556950 Offset: 0x2556A51 VA: 0x2556950
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x2556AF0 Offset: 0x2556BF1 VA: 0x2556AF0
	|-Task<object>.ContinueWith<object>
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3989310 Offset: 0x3989411 VA: 0x3989310
	|-Task<Nullable<int>>..cctor
	|
	|-RVA: 0x398ABD0 Offset: 0x398ACD1 VA: 0x398ABD0
	|-Task<ValueTuple<bool, object>>..cctor
	|
	|-RVA: 0x398C410 Offset: 0x398C511 VA: 0x398C410
	|-Task<ValueTuple<int, int>>..cctor
	|
	|-RVA: 0x398DD70 Offset: 0x398DE71 VA: 0x398DD70
	|-Task<ValueTuple<object, object, int>>..cctor
	|
	|-RVA: 0x398F6F0 Offset: 0x398F7F1 VA: 0x398F6F0
	|-Task<ValueTuple<object, bool, bool, object, object>>..cctor
	|
	|-RVA: 0x3990F40 Offset: 0x3991041 VA: 0x3990F40
	|-Task<bool>..cctor
	|
	|-RVA: 0x3992780 Offset: 0x3992881 VA: 0x3992780
	|-Task<int>..cctor
	|
	|-RVA: 0x3993FC0 Offset: 0x39940C1 VA: 0x3993FC0
	|-Task<long>..cctor
	|
	|-RVA: 0x3995860 Offset: 0x3995961 VA: 0x3995860
	|-Task<object>..cctor
	|
	|-RVA: 0x3997120 Offset: 0x3997221 VA: 0x3997120
	|-Task<SceneInstance>..cctor
	|
	|-RVA: 0x3998960 Offset: 0x3998A61 VA: 0x3998960
	|-Task<VoidTaskResult>..cctor
	*/
}

