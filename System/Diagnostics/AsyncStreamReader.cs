// Namespace: System.Diagnostics
internal class AsyncStreamReader // TypeDefIndex: 2277
{
	// Fields
	private Stream stream; // 0x10
	private Encoding encoding; // 0x18
	private Decoder decoder; // 0x20
	private byte[] byteBuffer; // 0x28
	private char[] charBuffer; // 0x30
	private bool cancelOperation; // 0x38
	private ManualResetEvent eofEvent; // 0x40
	private object syncObject; // 0x48

	// Methods

	// RVA: 0x1B3EAC0 Offset: 0x1B3EBC1 VA: 0x1B3EAC0 Slot: 4
	public virtual void Close() { }

	// RVA: 0x1B3EAD0 Offset: 0x1B3EBD1 VA: 0x1B3EAD0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1B3EC50 Offset: 0x1B3ED51 VA: 0x1B3EC50
	internal void CancelOperation() { }

	// RVA: 0x1B3EC60 Offset: 0x1B3ED61 VA: 0x1B3EC60
	internal void WaitUtilEOF() { }
}

