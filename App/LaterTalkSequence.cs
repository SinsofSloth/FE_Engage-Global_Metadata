// Namespace: App
public class LaterTalkSequence : SingletonProcInst<LaterTalkSequence> // TypeDefIndex: 12993
{
	// Fields
	private const string PrefabPath = "UI/Ending/Prefabs/LaterTalkRoot";
	private string m_BgmHeader; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x29B900 Offset: 0x29BA01 VA: 0x29B900
	private LaterTalkSetter <Setter>k__BackingField; // 0x80
	private BaseCombatLocation m_Locator; // 0x88
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x90
	private GameObject m_Camera; // 0x98
	private Volume m_VolumeAlive; // 0xA0
	private Volume m_VolumeDead; // 0xA8
	private GarbageCollector.Mode m_GcMode; // 0xB0
	public static string BgmBranch; // 0x0
	private CharacterLoader m_Current; // 0xB8
	private CharacterLoader m_CurrentMarriage; // 0xC0
	private ResourceHandle m_CurrentBg; // 0xC8
	private CharacterLoader m_Next; // 0xD0
	private CharacterLoader m_NextMarriage; // 0xD8
	private ResourceHandle m_NextBg; // 0xE0
	private float m_FadeInTime; // 0xE8
	private float m_FadeOutTime; // 0xEC
	private CameraControllerUnitDetail[] m_CameraCtrls; // 0xF0
	private float[] m_DefaultSlipSlideScales; // 0xF8
	private float m_SlideTime; // 0x100
	private float m_SlideStart; // 0x104
	private float m_SlideEnd; // 0x108
	private float m_Power; // 0x10C
	private IDisposable m_CurrentSlide; // 0x110

	// Properties
	public LaterTalkSetter Setter { get; set; }

	// Methods

	// RVA: 0x1F7EA40 Offset: 0x1F7EB41 VA: 0x1F7EA40
	public static bool IsExist() { }

	// RVA: 0x1F7EAC0 Offset: 0x1F7EBC1 VA: 0x1F7EAC0
	public static void CreateBind(ProcInst super, string bgmHeader) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA830 Offset: 0x2CA931 VA: 0x2CA830
	// RVA: 0x1F7F220 Offset: 0x1F7F321 VA: 0x1F7F220
	public LaterTalkSetter get_Setter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA840 Offset: 0x2CA941 VA: 0x2CA840
	// RVA: 0x1F7F230 Offset: 0x1F7F331 VA: 0x1F7F230
	private void set_Setter(LaterTalkSetter value) { }

	// RVA: 0x1F7F240 Offset: 0x1F7F341 VA: 0x1F7F240
	public static void PreSetup(string bgmHeader) { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA850 Offset: 0x2CA951 VA: 0x2CA850
	// RVA: 0x1F7F660 Offset: 0x1F7F761 VA: 0x1F7F660
	private IEnumerator SetUp() { }

	// RVA: 0x1F7F6E0 Offset: 0x1F7F7E1 VA: 0x1F7F6E0
	private void Unload() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA8C0 Offset: 0x2CA9C1 VA: 0x2CA8C0
	// RVA: 0x1F7F8C0 Offset: 0x1F7F9C1 VA: 0x1F7F8C0
	private IEnumerator FadeIn() { }

	// RVA: 0x1F7F940 Offset: 0x1F7FA41 VA: 0x1F7F940
	private void StartLoadNext() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA930 Offset: 0x2CAA31 VA: 0x2CA930
	// RVA: 0x1F7FDD0 Offset: 0x1F7FED1 VA: 0x1F7FDD0
	private IEnumerator Tick() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA9A0 Offset: 0x2CAAA1 VA: 0x2CA9A0
	// RVA: 0x1F7FE50 Offset: 0x1F7FF51 VA: 0x1F7FE50
	private IEnumerator FadeOut() { }

	// RVA: 0x1F7FED0 Offset: 0x1F7FFD1 VA: 0x1F7FED0
	private void StartSlideIn(float time) { }

	// RVA: 0x1F80090 Offset: 0x1F80191 VA: 0x1F80090
	private void StartSlideOut(float time) { }

	[IteratorStateMachineAttribute] // RVA: 0x2CAA10 Offset: 0x2CAB11 VA: 0x2CAA10
	// RVA: 0x1F80250 Offset: 0x1F80351 VA: 0x1F80250
	private IEnumerator Slide() { }

	// RVA: 0x1F7F1A0 Offset: 0x1F7F2A1 VA: 0x1F7F1A0
	public void .ctor() { }
}

