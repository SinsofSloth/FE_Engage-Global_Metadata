// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43CE50 Offset: 0x43CF51 VA: 0x43CE50
[RequireComponent] // RVA: 0x43CE50 Offset: 0x43CF51 VA: 0x43CE50
[RequireComponent] // RVA: 0x43CE50 Offset: 0x43CF51 VA: 0x43CE50
[NativeHeaderAttribute] // RVA: 0x43CE50 Offset: 0x43CF51 VA: 0x43CE50
public sealed class Light : Behaviour // TypeDefIndex: 3466
{
	// Fields
	private int m_BakedIndex; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0x459B60 Offset: 0x459C61 VA: 0x459B60
	public LightType type { get; set; }
	[NativePropertyAttribute] // RVA: 0x459BA0 Offset: 0x459CA1 VA: 0x459BA0
	public LightShape shape { get; set; }
	public float spotAngle { get; set; }
	public float innerSpotAngle { get; set; }
	public Color color { get; set; }
	public float colorTemperature { get; set; }
	public bool useColorTemperature { get; set; }
	public float intensity { get; set; }
	public float bounceIntensity { get; set; }
	public bool useBoundingSphereOverride { get; set; }
	public Vector4 boundingSphereOverride { get; set; }
	public bool useViewFrustumForShadowCasterCull { get; set; }
	public int shadowCustomResolution { get; set; }
	public float shadowBias { get; set; }
	public float shadowNormalBias { get; set; }
	public float shadowNearPlane { get; set; }
	public bool useShadowMatrixOverride { get; set; }
	public Matrix4x4 shadowMatrixOverride { get; set; }
	public float range { get; set; }
	public Flare flare { get; set; }
	public LightBakingOutput bakingOutput { get; set; }
	public int cullingMask { get; set; }
	public int renderingLayerMask { get; set; }
	public LightShadowCasterMode lightShadowCasterMode { get; set; }
	public LightShadows shadows { get; set; }
	public float shadowStrength { get; set; }
	public LightShadowResolution shadowResolution { get; set; }
	[ObsoleteAttribute] // RVA: 0x459BE0 Offset: 0x459CE1 VA: 0x459BE0
	[EditorBrowsableAttribute] // RVA: 0x459BE0 Offset: 0x459CE1 VA: 0x459BE0
	public float shadowSoftness { get; set; }
	[ObsoleteAttribute] // RVA: 0x459C40 Offset: 0x459D41 VA: 0x459C40
	[EditorBrowsableAttribute] // RVA: 0x459C40 Offset: 0x459D41 VA: 0x459C40
	public float shadowSoftnessFade { get; set; }
	public float[] layerShadowCullDistances { get; set; }
	public float cookieSize { get; set; }
	public Texture cookie { get; set; }
	public LightRenderMode renderMode { get; set; }
	[ObsoleteAttribute] // RVA: 0x459CA0 Offset: 0x459DA1 VA: 0x459CA0
	[EditorBrowsableAttribute] // RVA: 0x459CA0 Offset: 0x459DA1 VA: 0x459CA0
	public int bakedIndex { get; set; }
	public int commandBufferCount { get; }
	[ObsoleteAttribute] // RVA: 0x459D00 Offset: 0x459E01 VA: 0x459D00
	public static int pixelLightCount { get; set; }
	[ObsoleteAttribute] // RVA: 0x459D40 Offset: 0x459E41 VA: 0x459D40
	public float shadowConstantBias { get; set; }
	[ObsoleteAttribute] // RVA: 0x459D80 Offset: 0x459E81 VA: 0x459D80
	public float shadowObjectSizeBias { get; set; }
	[ObsoleteAttribute] // RVA: 0x459DC0 Offset: 0x459EC1 VA: 0x459DC0
	public bool attenuate { get; set; }

	// Methods

	// RVA: 0x2F278E0 Offset: 0x2F279E1 VA: 0x2F278E0
	public LightType get_type() { }

	// RVA: 0x2F27930 Offset: 0x2F27A31 VA: 0x2F27930
	public void set_type(LightType value) { }

	// RVA: 0x2F27980 Offset: 0x2F27A81 VA: 0x2F27980
	public LightShape get_shape() { }

	// RVA: 0x2F279D0 Offset: 0x2F27AD1 VA: 0x2F279D0
	public void set_shape(LightShape value) { }

	// RVA: 0x2F27A20 Offset: 0x2F27B21 VA: 0x2F27A20
	public float get_spotAngle() { }

	// RVA: 0x2F27A70 Offset: 0x2F27B71 VA: 0x2F27A70
	public void set_spotAngle(float value) { }

	// RVA: 0x2F27AC0 Offset: 0x2F27BC1 VA: 0x2F27AC0
	public float get_innerSpotAngle() { }

	// RVA: 0x2F27B10 Offset: 0x2F27C11 VA: 0x2F27B10
	public void set_innerSpotAngle(float value) { }

	// RVA: 0x2F27B60 Offset: 0x2F27C61 VA: 0x2F27B60
	public Color get_color() { }

	// RVA: 0x2F27C10 Offset: 0x2F27D11 VA: 0x2F27C10
	public void set_color(Color value) { }

	// RVA: 0x2F27CC0 Offset: 0x2F27DC1 VA: 0x2F27CC0
	public float get_colorTemperature() { }

	// RVA: 0x2F27D10 Offset: 0x2F27E11 VA: 0x2F27D10
	public void set_colorTemperature(float value) { }

	// RVA: 0x2F27D60 Offset: 0x2F27E61 VA: 0x2F27D60
	public bool get_useColorTemperature() { }

	// RVA: 0x2F27DB0 Offset: 0x2F27EB1 VA: 0x2F27DB0
	public void set_useColorTemperature(bool value) { }

	// RVA: 0x2F27E00 Offset: 0x2F27F01 VA: 0x2F27E00
	public float get_intensity() { }

	// RVA: 0x2F27E50 Offset: 0x2F27F51 VA: 0x2F27E50
	public void set_intensity(float value) { }

	// RVA: 0x2F27EA0 Offset: 0x2F27FA1 VA: 0x2F27EA0
	public float get_bounceIntensity() { }

	// RVA: 0x2F27EF0 Offset: 0x2F27FF1 VA: 0x2F27EF0
	public void set_bounceIntensity(float value) { }

	// RVA: 0x2F27F40 Offset: 0x2F28041 VA: 0x2F27F40
	public bool get_useBoundingSphereOverride() { }

	// RVA: 0x2F27F90 Offset: 0x2F28091 VA: 0x2F27F90
	public void set_useBoundingSphereOverride(bool value) { }

	// RVA: 0x2F27FE0 Offset: 0x2F280E1 VA: 0x2F27FE0
	public Vector4 get_boundingSphereOverride() { }

	// RVA: 0x2F28090 Offset: 0x2F28191 VA: 0x2F28090
	public void set_boundingSphereOverride(Vector4 value) { }

	// RVA: 0x2F28140 Offset: 0x2F28241 VA: 0x2F28140
	public bool get_useViewFrustumForShadowCasterCull() { }

	// RVA: 0x2F28190 Offset: 0x2F28291 VA: 0x2F28190
	public void set_useViewFrustumForShadowCasterCull(bool value) { }

	// RVA: 0x2F281E0 Offset: 0x2F282E1 VA: 0x2F281E0
	public int get_shadowCustomResolution() { }

	// RVA: 0x2F28230 Offset: 0x2F28331 VA: 0x2F28230
	public void set_shadowCustomResolution(int value) { }

	// RVA: 0x2F28280 Offset: 0x2F28381 VA: 0x2F28280
	public float get_shadowBias() { }

	// RVA: 0x2F282D0 Offset: 0x2F283D1 VA: 0x2F282D0
	public void set_shadowBias(float value) { }

	// RVA: 0x2F28320 Offset: 0x2F28421 VA: 0x2F28320
	public float get_shadowNormalBias() { }

	// RVA: 0x2F28370 Offset: 0x2F28471 VA: 0x2F28370
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x2F283C0 Offset: 0x2F284C1 VA: 0x2F283C0
	public float get_shadowNearPlane() { }

	// RVA: 0x2F28410 Offset: 0x2F28511 VA: 0x2F28410
	public void set_shadowNearPlane(float value) { }

	// RVA: 0x2F28460 Offset: 0x2F28561 VA: 0x2F28460
	public bool get_useShadowMatrixOverride() { }

	// RVA: 0x2F284B0 Offset: 0x2F285B1 VA: 0x2F284B0
	public void set_useShadowMatrixOverride(bool value) { }

	// RVA: 0x2F28500 Offset: 0x2F28601 VA: 0x2F28500
	public Matrix4x4 get_shadowMatrixOverride() { }

	// RVA: 0x2F285E0 Offset: 0x2F286E1 VA: 0x2F285E0
	public void set_shadowMatrixOverride(Matrix4x4 value) { }

	// RVA: 0x2F28680 Offset: 0x2F28781 VA: 0x2F28680
	public float get_range() { }

	// RVA: 0x2F286D0 Offset: 0x2F287D1 VA: 0x2F286D0
	public void set_range(float value) { }

	// RVA: 0x2F28720 Offset: 0x2F28821 VA: 0x2F28720
	public Flare get_flare() { }

	// RVA: 0x2F28770 Offset: 0x2F28871 VA: 0x2F28770
	public void set_flare(Flare value) { }

	// RVA: 0x2F287C0 Offset: 0x2F288C1 VA: 0x2F287C0
	public LightBakingOutput get_bakingOutput() { }

	// RVA: 0x2F28890 Offset: 0x2F28991 VA: 0x2F28890
	public void set_bakingOutput(LightBakingOutput value) { }

	// RVA: 0x2F28930 Offset: 0x2F28A31 VA: 0x2F28930
	public int get_cullingMask() { }

	// RVA: 0x2F28980 Offset: 0x2F28A81 VA: 0x2F28980
	public void set_cullingMask(int value) { }

	// RVA: 0x2F289D0 Offset: 0x2F28AD1 VA: 0x2F289D0
	public int get_renderingLayerMask() { }

	// RVA: 0x2F28A20 Offset: 0x2F28B21 VA: 0x2F28A20
	public void set_renderingLayerMask(int value) { }

	// RVA: 0x2F28A70 Offset: 0x2F28B71 VA: 0x2F28A70
	public LightShadowCasterMode get_lightShadowCasterMode() { }

	// RVA: 0x2F28AC0 Offset: 0x2F28BC1 VA: 0x2F28AC0
	public void set_lightShadowCasterMode(LightShadowCasterMode value) { }

	// RVA: 0x2F28B10 Offset: 0x2F28C11 VA: 0x2F28B10
	public void Reset() { }

	[NativeMethodAttribute] // RVA: 0x44A270 Offset: 0x44A371 VA: 0x44A270
	// RVA: 0x2F28B60 Offset: 0x2F28C61 VA: 0x2F28B60
	public LightShadows get_shadows() { }

	[FreeFunctionAttribute] // RVA: 0x44A2B0 Offset: 0x44A3B1 VA: 0x44A2B0
	// RVA: 0x2F28BB0 Offset: 0x2F28CB1 VA: 0x2F28BB0
	public void set_shadows(LightShadows value) { }

	// RVA: 0x2F28C00 Offset: 0x2F28D01 VA: 0x2F28C00
	public float get_shadowStrength() { }

	[FreeFunctionAttribute] // RVA: 0x44A300 Offset: 0x44A401 VA: 0x44A300
	// RVA: 0x2F28C50 Offset: 0x2F28D51 VA: 0x2F28C50
	public void set_shadowStrength(float value) { }

	// RVA: 0x2F28CA0 Offset: 0x2F28DA1 VA: 0x2F28CA0
	public LightShadowResolution get_shadowResolution() { }

	[FreeFunctionAttribute] // RVA: 0x44A350 Offset: 0x44A451 VA: 0x44A350
	// RVA: 0x2F28CF0 Offset: 0x2F28DF1 VA: 0x2F28CF0
	public void set_shadowResolution(LightShadowResolution value) { }

	// RVA: 0x2F28D40 Offset: 0x2F28E41 VA: 0x2F28D40
	public float get_shadowSoftness() { }

	// RVA: 0x2F28D50 Offset: 0x2F28E51 VA: 0x2F28D50
	public void set_shadowSoftness(float value) { }

	// RVA: 0x2F28D60 Offset: 0x2F28E61 VA: 0x2F28D60
	public float get_shadowSoftnessFade() { }

	// RVA: 0x2F28D70 Offset: 0x2F28E71 VA: 0x2F28D70
	public void set_shadowSoftnessFade(float value) { }

	[FreeFunctionAttribute] // RVA: 0x44A3A0 Offset: 0x44A4A1 VA: 0x44A3A0
	// RVA: 0x2F28D80 Offset: 0x2F28E81 VA: 0x2F28D80
	public float[] get_layerShadowCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0x44A3F0 Offset: 0x44A4F1 VA: 0x44A3F0
	// RVA: 0x2F28DD0 Offset: 0x2F28ED1 VA: 0x2F28DD0
	public void set_layerShadowCullDistances(float[] value) { }

	// RVA: 0x2F28E20 Offset: 0x2F28F21 VA: 0x2F28E20
	public float get_cookieSize() { }

	// RVA: 0x2F28E70 Offset: 0x2F28F71 VA: 0x2F28E70
	public void set_cookieSize(float value) { }

	// RVA: 0x2F28EC0 Offset: 0x2F28FC1 VA: 0x2F28EC0
	public Texture get_cookie() { }

	// RVA: 0x2F28F10 Offset: 0x2F29011 VA: 0x2F28F10
	public void set_cookie(Texture value) { }

	// RVA: 0x2F28F60 Offset: 0x2F29061 VA: 0x2F28F60
	public LightRenderMode get_renderMode() { }

	[FreeFunctionAttribute] // RVA: 0x44A440 Offset: 0x44A541 VA: 0x44A440
	// RVA: 0x2F28FB0 Offset: 0x2F290B1 VA: 0x2F28FB0
	public void set_renderMode(LightRenderMode value) { }

	// RVA: 0x2F29000 Offset: 0x2F29101 VA: 0x2F29000
	public int get_bakedIndex() { }

	// RVA: 0x2F29010 Offset: 0x2F29111 VA: 0x2F29010
	public void set_bakedIndex(int value) { }

	// RVA: 0x2F29020 Offset: 0x2F29121 VA: 0x2F29020
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x44A490 Offset: 0x44A591 VA: 0x44A490
	// RVA: 0x2F29080 Offset: 0x2F29181 VA: 0x2F29080
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	// RVA: 0x2F290F0 Offset: 0x2F291F1 VA: 0x2F290F0
	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[FreeFunctionAttribute] // RVA: 0x44A4E0 Offset: 0x44A5E1 VA: 0x44A4E0
	// RVA: 0x2F29160 Offset: 0x2F29261 VA: 0x2F29160
	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	// RVA: 0x2F291D0 Offset: 0x2F292D1 VA: 0x2F291D0
	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2F29230 Offset: 0x2F29331 VA: 0x2F29230
	public void RemoveCommandBuffers(LightEvent evt) { }

	// RVA: 0x2F29280 Offset: 0x2F29381 VA: 0x2F29280
	public void RemoveAllCommandBuffers() { }

	[FreeFunctionAttribute] // RVA: 0x44A530 Offset: 0x44A631 VA: 0x44A530
	// RVA: 0x2F292D0 Offset: 0x2F293D1 VA: 0x2F292D0
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	// RVA: 0x2F29320 Offset: 0x2F29421 VA: 0x2F29320
	public int get_commandBufferCount() { }

	// RVA: 0x2F29370 Offset: 0x2F29471 VA: 0x2F29370
	public static int get_pixelLightCount() { }

	// RVA: 0x2F29380 Offset: 0x2F29481 VA: 0x2F29380
	public static void set_pixelLightCount(int value) { }

	[FreeFunctionAttribute] // RVA: 0x44A580 Offset: 0x44A681 VA: 0x44A580
	// RVA: 0x2F29390 Offset: 0x2F29491 VA: 0x2F29390
	public static Light[] GetLights(LightType type, int layer) { }

	// RVA: 0x2F293E0 Offset: 0x2F294E1 VA: 0x2F293E0
	public float get_shadowConstantBias() { }

	// RVA: 0x2F293F0 Offset: 0x2F294F1 VA: 0x2F293F0
	public void set_shadowConstantBias(float value) { }

	// RVA: 0x2F29400 Offset: 0x2F29501 VA: 0x2F29400
	public float get_shadowObjectSizeBias() { }

	// RVA: 0x2F29410 Offset: 0x2F29511 VA: 0x2F29410
	public void set_shadowObjectSizeBias(float value) { }

	// RVA: 0x2F29420 Offset: 0x2F29521 VA: 0x2F29420
	public bool get_attenuate() { }

	// RVA: 0x2F29430 Offset: 0x2F29531 VA: 0x2F29430
	public void set_attenuate(bool value) { }

	// RVA: 0x2F29440 Offset: 0x2F29541 VA: 0x2F29440
	public void .ctor() { }

	// RVA: 0x2F27BC0 Offset: 0x2F27CC1 VA: 0x2F27BC0
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x2F27C70 Offset: 0x2F27D71 VA: 0x2F27C70
	private void set_color_Injected(ref Color value) { }

	// RVA: 0x2F28040 Offset: 0x2F28141 VA: 0x2F28040
	private void get_boundingSphereOverride_Injected(out Vector4 ret) { }

	// RVA: 0x2F280F0 Offset: 0x2F281F1 VA: 0x2F280F0
	private void set_boundingSphereOverride_Injected(ref Vector4 value) { }

	// RVA: 0x2F28590 Offset: 0x2F28691 VA: 0x2F28590
	private void get_shadowMatrixOverride_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2F28630 Offset: 0x2F28731 VA: 0x2F28630
	private void set_shadowMatrixOverride_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2F28840 Offset: 0x2F28941 VA: 0x2F28840
	private void get_bakingOutput_Injected(out LightBakingOutput ret) { }

	// RVA: 0x2F288E0 Offset: 0x2F289E1 VA: 0x2F288E0
	private void set_bakingOutput_Injected(ref LightBakingOutput value) { }
}

