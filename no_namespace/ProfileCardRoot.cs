// Namespace: 
[Serializable]
public class ProfileCardRoot.SortieCountInfo // TypeDefIndex: 11605
{
	// Fields
	public GameObject m_RootObject; // 0x10
	public UnitIcon m_UnitIcon; // 0x18
	public TextMeshProUGUI m_UnitName; // 0x20
	public TextMeshProUGUI m_SortieCount; // 0x28
	public Image m_BgImage; // 0x30

	// Methods

	// RVA: 0x1F25D30 Offset: 0x1F25E31 VA: 0x1F25D30
	public void .ctor() { }
}

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
public sealed class ProfileCardRoot.StartHandler : MulticastDelegate // TypeDefIndex: 11607
{
	// Methods

	// RVA: 0x1F25D40 Offset: 0x1F25E41 VA: 0x1F25D40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F25D60 Offset: 0x1F25E61 VA: 0x1F25D60 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F25F70 Offset: 0x1F26071 VA: 0x1F25F70 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F25FA0 Offset: 0x1F260A1 VA: 0x1F25FA0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
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
[CompilerGeneratedAttribute] // RVA: 0x2779E0 Offset: 0x277AE1 VA: 0x2779E0
private sealed class ProfileCardRoot.<>c__DisplayClass111_0 // TypeDefIndex: 11609
{
	// Fields
	public ProfileCardRoot <>4__this; // 0x10
	public ProfileCardBgData bgData; // 0x18

	// Methods

	// RVA: 0x1F25810 Offset: 0x1F25911 VA: 0x1F25810
	public void .ctor() { }

	// RVA: 0x1F25820 Offset: 0x1F25921 VA: 0x1F25820
	internal void <UpdateBg>b__0(Sprite sprite) { }
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

