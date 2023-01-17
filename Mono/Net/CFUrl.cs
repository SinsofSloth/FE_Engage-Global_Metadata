// Namespace: Mono.Net
internal class CFUrl : CFObject // TypeDefIndex: 2168
{
	// Methods

	// RVA: 0x1B47F30 Offset: 0x1B48031 VA: 0x1B47F30
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1B47FD0 Offset: 0x1B480D1 VA: 0x1B47FD0
	private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL) { }

	// RVA: 0x1B447A0 Offset: 0x1B448A1 VA: 0x1B447A0
	public static CFUrl Create(string absolute) { }
}

