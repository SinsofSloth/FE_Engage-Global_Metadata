// Namespace: MoonSharp.Interpreter.Platforms
public static class PlatformAutoDetector // TypeDefIndex: 6047
{
	// Fields
	private static bool m_AutoDetectionsDone; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xE640 Offset: 0xE741 VA: 0xE640
	private static bool <IsRunningOnMono>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0xE650 Offset: 0xE751 VA: 0xE650
	private static bool <IsRunningOnClr4>k__BackingField; // 0x2
	[CompilerGeneratedAttribute] // RVA: 0xE660 Offset: 0xE761 VA: 0xE660
	private static bool <IsRunningOnUnity>k__BackingField; // 0x3
	[CompilerGeneratedAttribute] // RVA: 0xE670 Offset: 0xE771 VA: 0xE670
	private static bool <IsPortableFramework>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0xE680 Offset: 0xE781 VA: 0xE680
	private static bool <IsUnityNative>k__BackingField; // 0x5
	[CompilerGeneratedAttribute] // RVA: 0xE690 Offset: 0xE791 VA: 0xE690
	private static bool <IsUnityIL2CPP>k__BackingField; // 0x6

	// Properties
	public static bool IsRunningOnMono { get; set; }
	public static bool IsRunningOnClr4 { get; set; }
	public static bool IsRunningOnUnity { get; set; }
	public static bool IsPortableFramework { get; set; }
	public static bool IsUnityNative { get; set; }
	public static bool IsUnityIL2CPP { get; set; }
	public static bool IsRunningOnAOT { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10210 Offset: 0x10311 VA: 0x10210
	// RVA: 0x2BC96B0 Offset: 0x2BC97B1 VA: 0x2BC96B0
	public static bool get_IsRunningOnMono() { }

	[CompilerGeneratedAttribute] // RVA: 0x10220 Offset: 0x10321 VA: 0x10220
	// RVA: 0x2BC9720 Offset: 0x2BC9821 VA: 0x2BC9720
	private static void set_IsRunningOnMono(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10230 Offset: 0x10331 VA: 0x10230
	// RVA: 0x2BC97A0 Offset: 0x2BC98A1 VA: 0x2BC97A0
	public static bool get_IsRunningOnClr4() { }

	[CompilerGeneratedAttribute] // RVA: 0x10240 Offset: 0x10341 VA: 0x10240
	// RVA: 0x2BC9810 Offset: 0x2BC9911 VA: 0x2BC9810
	private static void set_IsRunningOnClr4(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10250 Offset: 0x10351 VA: 0x10250
	// RVA: 0x2BC9890 Offset: 0x2BC9991 VA: 0x2BC9890
	public static bool get_IsRunningOnUnity() { }

	[CompilerGeneratedAttribute] // RVA: 0x10260 Offset: 0x10361 VA: 0x10260
	// RVA: 0x2BC9900 Offset: 0x2BC9A01 VA: 0x2BC9900
	private static void set_IsRunningOnUnity(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10270 Offset: 0x10371 VA: 0x10270
	// RVA: 0x2BC9980 Offset: 0x2BC9A81 VA: 0x2BC9980
	public static bool get_IsPortableFramework() { }

	[CompilerGeneratedAttribute] // RVA: 0x10280 Offset: 0x10381 VA: 0x10280
	// RVA: 0x2BC99F0 Offset: 0x2BC9AF1 VA: 0x2BC99F0
	private static void set_IsPortableFramework(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10290 Offset: 0x10391 VA: 0x10290
	// RVA: 0x2BC9A70 Offset: 0x2BC9B71 VA: 0x2BC9A70
	public static bool get_IsUnityNative() { }

	[CompilerGeneratedAttribute] // RVA: 0x102A0 Offset: 0x103A1 VA: 0x102A0
	// RVA: 0x2BC9AE0 Offset: 0x2BC9BE1 VA: 0x2BC9AE0
	private static void set_IsUnityNative(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x102B0 Offset: 0x103B1 VA: 0x102B0
	// RVA: 0x2BC9B60 Offset: 0x2BC9C61 VA: 0x2BC9B60
	public static bool get_IsUnityIL2CPP() { }

	[CompilerGeneratedAttribute] // RVA: 0x102C0 Offset: 0x103C1 VA: 0x102C0
	// RVA: 0x2BC9BD0 Offset: 0x2BC9CD1 VA: 0x2BC9BD0
	private static void set_IsUnityIL2CPP(bool value) { }

	// RVA: 0x2BC9610 Offset: 0x2BC9711 VA: 0x2BC9610
	public static bool get_IsRunningOnAOT() { }

	// RVA: 0x2BC9C50 Offset: 0x2BC9D51 VA: 0x2BC9C50
	private static void AutoDetectPlatformFlags() { }

	// RVA: 0x2BCA0B0 Offset: 0x2BCA1B1 VA: 0x2BCA0B0
	internal static IPlatformAccessor GetDefaultPlatform() { }

	// RVA: 0x2BCA1E0 Offset: 0x2BCA2E1 VA: 0x2BCA1E0
	internal static IScriptLoader GetDefaultScriptLoader() { }

	// RVA: 0x2BCA310 Offset: 0x2BCA411 VA: 0x2BCA310
	private static void .cctor() { }
}

