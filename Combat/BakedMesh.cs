// Namespace: Combat
public sealed class BakedMesh : MonoBehaviour // TypeDefIndex: 8802
{
	// Fields
	private MeshFilter _meshFilter; // 0x18
	private MeshRenderer _meshRenderer; // 0x20
	private bool twice; // 0x28
	private bool isSkinnedMesh; // 0x29

	// Properties
	private MeshFilter meshFilter { get; }
	private MeshRenderer meshRenderer { get; }

	// Methods

	// RVA: 0x26143A0 Offset: 0x26144A1 VA: 0x26143A0
	public static BakedMesh Create(Transform parent) { }

	// RVA: 0x2614480 Offset: 0x2614581 VA: 0x2614480
	private MeshFilter get_meshFilter() { }

	// RVA: 0x2614540 Offset: 0x2614641 VA: 0x2614540
	private MeshRenderer get_meshRenderer() { }

	// RVA: 0x2614600 Offset: 0x2614701 VA: 0x2614600
	private void OnDestroy() { }

	// RVA: 0x2614690 Offset: 0x2614791 VA: 0x2614690
	public void BakeFrom(SkinnedMeshRenderer skmesh, bool omit2nd = False) { }

	// RVA: 0x2614840 Offset: 0x2614941 VA: 0x2614840
	public void BakeFrom(MeshFilter filter, MeshRenderer renderer) { }

	// RVA: 0x2614960 Offset: 0x2614A61 VA: 0x2614960
	public void .ctor() { }
}

