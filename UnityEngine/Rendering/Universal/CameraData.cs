// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47FE20 Offset: 0x47FF21 VA: 0x47FE20
public struct CameraData // TypeDefIndex: 5364
{
	// Fields
	private Matrix4x4 m_ViewMatrix; // 0x0
	private Matrix4x4 m_ProjectionMatrix; // 0x40
	public Camera camera; // 0x80
	public CameraRenderType renderType; // 0x88
	public RenderTexture targetTexture; // 0x90
	public RenderTextureDescriptor cameraTargetDescriptor; // 0x98
	internal Rect pixelRect; // 0xCC
	internal int pixelWidth; // 0xDC
	internal int pixelHeight; // 0xE0
	internal float aspectRatio; // 0xE4
	public float renderScale; // 0xE8
	public bool clearDepth; // 0xEC
	public CameraType cameraType; // 0xF0
	public bool isDefaultViewport; // 0xF4
	public bool isHdrEnabled; // 0xF5
	public bool requiresDepthTexture; // 0xF6
	public bool requiresOpaqueTexture; // 0xF7
	public bool xrRendering; // 0xF8
	public SortingCriteria defaultOpaqueSortFlags; // 0xFC
	internal XRPass xr; // 0x100
	[ObsoleteAttribute] // RVA: 0x482ED0 Offset: 0x482FD1 VA: 0x482ED0
	public bool isStereoEnabled; // 0x108
	public float maxShadowDistance; // 0x10C
	public bool postProcessEnabled; // 0x110
	public IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions; // 0x118
	public LayerMask volumeLayerMask; // 0x120
	public Transform volumeTrigger; // 0x128
	public bool isStopNaNEnabled; // 0x130
	public bool isDitheringEnabled; // 0x131
	public AntialiasingMode antialiasing; // 0x134
	public AntialiasingQuality antialiasingQuality; // 0x138
	public ScriptableRenderer renderer; // 0x140
	public bool resolveFinalTarget; // 0x148
	public bool isAutoReduction; // 0x149
	public CustomCameraRenderingFlag customRenderingFlag; // 0x14C

	// Properties
	internal bool requireSrgbConversion { get; }
	public bool isSceneViewCamera { get; }
	public bool isPreviewCamera { get; }

	// Methods

	// RVA: 0x2D292A0 Offset: 0x2D293A1 VA: 0x2D292A0
	internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix) { }

	// RVA: 0x2D292E0 Offset: 0x2D293E1 VA: 0x2D292E0
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	// RVA: 0x2D29380 Offset: 0x2D29481 VA: 0x2D29380
	public Matrix4x4 GetProjectionMatrix(int viewIndex = 0) { }

	// RVA: 0x2D29420 Offset: 0x2D29521 VA: 0x2D29420
	public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0) { }

	// RVA: 0x2D29740 Offset: 0x2D29841 VA: 0x2D29740
	internal bool get_requireSrgbConversion() { }

	// RVA: 0x2D29830 Offset: 0x2D29931 VA: 0x2D29830
	public bool get_isSceneViewCamera() { }

	// RVA: 0x2D29840 Offset: 0x2D29941 VA: 0x2D29840
	public bool get_isPreviewCamera() { }

	// RVA: 0x2D29540 Offset: 0x2D29641 VA: 0x2D29540
	public bool IsCameraProjectionMatrixFlipped() { }
}

