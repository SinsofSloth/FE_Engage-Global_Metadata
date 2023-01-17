// Namespace: UnityEngine.Rendering.Universal
internal class TransparentSettingsPass : ScriptableRenderPass // TypeDefIndex: 5319
{
	// Fields
	private bool m_shouldReceiveShadows; // 0x70
	private const string m_ProfilerTag = "Transparent Settings Pass";
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0

	// Methods

	// RVA: 0x2F905D0 Offset: 0x2F906D1 VA: 0x2F905D0
	public void .ctor(RenderPassEvent evt, bool shadowReceiveSupported) { }

	// RVA: 0x2F90680 Offset: 0x2F90781 VA: 0x2F90680
	public bool Setup(ref RenderingData renderingData) { }

	// RVA: 0x2F90690 Offset: 0x2F90791 VA: 0x2F90690 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2F908A0 Offset: 0x2F909A1 VA: 0x2F908A0
	private static void .cctor() { }
}

