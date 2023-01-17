// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43BEA0 Offset: 0x43BFA1 VA: 0x43BEA0
public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 3421
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x4425A0 Offset: 0x4426A1 VA: 0x4425A0
	[DebuggerBrowsableAttribute] // RVA: 0x4425A0 Offset: 0x4426A1 VA: 0x4425A0
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x4425E0 Offset: 0x4426E1 VA: 0x4425E0
	[CompilerGeneratedAttribute] // RVA: 0x4425E0 Offset: 0x4426E1 VA: 0x4425E0
	private static Action<Cubemap> defaultReflectionSet; // 0x8

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x4590A0 Offset: 0x4591A1 VA: 0x4590A0
	[ObsoleteAttribute] // RVA: 0x4590A0 Offset: 0x4591A1 VA: 0x4590A0
	[NativeNameAttribute] // RVA: 0x4590A0 Offset: 0x4591A1 VA: 0x4590A0
	public ReflectionProbeType type { get; set; }
	[NativeNameAttribute] // RVA: 0x459120 Offset: 0x459221 VA: 0x459120
	public Vector3 size { get; set; }
	[NativeNameAttribute] // RVA: 0x459160 Offset: 0x459261 VA: 0x459160
	public Vector3 center { get; set; }
	[NativeNameAttribute] // RVA: 0x4591A0 Offset: 0x4592A1 VA: 0x4591A0
	public float nearClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0x4591E0 Offset: 0x4592E1 VA: 0x4591E0
	public float farClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0x459220 Offset: 0x459321 VA: 0x459220
	public float intensity { get; set; }
	[NativeNameAttribute] // RVA: 0x459260 Offset: 0x459361 VA: 0x459260
	public Bounds bounds { get; }
	[NativeNameAttribute] // RVA: 0x4592A0 Offset: 0x4593A1 VA: 0x4592A0
	public bool hdr { get; set; }
	[NativeNameAttribute] // RVA: 0x4592E0 Offset: 0x4593E1 VA: 0x4592E0
	public bool renderDynamicObjects { get; set; }
	public float shadowDistance { get; set; }
	public int resolution { get; set; }
	public int cullingMask { get; set; }
	public ReflectionProbeClearFlags clearFlags { get; set; }
	public Color backgroundColor { get; set; }
	public float blendDistance { get; set; }
	public bool boxProjection { get; set; }
	public ReflectionProbeMode mode { get; set; }
	public int importance { get; set; }
	public ReflectionProbeRefreshMode refreshMode { get; set; }
	public ReflectionProbeTimeSlicingMode timeSlicingMode { get; set; }
	public Texture bakedTexture { get; set; }
	public Texture customBakedTexture { get; set; }
	public RenderTexture realtimeTexture { get; set; }
	public Texture texture { get; }
	public Vector4 textureHDRDecodeValues { get; }
	[StaticAccessorAttribute] // RVA: 0x459320 Offset: 0x459421 VA: 0x459320
	public static int minBakedCubemapResolution { get; }
	[StaticAccessorAttribute] // RVA: 0x459360 Offset: 0x459461 VA: 0x459360
	public static int maxBakedCubemapResolution { get; }
	[StaticAccessorAttribute] // RVA: 0x4593A0 Offset: 0x4594A1 VA: 0x4593A0
	public static Vector4 defaultTextureHDRDecodeValues { get; }
	[StaticAccessorAttribute] // RVA: 0x4593E0 Offset: 0x4594E1 VA: 0x4593E0
	public static Texture defaultTexture { get; }

	// Methods

	// RVA: 0x31D5E40 Offset: 0x31D5F41 VA: 0x31D5E40
	public ReflectionProbeType get_type() { }

	// RVA: 0x31D5E90 Offset: 0x31D5F91 VA: 0x31D5E90
	public void set_type(ReflectionProbeType value) { }

	// RVA: 0x31D5EE0 Offset: 0x31D5FE1 VA: 0x31D5EE0
	public Vector3 get_size() { }

	// RVA: 0x31D5F90 Offset: 0x31D6091 VA: 0x31D5F90
	public void set_size(Vector3 value) { }

	// RVA: 0x31D6040 Offset: 0x31D6141 VA: 0x31D6040
	public Vector3 get_center() { }

	// RVA: 0x31D60F0 Offset: 0x31D61F1 VA: 0x31D60F0
	public void set_center(Vector3 value) { }

	// RVA: 0x31D61A0 Offset: 0x31D62A1 VA: 0x31D61A0
	public float get_nearClipPlane() { }

	// RVA: 0x31D61F0 Offset: 0x31D62F1 VA: 0x31D61F0
	public void set_nearClipPlane(float value) { }

	// RVA: 0x31D6240 Offset: 0x31D6341 VA: 0x31D6240
	public float get_farClipPlane() { }

	// RVA: 0x31D6290 Offset: 0x31D6391 VA: 0x31D6290
	public void set_farClipPlane(float value) { }

	// RVA: 0x31D62E0 Offset: 0x31D63E1 VA: 0x31D62E0
	public float get_intensity() { }

	// RVA: 0x31D6330 Offset: 0x31D6431 VA: 0x31D6330
	public void set_intensity(float value) { }

	// RVA: 0x31D6380 Offset: 0x31D6481 VA: 0x31D6380
	public Bounds get_bounds() { }

	// RVA: 0x31D6450 Offset: 0x31D6551 VA: 0x31D6450
	public bool get_hdr() { }

	// RVA: 0x31D64A0 Offset: 0x31D65A1 VA: 0x31D64A0
	public void set_hdr(bool value) { }

	// RVA: 0x31D64F0 Offset: 0x31D65F1 VA: 0x31D64F0
	public bool get_renderDynamicObjects() { }

	// RVA: 0x31D6540 Offset: 0x31D6641 VA: 0x31D6540
	public void set_renderDynamicObjects(bool value) { }

	// RVA: 0x31D6590 Offset: 0x31D6691 VA: 0x31D6590
	public float get_shadowDistance() { }

	// RVA: 0x31D65E0 Offset: 0x31D66E1 VA: 0x31D65E0
	public void set_shadowDistance(float value) { }

	// RVA: 0x31D6630 Offset: 0x31D6731 VA: 0x31D6630
	public int get_resolution() { }

	// RVA: 0x31D6680 Offset: 0x31D6781 VA: 0x31D6680
	public void set_resolution(int value) { }

	// RVA: 0x31D66D0 Offset: 0x31D67D1 VA: 0x31D66D0
	public int get_cullingMask() { }

	// RVA: 0x31D6720 Offset: 0x31D6821 VA: 0x31D6720
	public void set_cullingMask(int value) { }

	// RVA: 0x31D6770 Offset: 0x31D6871 VA: 0x31D6770
	public ReflectionProbeClearFlags get_clearFlags() { }

	// RVA: 0x31D67C0 Offset: 0x31D68C1 VA: 0x31D67C0
	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	// RVA: 0x31D6810 Offset: 0x31D6911 VA: 0x31D6810
	public Color get_backgroundColor() { }

	// RVA: 0x31D68C0 Offset: 0x31D69C1 VA: 0x31D68C0
	public void set_backgroundColor(Color value) { }

	// RVA: 0x31D6970 Offset: 0x31D6A71 VA: 0x31D6970
	public float get_blendDistance() { }

	// RVA: 0x31D69C0 Offset: 0x31D6AC1 VA: 0x31D69C0
	public void set_blendDistance(float value) { }

	// RVA: 0x31D6A10 Offset: 0x31D6B11 VA: 0x31D6A10
	public bool get_boxProjection() { }

	// RVA: 0x31D6A60 Offset: 0x31D6B61 VA: 0x31D6A60
	public void set_boxProjection(bool value) { }

	// RVA: 0x31D6AB0 Offset: 0x31D6BB1 VA: 0x31D6AB0
	public ReflectionProbeMode get_mode() { }

	// RVA: 0x31D6B00 Offset: 0x31D6C01 VA: 0x31D6B00
	public void set_mode(ReflectionProbeMode value) { }

	// RVA: 0x31D6B50 Offset: 0x31D6C51 VA: 0x31D6B50
	public int get_importance() { }

	// RVA: 0x31D6BA0 Offset: 0x31D6CA1 VA: 0x31D6BA0
	public void set_importance(int value) { }

	// RVA: 0x31D6BF0 Offset: 0x31D6CF1 VA: 0x31D6BF0
	public ReflectionProbeRefreshMode get_refreshMode() { }

	// RVA: 0x31D6C40 Offset: 0x31D6D41 VA: 0x31D6C40
	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	// RVA: 0x31D6C90 Offset: 0x31D6D91 VA: 0x31D6C90
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	// RVA: 0x31D6CE0 Offset: 0x31D6DE1 VA: 0x31D6CE0
	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	// RVA: 0x31D6D30 Offset: 0x31D6E31 VA: 0x31D6D30
	public Texture get_bakedTexture() { }

	// RVA: 0x31D6D80 Offset: 0x31D6E81 VA: 0x31D6D80
	public void set_bakedTexture(Texture value) { }

	// RVA: 0x31D6DD0 Offset: 0x31D6ED1 VA: 0x31D6DD0
	public Texture get_customBakedTexture() { }

	// RVA: 0x31D6E20 Offset: 0x31D6F21 VA: 0x31D6E20
	public void set_customBakedTexture(Texture value) { }

	// RVA: 0x31D6E70 Offset: 0x31D6F71 VA: 0x31D6E70
	public RenderTexture get_realtimeTexture() { }

	// RVA: 0x31D6EC0 Offset: 0x31D6FC1 VA: 0x31D6EC0
	public void set_realtimeTexture(RenderTexture value) { }

	// RVA: 0x31D6F10 Offset: 0x31D7011 VA: 0x31D6F10
	public Texture get_texture() { }

	[NativeNameAttribute] // RVA: 0x447140 Offset: 0x447241 VA: 0x447140
	// RVA: 0x31D6F60 Offset: 0x31D7061 VA: 0x31D6F60
	public Vector4 get_textureHDRDecodeValues() { }

	// RVA: 0x31D7010 Offset: 0x31D7111 VA: 0x31D7010
	public void Reset() { }

	// RVA: 0x31D7060 Offset: 0x31D7161 VA: 0x31D7060
	public int RenderProbe() { }

	// RVA: 0x31D70E0 Offset: 0x31D71E1 VA: 0x31D70E0
	public int RenderProbe(RenderTexture targetTexture) { }

	// RVA: 0x31D71C0 Offset: 0x31D72C1 VA: 0x31D71C0
	public bool IsFinishedRendering(int renderId) { }

	// RVA: 0x31D7160 Offset: 0x31D7261 VA: 0x31D7160
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[FreeFunctionAttribute] // RVA: 0x447180 Offset: 0x447281 VA: 0x447180
	[NativeHeaderAttribute] // RVA: 0x447180 Offset: 0x447281 VA: 0x447180
	// RVA: 0x31D7210 Offset: 0x31D7311 VA: 0x31D7210
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	// RVA: 0x31D7280 Offset: 0x31D7381 VA: 0x31D7280
	public static int get_minBakedCubemapResolution() { }

	// RVA: 0x31D72C0 Offset: 0x31D73C1 VA: 0x31D72C0
	public static int get_maxBakedCubemapResolution() { }

	// RVA: 0x31D7300 Offset: 0x31D7401 VA: 0x31D7300
	public static Vector4 get_defaultTextureHDRDecodeValues() { }

	// RVA: 0x31D73B0 Offset: 0x31D74B1 VA: 0x31D73B0
	public static Texture get_defaultTexture() { }

	[CompilerGeneratedAttribute] // RVA: 0x4471E0 Offset: 0x4472E1 VA: 0x4471E0
	// RVA: 0x31D73F0 Offset: 0x31D74F1 VA: 0x31D73F0
	public static void add_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4471F0 Offset: 0x4472F1 VA: 0x4471F0
	// RVA: 0x31D74B0 Offset: 0x31D75B1 VA: 0x31D74B0
	public static void remove_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x447200 Offset: 0x447301 VA: 0x447200
	// RVA: 0x31D7570 Offset: 0x31D7671 VA: 0x31D7570
	public static void add_defaultReflectionSet(Action<Cubemap> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x447210 Offset: 0x447311 VA: 0x447210
	// RVA: 0x31D7640 Offset: 0x31D7741 VA: 0x31D7640
	public static void remove_defaultReflectionSet(Action<Cubemap> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447220 Offset: 0x447321 VA: 0x447220
	// RVA: 0x31D7710 Offset: 0x31D7811 VA: 0x31D7710
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447230 Offset: 0x447331 VA: 0x447230
	// RVA: 0x31D77A0 Offset: 0x31D78A1 VA: 0x31D77A0
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	// RVA: 0x31D7830 Offset: 0x31D7931 VA: 0x31D7830
	public void .ctor() { }

	// RVA: 0x31D5F40 Offset: 0x31D6041 VA: 0x31D5F40
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x31D5FF0 Offset: 0x31D60F1 VA: 0x31D5FF0
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x31D60A0 Offset: 0x31D61A1 VA: 0x31D60A0
	private void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x31D6150 Offset: 0x31D6251 VA: 0x31D6150
	private void set_center_Injected(ref Vector3 value) { }

	// RVA: 0x31D6400 Offset: 0x31D6501 VA: 0x31D6400
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x31D6870 Offset: 0x31D6971 VA: 0x31D6870
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x31D6920 Offset: 0x31D6A21 VA: 0x31D6920
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x31D6FC0 Offset: 0x31D70C1 VA: 0x31D6FC0
	private void get_textureHDRDecodeValues_Injected(out Vector4 ret) { }

	// RVA: 0x31D7360 Offset: 0x31D7461 VA: 0x31D7360
	private static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret) { }
}

