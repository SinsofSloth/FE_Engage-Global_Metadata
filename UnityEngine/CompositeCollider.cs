// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x5CA70 Offset: 0x5CB71 VA: 0x5CA70
[RequireComponent] // RVA: 0x5CA70 Offset: 0x5CB71 VA: 0x5CA70
public sealed class CompositeCollider2D : Collider2D // TypeDefIndex: 4055
{
	// Properties
	public int pathCount { get; }
	public int pointCount { get; }

	// Methods

	// RVA: 0x1C5B0E0 Offset: 0x1C5B1E1 VA: 0x1C5B0E0
	public int get_pathCount() { }

	// RVA: 0x1C5B130 Offset: 0x1C5B231 VA: 0x1C5B130
	public int get_pointCount() { }

	// RVA: 0x1C5B180 Offset: 0x1C5B281 VA: 0x1C5B180
	public int GetPath(int index, Vector2[] points) { }

	[NativeMethodAttribute] // RVA: 0x5D680 Offset: 0x5D781 VA: 0x5D680
	// RVA: 0x1C5B310 Offset: 0x1C5B411 VA: 0x1C5B310
	private int GetPathArray_Internal(int index, Vector2[] points) { }
}

