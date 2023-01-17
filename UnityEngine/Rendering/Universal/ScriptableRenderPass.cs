// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47F2E0 Offset: 0x47F3E1 VA: 0x47F2E0
public abstract class ScriptableRenderPass // TypeDefIndex: 5267
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x481270 Offset: 0x481371 VA: 0x481270
	private RenderPassEvent <renderPassEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x481280 Offset: 0x481381 VA: 0x481280
	private ProfilingSampler <profilingSampler>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x481290 Offset: 0x481391 VA: 0x481290
	private bool <overrideCameraTarget>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x4812A0 Offset: 0x4813A1 VA: 0x4812A0
	private bool <isBlitRenderPass>k__BackingField; // 0x21
	private RenderTargetIdentifier[] m_ColorAttachments; // 0x28
	private RenderTargetIdentifier m_DepthAttachment; // 0x30
	private ScriptableRenderPassInput m_Input; // 0x58
	private ClearFlag m_ClearFlag; // 0x5C
	private Color m_ClearColor; // 0x60

	// Properties
	public RenderPassEvent renderPassEvent { get; set; }
	public RenderTargetIdentifier[] colorAttachments { get; }
	public RenderTargetIdentifier colorAttachment { get; }
	public RenderTargetIdentifier depthAttachment { get; }
	public ScriptableRenderPassInput input { get; }
	public ClearFlag clearFlag { get; }
	public Color clearColor { get; }
	protected internal ProfilingSampler profilingSampler { get; set; }
	internal bool overrideCameraTarget { get; set; }
	internal bool isBlitRenderPass { get; set; }

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x484430 Offset: 0x484531 VA: 0x484430
	// RVA: 0x3127580 Offset: 0x3127681 VA: 0x3127580 Slot: 4
	public virtual void FrameCleanup(CommandBuffer cmd) { }

	[CompilerGeneratedAttribute] // RVA: 0x484450 Offset: 0x484551 VA: 0x484450
	// RVA: 0x3127590 Offset: 0x3127691 VA: 0x3127590
	public RenderPassEvent get_renderPassEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x484460 Offset: 0x484561 VA: 0x484460
	// RVA: 0x31275A0 Offset: 0x31276A1 VA: 0x31275A0
	public void set_renderPassEvent(RenderPassEvent value) { }

	// RVA: 0x31275B0 Offset: 0x31276B1 VA: 0x31275B0
	public RenderTargetIdentifier[] get_colorAttachments() { }

	// RVA: 0x31275C0 Offset: 0x31276C1 VA: 0x31275C0
	public RenderTargetIdentifier get_colorAttachment() { }

	// RVA: 0x3127600 Offset: 0x3127701 VA: 0x3127600
	public RenderTargetIdentifier get_depthAttachment() { }

	// RVA: 0x3127620 Offset: 0x3127721 VA: 0x3127620
	public ScriptableRenderPassInput get_input() { }

	// RVA: 0x3127630 Offset: 0x3127731 VA: 0x3127630
	public ClearFlag get_clearFlag() { }

	// RVA: 0x3127640 Offset: 0x3127741 VA: 0x3127640
	public Color get_clearColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x484470 Offset: 0x484571 VA: 0x484470
	// RVA: 0x3127650 Offset: 0x3127751 VA: 0x3127650
	protected internal ProfilingSampler get_profilingSampler() { }

	[CompilerGeneratedAttribute] // RVA: 0x484480 Offset: 0x484581 VA: 0x484480
	// RVA: 0x3127660 Offset: 0x3127761 VA: 0x3127660
	protected internal void set_profilingSampler(ProfilingSampler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484490 Offset: 0x484591 VA: 0x484490
	// RVA: 0x3127670 Offset: 0x3127771 VA: 0x3127670
	internal bool get_overrideCameraTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x4844A0 Offset: 0x4845A1 VA: 0x4844A0
	// RVA: 0x3127680 Offset: 0x3127781 VA: 0x3127680
	internal void set_overrideCameraTarget(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4844B0 Offset: 0x4845B1 VA: 0x4844B0
	// RVA: 0x3127690 Offset: 0x3127791 VA: 0x3127690
	internal bool get_isBlitRenderPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x4844C0 Offset: 0x4845C1 VA: 0x4844C0
	// RVA: 0x31276A0 Offset: 0x31277A1 VA: 0x31276A0
	internal void set_isBlitRenderPass(bool value) { }

	// RVA: 0x31259D0 Offset: 0x3125AD1 VA: 0x31259D0
	public void .ctor() { }

	// RVA: 0x31276B0 Offset: 0x31277B1 VA: 0x31276B0
	public void ConfigureInput(ScriptableRenderPassInput passInput) { }

	// RVA: 0x31276C0 Offset: 0x31277C1 VA: 0x31276C0
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment) { }

	// RVA: 0x3127720 Offset: 0x3127821 VA: 0x3127720
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment) { }

	// RVA: 0x3126D30 Offset: 0x3126E31 VA: 0x3126D30
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment) { }

	// RVA: 0x3127860 Offset: 0x3127961 VA: 0x3127860
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments) { }

	// RVA: 0x3126E30 Offset: 0x3126F31 VA: 0x3126E30
	public void ConfigureClear(ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x31278C0 Offset: 0x31279C1 VA: 0x31278C0 Slot: 5
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x31278D0 Offset: 0x31279D1 VA: 0x31278D0 Slot: 6
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x31278E0 Offset: 0x31279E1 VA: 0x31278E0 Slot: 7
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x31278F0 Offset: 0x31279F1 VA: 0x31278F0 Slot: 8
	public virtual void OnFinishCameraStackRendering(CommandBuffer cmd) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData);

	// RVA: 0x3127360 Offset: 0x3127461 VA: 0x3127360
	public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex = 0) { }

	// RVA: 0x3127BC0 Offset: 0x3127CC1 VA: 0x3127BC0
	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	// RVA: 0x3127D00 Offset: 0x3127E01 VA: 0x3127D00
	public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	// RVA: 0x3128060 Offset: 0x3128161 VA: 0x3128060
	public static bool op_LessThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	// RVA: 0x3128080 Offset: 0x3128181 VA: 0x3128080
	public static bool op_GreaterThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }
}

