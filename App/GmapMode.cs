// Namespace: App
public class GmapMode // TypeDefIndex: 10309
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DD90 Offset: 0x28DE91 VA: 0x28DD90
	private static bool <IsAlongPath>k__BackingField; // 0x0

	// Properties
	public static bool IsAlongPath { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BD940 Offset: 0x2BDA41 VA: 0x2BD940
	// RVA: 0x28EECE0 Offset: 0x28EEDE1 VA: 0x28EECE0
	public static bool get_IsAlongPath() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD950 Offset: 0x2BDA51 VA: 0x2BD950
	// RVA: 0x28EED50 Offset: 0x28EEE51 VA: 0x28EED50
	public static void set_IsAlongPath(bool value) { }

	// RVA: 0x28EEDD0 Offset: 0x28EEED1 VA: 0x28EEDD0
	public static GmapMode.Mode GetMode() { }

	// RVA: 0x28EEE50 Offset: 0x28EEF51 VA: 0x28EEE50
	public static void SetMode(GmapMode.Mode mode) { }

	// RVA: 0x28EEF60 Offset: 0x28EF061 VA: 0x28EEF60
	public static void GoMode(GmapMode.Mode mode) { }

	// RVA: 0x28EF0F0 Offset: 0x28EF1F1 VA: 0x28EF0F0
	public static string GetSceneName(GmapMode.Mode mode) { }

	// RVA: 0x28EF1B0 Offset: 0x28EF2B1 VA: 0x28EF1B0
	public static void SetNowSpotId(string spotId) { }

	// RVA: 0x28D2E80 Offset: 0x28D2F81 VA: 0x28D2E80
	public static void SetNowSpotId(GmapMode.Mode mode, string spotId) { }

	// RVA: 0x28EF380 Offset: 0x28EF481 VA: 0x28EF380
	public static string GetNowSpotId() { }

	// RVA: 0x28E9F00 Offset: 0x28EA001 VA: 0x28E9F00
	public static bool CanMoveDlcMap() { }

	// RVA: 0x28EA010 Offset: 0x28EA111 VA: 0x28EA010
	public static bool CanMoveGod() { }

	// RVA: 0x28EA0A0 Offset: 0x28EA1A1 VA: 0x28EA0A0
	public static bool CanMoveEvil() { }

	// RVA: 0x28EF460 Offset: 0x28EF561 VA: 0x28EF460
	public static bool CheckSpotModeOnGmap(GmapSpot spot, GmapMode.Mode mode) { }

	// RVA: 0x28EF660 Offset: 0x28EF761 VA: 0x28EF660
	public static bool CheckSpotModeAtChapter(GmapSpot spot, GmapMode.Mode mode) { }

	// RVA: 0x28EF6F0 Offset: 0x28EF7F1 VA: 0x28EF6F0
	public static bool CheckSpotModeOnGmap(string spotID, GmapMode.Mode mode) { }

	// RVA: 0x28EF4F0 Offset: 0x28EF5F1 VA: 0x28EF4F0
	private static bool CheckSpotModeImpl(string spotID, GmapMode.Mode mode, bool onGmap) { }

	// RVA: 0x28EF770 Offset: 0x28EF871 VA: 0x28EF770
	public static string GetDlcGmapPathAssetPath() { }

	// RVA: 0x28EF7C0 Offset: 0x28EF8C1 VA: 0x28EF7C0
	public static string GetDlcGmapSpotAssetPath() { }

	// RVA: 0x28EF810 Offset: 0x28EF911 VA: 0x28EF810
	public void .ctor() { }

	// RVA: 0x28EF820 Offset: 0x28EF921 VA: 0x28EF820
	private static void .cctor() { }
}

