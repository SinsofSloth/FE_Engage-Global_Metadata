// Namespace: nn.os
public struct UserExceptionInfoDetail // TypeDefIndex: 14532
{
	// Fields
	public ulong[] r; // 0x0
	public ulong sp; // 0x8
	public ulong pc; // 0x10
	public ulong[] V; // 0x18
	public uint pstate; // 0x20
	public uint afsr0; // 0x24
	public uint afsr1; // 0x28
	public uint esr; // 0x2C
	public ulong far; // 0x30

	// Properties
	public ulong fp { get; }
	public ulong lr { get; }

	// Methods

	// RVA: 0x20AB310 Offset: 0x20AB411 VA: 0x20AB310
	public ulong get_fp() { }

	// RVA: 0x20AB340 Offset: 0x20AB441 VA: 0x20AB340
	public ulong get_lr() { }
}

