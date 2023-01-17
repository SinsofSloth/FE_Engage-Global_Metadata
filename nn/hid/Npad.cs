// Namespace: nn.hid
public static class Npad // TypeDefIndex: 14642
{
	// Fields
	public const int StateCountMax = 16;

	// Properties
	public static ErrorRange ResultColorNotAvailable { get; }
	public static ErrorRange ResultControllerNotConnected { get; }

	// Methods

	// RVA: 0x235EF10 Offset: 0x235F011 VA: 0x235EF10
	public static extern void Initialize() { }

	// RVA: 0x235EF20 Offset: 0x235F021 VA: 0x235EF20
	public static extern void SetSupportedStyleSet(NpadStyle npadStyle) { }

	// RVA: 0x235EF30 Offset: 0x235F031 VA: 0x235EF30
	public static extern NpadStyle GetSupportedStyleSet() { }

	// RVA: 0x235EF40 Offset: 0x235F041 VA: 0x235EF40
	public static extern void SetSupportedIdType(NpadId[] npadIds, long count) { }

	// RVA: 0x235EF50 Offset: 0x235F051 VA: 0x235EF50
	public static void SetSupportedIdType(NpadId[] npadIds) { }

	// RVA: 0x235EF70 Offset: 0x235F071 VA: 0x235EF70
	public static extern void BindStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x235EF80 Offset: 0x235F081 VA: 0x235EF80
	public static extern bool IsStyleSetUpdated(NpadId npadId) { }

	// RVA: 0x235EFA0 Offset: 0x235F0A1 VA: 0x235EFA0
	public static extern void DestroyStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x235EFB0 Offset: 0x235F0B1 VA: 0x235EFB0
	public static extern NpadStyle GetStyleSet(NpadId npadId) { }

	// RVA: 0x235EFC0 Offset: 0x235F0C1 VA: 0x235EFC0
	public static extern void Disconnect(NpadId npadId) { }

	// RVA: 0x235EFD0 Offset: 0x235F0D1 VA: 0x235EFD0
	public static extern byte GetPlayerLedPattern(NpadId npadId) { }

	// RVA: 0x235EFE0 Offset: 0x235F0E1 VA: 0x235EFE0
	public static extern Result GetControllerColor(ref NpadControllerColor pOutValue, NpadId npadId) { }

	// RVA: 0x235F000 Offset: 0x235F101 VA: 0x235F000
	public static extern Result GetControllerColor(ref NpadControllerColor pOutLeftColor, ref NpadControllerColor pOutRightColor, NpadId npadId) { }

	// RVA: 0x235F020 Offset: 0x235F121 VA: 0x235F020
	public static void GetState(ref NpadState pOutValue, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x235F120 Offset: 0x235F221 VA: 0x235F120
	public static int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x235FBC0 Offset: 0x235FCC1 VA: 0x235FBC0
	public static ErrorRange get_ResultColorNotAvailable() { }

	// RVA: 0x235FC00 Offset: 0x235FD01 VA: 0x235FC00
	public static ErrorRange get_ResultControllerNotConnected() { }
}

