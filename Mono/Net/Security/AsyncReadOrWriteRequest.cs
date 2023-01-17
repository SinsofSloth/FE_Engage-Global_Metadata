// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 2187
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x314E0 Offset: 0x315E1 VA: 0x314E0
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x314F0 Offset: 0x315F1 VA: 0x314F0
	private int <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x31ED0 Offset: 0x31FD1 VA: 0x31ED0
	// RVA: 0x1B3E750 Offset: 0x1B3E851 VA: 0x1B3E750
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x31EE0 Offset: 0x31FE1 VA: 0x31EE0
	// RVA: 0x1B3E760 Offset: 0x1B3E861 VA: 0x1B3E760
	protected int get_CurrentSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x31EF0 Offset: 0x31FF1 VA: 0x31EF0
	// RVA: 0x1B3E770 Offset: 0x1B3E871 VA: 0x1B3E770
	protected void set_CurrentSize(int value) { }

	// RVA: 0x1B3E780 Offset: 0x1B3E881 VA: 0x1B3E780
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x1B3E9A0 Offset: 0x1B3EAA1 VA: 0x1B3E9A0 Slot: 3
	public override string ToString() { }
}

