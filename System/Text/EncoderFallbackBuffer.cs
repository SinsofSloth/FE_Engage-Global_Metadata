// Namespace: System.Text
public abstract class EncoderFallbackBuffer // TypeDefIndex: 453
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining();

	// RVA: 0x372E690 Offset: 0x372E791 VA: 0x372E690 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x372E6D0 Offset: 0x372E7D1 VA: 0x372E6D0
	internal void InternalReset() { }

	// RVA: 0x372E6F0 Offset: 0x372E7F1 VA: 0x372E6F0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x372E740 Offset: 0x372E841 VA: 0x372E740
	internal char InternalGetNextChar() { }

	// RVA: 0x372E790 Offset: 0x372E891 VA: 0x372E790 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x372E980 Offset: 0x372EA81 VA: 0x372E980
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x372DBB0 Offset: 0x372DCB1 VA: 0x372DBB0
	protected void .ctor() { }
}

