// Namespace: UnityEngine.Rendering
[NativeHeaderAttribute] // RVA: 0x440F10 Offset: 0x441011 VA: 0x440F10
[NativeHeaderAttribute] // RVA: 0x440F10 Offset: 0x441011 VA: 0x440F10
[NativeTypeAttribute] // RVA: 0x440F10 Offset: 0x441011 VA: 0x440F10
[NativeHeaderAttribute] // RVA: 0x440F10 Offset: 0x441011 VA: 0x440F10
[NativeHeaderAttribute] // RVA: 0x440F10 Offset: 0x441011 VA: 0x440F10
[NativeHeaderAttribute] // RVA: 0x440F10 Offset: 0x441011 VA: 0x440F10
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 3957
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x0

	// Methods

	[FreeFunctionAttribute] // RVA: 0x454330 Offset: 0x454431 VA: 0x454330
	// RVA: 0x31E4660 Offset: 0x31E4761 VA: 0x31E4660
	private static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	[FreeFunctionAttribute] // RVA: 0x454370 Offset: 0x454471 VA: 0x454370
	// RVA: 0x31E4780 Offset: 0x31E4881 VA: 0x31E4780
	internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) { }

	// RVA: 0x31E47D0 Offset: 0x31E48D1 VA: 0x31E47D0
	private void Submit_Internal() { }

	// RVA: 0x31E48C0 Offset: 0x31E49C1 VA: 0x31E48C0
	private int GetNumberOfCameras_Internal() { }

	// RVA: 0x31E49B0 Offset: 0x31E4AB1 VA: 0x31E49B0
	private Camera GetCamera_Internal(int index) { }

	// RVA: 0x31E4AA0 Offset: 0x31E4BA1 VA: 0x31E4AA0
	private void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x31E4C40 Offset: 0x31E4D41 VA: 0x31E4C40
	private void DrawShadows_Internal(IntPtr shadowDrawingSettings) { }

	[NativeThrowsAttribute] // RVA: 0x4543B0 Offset: 0x4544B1 VA: 0x4543B0
	// RVA: 0x31E4D30 Offset: 0x31E4E31 VA: 0x31E4D30
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	[NativeThrowsAttribute] // RVA: 0x4543C0 Offset: 0x4544C1 VA: 0x4543C0
	// RVA: 0x31E4E20 Offset: 0x31E4F21 VA: 0x31E4E20
	private void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	// RVA: 0x31E4F30 Offset: 0x31E5031 VA: 0x31E4F30
	private void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x31E5060 Offset: 0x31E5161 VA: 0x31E5060
	private void DrawSkybox_Internal(Camera camera) { }

	// RVA: 0x31E5150 Offset: 0x31E5251 VA: 0x31E5150
	private void InvokeOnRenderObjectCallback_Internal() { }

	// RVA: 0x31E5240 Offset: 0x31E5341 VA: 0x31E5240
	private void DrawWireOverlay_Impl(Camera camera) { }

	// RVA: 0x31D9AF0 Offset: 0x31D9BF1 VA: 0x31D9AF0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x31E5330 Offset: 0x31E5431 VA: 0x31E5330
	public void Submit() { }

	// RVA: 0x31D9750 Offset: 0x31D9851 VA: 0x31D9750
	internal int GetNumberOfCameras() { }

	// RVA: 0x31D97F0 Offset: 0x31D98F1 VA: 0x31D97F0
	internal Camera GetCamera(int index) { }

	// RVA: 0x31E53D0 Offset: 0x31E54D1 VA: 0x31E53D0
	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings) { }

	// RVA: 0x31E5510 Offset: 0x31E5611 VA: 0x31E5510
	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock) { }

	// RVA: 0x31E5670 Offset: 0x31E5771 VA: 0x31E5670
	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, NativeArray<ShaderTagId> tagValues, NativeArray<RenderStateBlock> stateBlocks) { }

	// RVA: 0x31E5990 Offset: 0x31E5A91 VA: 0x31E5990
	public void DrawShadows(ref ShadowDrawingSettings settings) { }

	// RVA: 0x31E5A40 Offset: 0x31E5B41 VA: 0x31E5A40
	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	// RVA: 0x31E5B30 Offset: 0x31E5C31 VA: 0x31E5B30
	public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	// RVA: 0x31E5C30 Offset: 0x31E5D31 VA: 0x31E5C30
	public void SetupCameraProperties(Camera camera, bool stereoSetup = False) { }

	// RVA: 0x31E5CF0 Offset: 0x31E5DF1 VA: 0x31E5CF0
	public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x31E5DB0 Offset: 0x31E5EB1 VA: 0x31E5DB0
	public void DrawSkybox(Camera camera) { }

	// RVA: 0x31E5E50 Offset: 0x31E5F51 VA: 0x31E5E50
	public void InvokeOnRenderObjectCallback() { }

	// RVA: 0x31E5EF0 Offset: 0x31E5FF1 VA: 0x31E5EF0
	public void DrawWireOverlay(Camera camera) { }

	// RVA: 0x31E5F90 Offset: 0x31E6091 VA: 0x31E5F90
	public CullingResults Cull(ref ScriptableCullingParameters parameters) { }

	// RVA: 0x31E60B0 Offset: 0x31E61B1 VA: 0x31E60B0 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x31E6130 Offset: 0x31E6231 VA: 0x31E6130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31E6200 Offset: 0x31E6301 VA: 0x31E6200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31E6210 Offset: 0x31E6311 VA: 0x31E6210
	private static void .cctor() { }

	// RVA: 0x31E4720 Offset: 0x31E4821 VA: 0x31E4720
	private static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x31E4870 Offset: 0x31E4971 VA: 0x31E4870
	private static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x31E4960 Offset: 0x31E4A61 VA: 0x31E4960
	private static int GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x31E4A50 Offset: 0x31E4B51 VA: 0x31E4A50
	private static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, int index) { }

	// RVA: 0x31E4BA0 Offset: 0x31E4CA1 VA: 0x31E4BA0
	private static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x31E4CE0 Offset: 0x31E4DE1 VA: 0x31E4CE0
	private static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings) { }

	// RVA: 0x31E4DD0 Offset: 0x31E4ED1 VA: 0x31E4DD0
	private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) { }

	// RVA: 0x31E4ED0 Offset: 0x31E4FD1 VA: 0x31E4ED0
	private static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	// RVA: 0x31E4FF0 Offset: 0x31E50F1 VA: 0x31E4FF0
	private static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x31E5100 Offset: 0x31E5201 VA: 0x31E5100
	private static void DrawSkybox_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera) { }

	// RVA: 0x31E51F0 Offset: 0x31E52F1 VA: 0x31E51F0
	private static void InvokeOnRenderObjectCallback_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x31E52E0 Offset: 0x31E53E1 VA: 0x31E52E0
	private static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, Camera camera) { }
}

