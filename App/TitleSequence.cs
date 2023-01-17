// Namespace: App
public class TitleSequence : SingletonProcInst<TitleSequence> // TypeDefIndex: 13149
{
	// Fields
	public const string MapSceneName = "Fld_M003_Title";
	public const string CameraPrefabPath = "Title/Camera_rot";
	private const float FadeOutSec = 0.33;
	private const float StartFadeOutElapsedTime = 29.67;
	private static string s_TitleLogoTexturePath; // 0x0
	private float m_ElapsedTime; // 0x74
	private Animator m_TitleLogoAnimator; // 0x78
	private Animator m_PressStartAnimator; // 0x80
	private TextMeshProUGUI m_GameVersionText; // 0x88

	// Methods

	// RVA: 0x25E4E50 Offset: 0x25E4F51 VA: 0x25E4E50
	private void PostBgmEvent(string bgmEventName) { }

	// RVA: 0x25E4F80 Offset: 0x25E5081 VA: 0x25E4F80
	private void Start() { }

	// RVA: 0x25E52D0 Offset: 0x25E53D1 VA: 0x25E52D0
	private void Tick() { }

	// RVA: 0x25E5830 Offset: 0x25E5931 VA: 0x25E5830
	private void FadeIn() { }

	// RVA: 0x25E5780 Offset: 0x25E5881 VA: 0x25E5780
	private void FadeOut(bool isBgmFadeOut) { }

	// RVA: 0x25E5890 Offset: 0x25E5991 VA: 0x25E5890
	private void End() { }

	// RVA: 0x25E58A0 Offset: 0x25E59A1 VA: 0x25E58A0
	private ProcDesc[] GetDesc() { }

	// RVA: 0x25E5D30 Offset: 0x25E5E31 VA: 0x25E5D30
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x25E5E90 Offset: 0x25E5F91 VA: 0x25E5E90
	public static void LoadTitleScene(ProcInst super) { }

	// RVA: 0x25E6170 Offset: 0x25E6271 VA: 0x25E6170
	public static bool IsLoadingTitleScene(ProcInst super) { }

	// RVA: 0x25E6250 Offset: 0x25E6351 VA: 0x25E6250
	public static void UnloadTitleScene(ProcInst super) { }

	// RVA: 0x25E6360 Offset: 0x25E6461 VA: 0x25E6360
	public static void InitAfterLoadTitleScene() { }

	// RVA: 0x25E6AD0 Offset: 0x25E6BD1 VA: 0x25E6AD0
	public static void ShowTitleScene() { }

	// RVA: 0x25E6CD0 Offset: 0x25E6DD1 VA: 0x25E6CD0
	public static void HideTitleScene() { }

	// RVA: 0x25E6B20 Offset: 0x25E6C21 VA: 0x25E6B20
	private static void SetTitleSceneVisible(string sceneName, bool isShow) { }

	// RVA: 0x25E6D20 Offset: 0x25E6E21 VA: 0x25E6D20
	public static GameObject GetMovieCanvasPrefab() { }

	// RVA: 0x25E5E10 Offset: 0x25E5F11 VA: 0x25E5E10
	public void .ctor() { }
}

