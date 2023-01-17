// Namespace: Mono.Net
[DefaultMemberAttribute] // RVA: 0x2FAB0 Offset: 0x2FBB1 VA: 0x2FAB0
internal class CFDictionary : CFObject // TypeDefIndex: 2167
{
	// Fields
	private static readonly IntPtr KeyCallbacks; // 0x0
	private static readonly IntPtr ValueCallbacks; // 0x8

	// Properties
	public IntPtr Item { get; }

	// Methods

	// RVA: 0x1B43140 Offset: 0x1B43241 VA: 0x1B43140
	private static void .cctor() { }

	// RVA: 0x1B43440 Offset: 0x1B43541 VA: 0x1B43440
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1B434E0 Offset: 0x1B435E1 VA: 0x1B434E0
	private static extern IntPtr CFDictionaryGetValue(IntPtr handle, IntPtr key) { }

	// RVA: 0x1B43570 Offset: 0x1B43671 VA: 0x1B43570
	public IntPtr GetValue(IntPtr key) { }

	// RVA: 0x1B43650 Offset: 0x1B43751 VA: 0x1B43650
	public IntPtr get_Item(IntPtr key) { }
}

