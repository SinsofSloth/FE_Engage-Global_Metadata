// Namespace: App
internal class HubMoveStateMoveSplineLoop : HubMoveState // TypeDefIndex: 10742
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

	// RVA: 0x28ABFC0 Offset: 0x28AC0C1 VA: 0x28ABFC0
	public void .ctor(HubUnitController unit, Vector3[] data, string bodyAnim, string faceAnim, bool isTurn, float speed) { }

	// RVA: 0x28AC070 Offset: 0x28AC171 VA: 0x28AC070 Slot: 4
	public override bool IsEnd() { }

	// RVA: 0x28AC090 Offset: 0x28AC191 VA: 0x28AC090 Slot: 5
	public override void Start(bool resume) { }

	// RVA: 0x28AC170 Offset: 0x28AC271 VA: 0x28AC170 Slot: 6
	public override void Update() { }

	// RVA: 0x28AC880 Offset: 0x28AC981 VA: 0x28AC880 Slot: 7
	public override void OnDrawGizmos() { }
}

