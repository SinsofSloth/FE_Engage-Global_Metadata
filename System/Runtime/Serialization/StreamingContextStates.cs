// Namespace: System.Runtime.Serialization
[FlagsAttribute] // RVA: 0x474800 Offset: 0x474901 VA: 0x474800
[ComVisibleAttribute] // RVA: 0x474800 Offset: 0x474901 VA: 0x474800
[Serializable]
public enum StreamingContextStates // TypeDefIndex: 1025
{
	// Fields
	public int value__; // 0x0
	public const StreamingContextStates CrossProcess = 1;
	public const StreamingContextStates CrossMachine = 2;
	public const StreamingContextStates File = 4;
	public const StreamingContextStates Persistence = 8;
	public const StreamingContextStates Remoting = 16;
	public const StreamingContextStates Other = 32;
	public const StreamingContextStates Clone = 64;
	public const StreamingContextStates CrossAppDomain = 128;
	public const StreamingContextStates All = 255;
}

