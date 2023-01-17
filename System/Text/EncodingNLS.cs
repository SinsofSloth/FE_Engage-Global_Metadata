// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x4713F0 Offset: 0x4714F1 VA: 0x4713F0
[Serializable]
internal abstract class EncodingNLS : Encoding // TypeDefIndex: 462
{
	// Methods

	// RVA: 0x3733BF0 Offset: 0x3733CF1 VA: 0x3733BF0
	protected void .ctor(int codePage) { }

	// RVA: 0x3733C00 Offset: 0x3733D01 VA: 0x3733C00 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x3733DA0 Offset: 0x3733EA1 VA: 0x3733DA0 Slot: 11
	public override int GetByteCount(string s) { }

	// RVA: 0x3733E30 Offset: 0x3733F31 VA: 0x3733E30 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x3733F20 Offset: 0x3734021 VA: 0x3733F20 Slot: 18
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x37341B0 Offset: 0x37342B1 VA: 0x37341B0 Slot: 16
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x3734460 Offset: 0x3734561 VA: 0x3734460 Slot: 20
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x3734580 Offset: 0x3734681 VA: 0x3734580 Slot: 21
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x3734720 Offset: 0x3734821 VA: 0x3734720 Slot: 22
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x3734810 Offset: 0x3734911 VA: 0x3734810 Slot: 25
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x3734AC0 Offset: 0x3734BC1 VA: 0x3734AC0 Slot: 26
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x3734BE0 Offset: 0x3734CE1 VA: 0x3734BE0 Slot: 34
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x3734DD0 Offset: 0x3734ED1 VA: 0x3734DD0 Slot: 29
	public override Decoder GetDecoder() { }

	// RVA: 0x3734E70 Offset: 0x3734F71 VA: 0x3734E70 Slot: 30
	public override Encoder GetEncoder() { }
}

