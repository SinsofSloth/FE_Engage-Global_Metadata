// Namespace: nn.irsensor
public struct ClusteringProcessorState // TypeDefIndex: 14567
{
	// Fields
	public long samplingNumber; // 0x0
	public long timeStampNanoSeconds; // 0x8
	public sbyte objectCount; // 0x10
	public byte _reserved0; // 0x11
	public byte _reserved1; // 0x12
	public byte _reserved2; // 0x13
	public IrCameraAmbientNoiseLevel ambientNoiseLevel; // 0x14
	public ClusteringProcessorState.ClusteringDataArray16 objects; // 0x18

	// Methods

	// RVA: 0x22C8300 Offset: 0x22C8401 VA: 0x22C8300
	public void SetDefault() { }

	// RVA: 0x22C8310 Offset: 0x22C8411 VA: 0x22C8310 Slot: 3
	public override string ToString() { }
}

