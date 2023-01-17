// Namespace: nn.irsensor
public static class ClusteringProcessor // TypeDefIndex: 14562
{
	// Fields
	public const int StateCountMax = 5;
	public const int ObjectCountMax = 16;
	public const int ObjectPixelCountMax = 76800;
	public const int OutObjectPixelCountMax = 65535;
	public const long ExposureTimeMinNanoSeconds = 7000;
	public const long ExposureTimeMaxNanoSeconds = 600000;

	// Methods

	// RVA: 0x22C7ED0 Offset: 0x22C7FD1 VA: 0x22C7ED0
	public static extern void GetDefaultConfig(ref ClusteringProcessorConfig pOutValue) { }

	// RVA: 0x22C7EE0 Offset: 0x22C7FE1 VA: 0x22C7EE0
	public static extern void Run(IrCameraHandle handle, ClusteringProcessorConfig config) { }

	// RVA: 0x22C7F20 Offset: 0x22C8021 VA: 0x22C7F20
	public static extern Result GetState(ref ClusteringProcessorState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x22C7F40 Offset: 0x22C8041 VA: 0x22C7F40
	public static extern Result GetStates([Out] ClusteringProcessorState[] pOutStates, ref int pOutCount, int countMax, IrCameraHandle handle) { }
}

