// Namespace: System.Text
public abstract class DecoderFallbackBuffer // TypeDefIndex: 442
{
	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Remaining();

	// RVA: 0x371E580 Offset: 0x371E681 VA: 0x371E580 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x371E5C0 Offset: 0x371E6C1 VA: 0x371E5C0
	internal void InternalReset() { }

	// RVA: 0x371E5D0 Offset: 0x371E6D1 VA: 0x371E5D0
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x371E5E0 Offset: 0x371E6E1 VA: 0x371E5E0 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x371E7B0 Offset: 0x371E8B1 VA: 0x371E7B0 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x371E970 Offset: 0x371EA71 VA: 0x371E970
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x371E260 Offset: 0x371E361 VA: 0x371E260
	protected void .ctor() { }
}

