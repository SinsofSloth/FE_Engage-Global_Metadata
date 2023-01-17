// Namespace: System.Net
internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 2523
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1ADD950 Offset: 0x1ADDA51 VA: 0x1ADD950
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1ADE640 Offset: 0x1ADE741 VA: 0x1ADE640
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x1ADEF70 Offset: 0x1ADF071 VA: 0x1ADEF70 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1ADEFF0 Offset: 0x1ADF0F1 VA: 0x1ADEFF0 Slot: 34
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1ADF030 Offset: 0x1ADF131 VA: 0x1ADF030 Slot: 29
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1ADF190 Offset: 0x1ADF291 VA: 0x1ADF190 Slot: 31
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1ADF270 Offset: 0x1ADF371 VA: 0x1ADF270 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1ADF370 Offset: 0x1ADF471 VA: 0x1ADF370 Slot: 22
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1ADF430 Offset: 0x1ADF531 VA: 0x1ADF430 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1ADF530 Offset: 0x1ADF631 VA: 0x1ADF530 Slot: 25
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x1ADF110 Offset: 0x1ADF211 VA: 0x1ADF110
	private void CheckError() { }
}

