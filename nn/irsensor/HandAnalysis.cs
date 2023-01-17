// Namespace: nn.irsensor
public static class HandAnalysis // TypeDefIndex: 14568
{
	// Fields
	public const int ProcessorStateCountMax = 5;
	public const int ShapePointCountMax = 512;
	public const int ShapeCountMax = 16;
	public const int ProtrusionCountMax = 8;
	public const int HandCountMax = 2;
	public const int ImageWidth = 40;
	public const int ImageHeight = 30;

	// Methods

	// RVA: 0x2DB9F60 Offset: 0x2DBA061 VA: 0x2DB9F60
	public static extern Result Run(IrCameraHandle handle, HandAnalysisConfig config) { }

	// RVA: 0x2DB9F80 Offset: 0x2DBA081 VA: 0x2DB9F80
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x2DB9FA0 Offset: 0x2DBA0A1 VA: 0x2DB9FA0
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x2DB9FE0 Offset: 0x2DBA0E1 VA: 0x2DB9FE0
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x2DBA010 Offset: 0x2DBA111 VA: 0x2DBA010
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutState, [In] [Out] Float2[] pOutPointBuffer, IrCameraHandle handle) { }

	// RVA: 0x2DBA040 Offset: 0x2DBA141 VA: 0x2DBA040
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutStateArray, Float2[][] pOutPointArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x2DBA050 Offset: 0x2DBA151 VA: 0x2DBA050
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutStateArray, [In] [Out] Float2[][] pOutPointArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x2DBA070 Offset: 0x2DBA171 VA: 0x2DBA070
	public static extern Result GetImageState(ref HandAnalysisImageState pOutState, [In] [Out] ushort[] pOutImageBuffer, IrCameraHandle handle) { }

	// RVA: 0x2DBA0A0 Offset: 0x2DBA1A1 VA: 0x2DBA0A0
	public static Result GetImageState(HandAnalysisImageState[] pOutStateArray, ushort[] pOutImageArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x2DBA0E0 Offset: 0x2DBA1E1 VA: 0x2DBA0E0
	private static extern Result GetImageState([In] [Out] HandAnalysisImageState[] pOutStateArray, [In] [Out] ushort[] pOutImageArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }
}

