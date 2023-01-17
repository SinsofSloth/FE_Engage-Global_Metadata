// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47F390 Offset: 0x47F491 VA: 0x47F390
public abstract class ScriptableRenderer : IDisposable // TypeDefIndex: 5276
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x4812B0 Offset: 0x4813B1 VA: 0x4812B0
	private ProfilingSampler <profilingExecute>k__BackingField; // 0x10
	internal static ScriptableRenderer current; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x4812C0 Offset: 0x4813C1 VA: 0x4812C0
	private ScriptableRenderer.RenderingFeatures <supportedRenderingFeatures>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x4812D0 Offset: 0x4813D1 VA: 0x4812D0
	private GraphicsDeviceType[] <unsupportedGraphicsDeviceTypes>k__BackingField; // 0x20
	private const int k_RenderPassBlockCount = 4;
	private List<ScriptableRenderPass> m_ActiveRenderPassQueue; // 0x28
	private List<ScriptableRendererFeature> m_RendererFeatures; // 0x30
	private RenderTargetIdentifier m_CameraColorTarget; // 0x38
	private RenderTargetIdentifier m_CameraDepthTarget; // 0x60
	private bool m_FirstTimeCameraColorTargetIsBound; // 0x88
	private bool m_FirstTimeCameraDepthTargetIsBound; // 0x89
	private bool m_IsPipelineExecuting; // 0x8A
	internal bool isCameraColorTargetValid; // 0x8B
	private static RenderTargetIdentifier[] m_ActiveColorAttachments; // 0x8
	private static RenderTargetIdentifier m_ActiveDepthAttachment; // 0x10
	private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies; // 0x38

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x485590 Offset: 0x485691 VA: 0x485590
	[ObsoleteAttribute] // RVA: 0x485590 Offset: 0x485691 VA: 0x485590
	public RenderTargetIdentifier cameraDepth { get; }
	protected ProfilingSampler profilingExecute { get; set; }
	public RenderTargetIdentifier cameraColorTarget { get; }
	public RenderTargetIdentifier cameraDepthTarget { get; }
	protected List<ScriptableRendererFeature> rendererFeatures { get; }
	protected List<ScriptableRenderPass> activeRenderPassQueue { get; }
	public ScriptableRenderer.RenderingFeatures supportedRenderingFeatures { get; set; }
	public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes { get; set; }

	// Methods

	// RVA: 0x31280A0 Offset: 0x31281A1 VA: 0x31280A0
	public RenderTargetIdentifier get_cameraDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x4844D0 Offset: 0x4845D1 VA: 0x4844D0
	// RVA: 0x31280C0 Offset: 0x31281C1 VA: 0x31280C0
	protected ProfilingSampler get_profilingExecute() { }

	[CompilerGeneratedAttribute] // RVA: 0x4844E0 Offset: 0x4845E1 VA: 0x4844E0
	// RVA: 0x31280D0 Offset: 0x31281D1 VA: 0x31280D0
	protected void set_profilingExecute(ProfilingSampler value) { }

	// RVA: 0x31280E0 Offset: 0x31281E1 VA: 0x31280E0
	public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices) { }

	// RVA: 0x3128820 Offset: 0x3128921 VA: 0x3128820
	private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData) { }

	// RVA: 0x3128CD0 Offset: 0x3128DD1 VA: 0x3128CD0
	private void SetShaderTimeValues(CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime) { }

	// RVA: 0x3128F90 Offset: 0x3129091 VA: 0x3128F90
	public RenderTargetIdentifier get_cameraColorTarget() { }

	// RVA: 0x3129040 Offset: 0x3129141 VA: 0x3129040
	public RenderTargetIdentifier get_cameraDepthTarget() { }

	// RVA: 0x31290F0 Offset: 0x31291F1 VA: 0x31290F0
	protected List<ScriptableRendererFeature> get_rendererFeatures() { }

	// RVA: 0x3129100 Offset: 0x3129201 VA: 0x3129100
	protected List<ScriptableRenderPass> get_activeRenderPassQueue() { }

	[CompilerGeneratedAttribute] // RVA: 0x4844F0 Offset: 0x4845F1 VA: 0x4844F0
	// RVA: 0x3129110 Offset: 0x3129211 VA: 0x3129110
	public ScriptableRenderer.RenderingFeatures get_supportedRenderingFeatures() { }

	[CompilerGeneratedAttribute] // RVA: 0x484500 Offset: 0x484601 VA: 0x484500
	// RVA: 0x3129120 Offset: 0x3129221 VA: 0x3129120
	public void set_supportedRenderingFeatures(ScriptableRenderer.RenderingFeatures value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484510 Offset: 0x484611 VA: 0x484510
	// RVA: 0x3129130 Offset: 0x3129231 VA: 0x3129130
	public GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x484520 Offset: 0x484621 VA: 0x484520
	// RVA: 0x3129140 Offset: 0x3129241 VA: 0x3129140
	public void set_unsupportedGraphicsDeviceTypes(GraphicsDeviceType[] value) { }

	// RVA: 0x3129150 Offset: 0x3129251 VA: 0x3129150
	internal static void ConfigureActiveTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment) { }

	// RVA: 0x3129330 Offset: 0x3129431 VA: 0x3129330
	public void .ctor(ScriptableRendererData data) { }

	// RVA: 0x3129910 Offset: 0x3129A11 VA: 0x3129910 Slot: 4
	public void Dispose() { }

	// RVA: 0x3129B40 Offset: 0x3129C41 VA: 0x3129B40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3129B50 Offset: 0x3129C51 VA: 0x3129B50
	public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget) { }

	// RVA: 0x3129BA0 Offset: 0x3129CA1 VA: 0x3129BA0
	internal void ConfigureCameraColorTarget(RenderTargetIdentifier colorTarget) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Setup(ScriptableRenderContext context, ref RenderingData renderingData);

	// RVA: 0x3129BC0 Offset: 0x3129CC1 VA: 0x3129BC0 Slot: 7
	public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3129BD0 Offset: 0x3129CD1 VA: 0x3129BD0 Slot: 8
	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x3129BE0 Offset: 0x3129CE1 VA: 0x3129BE0 Slot: 9
	public virtual void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x3129BF0 Offset: 0x3129CF1 VA: 0x3129BF0 Slot: 10
	public virtual string GetSubLightTag() { }

	// RVA: 0x3129C00 Offset: 0x3129D01 VA: 0x3129C00
	public void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x31268F0 Offset: 0x31269F1 VA: 0x31268F0
	public void EnqueuePass(ScriptableRenderPass pass) { }

	// RVA: 0x312B520 Offset: 0x312B621 VA: 0x312B520
	protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData) { }

	// RVA: 0x312B610 Offset: 0x312B711 VA: 0x312B610
	protected void AddRenderPasses(ref RenderingData renderingData) { }

	// RVA: 0x312AC20 Offset: 0x312AD21 VA: 0x312AC20
	private void ClearRenderingState(CommandBuffer cmd) { }

	// RVA: 0x3129670 Offset: 0x3129771 VA: 0x3129670
	internal void Clear(CameraRenderType cameraType) { }

	// RVA: 0x312AFE0 Offset: 0x312B0E1 VA: 0x312AFE0
	private void ExecuteBlock(int blockIndex, in ScriptableRenderer.RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = False) { }

	// RVA: 0x312B820 Offset: 0x312B921 VA: 0x312B820
	private void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref RenderingData renderingData) { }

	// RVA: 0x312BB20 Offset: 0x312BC21 VA: 0x312BB20
	private void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, ref CameraData cameraData) { }

	// RVA: 0x312B130 Offset: 0x312B231 VA: 0x312B130
	private void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData) { }

	// RVA: 0x312B210 Offset: 0x312B311 VA: 0x312B210
	private void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData) { }

	// RVA: 0x3127900 Offset: 0x3127A01 VA: 0x3127900
	internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x312D230 Offset: 0x312D331 VA: 0x312D230
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor) { }

	// RVA: 0x312CF60 Offset: 0x312D061 VA: 0x312CF60
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor) { }

	// RVA: 0x312CDE0 Offset: 0x312CEE1 VA: 0x312CDE0
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	[ConditionalAttribute] // RVA: 0x484530 Offset: 0x484631 VA: 0x484530
	// RVA: 0x312D340 Offset: 0x312D441 VA: 0x312D340
	private void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset) { }

	[ConditionalAttribute] // RVA: 0x484570 Offset: 0x484671 VA: 0x484570
	// RVA: 0x312D350 Offset: 0x312D451 VA: 0x312D350
	private void DrawWireOverlay(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x312AA60 Offset: 0x312AB61 VA: 0x312AA60
	private void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x312B2F0 Offset: 0x312B3F1 VA: 0x312B2F0
	private void InternalFinishRendering(ScriptableRenderContext context, bool resolveFinalTarget) { }

	// RVA: 0x312AE80 Offset: 0x312AF81 VA: 0x312AE80
	internal static void SortStable(List<ScriptableRenderPass> list) { }

	// RVA: 0x312D380 Offset: 0x312D481 VA: 0x312D380
	private static void .cctor() { }
}

