// Namespace: UnityEngine
[RequireComponent] // RVA: 0x5C980 Offset: 0x5CA81 VA: 0x5C980
[NativeHeaderAttribute] // RVA: 0x5C980 Offset: 0x5CA81 VA: 0x5C980
[RequiredByNativeCodeAttribute] // RVA: 0x5C980 Offset: 0x5CA81 VA: 0x5C980
public class Collider2D : Behaviour // TypeDefIndex: 4053
{
	// Properties
	public Rigidbody2D attachedRigidbody { get; }
	public Bounds bounds { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x5D5C0 Offset: 0x5D6C1 VA: 0x5D5C0
	// RVA: 0x1C5AB70 Offset: 0x1C5AC71 VA: 0x1C5AB70
	public Rigidbody2D get_attachedRigidbody() { }

	// RVA: 0x1C5ABC0 Offset: 0x1C5ACC1 VA: 0x1C5ABC0
	public Bounds get_bounds() { }

	// RVA: 0x1C5AC90 Offset: 0x1C5AD91 VA: 0x1C5AC90
	public bool OverlapPoint(Vector2 point) { }

	// RVA: 0x1C5AC40 Offset: 0x1C5AD41 VA: 0x1C5AC40
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x1C5ACF0 Offset: 0x1C5ADF1 VA: 0x1C5ACF0
	private bool OverlapPoint_Injected(ref Vector2 point) { }
}

// Namespace: UnityEngine
[RequireComponent] // RVA: 0x485890 Offset: 0x485991 VA: 0x485890
[NativeHeaderAttribute] // RVA: 0x485890 Offset: 0x485991 VA: 0x485890
[RequiredByNativeCodeAttribute] // RVA: 0x485890 Offset: 0x485991 VA: 0x485890
public class Collider : Component // TypeDefIndex: 4200
{
	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }
	[NativeMethodAttribute] // RVA: 0x488AA0 Offset: 0x488BA1 VA: 0x488AA0
	public PhysicMaterial sharedMaterial { get; }

	// Methods

	// RVA: 0x3EE1250 Offset: 0x3EE1351 VA: 0x3EE1250
	public bool get_enabled() { }

	// RVA: 0x3EE12A0 Offset: 0x3EE13A1 VA: 0x3EE12A0
	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x486110 Offset: 0x486211 VA: 0x486110
	// RVA: 0x3EE12F0 Offset: 0x3EE13F1 VA: 0x3EE12F0
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x3EE1340 Offset: 0x3EE1441 VA: 0x3EE1340
	public bool get_isTrigger() { }

	// RVA: 0x3EE1390 Offset: 0x3EE1491 VA: 0x3EE1390
	public void set_isTrigger(bool value) { }

	// RVA: 0x3EE13E0 Offset: 0x3EE14E1 VA: 0x3EE13E0
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x3EE14B0 Offset: 0x3EE15B1 VA: 0x3EE14B0
	public Bounds get_bounds() { }

	// RVA: 0x3EE1580 Offset: 0x3EE1681 VA: 0x3EE1580
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x3EE15D0 Offset: 0x3EE16D1 VA: 0x3EE15D0
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x3EE1710 Offset: 0x3EE1811 VA: 0x3EE1710
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0x486150 Offset: 0x486251 VA: 0x486150
	// RVA: 0x3EE17E0 Offset: 0x3EE18E1 VA: 0x3EE17E0
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x3EE18C0 Offset: 0x3EE19C1 VA: 0x3EE18C0
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x3EE0D60 Offset: 0x3EE0E61 VA: 0x3EE0D60
	public void .ctor() { }

	// RVA: 0x3EE1450 Offset: 0x3EE1551 VA: 0x3EE1450
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x3EE1530 Offset: 0x3EE1631 VA: 0x3EE1530
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x3EE1690 Offset: 0x3EE1791 VA: 0x3EE1690
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x3EE1850 Offset: 0x3EE1951 VA: 0x3EE1850
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }
}

