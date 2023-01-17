// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472D00 Offset: 0x472E01 VA: 0x472D00
[FlagsAttribute] // RVA: 0x472D00 Offset: 0x472E01 VA: 0x472D00
[Serializable]
public enum FileOptions // TypeDefIndex: 662
{
	// Fields
	public int value__; // 0x0
	public const FileOptions None = 0;
	public const FileOptions Encrypted = 16384;
	public const FileOptions DeleteOnClose = 67108864;
	public const FileOptions SequentialScan = 134217728;
	public const FileOptions RandomAccess = 268435456;
	public const FileOptions Asynchronous = 1073741824;
	public const FileOptions WriteThrough = -2147483648;
}

