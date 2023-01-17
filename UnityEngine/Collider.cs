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

