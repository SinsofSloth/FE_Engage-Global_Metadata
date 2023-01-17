// Namespace: UniRx
public sealed class MainThreadDispatcher : MonoBehaviour // TypeDefIndex: 6698
{
	// Fields
	public static MainThreadDispatcher.CullingMode cullingMode; // 0x0
	private ThreadSafeQueueWorker queueWorker; // 0x18
	private Action<Exception> unhandledExceptionCallback; // 0x20
	private MicroCoroutine updateMicroCoroutine; // 0x28
	private MicroCoroutine fixedUpdateMicroCoroutine; // 0x30
	private MicroCoroutine endOfFrameMicroCoroutine; // 0x38
	private static MainThreadDispatcher instance; // 0x8
	private static bool initialized; // 0x10
	private static bool isQuitting; // 0x11
	[ThreadStaticAttribute] // RVA: 0x13BD0 Offset: 0x13CD1 VA: 0x13BD0
	private static object mainThreadToken; // 0x80000000
	private Subject<Unit> update; // 0x40
	private Subject<Unit> lateUpdate; // 0x48
	private Subject<bool> onApplicationFocus; // 0x50
	private Subject<bool> onApplicationPause; // 0x58
	private Subject<Unit> onApplicationQuit; // 0x60

	// Properties
	public static string InstanceName { get; }
	public static bool IsInitialized { get; }
	private static MainThreadDispatcher Instance { get; }
	public static bool IsInMainThread { get; }

	// Methods

	// RVA: 0x19D2DC0 Offset: 0x19D2EC1 VA: 0x19D2DC0
	public static void Post(Action<object> action, object state) { }

	// RVA: 0x19D2F20 Offset: 0x19D3021 VA: 0x19D2F20
	public static void Send(Action<object> action, object state) { }

	// RVA: 0x19D3170 Offset: 0x19D3271 VA: 0x19D3170
	public static void UnsafeSend(Action action) { }

	// RVA: -1 Offset: -1
	public static void UnsafeSend<T>(Action<T> action, T state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295C7B0 Offset: 0x295C8B1 VA: 0x295C7B0
	|-MainThreadDispatcher.UnsafeSend<object>
	|
	|-RVA: 0x295C900 Offset: 0x295CA01 VA: 0x295C900
	|-MainThreadDispatcher.UnsafeSend<Unit>
	*/

	// RVA: 0x19D3310 Offset: 0x19D3411 VA: 0x19D3310
	public static void SendStartCoroutine(IEnumerator routine) { }

	// RVA: 0x19D3610 Offset: 0x19D3711 VA: 0x19D3610
	public static void StartUpdateMicroCoroutine(IEnumerator routine) { }

	// RVA: 0x19D39E0 Offset: 0x19D3AE1 VA: 0x19D39E0
	public static void StartFixedUpdateMicroCoroutine(IEnumerator routine) { }

	// RVA: 0x19D3B00 Offset: 0x19D3C01 VA: 0x19D3B00
	public static void StartEndOfFrameMicroCoroutine(IEnumerator routine) { }

	// RVA: 0x19D34F0 Offset: 0x19D35F1 VA: 0x19D34F0
	public static Coroutine StartCoroutine(IEnumerator routine) { }

	// RVA: 0x19D3C20 Offset: 0x19D3D21 VA: 0x19D3C20
	public static void RegisterUnhandledExceptionCallback(Action<Exception> exceptionCallback) { }

	// RVA: 0x19D3D80 Offset: 0x19D3E81 VA: 0x19D3D80
	public static string get_InstanceName() { }

	// RVA: 0x19D3EA0 Offset: 0x19D3FA1 VA: 0x19D3EA0
	public static bool get_IsInitialized() { }

	// RVA: 0x19D2EB0 Offset: 0x19D2FB1 VA: 0x19D2EB0
	private static MainThreadDispatcher get_Instance() { }

	// RVA: 0x19D3F90 Offset: 0x19D4091 VA: 0x19D3F90
	public static void Initialize() { }

	// RVA: 0x19D4800 Offset: 0x19D4901 VA: 0x19D4800
	public static bool get_IsInMainThread() { }

	// RVA: 0x19D4240 Offset: 0x19D4341 VA: 0x19D4240
	private void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x16610 Offset: 0x16711 VA: 0x16610
	// RVA: 0x19D49B0 Offset: 0x19D4AB1 VA: 0x19D49B0
	private IEnumerator RunUpdateMicroCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x16680 Offset: 0x16781 VA: 0x16680
	// RVA: 0x19D4A30 Offset: 0x19D4B31 VA: 0x19D4A30
	private IEnumerator RunFixedUpdateMicroCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x166F0 Offset: 0x167F1 VA: 0x166F0
	// RVA: 0x19D4AB0 Offset: 0x19D4BB1 VA: 0x19D4AB0
	private IEnumerator RunEndOfFrameMicroCoroutine() { }

	// RVA: 0x19D4B30 Offset: 0x19D4C31 VA: 0x19D4B30
	private static void DestroyDispatcher(MainThreadDispatcher aDispatcher) { }

	// RVA: 0x19D4CE0 Offset: 0x19D4DE1 VA: 0x19D4CE0
	public static void CullAllExcessDispatchers() { }

	// RVA: 0x19D4DF0 Offset: 0x19D4EF1 VA: 0x19D4DF0
	private void OnDestroy() { }

	// RVA: 0x19D4F30 Offset: 0x19D5031 VA: 0x19D4F30
	private void Update() { }

	// RVA: 0x19D50C0 Offset: 0x19D51C1 VA: 0x19D50C0
	public static IObservable<Unit> UpdateAsObservable() { }

	// RVA: 0x19D5230 Offset: 0x19D5331 VA: 0x19D5230
	private void LateUpdate() { }

	// RVA: 0x19D5330 Offset: 0x19D5431 VA: 0x19D5330
	public static IObservable<Unit> LateUpdateAsObservable() { }

	// RVA: 0x19D54A0 Offset: 0x19D55A1 VA: 0x19D54A0
	private void OnApplicationFocus(bool focus) { }

	// RVA: 0x19D5510 Offset: 0x19D5611 VA: 0x19D5510
	public static IObservable<bool> OnApplicationFocusAsObservable() { }

	// RVA: 0x19D5680 Offset: 0x19D5781 VA: 0x19D5680
	private void OnApplicationPause(bool pause) { }

	// RVA: 0x19D56F0 Offset: 0x19D57F1 VA: 0x19D56F0
	public static IObservable<bool> OnApplicationPauseAsObservable() { }

	// RVA: 0x19D5860 Offset: 0x19D5961 VA: 0x19D5860
	private void OnApplicationQuit() { }

	// RVA: 0x19D5990 Offset: 0x19D5A91 VA: 0x19D5990
	public static IObservable<Unit> OnApplicationQuitAsObservable() { }

	// RVA: 0x19D5B00 Offset: 0x19D5C01 VA: 0x19D5B00
	public void .ctor() { }

	// RVA: 0x19D5C60 Offset: 0x19D5D61 VA: 0x19D5C60
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x16760 Offset: 0x16861 VA: 0x16760
	// RVA: 0x19D5CC0 Offset: 0x19D5DC1 VA: 0x19D5CC0
	private void <Awake>b__30_0(Exception ex) { }

	[CompilerGeneratedAttribute] // RVA: 0x16770 Offset: 0x16871 VA: 0x16770
	// RVA: 0x19D5D20 Offset: 0x19D5E21 VA: 0x19D5D20
	private void <Awake>b__30_1(Exception ex) { }

	[CompilerGeneratedAttribute] // RVA: 0x16780 Offset: 0x16881 VA: 0x16780
	// RVA: 0x19D5D80 Offset: 0x19D5E81 VA: 0x19D5D80
	private void <Awake>b__30_2(Exception ex) { }
}

