// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472B60 Offset: 0x472C61 VA: 0x472B60
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 644
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public bool EndOfStream { get; }

	// Methods

	// RVA: 0x3833680 Offset: 0x3833781 VA: 0x3833680
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x3833690 Offset: 0x3833791 VA: 0x3833690
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x3833720 Offset: 0x3833821 VA: 0x3833720
	internal void .ctor() { }

	// RVA: 0x3833790 Offset: 0x3833891 VA: 0x3833790
	public void .ctor(Stream stream) { }

	// RVA: 0x3833820 Offset: 0x3833921 VA: 0x3833820
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x3833A80 Offset: 0x3833B81 VA: 0x3833A80
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x3833B10 Offset: 0x3833C11 VA: 0x3833B10
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x38338C0 Offset: 0x38339C1 VA: 0x38338C0
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x3833D20 Offset: 0x3833E21 VA: 0x3833D20
	public void .ctor(string path) { }

	// RVA: 0x3833DB0 Offset: 0x3833EB1 VA: 0x3833DB0
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x3833E60 Offset: 0x3833F61 VA: 0x3833E60
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x3833E50 Offset: 0x3833F51 VA: 0x3833E50
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x3833EF0 Offset: 0x3833FF1 VA: 0x3833EF0
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x3833BA0 Offset: 0x3833CA1 VA: 0x3833BA0
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x3834130 Offset: 0x3834231 VA: 0x3834130
	internal void Init(Stream stream) { }

	// RVA: 0x3834160 Offset: 0x3834261 VA: 0x3834160 Slot: 7
	public override void Close() { }

	// RVA: 0x3834170 Offset: 0x3834271 VA: 0x3834170 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x38342C0 Offset: 0x38343C1 VA: 0x38342C0 Slot: 15
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x38342D0 Offset: 0x38343D1 VA: 0x38342D0 Slot: 16
	public virtual Stream get_BaseStream() { }

	// RVA: 0x38342B0 Offset: 0x38343B1 VA: 0x38342B0
	internal bool get_LeaveOpen() { }

	// RVA: 0x38342E0 Offset: 0x38343E1 VA: 0x38342E0
	public bool get_EndOfStream() { }

	// RVA: 0x3834350 Offset: 0x3834451 VA: 0x3834350 Slot: 9
	public override int Peek() { }

	// RVA: 0x38343F0 Offset: 0x38344F1 VA: 0x38343F0
	internal bool DataAvailable() { }

	// RVA: 0x3834400 Offset: 0x3834501 VA: 0x3834400 Slot: 10
	public override int Read() { }

	// RVA: 0x38344A0 Offset: 0x38345A1 VA: 0x38344A0 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x38348E0 Offset: 0x38349E1 VA: 0x38348E0 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x38349B0 Offset: 0x3834AB1 VA: 0x38349B0 Slot: 13
	public override int ReadBlock([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x3834B40 Offset: 0x3834C41 VA: 0x3834B40
	private void CompressBuffer(int n) { }

	// RVA: 0x3834B90 Offset: 0x3834C91 VA: 0x3834B90
	private void DetectEncoding() { }

	// RVA: 0x3834EC0 Offset: 0x3834FC1 VA: 0x3834EC0
	private bool IsPreamble() { }

	// RVA: 0x3834FE0 Offset: 0x38350E1 VA: 0x3834FE0 Slot: 17
	internal virtual int ReadBuffer() { }

	// RVA: 0x38346E0 Offset: 0x38347E1 VA: 0x38346E0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x3835160 Offset: 0x3835261 VA: 0x3835160 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x3835360 Offset: 0x3835461 VA: 0x3835360
	private static void .cctor() { }
}

