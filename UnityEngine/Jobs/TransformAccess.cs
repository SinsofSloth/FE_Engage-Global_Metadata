// Namespace: UnityEngine.Jobs
[NativeHeaderAttribute] // RVA: 0x43F810 Offset: 0x43F911 VA: 0x43F810
public struct TransformAccess // TypeDefIndex: 3678
{
	// Fields
	private IntPtr hierarchy; // 0x0
	private int index; // 0x8

	// Properties
	public Vector3 position { get; }
	public Quaternion rotation { get; }
	public Quaternion localRotation { set; }

	// Methods

	// RVA: 0x384A630 Offset: 0x384A731 VA: 0x384A630
	public Vector3 get_position() { }

	// RVA: 0x384A6E0 Offset: 0x384A7E1 VA: 0x384A6E0
	public Quaternion get_rotation() { }

	// RVA: 0x384A790 Offset: 0x384A891 VA: 0x384A790
	public void set_localRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0x452540 Offset: 0x452641 VA: 0x452540
	// RVA: 0x384A690 Offset: 0x384A791 VA: 0x384A690
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0x4525A0 Offset: 0x4526A1 VA: 0x4525A0
	// RVA: 0x384A740 Offset: 0x384A841 VA: 0x384A740
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0x452600 Offset: 0x452701 VA: 0x452600
	// RVA: 0x384A7F0 Offset: 0x384A8F1 VA: 0x384A7F0
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }
}

