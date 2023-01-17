// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1AF00 Offset: 0x1B001 VA: 0x1AF00
[Serializable]
public struct CinemachineSmoothPath.Waypoint // TypeDefIndex: 5763
{
	// Fields
	[TooltipAttribute] // RVA: 0x1DE50 Offset: 0x1DF51 VA: 0x1DE50
	public Vector3 position; // 0x0
	[TooltipAttribute] // RVA: 0x1DE90 Offset: 0x1DF91 VA: 0x1DE90
	public float roll; // 0xC

	// Properties
	internal Vector4 AsVector4 { get; }

	// Methods

	// RVA: 0x1A8B480 Offset: 0x1A8B581 VA: 0x1A8B480
	internal Vector4 get_AsVector4() { }

	// RVA: 0x1A8B4C0 Offset: 0x1A8B5C1 VA: 0x1A8B4C0
	internal static CinemachineSmoothPath.Waypoint FromVector4(Vector4 v) { }
}

