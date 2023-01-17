// Namespace: nn.hid
public static class SixAxisSensor // TypeDefIndex: 14667
{
	// Fields
	public const int StateCountMax = 16;
	public const int HandleCountMax = 8;

	// Methods

	// RVA: 0x23434A0 Offset: 0x23435A1 VA: 0x23434A0
	public static extern int GetHandles(SixAxisSensorHandle[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x23434B0 Offset: 0x23435B1 VA: 0x23434B0
	public static extern void Start(SixAxisSensorHandle handle) { }

	// RVA: 0x23434C0 Offset: 0x23435C1 VA: 0x23434C0
	public static extern void Stop(SixAxisSensorHandle handle) { }

	// RVA: 0x23434D0 Offset: 0x23435D1 VA: 0x23434D0
	public static extern bool IsRest(SixAxisSensorHandle handle) { }

	// RVA: 0x23434F0 Offset: 0x23435F1 VA: 0x23434F0
	public static extern void GetState(ref SixAxisSensorState pOutValue, SixAxisSensorHandle handle) { }

	// RVA: 0x2343500 Offset: 0x2343601 VA: 0x2343500
	public static extern int GetStates([Out] SixAxisSensorState[] pOutValues, int count, SixAxisSensorHandle handle) { }

	// RVA: 0x2343630 Offset: 0x2343731 VA: 0x2343630
	public static extern bool IsFusionEnabled(SixAxisSensorHandle handle) { }

	// RVA: 0x2343650 Offset: 0x2343751 VA: 0x2343650
	public static extern void EnableFusion(SixAxisSensorHandle handle, bool enable) { }

	// RVA: 0x2343660 Offset: 0x2343761 VA: 0x2343660
	public static extern void SetFusionParameters(SixAxisSensorHandle handle, float revisePower, float reviseRange) { }

	// RVA: 0x2343670 Offset: 0x2343771 VA: 0x2343670
	public static extern void GetFusionParameters(ref float pOutRevisePower, ref float pOutReviseRange, SixAxisSensorHandle handle) { }

	// RVA: 0x2343680 Offset: 0x2343781 VA: 0x2343680
	public static extern void ResetFusionParameters(SixAxisSensorHandle handle) { }

	// RVA: 0x2343690 Offset: 0x2343791 VA: 0x2343690
	public static extern void SetGyroscopeZeroDriftMode(SixAxisSensorHandle handle, GyroscopeZeroDriftMode mode) { }

	// RVA: 0x23436A0 Offset: 0x23437A1 VA: 0x23436A0
	public static extern GyroscopeZeroDriftMode GetGyroscopeZeroDriftMode(SixAxisSensorHandle handle) { }

	// RVA: 0x23436B0 Offset: 0x23437B1 VA: 0x23436B0
	public static extern bool IsFirmwareUpdateAvailableForSixAxisSensor(SixAxisSensorHandle handle) { }
}

