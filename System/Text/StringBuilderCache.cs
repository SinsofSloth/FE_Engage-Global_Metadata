// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 466
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x478290 Offset: 0x478391 VA: 0x478290
	private static StringBuilder CachedInstance; // 0x80000000

	// Methods

	// RVA: 0x3659A90 Offset: 0x3659B91 VA: 0x3659A90
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x3659BB0 Offset: 0x3659CB1 VA: 0x3659BB0
	public static void Release(StringBuilder sb) { }

	// RVA: 0x3659C30 Offset: 0x3659D31 VA: 0x3659C30
	public static string GetStringAndRelease(StringBuilder sb) { }
}

