// Namespace: App
internal class HubMoveStateMove : HubMoveState // TypeDefIndex: 10741
{
	// Fields
	private HubUnitController m_unit; // 0x10
	private Vector3 m_target; // 0x18
	private string m_bodyAnim; // 0x28
	private string m_faceAnim; // 0x30
	private bool m_isTurn; // 0x38
	private bool m_resume; // 0x39
	private float m_speed; // 0x3C
	private float m_blend; // 0x40

	// Methods

	// RVA: 0x2BEF850 Offset: 0x2BEF951 VA: 0x2BEF850
	public void .ctor(HubUnitController unit, Vector3 target, string bodyAnim, string faceAnim, bool isTurn, float speed) { }

	// RVA: 0x2BEFD50 Offset: 0x2BEFE51 VA: 0x2BEFD50 Slot: 4
	public override bool IsEnd() { }

	// RVA: 0x2BEFE60 Offset: 0x2BEFF61 VA: 0x2BEFE60 Slot: 5
	public override void Start(bool resume) { }

	// RVA: 0x2BEFF20 Offset: 0x2BF0021 VA: 0x2BEFF20 Slot: 6
	public override void Update() { }
}

