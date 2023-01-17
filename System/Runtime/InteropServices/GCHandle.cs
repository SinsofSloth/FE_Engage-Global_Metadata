// Namespace: System.Runtime.InteropServices
[ComVisibleAttribute] // RVA: 0x476160 Offset: 0x476261 VA: 0x476160
[MonoTODOAttribute] // RVA: 0x476160 Offset: 0x476261 VA: 0x476160
public struct GCHandle // TypeDefIndex: 1313
{
	// Fields
	private int handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x38B6D00 Offset: 0x38B6E01 VA: 0x38B6D00
	private void .ctor(IntPtr h) { }

	// RVA: 0x38B6D30 Offset: 0x38B6E31 VA: 0x38B6D30
	private void .ctor(object obj) { }

	// RVA: 0x38B6D60 Offset: 0x38B6E61 VA: 0x38B6D60
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x38B6DB0 Offset: 0x38B6EB1 VA: 0x38B6DB0
	public bool get_IsAllocated() { }

	// RVA: 0x38B6DC0 Offset: 0x38B6EC1 VA: 0x38B6DC0
	public object get_Target() { }

	// RVA: 0x38B6E40 Offset: 0x38B6F41 VA: 0x38B6E40
	public void set_Target(object value) { }

	// RVA: 0x38B6E80 Offset: 0x38B6F81 VA: 0x38B6E80
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0x38B6F80 Offset: 0x38B7081 VA: 0x38B6F80
	public static GCHandle Alloc(object value) { }

	// RVA: 0x38B6FA0 Offset: 0x38B70A1 VA: 0x38B6FA0
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x38B6FD0 Offset: 0x38B70D1 VA: 0x38B6FD0
	public void Free() { }

	// RVA: 0x38B7070 Offset: 0x38B7171 VA: 0x38B7070
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0x38B7080 Offset: 0x38B7181 VA: 0x38B7080
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0x38B7170 Offset: 0x38B7271 VA: 0x38B7170
	private static bool CheckCurrentDomain(int handle) { }

	// RVA: 0x38B6E30 Offset: 0x38B6F31 VA: 0x38B6E30
	private static object GetTarget(int handle) { }

	// RVA: 0x38B6DA0 Offset: 0x38B6EA1 VA: 0x38B6DA0
	private static int GetTargetHandle(object obj, int handle, GCHandleType type) { }

	// RVA: 0x38B7060 Offset: 0x38B7161 VA: 0x38B7060
	private static void FreeHandle(int handle) { }

	// RVA: 0x38B6F70 Offset: 0x38B7071 VA: 0x38B6F70
	private static IntPtr GetAddrOfPinnedObject(int handle) { }

	// RVA: 0x38B7180 Offset: 0x38B7281 VA: 0x38B7180
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x38B7190 Offset: 0x38B7291 VA: 0x38B7190 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x38B7220 Offset: 0x38B7321 VA: 0x38B7220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x38B7230 Offset: 0x38B7331 VA: 0x38B7230
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0x38B7250 Offset: 0x38B7351 VA: 0x38B7250
	public static IntPtr ToIntPtr(GCHandle value) { }
}

