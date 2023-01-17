// Namespace: System
[FlagsAttribute] // RVA: 0x2FC60 Offset: 0x2FD61 VA: 0x2FC60
internal enum UnescapeMode // TypeDefIndex: 2227
{
	// Fields
	public int value__; // 0x0
	public const UnescapeMode CopyOnly = 0;
	public const UnescapeMode Escape = 1;
	public const UnescapeMode Unescape = 2;
	public const UnescapeMode EscapeUnescape = 3;
	public const UnescapeMode V1ToStringFlag = 4;
	public const UnescapeMode UnescapeAll = 8;
	public const UnescapeMode UnescapeAllOrThrow = 24;
}

