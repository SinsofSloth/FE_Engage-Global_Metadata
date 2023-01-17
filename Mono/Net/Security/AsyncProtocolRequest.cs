// Namespace: Mono.Net.Security
internal abstract class AsyncProtocolRequest // TypeDefIndex: 2185
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x314B0 Offset: 0x315B1 VA: 0x314B0
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x314C0 Offset: 0x315C1 VA: 0x314C0
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x314D0 Offset: 0x315D1 VA: 0x314D0
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x31D10 Offset: 0x31E11 VA: 0x31D10
	// RVA: 0x1B3E060 Offset: 0x1B3E161 VA: 0x1B3E060
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0x31D20 Offset: 0x31E21 VA: 0x31D20
	// RVA: 0x1B3E070 Offset: 0x1B3E171 VA: 0x1B3E070
	public bool get_RunSynchronously() { }

	// RVA: 0x1B3E080 Offset: 0x1B3E181 VA: 0x1B3E080
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x31D30 Offset: 0x31E31 VA: 0x31D30
	// RVA: 0x1B3E0A0 Offset: 0x1B3E1A1 VA: 0x1B3E0A0
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x31D40 Offset: 0x31E41 VA: 0x31D40
	// RVA: 0x1B3E0B0 Offset: 0x1B3E1B1 VA: 0x1B3E0B0
	protected void set_UserResult(int value) { }

	// RVA: 0x1B3DFA0 Offset: 0x1B3E0A1 VA: 0x1B3DFA0
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x1B3E0C0 Offset: 0x1B3E1C1 VA: 0x1B3E0C0
	internal void RequestRead(int size) { }

	// RVA: 0x1B3E1A0 Offset: 0x1B3E2A1 VA: 0x1B3E1A0
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0x31D50 Offset: 0x31E51 VA: 0x31D50
	// RVA: 0x1B3E1B0 Offset: 0x1B3E2B1 VA: 0x1B3E1B0
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x31DC0 Offset: 0x31EC1 VA: 0x31DC0
	// RVA: 0x1B3E330 Offset: 0x1B3E431 VA: 0x1B3E330
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x31E30 Offset: 0x31F31 VA: 0x31E30
	// RVA: 0x1B3E4B0 Offset: 0x1B3E5B1 VA: 0x1B3E4B0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

	// RVA: 0x1B3E650 Offset: 0x1B3E751 VA: 0x1B3E650 Slot: 3
	public override string ToString() { }
}

