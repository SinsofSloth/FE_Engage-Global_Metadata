// Namespace: UnityEngine.Switch
public static class Notification // TypeDefIndex: 7542
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x48A8A0 Offset: 0x48A9A1 VA: 0x48A8A0
	[CompilerGeneratedAttribute] // RVA: 0x48A8A0 Offset: 0x48A9A1 VA: 0x48A8A0
	private static Action<Notification.Message> notificationMessageReceived; // 0x0

	// Methods

	// RVA: 0x3F0BEB0 Offset: 0x3F0BFB1 VA: 0x3F0BEB0
	public static void SetFocusHandlingMode(Notification.FocusHandlingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x48B190 Offset: 0x48B291 VA: 0x48B190
	[NativeConditionalAttribute] // RVA: 0x48B190 Offset: 0x48B291 VA: 0x48B190
	// RVA: 0x3F0BF00 Offset: 0x3F0C001 VA: 0x3F0BF00
	private static void SetFocusHandlingMode_Internal(Notification.FocusHandlingMode mode) { }

	// RVA: 0x3F0BF50 Offset: 0x3F0C051 VA: 0x3F0BF50
	public static Notification.FocusState GetCurrentFocusState() { }

	[NativeConditionalAttribute] // RVA: 0x48B1F0 Offset: 0x48B2F1 VA: 0x48B1F0
	[FreeFunctionAttribute] // RVA: 0x48B1F0 Offset: 0x48B2F1 VA: 0x48B1F0
	// RVA: 0x3F0BF90 Offset: 0x3F0C091 VA: 0x3F0BF90
	private static Notification.FocusState GetCurrentFocusState_Internal() { }

	// RVA: 0x3F0BFD0 Offset: 0x3F0C0D1 VA: 0x3F0BFD0
	public static void SetResumeNotificationEnabled(bool enabled) { }

	[NativeConditionalAttribute] // RVA: 0x48B250 Offset: 0x48B351 VA: 0x48B250
	[FreeFunctionAttribute] // RVA: 0x48B250 Offset: 0x48B351 VA: 0x48B250
	// RVA: 0x3F0C020 Offset: 0x3F0C121 VA: 0x3F0C020
	private static void SetResumeNotificationEnabled_Internal(bool enabled) { }

	// RVA: 0x3F0C070 Offset: 0x3F0C171 VA: 0x3F0C070
	public static void EnterExitRequestHandlingSection() { }

	[NativeConditionalAttribute] // RVA: 0x48B2B0 Offset: 0x48B3B1 VA: 0x48B2B0
	[FreeFunctionAttribute] // RVA: 0x48B2B0 Offset: 0x48B3B1 VA: 0x48B2B0
	// RVA: 0x3F0C0B0 Offset: 0x3F0C1B1 VA: 0x3F0C0B0
	private static void EnterExitRequestHandlingSection_Internal() { }

	// RVA: 0x3F0C0F0 Offset: 0x3F0C1F1 VA: 0x3F0C0F0
	public static void LeaveExitRequestHandlingSection() { }

	[FreeFunctionAttribute] // RVA: 0x48B310 Offset: 0x48B411 VA: 0x48B310
	[NativeConditionalAttribute] // RVA: 0x48B310 Offset: 0x48B411 VA: 0x48B310
	// RVA: 0x3F0C130 Offset: 0x3F0C231 VA: 0x3F0C130
	private static void LeaveExitRequestHandlingSection_Internal() { }

	// RVA: 0x3F0C170 Offset: 0x3F0C271 VA: 0x3F0C170
	public static void SetOperationModeChangedNotificationEnabled(bool enabled) { }

	[FreeFunctionAttribute] // RVA: 0x48B370 Offset: 0x48B471 VA: 0x48B370
	[NativeConditionalAttribute] // RVA: 0x48B370 Offset: 0x48B471 VA: 0x48B370
	// RVA: 0x3F0C1C0 Offset: 0x3F0C2C1 VA: 0x3F0C1C0
	private static void SetOperationModeChangedNotificationEnabled_Internal(bool enabled) { }

	// RVA: 0x3F0C210 Offset: 0x3F0C311 VA: 0x3F0C210
	public static void SetPerformanceModeChangedNotificationEnabled(bool enabled) { }

	[FreeFunctionAttribute] // RVA: 0x48B3D0 Offset: 0x48B4D1 VA: 0x48B3D0
	[NativeConditionalAttribute] // RVA: 0x48B3D0 Offset: 0x48B4D1 VA: 0x48B3D0
	// RVA: 0x3F0C260 Offset: 0x3F0C361 VA: 0x3F0C260
	private static void SetPerformanceModeChangedNotificationEnabled_Internal(bool enabled) { }

	// RVA: 0x3F0C2B0 Offset: 0x3F0C3B1 VA: 0x3F0C2B0
	private static void InvokeNotificationMessage(int message) { }

	[CompilerGeneratedAttribute] // RVA: 0x48B430 Offset: 0x48B531 VA: 0x48B430
	// RVA: 0x3F0C340 Offset: 0x3F0C441 VA: 0x3F0C340
	public static void add_notificationMessageReceived(Action<Notification.Message> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x48B440 Offset: 0x48B541 VA: 0x48B440
	// RVA: 0x3F0C400 Offset: 0x3F0C501 VA: 0x3F0C400
	public static void remove_notificationMessageReceived(Action<Notification.Message> value) { }
}

