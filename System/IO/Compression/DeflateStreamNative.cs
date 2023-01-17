// Namespace: System.IO.Compression
internal class DeflateStreamNative // TypeDefIndex: 2389
{
	// Fields
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x2C
	private byte[] io_buffer; // 0x30

	// Methods

	// RVA: 0x1B55E20 Offset: 0x1B55F21 VA: 0x1B55E20
	private void .ctor() { }

	// RVA: 0x1B548D0 Offset: 0x1B549D1 VA: 0x1B548D0
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x1B55ED0 Offset: 0x1B55FD1 VA: 0x1B55ED0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1B54B40 Offset: 0x1B54C41 VA: 0x1B54B40
	public void Dispose(bool disposing) { }

	// RVA: 0x1B552C0 Offset: 0x1B553C1 VA: 0x1B552C0
	public void Flush() { }

	// RVA: 0x1B54C70 Offset: 0x1B54D71 VA: 0x1B54C70
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1B54F70 Offset: 0x1B55071 VA: 0x1B54F70
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x32250 Offset: 0x32351 VA: 0x32250
	// RVA: 0x1B55CA0 Offset: 0x1B55DA1 VA: 0x1B55CA0
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1B561F0 Offset: 0x1B562F1 VA: 0x1B561F0
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x322C0 Offset: 0x323C1 VA: 0x322C0
	// RVA: 0x1B55D60 Offset: 0x1B55E61 VA: 0x1B55D60
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1B56340 Offset: 0x1B56441 VA: 0x1B56340
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x1B55FF0 Offset: 0x1B560F1 VA: 0x1B55FF0
	private static void CheckResult(int result, string where) { }

	// RVA: 0x1B55E30 Offset: 0x1B55F31 VA: 0x1B55E30
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x1B564C0 Offset: 0x1B565C1 VA: 0x1B564C0
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x1B55F80 Offset: 0x1B56081 VA: 0x1B55F80
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x1B560F0 Offset: 0x1B561F1 VA: 0x1B560F0
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x1B56170 Offset: 0x1B56271 VA: 0x1B56170
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }
}

