// Namespace: System.Net
internal abstract class WebConnectionStream : Stream // TypeDefIndex: 2588
{
	// Fields
	protected bool closed; // 0x28
	private bool disposed; // 0x29
	private object locker; // 0x30
	private int read_timeout; // 0x38
	private int write_timeout; // 0x3C
	internal bool IgnoreIOErrors; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x31900 Offset: 0x31A01 VA: 0x31900
	private readonly HttpWebRequest <Request>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x31910 Offset: 0x31A11 VA: 0x31910
	private readonly WebConnection <Connection>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x31920 Offset: 0x31A21 VA: 0x31920
	private readonly WebOperation <Operation>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x31930 Offset: 0x31A31 VA: 0x31930
	private readonly Stream <InnerStream>k__BackingField; // 0x60

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebConnection Connection { get; }
	internal WebOperation Operation { get; }
	internal ServicePoint ServicePoint { get; }
	internal Stream InnerStream { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override bool CanSeek { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x19486C0 Offset: 0x19487C1 VA: 0x19486C0
	protected void .ctor(WebConnection cnc, WebOperation operation, Stream stream) { }

	[CompilerGeneratedAttribute] // RVA: 0x32BD0 Offset: 0x32CD1 VA: 0x32BD0
	// RVA: 0x19487E0 Offset: 0x19488E1 VA: 0x19487E0
	internal HttpWebRequest get_Request() { }

	[CompilerGeneratedAttribute] // RVA: 0x32BE0 Offset: 0x32CE1 VA: 0x32BE0
	// RVA: 0x19487F0 Offset: 0x19488F1 VA: 0x19487F0
	internal WebConnection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x32BF0 Offset: 0x32CF1 VA: 0x32BF0
	// RVA: 0x1948800 Offset: 0x1948901 VA: 0x1948800
	internal WebOperation get_Operation() { }

	// RVA: 0x1948810 Offset: 0x1948911 VA: 0x1948810
	internal ServicePoint get_ServicePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x32C00 Offset: 0x32D01 VA: 0x32C00
	// RVA: 0x1948820 Offset: 0x1948921 VA: 0x1948820
	internal Stream get_InnerStream() { }

	// RVA: 0x1948830 Offset: 0x1948931 VA: 0x1948830 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1948840 Offset: 0x1948941 VA: 0x1948840 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1948850 Offset: 0x1948951 VA: 0x1948850 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x19488C0 Offset: 0x19489C1 VA: 0x19488C0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x19488D0 Offset: 0x19489D1 VA: 0x19488D0 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1948940 Offset: 0x1948A41 VA: 0x1948940
	protected Exception GetException(Exception e) { }

	// RVA: 0x1948B60 Offset: 0x1948C61 VA: 0x1948B60 Slot: 29
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1948E90 Offset: 0x1948F91 VA: 0x1948E90 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x19490B0 Offset: 0x19491B1 VA: 0x19490B0 Slot: 22
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x19491E0 Offset: 0x19492E1 VA: 0x19491E0 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1949400 Offset: 0x1949501 VA: 0x1949400 Slot: 25
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x1949500 Offset: 0x1949601 VA: 0x1949500 Slot: 31
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1949740 Offset: 0x1949841 VA: 0x1949740 Slot: 20
	public override void Flush() { }

	// RVA: 0x1949750 Offset: 0x1949851 VA: 0x1949750
	internal void InternalClose() { }

	// RVA: -1 Offset: -1 Slot: 33
	protected abstract void Close_internal(ref bool disposed);

	// RVA: 0x1949760 Offset: 0x1949861 VA: 0x1949760 Slot: 18
	public override void Close() { }

	// RVA: 0x1949780 Offset: 0x1949881 VA: 0x1949780 Slot: 27
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x19497C0 Offset: 0x19498C1 VA: 0x19497C0 Slot: 28
	public override void SetLength(long a) { }

	// RVA: 0x1949800 Offset: 0x1949901 VA: 0x1949800 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1949810 Offset: 0x1949911 VA: 0x1949810 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1949850 Offset: 0x1949951 VA: 0x1949850 Slot: 13
	public override void set_Position(long value) { }
}

