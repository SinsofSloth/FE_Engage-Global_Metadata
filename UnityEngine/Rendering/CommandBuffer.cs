// Namespace: UnityEngine.Rendering
[NativeTypeAttribute] // RVA: 0x4409F0 Offset: 0x440AF1 VA: 0x4409F0
[NativeHeaderAttribute] // RVA: 0x4409F0 Offset: 0x440AF1 VA: 0x4409F0
[NativeHeaderAttribute] // RVA: 0x4409F0 Offset: 0x440AF1 VA: 0x4409F0
[UsedByNativeCodeAttribute] // RVA: 0x4409F0 Offset: 0x440AF1 VA: 0x4409F0
[NativeHeaderAttribute] // RVA: 0x4409F0 Offset: 0x440AF1 VA: 0x4409F0
public class CommandBuffer : IDisposable // TypeDefIndex: 3920
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x453240 Offset: 0x453341 VA: 0x453240
	// RVA: 0x2F162B0 Offset: 0x2F163B1 VA: 0x2F162B0
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x453290 Offset: 0x453391 VA: 0x453290
	// RVA: 0x2F16300 Offset: 0x2F16401 VA: 0x2F16300
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x4532D0 Offset: 0x4533D1 VA: 0x4532D0
	// RVA: 0x2F16340 Offset: 0x2F16441 VA: 0x2F16340
	private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[FreeFunctionAttribute] // RVA: 0x453320 Offset: 0x453421 VA: 0x453320
	// RVA: 0x2F163A0 Offset: 0x2F164A1 VA: 0x2F163A0
	private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage) { }

	[FreeFunctionAttribute] // RVA: 0x453370 Offset: 0x453471 VA: 0x453370
	// RVA: 0x2F16400 Offset: 0x2F16501 VA: 0x2F16400
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x4533C0 Offset: 0x4534C1 VA: 0x4533C0
	// RVA: 0x2F16450 Offset: 0x2F16551 VA: 0x2F16450
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x453410 Offset: 0x453511 VA: 0x453410
	// RVA: 0x2F164E0 Offset: 0x2F165E1 VA: 0x2F164E0
	private void Internal_SetComputeConstantComputeBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[FreeFunctionAttribute] // RVA: 0x453460 Offset: 0x453561 VA: 0x453460
	// RVA: 0x2F16560 Offset: 0x2F16661 VA: 0x2F16560
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x2F165E0 Offset: 0x2F166E1 VA: 0x2F165E0
	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x4534B0 Offset: 0x4535B1 VA: 0x4534B0
	// RVA: 0x2F16630 Offset: 0x2F16731 VA: 0x2F16630
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x4534F0 Offset: 0x4535F1 VA: 0x4534F0
	// RVA: 0x2F16680 Offset: 0x2F16781 VA: 0x2F16680
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x453540 Offset: 0x453641 VA: 0x453540
	// RVA: 0x2F167A0 Offset: 0x2F168A1 VA: 0x2F167A0
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[NativeMethodAttribute] // RVA: 0x453580 Offset: 0x453681 VA: 0x453580
	// RVA: 0x2F16810 Offset: 0x2F16911 VA: 0x2F16810
	private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x4535C0 Offset: 0x4536C1 VA: 0x4535C0
	// RVA: 0x2F16950 Offset: 0x2F16A51 VA: 0x2F16950
	private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[FreeFunctionAttribute] // RVA: 0x453610 Offset: 0x453711 VA: 0x453610
	// RVA: 0x2F16A00 Offset: 0x2F16B01 VA: 0x2F16A00
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x453660 Offset: 0x453761 VA: 0x453660
	// RVA: 0x2F16AB0 Offset: 0x2F16BB1 VA: 0x2F16AB0
	public void EnableScissorRect(Rect scissor) { }

	[FreeFunctionAttribute] // RVA: 0x4536B0 Offset: 0x4537B1 VA: 0x4536B0
	// RVA: 0x2F16B60 Offset: 0x2F16C61 VA: 0x2F16B60
	public void DisableScissorRect() { }

	[FreeFunctionAttribute] // RVA: 0x453700 Offset: 0x453801 VA: 0x453700
	// RVA: 0x2F16BB0 Offset: 0x2F16CB1 VA: 0x2F16BB0
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x453750 Offset: 0x453851 VA: 0x453750
	// RVA: 0x2F16D00 Offset: 0x2F16E01 VA: 0x2F16D00
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x2F16DD0 Offset: 0x2F16ED1 VA: 0x2F16DD0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x2F16F50 Offset: 0x2F17051 VA: 0x2F16F50
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x2F17060 Offset: 0x2F17161 VA: 0x2F17060
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x2F17170 Offset: 0x2F17271 VA: 0x2F17170
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x2F17280 Offset: 0x2F17381 VA: 0x2F17280
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x4537A0 Offset: 0x4538A1 VA: 0x4537A0
	// RVA: 0x2F17380 Offset: 0x2F17481 VA: 0x2F17380
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x2F17460 Offset: 0x2F17561 VA: 0x2F17460
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x2F174F0 Offset: 0x2F175F1 VA: 0x2F174F0
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x4537F0 Offset: 0x4538F1 VA: 0x4537F0
	// RVA: 0x2F17580 Offset: 0x2F17681 VA: 0x2F17580
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x453840 Offset: 0x453941 VA: 0x453840
	// RVA: 0x2F175D0 Offset: 0x2F176D1 VA: 0x2F175D0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x2F176D0 Offset: 0x2F177D1 VA: 0x2F176D0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x453890 Offset: 0x453991 VA: 0x453890
	// RVA: 0x2F17800 Offset: 0x2F17901 VA: 0x2F17800
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x4538E0 Offset: 0x4539E1 VA: 0x4538E0
	// RVA: 0x2F17860 Offset: 0x2F17961 VA: 0x2F17860
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x453930 Offset: 0x453A31 VA: 0x453930
	// RVA: 0x2F178C0 Offset: 0x2F179C1 VA: 0x2F178C0
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x453980 Offset: 0x453A81 VA: 0x453980
	// RVA: 0x2F17990 Offset: 0x2F17A91 VA: 0x2F17990
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x4539D0 Offset: 0x453AD1 VA: 0x4539D0
	// RVA: 0x2F17A60 Offset: 0x2F17B61 VA: 0x2F17A60
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x453A20 Offset: 0x453B21 VA: 0x453A20
	// RVA: 0x2F17B20 Offset: 0x2F17C21 VA: 0x2F17B20
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x453A70 Offset: 0x453B71 VA: 0x453A70
	// RVA: 0x2F17B70 Offset: 0x2F17C71 VA: 0x2F17B70
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x453AC0 Offset: 0x453BC1 VA: 0x453AC0
	// RVA: 0x2F17BC0 Offset: 0x2F17CC1 VA: 0x2F17BC0
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x453B10 Offset: 0x453C11 VA: 0x453B10
	// RVA: 0x2F17C80 Offset: 0x2F17D81 VA: 0x2F17C80
	public void SetExecutionFlags(CommandBufferExecutionFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x453B60 Offset: 0x453C61 VA: 0x453B60
	// RVA: 0x2F177A0 Offset: 0x2F178A1 VA: 0x2F177A0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x453BB0 Offset: 0x453CB1 VA: 0x453BB0
	// RVA: 0x2F17CD0 Offset: 0x2F17DD1 VA: 0x2F17CD0
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x453C00 Offset: 0x453D01 VA: 0x453C00
	// RVA: 0x2F17D30 Offset: 0x2F17E31 VA: 0x2F17D30
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x453C50 Offset: 0x453D51 VA: 0x453C50
	// RVA: 0x2F17D90 Offset: 0x2F17E91 VA: 0x2F17D90
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x453CA0 Offset: 0x453DA1 VA: 0x453CA0
	// RVA: 0x2F17E00 Offset: 0x2F17F01 VA: 0x2F17E00
	private void SetGlobalBufferInternal(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x453CF0 Offset: 0x453DF1 VA: 0x453CF0
	// RVA: 0x2F17E60 Offset: 0x2F17F61 VA: 0x2F17E60
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x453D40 Offset: 0x453E41 VA: 0x453D40
	// RVA: 0x2F17EB0 Offset: 0x2F17FB1 VA: 0x2F17EB0
	public void EndSample(string name) { }

	// RVA: 0x2F17F00 Offset: 0x2F18001 VA: 0x2F17F00
	public void BeginSample(CustomSampler sampler) { }

	// RVA: 0x2F17FA0 Offset: 0x2F180A1 VA: 0x2F17FA0
	public void EndSample(CustomSampler sampler) { }

	[FreeFunctionAttribute] // RVA: 0x453D90 Offset: 0x453E91 VA: 0x453D90
	// RVA: 0x2F17F50 Offset: 0x2F18051 VA: 0x2F17F50
	private void BeginSample_CustomSampler(CustomSampler sampler) { }

	[FreeFunctionAttribute] // RVA: 0x453DE0 Offset: 0x453EE1 VA: 0x453DE0
	// RVA: 0x2F17FF0 Offset: 0x2F180F1 VA: 0x2F17FF0
	private void EndSample_CustomSampler(CustomSampler sampler) { }

	[FreeFunctionAttribute] // RVA: 0x453E30 Offset: 0x453F31 VA: 0x453E30
	// RVA: 0x2F18040 Offset: 0x2F18141 VA: 0x2F18040
	private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[FreeFunctionAttribute] // RVA: 0x453E80 Offset: 0x453F81 VA: 0x453E80
	// RVA: 0x2F180B0 Offset: 0x2F181B1 VA: 0x2F180B0
	public void SetInstanceMultiplier(uint multiplier) { }

	// RVA: 0x2F18100 Offset: 0x2F18201 VA: 0x2F18100
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x2F18240 Offset: 0x2F18341 VA: 0x2F18240
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	// RVA: 0x2F18360 Offset: 0x2F18461 VA: 0x2F18360
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2F18490 Offset: 0x2F18591 VA: 0x2F18490
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2F18640 Offset: 0x2F18741 VA: 0x2F18640
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x2F187C0 Offset: 0x2F188C1 VA: 0x2F187C0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2F189A0 Offset: 0x2F18AA1 VA: 0x2F189A0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2F18AF0 Offset: 0x2F18BF1 VA: 0x2F18AF0
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2F181C0 Offset: 0x2F182C1 VA: 0x2F181C0
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2F18720 Offset: 0x2F18821 VA: 0x2F18720
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x2F18CD0 Offset: 0x2F18DD1 VA: 0x2F18CD0
	private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2F18F50 Offset: 0x2F19051 VA: 0x2F18F50
	public void SetComputeBufferData(ComputeBuffer buffer, Array data) { }

	[FreeFunctionAttribute] // RVA: 0x453ED0 Offset: 0x453FD1 VA: 0x453ED0
	// RVA: 0x2F190C0 Offset: 0x2F191C1 VA: 0x2F190C0
	private void InternalSetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x2F19150 Offset: 0x2F19251 VA: 0x2F19150 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F19270 Offset: 0x2F19371 VA: 0x2F19270 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F19200 Offset: 0x2F19301 VA: 0x2F19200
	private void Dispose(bool disposing) { }

	// RVA: 0x2F19330 Offset: 0x2F19431 VA: 0x2F19330
	public void .ctor() { }

	// RVA: 0x2F19380 Offset: 0x2F19481 VA: 0x2F19380
	public GraphicsFence CreateAsyncGraphicsFence() { }

	// RVA: 0x2F19390 Offset: 0x2F19491 VA: 0x2F19390
	public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	// RVA: 0x2F195F0 Offset: 0x2F196F1 VA: 0x2F195F0
	public void WaitOnAsyncGraphicsFence(GraphicsFence fence) { }

	// RVA: 0x2F19600 Offset: 0x2F19701 VA: 0x2F19600
	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage) { }

	// RVA: 0x2F19620 Offset: 0x2F19721 VA: 0x2F19620
	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage) { }

	// RVA: 0x2F19860 Offset: 0x2F19961 VA: 0x2F19860
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	// RVA: 0x2F198F0 Offset: 0x2F199F1 VA: 0x2F198F0
	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	// RVA: 0x2F19970 Offset: 0x2F19A71 VA: 0x2F19970
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x2F199F0 Offset: 0x2F19AF1 VA: 0x2F199F0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x2F19C90 Offset: 0x2F19D91 VA: 0x2F19C90
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x2F19CE0 Offset: 0x2F19DE1 VA: 0x2F19CE0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x2F19D30 Offset: 0x2F19E31 VA: 0x2F19D30
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	// RVA: 0x2F19D80 Offset: 0x2F19E81 VA: 0x2F19D80
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x2F19FC0 Offset: 0x2F1A0C1 VA: 0x2F19FC0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x2F19FD0 Offset: 0x2F1A0D1 VA: 0x2F19FD0
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x2F19FE0 Offset: 0x2F1A0E1 VA: 0x2F19FE0
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	// RVA: 0x2F1A170 Offset: 0x2F1A271 VA: 0x2F1A170
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	// RVA: 0x2F1A1C0 Offset: 0x2F1A2C1 VA: 0x2F1A1C0
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount) { }

	// RVA: 0x2F1A210 Offset: 0x2F1A311 VA: 0x2F1A210
	public void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	// RVA: 0x2F1A270 Offset: 0x2F1A371 VA: 0x2F1A270
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x2F1A340 Offset: 0x2F1A441 VA: 0x2F1A340
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x2F1A420 Offset: 0x2F1A521 VA: 0x2F1A420
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x2F1A4C0 Offset: 0x2F1A5C1 VA: 0x2F1A4C0
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	// RVA: 0x2F1A530 Offset: 0x2F1A631 VA: 0x2F1A530
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x2F1A630 Offset: 0x2F1A731 VA: 0x2F1A630
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x2F1A5C0 Offset: 0x2F1A6C1 VA: 0x2F1A5C0
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x2F1A690 Offset: 0x2F1A791 VA: 0x2F1A690
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x2F1A6F0 Offset: 0x2F1A7F1 VA: 0x2F1A6F0
	public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	// RVA: 0x2F1A760 Offset: 0x2F1A861 VA: 0x2F1A760
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	// RVA: 0x2F16710 Offset: 0x2F16811 VA: 0x2F16710
	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x2F168B0 Offset: 0x2F169B1 VA: 0x2F168B0
	private void Internal_DrawProcedural_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	// RVA: 0x2F169B0 Offset: 0x2F16AB1 VA: 0x2F169B0
	private void Internal_DrawOcclusionMesh_Injected(ref RectInt normalizedCamViewport) { }

	// RVA: 0x2F16A60 Offset: 0x2F16B61 VA: 0x2F16A60
	private void SetViewport_Injected(ref Rect pixelRect) { }

	// RVA: 0x2F16B10 Offset: 0x2F16C11 VA: 0x2F16B10
	private void EnableScissorRect_Injected(ref Rect scissor) { }

	// RVA: 0x2F16C60 Offset: 0x2F16D61 VA: 0x2F16C60
	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x2F173F0 Offset: 0x2F174F1 VA: 0x2F173F0
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x2F17650 Offset: 0x2F17751 VA: 0x2F17650
	private void ClearRenderTarget_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x2F17930 Offset: 0x2F17A31 VA: 0x2F17930
	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x2F17A00 Offset: 0x2F17B01 VA: 0x2F17A00
	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	// RVA: 0x2F17AC0 Offset: 0x2F17BC1 VA: 0x2F17AC0
	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	// RVA: 0x2F17C20 Offset: 0x2F17D21 VA: 0x2F17C20
	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0x2F18D80 Offset: 0x2F18E81 VA: 0x2F18D80
	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2F18E00 Offset: 0x2F18F01 VA: 0x2F18E00
	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x2F18EA0 Offset: 0x2F18FA1 VA: 0x2F18EA0
	private void SetRenderTargetMultiSubtarget_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }
}

