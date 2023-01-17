// Namespace: nn.hid
public static class Vibration // TypeDefIndex: 14723
{
	// Methods

	// RVA: 0x26C1FA0 Offset: 0x26C20A1 VA: 0x26C1FA0
	public static extern int GetDeviceHandles(VibrationDeviceHandle[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26C1FB0 Offset: 0x26C20B1 VA: 0x26C1FB0
	public static extern void GetDeviceInfo(ref VibrationDeviceInfo pOutValue, VibrationDeviceHandle handle) { }

	// RVA: 0x26C1FC0 Offset: 0x26C20C1 VA: 0x26C1FC0
	public static extern void InitializeDevice(VibrationDeviceHandle handle) { }

	// RVA: 0x26C1FD0 Offset: 0x26C20D1 VA: 0x26C1FD0
	public static extern void SendValue(VibrationDeviceHandle handle, VibrationValue value) { }

	// RVA: 0x26C1FE0 Offset: 0x26C20E1 VA: 0x26C1FE0
	public static extern void GetActualValue(ref VibrationValue pOutValue, VibrationDeviceHandle handle) { }

	// RVA: 0x26C1FF0 Offset: 0x26C20F1 VA: 0x26C1FF0
	public static extern bool IsPermitted() { }
}

