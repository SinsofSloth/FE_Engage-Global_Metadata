// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2212
{
	// Fields
	internal static SafeProcessHandle InvalidHandle; // 0x0

	// Methods

	// RVA: 0x2D03DC0 Offset: 0x2D03EC1 VA: 0x2D03DC0
	internal void .ctor(IntPtr handle) { }

	// RVA: 0x2D03DF0 Offset: 0x2D03EF1 VA: 0x2D03DF0
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x2D03E20 Offset: 0x2D03F21 VA: 0x2D03E20 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x2D03E30 Offset: 0x2D03F31 VA: 0x2D03E30
	private static void .cctor() { }
}

