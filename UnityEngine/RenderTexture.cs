// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D570 Offset: 0x43D671 VA: 0x43D570
[NativeHeaderAttribute] // RVA: 0x43D570 Offset: 0x43D671 VA: 0x43D570
[UsedByNativeCodeAttribute] // RVA: 0x43D570 Offset: 0x43D671 VA: 0x43D570
[NativeHeaderAttribute] // RVA: 0x43D570 Offset: 0x43D671 VA: 0x43D570
[NativeHeaderAttribute] // RVA: 0x43D570 Offset: 0x43D671 VA: 0x43D570
public class RenderTexture : Texture // TypeDefIndex: 3521
{
	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public override TextureDimension dimension { get; set; }
	[NativePropertyAttribute] // RVA: 0x45A0E0 Offset: 0x45A1E1 VA: 0x45A0E0
	public GraphicsFormat graphicsFormat { get; set; }
	[NativePropertyAttribute] // RVA: 0x45A120 Offset: 0x45A221 VA: 0x45A120
	public bool useMipMap { get; set; }
	[NativePropertyAttribute] // RVA: 0x45A160 Offset: 0x45A261 VA: 0x45A160
	public bool sRGB { get; }
	[NativePropertyAttribute] // RVA: 0x45A1A0 Offset: 0x45A2A1 VA: 0x45A1A0
	public VRTextureUsage vrUsage { get; set; }
	[NativePropertyAttribute] // RVA: 0x45A1E0 Offset: 0x45A2E1 VA: 0x45A1E0
	public RenderTextureMemoryless memorylessMode { get; set; }
	public RenderTextureFormat format { get; set; }
	public GraphicsFormat stencilFormat { get; set; }
	public bool autoGenerateMips { get; set; }
	public int volumeDepth { get; set; }
	public int antiAliasing { get; set; }
	public bool bindTextureMS { get; set; }
	public bool enableRandomWrite { get; set; }
	public bool useDynamicScale { get; set; }
	public bool isPowerOfTwo { get; set; }
	public static RenderTexture active { get; set; }
	public RenderBuffer colorBuffer { get; }
	public RenderBuffer depthBuffer { get; }
	public int depth { get; set; }
	public RenderTextureDescriptor descriptor { get; set; }
	[ObsoleteAttribute] // RVA: 0x45A220 Offset: 0x45A321 VA: 0x45A220
	public bool isCubemap { get; set; }
	[ObsoleteAttribute] // RVA: 0x45A260 Offset: 0x45A361 VA: 0x45A260
	public bool isVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0x45A2A0 Offset: 0x45A3A1 VA: 0x45A2A0
	[EditorBrowsableAttribute] // RVA: 0x45A2A0 Offset: 0x45A3A1 VA: 0x45A2A0
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x31DC8B0 Offset: 0x31DC9B1 VA: 0x31DC8B0 Slot: 5
	public override int get_width() { }

	// RVA: 0x31DC900 Offset: 0x31DCA01 VA: 0x31DC900 Slot: 6
	public override void set_width(int value) { }

	// RVA: 0x31DC950 Offset: 0x31DCA51 VA: 0x31DC950 Slot: 7
	public override int get_height() { }

	// RVA: 0x31DC9A0 Offset: 0x31DCAA1 VA: 0x31DC9A0 Slot: 8
	public override void set_height(int value) { }

	// RVA: 0x31DC9F0 Offset: 0x31DCAF1 VA: 0x31DC9F0 Slot: 9
	public override TextureDimension get_dimension() { }

	// RVA: 0x31DCA40 Offset: 0x31DCB41 VA: 0x31DCA40 Slot: 10
	public override void set_dimension(TextureDimension value) { }

	// RVA: 0x31DCA90 Offset: 0x31DCB91 VA: 0x31DCA90
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x31DCAE0 Offset: 0x31DCBE1 VA: 0x31DCAE0
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x31DCB30 Offset: 0x31DCC31 VA: 0x31DCB30
	public bool get_useMipMap() { }

	// RVA: 0x31DCB80 Offset: 0x31DCC81 VA: 0x31DCB80
	public void set_useMipMap(bool value) { }

	// RVA: 0x31DCBD0 Offset: 0x31DCCD1 VA: 0x31DCBD0
	public bool get_sRGB() { }

	// RVA: 0x31DCC20 Offset: 0x31DCD21 VA: 0x31DCC20
	public VRTextureUsage get_vrUsage() { }

	// RVA: 0x31DCC70 Offset: 0x31DCD71 VA: 0x31DCC70
	public void set_vrUsage(VRTextureUsage value) { }

	// RVA: 0x31DCCC0 Offset: 0x31DCDC1 VA: 0x31DCCC0
	public RenderTextureMemoryless get_memorylessMode() { }

	// RVA: 0x31DCD10 Offset: 0x31DCE11 VA: 0x31DCD10
	public void set_memorylessMode(RenderTextureMemoryless value) { }

	// RVA: 0x31DCD60 Offset: 0x31DCE61 VA: 0x31DCD60
	public RenderTextureFormat get_format() { }

	// RVA: 0x31DCDB0 Offset: 0x31DCEB1 VA: 0x31DCDB0
	public void set_format(RenderTextureFormat value) { }

	// RVA: 0x31DCE40 Offset: 0x31DCF41 VA: 0x31DCE40
	public GraphicsFormat get_stencilFormat() { }

	// RVA: 0x31DCE90 Offset: 0x31DCF91 VA: 0x31DCE90
	public void set_stencilFormat(GraphicsFormat value) { }

	// RVA: 0x31DCEE0 Offset: 0x31DCFE1 VA: 0x31DCEE0
	public bool get_autoGenerateMips() { }

	// RVA: 0x31DCF30 Offset: 0x31DD031 VA: 0x31DCF30
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x31DCF80 Offset: 0x31DD081 VA: 0x31DCF80
	public int get_volumeDepth() { }

	// RVA: 0x31DCFD0 Offset: 0x31DD0D1 VA: 0x31DCFD0
	public void set_volumeDepth(int value) { }

	// RVA: 0x31DD020 Offset: 0x31DD121 VA: 0x31DD020
	public int get_antiAliasing() { }

	// RVA: 0x31DD070 Offset: 0x31DD171 VA: 0x31DD070
	public void set_antiAliasing(int value) { }

	// RVA: 0x31DD0C0 Offset: 0x31DD1C1 VA: 0x31DD0C0
	public bool get_bindTextureMS() { }

	// RVA: 0x31DD110 Offset: 0x31DD211 VA: 0x31DD110
	public void set_bindTextureMS(bool value) { }

	// RVA: 0x31DD160 Offset: 0x31DD261 VA: 0x31DD160
	public bool get_enableRandomWrite() { }

	// RVA: 0x31DD1B0 Offset: 0x31DD2B1 VA: 0x31DD1B0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x31DD200 Offset: 0x31DD301 VA: 0x31DD200
	public bool get_useDynamicScale() { }

	// RVA: 0x31DD250 Offset: 0x31DD351 VA: 0x31DD250
	public void set_useDynamicScale(bool value) { }

	// RVA: 0x31DD2A0 Offset: 0x31DD3A1 VA: 0x31DD2A0
	private bool GetIsPowerOfTwo() { }

	// RVA: 0x31DD2F0 Offset: 0x31DD3F1 VA: 0x31DD2F0
	public bool get_isPowerOfTwo() { }

	// RVA: 0x31DD340 Offset: 0x31DD441 VA: 0x31DD340
	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x44D760 Offset: 0x44D861 VA: 0x44D760
	// RVA: 0x31DD350 Offset: 0x31DD451 VA: 0x31DD350
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0x44D7A0 Offset: 0x44D8A1 VA: 0x44D7A0
	// RVA: 0x31DD390 Offset: 0x31DD491 VA: 0x31DD390
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x31DD3E0 Offset: 0x31DD4E1 VA: 0x31DD3E0
	public static RenderTexture get_active() { }

	// RVA: 0x31DD420 Offset: 0x31DD521 VA: 0x31DD420
	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0x44D7E0 Offset: 0x44D8E1 VA: 0x44D7E0
	// RVA: 0x31DD470 Offset: 0x31DD571 VA: 0x31DD470
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x44D830 Offset: 0x44D931 VA: 0x44D830
	// RVA: 0x31DD520 Offset: 0x31DD621 VA: 0x31DD520
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x31DD5D0 Offset: 0x31DD6D1 VA: 0x31DD5D0
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x31DD630 Offset: 0x31DD731 VA: 0x31DD630
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x31DD690 Offset: 0x31DD791 VA: 0x31DD690
	public IntPtr GetNativeDepthBufferPtr() { }

	// RVA: 0x31DD6E0 Offset: 0x31DD7E1 VA: 0x31DD6E0
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x31DD740 Offset: 0x31DD841 VA: 0x31DD740
	public void MarkRestoreExpected() { }

	// RVA: 0x31DD790 Offset: 0x31DD891 VA: 0x31DD790
	public void DiscardContents() { }

	[NativeNameAttribute] // RVA: 0x44D880 Offset: 0x44D981 VA: 0x44D880
	// RVA: 0x31DD7E0 Offset: 0x31DD8E1 VA: 0x31DD7E0
	private void ResolveAA() { }

	[NativeNameAttribute] // RVA: 0x44D8C0 Offset: 0x44D9C1 VA: 0x44D8C0
	// RVA: 0x31DD830 Offset: 0x31DD931 VA: 0x31DD830
	private void ResolveAATo(RenderTexture rt) { }

	// RVA: 0x31DD880 Offset: 0x31DD981 VA: 0x31DD880
	public void ResolveAntiAliasedSurface() { }

	// RVA: 0x31DD8D0 Offset: 0x31DD9D1 VA: 0x31DD8D0
	public void ResolveAntiAliasedSurface(RenderTexture target) { }

	[FreeFunctionAttribute] // RVA: 0x44D900 Offset: 0x44DA01 VA: 0x44D900
	// RVA: 0x31DD920 Offset: 0x31DDA21 VA: 0x31DD920
	public void SetGlobalShaderProperty(string propertyName) { }

	// RVA: 0x31DD970 Offset: 0x31DDA71 VA: 0x31DD970
	public bool Create() { }

	// RVA: 0x31DD9C0 Offset: 0x31DDAC1 VA: 0x31DD9C0
	public void Release() { }

	// RVA: 0x31DDA10 Offset: 0x31DDB11 VA: 0x31DDA10
	public bool IsCreated() { }

	// RVA: 0x31DDA60 Offset: 0x31DDB61 VA: 0x31DDA60
	public void GenerateMips() { }

	[NativeThrowsAttribute] // RVA: 0x44D950 Offset: 0x44DA51 VA: 0x44D950
	// RVA: 0x31DDAB0 Offset: 0x31DDBB1 VA: 0x31DDAB0
	public void ConvertToEquirect(RenderTexture equirect, Camera.MonoOrStereoscopicEye eye = 2) { }

	// RVA: 0x31DDB10 Offset: 0x31DDC11 VA: 0x31DDB10
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0x44D960 Offset: 0x44DA61 VA: 0x44D960
	// RVA: 0x31DDB60 Offset: 0x31DDC61 VA: 0x31DDB60
	private static void Internal_Create(RenderTexture rt) { }

	[FreeFunctionAttribute] // RVA: 0x44D9A0 Offset: 0x44DAA1 VA: 0x44D9A0
	// RVA: 0x31DDBB0 Offset: 0x31DDCB1 VA: 0x31DDBB0
	public static bool SupportsStencil(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0x44D9E0 Offset: 0x44DAE1 VA: 0x44D9E0
	// RVA: 0x31DDC00 Offset: 0x31DDD01 VA: 0x31DDC00
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0x44DA20 Offset: 0x44DB21 VA: 0x44DA20
	// RVA: 0x31DDCA0 Offset: 0x31DDDA1 VA: 0x31DDCA0
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0x44DA60 Offset: 0x44DB61 VA: 0x44DA60
	// RVA: 0x31DDD80 Offset: 0x31DDE81 VA: 0x31DDD80
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x44DAA0 Offset: 0x44DBA1 VA: 0x44DAA0
	// RVA: 0x31DDE20 Offset: 0x31DDF21 VA: 0x31DDE20
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0x44DAE0 Offset: 0x44DBE1 VA: 0x44DAE0
	// RVA: 0x31DDE70 Offset: 0x31DDF71 VA: 0x31DDE70
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0x44DB30 Offset: 0x44DC31 VA: 0x44DB30
	// RVA: 0x31DDEC0 Offset: 0x31DDFC1 VA: 0x31DDEC0
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44DB80 Offset: 0x44DC81 VA: 0x44DB80
	// RVA: 0x31DDF10 Offset: 0x31DE011 VA: 0x31DDF10
	protected internal void .ctor() { }

	// RVA: 0x31DDF80 Offset: 0x31DE081 VA: 0x31DDF80
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x31DE440 Offset: 0x31DE541 VA: 0x31DE440
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x31DE770 Offset: 0x31DE871 VA: 0x31DE770
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x31DE7C0 Offset: 0x31DE8C1 VA: 0x31DE7C0
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x31DE980 Offset: 0x31DEA81 VA: 0x31DE980
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x31DED40 Offset: 0x31DEE41 VA: 0x31DED40
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DB90 Offset: 0x44DC91 VA: 0x44DB90
	// RVA: 0x31DEEF0 Offset: 0x31DEFF1 VA: 0x31DEEF0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DBA0 Offset: 0x44DCA1 VA: 0x44DBA0
	// RVA: 0x31DEF40 Offset: 0x31DF041 VA: 0x31DEF40
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DBB0 Offset: 0x44DCB1 VA: 0x44DBB0
	// RVA: 0x31DEF90 Offset: 0x31DF091 VA: 0x31DEF90
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x31DE6B0 Offset: 0x31DE7B1 VA: 0x31DE6B0
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x31DEC90 Offset: 0x31DED91 VA: 0x31DEC90
	public void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x31DE0B0 Offset: 0x31DE1B1 VA: 0x31DE0B0
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x31DED90 Offset: 0x31DEE91 VA: 0x31DED90
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x31DF0A0 Offset: 0x31DF1A1 VA: 0x31DF0A0
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x31DF170 Offset: 0x31DF271 VA: 0x31DF170
	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DBC0 Offset: 0x44DCC1 VA: 0x44DBC0
	// RVA: 0x31DF400 Offset: 0x31DF501 VA: 0x31DF400
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DBD0 Offset: 0x44DCD1 VA: 0x44DBD0
	// RVA: 0x31DF410 Offset: 0x31DF511 VA: 0x31DF410
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DBE0 Offset: 0x44DCE1 VA: 0x44DBE0
	// RVA: 0x31DF430 Offset: 0x31DF531 VA: 0x31DF430
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DBF0 Offset: 0x44DCF1 VA: 0x44DBF0
	// RVA: 0x31DF460 Offset: 0x31DF561 VA: 0x31DF460
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DC00 Offset: 0x44DD01 VA: 0x44DC00
	// RVA: 0x31DF490 Offset: 0x31DF591 VA: 0x31DF490
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format) { }

	// RVA: 0x31DF4C0 Offset: 0x31DF5C1 VA: 0x31DF4C0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DC10 Offset: 0x44DD11 VA: 0x44DC10
	// RVA: 0x31DF540 Offset: 0x31DF641 VA: 0x31DF540
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DC20 Offset: 0x44DD21 VA: 0x44DC20
	// RVA: 0x31DF5B0 Offset: 0x31DF6B1 VA: 0x31DF5B0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DC30 Offset: 0x44DD31 VA: 0x44DC30
	// RVA: 0x31DF630 Offset: 0x31DF731 VA: 0x31DF630
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DC40 Offset: 0x44DD41 VA: 0x44DC40
	// RVA: 0x31DF6A0 Offset: 0x31DF7A1 VA: 0x31DF6A0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DC50 Offset: 0x44DD51 VA: 0x44DC50
	// RVA: 0x31DF710 Offset: 0x31DF811 VA: 0x31DF710
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DC60 Offset: 0x44DD61 VA: 0x44DC60
	// RVA: 0x31DF780 Offset: 0x31DF881 VA: 0x31DF780
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44DC70 Offset: 0x44DD71 VA: 0x44DC70
	// RVA: 0x31DF7F0 Offset: 0x31DF8F1 VA: 0x31DF7F0
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x31DF850 Offset: 0x31DF951 VA: 0x31DF850
	public bool get_isCubemap() { }

	// RVA: 0x31DF880 Offset: 0x31DF981 VA: 0x31DF880
	public void set_isCubemap(bool value) { }

	// RVA: 0x31DF8A0 Offset: 0x31DF9A1 VA: 0x31DF8A0
	public bool get_isVolume() { }

	// RVA: 0x31DF8D0 Offset: 0x31DF9D1 VA: 0x31DF8D0
	public void set_isVolume(bool value) { }

	// RVA: 0x31DF8F0 Offset: 0x31DF9F1 VA: 0x31DF8F0
	public static bool get_enabled() { }

	// RVA: 0x31DF900 Offset: 0x31DFA01 VA: 0x31DF900
	public static void set_enabled(bool value) { }

	[EditorBrowsableAttribute] // RVA: 0x44DC80 Offset: 0x44DD81 VA: 0x44DC80
	[ObsoleteAttribute] // RVA: 0x44DC80 Offset: 0x44DD81 VA: 0x44DC80
	// RVA: 0x31DF910 Offset: 0x31DFA11 VA: 0x31DF910
	public Vector2 GetTexelOffset() { }

	// RVA: 0x31DD4D0 Offset: 0x31DD5D1 VA: 0x31DD4D0
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x31DD580 Offset: 0x31DD681 VA: 0x31DD580
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x31DDC50 Offset: 0x31DDD51 VA: 0x31DDC50
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x31DDD30 Offset: 0x31DDE31 VA: 0x31DDD30
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x31DDDD0 Offset: 0x31DDED1 VA: 0x31DDDD0
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }
}

