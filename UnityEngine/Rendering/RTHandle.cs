// Namespace: UnityEngine.Rendering
public class RTHandle // TypeDefIndex: 4605
{
	// Fields
	internal RTHandleSystem m_Owner; // 0x10
	internal RenderTexture m_RT; // 0x18
	internal Texture m_ExternalTexture; // 0x20
	internal RenderTargetIdentifier m_NameID; // 0x28
	internal bool m_EnableMSAA; // 0x50
	internal bool m_EnableRandomWrite; // 0x51
	internal bool m_EnableHWDynamicScale; // 0x52
	internal string m_Name; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x3CC40 Offset: 0x3CD41 VA: 0x3CC40
	private Vector2 <scaleFactor>k__BackingField; // 0x60
	internal ScaleFunc scaleFunc; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x3CC50 Offset: 0x3CD51 VA: 0x3CC50
	private bool <useScaling>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x3CC60 Offset: 0x3CD61 VA: 0x3CC60
	private Vector2Int <referenceSize>k__BackingField; // 0x74

	// Properties
	public Vector2 scaleFactor { get; set; }
	public bool useScaling { get; set; }
	public Vector2Int referenceSize { get; set; }
	public RTHandleProperties rtHandleProperties { get; }
	public RenderTexture rt { get; }
	public RenderTargetIdentifier nameID { get; }
	public string name { get; }
	public bool isMSAAEnabled { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3DA70 Offset: 0x3DB71 VA: 0x3DA70
	// RVA: 0x1A13690 Offset: 0x1A13791 VA: 0x1A13690
	public Vector2 get_scaleFactor() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA80 Offset: 0x3DB81 VA: 0x3DA80
	// RVA: 0x1A136A0 Offset: 0x1A137A1 VA: 0x1A136A0
	internal void set_scaleFactor(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA90 Offset: 0x3DB91 VA: 0x3DA90
	// RVA: 0x1A136B0 Offset: 0x1A137B1 VA: 0x1A136B0
	public bool get_useScaling() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DAA0 Offset: 0x3DBA1 VA: 0x3DAA0
	// RVA: 0x1A136C0 Offset: 0x1A137C1 VA: 0x1A136C0
	internal void set_useScaling(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DAB0 Offset: 0x3DBB1 VA: 0x3DAB0
	// RVA: 0x1A136D0 Offset: 0x1A137D1 VA: 0x1A136D0
	public Vector2Int get_referenceSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DAC0 Offset: 0x3DBC1 VA: 0x3DAC0
	// RVA: 0x1A136E0 Offset: 0x1A137E1 VA: 0x1A136E0
	internal void set_referenceSize(Vector2Int value) { }

	// RVA: 0x1A136F0 Offset: 0x1A137F1 VA: 0x1A136F0
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x1A13710 Offset: 0x1A13811 VA: 0x1A13710
	public RenderTexture get_rt() { }

	// RVA: 0x1A13720 Offset: 0x1A13821 VA: 0x1A13720
	public RenderTargetIdentifier get_nameID() { }

	// RVA: 0x1A13740 Offset: 0x1A13841 VA: 0x1A13740
	public string get_name() { }

	// RVA: 0x1A13750 Offset: 0x1A13851 VA: 0x1A13750
	public bool get_isMSAAEnabled() { }

	// RVA: 0x1A13760 Offset: 0x1A13861 VA: 0x1A13760
	internal void .ctor(RTHandleSystem owner) { }

	// RVA: 0x1A137A0 Offset: 0x1A138A1 VA: 0x1A137A0
	public static RenderTexture op_Implicit(RTHandle handle) { }

	// RVA: 0x1A137B0 Offset: 0x1A138B1 VA: 0x1A137B0
	public static Texture op_Implicit(RTHandle handle) { }

	// RVA: 0x1A13850 Offset: 0x1A13951 VA: 0x1A13850
	public static RenderTargetIdentifier op_Implicit(RTHandle handle) { }

	// RVA: 0x1A13880 Offset: 0x1A13981 VA: 0x1A13880
	internal void SetRenderTexture(RenderTexture rt) { }

	// RVA: 0x1A13900 Offset: 0x1A13A01 VA: 0x1A13900
	internal void SetTexture(Texture tex) { }

	// RVA: 0x1A13980 Offset: 0x1A13A81 VA: 0x1A13980
	internal void SetTexture(RenderTargetIdentifier tex) { }

	// RVA: 0x1A139D0 Offset: 0x1A13AD1 VA: 0x1A139D0
	public void Release() { }

	// RVA: 0x1A13B50 Offset: 0x1A13C51 VA: 0x1A13B50
	public Vector2Int GetScaledSize(Vector2Int refSize) { }

	// RVA: 0x1A13BD0 Offset: 0x1A13CD1 VA: 0x1A13BD0
	public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1, bool copyContents = False) { }

	// RVA: 0x1A13C60 Offset: 0x1A13D61 VA: 0x1A13C60
	public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1) { }

	// RVA: 0x1A13CF0 Offset: 0x1A13DF1 VA: 0x1A13CF0
	public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = True) { }
}

