// Namespace: App
public class ProfileCardVisualAssets // TypeDefIndex: 11663
{
	// Fields
	private static readonly string BgPath; // 0x0
	private static readonly string BgThumbPath; // 0x8
	private static readonly string FramePath; // 0x10
	private static readonly string FrameThumbPath; // 0x18
	private static readonly string TextDecoPath; // 0x20
	private static readonly string TextDecoThumbPath; // 0x28
	private static readonly string StampPath; // 0x30
	private static readonly string TexturesPath; // 0x38
	private static readonly string FrameThumbEmpty; // 0x40
	private static readonly string TextureFaceEmpty; // 0x48
	private static readonly string TexturePhotoEmpty; // 0x50
	private static SpriteAtlasManager s_BgThumbAtlas; // 0x58
	private static SpriteAtlasManager s_FrameThumbAtlas; // 0x60
	private static SpriteAtlasManager s_TextDecoAtlas; // 0x68
	private static SpriteAtlasManager s_TextDecoThumbAtlas; // 0x70
	private static SpriteAtlasManager s_StampAtlas; // 0x78
	private static SpriteAtlasManager s_TexturesAtlas; // 0x80

	// Methods

	// RVA: 0x2EE6340 Offset: 0x2EE6441 VA: 0x2EE6340
	public static void LoadAsync() { }

	// RVA: 0x2EE6750 Offset: 0x2EE6851 VA: 0x2EE6750
	public static bool IsLoading() { }

	// RVA: 0x2EE6AA0 Offset: 0x2EE6BA1 VA: 0x2EE6AA0
	public static void GetBg(ProfileCardBgData bgData, Action<Sprite> completed) { }

	// RVA: 0x2EE6BF0 Offset: 0x2EE6CF1 VA: 0x2EE6BF0
	public static void ReleaseBg(ProfileCardBgData bgData) { }

	// RVA: 0x2EE6CC0 Offset: 0x2EE6DC1 VA: 0x2EE6CC0
	public static Sprite TryGetBgThumb(ProfileCardBgData bgData) { }

	// RVA: 0x2EE6D50 Offset: 0x2EE6E51 VA: 0x2EE6D50
	public static void GetFrame(ProfileCardFrameData frameData, Action<Sprite> completed) { }

	// RVA: 0x2EE6EC0 Offset: 0x2EE6FC1 VA: 0x2EE6EC0
	public static void ReleaseFrame(ProfileCardFrameData frameData) { }

	// RVA: 0x2EE6F90 Offset: 0x2EE7091 VA: 0x2EE6F90
	public static Sprite TryGetFrameThumb(ProfileCardFrameData frameData) { }

	// RVA: 0x2EE7020 Offset: 0x2EE7121 VA: 0x2EE7020
	public static Sprite TryGetFrameThumbEmpty() { }

	// RVA: 0x2EE7090 Offset: 0x2EE7191 VA: 0x2EE7090
	public static Sprite TryGetTextDecoNameBg(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE7160 Offset: 0x2EE7261 VA: 0x2EE7160
	public static Sprite TryGetTextDecoCommentBg(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE7230 Offset: 0x2EE7331 VA: 0x2EE7230
	public static Sprite TryGetTextDecoTitleLargeBg(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE7300 Offset: 0x2EE7401 VA: 0x2EE7300
	public static Sprite TryGetTextDecoTitleSmallBg(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE73D0 Offset: 0x2EE74D1 VA: 0x2EE73D0
	public static Sprite TryGetTextDecoColumnBg(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE74A0 Offset: 0x2EE75A1 VA: 0x2EE74A0
	public static Sprite TryGetTextDecoLine(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE7570 Offset: 0x2EE7671 VA: 0x2EE7570
	public static Sprite TryGetTextDecoUnitNameBg(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE7640 Offset: 0x2EE7741 VA: 0x2EE7640
	public static Sprite TryGetTextDecoAchievement1Bg(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE7710 Offset: 0x2EE7811 VA: 0x2EE7710
	public static Sprite TryGetTextDecoAchievement2Bg(ProfileCardTextDecoData decoData) { }

	// RVA: 0x2EE77E0 Offset: 0x2EE78E1 VA: 0x2EE77E0
	public static Sprite TryGetTextDecoThumb(ProfileCardTextDecoData textDecoData) { }

	// RVA: 0x2ED8AF0 Offset: 0x2ED8BF1 VA: 0x2ED8AF0
	public static Sprite TryGetStamp(ProfileCardStampData stampData) { }

	// RVA: 0x2EE7870 Offset: 0x2EE7971 VA: 0x2EE7870
	public static Sprite TryGetTextures(string name) { }

	// RVA: 0x2EE7900 Offset: 0x2EE7A01 VA: 0x2EE7900
	public static Sprite TryGetTextureFaceEmpty() { }

	// RVA: 0x2EE7970 Offset: 0x2EE7A71 VA: 0x2EE7970
	public static Sprite TryGetTexturePhotoEmpty() { }

	// RVA: 0x2EE79E0 Offset: 0x2EE7AE1 VA: 0x2EE79E0
	public static void Unload() { }

	// RVA: 0x2EE7B70 Offset: 0x2EE7C71 VA: 0x2EE7B70
	public void .ctor() { }

	// RVA: 0x2EE7B80 Offset: 0x2EE7C81 VA: 0x2EE7B80
	private static void .cctor() { }
}

