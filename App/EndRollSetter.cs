// Namespace: App
public class EndRollSetter : MonoBehaviour // TypeDefIndex: 12548
{
	// Fields
	[HeaderAttribute] // RVA: 0x29AA40 Offset: 0x29AB41 VA: 0x29AA40
	public Image PictureSide0; // 0x18
	public Image PictureSide1; // 0x20
	public Image PictureLarge; // 0x28
	[HeaderAttribute] // RVA: 0x29AA80 Offset: 0x29AB81 VA: 0x29AA80
	public GameObject CreditRoot; // 0x30
	[HeaderAttribute] // RVA: 0x29AAC0 Offset: 0x29ABC1 VA: 0x29AAC0
	public GameObject PrefabTitlePosition; // 0x38
	public GameObject PrefabTitleCompany; // 0x40
	public GameObject Prefab1Lines; // 0x48
	public GameObject Prefab2Lines; // 0x50
	public GameObject Prefab3Lines; // 0x58
	public GameObject PrefabVoiceActor; // 0x60
	[HeaderAttribute] // RVA: 0x29AB00 Offset: 0x29AC01 VA: 0x29AB00
	public SpriteAtlas m_Pictures; // 0x68
	private float m_StartPos; // 0x70
	private float m_IllustFadeTime; // 0x74
	private float m_ScrollTime; // 0x78
	private float m_WaitTimeAfterStop; // 0x7C
	private float m_FadeOutTime; // 0x80
	private float m_LastPicWaitTime; // 0x84
	private float m_LastPicFadeIn; // 0x88
	private float m_LastPicDisplay; // 0x8C
	private float m_LastPicFadeOut; // 0x90
	private float m_ScrolledTime; // 0x94
	private float m_ScrollLength; // 0x98
	private GameObject m_LastObject; // 0xA0
	private List<RectTransform> m_CreditList; // 0xA8
	private List<int> m_IllustList; // 0xB0
	private float m_IllustFade; // 0xB8
	private double m_StartTime; // 0xC0
	private int m_Phase; // 0xC8
	private readonly int[] seqIllust; // 0xD0

	// Methods

	// RVA: 0x25FEAC0 Offset: 0x25FEBC1 VA: 0x25FEAC0
	public void Initialize() { }

	// RVA: 0x25FF200 Offset: 0x25FF301 VA: 0x25FF200
	private void SetupEndRoll() { }

	// RVA: 0x25FFD80 Offset: 0x25FFE81 VA: 0x25FFD80
	private void SetupIllust() { }

	// RVA: 0x26021F0 Offset: 0x26022F1 VA: 0x26021F0
	private void Update() { }

	// RVA: 0x2602280 Offset: 0x2602381 VA: 0x2602280
	private void Update1() { }

	// RVA: 0x2602830 Offset: 0x2602931 VA: 0x2602830
	private void Update2() { }

	// RVA: 0x2602260 Offset: 0x2602361 VA: 0x2602260
	public bool IsFinished1() { }

	// RVA: 0x2602F10 Offset: 0x2603011 VA: 0x2602F10
	public bool IsFinished2() { }

	// RVA: 0x25FEB00 Offset: 0x25FEC01 VA: 0x25FEB00
	public void DisplayLargePic() { }

	// RVA: 0x2602F40 Offset: 0x2603041 VA: 0x2602F40
	public void EndLargePic() { }

	// RVA: 0x2602950 Offset: 0x2602A51 VA: 0x2602950
	private float WaitStartFadeOut(int cur, int aft) { }

	// RVA: 0x26029E0 Offset: 0x2602AE1 VA: 0x26029E0
	private void PreFadeOut(int bef, int aft) { }

	// RVA: 0x2602B70 Offset: 0x2602C71 VA: 0x2602B70
	private float FadeOut(int bef, int aft) { }

	// RVA: 0x2602C60 Offset: 0x2602D61 VA: 0x2602C60
	private void PreFadeIn(int bef, int aft) { }

	// RVA: 0x2602E70 Offset: 0x2602F71 VA: 0x2602E70
	private float FadeIn(int bef, int aft) { }

	// RVA: 0x2602FC0 Offset: 0x26030C1 VA: 0x2602FC0
	private bool IsSequential(int id) { }

	// RVA: 0x2602130 Offset: 0x2602231 VA: 0x2602130
	private void SetPicture(Image img, int num) { }

	// RVA: 0x2603030 Offset: 0x2603131 VA: 0x2603030
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9780 Offset: 0x2C9881 VA: 0x2C9780
	// RVA: 0x2601DA0 Offset: 0x2601EA1 VA: 0x2601DA0
	private void <SetupEndRoll>g__SetTransform|28_0(ref EndRollSetter.<>c__DisplayClass28_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9790 Offset: 0x2C9891 VA: 0x2C9790
	// RVA: 0x2601670 Offset: 0x2601771 VA: 0x2601670
	private void <SetupEndRoll>g__SetName2|28_1(ref EndRollSetter.<>c__DisplayClass28_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C97A0 Offset: 0x2C98A1 VA: 0x2C97A0
	// RVA: 0x26019A0 Offset: 0x2601AA1 VA: 0x26019A0
	private void <SetupEndRoll>g__SetName3|28_2(ref EndRollSetter.<>c__DisplayClass28_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C97B0 Offset: 0x2C98B1 VA: 0x2C97B0
	// RVA: 0x2601EA0 Offset: 0x2601FA1 VA: 0x2601EA0
	private void <SetupEndRoll>g__CreateSpace|28_3(string name, int height, ref EndRollSetter.<>c__DisplayClass28_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C97C0 Offset: 0x2C98C1 VA: 0x2C97C0
	// RVA: 0x2602080 Offset: 0x2602181 VA: 0x2602080
	internal static bool <SetupIllust>g__IsAliveAll|29_0(string[] names) { }
}

