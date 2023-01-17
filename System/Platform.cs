// Namespace: System
internal static class Platform // TypeDefIndex: 2243
{
	// Fields
	private static bool checkedOS; // 0x0
	private static bool isMacOS; // 0x1
	private static bool isFreeBSD; // 0x2

	// Properties
	public static bool IsMacOS { get; }

	// Methods

	// RVA: 0x1AD48F0 Offset: 0x1AD49F1 VA: 0x1AD48F0
	private static extern int uname(IntPtr buf) { }

	// RVA: 0x1AD4970 Offset: 0x1AD4A71 VA: 0x1AD4970
	private static void CheckOS() { }

	// RVA: 0x1AD4BE0 Offset: 0x1AD4CE1 VA: 0x1AD4BE0
	public static bool get_IsMacOS() { }
}

