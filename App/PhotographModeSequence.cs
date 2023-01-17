// Namespace: App
public class PhotographModeSequence : ProcInst // TypeDefIndex: 11489
{
	// Fields
	private PhotographAllMenuContent m_AllMenuContent; // 0x70
	private PhotographCameraController m_CameraController; // 0x78
	private PhotographDisposManager m_DisposManager; // 0x80
	private bool m_IsHelpVisible; // 0x88
	private PhotographModeSequence.Label m_ReservedLabel; // 0x8C

	// Methods

	// RVA: 0x2A32670 Offset: 0x2A32771 VA: 0x2A32670
	public static void CreateBind(ProcInst super, PhotographAllMenuContent allMenuContent, PhotographCameraController cameraController, PhotographDisposManager disposManager) { }

	// RVA: 0x2A32AE0 Offset: 0x2A32BE1 VA: 0x2A32AE0
	private void JumpReservedLabel() { }

	// RVA: 0x2A32A70 Offset: 0x2A32B71 VA: 0x2A32A70
	private void .ctor(PhotographAllMenuContent allMenuContent, PhotographCameraController cameraController, PhotographDisposManager disposManager) { }

	// RVA: 0x2A32B50 Offset: 0x2A32C51 VA: 0x2A32B50
	private void Tick() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C5980 Offset: 0x2C5A81 VA: 0x2C5980
	// RVA: 0x2A331D0 Offset: 0x2A332D1 VA: 0x2A331D0
	private IEnumerator PhotographCoroutine() { }
}

