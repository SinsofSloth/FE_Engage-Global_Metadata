// Namespace: UnityEngine
[FlagsAttribute] // RVA: 0x43D000 Offset: 0x43D101 VA: 0x43D000
public enum ComputeBufferType // TypeDefIndex: 3473
{
	// Fields
	public int value__; // 0x0
	public const ComputeBufferType Default = 0;
	public const ComputeBufferType Raw = 1;
	public const ComputeBufferType Append = 2;
	public const ComputeBufferType Counter = 4;
	public const ComputeBufferType Constant = 8;
	public const ComputeBufferType Structured = 16;
	[ObsoleteAttribute] // RVA: 0x4429D0 Offset: 0x442AD1 VA: 0x4429D0
	public const ComputeBufferType DrawIndirect = 256;
	public const ComputeBufferType IndirectArguments = 256;
	[ObsoleteAttribute] // RVA: 0x442A10 Offset: 0x442B11 VA: 0x442A10
	public const ComputeBufferType GPUMemory = 512;
}

