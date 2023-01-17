// Namespace: TMPro
public class MaterialReferenceManager // TypeDefIndex: 7332
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x192EFD0 Offset: 0x192F0D1 VA: 0x192EFD0
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x192F200 Offset: 0x192F301 VA: 0x192F200
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x192F290 Offset: 0x192F391 VA: 0x192F290
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0x192F350 Offset: 0x192F451 VA: 0x192F350
	public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x192F3E0 Offset: 0x192F4E1 VA: 0x192F3E0
	private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x192F4A0 Offset: 0x192F5A1 VA: 0x192F4A0
	public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x192F540 Offset: 0x192F641 VA: 0x192F540
	private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x192F610 Offset: 0x192F711 VA: 0x192F610
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x192F6E0 Offset: 0x192F7E1 VA: 0x192F6E0
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x192F750 Offset: 0x192F851 VA: 0x192F750
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x192F860 Offset: 0x192F961 VA: 0x192F860
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x192F910 Offset: 0x192FA11 VA: 0x192F910
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0x192F970 Offset: 0x192FA71 VA: 0x192F970
	public bool Contains(TMP_SpriteAsset sprite) { }

	// RVA: 0x192F9D0 Offset: 0x192FAD1 VA: 0x192F9D0
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x192FAB0 Offset: 0x192FBB1 VA: 0x192FAB0
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x192FB30 Offset: 0x192FC31 VA: 0x192FB30
	public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x192FC10 Offset: 0x192FD11 VA: 0x192FC10
	private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x192FC90 Offset: 0x192FD91 VA: 0x192FC90
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x192FD70 Offset: 0x192FE71 VA: 0x192FD70
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x192FDF0 Offset: 0x192FEF1 VA: 0x192FDF0
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x192FED0 Offset: 0x192FFD1 VA: 0x192FED0
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x192F070 Offset: 0x192F171 VA: 0x192F070
	public void .ctor() { }
}

