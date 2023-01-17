// Namespace: App
[Serializable]
public class GrassData : ScriptableObject // TypeDefIndex: 14009
{
	// Fields
	public const int GrassInfoCount = 32;
	public const int GrassInfoIndexUvChannel = 0;
	public const int GrassOrgMeshUvChannel = 1;
	public bool m_bilinear; // 0x18
	public SpriteAtlas m_spriteAtlas; // 0x20
	public List<GrassData.SpriteInfo> m_spriteInfos; // 0x28

	// Methods

	// RVA: 0x27BE140 Offset: 0x27BE241 VA: 0x27BE140
	public void Copy(GrassData src) { }

	// RVA: 0x27BE2B0 Offset: 0x27BE3B1 VA: 0x27BE2B0
	public bool VerifyData() { }

	// RVA: 0x27BE440 Offset: 0x27BE541 VA: 0x27BE440
	public static void ParseSpriteInfos(List<GrassData.SpriteInfo> src, out List<Vector4> outScale, out List<float> outAspect, out List<Vector4> outST, out List<Color> outTopColor, out List<Color> outBottomColor, out List<float> outWindColorInfluence) { }

	// RVA: 0x27BE830 Offset: 0x27BE931 VA: 0x27BE830
	public void .ctor() { }
}

