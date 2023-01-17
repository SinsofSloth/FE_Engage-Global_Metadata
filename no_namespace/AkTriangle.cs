// Namespace: 
public class AkTriangle : IDisposable // TypeDefIndex: 7905
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ushort point0 { get; set; }
	public ushort point1 { get; set; }
	public ushort point2 { get; set; }
	public ushort surface { get; set; }

	// Methods

	// RVA: 0x20DDEB0 Offset: 0x20DDFB1 VA: 0x20DDEB0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x20DDEF0 Offset: 0x20DDFF1 VA: 0x20DDEF0
	internal static IntPtr getCPtr(AkTriangle obj) { }

	// RVA: 0x20DDF50 Offset: 0x20DE051 VA: 0x20DDF50 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x20DDF80 Offset: 0x20DE081 VA: 0x20DDF80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x20DDFF0 Offset: 0x20DE0F1 VA: 0x20DDFF0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x20DE170 Offset: 0x20DE271 VA: 0x20DE170
	public void .ctor() { }

	// RVA: 0x20DE200 Offset: 0x20DE301 VA: 0x20DE200
	public void .ctor(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo) { }

	// RVA: 0x20D8670 Offset: 0x20D8771 VA: 0x20D8670
	public void set_point0(ushort value) { }

	// RVA: 0x20D8870 Offset: 0x20D8971 VA: 0x20D8870
	public ushort get_point0() { }

	// RVA: 0x20D86F0 Offset: 0x20D87F1 VA: 0x20D86F0
	public void set_point1(ushort value) { }

	// RVA: 0x20D88E0 Offset: 0x20D89E1 VA: 0x20D88E0
	public ushort get_point1() { }

	// RVA: 0x20D8770 Offset: 0x20D8871 VA: 0x20D8770
	public void set_point2(ushort value) { }

	// RVA: 0x20D8950 Offset: 0x20D8A51 VA: 0x20D8950
	public ushort get_point2() { }

	// RVA: 0x20D87F0 Offset: 0x20D88F1 VA: 0x20D87F0
	public void set_surface(ushort value) { }

	// RVA: 0x20DE2C0 Offset: 0x20DE3C1 VA: 0x20DE2C0
	public ushort get_surface() { }

	// RVA: 0x20DE330 Offset: 0x20DE431 VA: 0x20DE330
	public void Clear() { }

	// RVA: 0x20DE3A0 Offset: 0x20DE4A1 VA: 0x20DE3A0
	public static int GetSizeOf() { }

	// RVA: 0x20DE410 Offset: 0x20DE511 VA: 0x20DE410
	public void Clone(AkTriangle other) { }
}

