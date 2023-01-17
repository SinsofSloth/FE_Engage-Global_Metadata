// Namespace: UnityEngine.Rendering
public static class RenderPipelineManager // TypeDefIndex: 3952
{
	// Fields
	internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static Camera[] s_Cameras; // 0x8
	private static int s_CameraCapacity; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x444E00 Offset: 0x444F01 VA: 0x444E00
	[CompilerGeneratedAttribute] // RVA: 0x444E00 Offset: 0x444F01 VA: 0x444E00
	private static RenderPipeline <currentPipeline>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x444E40 Offset: 0x444F41 VA: 0x444E40
	[DebuggerBrowsableAttribute] // RVA: 0x444E40 Offset: 0x444F41 VA: 0x444E40
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x444E80 Offset: 0x444F81 VA: 0x444E80
	[DebuggerBrowsableAttribute] // RVA: 0x444E80 Offset: 0x444F81 VA: 0x444E80
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x444EC0 Offset: 0x444FC1 VA: 0x444EC0
	[DebuggerBrowsableAttribute] // RVA: 0x444EC0 Offset: 0x444FC1 VA: 0x444EC0
	private static Action<ScriptableRenderContext, Camera[]> endFrameRendering; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x444F00 Offset: 0x445001 VA: 0x444F00
	[CompilerGeneratedAttribute] // RVA: 0x444F00 Offset: 0x445001 VA: 0x444F00
	private static Action<ScriptableRenderContext, Camera> endCameraRendering; // 0x38

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4542B0 Offset: 0x4543B1 VA: 0x4542B0
	// RVA: 0x31D8EB0 Offset: 0x31D8FB1 VA: 0x31D8EB0
	public static RenderPipeline get_currentPipeline() { }

	[CompilerGeneratedAttribute] // RVA: 0x4542C0 Offset: 0x4543C1 VA: 0x4542C0
	// RVA: 0x31D8F20 Offset: 0x31D9021 VA: 0x31D8F20
	private static void set_currentPipeline(RenderPipeline value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4542D0 Offset: 0x4543D1 VA: 0x4542D0
	// RVA: 0x31D8FA0 Offset: 0x31D90A1 VA: 0x31D8FA0
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4542E0 Offset: 0x4543E1 VA: 0x4542E0
	// RVA: 0x31D90A0 Offset: 0x31D91A1 VA: 0x31D90A0
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4542F0 Offset: 0x4543F1 VA: 0x4542F0
	// RVA: 0x31D91A0 Offset: 0x31D92A1 VA: 0x31D91A0
	public static void add_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x454300 Offset: 0x454401 VA: 0x454300
	// RVA: 0x31D92A0 Offset: 0x31D93A1 VA: 0x31D92A0
	public static void remove_endCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	// RVA: 0x31D7950 Offset: 0x31D7A51 VA: 0x31D7950
	internal static void BeginFrameRendering(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x31D7B10 Offset: 0x31D7C11 VA: 0x31D7B10
	internal static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x31D7CD0 Offset: 0x31D7DD1 VA: 0x31D7CD0
	internal static void EndFrameRendering(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x31D7E90 Offset: 0x31D7F91 VA: 0x31D7E90
	internal static void EndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x454310 Offset: 0x454411 VA: 0x454310
	// RVA: 0x31D8680 Offset: 0x31D8781 VA: 0x31D8680
	internal static void CleanupRenderPipeline() { }

	// RVA: 0x31D94C0 Offset: 0x31D95C1 VA: 0x31D94C0
	private static void GetCameras(ScriptableRenderContext context) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x454320 Offset: 0x454421 VA: 0x454320
	// RVA: 0x31D9890 Offset: 0x31D9991 VA: 0x31D9890
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, List<Camera.RenderRequest> renderRequests) { }

	// RVA: 0x31D8A40 Offset: 0x31D8B41 VA: 0x31D8A40
	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x31D9B00 Offset: 0x31D9C01 VA: 0x31D9B00
	private static void .cctor() { }
}

