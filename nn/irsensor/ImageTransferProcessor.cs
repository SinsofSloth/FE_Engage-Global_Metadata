// Namespace: nn.irsensor
public static class ImageTransferProcessor // TypeDefIndex: 14594
{
	// Fields
	public const int QvgaImageSize = 76800;
	public const int QqvgaImageSize = 19200;
	public const int QqqvgaImageSize = 4800;
	public const int ImageSize320x240 = 76800;
	public const int ImageSize160x120 = 19200;
	public const int ImageSize80x60 = 4800;
	public const int ImageSize40x30 = 1200;
	public const int ImageSize20x15 = 300;
	public const int QvgaWorkBufferSize = 155648;
	public const int QqvgaWorkBufferSize = 40960;
	public const int QqqvgaWorkBufferSize = 12288;
	public const int WorkBufferSize320x240 = 155648;
	public const int WorkBufferSize160x120 = 40960;
	public const int WorkBufferSize80x60 = 12288;
	public const int WorkBufferSize40x30 = 4096;
	public const int WorkBufferSize20x15 = 4096;
	public const long ExposureTimeMinNanoSeconds = 7000;
	public const long ExposureTimeMaxNanoSeconds = 600000;

	// Methods

	// RVA: 0x2C458E0 Offset: 0x2C459E1 VA: 0x2C458E0
	public static extern void GetDefaultConfig(ref ImageTransferProcessorConfig pOutValue) { }

	// RVA: 0x2C458F0 Offset: 0x2C459F1 VA: 0x2C458F0
	public static extern void GetDefaultConfig(ref ImageTransferProcessorExConfig pOutValue) { }

	// RVA: 0x2C45900 Offset: 0x2C45A01 VA: 0x2C45900
	public static extern void Run(IrCameraHandle handle, ImageTransferProcessorConfig config, IntPtr workBuffer, long workBufferSize) { }

	// RVA: 0x2C45940 Offset: 0x2C45A41 VA: 0x2C45940
	public static extern void Run(IrCameraHandle handle, ImageTransferProcessorExConfig config, IntPtr workBuffer, long workBufferSize) { }

	// RVA: 0x2C45980 Offset: 0x2C45A81 VA: 0x2C45980
	public static extern Result GetState(ref ImageTransferProcessorState pOutState, IntPtr pOutImage, long size, IrCameraHandle handle) { }

	// RVA: 0x2C459A0 Offset: 0x2C45AA1 VA: 0x2C459A0
	public static extern void InitializeWorkBuffer(ref IntPtr pOutWorkBuffer, ref long pOutWorkBufferSize, ImageTransferProcessorConfig config) { }

	// RVA: 0x2C459D0 Offset: 0x2C45AD1 VA: 0x2C459D0
	public static extern void InitializeWorkBuffer(ref IntPtr pOutWorkBuffer, ref long pOutWorkBufferSize, ImageTransferProcessorExConfig config) { }

	// RVA: 0x2C45A10 Offset: 0x2C45B11 VA: 0x2C45A10
	public static extern void DestroyWorkBuffer(IntPtr workBuffer) { }

	// RVA: 0x2C45A20 Offset: 0x2C45B21 VA: 0x2C45A20
	public static int GetWorkBufferSize(ImageTransferProcessorFormat format) { }

	// RVA: 0x2C45A50 Offset: 0x2C45B51 VA: 0x2C45A50
	public static int GetImageSize(ImageTransferProcessorFormat format) { }

	// RVA: 0x2C45A80 Offset: 0x2C45B81 VA: 0x2C45A80
	public static int GetImageWidth(ImageTransferProcessorFormat format) { }

	// RVA: 0x2C45AB0 Offset: 0x2C45BB1 VA: 0x2C45AB0
	public static int GetImageHeight(ImageTransferProcessorFormat format) { }
}

