// Namespace: TMPro
public struct MaterialReference // TypeDefIndex: 7334
{
	// Fields
	public int index; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public TMP_SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isDefaultMaterial; // 0x20
	public bool isFallbackMaterial; // 0x21
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x192E9D0 Offset: 0x192EAD1 VA: 0x192E9D0
	public void .ctor(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x192EA80 Offset: 0x192EB81 VA: 0x192EA80
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	// RVA: 0x192EB90 Offset: 0x192EC91 VA: 0x192EB90
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x192EDB0 Offset: 0x192EEB1 VA: 0x192EDB0
	public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}

