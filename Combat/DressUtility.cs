// Namespace: Combat
[DefaultMemberAttribute] // RVA: 0x2748A0 Offset: 0x2749A1 VA: 0x2748A0
public sealed class DressUtility // TypeDefIndex: 8809
{
	// Fields
	private HierarchyCache bodyCache; // 0x10

	// Properties
	public HierarchyCache Cache { get; }
	public Transform Item { get; }

	// Methods

	// RVA: 0x25ED180 Offset: 0x25ED281 VA: 0x25ED180
	public HierarchyCache get_Cache() { }

	// RVA: 0x25ED190 Offset: 0x25ED291 VA: 0x25ED190
	public Transform get_Item(string name) { }

	// RVA: 0x25ED1A0 Offset: 0x25ED2A1 VA: 0x25ED1A0
	public void .ctor(Transform bodyRoot) { }

	// RVA: 0x25ED220 Offset: 0x25ED321 VA: 0x25ED220
	public void TransplantDressOnlyBones(Transform dress) { }

	// RVA: 0x25ED4E0 Offset: 0x25ED5E1 VA: 0x25ED4E0
	public void TransplantSkinnedMesh(GameObject dressGO, SkinnedMeshRenderer[] dressMeshes, string parentName = "meshGP") { }

	// RVA: 0x25ED7C0 Offset: 0x25ED8C1 VA: 0x25ED7C0
	public void TransplantMesh(GameObject accGO, string parentName = "meshGP") { }
}

