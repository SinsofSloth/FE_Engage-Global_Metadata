// Namespace: UnityEngineInternal.Input
[FlagsAttribute] // RVA: 0x7FB30 Offset: 0x7FC31 VA: 0x7FB30
internal enum NativeInputUpdateType // TypeDefIndex: 7524
{
	// Fields
	public int value__; // 0x0
	public const NativeInputUpdateType Dynamic = 1;
	public const NativeInputUpdateType Fixed = 2;
	public const NativeInputUpdateType BeforeRender = 4;
	public const NativeInputUpdateType Editor = 8;
	public const NativeInputUpdateType IgnoreFocus = -2147483648;
}

