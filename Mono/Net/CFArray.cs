// Namespace: Mono.Net
[DefaultMemberAttribute] // RVA: 0x2FA70 Offset: 0x2FB71 VA: 0x2FA70
internal class CFArray : CFObject // TypeDefIndex: 2162
{
	// Fields
	private static readonly IntPtr kCFTypeArrayCallbacks; // 0x0

	// Properties
	public int Count { get; }
	public IntPtr Item { get; }

	// Methods

	// RVA: 0x1B428E0 Offset: 0x1B429E1 VA: 0x1B428E0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1B42A20 Offset: 0x1B42B21 VA: 0x1B42A20
	private static void .cctor() { }

	// RVA: 0x1B42E60 Offset: 0x1B42F61 VA: 0x1B42E60
	private static extern IntPtr CFArrayGetCount(IntPtr handle) { }

	// RVA: 0x1B42EE0 Offset: 0x1B42FE1 VA: 0x1B42EE0
	public int get_Count() { }

	// RVA: 0x1B42FC0 Offset: 0x1B430C1 VA: 0x1B42FC0
	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index) { }

	// RVA: 0x1B43050 Offset: 0x1B43151 VA: 0x1B43050
	public IntPtr get_Item(int index) { }
}

