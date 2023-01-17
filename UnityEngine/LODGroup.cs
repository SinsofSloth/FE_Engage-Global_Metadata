// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D140 Offset: 0x43D241 VA: 0x43D140
[StaticAccessorAttribute] // RVA: 0x43D140 Offset: 0x43D241 VA: 0x43D140
[NativeHeaderAttribute] // RVA: 0x43D140 Offset: 0x43D241 VA: 0x43D140
[NativeHeaderAttribute] // RVA: 0x43D140 Offset: 0x43D241 VA: 0x43D140
public class LODGroup : Component // TypeDefIndex: 3508
{
	// Properties
	public Vector3 localReferencePoint { get; set; }
	public float size { get; set; }
	public int lodCount { get; }
	public LODFadeMode fadeMode { get; set; }
	public bool animateCrossFading { get; set; }
	public bool enabled { get; set; }
	[StaticAccessorAttribute] // RVA: 0x459E80 Offset: 0x459F81 VA: 0x459E80
	public static float crossFadeAnimationDuration { get; set; }
	internal Vector3 worldReferencePoint { get; }

	// Methods

	// RVA: 0x2F26D90 Offset: 0x2F26E91 VA: 0x2F26D90
	public Vector3 get_localReferencePoint() { }

	// RVA: 0x2F26E40 Offset: 0x2F26F41 VA: 0x2F26E40
	public void set_localReferencePoint(Vector3 value) { }

	// RVA: 0x2F26EF0 Offset: 0x2F26FF1 VA: 0x2F26EF0
	public float get_size() { }

	// RVA: 0x2F26F40 Offset: 0x2F27041 VA: 0x2F26F40
	public void set_size(float value) { }

	[NativeMethodAttribute] // RVA: 0x44A6F0 Offset: 0x44A7F1 VA: 0x44A6F0
	// RVA: 0x2F26F90 Offset: 0x2F27091 VA: 0x2F26F90
	public int get_lodCount() { }

	// RVA: 0x2F26FE0 Offset: 0x2F270E1 VA: 0x2F26FE0
	public LODFadeMode get_fadeMode() { }

	// RVA: 0x2F27030 Offset: 0x2F27131 VA: 0x2F27030
	public void set_fadeMode(LODFadeMode value) { }

	// RVA: 0x2F27080 Offset: 0x2F27181 VA: 0x2F27080
	public bool get_animateCrossFading() { }

	// RVA: 0x2F270D0 Offset: 0x2F271D1 VA: 0x2F270D0
	public void set_animateCrossFading(bool value) { }

	// RVA: 0x2F27120 Offset: 0x2F27221 VA: 0x2F27120
	public bool get_enabled() { }

	// RVA: 0x2F27170 Offset: 0x2F27271 VA: 0x2F27170
	public void set_enabled(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x44A730 Offset: 0x44A831 VA: 0x44A730
	// RVA: 0x2F271C0 Offset: 0x2F272C1 VA: 0x2F271C0
	public void RecalculateBounds() { }

	[FreeFunctionAttribute] // RVA: 0x44A780 Offset: 0x44A881 VA: 0x44A780
	// RVA: 0x2F27210 Offset: 0x2F27311 VA: 0x2F27210
	public LOD[] GetLODs() { }

	[ObsoleteAttribute] // RVA: 0x44A7D0 Offset: 0x44A8D1 VA: 0x44A7D0
	// RVA: 0x2F27260 Offset: 0x2F27361 VA: 0x2F27260
	public void SetLODS(LOD[] lods) { }

	[FreeFunctionAttribute] // RVA: 0x44A810 Offset: 0x44A911 VA: 0x44A810
	// RVA: 0x2F272B0 Offset: 0x2F273B1 VA: 0x2F272B0
	public void SetLODs(LOD[] lods) { }

	[FreeFunctionAttribute] // RVA: 0x44A860 Offset: 0x44A961 VA: 0x44A860
	// RVA: 0x2F27300 Offset: 0x2F27401 VA: 0x2F27300
	public void ForceLOD(int index) { }

	// RVA: 0x2F27350 Offset: 0x2F27451 VA: 0x2F27350
	public static float get_crossFadeAnimationDuration() { }

	// RVA: 0x2F27390 Offset: 0x2F27491 VA: 0x2F27390
	public static void set_crossFadeAnimationDuration(float value) { }

	// RVA: 0x2F273E0 Offset: 0x2F274E1 VA: 0x2F273E0
	internal Vector3 get_worldReferencePoint() { }

	// RVA: 0x2F27490 Offset: 0x2F27591 VA: 0x2F27490
	public void .ctor() { }

	// RVA: 0x2F26DF0 Offset: 0x2F26EF1 VA: 0x2F26DF0
	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	// RVA: 0x2F26EA0 Offset: 0x2F26FA1 VA: 0x2F26EA0
	private void set_localReferencePoint_Injected(ref Vector3 value) { }

	// RVA: 0x2F27440 Offset: 0x2F27541 VA: 0x2F27440
	private void get_worldReferencePoint_Injected(out Vector3 ret) { }
}

