// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D070 Offset: 0x43D171 VA: 0x43D070
public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 3503
{
	// Properties
	public SkinQuality quality { get; set; }
	public bool updateWhenOffscreen { get; set; }
	public bool forceMatrixRecalculationPerRender { get; set; }
	public Transform rootBone { get; set; }
	public Transform[] bones { get; set; }
	[NativePropertyAttribute] // RVA: 0x459E00 Offset: 0x459F01 VA: 0x459E00
	public Mesh sharedMesh { get; set; }
	[NativePropertyAttribute] // RVA: 0x459E40 Offset: 0x459F41 VA: 0x459E40
	public bool skinnedMotionVectors { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0x31EBB60 Offset: 0x31EBC61 VA: 0x31EBB60
	public SkinQuality get_quality() { }

	// RVA: 0x31EBBB0 Offset: 0x31EBCB1 VA: 0x31EBBB0
	public void set_quality(SkinQuality value) { }

	// RVA: 0x31EBC00 Offset: 0x31EBD01 VA: 0x31EBC00
	public bool get_updateWhenOffscreen() { }

	// RVA: 0x31EBC50 Offset: 0x31EBD51 VA: 0x31EBC50
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x31EBCA0 Offset: 0x31EBDA1 VA: 0x31EBCA0
	public bool get_forceMatrixRecalculationPerRender() { }

	// RVA: 0x31EBCF0 Offset: 0x31EBDF1 VA: 0x31EBCF0
	public void set_forceMatrixRecalculationPerRender(bool value) { }

	// RVA: 0x31EBD40 Offset: 0x31EBE41 VA: 0x31EBD40
	public Transform get_rootBone() { }

	// RVA: 0x31EBD90 Offset: 0x31EBE91 VA: 0x31EBD90
	public void set_rootBone(Transform value) { }

	// RVA: 0x31EBDE0 Offset: 0x31EBEE1 VA: 0x31EBDE0
	public Transform[] get_bones() { }

	// RVA: 0x31EBE30 Offset: 0x31EBF31 VA: 0x31EBE30
	public void set_bones(Transform[] value) { }

	// RVA: 0x31EBE80 Offset: 0x31EBF81 VA: 0x31EBE80
	public Mesh get_sharedMesh() { }

	// RVA: 0x31EBED0 Offset: 0x31EBFD1 VA: 0x31EBED0
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x31EBF20 Offset: 0x31EC021 VA: 0x31EBF20
	public bool get_skinnedMotionVectors() { }

	// RVA: 0x31EBF70 Offset: 0x31EC071 VA: 0x31EBF70
	public void set_skinnedMotionVectors(bool value) { }

	// RVA: 0x31EBFC0 Offset: 0x31EC0C1 VA: 0x31EBFC0
	public float GetBlendShapeWeight(int index) { }

	// RVA: 0x31EC010 Offset: 0x31EC111 VA: 0x31EC010
	public void SetBlendShapeWeight(int index, float value) { }

	// RVA: 0x31EC070 Offset: 0x31EC171 VA: 0x31EC070
	public void BakeMesh(Mesh mesh) { }

	// RVA: 0x31EC0D0 Offset: 0x31EC1D1 VA: 0x31EC0D0
	public void BakeMesh(Mesh mesh, bool useScale) { }

	[FreeFunctionAttribute] // RVA: 0x44A650 Offset: 0x44A751 VA: 0x44A650
	// RVA: 0x31EC130 Offset: 0x31EC231 VA: 0x31EC130
	private Bounds GetLocalAABB() { }

	// RVA: 0x31EC200 Offset: 0x31EC301 VA: 0x31EC200
	private void SetLocalAABB(Bounds b) { }

	// RVA: 0x31EC2A0 Offset: 0x31EC3A1 VA: 0x31EC2A0
	public Bounds get_localBounds() { }

	// RVA: 0x31EC330 Offset: 0x31EC431 VA: 0x31EC330
	public void set_localBounds(Bounds value) { }

	// RVA: 0x31EC390 Offset: 0x31EC491 VA: 0x31EC390
	public void .ctor() { }

	// RVA: 0x31EC1B0 Offset: 0x31EC2B1 VA: 0x31EC1B0
	private void GetLocalAABB_Injected(out Bounds ret) { }

	// RVA: 0x31EC250 Offset: 0x31EC351 VA: 0x31EC250
	private void SetLocalAABB_Injected(ref Bounds b) { }
}

