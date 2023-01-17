// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472980 Offset: 0x472A81 VA: 0x472980
public class BinaryReader : IDisposable // TypeDefIndex: 614
{
	// Fields
	private Stream m_stream; // 0x10
	private byte[] m_buffer; // 0x18
	private Decoder m_decoder; // 0x20
	private byte[] m_charBytes; // 0x28
	private char[] m_singleChar; // 0x30
	private char[] m_charBuffer; // 0x38
	private int m_maxCharsSize; // 0x40
	private bool m_2BytesPerChar; // 0x44
	private bool m_isMemoryStream; // 0x45
	private bool m_leaveOpen; // 0x46

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x35061E0 Offset: 0x35062E1 VA: 0x35061E0
	public void .ctor(Stream input) { }

	// RVA: 0x3506500 Offset: 0x3506601 VA: 0x3506500
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x3506260 Offset: 0x3506361 VA: 0x3506260
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x3506510 Offset: 0x3506611 VA: 0x3506510 Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x3506520 Offset: 0x3506621 VA: 0x3506520 Slot: 6
	public virtual void Close() { }

	// RVA: 0x3506530 Offset: 0x3506631 VA: 0x3506530 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x35065E0 Offset: 0x35066E1 VA: 0x35065E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x35065F0 Offset: 0x35066F1 VA: 0x35065F0 Slot: 8
	public virtual int Read() { }

	// RVA: 0x35068C0 Offset: 0x35069C1 VA: 0x35068C0 Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x3506920 Offset: 0x3506A21 VA: 0x3506920 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliantAttribute] // RVA: 0x47C120 Offset: 0x47C221 VA: 0x47C120
	// RVA: 0x3506990 Offset: 0x3506A91 VA: 0x3506990 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x35069E0 Offset: 0x3506AE1 VA: 0x35069E0 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x3506A30 Offset: 0x3506B31 VA: 0x3506A30 Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliantAttribute] // RVA: 0x47C140 Offset: 0x47C241 VA: 0x47C140
	// RVA: 0x3506A90 Offset: 0x3506B91 VA: 0x3506A90 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x3506AF0 Offset: 0x3506BF1 VA: 0x3506AF0 Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliantAttribute] // RVA: 0x47C160 Offset: 0x47C261 VA: 0x47C160
	// RVA: 0x3506C10 Offset: 0x3506D11 VA: 0x3506C10 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x3506C90 Offset: 0x3506D91 VA: 0x3506C90 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliantAttribute] // RVA: 0x47C180 Offset: 0x47C281 VA: 0x47C180
	// RVA: 0x3506D60 Offset: 0x3506E61 VA: 0x3506D60 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x3506E30 Offset: 0x3506F31 VA: 0x3506E30 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x3506EB0 Offset: 0x3506FB1 VA: 0x3506EB0 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x3506F30 Offset: 0x3507031 VA: 0x3506F30 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x3507090 Offset: 0x3507191 VA: 0x3507090 Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x3507420 Offset: 0x3507521 VA: 0x3507420
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x3506630 Offset: 0x3506731 VA: 0x3506630
	private int InternalReadOneChar() { }

	// RVA: 0x3507750 Offset: 0x3507851 VA: 0x3507750 Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x35078D0 Offset: 0x35079D1 VA: 0x35078D0 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x3507A70 Offset: 0x3507B71 VA: 0x3507A70 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x3507C10 Offset: 0x3507D11 VA: 0x3507C10 Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x3507370 Offset: 0x3507471 VA: 0x3507370
	protected internal int Read7BitEncodedInt() { }
}

