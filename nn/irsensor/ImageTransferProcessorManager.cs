// Namespace: nn.irsensor
public class ImageTransferProcessorManager // TypeDefIndex: 14595
{
	// Fields
	private ImageTransferProcessorState state; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2A6400 Offset: 0x2A6501 VA: 0x2A6400
	private byte[] <ImageBuffer>k__BackingField; // 0x20
	private IntPtr pWorkBuffer; // 0x28
	private long workBufferSize; // 0x30
	private ImageTransferProcessorExConfig config; // 0x38
	private IrCameraHandle handle; // 0x60

	// Properties
	public ImageTransferProcessorState State { get; }
	public byte[] ImageBuffer { get; set; }

	// Methods

	// RVA: 0x2C45AE0 Offset: 0x2C45BE1 VA: 0x2C45AE0
	public ImageTransferProcessorState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D1120 Offset: 0x2D1221 VA: 0x2D1120
	// RVA: 0x2C45AF0 Offset: 0x2C45BF1 VA: 0x2C45AF0
	public byte[] get_ImageBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D1130 Offset: 0x2D1231 VA: 0x2D1130
	// RVA: 0x2C45B00 Offset: 0x2C45C01 VA: 0x2C45B00
	private void set_ImageBuffer(byte[] value) { }

	// RVA: 0x2C45B10 Offset: 0x2C45C11 VA: 0x2C45B10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2C45C20 Offset: 0x2C45D21 VA: 0x2C45C20
	public void Initialize(IrCameraHandle handle, ImageTransferProcessorFormat format) { }

	// RVA: 0x2C45DD0 Offset: 0x2C45ED1 VA: 0x2C45DD0
	public void Initialize(IrCameraHandle handle, ImageTransferProcessorConfig config) { }

	// RVA: 0x2C45C90 Offset: 0x2C45D91 VA: 0x2C45C90
	public void Initialize(IrCameraHandle handle, ImageTransferProcessorExConfig config) { }

	// RVA: 0x2C45E10 Offset: 0x2C45F11 VA: 0x2C45E10
	public void Destroy() { }

	// RVA: 0x2C45EC0 Offset: 0x2C45FC1 VA: 0x2C45EC0
	public bool IsRunning() { }

	// RVA: 0x2C45EE0 Offset: 0x2C45FE1 VA: 0x2C45EE0
	public void Run() { }

	// RVA: 0x2C45F30 Offset: 0x2C46031 VA: 0x2C45F30
	public Result Update() { }

	// RVA: 0x2C45FD0 Offset: 0x2C460D1 VA: 0x2C45FD0
	public void Stop() { }

	// RVA: 0x2C45BC0 Offset: 0x2C45CC1 VA: 0x2C45BC0
	private void _Destroy() { }

	// RVA: 0x2C46010 Offset: 0x2C46111 VA: 0x2C46010
	public void .ctor() { }
}

