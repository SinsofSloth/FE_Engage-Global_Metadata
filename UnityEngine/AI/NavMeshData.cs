// Namespace: UnityEngine.AI
[NativeHeaderAttribute] // RVA: 0x70C80 Offset: 0x70D81 VA: 0x70C80
public sealed class NavMeshData : Object // TypeDefIndex: 7504
{
	// Properties
	public Bounds sourceBounds { get; }
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }

	// Methods

	// RVA: 0x1C6AE80 Offset: 0x1C6AF81 VA: 0x1C6AE80
	public void .ctor() { }

	// RVA: 0x1C6AF70 Offset: 0x1C6B071 VA: 0x1C6AF70
	public void .ctor(int agentTypeID) { }

	[StaticAccessorAttribute] // RVA: 0x70EF0 Offset: 0x70FF1 VA: 0x70EF0
	// RVA: 0x1C6AF20 Offset: 0x1C6B021 VA: 0x1C6AF20
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	// RVA: 0x1C6B010 Offset: 0x1C6B111 VA: 0x1C6B010
	public Bounds get_sourceBounds() { }

	// RVA: 0x1C6B0E0 Offset: 0x1C6B1E1 VA: 0x1C6B0E0
	public Vector3 get_position() { }

	// RVA: 0x1C6B190 Offset: 0x1C6B291 VA: 0x1C6B190
	public void set_position(Vector3 value) { }

	// RVA: 0x1C6B240 Offset: 0x1C6B341 VA: 0x1C6B240
	public Quaternion get_rotation() { }

	// RVA: 0x1C6B2F0 Offset: 0x1C6B3F1 VA: 0x1C6B2F0
	public void set_rotation(Quaternion value) { }

	// RVA: 0x1C6B090 Offset: 0x1C6B191 VA: 0x1C6B090
	private void get_sourceBounds_Injected(out Bounds ret) { }

	// RVA: 0x1C6B140 Offset: 0x1C6B241 VA: 0x1C6B140
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x1C6B1F0 Offset: 0x1C6B2F1 VA: 0x1C6B1F0
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x1C6B2A0 Offset: 0x1C6B3A1 VA: 0x1C6B2A0
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x1C6B350 Offset: 0x1C6B451 VA: 0x1C6B350
	private void set_rotation_Injected(ref Quaternion value) { }
}

