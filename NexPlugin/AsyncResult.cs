// Namespace: NexPlugin
public class AsyncResult // TypeDefIndex: 14859
{
	// Fields
	public uint asyncId; // 0x10
	public AsyncResultNum asyncNum; // 0x14
	public Result nnResult; // 0x18
	public uint netErrCode; // 0x1C
	public int returnCode; // 0x20
	public uint errorCode; // 0x24

	// Methods

	// RVA: 0x260F0C0 Offset: 0x260F1C1 VA: 0x260F0C0
	public bool IsSuccess() { }

	// RVA: 0x260F110 Offset: 0x260F211 VA: 0x260F110
	public bool IsFailure() { }

	// RVA: 0x260F160 Offset: 0x260F261 VA: 0x260F160
	public void Trace() { }

	// RVA: 0x260F170 Offset: 0x260F271 VA: 0x260F170 Slot: 3
	public override string ToString() { }

	// RVA: 0x260F430 Offset: 0x260F531 VA: 0x260F430
	public void .ctor() { }
}

