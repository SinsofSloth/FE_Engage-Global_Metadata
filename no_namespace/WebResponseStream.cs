// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31180 Offset: 0x31281 VA: 0x31180
private sealed class WebResponseStream.<>c__DisplayClass48_0 // TypeDefIndex: 2606
{
	// Fields
	public WebResponseStream <>4__this; // 0x10
	public byte[] buffer; // 0x18
	public int offset; // 0x20
	public int size; // 0x24

	// Methods

	// RVA: 0x192C160 Offset: 0x192C261 VA: 0x192C160
	public void .ctor() { }

	// RVA: 0x192C170 Offset: 0x192C271 VA: 0x192C170
	internal Task<ValueTuple<int, int>> <ReadAsync>b__0(CancellationToken ct) { }

	// RVA: 0x192C190 Offset: 0x192C291 VA: 0x192C190
	internal void <ReadAsync>b__1() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x311A0 Offset: 0x312A1 VA: 0x311A0
private struct WebResponseStream.<ProcessRead>d__49 : IAsyncStateMachine // TypeDefIndex: 2608
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<ValueTuple<int, int>> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public WebResponseStream <>4__this; // 0x28
	public int size; // 0x30
	public byte[] buffer; // 0x38
	public int offset; // 0x40
	private int <oldBytes>5__1; // 0x44
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1C13300 Offset: 0x1C13401 VA: 0x1C13300 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x33840 Offset: 0x33941 VA: 0x33840
	// RVA: 0x1C13720 Offset: 0x1C13821 VA: 0x1C13720 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x311C0 Offset: 0x312C1 VA: 0x311C0
private struct WebResponseStream.<EnsureReadAsync>d__51 : IAsyncStateMachine // TypeDefIndex: 2610
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public WebResponseStream <>4__this; // 0x20
	private byte[] <morebytes>5__1; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private int <nbytes>5__2; // 0x38
	public byte[] buffer; // 0x40
	public int offset; // 0x48
	public int size; // 0x4C
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x50

	// Methods

	// RVA: 0x192C1D0 Offset: 0x192C2D1 VA: 0x192C1D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x33860 Offset: 0x33961 VA: 0x33860
	// RVA: 0x192C510 Offset: 0x192C611 VA: 0x192C510 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x311E0 Offset: 0x312E1 VA: 0x311E0
private struct WebResponseStream.<ReadAllAsync>d__57 : IAsyncStateMachine // TypeDefIndex: 2612
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebResponseStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private WebCompletionSource <completion>5__1; // 0x30
	private Task <timeoutTask>5__2; // 0x38
	public bool resending; // 0x40
	private MemoryStream <ms>5__3; // 0x48
	private BufferOffsetSize <buffer>5__4; // 0x50
	private int <read>5__5; // 0x58
	private byte[] <b>5__6; // 0x60
	private int <remaining>5__7; // 0x68
	private int <readSize>5__8; // 0x6C
	private int <new_size>5__9; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x78
	private TaskAwaiter<int> <>u__2; // 0x88

	// Methods

	// RVA: 0x1C13780 Offset: 0x1C13881 VA: 0x1C13780 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x33880 Offset: 0x33981 VA: 0x33880
	// RVA: 0x1C14370 Offset: 0x1C14471 VA: 0x1C14370 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

