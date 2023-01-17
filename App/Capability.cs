// Namespace: App
public class Capability : CapabilityBase<byte> // TypeDefIndex: 9829
{
	// Fields
	public const int Min = 0;
	public const int Max = 255;

	// Methods

	// RVA: 0x29A8C80 Offset: 0x29A8D81 VA: 0x29A8C80
	public void .ctor(byte value = 0) { }

	// RVA: 0x29A8CE0 Offset: 0x29A8DE1 VA: 0x29A8CE0 Slot: 5
	public override void Add(int i, byte v) { }

	// RVA: 0x29A8D80 Offset: 0x29A8E81 VA: 0x29A8D80 Slot: 6
	public override bool IsZero() { }

	// RVA: 0x29A8E40 Offset: 0x29A8F41 VA: 0x29A8E40 Slot: 7
	protected override void WriteToStream(Stream stream, byte v) { }

	// RVA: 0x29A8E50 Offset: 0x29A8F51 VA: 0x29A8E50 Slot: 8
	protected override byte ReadFromStream(Stream stream) { }
}

