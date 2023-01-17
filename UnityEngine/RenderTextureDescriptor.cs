// Namespace: UnityEngine
public struct RenderTextureDescriptor // TypeDefIndex: 3523
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x442F90 Offset: 0x443091 VA: 0x442F90
	[DebuggerBrowsableAttribute] // RVA: 0x442F90 Offset: 0x443091 VA: 0x442F90
	private int <width>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x442FD0 Offset: 0x4430D1 VA: 0x442FD0
	[DebuggerBrowsableAttribute] // RVA: 0x442FD0 Offset: 0x4430D1 VA: 0x442FD0
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsableAttribute] // RVA: 0x443010 Offset: 0x443111 VA: 0x443010
	[CompilerGeneratedAttribute] // RVA: 0x443010 Offset: 0x443111 VA: 0x443010
	private int <msaaSamples>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x443050 Offset: 0x443151 VA: 0x443050
	[CompilerGeneratedAttribute] // RVA: 0x443050 Offset: 0x443151 VA: 0x443050
	private int <volumeDepth>k__BackingField; // 0xC
	[DebuggerBrowsableAttribute] // RVA: 0x443090 Offset: 0x443191 VA: 0x443090
	[CompilerGeneratedAttribute] // RVA: 0x443090 Offset: 0x443191 VA: 0x443090
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x4430D0 Offset: 0x4431D1 VA: 0x4430D0
	[DebuggerBrowsableAttribute] // RVA: 0x4430D0 Offset: 0x4431D1 VA: 0x4430D0
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	private int _depthBufferBits; // 0x1C
	private static int[] depthFormatBits; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x443110 Offset: 0x443211 VA: 0x443110
	[DebuggerBrowsableAttribute] // RVA: 0x443110 Offset: 0x443211 VA: 0x443110
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x443150 Offset: 0x443251 VA: 0x443150
	[DebuggerBrowsableAttribute] // RVA: 0x443150 Offset: 0x443251 VA: 0x443150
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x443190 Offset: 0x443291 VA: 0x443190
	[DebuggerBrowsableAttribute] // RVA: 0x443190 Offset: 0x443291 VA: 0x443190
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x4431D0 Offset: 0x4432D1 VA: 0x4431D0
	[DebuggerBrowsableAttribute] // RVA: 0x4431D0 Offset: 0x4432D1 VA: 0x4431D0
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
	public int width { get; set; }
	public int height { get; set; }
	public int msaaSamples { get; set; }
	public int volumeDepth { get; set; }
	public int mipCount { get; set; }
	public GraphicsFormat graphicsFormat { get; set; }
	public GraphicsFormat stencilFormat { set; }
	public RenderTextureFormat colorFormat { get; set; }
	public bool sRGB { get; set; }
	public int depthBufferBits { get; set; }
	public TextureDimension dimension { get; set; }
	public ShadowSamplingMode shadowSamplingMode { set; }
	public VRTextureUsage vrUsage { get; set; }
	public RenderTextureMemoryless memoryless { set; }
	public bool useMipMap { set; }
	public bool autoGenerateMips { set; }
	public bool enableRandomWrite { set; }
	public bool bindMS { set; }
	internal bool createdFromScript { set; }
	public bool useDynamicScale { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x44DCE0 Offset: 0x44DDE1 VA: 0x44DCE0
	[CompilerGeneratedAttribute] // RVA: 0x44DCE0 Offset: 0x44DDE1 VA: 0x44DCE0
	// RVA: 0x31DF920 Offset: 0x31DFA21 VA: 0x31DF920
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x44DD20 Offset: 0x44DE21 VA: 0x44DD20
	// RVA: 0x31DF930 Offset: 0x31DFA31 VA: 0x31DF930
	public void set_width(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x44DD30 Offset: 0x44DE31 VA: 0x44DD30
	[CompilerGeneratedAttribute] // RVA: 0x44DD30 Offset: 0x44DE31 VA: 0x44DD30
	// RVA: 0x31DF940 Offset: 0x31DFA41 VA: 0x31DF940
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x44DD70 Offset: 0x44DE71 VA: 0x44DD70
	// RVA: 0x31DF950 Offset: 0x31DFA51 VA: 0x31DF950
	public void set_height(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x44DD80 Offset: 0x44DE81 VA: 0x44DD80
	[CompilerGeneratedAttribute] // RVA: 0x44DD80 Offset: 0x44DE81 VA: 0x44DD80
	// RVA: 0x31DF960 Offset: 0x31DFA61 VA: 0x31DF960
	public int get_msaaSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x44DDC0 Offset: 0x44DEC1 VA: 0x44DDC0
	// RVA: 0x31DF970 Offset: 0x31DFA71 VA: 0x31DF970
	public void set_msaaSamples(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x44DDD0 Offset: 0x44DED1 VA: 0x44DDD0
	[IsReadOnlyAttribute] // RVA: 0x44DDD0 Offset: 0x44DED1 VA: 0x44DDD0
	// RVA: 0x31DF980 Offset: 0x31DFA81 VA: 0x31DF980
	public int get_volumeDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x44DE10 Offset: 0x44DF11 VA: 0x44DE10
	// RVA: 0x31DF990 Offset: 0x31DFA91 VA: 0x31DF990
	public void set_volumeDepth(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x44DE20 Offset: 0x44DF21 VA: 0x44DE20
	[CompilerGeneratedAttribute] // RVA: 0x44DE20 Offset: 0x44DF21 VA: 0x44DE20
	// RVA: 0x31DF9A0 Offset: 0x31DFAA1 VA: 0x31DF9A0
	public int get_mipCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x44DE60 Offset: 0x44DF61 VA: 0x44DE60
	// RVA: 0x31DF9B0 Offset: 0x31DFAB1 VA: 0x31DF9B0
	public void set_mipCount(int value) { }

	// RVA: 0x31DEFF0 Offset: 0x31DF0F1 VA: 0x31DEFF0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x31DF9C0 Offset: 0x31DFAC1 VA: 0x31DF9C0
	public void set_graphicsFormat(GraphicsFormat value) { }

	[CompilerGeneratedAttribute] // RVA: 0x44DE70 Offset: 0x44DF71 VA: 0x44DE70
	// RVA: 0x31DFA30 Offset: 0x31DFB31 VA: 0x31DFA30
	public void set_stencilFormat(GraphicsFormat value) { }

	// RVA: 0x31DFA40 Offset: 0x31DFB41 VA: 0x31DFA40
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x31DFA50 Offset: 0x31DFB51 VA: 0x31DFA50
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x31DFAC0 Offset: 0x31DFBC1 VA: 0x31DFAC0
	public bool get_sRGB() { }

	// RVA: 0x31DFAD0 Offset: 0x31DFBD1 VA: 0x31DFAD0
	public void set_sRGB(bool value) { }

	// RVA: 0x31DF000 Offset: 0x31DF101 VA: 0x31DF000
	public int get_depthBufferBits() { }

	// RVA: 0x31DFB30 Offset: 0x31DFC31 VA: 0x31DFB30
	public void set_depthBufferBits(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x44DE80 Offset: 0x44DF81 VA: 0x44DE80
	[IsReadOnlyAttribute] // RVA: 0x44DE80 Offset: 0x44DF81 VA: 0x44DE80
	// RVA: 0x31DFB60 Offset: 0x31DFC61 VA: 0x31DFB60
	public TextureDimension get_dimension() { }

	[CompilerGeneratedAttribute] // RVA: 0x44DEC0 Offset: 0x44DFC1 VA: 0x44DEC0
	// RVA: 0x31DFB70 Offset: 0x31DFC71 VA: 0x31DFB70
	public void set_dimension(TextureDimension value) { }

	[CompilerGeneratedAttribute] // RVA: 0x44DED0 Offset: 0x44DFD1 VA: 0x44DED0
	// RVA: 0x31DFB80 Offset: 0x31DFC81 VA: 0x31DFB80
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[IsReadOnlyAttribute] // RVA: 0x44DEE0 Offset: 0x44DFE1 VA: 0x44DEE0
	[CompilerGeneratedAttribute] // RVA: 0x44DEE0 Offset: 0x44DFE1 VA: 0x44DEE0
	// RVA: 0x31DFB90 Offset: 0x31DFC91 VA: 0x31DFB90
	public VRTextureUsage get_vrUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x44DF20 Offset: 0x44E021 VA: 0x44DF20
	// RVA: 0x31DFBA0 Offset: 0x31DFCA1 VA: 0x31DFBA0
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x44DF30 Offset: 0x44E031 VA: 0x44DF30
	// RVA: 0x31DFBB0 Offset: 0x31DFCB1 VA: 0x31DFBB0
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x31DFBC0 Offset: 0x31DFCC1 VA: 0x31DFBC0
	public void .ctor(int width, int height) { }

	// RVA: 0x31DF2D0 Offset: 0x31DF3D1 VA: 0x31DF2D0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x31DFCB0 Offset: 0x31DFDB1 VA: 0x31DFCB0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x31DEBE0 Offset: 0x31DECE1 VA: 0x31DEBE0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x31DFA10 Offset: 0x31DFB11 VA: 0x31DFA10
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x31DFD90 Offset: 0x31DFE91 VA: 0x31DFD90
	public void set_useMipMap(bool value) { }

	// RVA: 0x31DFDB0 Offset: 0x31DFEB1 VA: 0x31DFDB0
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x31DFDD0 Offset: 0x31DFED1 VA: 0x31DFDD0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x31DFDF0 Offset: 0x31DFEF1 VA: 0x31DFDF0
	public void set_bindMS(bool value) { }

	// RVA: 0x31DF150 Offset: 0x31DF251 VA: 0x31DF150
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x31DFE10 Offset: 0x31DFF11 VA: 0x31DFE10
	public bool get_useDynamicScale() { }

	// RVA: 0x31DF3E0 Offset: 0x31DF4E1 VA: 0x31DF3E0
	public void set_useDynamicScale(bool value) { }

	// RVA: 0x31DFE20 Offset: 0x31DFF21 VA: 0x31DFE20
	private static void .cctor() { }
}

