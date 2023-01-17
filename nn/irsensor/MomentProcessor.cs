// Namespace: nn.irsensor
public static class MomentProcessor // TypeDefIndex: 14605
{
	// Fields
	public const int StateCountMax = 5;
	public const int BlockColumnCount = 8;
	public const int BlockRowCount = 6;
	public const int BlockCount = 48;

	// Methods

	// RVA: 0x2279F10 Offset: 0x227A011 VA: 0x2279F10
	public static extern void GetDefaultConfig(ref MomentProcessorConfig pOutValue) { }

	// RVA: 0x2279F20 Offset: 0x227A021 VA: 0x2279F20
	public static extern void Run(IrCameraHandle handle, MomentProcessorConfig config) { }

	// RVA: 0x2279F60 Offset: 0x227A061 VA: 0x2279F60
	public static extern Result GetState(ref MomentProcessorState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x2279F80 Offset: 0x227A081 VA: 0x2279F80
	public static Result GetStatus(MomentProcessorState[] pOutStates, ref int pOutCount, IrCameraHandle handle) { }

	// RVA: 0x2279FB0 Offset: 0x227A0B1 VA: 0x2279FB0
	private static extern Result GetStates([In] [Out] MomentProcessorState[] pOutStates, ref int pOutCount, int countMax, IrCameraHandle handle) { }

	// RVA: 0x2279FE0 Offset: 0x227A0E1 VA: 0x2279FE0
	public static extern MomentStatistic CalculateMomentRegionStatistic(ref MomentProcessorState pState, Rect windowOfInterest, int startRow, int startColumn, int rowCount, int columnCount) { }
}

