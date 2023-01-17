// Namespace: System.Text
[Serializable]
internal class InternalEncoderBestFitFallback : EncoderFallback // TypeDefIndex: 447
{
	// Fields
	internal Encoding encoding; // 0x18
	internal char[] arrayBestFit; // 0x20

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x3411E90 Offset: 0x3411F91 VA: 0x3411E90
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x3411ED0 Offset: 0x3411FD1 VA: 0x3411ED0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x34120F0 Offset: 0x34121F1 VA: 0x34120F0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x3412100 Offset: 0x3412201 VA: 0x3412100 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x34121D0 Offset: 0x34122D1 VA: 0x34121D0 Slot: 2
	public override int GetHashCode() { }
}

