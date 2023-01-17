// Namespace: Mono.Net
internal class CFString : CFObject // TypeDefIndex: 2166
{
	// Fields
	private string str; // 0x18

	// Methods

	// RVA: 0x1B47BF0 Offset: 0x1B47CF1 VA: 0x1B47BF0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1B47C90 Offset: 0x1B47D91 VA: 0x1B47C90
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length) { }

	// RVA: 0x1B44D70 Offset: 0x1B44E71 VA: 0x1B44D70
	public static CFString Create(string value) { }

	// RVA: 0x1B47D30 Offset: 0x1B47E31 VA: 0x1B47D30
	private static extern IntPtr CFStringGetLength(IntPtr handle) { }

	// RVA: 0x1B47DB0 Offset: 0x1B47EB1 VA: 0x1B47DB0
	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle) { }

	// RVA: 0x1B47E30 Offset: 0x1B47F31 VA: 0x1B47E30
	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer) { }

	// RVA: 0x1B46C00 Offset: 0x1B46D01 VA: 0x1B46C00
	public static string AsString(IntPtr handle) { }

	// RVA: 0x1B47EE0 Offset: 0x1B47FE1 VA: 0x1B47EE0 Slot: 3
	public override string ToString() { }
}

