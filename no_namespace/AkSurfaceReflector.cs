// Namespace: 
[AddComponentMenu] // RVA: 0x272CC0 Offset: 0x272DC1 VA: 0x272CC0
[ExecuteInEditMode] // RVA: 0x272CC0 Offset: 0x272DC1 VA: 0x272CC0
public class AkSurfaceReflector : MonoBehaviour // TypeDefIndex: 8050
{
	// Fields
	[TooltipAttribute] // RVA: 0x27F340 Offset: 0x27F441 VA: 0x27F340
	public Mesh Mesh; // 0x18
	[TooltipAttribute] // RVA: 0x27F380 Offset: 0x27F481 VA: 0x27F380
	public AcousticTexture[] AcousticTextures; // 0x20
	[RangeAttribute] // RVA: 0x27F3C0 Offset: 0x27F4C1 VA: 0x27F3C0
	[TooltipAttribute] // RVA: 0x27F3C0 Offset: 0x27F4C1 VA: 0x27F3C0
	public float[] OcclusionValues; // 0x28
	[TooltipAttribute] // RVA: 0x27F420 Offset: 0x27F521 VA: 0x27F420
	public bool EnableDiffraction; // 0x30
	[TooltipAttribute] // RVA: 0x27F460 Offset: 0x27F561 VA: 0x27F460
	public bool EnableDiffractionOnBoundaryEdges; // 0x31
	[TooltipAttribute] // RVA: 0x27F4A0 Offset: 0x27F5A1 VA: 0x27F4A0
	public AkRoom AssociatedRoom; // 0x38
	[SerializeField] // RVA: 0x27F4E0 Offset: 0x27F5E1 VA: 0x27F4E0
	[FormerlySerializedAsAttribute] // RVA: 0x27F4E0 Offset: 0x27F5E1 VA: 0x27F4E0
	[HideInInspector] // RVA: 0x27F4E0 Offset: 0x27F5E1 VA: 0x27F4E0
	private AcousticTexture AcousticTextureInternal; // 0x40

	// Properties
	[ObsoleteAttribute] // RVA: 0x2D4AC0 Offset: 0x2D4BC1 VA: 0x2D4AC0
	public AcousticTexture AcousticTexture { get; set; }

	// Methods

	// RVA: 0x20D71F0 Offset: 0x20D72F1 VA: 0x20D71F0
	private ulong GetID() { }

	// RVA: 0x20D7210 Offset: 0x20D7311 VA: 0x20D7210
	private static void SetGeometryFromMesh(Mesh mesh, AcousticTexture[] acousticTextures, float[] occlusionValues, Transform transform, ulong geometryID, ulong associatedRoomID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges, string name = "") { }

	// RVA: 0x20D89C0 Offset: 0x20D8AC1 VA: 0x20D89C0
	public void SetAssociatedRoom(AkRoom room) { }

	// RVA: 0x20D8B10 Offset: 0x20D8C11 VA: 0x20D8B10
	public void SetGeometry() { }

	// RVA: 0x20D8AE0 Offset: 0x20D8BE1 VA: 0x20D8AE0
	public void UpdateGeometry() { }

	// RVA: 0x20D8E10 Offset: 0x20D8F11 VA: 0x20D8E10
	public void RemoveGeometry() { }

	[ObsoleteAttribute] // RVA: 0x2A7500 Offset: 0x2A7601 VA: 0x2A7500
	// RVA: 0x20D8ED0 Offset: 0x20D8FD1 VA: 0x20D8ED0
	public static void RemoveGeometrySet(MeshFilter meshFilter) { }

	// RVA: 0x20D9000 Offset: 0x20D9101 VA: 0x20D9000
	private void Awake() { }

	// RVA: 0x20D9100 Offset: 0x20D9201 VA: 0x20D9100
	private void OnEnable() { }

	// RVA: 0x20D91A0 Offset: 0x20D92A1 VA: 0x20D91A0
	private void OnDisable() { }

	[ObsoleteAttribute] // RVA: 0x2A7540 Offset: 0x2A7641 VA: 0x2A7540
	// RVA: 0x20D8FE0 Offset: 0x20D90E1 VA: 0x20D8FE0
	public static ulong GetAkGeometrySetID(MeshFilter meshFilter) { }

	[ObsoleteAttribute] // RVA: 0x2A7580 Offset: 0x2A7681 VA: 0x2A7580
	// RVA: 0x20D91D0 Offset: 0x20D92D1 VA: 0x20D91D0
	public static void AddGeometrySet(AcousticTexture acousticTexture, MeshFilter meshFilter, ulong roomID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges) { }

	// RVA: 0x20D9500 Offset: 0x20D9601 VA: 0x20D9500
	public AcousticTexture get_AcousticTexture() { }

	// RVA: 0x20D9530 Offset: 0x20D9631 VA: 0x20D9530
	public void set_AcousticTexture(AcousticTexture value) { }

	// RVA: 0x20D9760 Offset: 0x20D9861 VA: 0x20D9760
	public void .ctor() { }
}

