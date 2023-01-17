// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
[NativeHeaderAttribute] // RVA: 0x43B980 Offset: 0x43BA81 VA: 0x43B980
public class Application // TypeDefIndex: 3402
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x4423A0 Offset: 0x4424A1 VA: 0x4423A0
	[CompilerGeneratedAttribute] // RVA: 0x4423A0 Offset: 0x4424A1 VA: 0x4423A0
	private static Application.LowMemoryCallback lowMemory; // 0x0
	private static Application.LogCallback s_LogCallbackHandler; // 0x8
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x4423E0 Offset: 0x4424E1 VA: 0x4423E0
	[CompilerGeneratedAttribute] // RVA: 0x4423E0 Offset: 0x4424E1 VA: 0x4423E0
	private static Action<bool> focusChanged; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x442420 Offset: 0x442521 VA: 0x442420
	[DebuggerBrowsableAttribute] // RVA: 0x442420 Offset: 0x442521 VA: 0x442420
	private static Action<string> deepLinkActivated; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x442460 Offset: 0x442561 VA: 0x442460
	[DebuggerBrowsableAttribute] // RVA: 0x442460 Offset: 0x442561 VA: 0x442460
	private static Func<bool> wantsToQuit; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x4424A0 Offset: 0x4425A1 VA: 0x4424A0
	[CompilerGeneratedAttribute] // RVA: 0x4424A0 Offset: 0x4425A1 VA: 0x4424A0
	private static Action quitting; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x4424E0 Offset: 0x4425E1 VA: 0x4424E0
	[DebuggerBrowsableAttribute] // RVA: 0x4424E0 Offset: 0x4425E1 VA: 0x4424E0
	private static Action unloading; // 0x38

	// Properties
	public static bool isPlaying { get; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	public static string persistentDataPath { get; }
	public static string temporaryCachePath { get; }
	public static string productName { get; }
	public static ThreadPriority backgroundLoadingPriority { set; }
	public static RuntimePlatform platform { get; }
	public static bool isMobilePlatform { get; }
	public static bool isEditor { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x446210 Offset: 0x446311 VA: 0x446210
	// RVA: 0x2F09C90 Offset: 0x2F09D91 VA: 0x2F09C90
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute] // RVA: 0x446250 Offset: 0x446351 VA: 0x446250
	// RVA: 0x2F09CD0 Offset: 0x2F09DD1 VA: 0x2F09CD0
	public static string get_dataPath() { }

	[FreeFunctionAttribute] // RVA: 0x446290 Offset: 0x446391 VA: 0x446290
	// RVA: 0x2F09D10 Offset: 0x2F09E11 VA: 0x2F09D10
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute] // RVA: 0x4462E0 Offset: 0x4463E1 VA: 0x4462E0
	// RVA: 0x2F09D50 Offset: 0x2F09E51 VA: 0x2F09D50
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute] // RVA: 0x446320 Offset: 0x446421 VA: 0x446320
	// RVA: 0x2F09D90 Offset: 0x2F09E91 VA: 0x2F09D90
	public static string get_temporaryCachePath() { }

	[FreeFunctionAttribute] // RVA: 0x446360 Offset: 0x446461 VA: 0x446360
	// RVA: 0x2F09DD0 Offset: 0x2F09ED1 VA: 0x2F09DD0
	public static string get_productName() { }

	[FreeFunctionAttribute] // RVA: 0x4463A0 Offset: 0x4464A1 VA: 0x4463A0
	// RVA: 0x2F09E10 Offset: 0x2F09F11 VA: 0x2F09E10
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute] // RVA: 0x4463E0 Offset: 0x4464E1 VA: 0x4463E0
	// RVA: 0x2F09E60 Offset: 0x2F09F61 VA: 0x2F09E60
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute] // RVA: 0x446420 Offset: 0x446521 VA: 0x446420
	// RVA: 0x2F09EB0 Offset: 0x2F09FB1 VA: 0x2F09EB0
	public static RuntimePlatform get_platform() { }

	// RVA: 0x2F09EF0 Offset: 0x2F09FF1 VA: 0x2F09EF0
	public static bool get_isMobilePlatform() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x446470 Offset: 0x446571 VA: 0x446470
	// RVA: 0x2F09F90 Offset: 0x2F0A091 VA: 0x2F09F90
	internal static void CallLowMemory() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x446480 Offset: 0x446581 VA: 0x446480
	// RVA: 0x2F09FF0 Offset: 0x2F0A0F1 VA: 0x2F09FF0
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x446490 Offset: 0x446591 VA: 0x446490
	// RVA: 0x2F0A0B0 Offset: 0x2F0A1B1 VA: 0x2F0A0B0
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4464A0 Offset: 0x4465A1 VA: 0x4464A0
	// RVA: 0x2F0A400 Offset: 0x2F0A501 VA: 0x2F0A400
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4464B0 Offset: 0x4465B1 VA: 0x4464B0
	// RVA: 0x2F0A460 Offset: 0x2F0A561 VA: 0x2F0A460
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4464C0 Offset: 0x4465C1 VA: 0x4464C0
	// RVA: 0x2F0A4C0 Offset: 0x2F0A5C1 VA: 0x2F0A4C0
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4464D0 Offset: 0x4465D1 VA: 0x4464D0
	// RVA: 0x2F0A6C0 Offset: 0x2F0A7C1 VA: 0x2F0A6C0
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4464E0 Offset: 0x4465E1 VA: 0x4464E0
	// RVA: 0x2F0A750 Offset: 0x2F0A851 VA: 0x2F0A750
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x2F0A7E0 Offset: 0x2F0A8E1 VA: 0x2F0A7E0
	public static bool get_isEditor() { }
}

