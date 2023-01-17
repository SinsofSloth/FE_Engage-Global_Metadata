// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x5CA30 Offset: 0x5CB31 VA: 0x5CA30
public sealed class PolygonCollider2D : Collider2D // TypeDefIndex: 4054
{
	// Properties
	public int pathCount { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x5D600 Offset: 0x5D701 VA: 0x5D600
	// RVA: 0x1C5D3A0 Offset: 0x1C5D4A1 VA: 0x1C5D3A0
	public int GetTotalPointCount() { }

	// RVA: 0x1C5D3F0 Offset: 0x1C5D4F1 VA: 0x1C5D3F0
	public int get_pathCount() { }

	// RVA: 0x1C5D440 Offset: 0x1C5D541 VA: 0x1C5D440
	public Vector2[] GetPath(int index) { }

	[NativeMethodAttribute] // RVA: 0x5D640 Offset: 0x5D741 VA: 0x5D640
	// RVA: 0x1C5D560 Offset: 0x1C5D661 VA: 0x1C5D560
	private Vector2[] GetPath_Internal(int index) { }
}

