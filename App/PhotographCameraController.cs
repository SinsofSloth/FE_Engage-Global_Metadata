// Namespace: App
public class PhotographCameraController // TypeDefIndex: 11466
{
	// Fields
	private bool m_IsEnable; // 0x10
	private bool m_IsPhotographMode; // 0x11
	private List<PhotographCameraParameter> m_ParameterList; // 0x18
	private PhotographCameraParameter m_CurrentParameter; // 0x20
	private InterpolatorFloat m_MoveX; // 0x28
	private InterpolatorFloat m_MoveY; // 0x30
	private InterpolatorRotation m_AngleY; // 0x38
	private InterpolatorFloat m_Fov; // 0x40
	private PhotographDisposManager m_DisposManager; // 0x48
	private bool flg; // 0x50

	// Methods

	// RVA: 0x2A26CD0 Offset: 0x2A26DD1 VA: 0x2A26CD0
	public void Setup(GameObject spot, PhotographDisposManager disposManager) { }

	// RVA: 0x2A27160 Offset: 0x2A27261 VA: 0x2A27160
	public void Enable() { }

	// RVA: 0x2A27170 Offset: 0x2A27271 VA: 0x2A27170
	public void Disable() { }

	// RVA: 0x2A27240 Offset: 0x2A27341 VA: 0x2A27240
	public void SetIsPhotographMode(bool isPhotographMode) { }

	// RVA: 0x2A27320 Offset: 0x2A27421 VA: 0x2A27320
	public void Update() { }

	// RVA: 0x2A26F20 Offset: 0x2A27021 VA: 0x2A26F20
	private void SetCameraParameter() { }

	// RVA: 0x2A28920 Offset: 0x2A28A21 VA: 0x2A28920
	public void .ctor() { }
}

