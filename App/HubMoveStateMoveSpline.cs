// Namespace: App
internal class HubMoveStateMoveSpline : HubMoveState // TypeDefIndex: 10743
{
	// Fields
	private HubUnitController m_unit; // 0x10
	private Vector3[] m_data; // 0x18
	private float m_term; // 0x20
	private string m_bodyAnim; // 0x28
	private string m_faceAnim; // 0x30
	private bool m_isTurn; // 0x38
	private bool m_resume; // 0x39
	private float m_speed; // 0x3C

	// Methods

	// RVA: 0x28AB590 Offset: 0x28AB691 VA: 0x28AB590
	public void .ctor(HubUnitController unit, Vector3[] data, string bodyAnim, string faceAnim, bool isTurn, float speed) { }

	// RVA: 0x28AB640 Offset: 0x28AB741 VA: 0x28AB640 Slot: 4
	public override bool IsEnd() { }

	// RVA: 0x28AB660 Offset: 0x28AB761 VA: 0x28AB660 Slot: 5
	public override void Start(bool resume) { }

	// RVA: 0x28AB740 Offset: 0x28AB841 VA: 0x28AB740 Slot: 6
	public override void Update() { }

	// RVA: 0x28ABE50 Offset: 0x28ABF51 VA: 0x28ABE50 Slot: 7
	public override void OnDrawGizmos() { }
}

