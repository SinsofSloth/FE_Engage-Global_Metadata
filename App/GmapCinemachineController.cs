// Namespace: App
public class GmapCinemachineController // TypeDefIndex: 10263
{
	// Fields
	private GameObject m_Carrier; // 0x10
	private CinemachineDollyCart m_DollyCart; // 0x18

	// Properties
	private float PathPosition { get; set; }
	private float PathLength { get; }

	// Methods

	// RVA: 0x28E7B20 Offset: 0x28E7C21 VA: 0x28E7B20
	public void .ctor(GameObject carrier) { }

	// RVA: 0x28E7BB0 Offset: 0x28E7CB1 VA: 0x28E7BB0
	public void SetPosition(Vector3 pos) { }

	// RVA: 0x28E7C00 Offset: 0x28E7D01 VA: 0x28E7C00
	public void SetGmapPath(CinemachinePathBase path, float pos) { }

	// RVA: 0x28E7C40 Offset: 0x28E7D41 VA: 0x28E7C40
	public Vector3 Move(float speed) { }

	// RVA: 0x28E7CE0 Offset: 0x28E7DE1 VA: 0x28E7CE0
	public Vector3 Set(float normalizedPos) { }

	// RVA: 0x28E7D50 Offset: 0x28E7E51 VA: 0x28E7D50
	public bool IsMoveFinished(bool isForward) { }

	// RVA: 0x28E7DC0 Offset: 0x28E7EC1 VA: 0x28E7DC0
	public GmapCinemachineController.PointType GetFinishedType() { }

	// RVA: 0x28E7E10 Offset: 0x28E7F11 VA: 0x28E7E10
	public void Enable() { }

	// RVA: 0x28E7E20 Offset: 0x28E7F21 VA: 0x28E7E20
	public void Disable() { }

	// RVA: 0x28E7E30 Offset: 0x28E7F31 VA: 0x28E7E30
	public float GetNormalizedPathPosition() { }

	// RVA: 0x28E7CB0 Offset: 0x28E7DB1 VA: 0x28E7CB0
	private float get_PathPosition() { }

	// RVA: 0x28E7CD0 Offset: 0x28E7DD1 VA: 0x28E7CD0
	private void set_PathPosition(float value) { }

	// RVA: 0x28E7CC0 Offset: 0x28E7DC1 VA: 0x28E7CC0
	private float get_PathLength() { }
}

