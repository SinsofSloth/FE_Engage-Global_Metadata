// Namespace: 
[FlagsAttribute] // RVA: 0x2792F0 Offset: 0x2793F1 VA: 0x2792F0
private enum ProcInst.State // TypeDefIndex: 13904
{
	// Fields
	public int value__; // 0x0
	public const ProcInst.State Dead = 1;
	public const ProcInst.State ParentBind = 2;
	public const ProcInst.State Executed = 4;
	public const ProcInst.State Continue = 8;
	public const ProcInst.State Yield = 16;
}

