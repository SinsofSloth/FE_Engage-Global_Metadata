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

// Namespace: System.Threading.Tasks
[DebuggerTypeProxyAttribute] // RVA: 0x473840 Offset: 0x473941 VA: 0x473840
[DebuggerDisplayAttribute] // RVA: 0x473840 Offset: 0x473941 VA: 0x473840
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 836
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x479120 Offset: 0x479221 VA: 0x479120
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x479130 Offset: 0x479231 VA: 0x479130
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0x479140 Offset: 0x479241 VA: 0x479140
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x47CDA0 Offset: 0x47CEA1 VA: 0x47CDA0
	// RVA: 0x365F5C0 Offset: 0x365F6C1 VA: 0x365F5C0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47CDB0 Offset: 0x47CEB1 VA: 0x47CDB0
	// RVA: 0x365F830 Offset: 0x365F931 VA: 0x365F830
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x365F990 Offset: 0x365FA91 VA: 0x365F990
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x365FA60 Offset: 0x365FB61 VA: 0x365FA60
	internal void .ctor() { }

	// RVA: 0x365FAA0 Offset: 0x365FBA1 VA: 0x365FAA0
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x365FDD0 Offset: 0x365FED1 VA: 0x365FDD0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x365FC10 Offset: 0x365FD11 VA: 0x365FC10
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x3660090 Offset: 0x3660191 VA: 0x3660090
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x36609D0 Offset: 0x3660AD1 VA: 0x36609D0
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x3660D60 Offset: 0x3660E61 VA: 0x3660D60
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x3660500 Offset: 0x3660601 VA: 0x3660500
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x3660EC0 Offset: 0x3660FC1 VA: 0x3660EC0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x3660ED0 Offset: 0x3660FD1 VA: 0x3660ED0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x3660F70 Offset: 0x3661071 VA: 0x3660F70
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x3661020 Offset: 0x3661121 VA: 0x3661020
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x36610F0 Offset: 0x36611F1 VA: 0x36610F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x36611B0 Offset: 0x36612B1 VA: 0x36611B0
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x36611F0 Offset: 0x36612F1 VA: 0x36611F0 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x3661150 Offset: 0x3661251 VA: 0x3661150
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x3661180 Offset: 0x3661281 VA: 0x3661180
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x3661220 Offset: 0x3661321 VA: 0x3661220
	internal bool MarkStarted() { }

	// RVA: 0x36612D0 Offset: 0x36613D1 VA: 0x36612D0
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x365FF20 Offset: 0x3660021 VA: 0x365FF20
	internal void AddNewChild() { }

	// RVA: 0x3660910 Offset: 0x3660A11 VA: 0x3660910
	internal void DisregardChild() { }

	// RVA: 0x3661360 Offset: 0x3661461 VA: 0x3661360
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x3661950 Offset: 0x3661A51 VA: 0x3661950
	internal static int NewId() { }

	// RVA: 0x365F730 Offset: 0x365F831 VA: 0x365F730
	public int get_Id() { }

	// RVA: 0x36619D0 Offset: 0x3661AD1 VA: 0x36619D0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x3661A40 Offset: 0x3661B41 VA: 0x3661A40
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x3661B20 Offset: 0x3661C21 VA: 0x3661B20
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x3661C00 Offset: 0x3661D01 VA: 0x3661C00
	public AggregateException get_Exception() { }

	// RVA: 0x3661E70 Offset: 0x3661F71 VA: 0x3661E70
	public TaskStatus get_Status() { }

	// RVA: 0x3661F10 Offset: 0x3662011 VA: 0x3661F10
	public bool get_IsCanceled() { }

	// RVA: 0x3661F40 Offset: 0x3662041 VA: 0x3661F40
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x36604B0 Offset: 0x36605B1 VA: 0x36604B0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x3661FA0 Offset: 0x36620A1 VA: 0x3661FA0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x3662090 Offset: 0x3662191 VA: 0x3662090
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x36620D0 Offset: 0x36621D1 VA: 0x36620D0
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x3662100 Offset: 0x3662201 VA: 0x3662100 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x3662180 Offset: 0x3662281 VA: 0x3662180
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x3662190 Offset: 0x3662291 VA: 0x3662190
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x365FEB0 Offset: 0x365FFB1 VA: 0x365FEB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x36621D0 Offset: 0x36622D1 VA: 0x36621D0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x3662470 Offset: 0x3662571 VA: 0x3662470 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x3662480 Offset: 0x3662581 VA: 0x3662480 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x3662490 Offset: 0x3662591 VA: 0x3662490
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x36624A0 Offset: 0x36625A1 VA: 0x36624A0
	public static TaskFactory get_Factory() { }

	// RVA: 0x3662510 Offset: 0x3662611 VA: 0x3662510
	public static Task get_CompletedTask() { }

	// RVA: 0x3662260 Offset: 0x3662361 VA: 0x3662260
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x36612E0 Offset: 0x36613E1 VA: 0x36612E0
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x3662610 Offset: 0x3662711 VA: 0x3662610
	internal bool get_IsChildReplica() { }

	// RVA: 0x3662680 Offset: 0x3662781 VA: 0x3662680
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x3661C40 Offset: 0x3661D41 VA: 0x3661C40
	public bool get_IsFaulted() { }

	// RVA: 0x3662710 Offset: 0x3662811 VA: 0x3662710
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x3660DE0 Offset: 0x3660EE1 VA: 0x3660DE0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x3662810 Offset: 0x3662911 VA: 0x3662810
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x3662910 Offset: 0x3662A11 VA: 0x3662910 Slot: 10
	public void Dispose() { }

	// RVA: 0x3662990 Offset: 0x3662A91 VA: 0x3662990 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36614D0 Offset: 0x36615D1 VA: 0x36614D0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x3662B20 Offset: 0x3662C21 VA: 0x3662B20
	internal void AddException(object exceptionObject) { }

	// RVA: 0x3662FF0 Offset: 0x36630F1 VA: 0x3662FF0
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x3661C70 Offset: 0x3661D71 VA: 0x3661C70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x3663650 Offset: 0x3663751 VA: 0x3663650
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x3663840 Offset: 0x3663941 VA: 0x3663840
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x3663890 Offset: 0x3663991 VA: 0x3663890
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x36638E0 Offset: 0x36639E1 VA: 0x36638E0
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x3663A60 Offset: 0x3663B61 VA: 0x3663A60
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x3663A90 Offset: 0x3663B91 VA: 0x3663A90
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x3662CF0 Offset: 0x3662DF1 VA: 0x3662CF0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x3663AC0 Offset: 0x3663BC1 VA: 0x3663AC0
	internal void FinishStageTwo() { }

	// RVA: 0x3663FD0 Offset: 0x36640D1 VA: 0x3663FD0
	internal void FinishStageThree() { }

	// RVA: 0x3664080 Offset: 0x3664181 VA: 0x3664080
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x3663D60 Offset: 0x3663E61 VA: 0x3663D60
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x3662B30 Offset: 0x3662C31 VA: 0x3662B30
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x36648C0 Offset: 0x36649C1 VA: 0x36648C0
	private void Execute() { }

	// RVA: 0x3664D80 Offset: 0x3664E81 VA: 0x3664D80 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x3664D90 Offset: 0x3664E91 VA: 0x3664D90 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x3664E40 Offset: 0x3664F41 VA: 0x3664E40 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x3664E50 Offset: 0x3664F51 VA: 0x3664E50 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x3664E60 Offset: 0x3664F61 VA: 0x3664E60 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x3664E70 Offset: 0x3664F71 VA: 0x3664E70 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x3664AC0 Offset: 0x3664BC1 VA: 0x3664AC0
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x3664E80 Offset: 0x3664F81 VA: 0x3664E80 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3664E90 Offset: 0x3664F91 VA: 0x3664E90 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x365DE60 Offset: 0x365DF61 VA: 0x365DE60
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x3664F40 Offset: 0x3665041 VA: 0x3664F40
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x3665340 Offset: 0x3665441 VA: 0x3665340
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x36653D0 Offset: 0x36654D1 VA: 0x36653D0 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x3665490 Offset: 0x3665591 VA: 0x3665490
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x3664C40 Offset: 0x3664D41 VA: 0x3664C40
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x36654F0 Offset: 0x36655F1 VA: 0x36654F0
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x3665520 Offset: 0x3665621 VA: 0x3665520
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x3665560 Offset: 0x3665661 VA: 0x3665560
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x3665AB0 Offset: 0x3665BB1 VA: 0x3665AB0
	public void Wait() { }

	// RVA: 0x3665AC0 Offset: 0x3665BC1 VA: 0x3665AC0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x3665ED0 Offset: 0x3665FD1 VA: 0x3665ED0
	private bool WrappedTryRunInline() { }

	// RVA: 0x3665C30 Offset: 0x3665D31 VA: 0x3665C30
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x36661B0 Offset: 0x36662B1 VA: 0x36661B0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x3666450 Offset: 0x3666551 VA: 0x3666450
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x3660570 Offset: 0x3660671 VA: 0x3660570
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x3666690 Offset: 0x3666791 VA: 0x3666690
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x3666750 Offset: 0x3666851 VA: 0x3666750
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x3666800 Offset: 0x3666901 VA: 0x3666800
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x3665230 Offset: 0x3665331 VA: 0x3665230
	internal void CancellationCleanupLogic() { }

	// RVA: 0x36654C0 Offset: 0x36655C1 VA: 0x36654C0
	private void SetCancellationAcknowledged() { }

	// RVA: 0x3664250 Offset: 0x3664351 VA: 0x3664250
	internal void FinishContinuations() { }

	// RVA: 0x3666840 Offset: 0x3666941 VA: 0x3666840
	private void LogFinishCompletionNotification() { }

	// RVA: 0x3666870 Offset: 0x3666971 VA: 0x3666870
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x3666B90 Offset: 0x3666C91 VA: 0x3666B90
	public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x3666A10 Offset: 0x3666B11 VA: 0x3666A10
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x3666F10 Offset: 0x3667011 VA: 0x3666F10
	public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler) { }

	// RVA: 0x36670D0 Offset: 0x36671D1 VA: 0x36670D0
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x3666F40 Offset: 0x3667041 VA: 0x3666F40
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x3666C30 Offset: 0x3666D31 VA: 0x3666C30
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x3666D50 Offset: 0x3666E51 VA: 0x3666D50
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x3667110 Offset: 0x3667211 VA: 0x3667110
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x36665C0 Offset: 0x36666C1 VA: 0x36665C0
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x36671E0 Offset: 0x36672E1 VA: 0x36671E0
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x36659C0 Offset: 0x3665AC1 VA: 0x36659C0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x3660AC0 Offset: 0x3660BC1 VA: 0x3660AC0
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20251F0 Offset: 0x20252F1 VA: 0x20251F0
	|-Task.FromResult<Tuple<int, int, int, bool>>
	|-Task.FromResult<BufferOffsetSize>
	|-Task.FromResult<object>
	|
	|-RVA: 0x2025110 Offset: 0x2025211 VA: 0x2025110
	|-Task.FromResult<bool>
	|
	|-RVA: 0x2025180 Offset: 0x2025281 VA: 0x2025180
	|-Task.FromResult<int>
	*/

	// RVA: 0x3667550 Offset: 0x3667651 VA: 0x3667550
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2024EA0 Offset: 0x2024FA1 VA: 0x2024EA0
	|-Task.FromException<int>
	|
	|-RVA: 0x2024F70 Offset: 0x2025071 VA: 0x2024F70
	|-Task.FromException<object>
	|
	|-RVA: 0x2025040 Offset: 0x2025141 VA: 0x2025040
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0x47CDC0 Offset: 0x47CEC1 VA: 0x47CDC0
	// RVA: 0x36675D0 Offset: 0x36676D1 VA: 0x36675D0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47CDD0 Offset: 0x47CED1 VA: 0x47CDD0
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20249C0 Offset: 0x2024AC1 VA: 0x20249C0
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x2024B60 Offset: 0x2024C61 VA: 0x2024B60
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x2024D00 Offset: 0x2024E01 VA: 0x2024D00
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2024A90 Offset: 0x2024B91 VA: 0x2024A90
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x2024C30 Offset: 0x2024D31 VA: 0x2024C30
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x2024DD0 Offset: 0x2024ED1 VA: 0x2024DD0
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x36676A0 Offset: 0x36677A1 VA: 0x36676A0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2025260 Offset: 0x2025361 VA: 0x2025260
	|-Task.Run<int>
	|
	|-RVA: 0x2025450 Offset: 0x2025551 VA: 0x2025450
	|-Task.Run<object>
	|-Task.Run<Stream>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20253D0 Offset: 0x20254D1 VA: 0x20253D0
	|-Task.Run<object>
	|-Task.Run<WebResponse>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20255C0 Offset: 0x20256C1 VA: 0x20255C0
	|-Task.Run<object>
	*/

	// RVA: 0x36677C0 Offset: 0x36678C1 VA: 0x36677C0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x3667830 Offset: 0x3667931 VA: 0x3667830
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x3667BC0 Offset: 0x3667CC1 VA: 0x3667BC0
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x3668120 Offset: 0x3668221 VA: 0x3668120
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	// RVA: 0x3668540 Offset: 0x3668641 VA: 0x3668540
	private static void .cctor() { }
}

