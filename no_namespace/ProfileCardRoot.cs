// Namespace: 
[Serializable]
public class ProfileCardRoot.AchievementInfo // TypeDefIndex: 11606
{
	// Fields
	public Image m_Icon; // 0x10
	public TextMeshProUGUI m_Caption; // 0x18
	public TextMeshProUGUI m_Count; // 0x20
	public Image m_BgImage; // 0x28

	// Methods

	// RVA: 0x1F25A90 Offset: 0x1F25B91 VA: 0x1F25A90
	public void .ctor() { }
}

// Namespace: 
public struct ProfileCardRoot.RectInfo // TypeDefIndex: 11608
{
	// Fields
	public Vector2 Pos; // 0x0
	public Vector2 HarfSize; // 0x8
	public Vector2 XAxis; // 0x10
	public Vector2 YAxis; // 0x18

	// Methods

	// RVA: 0x1F25AA0 Offset: 0x1F25BA1 VA: 0x1F25AA0
	public void .ctor(Vector2 pos, Vector2 harfSize, Vector2 xAxis, Vector2 yAxis) { }

	// RVA: 0x1F25AD0 Offset: 0x1F25BD1 VA: 0x1F25AD0
	private static float GetAbsDot(Vector2 v1, Vector2 v2) { }

	// RVA: 0x1F25AF0 Offset: 0x1F25BF1 VA: 0x1F25AF0
	public static bool IsOverlap(ProfileCardRoot.RectInfo rect1, ProfileCardRoot.RectInfo rect2) { }

	// RVA: 0x1F25C50 Offset: 0x1F25D51 VA: 0x1F25C50
	public static float GetDistance(Vector2 pos, ProfileCardRoot.RectInfo rect) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2779F0 Offset: 0x277AF1 VA: 0x2779F0
private sealed class ProfileCardRoot.<>c__DisplayClass113_0 // TypeDefIndex: 11610
{
	// Fields
	public ProfileCardRoot <>4__this; // 0x10
	public ProfileCardFrameData frameData; // 0x18

	// Methods

	// RVA: 0x1F25910 Offset: 0x1F25A11 VA: 0x1F25910
	public void .ctor() { }

	// RVA: 0x1F25920 Offset: 0x1F25A21 VA: 0x1F25920
	internal void <UpdateFrame>b__0(Sprite sprite) { }
}

