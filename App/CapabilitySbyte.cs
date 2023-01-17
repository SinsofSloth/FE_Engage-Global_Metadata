// Namespace: App
public class CapabilitySbyte : CapabilityBase<sbyte> // TypeDefIndex: 9830
{
	// Fields
	public const int Min = -120;
	public const int Max = 120;

	// Methods

	// RVA: 0x29A9F10 Offset: 0x29AA011 VA: 0x29A9F10
	public void .ctor(sbyte value = 0) { }

	// RVA: 0x29A9F70 Offset: 0x29AA071 VA: 0x29A9F70 Slot: 5
	public override void Add(int i, sbyte v) { }

	// RVA: 0x29AA010 Offset: 0x29AA111 VA: 0x29AA010 Slot: 6
	public override bool IsZero() { }

	// RVA: 0x29AA0D0 Offset: 0x29AA1D1 VA: 0x29AA0D0 Slot: 7
	protected override void WriteToStream(Stream stream, sbyte v) { }

	// RVA: 0x29AA0E0 Offset: 0x29AA1E1 VA: 0x29AA0E0 Slot: 8
	protected override sbyte ReadFromStream(Stream stream) { }
}

