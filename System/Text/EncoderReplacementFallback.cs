// Namespace: System.Text
[Serializable]
public sealed class EncoderReplacementFallback : EncoderFallback // TypeDefIndex: 455
{
	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x372E440 Offset: 0x372E541 VA: 0x372E440
	public void .ctor() { }

	// RVA: 0x372F4F0 Offset: 0x372F5F1 VA: 0x372F4F0
	public void .ctor(string replacement) { }

	// RVA: 0x372F700 Offset: 0x372F801 VA: 0x372F700
	public string get_DefaultString() { }

	// RVA: 0x372F710 Offset: 0x372F811 VA: 0x372F710 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x372F7F0 Offset: 0x372F8F1 VA: 0x372F7F0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x372F800 Offset: 0x372F901 VA: 0x372F800 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x372F890 Offset: 0x372F991 VA: 0x372F890 Slot: 2
	public override int GetHashCode() { }
}

