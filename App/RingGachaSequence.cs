// Namespace: App
public class RingGachaSequence : SingletonProcInst<RingGachaSequence> // TypeDefIndex: 11779
{
	// Fields
	private ResourceHandle m_SceneResourceHandle; // 0x78
	private List<GameObject> m_DisableList; // 0x80
	private readonly string SceneName; // 0x88
	private Scene m_RingGachaScene; // 0x90
	private GameObject m_EffectObject; // 0x98
	private GameObject m_BgEffectRootObject; // 0xA0
	private TitleBar m_TitleBar; // 0xA8
	private string m_EngageZonePrefabPath; // 0xB0
	private TResourceHandle<GameObject> m_CommonRingHandle; // 0xB8
	private CommonRingController m_CommonRingController; // 0xC0
	private GameObject m_RingModelRoot; // 0xC8
	private readonly string StartEffectPath; // 0xD0
	private string[] CreateEffectPaths; // 0xD8
	private readonly string[] LoopEffectPaths; // 0xE0
	private GodUnit m_GodUnit; // 0xE8
	private List<UnitRing> m_RingList; // 0xF0
	private int m_RingIndex; // 0xF8
	private List<bool> m_NewList; // 0x100
	private Action m_EndCallback; // 0x108
	private RingGachaSequence.SkipListenerProc m_SkipListenerProc; // 0x110
	private ProcInst m_ResultProc; // 0x118
	private GameObject m_StartEffect; // 0x120
	private GameObject m_CreateEffect; // 0x128
	private GameObject m_LoopEffect; // 0x130
	private GameObject m_RingObject; // 0x138

	// Properties
	private string ReturnSceneName { get; }
	private UnitRing ResultRing { get; }

	// Methods

	// RVA: 0x2687C60 Offset: 0x2687D61 VA: 0x2687C60
	private string get_ReturnSceneName() { }

	// RVA: 0x2687CD0 Offset: 0x2687DD1 VA: 0x2687CD0
	private UnitRing get_ResultRing() { }

	// RVA: 0x2687D40 Offset: 0x2687E41 VA: 0x2687D40
	private void .ctor(GodUnit godUnit, List<UnitRing> ringList, List<bool> newList, Action endCallback) { }

	// RVA: 0x2688290 Offset: 0x2688391 VA: 0x2688290
	private void Init() { }

	// RVA: 0x2688470 Offset: 0x2688571 VA: 0x2688470
	private void LoadResources() { }

	// RVA: 0x2688810 Offset: 0x2688911 VA: 0x2688810
	private bool IsLoading() { }

	// RVA: 0x26889A0 Offset: 0x2688AA1 VA: 0x26889A0
	private void ActiveScene() { }

	// RVA: 0x2688CA0 Offset: 0x2688DA1 VA: 0x2688CA0
	private void SetGameObjects() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C6850 Offset: 0x2C6951 VA: 0x2C6850
	// RVA: 0x2689070 Offset: 0x2689171 VA: 0x2689070
	private IEnumerator Start() { }

	// RVA: 0x26890F0 Offset: 0x26891F1 VA: 0x26890F0
	private void ShowRing() { }

	// RVA: 0x26894C0 Offset: 0x26895C1 VA: 0x26894C0
	private void SetUpResultSceneForSkipOneOfTen() { }

	// RVA: 0x2689530 Offset: 0x2689631 VA: 0x2689530
	private void CreateResultOneOfTenWindow() { }

	// RVA: 0x2689620 Offset: 0x2689721 VA: 0x2689620
	private void Branch() { }

	// RVA: 0x26896F0 Offset: 0x26897F1 VA: 0x26896F0
	private void Clear() { }

	// RVA: 0x2689900 Offset: 0x2689A01 VA: 0x2689900
	private void CreateResultWindow() { }

	// RVA: 0x26899E0 Offset: 0x2689AE1 VA: 0x26899E0
	private void SetUpResultSceneForSkip() { }

	// RVA: 0x2689B00 Offset: 0x2689C01 VA: 0x2689B00
	private void BeginSkipListener() { }

	// RVA: 0x2689BA0 Offset: 0x2689CA1 VA: 0x2689BA0
	private void PauseSkipOne() { }

	// RVA: 0x2689BC0 Offset: 0x2689CC1 VA: 0x2689BC0
	private void UnpauseSkipOne() { }

	// RVA: 0x2689BD0 Offset: 0x2689CD1 VA: 0x2689BD0
	private void OnSkip(RingGachaSequence.SkipListenerProc.Type skipType) { }

	// RVA: 0x2689E30 Offset: 0x2689F31 VA: 0x2689E30
	private void EndSkipListenter() { }

	// RVA: 0x2689E80 Offset: 0x2689F81 VA: 0x2689E80
	private void UnloadResources() { }

	// RVA: 0x268A160 Offset: 0x268A261 VA: 0x268A160
	private void ReturnScene() { }

	// RVA: 0x268A360 Offset: 0x268A461 VA: 0x268A360
	private void End() { }

	// RVA: 0x268A3F0 Offset: 0x268A4F1 VA: 0x268A3F0
	public static void CreateBind(ProcInst super, GodUnit god, List<UnitRing> ringList, List<bool> newList, Action endCallback) { }

	// RVA: 0x2689440 Offset: 0x2689541 VA: 0x2689440
	private string GetCreateEffectPath(RingData ring) { }

	// RVA: 0x2689480 Offset: 0x2689581 VA: 0x2689480
	private string GetLoopEffectPath(RingData ring) { }
}

