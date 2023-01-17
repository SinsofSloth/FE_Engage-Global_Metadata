// Namespace: nn.irsensor
public static class IrCamera // TypeDefIndex: 14591
{
	// Fields
	public const int IntensityMax = 255;
	public const int ImageWidth = 320;
	public const int ImageHeight = 240;
	public const int GainMin = 1;
	public const int GainMax = 16;

	// Methods

	// RVA: 0x2B60060 Offset: 0x2B60161 VA: 0x2B60060
	public static extern IrCameraHandle GetHandle(NpadId npadId) { }

	// RVA: 0x2B60080 Offset: 0x2B60181 VA: 0x2B60080
	public static extern void Initialize(IrCameraHandle handle) { }

	// RVA: 0x2B60090 Offset: 0x2B60191 VA: 0x2B60090
	public static extern void Finalize(IrCameraHandle handle) { }

	// RVA: 0x2B600A0 Offset: 0x2B601A1 VA: 0x2B600A0
	public static extern IrCameraStatus GetStatus(IrCameraHandle handle) { }

	// RVA: 0x2B600B0 Offset: 0x2B601B1 VA: 0x2B600B0
	public static extern Result CheckFirmwareUpdateNecessity(ref bool pOutIsUpdateNeeded, IrCameraHandle handle) { }
}

