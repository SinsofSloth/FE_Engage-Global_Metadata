// Namespace: App
public static class SwitchNotificationHandler // TypeDefIndex: 9165
{
	// Fields
	private static bool OperationModeInitialized; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x286D20 Offset: 0x286E21 VA: 0x286D20
	private static Operation.OperationMode <OperationMode>k__BackingField; // 0x4
	private static bool PerformanceModeInitialized; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x286D30 Offset: 0x286E31 VA: 0x286D30
	private static Performance.PerformanceMode <PerformanceMode>k__BackingField; // 0xC

	// Properties
	public static bool IsDocked { get; }
	public static bool IsBoosted { get; }
	private static Operation.OperationMode OperationMode { get; set; }
	private static Performance.PerformanceMode PerformanceMode { get; set; }

	// Methods

	// RVA: 0x2929AB0 Offset: 0x2929BB1 VA: 0x2929AB0
	public static bool get_IsDocked() { }

	// RVA: 0x2929CC0 Offset: 0x2929DC1 VA: 0x2929CC0
	public static bool get_IsBoosted() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE670 Offset: 0x2AE771 VA: 0x2AE670
	// RVA: 0x2929EC0 Offset: 0x2929FC1 VA: 0x2929EC0
	private static Operation.OperationMode get_OperationMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE680 Offset: 0x2AE781 VA: 0x2AE680
	// RVA: 0x2929F30 Offset: 0x292A031 VA: 0x2929F30
	private static void set_OperationMode(Operation.OperationMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE690 Offset: 0x2AE791 VA: 0x2AE690
	// RVA: 0x2929FA0 Offset: 0x292A0A1 VA: 0x2929FA0
	private static Performance.PerformanceMode get_PerformanceMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE6A0 Offset: 0x2AE7A1 VA: 0x2AE6A0
	// RVA: 0x292A010 Offset: 0x292A111 VA: 0x292A010
	private static void set_PerformanceMode(Performance.PerformanceMode value) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x2AE6B0 Offset: 0x2AE7B1 VA: 0x2AE6B0
	// RVA: 0x292A080 Offset: 0x292A181 VA: 0x292A080
	private static void OnRuntimeMethodLoad() { }

	// RVA: 0x292A160 Offset: 0x292A261 VA: 0x292A160
	private static void OnNotificationMessage(Notification.Message message) { }

	// RVA: 0x2929BD0 Offset: 0x2929CD1 VA: 0x2929BD0
	private static void UpdateOperationMode() { }

	// RVA: 0x2929DE0 Offset: 0x2929EE1 VA: 0x2929DE0
	private static void UpdatePerformanceMode() { }

	// RVA: 0x292A220 Offset: 0x292A321 VA: 0x292A220
	private static void .cctor() { }
}

