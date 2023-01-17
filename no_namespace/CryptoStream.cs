// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x473DE0 Offset: 0x473EE1 VA: 0x473DE0
private struct CryptoStream.<ReadAsyncInternal>d__34 : IAsyncStateMachine // TypeDefIndex: 913
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public int count; // 0x28
	public int offset; // 0x2C
	public byte[] buffer; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private byte[] <tempInputBuffer>5__1; // 0x40
	private int <currentOutputIndex>5__2; // 0x48
	private int <bytesToDeliver>5__3; // 0x4C
	private SemaphoreSlim <sem>5__4; // 0x50
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60
	private int <>7__wrap1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__3; // 0x78

	// Methods

	// RVA: 0x35E6F50 Offset: 0x35E7051 VA: 0x35E6F50 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x47D060 Offset: 0x47D161 VA: 0x47D060
	// RVA: 0x35E7A50 Offset: 0x35E7B51 VA: 0x35E7A50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

