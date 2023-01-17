// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
[UsedByNativeCodeAttribute] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
[RequireComponent] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
[NativeHeaderAttribute] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
[NativeHeaderAttribute] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
[NativeHeaderAttribute] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
[NativeHeaderAttribute] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
[NativeHeaderAttribute] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
[NativeHeaderAttribute] // RVA: 0x43BC70 Offset: 0x43BD71 VA: 0x43BC70
public sealed class Camera : Behaviour // TypeDefIndex: 3414
{
	// Fields
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativePropertyAttribute] // RVA: 0x458E60 Offset: 0x458F61 VA: 0x458E60
	public float nearClipPlane { get; set; }
	[NativePropertyAttribute] // RVA: 0x458EA0 Offset: 0x458FA1 VA: 0x458EA0
	public float farClipPlane { get; set; }
	[NativePropertyAttribute] // RVA: 0x458EE0 Offset: 0x458FE1 VA: 0x458EE0
	public float fieldOfView { get; set; }
	public RenderingPath renderingPath { get; set; }
	public RenderingPath actualRenderingPath { get; }
	public bool allowHDR { get; set; }
	public bool allowMSAA { get; set; }
	public bool allowDynamicResolution { get; set; }
	[NativePropertyAttribute] // RVA: 0x458F20 Offset: 0x459021 VA: 0x458F20
	public bool forceIntoRenderTexture { get; set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public OpaqueSortMode opaqueSortMode { get; set; }
	public TransparencySortMode transparencySortMode { get; set; }
	public Vector3 transparencySortAxis { get; set; }
	public float depth { get; set; }
	public float aspect { get; set; }
	public Vector3 velocity { get; }
	public int cullingMask { get; set; }
	public int eventMask { get; set; }
	public bool layerCullSpherical { get; set; }
	public CameraType cameraType { get; set; }
	[NativeConditionalAttribute] // RVA: 0x458F60 Offset: 0x459061 VA: 0x458F60
	public ulong overrideSceneCullingMask { get; set; }
	[NativeConditionalAttribute] // RVA: 0x458FA0 Offset: 0x4590A1 VA: 0x458FA0
	internal ulong sceneCullingMask { get; }
	public float[] layerCullDistances { get; set; }
	internal static int PreviewCullingLayer { get; }
	public bool useOcclusionCulling { get; set; }
	public Matrix4x4 cullingMatrix { get; set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public bool clearStencilAfterLightingPass { get; set; }
	internal Camera.ProjectionMatrixMode projectionMatrixMode { get; }
	public bool usePhysicalProperties { get; set; }
	public Vector2 sensorSize { get; set; }
	public Vector2 lensShift { get; set; }
	public float focalLength { get; set; }
	public Camera.GateFitMode gateFit { get; set; }
	[NativePropertyAttribute] // RVA: 0x458FE0 Offset: 0x4590E1 VA: 0x458FE0
	public Rect rect { get; set; }
	[NativePropertyAttribute] // RVA: 0x459020 Offset: 0x459121 VA: 0x459020
	public Rect pixelRect { get; set; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public int scaledPixelWidth { get; }
	public int scaledPixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public RenderTexture activeTexture { get; }
	public int targetDisplay { get; set; }
	public Matrix4x4 cameraToWorldMatrix { get; }
	public Matrix4x4 worldToCameraMatrix { get; set; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
	[NativePropertyAttribute] // RVA: 0x459060 Offset: 0x459161 VA: 0x459060
	public bool useJitteredProjectionMatrixForTransparentRendering { get; set; }
	public Matrix4x4 previousViewProjectionMatrix { get; }
	public static Camera main { get; }
	public static Camera current { get; }
	public Scene scene { get; set; }
	public bool stereoEnabled { get; }
	public float stereoSeparation { get; set; }
	public float stereoConvergence { get; set; }
	public bool areVRStereoViewMatricesWithinSingleCullTolerance { get; }
	public StereoTargetEyeMask stereoTargetEye { get; set; }
	public Camera.MonoOrStereoscopicEye stereoActiveEye { get; }
	public static int allCamerasCount { get; }
	public static Camera[] allCameras { get; }
	public int commandBufferCount { get; }

	// Methods

	// RVA: 0x2F0D690 Offset: 0x2F0D791 VA: 0x2F0D690
	public void .ctor() { }

	// RVA: 0x2F0D700 Offset: 0x2F0D801 VA: 0x2F0D700
	public float get_nearClipPlane() { }

	// RVA: 0x2F0D750 Offset: 0x2F0D851 VA: 0x2F0D750
	public void set_nearClipPlane(float value) { }

	// RVA: 0x2F0D7A0 Offset: 0x2F0D8A1 VA: 0x2F0D7A0
	public float get_farClipPlane() { }

	// RVA: 0x2F0D7F0 Offset: 0x2F0D8F1 VA: 0x2F0D7F0
	public void set_farClipPlane(float value) { }

	// RVA: 0x2F0D840 Offset: 0x2F0D941 VA: 0x2F0D840
	public float get_fieldOfView() { }

	// RVA: 0x2F0D890 Offset: 0x2F0D991 VA: 0x2F0D890
	public void set_fieldOfView(float value) { }

	// RVA: 0x2F0D8E0 Offset: 0x2F0D9E1 VA: 0x2F0D8E0
	public RenderingPath get_renderingPath() { }

	// RVA: 0x2F0D930 Offset: 0x2F0DA31 VA: 0x2F0D930
	public void set_renderingPath(RenderingPath value) { }

	[NativeNameAttribute] // RVA: 0x446500 Offset: 0x446601 VA: 0x446500
	// RVA: 0x2F0D980 Offset: 0x2F0DA81 VA: 0x2F0D980
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x2F0D9D0 Offset: 0x2F0DAD1 VA: 0x2F0D9D0
	public void Reset() { }

	// RVA: 0x2F0DA20 Offset: 0x2F0DB21 VA: 0x2F0DA20
	public bool get_allowHDR() { }

	// RVA: 0x2F0DA70 Offset: 0x2F0DB71 VA: 0x2F0DA70
	public void set_allowHDR(bool value) { }

	// RVA: 0x2F0DAC0 Offset: 0x2F0DBC1 VA: 0x2F0DAC0
	public bool get_allowMSAA() { }

	// RVA: 0x2F0DB10 Offset: 0x2F0DC11 VA: 0x2F0DB10
	public void set_allowMSAA(bool value) { }

	// RVA: 0x2F0DB60 Offset: 0x2F0DC61 VA: 0x2F0DB60
	public bool get_allowDynamicResolution() { }

	// RVA: 0x2F0DBB0 Offset: 0x2F0DCB1 VA: 0x2F0DBB0
	public void set_allowDynamicResolution(bool value) { }

	// RVA: 0x2F0DC00 Offset: 0x2F0DD01 VA: 0x2F0DC00
	public bool get_forceIntoRenderTexture() { }

	// RVA: 0x2F0DC50 Offset: 0x2F0DD51 VA: 0x2F0DC50
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x2F0DCA0 Offset: 0x2F0DDA1 VA: 0x2F0DCA0
	public float get_orthographicSize() { }

	// RVA: 0x2F0DCF0 Offset: 0x2F0DDF1 VA: 0x2F0DCF0
	public void set_orthographicSize(float value) { }

	// RVA: 0x2F0DD40 Offset: 0x2F0DE41 VA: 0x2F0DD40
	public bool get_orthographic() { }

	// RVA: 0x2F0DD90 Offset: 0x2F0DE91 VA: 0x2F0DD90
	public void set_orthographic(bool value) { }

	// RVA: 0x2F0DDE0 Offset: 0x2F0DEE1 VA: 0x2F0DDE0
	public OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0x2F0DE30 Offset: 0x2F0DF31 VA: 0x2F0DE30
	public void set_opaqueSortMode(OpaqueSortMode value) { }

	// RVA: 0x2F0DE80 Offset: 0x2F0DF81 VA: 0x2F0DE80
	public TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x2F0DED0 Offset: 0x2F0DFD1 VA: 0x2F0DED0
	public void set_transparencySortMode(TransparencySortMode value) { }

	// RVA: 0x2F0DF20 Offset: 0x2F0E021 VA: 0x2F0DF20
	public Vector3 get_transparencySortAxis() { }

	// RVA: 0x2F0DFD0 Offset: 0x2F0E0D1 VA: 0x2F0DFD0
	public void set_transparencySortAxis(Vector3 value) { }

	// RVA: 0x2F0E080 Offset: 0x2F0E181 VA: 0x2F0E080
	public void ResetTransparencySortSettings() { }

	// RVA: 0x2F0E0D0 Offset: 0x2F0E1D1 VA: 0x2F0E0D0
	public float get_depth() { }

	// RVA: 0x2F0E120 Offset: 0x2F0E221 VA: 0x2F0E120
	public void set_depth(float value) { }

	// RVA: 0x2F0E170 Offset: 0x2F0E271 VA: 0x2F0E170
	public float get_aspect() { }

	// RVA: 0x2F0E1C0 Offset: 0x2F0E2C1 VA: 0x2F0E1C0
	public void set_aspect(float value) { }

	// RVA: 0x2F0E210 Offset: 0x2F0E311 VA: 0x2F0E210
	public void ResetAspect() { }

	// RVA: 0x2F0E260 Offset: 0x2F0E361 VA: 0x2F0E260
	public Vector3 get_velocity() { }

	// RVA: 0x2F0E310 Offset: 0x2F0E411 VA: 0x2F0E310
	public int get_cullingMask() { }

	// RVA: 0x2F0E360 Offset: 0x2F0E461 VA: 0x2F0E360
	public void set_cullingMask(int value) { }

	// RVA: 0x2F0E3B0 Offset: 0x2F0E4B1 VA: 0x2F0E3B0
	public int get_eventMask() { }

	// RVA: 0x2F0E400 Offset: 0x2F0E501 VA: 0x2F0E400
	public void set_eventMask(int value) { }

	// RVA: 0x2F0E450 Offset: 0x2F0E551 VA: 0x2F0E450
	public bool get_layerCullSpherical() { }

	// RVA: 0x2F0E4A0 Offset: 0x2F0E5A1 VA: 0x2F0E4A0
	public void set_layerCullSpherical(bool value) { }

	// RVA: 0x2F0E4F0 Offset: 0x2F0E5F1 VA: 0x2F0E4F0
	public CameraType get_cameraType() { }

	// RVA: 0x2F0E540 Offset: 0x2F0E641 VA: 0x2F0E540
	public void set_cameraType(CameraType value) { }

	// RVA: 0x2F0E590 Offset: 0x2F0E691 VA: 0x2F0E590
	public ulong get_overrideSceneCullingMask() { }

	// RVA: 0x2F0E5E0 Offset: 0x2F0E6E1 VA: 0x2F0E5E0
	public void set_overrideSceneCullingMask(ulong value) { }

	// RVA: 0x2F0E630 Offset: 0x2F0E731 VA: 0x2F0E630
	internal ulong get_sceneCullingMask() { }

	[FreeFunctionAttribute] // RVA: 0x446540 Offset: 0x446641 VA: 0x446540
	// RVA: 0x2F0E680 Offset: 0x2F0E781 VA: 0x2F0E680
	private float[] GetLayerCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0x446590 Offset: 0x446691 VA: 0x446590
	// RVA: 0x2F0E6D0 Offset: 0x2F0E7D1 VA: 0x2F0E6D0
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x2F0E720 Offset: 0x2F0E821 VA: 0x2F0E720
	public float[] get_layerCullDistances() { }

	// RVA: 0x2F0E770 Offset: 0x2F0E871 VA: 0x2F0E770
	public void set_layerCullDistances(float[] value) { }

	[FreeFunctionAttribute] // RVA: 0x4465E0 Offset: 0x4466E1 VA: 0x4465E0
	// RVA: 0x2F0E820 Offset: 0x2F0E921 VA: 0x2F0E820
	internal static int get_PreviewCullingLayer() { }

	// RVA: 0x2F0E860 Offset: 0x2F0E961 VA: 0x2F0E860
	public bool get_useOcclusionCulling() { }

	// RVA: 0x2F0E8B0 Offset: 0x2F0E9B1 VA: 0x2F0E8B0
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x2F0E900 Offset: 0x2F0EA01 VA: 0x2F0E900
	public Matrix4x4 get_cullingMatrix() { }

	// RVA: 0x2F0E9E0 Offset: 0x2F0EAE1 VA: 0x2F0E9E0
	public void set_cullingMatrix(Matrix4x4 value) { }

	// RVA: 0x2F0EA80 Offset: 0x2F0EB81 VA: 0x2F0EA80
	public void ResetCullingMatrix() { }

	// RVA: 0x2F0EAD0 Offset: 0x2F0EBD1 VA: 0x2F0EAD0
	public Color get_backgroundColor() { }

	// RVA: 0x2F0EB80 Offset: 0x2F0EC81 VA: 0x2F0EB80
	public void set_backgroundColor(Color value) { }

	// RVA: 0x2F0EC30 Offset: 0x2F0ED31 VA: 0x2F0EC30
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x2F0EC80 Offset: 0x2F0ED81 VA: 0x2F0EC80
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x2F0ECD0 Offset: 0x2F0EDD1 VA: 0x2F0ECD0
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x2F0ED20 Offset: 0x2F0EE21 VA: 0x2F0ED20
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x2F0ED70 Offset: 0x2F0EE71 VA: 0x2F0ED70
	public bool get_clearStencilAfterLightingPass() { }

	// RVA: 0x2F0EDC0 Offset: 0x2F0EEC1 VA: 0x2F0EDC0
	public void set_clearStencilAfterLightingPass(bool value) { }

	// RVA: 0x2F0EE10 Offset: 0x2F0EF11 VA: 0x2F0EE10
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x2F0EE70 Offset: 0x2F0EF71 VA: 0x2F0EE70
	public void ResetReplacementShader() { }

	// RVA: 0x2F0EEC0 Offset: 0x2F0EFC1 VA: 0x2F0EEC0
	internal Camera.ProjectionMatrixMode get_projectionMatrixMode() { }

	// RVA: 0x2F0EF10 Offset: 0x2F0F011 VA: 0x2F0EF10
	public bool get_usePhysicalProperties() { }

	// RVA: 0x2F0EF60 Offset: 0x2F0F061 VA: 0x2F0EF60
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x2F0EFB0 Offset: 0x2F0F0B1 VA: 0x2F0EFB0
	public Vector2 get_sensorSize() { }

	// RVA: 0x2F0F060 Offset: 0x2F0F161 VA: 0x2F0F060
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x2F0F110 Offset: 0x2F0F211 VA: 0x2F0F110
	public Vector2 get_lensShift() { }

	// RVA: 0x2F0F1C0 Offset: 0x2F0F2C1 VA: 0x2F0F1C0
	public void set_lensShift(Vector2 value) { }

	// RVA: 0x2F0F270 Offset: 0x2F0F371 VA: 0x2F0F270
	public float get_focalLength() { }

	// RVA: 0x2F0F2C0 Offset: 0x2F0F3C1 VA: 0x2F0F2C0
	public void set_focalLength(float value) { }

	// RVA: 0x2F0F310 Offset: 0x2F0F411 VA: 0x2F0F310
	public Camera.GateFitMode get_gateFit() { }

	// RVA: 0x2F0F360 Offset: 0x2F0F461 VA: 0x2F0F360
	public void set_gateFit(Camera.GateFitMode value) { }

	// RVA: 0x2F0F3B0 Offset: 0x2F0F4B1 VA: 0x2F0F3B0
	public float GetGateFittedFieldOfView() { }

	// RVA: 0x2F0F400 Offset: 0x2F0F501 VA: 0x2F0F400
	public Vector2 GetGateFittedLensShift() { }

	// RVA: 0x2F0F4B0 Offset: 0x2F0F5B1 VA: 0x2F0F4B0
	internal Vector3 GetLocalSpaceAim() { }

	// RVA: 0x2F0F560 Offset: 0x2F0F661 VA: 0x2F0F560
	public Rect get_rect() { }

	// RVA: 0x2F0F610 Offset: 0x2F0F711 VA: 0x2F0F610
	public void set_rect(Rect value) { }

	// RVA: 0x2F0F6C0 Offset: 0x2F0F7C1 VA: 0x2F0F6C0
	public Rect get_pixelRect() { }

	// RVA: 0x2F0F770 Offset: 0x2F0F871 VA: 0x2F0F770
	public void set_pixelRect(Rect value) { }

	[FreeFunctionAttribute] // RVA: 0x446620 Offset: 0x446721 VA: 0x446620
	// RVA: 0x2F0F820 Offset: 0x2F0F921 VA: 0x2F0F820
	public int get_pixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0x446670 Offset: 0x446771 VA: 0x446670
	// RVA: 0x2F0F870 Offset: 0x2F0F971 VA: 0x2F0F870
	public int get_pixelHeight() { }

	[FreeFunctionAttribute] // RVA: 0x4466C0 Offset: 0x4467C1 VA: 0x4466C0
	// RVA: 0x2F0F8C0 Offset: 0x2F0F9C1 VA: 0x2F0F8C0
	public int get_scaledPixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0x446710 Offset: 0x446811 VA: 0x446710
	// RVA: 0x2F0F910 Offset: 0x2F0FA11 VA: 0x2F0F910
	public int get_scaledPixelHeight() { }

	// RVA: 0x2F0F960 Offset: 0x2F0FA61 VA: 0x2F0F960
	public RenderTexture get_targetTexture() { }

	// RVA: 0x2F0F9B0 Offset: 0x2F0FAB1 VA: 0x2F0F9B0
	public void set_targetTexture(RenderTexture value) { }

	[NativeNameAttribute] // RVA: 0x446760 Offset: 0x446861 VA: 0x446760
	// RVA: 0x2F0FA00 Offset: 0x2F0FB01 VA: 0x2F0FA00
	public RenderTexture get_activeTexture() { }

	// RVA: 0x2F0FA50 Offset: 0x2F0FB51 VA: 0x2F0FA50
	public int get_targetDisplay() { }

	// RVA: 0x2F0FAA0 Offset: 0x2F0FBA1 VA: 0x2F0FAA0
	public void set_targetDisplay(int value) { }

	[FreeFunctionAttribute] // RVA: 0x4467A0 Offset: 0x4468A1 VA: 0x4467A0
	// RVA: 0x2F0FAF0 Offset: 0x2F0FBF1 VA: 0x2F0FAF0
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x2F0FBB0 Offset: 0x2F0FCB1 VA: 0x2F0FBB0
	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[FreeFunctionAttribute] // RVA: 0x4467F0 Offset: 0x4468F1 VA: 0x4467F0
	// RVA: 0x2F0FC10 Offset: 0x2F0FD11 VA: 0x2F0FC10
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x2F0FCE0 Offset: 0x2F0FDE1 VA: 0x2F0FCE0
	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x2F0FD50 Offset: 0x2F0FE51 VA: 0x2F0FD50
	internal string[] GetCameraBufferWarnings() { }

	// RVA: 0x2F0FDA0 Offset: 0x2F0FEA1 VA: 0x2F0FDA0
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x2F0FE80 Offset: 0x2F0FF81 VA: 0x2F0FE80
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x2F0FF60 Offset: 0x2F10061 VA: 0x2F0FF60
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x2F10000 Offset: 0x2F10101 VA: 0x2F10000
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x2F100E0 Offset: 0x2F101E1 VA: 0x2F100E0
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2F10180 Offset: 0x2F10281 VA: 0x2F10180
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x2F10260 Offset: 0x2F10361 VA: 0x2F10260
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2F10300 Offset: 0x2F10401 VA: 0x2F10300
	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	// RVA: 0x2F10350 Offset: 0x2F10451 VA: 0x2F10350
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x2F103A0 Offset: 0x2F104A1 VA: 0x2F103A0
	public Matrix4x4 get_previousViewProjectionMatrix() { }

	// RVA: 0x2F10480 Offset: 0x2F10581 VA: 0x2F10480
	public void ResetWorldToCameraMatrix() { }

	// RVA: 0x2F104D0 Offset: 0x2F105D1 VA: 0x2F104D0
	public void ResetProjectionMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x446840 Offset: 0x446941 VA: 0x446840
	// RVA: 0x2F10520 Offset: 0x2F10621 VA: 0x2F10520
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x2F10620 Offset: 0x2F10721 VA: 0x2F10620
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2F10710 Offset: 0x2F10811 VA: 0x2F10710
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2F10800 Offset: 0x2F10901 VA: 0x2F10800
	public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2F108F0 Offset: 0x2F109F1 VA: 0x2F108F0
	public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2F109E0 Offset: 0x2F10AE1 VA: 0x2F109E0
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x2F10A50 Offset: 0x2F10B51 VA: 0x2F10A50
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x2F10AC0 Offset: 0x2F10BC1 VA: 0x2F10AC0
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x2F10B30 Offset: 0x2F10C31 VA: 0x2F10B30
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x2F10BA0 Offset: 0x2F10CA1 VA: 0x2F10BA0
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x2F10C70 Offset: 0x2F10D71 VA: 0x2F10C70
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x2F10D40 Offset: 0x2F10E41 VA: 0x2F10D40
	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	// RVA: 0x2F10E00 Offset: 0x2F10F01 VA: 0x2F10E00
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2F10F00 Offset: 0x2F11001 VA: 0x2F10F00
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2F10FA0 Offset: 0x2F110A1 VA: 0x2F10FA0
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x2F11050 Offset: 0x2F11151 VA: 0x2F11050
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2F11150 Offset: 0x2F11251 VA: 0x2F11150
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2F111F0 Offset: 0x2F112F1 VA: 0x2F111F0
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunctionAttribute] // RVA: 0x446890 Offset: 0x446991 VA: 0x446890
	// RVA: 0x2F112A0 Offset: 0x2F113A1 VA: 0x2F112A0
	private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x2F113A0 Offset: 0x2F114A1 VA: 0x2F113A0
	public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[NativeNameAttribute] // RVA: 0x4468E0 Offset: 0x4469E1 VA: 0x4468E0
	// RVA: 0x2F114C0 Offset: 0x2F115C1 VA: 0x2F114C0
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode) { }

	// RVA: 0x2F11600 Offset: 0x2F11701 VA: 0x2F11600
	public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, Camera.GateFitParameters gateFitParameters) { }

	[NativeNameAttribute] // RVA: 0x446920 Offset: 0x446A21 VA: 0x446920
	// RVA: 0x2F116A0 Offset: 0x2F117A1 VA: 0x2F116A0
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	[NativeNameAttribute] // RVA: 0x446960 Offset: 0x446A61 VA: 0x446960
	// RVA: 0x2F116F0 Offset: 0x2F117F1 VA: 0x2F116F0
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[NativeNameAttribute] // RVA: 0x4469A0 Offset: 0x446AA1 VA: 0x4469A0
	// RVA: 0x2F11740 Offset: 0x2F11841 VA: 0x2F11740
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	// RVA: 0x2F11790 Offset: 0x2F11891 VA: 0x2F11790
	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	[FreeFunctionAttribute] // RVA: 0x4469E0 Offset: 0x446AE1 VA: 0x4469E0
	// RVA: 0x2F117E0 Offset: 0x2F118E1 VA: 0x2F117E0
	public static Camera get_main() { }

	[FreeFunctionAttribute] // RVA: 0x446A20 Offset: 0x446B21 VA: 0x446A20
	// RVA: 0x2F11820 Offset: 0x2F11921 VA: 0x2F11820
	public static Camera get_current() { }

	[FreeFunctionAttribute] // RVA: 0x446A60 Offset: 0x446B61 VA: 0x446A60
	// RVA: 0x2F11860 Offset: 0x2F11961 VA: 0x2F11860
	public Scene get_scene() { }

	[FreeFunctionAttribute] // RVA: 0x446AB0 Offset: 0x446BB1 VA: 0x446AB0
	// RVA: 0x2F11910 Offset: 0x2F11A11 VA: 0x2F11910
	public void set_scene(Scene value) { }

	// RVA: 0x2F119C0 Offset: 0x2F11AC1 VA: 0x2F119C0
	public bool get_stereoEnabled() { }

	// RVA: 0x2F11A10 Offset: 0x2F11B11 VA: 0x2F11A10
	public float get_stereoSeparation() { }

	// RVA: 0x2F11A60 Offset: 0x2F11B61 VA: 0x2F11A60
	public void set_stereoSeparation(float value) { }

	// RVA: 0x2F11AB0 Offset: 0x2F11BB1 VA: 0x2F11AB0
	public float get_stereoConvergence() { }

	// RVA: 0x2F11B00 Offset: 0x2F11C01 VA: 0x2F11B00
	public void set_stereoConvergence(float value) { }

	[NativeNameAttribute] // RVA: 0x446B00 Offset: 0x446C01 VA: 0x446B00
	// RVA: 0x2F11B50 Offset: 0x2F11C51 VA: 0x2F11B50
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	// RVA: 0x2F11BA0 Offset: 0x2F11CA1 VA: 0x2F11BA0
	public StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0x2F11BF0 Offset: 0x2F11CF1 VA: 0x2F11BF0
	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	[FreeFunctionAttribute] // RVA: 0x446B40 Offset: 0x446C41 VA: 0x446B40
	// RVA: 0x2F11C40 Offset: 0x2F11D41 VA: 0x2F11C40
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x2F11C90 Offset: 0x2F11D91 VA: 0x2F11C90
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	[FreeFunctionAttribute] // RVA: 0x446B90 Offset: 0x446C91 VA: 0x446B90
	// RVA: 0x2F11D90 Offset: 0x2F11E91 VA: 0x2F11D90
	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2F11E90 Offset: 0x2F11F91 VA: 0x2F11E90
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	[FreeFunctionAttribute] // RVA: 0x446BE0 Offset: 0x446CE1 VA: 0x446BE0
	// RVA: 0x2F11EE0 Offset: 0x2F11FE1 VA: 0x2F11EE0
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2F11FE0 Offset: 0x2F120E1 VA: 0x2F11FE0
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x2F120A0 Offset: 0x2F121A1 VA: 0x2F120A0
	public void ResetStereoProjectionMatrices() { }

	// RVA: 0x2F120F0 Offset: 0x2F121F1 VA: 0x2F120F0
	public void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x2F121B0 Offset: 0x2F122B1 VA: 0x2F121B0
	public void ResetStereoViewMatrices() { }

	[FreeFunctionAttribute] // RVA: 0x446C30 Offset: 0x446D31 VA: 0x446C30
	// RVA: 0x2F12200 Offset: 0x2F12301 VA: 0x2F12200
	private static int GetAllCamerasCount() { }

	[FreeFunctionAttribute] // RVA: 0x446C70 Offset: 0x446D71 VA: 0x446C70
	// RVA: 0x2F12240 Offset: 0x2F12341 VA: 0x2F12240
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x2F12290 Offset: 0x2F12391 VA: 0x2F12290
	public static int get_allCamerasCount() { }

	// RVA: 0x2F122D0 Offset: 0x2F123D1 VA: 0x2F122D0
	public static Camera[] get_allCameras() { }

	// RVA: 0x2F12370 Offset: 0x2F12471 VA: 0x2F12370
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunctionAttribute] // RVA: 0x446CB0 Offset: 0x446DB1 VA: 0x446CB0
	// RVA: 0x2F12460 Offset: 0x2F12561 VA: 0x2F12460
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	// RVA: 0x2F124C0 Offset: 0x2F125C1 VA: 0x2F124C0
	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	// RVA: 0x2F12520 Offset: 0x2F12621 VA: 0x2F12520
	public bool RenderToCubemap(Cubemap cubemap) { }

	// RVA: 0x2F12580 Offset: 0x2F12681 VA: 0x2F12580
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	// RVA: 0x2F125E0 Offset: 0x2F126E1 VA: 0x2F125E0
	public bool RenderToCubemap(RenderTexture cubemap) { }

	[NativeNameAttribute] // RVA: 0x446D00 Offset: 0x446E01 VA: 0x446D00
	// RVA: 0x2F12640 Offset: 0x2F12741 VA: 0x2F12640
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x2F126B0 Offset: 0x2F127B1 VA: 0x2F126B0
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye) { }

	[FreeFunctionAttribute] // RVA: 0x446D40 Offset: 0x446E41 VA: 0x446D40
	// RVA: 0x2F12720 Offset: 0x2F12821 VA: 0x2F12720
	public void Render() { }

	[FreeFunctionAttribute] // RVA: 0x446D90 Offset: 0x446E91 VA: 0x446D90
	// RVA: 0x2F12770 Offset: 0x2F12871 VA: 0x2F12770
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunctionAttribute] // RVA: 0x446DE0 Offset: 0x446EE1 VA: 0x446DE0
	// RVA: 0x2F127D0 Offset: 0x2F128D1 VA: 0x2F127D0
	public void RenderDontRestore() { }

	// RVA: 0x2F12820 Offset: 0x2F12921 VA: 0x2F12820
	public void SubmitRenderRequests(List<Camera.RenderRequest> renderRequests) { }

	[FreeFunctionAttribute] // RVA: 0x446E30 Offset: 0x446F31 VA: 0x446E30
	// RVA: 0x2F12C40 Offset: 0x2F12D41 VA: 0x2F12C40
	private void SubmitRenderRequestsInternal(object requests) { }

	[FreeFunctionAttribute] // RVA: 0x446E80 Offset: 0x446F81 VA: 0x446E80
	// RVA: 0x2F12C90 Offset: 0x2F12D91 VA: 0x2F12C90
	public static void SetupCurrent(Camera cur) { }

	[FreeFunctionAttribute] // RVA: 0x446EC0 Offset: 0x446FC1 VA: 0x446EC0
	// RVA: 0x2F12CE0 Offset: 0x2F12DE1 VA: 0x2F12CE0
	public void CopyFrom(Camera other) { }

	// RVA: 0x2F12D30 Offset: 0x2F12E31 VA: 0x2F12D30
	public int get_commandBufferCount() { }

	// RVA: 0x2F12D80 Offset: 0x2F12E81 VA: 0x2F12D80
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x2F12DD0 Offset: 0x2F12ED1 VA: 0x2F12DD0
	public void RemoveAllCommandBuffers() { }

	[NativeNameAttribute] // RVA: 0x446F10 Offset: 0x447011 VA: 0x446F10
	// RVA: 0x2F12E20 Offset: 0x2F12F21 VA: 0x2F12E20
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeNameAttribute] // RVA: 0x446F50 Offset: 0x447051 VA: 0x446F50
	// RVA: 0x2F12E80 Offset: 0x2F12F81 VA: 0x2F12E80
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[NativeNameAttribute] // RVA: 0x446F90 Offset: 0x447091 VA: 0x446F90
	// RVA: 0x2F12EF0 Offset: 0x2F12FF1 VA: 0x2F12EF0
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2F12F50 Offset: 0x2F13051 VA: 0x2F12F50
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2F130A0 Offset: 0x2F131A1 VA: 0x2F130A0
	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x2F131E0 Offset: 0x2F132E1 VA: 0x2F131E0
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x446FD0 Offset: 0x4470D1 VA: 0x446FD0
	// RVA: 0x2F13320 Offset: 0x2F13421 VA: 0x2F13320
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447020 Offset: 0x447121 VA: 0x447020
	// RVA: 0x2F13370 Offset: 0x2F13471 VA: 0x2F13370
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447030 Offset: 0x447131 VA: 0x447030
	// RVA: 0x2F133F0 Offset: 0x2F134F1 VA: 0x2F133F0
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447040 Offset: 0x447141 VA: 0x447040
	// RVA: 0x2F13470 Offset: 0x2F13571 VA: 0x2F13470
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x2F134F0 Offset: 0x2F135F1 VA: 0x2F134F0
	internal void OnlyUsedForTesting1() { }

	// RVA: 0x2F13500 Offset: 0x2F13601 VA: 0x2F13500
	internal void OnlyUsedForTesting2() { }

	// RVA: 0x2F13510 Offset: 0x2F13611 VA: 0x2F13510
	public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x2F135E0 Offset: 0x2F136E1 VA: 0x2F135E0
	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	[FreeFunctionAttribute] // RVA: 0x447050 Offset: 0x447151 VA: 0x447050
	[NativeHeaderAttribute] // RVA: 0x447050 Offset: 0x447151 VA: 0x447050
	// RVA: 0x2F13570 Offset: 0x2F13671 VA: 0x2F13570
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	// RVA: 0x2F0DF80 Offset: 0x2F0E081 VA: 0x2F0DF80
	private void get_transparencySortAxis_Injected(out Vector3 ret) { }

	// RVA: 0x2F0E030 Offset: 0x2F0E131 VA: 0x2F0E030
	private void set_transparencySortAxis_Injected(ref Vector3 value) { }

	// RVA: 0x2F0E2C0 Offset: 0x2F0E3C1 VA: 0x2F0E2C0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x2F0E990 Offset: 0x2F0EA91 VA: 0x2F0E990
	private void get_cullingMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2F0EA30 Offset: 0x2F0EB31 VA: 0x2F0EA30
	private void set_cullingMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2F0EB30 Offset: 0x2F0EC31 VA: 0x2F0EB30
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x2F0EBE0 Offset: 0x2F0ECE1 VA: 0x2F0EBE0
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x2F0F010 Offset: 0x2F0F111 VA: 0x2F0F010
	private void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x2F0F0C0 Offset: 0x2F0F1C1 VA: 0x2F0F0C0
	private void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x2F0F170 Offset: 0x2F0F271 VA: 0x2F0F170
	private void get_lensShift_Injected(out Vector2 ret) { }

	// RVA: 0x2F0F220 Offset: 0x2F0F321 VA: 0x2F0F220
	private void set_lensShift_Injected(ref Vector2 value) { }

	// RVA: 0x2F0F460 Offset: 0x2F0F561 VA: 0x2F0F460
	private void GetGateFittedLensShift_Injected(out Vector2 ret) { }

	// RVA: 0x2F0F510 Offset: 0x2F0F611 VA: 0x2F0F510
	private void GetLocalSpaceAim_Injected(out Vector3 ret) { }

	// RVA: 0x2F0F5C0 Offset: 0x2F0F6C1 VA: 0x2F0F5C0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2F0F670 Offset: 0x2F0F771 VA: 0x2F0F670
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x2F0F720 Offset: 0x2F0F821 VA: 0x2F0F720
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x2F0F7D0 Offset: 0x2F0F8D1 VA: 0x2F0F7D0
	private void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x2F0FB50 Offset: 0x2F0FC51 VA: 0x2F0FB50
	private void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth) { }

	// RVA: 0x2F0FC80 Offset: 0x2F0FD81 VA: 0x2F0FC80
	private void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, ref RenderBuffer depth) { }

	// RVA: 0x2F0FE30 Offset: 0x2F0FF31 VA: 0x2F0FE30
	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2F0FF10 Offset: 0x2F10011 VA: 0x2F0FF10
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2F0FFB0 Offset: 0x2F100B1 VA: 0x2F0FFB0
	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2F10090 Offset: 0x2F10191 VA: 0x2F10090
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2F10130 Offset: 0x2F10231 VA: 0x2F10130
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2F10210 Offset: 0x2F10311 VA: 0x2F10210
	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2F102B0 Offset: 0x2F103B1 VA: 0x2F102B0
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2F10430 Offset: 0x2F10531 VA: 0x2F10430
	private void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2F105C0 Offset: 0x2F106C1 VA: 0x2F105C0
	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	// RVA: 0x2F106A0 Offset: 0x2F107A1 VA: 0x2F106A0
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2F10790 Offset: 0x2F10891 VA: 0x2F10790
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2F10880 Offset: 0x2F10981 VA: 0x2F10880
	private void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2F10970 Offset: 0x2F10A71 VA: 0x2F10970
	private void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2F10C10 Offset: 0x2F10D11 VA: 0x2F10C10
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2F10CE0 Offset: 0x2F10DE1 VA: 0x2F10CE0
	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2F10DA0 Offset: 0x2F10EA1 VA: 0x2F10DA0
	private void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret) { }

	// RVA: 0x2F10E90 Offset: 0x2F10F91 VA: 0x2F10E90
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x2F110E0 Offset: 0x2F111E1 VA: 0x2F110E0
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x2F11320 Offset: 0x2F11421 VA: 0x2F11320
	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x2F11560 Offset: 0x2F11661 VA: 0x2F11560
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode) { }

	// RVA: 0x2F118C0 Offset: 0x2F119C1 VA: 0x2F118C0
	private void get_scene_Injected(out Scene ret) { }

	// RVA: 0x2F11970 Offset: 0x2F11A71 VA: 0x2F11970
	private void set_scene_Injected(ref Scene value) { }

	// RVA: 0x2F11D30 Offset: 0x2F11E31 VA: 0x2F11D30
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2F11E30 Offset: 0x2F11F31 VA: 0x2F11E30
	private void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2F11F80 Offset: 0x2F12081 VA: 0x2F11F80
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2F12040 Offset: 0x2F12141 VA: 0x2F12040
	private void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }

	// RVA: 0x2F12150 Offset: 0x2F12251 VA: 0x2F12150
	private void SetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }
}

