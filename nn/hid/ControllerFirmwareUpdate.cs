// Namespace: nn.hid
public static class ControllerFirmwareUpdate // TypeDefIndex: 14624
{
	// Properties
	public static ErrorRange ResultControllerFirmwareUpdateError { get; }
	public static ErrorRange ResultControllerFirmwareUpdateFailed { get; }

	// Methods

	// RVA: 0x23B9530 Offset: 0x23B9631 VA: 0x23B9530
	public static extern Result Show(ControllerFirmwareUpdateArg showControllerFirmwareUpdateArg) { }

	// RVA: 0x23B9550 Offset: 0x23B9651 VA: 0x23B9550
	public static Result Show(ControllerFirmwareUpdateArg showControllerFirmwareUpdateArg, bool suspendUnityThreads) { }

	// RVA: 0x23B95B0 Offset: 0x23B96B1 VA: 0x23B95B0
	public static ErrorRange get_ResultControllerFirmwareUpdateError() { }

	// RVA: 0x23B95F0 Offset: 0x23B96F1 VA: 0x23B95F0
	public static ErrorRange get_ResultControllerFirmwareUpdateFailed() { }
}

