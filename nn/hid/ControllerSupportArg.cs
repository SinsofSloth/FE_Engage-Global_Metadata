// Namespace: nn.hid
public struct ControllerSupportArg // TypeDefIndex: 14619
{
	// Fields
	private const int ExplainTextSize = 1032;
	public byte playerCountMin; // 0x0
	public byte playerCountMax; // 0x1
	public bool enableTakeOverConnection; // 0x2
	public bool enableLeftJustify; // 0x3
	public bool enablePermitJoyDual; // 0x4
	public bool enableSingleMode; // 0x5
	public bool enableIdentificationColor; // 0x6
	public ControllerSupportArg.Color4u8Array8 identificationColor; // 0x7
	public bool enableExplainText; // 0x27
	private byte[] explainText; // 0x28

	// Methods

	// RVA: 0x23BA450 Offset: 0x23BA551 VA: 0x23BA450
	public void SetDefault() { }

	// RVA: 0x23BA4F0 Offset: 0x23BA5F1 VA: 0x23BA4F0 Slot: 3
	public override string ToString() { }
}

