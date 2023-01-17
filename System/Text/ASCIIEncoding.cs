// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x471370 Offset: 0x471471 VA: 0x471370
[Serializable]
public class ASCIIEncoding : Encoding // TypeDefIndex: 434
{
	// Methods

	// RVA: 0x3554DE0 Offset: 0x3554EE1 VA: 0x3554DE0
	public void .ctor() { }

	// RVA: 0x3554DF0 Offset: 0x3554EF1 VA: 0x3554DF0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x3554E40 Offset: 0x3554F41 VA: 0x3554E40 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x3555040 Offset: 0x3555141 VA: 0x3555040 Slot: 11
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0x47B2C0 Offset: 0x47B3C1 VA: 0x47B2C0
	[CLSCompliantAttribute] // RVA: 0x47B2C0 Offset: 0x47B3C1 VA: 0x47B2C0
	// RVA: 0x35550D0 Offset: 0x35551D1 VA: 0x35550D0 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x35551B0 Offset: 0x35552B1 VA: 0x35551B0 Slot: 18
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x3555430 Offset: 0x3555531 VA: 0x3555430 Slot: 16
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0x47B300 Offset: 0x47B401 VA: 0x47B300
	[CLSCompliantAttribute] // RVA: 0x47B300 Offset: 0x47B401 VA: 0x47B300
	// RVA: 0x35556D0 Offset: 0x35557D1 VA: 0x35556D0 Slot: 20
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x35557E0 Offset: 0x35558E1 VA: 0x35557E0 Slot: 21
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x47B340 Offset: 0x47B441 VA: 0x47B340
	[CLSCompliantAttribute] // RVA: 0x47B340 Offset: 0x47B441 VA: 0x47B340
	// RVA: 0x3555980 Offset: 0x3555A81 VA: 0x3555980 Slot: 22
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x3555A60 Offset: 0x3555B61 VA: 0x3555A60 Slot: 25
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x47B380 Offset: 0x47B481 VA: 0x47B380
	[ComVisibleAttribute] // RVA: 0x47B380 Offset: 0x47B481 VA: 0x47B380
	// RVA: 0x3555D00 Offset: 0x3555E01 VA: 0x3555D00 Slot: 26
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x3555E10 Offset: 0x3555F11 VA: 0x3555E10 Slot: 34
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x3555FF0 Offset: 0x35560F1 VA: 0x3555FF0 Slot: 14
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x35563D0 Offset: 0x35564D1 VA: 0x35563D0 Slot: 19
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x3556950 Offset: 0x3556A51 VA: 0x3556950 Slot: 23
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x3556B10 Offset: 0x3556C11 VA: 0x3556B10 Slot: 27
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x3556E60 Offset: 0x3556F61 VA: 0x3556E60 Slot: 31
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x3556F40 Offset: 0x3557041 VA: 0x3556F40 Slot: 32
	public override int GetMaxCharCount(int byteCount) { }

	[ComVisibleAttribute] // RVA: 0x47B3C0 Offset: 0x47B4C1 VA: 0x47B3C0
	// RVA: 0x3557010 Offset: 0x3557111 VA: 0x3557010 Slot: 29
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] // RVA: 0x47B3E0 Offset: 0x47B4E1 VA: 0x47B3E0
	// RVA: 0x3557080 Offset: 0x3557181 VA: 0x3557080 Slot: 30
	public override Encoder GetEncoder() { }
}

