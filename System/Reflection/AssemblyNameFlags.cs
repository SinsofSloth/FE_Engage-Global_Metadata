// Namespace: System.Reflection
[FlagsAttribute] // RVA: 0x471A50 Offset: 0x471B51 VA: 0x471A50
[ComVisibleAttribute] // RVA: 0x471A50 Offset: 0x471B51 VA: 0x471A50
[Serializable]
public enum AssemblyNameFlags // TypeDefIndex: 515
{
	// Fields
	public int value__; // 0x0
	public const AssemblyNameFlags None = 0;
	public const AssemblyNameFlags PublicKey = 1;
	public const AssemblyNameFlags EnableJITcompileOptimizer = 16384;
	public const AssemblyNameFlags EnableJITcompileTracking = 32768;
	public const AssemblyNameFlags Retargetable = 256;
}

