// Namespace: Mono.Net
internal class CFNumber : CFObject // TypeDefIndex: 2163
{
	// Methods

	// RVA: 0x1B45B50 Offset: 0x1B45C51 VA: 0x1B45B50
	private static extern bool CFNumberGetValue(IntPtr handle, IntPtr type, out int value) { }

	// RVA: 0x1B45BF0 Offset: 0x1B45CF1 VA: 0x1B45BF0
	public static int AsInt32(IntPtr handle) { }
}

