// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct RenderGraphBuilder : IDisposable // TypeDefIndex: 4475
{
	// Fields
	private RenderGraphPass m_RenderPass; // 0x0
	private RenderGraphResourceRegistry m_Resources; // 0x8
	private RenderGraph m_RenderGraph; // 0x10
	private bool m_Disposed; // 0x18

	// Methods

	// RVA: 0x1A1FB10 Offset: 0x1A1FC11 VA: 0x1A1FB10
	public TextureHandle UseColorBuffer(in TextureHandle input, int index) { }

	// RVA: 0x1A1FB50 Offset: 0x1A1FC51 VA: 0x1A1FB50
	public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags) { }

	// RVA: 0x1A1FB80 Offset: 0x1A1FC81 VA: 0x1A1FB80
	public TextureHandle ReadTexture(in TextureHandle input) { }

	// RVA: 0x1A1FBB0 Offset: 0x1A1FCB1 VA: 0x1A1FBB0
	public TextureHandle WriteTexture(in TextureHandle input) { }

	// RVA: 0x1A1FBE0 Offset: 0x1A1FCE1 VA: 0x1A1FBE0
	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	// RVA: 0x1A1FC30 Offset: 0x1A1FD31 VA: 0x1A1FC30
	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	// RVA: 0x1A1FCF0 Offset: 0x1A1FDF1 VA: 0x1A1FCF0
	public RendererListHandle UseRendererList(in RendererListHandle input) { }

	// RVA: 0x1A1FD20 Offset: 0x1A1FE21 VA: 0x1A1FD20
	public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input) { }

	// RVA: 0x1A1FD50 Offset: 0x1A1FE51 VA: 0x1A1FD50
	public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input) { }

	// RVA: 0x1A1FD80 Offset: 0x1A1FE81 VA: 0x1A1FD80
	public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc) { }

	// RVA: 0x1A1FDD0 Offset: 0x1A1FED1 VA: 0x1A1FDD0
	public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer) { }

	// RVA: -1 Offset: -1
	public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015EB0 Offset: 0x2015FB1 VA: 0x2015EB0
	|-RenderGraphBuilder.SetRenderFunc<object>
	|-RenderGraphBuilder.SetRenderFunc<RenderGraph.ProfilingScopePassData>
	*/

	// RVA: 0x1A1FE50 Offset: 0x1A1FF51 VA: 0x1A1FE50
	public void EnableAsyncCompute(bool value) { }

	// RVA: 0x1A1A6F0 Offset: 0x1A1A7F1 VA: 0x1A1A6F0
	public void AllowPassCulling(bool value) { }

	// RVA: 0x1A1A710 Offset: 0x1A1A811 VA: 0x1A1A710 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A1FED0 Offset: 0x1A1FFD1 VA: 0x1A1FED0
	internal void .ctor(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) { }

	// RVA: 0x1A1FE60 Offset: 0x1A1FF61 VA: 0x1A1FE60
	private void Dispose(bool disposing) { }

	// RVA: 0x1A1FB40 Offset: 0x1A1FC41 VA: 0x1A1FB40
	private void CheckResource(in ResourceHandle res) { }

	// RVA: 0x1A1A700 Offset: 0x1A1A801 VA: 0x1A1A700
	internal void GenerateDebugData(bool value) { }
}

