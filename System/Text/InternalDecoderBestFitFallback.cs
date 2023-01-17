// Namespace: System.Text
[Serializable]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 436
{
	// Fields
	internal Encoding encoding; // 0x18
	internal char[] arrayBestFit; // 0x20
	internal char cReplacement; // 0x28

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x3411870 Offset: 0x3411971 VA: 0x3411870
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x34118C0 Offset: 0x34119C1 VA: 0x34118C0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x3411AE0 Offset: 0x3411BE1 VA: 0x3411AE0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x3411AF0 Offset: 0x3411BF1 VA: 0x3411AF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3411BA0 Offset: 0x3411CA1 VA: 0x3411BA0 Slot: 2
	public override int GetHashCode() { }
}

