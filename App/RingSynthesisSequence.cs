// Namespace: App
public class RingSynthesisSequence : SingletonProcInst<RingSynthesisSequence> // TypeDefIndex: 11784
{
	// Fields
	private SynthesisRingMenuTop.Result m_MenuResult; // 0x78
	private RingData m_MaterialRing; // 0x80
	private RingData m_NextRing; // 0x88
	private string m_EngageZonePrefabPath; // 0x90
	private ResourceHandle m_SceneResourceHandle; // 0x98
	private List<GameObject> m_DisableList; // 0xA0
	private readonly string SceneName; // 0xA8
	private Scene m_RingMergeScene; // 0xB0
	private GameObject m_EffectObject; // 0xB8
	private TResourceHandle<GameObject> m_MaterialRingHandle; // 0xC0
	private TResourceHandle<GameObject> m_NextRingHandle; // 0xC8
	private CommonRingController m_NextRingController; // 0xD0
	private GameObject m_NextRingObject; // 0xD8
	private GameObject m_RingRoot; // 0xE0
	private GameObject m_RingRotateRoot; // 0xE8
	private Action m_EndEventHandler; // 0xF0
	private RingSynthesisSequence.SkipListenerProc m_SkipListenerProc; // 0xF8
	private bool m_IsSkipped; // 0x100
	private readonly Vector3 InitRotate; // 0x104
	private string[] CreateEffectPaths; // 0x110
	private readonly string[] LoopEffectPaths; // 0x118
	private readonly string EmitEffect; // 0x120

	// Properties
	private string ReturnSceneName { get; }

	// Methods

	// RVA: 0x20591C0 Offset: 0x20592C1 VA: 0x20591C0
	private string get_ReturnSceneName() { }

	// RVA: 0x2059230 Offset: 0x2059331 VA: 0x2059230
	private void .ctor(SynthesisRingMenuTop.Result result, Action endEventHandler) { }

	// RVA: 0x2059720 Offset: 0x2059821 VA: 0x2059720
	private void Init() { }

	// RVA: 0x2059890 Offset: 0x2059991 VA: 0x2059890
	private void LoadResources() { }

	// RVA: 0x2059B80 Offset: 0x2059C81 VA: 0x2059B80
	private bool IsLoading() { }

	// RVA: 0x2059C80 Offset: 0x2059D81 VA: 0x2059C80
	private void ActiveScene() { }

	// RVA: 0x2059FC0 Offset: 0x205A0C1 VA: 0x2059FC0
	private void SetGameObjects() { }

	// RVA: 0x205A4B0 Offset: 0x205A5B1 VA: 0x205A4B0
	private void SetParameter(CommonRingController controller, RingData data) { }

	// RVA: 0x205A500 Offset: 0x205A601 VA: 0x205A500
	private void StartAnimation() { }

	// RVA: 0x205A5D0 Offset: 0x205A6D1 VA: 0x205A5D0
	private void PlaySynthesisSound() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C6950 Offset: 0x2C6A51 VA: 0x2C6950
	// RVA: 0x205A6C0 Offset: 0x205A7C1 VA: 0x205A6C0
	private IEnumerator WaitTick() { }

	// RVA: 0x205A720 Offset: 0x205A821 VA: 0x205A720
	private void ShowNextRing() { }

	// RVA: 0x205A910 Offset: 0x205AA11 VA: 0x205A910
	private void OpenDialog() { }

	// RVA: 0x205A920 Offset: 0x205AA21 VA: 0x205A920
	private void UnloadResources() { }

	// RVA: 0x205AAA0 Offset: 0x205ABA1 VA: 0x205AAA0
	private void ReturnScene() { }

	// RVA: 0x205ACA0 Offset: 0x205ADA1 VA: 0x205ACA0
	private void End() { }

	// RVA: 0x205AD30 Offset: 0x205AE31 VA: 0x205AD30
	private void BeginSkipListener() { }

	// RVA: 0x205AD60 Offset: 0x205AE61 VA: 0x205AD60
	private void EndSkipLisnter() { }

	// RVA: 0x205AE10 Offset: 0x205AF11 VA: 0x205AE10
	public static void CreateBind(ProcInst super, SynthesisRingMenuTop.Result menuResult, Action endEventHandler) { }

	// RVA: 0x2059B00 Offset: 0x2059C01 VA: 0x2059B00
	private string GetCreateEffectPath(RingData ring) { }

	// RVA: 0x2059B40 Offset: 0x2059C41 VA: 0x2059B40
	private string GetLoopEffectPath(RingData ring) { }
}

