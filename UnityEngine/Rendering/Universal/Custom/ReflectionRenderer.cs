// Namespace: UnityEngine.Rendering.Universal.Custom
public sealed class ReflectionRenderer : ScriptableRenderer // TypeDefIndex: 5436
{
	// Fields
	private const int k_DepthStencilBufferBits = 32;
	private const string k_CreateCameraTextures = "Create Camera Texture";
	private const string k_SubLightTag = "CharaLight";
	private const string k_SetupCustomRPConstants = "Setup CustomRP Constants";
	private static readonly int s_CustomExposurePropID; // 0x0
	private static readonly int s_CustomLodFadeBiasPropID; // 0x4
	private static readonly int s_CustomReflectionBaseYPropID; // 0x8
	private static readonly int s_CustomReflectionBaseYvPropID; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x483800 Offset: 0x483901 VA: 0x483800
	private static float <reflectionBaseY>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x483810 Offset: 0x483911 VA: 0x483810
	private static float <reflectionBaseY_Chara>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x483820 Offset: 0x483921 VA: 0x483820
	private static float <reflectionBaseY_Map>k__BackingField; // 0x18
	private CustomBaseOpaquePass m_CustomBaseOpaquePass; // 0x90
	private CustomCharaOpaquePass m_CustomCharaOpaquePass; // 0x98
	private CustomSpecialReflectionPass m_CustomSpecialReflectionPass; // 0xA0
	private bool m_UseCustomBaseOpaquePass; // 0xA8
	private bool m_UseSpecialReflectionPass; // 0xA9
	private RenderTargetHandle m_ActiveCameraColorAttachment; // 0xB0
	private RenderTargetHandle m_ActiveCameraDepthAttachment; // 0xE0
	private ForwardLights m_ForwardLights; // 0x110

	// Properties
	public static float reflectionBaseY { get; set; }
	public static float reflectionBaseY_Chara { get; set; }
	public static float reflectionBaseY_Map { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484E90 Offset: 0x484F91 VA: 0x484E90
	// RVA: 0x33718F0 Offset: 0x33719F1 VA: 0x33718F0
	public static float get_reflectionBaseY() { }

	[CompilerGeneratedAttribute] // RVA: 0x484EA0 Offset: 0x484FA1 VA: 0x484EA0
	// RVA: 0x3371960 Offset: 0x3371A61 VA: 0x3371960
	public static void set_reflectionBaseY(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484EB0 Offset: 0x484FB1 VA: 0x484EB0
	// RVA: 0x33719D0 Offset: 0x3371AD1 VA: 0x33719D0
	public static float get_reflectionBaseY_Chara() { }

	[CompilerGeneratedAttribute] // RVA: 0x484EC0 Offset: 0x484FC1 VA: 0x484EC0
	// RVA: 0x3371A40 Offset: 0x3371B41 VA: 0x3371A40
	public static void set_reflectionBaseY_Chara(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484ED0 Offset: 0x484FD1 VA: 0x484ED0
	// RVA: 0x3371AB0 Offset: 0x3371BB1 VA: 0x3371AB0
	public static float get_reflectionBaseY_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x484EE0 Offset: 0x484FE1 VA: 0x484EE0
	// RVA: 0x3371B20 Offset: 0x3371C21 VA: 0x3371B20
	public static void set_reflectionBaseY_Map(float value) { }

	// RVA: 0x3371B90 Offset: 0x3371C91 VA: 0x3371B90
	public void .ctor(ReflectionRendererData data) { }

	// RVA: 0x3371FB0 Offset: 0x33720B1 VA: 0x3371FB0 Slot: 10
	public override string GetSubLightTag() { }

	// RVA: 0x3372000 Offset: 0x3372101 VA: 0x3372000 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3372010 Offset: 0x3372111 VA: 0x3372010 Slot: 6
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x33723B0 Offset: 0x33724B1 VA: 0x33723B0 Slot: 7
	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3372670 Offset: 0x3372771 VA: 0x3372670 Slot: 8
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x33726F0 Offset: 0x33727F1 VA: 0x33726F0 Slot: 9
	public override void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x3372910 Offset: 0x3372A11 VA: 0x3372910
	private static void .cctor() { }
}

