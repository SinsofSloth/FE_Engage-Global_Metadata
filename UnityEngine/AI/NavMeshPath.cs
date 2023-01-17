// Namespace: UnityEngine.AI
[MovedFromAttribute] // RVA: 0x70B50 Offset: 0x70C51 VA: 0x70B50
[NativeHeaderAttribute] // RVA: 0x70B50 Offset: 0x70C51 VA: 0x70B50
public sealed class NavMeshPath // TypeDefIndex: 7501
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal Vector3[] m_Corners; // 0x18

	// Properties
	public Vector3[] corners { get; }
	public NavMeshPathStatus status { get; }

	// Methods

	// RVA: 0x1C6B3B0 Offset: 0x1C6B4B1 VA: 0x1C6B3B0
	public void .ctor() { }

	// RVA: 0x1C6B440 Offset: 0x1C6B541 VA: 0x1C6B440 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x70D70 Offset: 0x70E71 VA: 0x70D70
	// RVA: 0x1C6B400 Offset: 0x1C6B501 VA: 0x1C6B400
	private static IntPtr InitializeNavMeshPath() { }

	[FreeFunctionAttribute] // RVA: 0x70DB0 Offset: 0x70EB1 VA: 0x70DB0
	// RVA: 0x1C6B500 Offset: 0x1C6B601 VA: 0x1C6B500
	private static void DestroyNavMeshPath(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0x70E00 Offset: 0x70F01 VA: 0x70E00
	// RVA: 0x1C6B550 Offset: 0x1C6B651 VA: 0x1C6B550
	private Vector3[] CalculateCornersInternal() { }

	[FreeFunctionAttribute] // RVA: 0x70E50 Offset: 0x70F51 VA: 0x70E50
	// RVA: 0x1C6B5A0 Offset: 0x1C6B6A1 VA: 0x1C6B5A0
	private void ClearCornersInternal() { }

	// RVA: 0x1C6A910 Offset: 0x1C6AA11 VA: 0x1C6A910
	public void ClearCorners() { }

	// RVA: 0x1C6B5F0 Offset: 0x1C6B6F1 VA: 0x1C6B5F0
	private void CalculateCorners() { }

	// RVA: 0x1C6B670 Offset: 0x1C6B771 VA: 0x1C6B670
	public Vector3[] get_corners() { }

	// RVA: 0x1C6B6F0 Offset: 0x1C6B7F1 VA: 0x1C6B6F0
	public NavMeshPathStatus get_status() { }
}

