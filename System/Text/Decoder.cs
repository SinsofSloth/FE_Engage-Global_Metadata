// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x471390 Offset: 0x471491 VA: 0x471390
[Serializable]
public abstract class Decoder // TypeDefIndex: 435
{
	// Fields
	internal DecoderFallback m_fallback; // 0x10
	internal DecoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DCB0 Offset: 0x47DDB1 VA: 0x47DCB0
	public DecoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x47DCD0 Offset: 0x47DDD1 VA: 0x47DCD0
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x371D130 Offset: 0x371D231 VA: 0x371D130
	internal void SerializeDecoder(SerializationInfo info) { }

	// RVA: 0x371D190 Offset: 0x371D291 VA: 0x371D190
	protected void .ctor() { }

	// RVA: 0x371D1A0 Offset: 0x371D2A1 VA: 0x371D1A0
	public DecoderFallback get_Fallback() { }

	// RVA: 0x371D1B0 Offset: 0x371D2B1 VA: 0x371D1B0
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x371D430 Offset: 0x371D531 VA: 0x371D430
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x47B400 Offset: 0x47B501 VA: 0x47B400
	// RVA: 0x371D440 Offset: 0x371D541 VA: 0x371D440 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisibleAttribute] // RVA: 0x47B420 Offset: 0x47B521 VA: 0x47B420
	// RVA: 0x371D530 Offset: 0x371D631 VA: 0x371D530 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x47B440 Offset: 0x47B541 VA: 0x47B440
	[CLSCompliantAttribute] // RVA: 0x47B440 Offset: 0x47B541 VA: 0x47B440
	// RVA: 0x371D540 Offset: 0x371D641 VA: 0x371D540 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x371D6B0 Offset: 0x371D7B1 VA: 0x371D6B0 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliantAttribute] // RVA: 0x47B480 Offset: 0x47B581 VA: 0x47B480
	[ComVisibleAttribute] // RVA: 0x47B480 Offset: 0x47B581 VA: 0x47B480
	// RVA: 0x371D6C0 Offset: 0x371D7C1 VA: 0x371D6C0 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x47B4C0 Offset: 0x47B5C1 VA: 0x47B4C0
	// RVA: 0x371D8F0 Offset: 0x371D9F1 VA: 0x371D8F0 Slot: 11
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliantAttribute] // RVA: 0x47B4E0 Offset: 0x47B5E1 VA: 0x47B4E0
	[ComVisibleAttribute] // RVA: 0x47B4E0 Offset: 0x47B5E1 VA: 0x47B4E0
	// RVA: 0x371DC20 Offset: 0x371DD21 VA: 0x371DC20 Slot: 12
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

