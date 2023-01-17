// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomEffectPass : ScriptableRenderPass // TypeDefIndex: 5448
{
	// Fields
	private const string m_ProfilerTag = "Custom Effect Pass";
	private ProfilingSampler m_ProfilingSampler; // 0x70
	private FilteringSettings m_FilteringSettings; // 0x78
	private ShaderTagId m_EffectTagId; // 0x90
	private ShaderTagId m_EffectFullTagId; // 0x94
	private bool m_ShouldSetEffectDepth; // 0x98
	private RenderTargetIdentifier m_EffectDepthId; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x483B50 Offset: 0x483C51 VA: 0x483B50
	private bool <forceHalfEffectToDrawFull>k__BackingField; // 0xC8

	// Properties
	public bool forceHalfEffectToDrawFull { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x485050 Offset: 0x485151 VA: 0x485050
	// RVA: 0x2D320B0 Offset: 0x2D321B1 VA: 0x2D320B0
	public bool get_forceHalfEffectToDrawFull() { }

	[CompilerGeneratedAttribute] // RVA: 0x485060 Offset: 0x485161 VA: 0x485060
	// RVA: 0x2D320C0 Offset: 0x2D321C1 VA: 0x2D320C0
	public void set_forceHalfEffectToDrawFull(bool value) { }

	// RVA: 0x2D320D0 Offset: 0x2D321D1 VA: 0x2D320D0
	public void .ctor(RenderPassEvent evt, LayerMask layerMask) { }

	// RVA: 0x2D322A0 Offset: 0x2D323A1 VA: 0x2D322A0
	public void SetEffectDepth(int id) { }

	// RVA: 0x2D32300 Offset: 0x2D32401 VA: 0x2D32300 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }
}

