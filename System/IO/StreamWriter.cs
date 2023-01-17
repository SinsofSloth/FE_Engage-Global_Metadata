// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472B80 Offset: 0x472C81 VA: 0x472B80
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 645
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	internal bool LeaveOpen { get; }
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x38353E0 Offset: 0x38354E1 VA: 0x38353E0
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0x47C320 Offset: 0x47C421 VA: 0x47C320
	// RVA: 0x3835470 Offset: 0x3835571 VA: 0x3835470
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x3835590 Offset: 0x3835691 VA: 0x3835590
	internal void .ctor() { }

	// RVA: 0x3835600 Offset: 0x3835701 VA: 0x3835600
	public void .ctor(Stream stream) { }

	// RVA: 0x3835830 Offset: 0x3835931 VA: 0x3835830
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x3835680 Offset: 0x3835781 VA: 0x3835680
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x38359B0 Offset: 0x3835AB1 VA: 0x38359B0
	public void .ctor(string path) { }

	// RVA: 0x3835A50 Offset: 0x3835B51 VA: 0x3835A50
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x3835A40 Offset: 0x3835B41 VA: 0x3835A40
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x3835A60 Offset: 0x3835B61 VA: 0x3835A60
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x3835840 Offset: 0x3835941 VA: 0x3835840
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x3835C70 Offset: 0x3835D71 VA: 0x3835C70
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x3835D70 Offset: 0x3835E71 VA: 0x3835D70 Slot: 8
	public override void Close() { }

	// RVA: 0x3835DF0 Offset: 0x3835EF1 VA: 0x3835DF0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3836100 Offset: 0x3836201 VA: 0x3836100 Slot: 10
	public override void Flush() { }

	// RVA: 0x3835FB0 Offset: 0x38360B1 VA: 0x3835FB0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x3836130 Offset: 0x3836231 VA: 0x3836130 Slot: 22
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x3835FA0 Offset: 0x38360A1 VA: 0x3835FA0
	internal bool get_LeaveOpen() { }

	// RVA: 0x3836190 Offset: 0x3836291 VA: 0x3836190 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x38361A0 Offset: 0x38362A1 VA: 0x38361A0 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x3836240 Offset: 0x3836341 VA: 0x3836240 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x3836320 Offset: 0x3836421 VA: 0x3836320 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x3836540 Offset: 0x3836641 VA: 0x3836540 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x38367D0 Offset: 0x38368D1 VA: 0x38367D0
	private static void .cctor() { }
}

