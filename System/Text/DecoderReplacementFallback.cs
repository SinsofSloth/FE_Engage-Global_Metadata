// Namespace: System.Text
[Serializable]
public sealed class DecoderReplacementFallback : DecoderFallback // TypeDefIndex: 444
{
	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x371E330 Offset: 0x371E431 VA: 0x371E330
	public void .ctor() { }

	// RVA: 0x371FB20 Offset: 0x371FC21 VA: 0x371FB20
	public void .ctor(string replacement) { }

	// RVA: 0x371FD30 Offset: 0x371FE31 VA: 0x371FD30
	public string get_DefaultString() { }

	// RVA: 0x371FD40 Offset: 0x371FE41 VA: 0x371FD40 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x371FE00 Offset: 0x371FF01 VA: 0x371FE00 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x371FE10 Offset: 0x371FF11 VA: 0x371FE10 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x371FEA0 Offset: 0x371FFA1 VA: 0x371FEA0 Slot: 2
	public override int GetHashCode() { }
}

