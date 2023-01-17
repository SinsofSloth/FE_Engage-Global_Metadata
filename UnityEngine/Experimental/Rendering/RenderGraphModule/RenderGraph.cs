// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public class RenderGraph // TypeDefIndex: 4473
{
	// Fields
	public static readonly int kMaxMRTCount; // 0x0
	private RenderGraphResourceRegistry m_Resources; // 0x10
	private RenderGraphObjectPool m_RenderGraphPool; // 0x18
	private List<RenderGraphPass> m_RenderPasses; // 0x20
	private List<RendererListHandle> m_RendererLists; // 0x28
	private RenderGraphDebugParams m_DebugParameters; // 0x30
	private RenderGraphLogger m_Logger; // 0x38
	private RenderGraphDefaultResources m_DefaultResources; // 0x40
	private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers; // 0x48
	private bool m_ExecutionExceptionWasRaised; // 0x50
	private RenderGraphContext m_RenderGraphContext; // 0x58
	private CommandBuffer m_PreviousCommandBuffer; // 0x60
	private int m_CurrentImmediatePassIndex; // 0x68
	private List<int>[] m_ImmediateModeResourceList; // 0x70
	private DynamicArray<RenderGraph.CompiledResourceInfo>[] m_CompiledResourcesInfos; // 0x78
	private DynamicArray<RenderGraph.CompiledPassInfo> m_CompiledPassInfos; // 0x80
	private Stack<int> m_CullingStack; // 0x88
	private int m_ExecutionCount; // 0x90
	private RenderGraphDebugData m_RenderGraphDebugData; // 0x98
	private static List<RenderGraph> s_RegisteredGraphs; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x3C650 Offset: 0x3C751 VA: 0x3C650
	private string <name>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x3C660 Offset: 0x3C761 VA: 0x3C660
	private static bool <requireDebugData>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x3C670 Offset: 0x3C771 VA: 0x3C670
	private static RenderGraph.OnGraphRegisteredDelegate onGraphRegistered; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x3C680 Offset: 0x3C781 VA: 0x3C680
	private static RenderGraph.OnGraphRegisteredDelegate onGraphUnregistered; // 0x20

	// Properties
	public string name { get; set; }
	internal static bool requireDebugData { get; set; }
	public RenderGraphDefaultResources defaultResources { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D1F0 Offset: 0x3D2F1 VA: 0x3D1F0
	// RVA: 0x1A171C0 Offset: 0x1A172C1 VA: 0x1A171C0
	public string get_name() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D200 Offset: 0x3D301 VA: 0x3D200
	// RVA: 0x1A171D0 Offset: 0x1A172D1 VA: 0x1A171D0
	private void set_name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D210 Offset: 0x3D311 VA: 0x3D210
	// RVA: 0x1A171E0 Offset: 0x1A172E1 VA: 0x1A171E0
	internal static bool get_requireDebugData() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D220 Offset: 0x3D321 VA: 0x3D220
	// RVA: 0x1A17250 Offset: 0x1A17351 VA: 0x1A17250
	internal static void set_requireDebugData(bool value) { }

	// RVA: 0x1A172D0 Offset: 0x1A173D1 VA: 0x1A172D0
	public RenderGraphDefaultResources get_defaultResources() { }

	// RVA: 0x1A172E0 Offset: 0x1A173E1 VA: 0x1A172E0
	public void .ctor(string name = "RenderGraph") { }

	// RVA: 0x1A18220 Offset: 0x1A18321 VA: 0x1A18220
	public void Cleanup() { }

	// RVA: 0x1A18450 Offset: 0x1A18551 VA: 0x1A18450
	internal RenderGraphDebugData GetDebugData() { }

	// RVA: 0x1A18460 Offset: 0x1A18561 VA: 0x1A18460
	public void EndFrame() { }

	// RVA: 0x1A184A0 Offset: 0x1A185A1 VA: 0x1A184A0
	public TextureHandle ImportTexture(RTHandle rt) { }

	// RVA: 0x1A184B0 Offset: 0x1A185B1 VA: 0x1A184B0
	public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	// RVA: 0x1A184F0 Offset: 0x1A185F1 VA: 0x1A184F0
	public TextureHandle CreateTexture(in TextureDesc desc) { }

	// RVA: 0x1A18500 Offset: 0x1A18601 VA: 0x1A18500
	public TextureHandle CreateTexture(TextureHandle texture) { }

	// RVA: 0x1A185B0 Offset: 0x1A186B1 VA: 0x1A185B0
	public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture) { }

	// RVA: 0x1A18610 Offset: 0x1A18711 VA: 0x1A18610
	public TextureDesc GetTextureDesc(TextureHandle texture) { }

	// RVA: 0x1A18690 Offset: 0x1A18791 VA: 0x1A18690
	public RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	// RVA: 0x1A186A0 Offset: 0x1A187A1 VA: 0x1A186A0
	public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) { }

	// RVA: 0x1A186B0 Offset: 0x1A187B1 VA: 0x1A186B0
	public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc) { }

	// RVA: 0x1A186C0 Offset: 0x1A187C1 VA: 0x1A186C0
	public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer) { }

	// RVA: 0x1A18720 Offset: 0x1A18821 VA: 0x1A18720
	public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer) { }

	// RVA: -1 Offset: -1
	public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015D80 Offset: 0x2015E81 VA: 0x2015D80
	|-RenderGraph.AddRenderPass<object>
	|-RenderGraph.AddRenderPass<RenderGraph.ProfilingScopePassData>
	*/

	// RVA: -1 Offset: -1
	public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015D00 Offset: 0x2015E01 VA: 0x2015D00
	|-RenderGraph.AddRenderPass<object>
	*/

	// RVA: 0x1A18770 Offset: 0x1A18871 VA: 0x1A18770
	public void Begin(in RenderGraphParameters parameters) { }

	// RVA: 0x1A18EA0 Offset: 0x1A18FA1 VA: 0x1A18EA0
	public void Execute() { }

	// RVA: 0x1A1A450 Offset: 0x1A1A551 VA: 0x1A1A450
	public void BeginProfilingSampler(ProfilingSampler sampler) { }

	// RVA: 0x1A1A780 Offset: 0x1A1A881 VA: 0x1A1A780
	public void EndProfilingSampler(ProfilingSampler sampler) { }

	// RVA: 0x1A1AA20 Offset: 0x1A1AB21 VA: 0x1A1AA20
	internal static List<RenderGraph> GetRegisteredRenderGraphs() { }

	// RVA: 0x1A1AA90 Offset: 0x1A1AB91 VA: 0x1A1AA90
	internal DynamicArray<RenderGraph.CompiledPassInfo> GetCompiledPassInfos() { }

	// RVA: 0x1A1A310 Offset: 0x1A1A411 VA: 0x1A1A310
	internal void ClearCompiledGraph() { }

	// RVA: 0x1A1A400 Offset: 0x1A1A501 VA: 0x1A1A400
	private void InvalidateContext() { }

	// RVA: 0x1A1ABE0 Offset: 0x1A1ACE1 VA: 0x1A1ABE0
	internal void OnPassAdded(RenderGraphPass pass) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D230 Offset: 0x3D331 VA: 0x3D230
	// RVA: 0x1A1AC60 Offset: 0x1A1AD61 VA: 0x1A1AC60
	internal static void add_onGraphRegistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D240 Offset: 0x3D341 VA: 0x3D240
	// RVA: 0x1A1AD60 Offset: 0x1A1AE61 VA: 0x1A1AD60
	internal static void remove_onGraphRegistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D250 Offset: 0x3D351 VA: 0x3D250
	// RVA: 0x1A1AE60 Offset: 0x1A1AF61 VA: 0x1A1AE60
	internal static void add_onGraphUnregistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D260 Offset: 0x3D361 VA: 0x3D260
	// RVA: 0x1A1AF60 Offset: 0x1A1B061 VA: 0x1A1AF60
	internal static void remove_onGraphUnregistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	// RVA: 0x1A1B060 Offset: 0x1A1B161 VA: 0x1A1B060
	private void InitResourceInfosData(DynamicArray<RenderGraph.CompiledResourceInfo> resourceInfos, int count) { }

	// RVA: 0x1A1B120 Offset: 0x1A1B221 VA: 0x1A1B120
	private void InitializeCompilationData() { }

	// RVA: 0x1A1B2A0 Offset: 0x1A1B3A1 VA: 0x1A1B2A0
	private void CountReferences() { }

	// RVA: 0x1A1B8D0 Offset: 0x1A1B9D1 VA: 0x1A1B8D0
	private void CullOutputlessPasses() { }

	// RVA: 0x1A1BD00 Offset: 0x1A1BE01 VA: 0x1A1BD00
	private void CullUnusedPasses() { }

	// RVA: 0x1A1C9C0 Offset: 0x1A1CAC1 VA: 0x1A1C9C0
	private void UpdatePassSynchronization(ref RenderGraph.CompiledPassInfo currentPassInfo, ref RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex) { }

	// RVA: 0x1A1C9F0 Offset: 0x1A1CAF1 VA: 0x1A1C9F0
	private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in RenderGraph.CompiledResourceInfo resource) { }

	// RVA: 0x1A1CB20 Offset: 0x1A1CC21 VA: 0x1A1CB20
	private int GetLatestProducerIndex(int passIndex, in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x1A1CC90 Offset: 0x1A1CD91 VA: 0x1A1CC90
	private int GetLatestValidReadIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x1A1CD90 Offset: 0x1A1CE91 VA: 0x1A1CD90
	private int GetFirstValidWriteIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x1A1CE90 Offset: 0x1A1CF91 VA: 0x1A1CE90
	private int GetLatestValidWriteIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x1A1CF90 Offset: 0x1A1D091 VA: 0x1A1CF90
	private void UpdateResourceAllocationAndSynchronization() { }

	// RVA: 0x1A19310 Offset: 0x1A19411 VA: 0x1A19310
	internal void CompileRenderGraph() { }

	// RVA: 0x1A1D870 Offset: 0x1A1D971 VA: 0x1A1D870
	private ref RenderGraph.CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass) { }

	// RVA: 0x1A1AC30 Offset: 0x1A1AD31 VA: 0x1A1AC30
	private void ExecutePassImmediatly(RenderGraphPass pass) { }

	// RVA: 0x1A1DF60 Offset: 0x1A1E061 VA: 0x1A1DF60
	private void ExecuteCompiledPass(ref RenderGraph.CompiledPassInfo passInfo, int passIndex) { }

	// RVA: 0x1A19350 Offset: 0x1A19451 VA: 0x1A19350
	private void ExecuteRenderGraph() { }

	// RVA: 0x1A1EF40 Offset: 0x1A1F041 VA: 0x1A1EF40
	private void PreRenderPassSetRenderTargets(in RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x1A1E8A0 Offset: 0x1A1E9A1 VA: 0x1A1E8A0
	private void PreRenderPassExecute(in RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x1A1EBD0 Offset: 0x1A1ECD1 VA: 0x1A1EBD0
	private void PostRenderPassExecute(ref RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x1A1AAA0 Offset: 0x1A1ABA1 VA: 0x1A1AAA0
	private void ClearRenderPasses() { }

	// RVA: 0x1A1A0F0 Offset: 0x1A1A1F1 VA: 0x1A1A0F0
	private void ReleaseImmediateModeResources() { }

	// RVA: 0x1A18C20 Offset: 0x1A18D21 VA: 0x1A18C20
	private void LogFrameInformation() { }

	// RVA: 0x1A1D700 Offset: 0x1A1D801 VA: 0x1A1D700
	private void LogRendererListsCreation() { }

	// RVA: 0x1A1E380 Offset: 0x1A1E481 VA: 0x1A1E380
	private void LogRenderPassBegin(in RenderGraph.CompiledPassInfo passInfo) { }

	// RVA: 0x1A1C3E0 Offset: 0x1A1C4E1 VA: 0x1A1C3E0
	private void LogCulledPasses() { }

	// RVA: 0x1A1F610 Offset: 0x1A1F711 VA: 0x1A1F610
	private ProfilingSampler GetDefaultProfilingSampler(string name) { }

	// RVA: 0x1A1F6F0 Offset: 0x1A1F7F1 VA: 0x1A1F6F0
	private void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList) { }

	// RVA: 0x1A193F0 Offset: 0x1A194F1 VA: 0x1A193F0
	private void GenerateDebugData() { }

	// RVA: 0x1A1FA50 Offset: 0x1A1FB51 VA: 0x1A1FA50
	private static void .cctor() { }
}

