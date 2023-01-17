// Namespace: Cinemachine
[AddComponentMenu] // RVA: 0x1AFF0 Offset: 0x1B0F1 VA: 0x1AFF0
[ExecuteAlways] // RVA: 0x1AFF0 Offset: 0x1B0F1 VA: 0x1AFF0
[DocumentationSortingAttribute] // RVA: 0x1AFF0 Offset: 0x1B0F1 VA: 0x1AFF0
[HelpURLAttribute] // RVA: 0x1AFF0 Offset: 0x1B0F1 VA: 0x1AFF0
[DisallowMultipleComponent] // RVA: 0x1AFF0 Offset: 0x1B0F1 VA: 0x1AFF0
[SaveDuringPlayAttribute] // RVA: 0x1AFF0 Offset: 0x1B0F1 VA: 0x1AFF0
public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 5771
{
	// Fields
	[TooltipAttribute] // RVA: 0x1E300 Offset: 0x1E401 VA: 0x1E300
	public static bool s_StoryboardGlobalMute; // 0x0
	[TooltipAttribute] // RVA: 0x1E340 Offset: 0x1E441 VA: 0x1E340
	public bool m_ShowImage; // 0x28
	[TooltipAttribute] // RVA: 0x1E380 Offset: 0x1E481 VA: 0x1E380
	public Texture m_Image; // 0x30
	[TooltipAttribute] // RVA: 0x1E3C0 Offset: 0x1E4C1 VA: 0x1E3C0
	public CinemachineStoryboard.FillStrategy m_Aspect; // 0x38
	[RangeAttribute] // RVA: 0x1E400 Offset: 0x1E501 VA: 0x1E400
	[TooltipAttribute] // RVA: 0x1E400 Offset: 0x1E501 VA: 0x1E400
	public float m_Alpha; // 0x3C
	[TooltipAttribute] // RVA: 0x1E460 Offset: 0x1E561 VA: 0x1E460
	public Vector2 m_Center; // 0x40
	[TooltipAttribute] // RVA: 0x1E4A0 Offset: 0x1E5A1 VA: 0x1E4A0
	public Vector3 m_Rotation; // 0x48
	[TooltipAttribute] // RVA: 0x1E4E0 Offset: 0x1E5E1 VA: 0x1E4E0
	public Vector2 m_Scale; // 0x54
	[TooltipAttribute] // RVA: 0x1E520 Offset: 0x1E621 VA: 0x1E520
	public bool m_SyncScale; // 0x5C
	[TooltipAttribute] // RVA: 0x1E560 Offset: 0x1E661 VA: 0x1E560
	public bool m_MuteCamera; // 0x5D
	[TooltipAttribute] // RVA: 0x1E5A0 Offset: 0x1E6A1 VA: 0x1E5A0
	[RangeAttribute] // RVA: 0x1E5A0 Offset: 0x1E6A1 VA: 0x1E5A0
	public float m_SplitView; // 0x60
	private List<CinemachineStoryboard.CanvasInfo> mCanvasInfo; // 0x68

	// Properties
	private string CanvasName { get; }

	// Methods

	// RVA: 0x1A72FC0 Offset: 0x1A730C1 VA: 0x1A72FC0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1A73100 Offset: 0x1A73201 VA: 0x1A73100 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1A73530 Offset: 0x1A73631 VA: 0x1A73530
	private string get_CanvasName() { }

	// RVA: 0x1A735B0 Offset: 0x1A736B1 VA: 0x1A735B0
	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	// RVA: 0x1A737A0 Offset: 0x1A738A1 VA: 0x1A737A0
	private CinemachineStoryboard.CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	// RVA: 0x1A73BF0 Offset: 0x1A73CF1 VA: 0x1A73BF0
	private void CreateCanvas(CinemachineStoryboard.CanvasInfo ci) { }

	// RVA: 0x1A732A0 Offset: 0x1A733A1 VA: 0x1A732A0
	private void DestroyCanvas() { }

	// RVA: 0x1A740E0 Offset: 0x1A741E1 VA: 0x1A740E0
	private void PlaceImage(CinemachineStoryboard.CanvasInfo ci, float alpha) { }

	// RVA: 0x1A745C0 Offset: 0x1A746C1 VA: 0x1A745C0
	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x236A0 Offset: 0x237A1 VA: 0x236A0
	// RVA: 0x1A747C0 Offset: 0x1A748C1 VA: 0x1A747C0
	private static void InitializeModule() { }

	// RVA: 0x1A74900 Offset: 0x1A74A01 VA: 0x1A74900
	public void .ctor() { }
}

