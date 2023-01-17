// Namespace: Mono.Net
internal class CFObject : IDisposable // TypeDefIndex: 2161
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x31480 Offset: 0x31581 VA: 0x31480
	private IntPtr <Handle>k__BackingField; // 0x10

	// Properties
	public IntPtr Handle { get; set; }

	// Methods

	// RVA: 0x1B42C80 Offset: 0x1B42D81 VA: 0x1B42C80
	public static extern IntPtr dlopen(string path, int mode) { }

	// RVA: 0x1B45CD0 Offset: 0x1B45DD1 VA: 0x1B45CD0
	private static extern IntPtr dlsym(IntPtr handle, string symbol) { }

	// RVA: 0x1B42DE0 Offset: 0x1B42EE1 VA: 0x1B42DE0
	public static extern void dlclose(IntPtr handle) { }

	// RVA: 0x1B42D30 Offset: 0x1B42E31 VA: 0x1B42D30
	public static IntPtr GetIndirect(IntPtr handle, string symbol) { }

	// RVA: 0x1B45D80 Offset: 0x1B45E81 VA: 0x1B45D80
	public static IntPtr GetCFObjectHandle(IntPtr handle, string symbol) { }

	// RVA: 0x1B42980 Offset: 0x1B42A81 VA: 0x1B42980
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1B45F20 Offset: 0x1B46021 VA: 0x1B45F20 Slot: 1
	protected override void Finalize() { }

	[CompilerGeneratedAttribute] // RVA: 0x31CD0 Offset: 0x31DD1 VA: 0x31CD0
	// RVA: 0x1B45FA0 Offset: 0x1B460A1 VA: 0x1B45FA0 Slot: 5
	public IntPtr get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x31CE0 Offset: 0x31DE1 VA: 0x31CE0
	// RVA: 0x1B45FB0 Offset: 0x1B460B1 VA: 0x1B45FB0
	private void set_Handle(IntPtr value) { }

	// RVA: 0x1B45FC0 Offset: 0x1B460C1 VA: 0x1B45FC0
	internal static extern IntPtr CFRetain(IntPtr handle) { }

	// RVA: 0x1B45EA0 Offset: 0x1B45FA1 VA: 0x1B45EA0
	private void Retain() { }

	// RVA: 0x1B46040 Offset: 0x1B46141 VA: 0x1B46040
	internal static extern void CFRelease(IntPtr handle) { }

	// RVA: 0x1B460C0 Offset: 0x1B461C1 VA: 0x1B460C0
	private void Release() { }

	// RVA: 0x1B46140 Offset: 0x1B46241 VA: 0x1B46140 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1B44560 Offset: 0x1B44661 VA: 0x1B44560 Slot: 4
	public void Dispose() { }
}

