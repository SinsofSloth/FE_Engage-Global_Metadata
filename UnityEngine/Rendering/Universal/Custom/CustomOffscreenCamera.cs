// Namespace: UnityEngine.Rendering.Universal.Custom
public sealed class CustomOffscreenCamera : MonoBehaviour // TypeDefIndex: 5433
{
	// Fields
	[SerializeField] // RVA: 0x483670 Offset: 0x483771 VA: 0x483670
	private VolumeProfile m_PPVolumeProfile; // 0x18
	private Camera m_Camera; // 0x20
	private UniversalAdditionalCameraData m_AdditionalCameraData; // 0x28

	// Properties
	public VolumeProfile profile { get; }

	// Methods

	// RVA: 0x2D38EE0 Offset: 0x2D38FE1 VA: 0x2D38EE0
	public VolumeProfile get_profile() { }

	// RVA: 0x2D38EF0 Offset: 0x2D38FF1 VA: 0x2D38EF0
	private void OnEnable() { }

	// RVA: 0x2D390B0 Offset: 0x2D391B1 VA: 0x2D390B0
	private void OnDisable() { }

	// RVA: 0x2D39180 Offset: 0x2D39281 VA: 0x2D39180
	private void CustomBeginFrameRendering(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x2D393C0 Offset: 0x2D394C1 VA: 0x2D393C0
	public void .ctor() { }
}

