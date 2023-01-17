// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x4713B0 Offset: 0x4714B1 VA: 0x4713B0
[Serializable]
public abstract class Encoder // TypeDefIndex: 446
{
	// Fields
	internal EncoderFallback m_fallback; // 0x10
	internal EncoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DCF0 Offset: 0x47DDF1 VA: 0x47DCF0
	public EncoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x47DD10 Offset: 0x47DE11 VA: 0x47DD10
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x372D2E0 Offset: 0x372D3E1 VA: 0x372D2E0
	internal void SerializeEncoder(SerializationInfo info) { }

	// RVA: 0x372D340 Offset: 0x372D441 VA: 0x372D340
	protected void .ctor() { }

	// RVA: 0x372D350 Offset: 0x372D451 VA: 0x372D350
	public EncoderFallback get_Fallback() { }

	// RVA: 0x372D360 Offset: 0x372D461 VA: 0x372D360
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x372D5E0 Offset: 0x372D6E1 VA: 0x372D5E0
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x47B520 Offset: 0x47B621 VA: 0x47B520
	// RVA: 0x372D5F0 Offset: 0x372D6F1 VA: 0x372D5F0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliantAttribute] // RVA: 0x47B540 Offset: 0x47B641 VA: 0x47B540
	[ComVisibleAttribute] // RVA: 0x47B540 Offset: 0x47B641 VA: 0x47B540
	// RVA: 0x372D6E0 Offset: 0x372D7E1 VA: 0x372D6E0 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliantAttribute] // RVA: 0x47B580 Offset: 0x47B681 VA: 0x47B580
	[ComVisibleAttribute] // RVA: 0x47B580 Offset: 0x47B681 VA: 0x47B580
	// RVA: 0x372D860 Offset: 0x372D961 VA: 0x372D860 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }
}

