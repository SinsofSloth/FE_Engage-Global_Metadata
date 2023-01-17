// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class RenderGraphResourceRegistry // TypeDefIndex: 4496
{
	// Fields
	private static readonly ShaderTagId s_EmptyName; // 0x0
	private static RenderGraphResourceRegistry m_CurrentRegistry; // 0x8
	private DynamicArray<RenderGraphResourceRegistry.IRenderGraphResource>[] m_Resources; // 0x10
	private TexturePool m_TexturePool; // 0x18
	private int m_TextureCreationIndex; // 0x20
	private ComputeBufferPool m_ComputeBufferPool; // 0x28
	private DynamicArray<RenderGraphResourceRegistry.RendererListResource> m_RendererListResources; // 0x30
	private RenderGraphDebugParams m_RenderGraphDebug; // 0x38
	private RenderGraphLogger m_Logger; // 0x40
	private int m_CurrentFrameIndex; // 0x48
	private RTHandle m_CurrentBackbuffer; // 0x50

	// Properties
	internal static RenderGraphResourceRegistry current { get; set; }

	// Methods

	// RVA: 0x35418D0 Offset: 0x35419D1 VA: 0x35418D0
	internal static RenderGraphResourceRegistry get_current() { }

	// RVA: 0x3541940 Offset: 0x3541A41 VA: 0x3541940
	internal static void set_current(RenderGraphResourceRegistry value) { }

	// RVA: 0x35419C0 Offset: 0x3541AC1 VA: 0x35419C0
	internal RTHandle GetTexture(in TextureHandle handle) { }

	// RVA: 0x3541C20 Offset: 0x3541D21 VA: 0x3541C20
	internal RendererList GetRendererList(in RendererListHandle handle) { }

	// RVA: 0x3541D00 Offset: 0x3541E01 VA: 0x3541D00
	internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle) { }

	// RVA: 0x3541E70 Offset: 0x3541F71 VA: 0x3541E70
	private void .ctor() { }

	// RVA: 0x3542040 Offset: 0x3542141 VA: 0x3542040
	internal void .ctor(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger logger) { }

	// RVA: 0x35422B0 Offset: 0x35423B1 VA: 0x35422B0
	internal void BeginRender(int currentFrameIndex, int executionCount) { }

	// RVA: 0x3542540 Offset: 0x3542641 VA: 0x3542540
	internal void EndRender() { }

	// RVA: 0x3542610 Offset: 0x3542711 VA: 0x3542610
	private void CheckHandleValidity(in ResourceHandle res) { }

	// RVA: 0x3542630 Offset: 0x3542731 VA: 0x3542630
	private void CheckHandleValidity(RenderGraphResourceType type, int index) { }

	// RVA: 0x3542750 Offset: 0x3542851 VA: 0x3542750
	internal string GetResourceName(in ResourceHandle res) { }

	// RVA: 0x3542800 Offset: 0x3542901 VA: 0x3542800
	internal string GetResourceName(RenderGraphResourceType type, int index) { }

	// RVA: 0x35428A0 Offset: 0x35429A1 VA: 0x35428A0
	internal bool IsResourceImported(in ResourceHandle res) { }

	// RVA: 0x3542950 Offset: 0x3542A51 VA: 0x3542950
	internal bool IsResourceCreated(in ResourceHandle res) { }

	// RVA: 0x3542A00 Offset: 0x3542B01 VA: 0x3542A00
	internal bool IsRendererListCreated(in RendererListHandle res) { }

	// RVA: 0x3542A70 Offset: 0x3542B71 VA: 0x3542A70
	internal bool IsResourceImported(RenderGraphResourceType type, int index) { }

	// RVA: 0x3542B10 Offset: 0x3542C11 VA: 0x3542B10
	internal int GetResourceTransientIndex(in ResourceHandle res) { }

	// RVA: 0x3542BC0 Offset: 0x3542CC1 VA: 0x3542BC0
	internal TextureHandle ImportTexture(RTHandle rt) { }

	// RVA: 0x3542D40 Offset: 0x3542E41 VA: 0x3542D40
	internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	// RVA: -1 Offset: -1
	private int AddNewResource<ResType>(DynamicArray<RenderGraphResourceRegistry.IRenderGraphResource> resourceArray, out ResType outRes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20166D0 Offset: 0x20167D1 VA: 0x20166D0
	|-RenderGraphResourceRegistry.AddNewResource<object>
	|-RenderGraphResourceRegistry.AddNewResource<RenderGraphResourceRegistry.ComputeBufferResource>
	|-RenderGraphResourceRegistry.AddNewResource<RenderGraphResourceRegistry.TextureResource>
	*/

	// RVA: 0x3542F10 Offset: 0x3543011 VA: 0x3542F10
	internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1) { }

	// RVA: 0x3543030 Offset: 0x3543131 VA: 0x3543030
	internal int GetTextureResourceCount() { }

	// RVA: 0x3541B10 Offset: 0x3541C11 VA: 0x3541B10
	private RenderGraphResourceRegistry.TextureResource GetTextureResource(in ResourceHandle handle) { }

	// RVA: 0x35430A0 Offset: 0x35431A1 VA: 0x35430A0
	internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle) { }

	// RVA: 0x35431E0 Offset: 0x35432E1 VA: 0x35431E0
	internal RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	// RVA: 0x3543320 Offset: 0x3543421 VA: 0x3543320
	internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) { }

	// RVA: 0x35433F0 Offset: 0x35434F1 VA: 0x35433F0
	internal ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc, int transientPassIndex = -1) { }

	// RVA: 0x35434D0 Offset: 0x35435D1 VA: 0x35434D0
	internal ComputeBufferDesc GetComputeBufferResourceDesc(in ResourceHandle handle) { }

	// RVA: 0x35435F0 Offset: 0x35436F1 VA: 0x35435F0
	internal int GetComputeBufferResourceCount() { }

	// RVA: 0x3541D60 Offset: 0x3541E61 VA: 0x3541D60
	private RenderGraphResourceRegistry.ComputeBufferResource GetComputeBufferResource(in ResourceHandle handle) { }

	// RVA: 0x3543650 Offset: 0x3543751 VA: 0x3543650
	internal void CreateAndClearTexture(RenderGraphContext rgContext, int index) { }

	// RVA: 0x3544040 Offset: 0x3544141 VA: 0x3544040
	internal void CreateComputeBuffer(RenderGraphContext rgContext, int index) { }

	// RVA: 0x3544470 Offset: 0x3544571 VA: 0x3544470
	internal void ReleaseTexture(RenderGraphContext rgContext, int index) { }

	// RVA: 0x35449A0 Offset: 0x3544AA1 VA: 0x35449A0
	internal void ReleaseComputeBuffer(RenderGraphContext rgContext, int index) { }

	// RVA: 0x3543020 Offset: 0x3543121 VA: 0x3543020
	private void ValidateTextureDesc(in TextureDesc desc) { }

	// RVA: 0x35432C0 Offset: 0x35433C1 VA: 0x35432C0
	private void ValidateRendererListDesc(in RendererListDesc desc) { }

	// RVA: 0x35434C0 Offset: 0x35435C1 VA: 0x35434C0
	private void ValidateComputeBufferDesc(in ComputeBufferDesc desc) { }

	// RVA: 0x3544CD0 Offset: 0x3544DD1 VA: 0x3544CD0
	internal void CreateRendererLists(List<RendererListHandle> rendererLists) { }

	// RVA: 0x3545420 Offset: 0x3545521 VA: 0x3545420
	internal void Clear(bool onException) { }

	// RVA: 0x3545750 Offset: 0x3545851 VA: 0x3545750
	internal void PurgeUnusedResources() { }

	// RVA: 0x3545790 Offset: 0x3545891 VA: 0x3545790
	internal void Cleanup() { }

	// RVA: 0x3543EC0 Offset: 0x3543FC1 VA: 0x3543EC0
	private void LogTextureCreation(RenderGraphResourceRegistry.TextureResource rt) { }

	// RVA: 0x3544860 Offset: 0x3544961 VA: 0x3544860
	private void LogTextureRelease(RenderGraphResourceRegistry.TextureResource rt) { }

	// RVA: 0x3544330 Offset: 0x3544431 VA: 0x3544330
	private void LogComputeBufferCreation(RenderGraphResourceRegistry.ComputeBufferResource buffer) { }

	// RVA: 0x3544B90 Offset: 0x3544C91 VA: 0x3544B90
	private void LogComputeBufferRelease(RenderGraphResourceRegistry.ComputeBufferResource buffer) { }

	// RVA: 0x3545530 Offset: 0x3545631 VA: 0x3545530
	private void LogResources() { }

	// RVA: 0x3545850 Offset: 0x3545951 VA: 0x3545850
	private static void .cctor() { }
}

