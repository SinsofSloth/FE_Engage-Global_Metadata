// Namespace: App
public class ControllerSupportApplet // TypeDefIndex: 9130
{
	// Fields
	private const float c_appletWaitTime = 5;
	private Operation.OperationMode m_preOperationMode; // 0x10
	private Nullable<float> m_appletWaitTime; // 0x14
	private NpadId[] m_npadIds; // 0x20
	private bool m_isHandheldMode; // 0x28
	private int m_DisableCallCount; // 0x2C

	// Methods

	// RVA: 0x23B9ED0 Offset: 0x23B9FD1 VA: 0x23B9ED0
	public void SetEnableApplet(bool isEnable) { }

	// RVA: 0x23B9F00 Offset: 0x23BA001 VA: 0x23B9F00
	public void .ctor(NpadId[] npadId) { }

	// RVA: 0x23B9F40 Offset: 0x23BA041 VA: 0x23B9F40
	public void Update() { }

	// RVA: 0x23BA110 Offset: 0x23BA211 VA: 0x23BA110
	private ControllerSupportApplet.CallState UpdateConnectController() { }

	// RVA: 0x23BA340 Offset: 0x23BA441 VA: 0x23BA340
	private void CallControllerSupportApplet() { }

	// RVA: 0x23BA4E0 Offset: 0x23BA5E1 VA: 0x23BA4E0
	public NpadId GetNpadId() { }
}

