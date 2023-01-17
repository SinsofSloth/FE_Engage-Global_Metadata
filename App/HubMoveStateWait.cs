// Namespace: App
internal class HubMoveStateWait : HubMoveState // TypeDefIndex: 10740
{
	// Fields
	private HubUnitController m_unit; // 0x10
	private Vector3 m_target; // 0x18
	private string m_bodyAnim; // 0x28
	private string m_faceAnim; // 0x30
	private bool m_isTurn; // 0x38
	private float m_startSec; // 0x3C
	private float m_endSec; // 0x40
	private float m_interval; // 0x44

	// Methods

	// RVA: 0x28AC9F0 Offset: 0x28ACAF1 VA: 0x28AC9F0
	public void .ctor(HubUnitController unit, Vector3 target, string bodyAnim, string faceAnim, bool isTurn, float startSec, float endSec) { }

	// RVA: 0x28ACAB0 Offset: 0x28ACBB1 VA: 0x28ACAB0 Slot: 4
	public override bool IsEnd() { }

	// RVA: 0x28ACAE0 Offset: 0x28ACBE1 VA: 0x28ACAE0 Slot: 5
	public override void Start(bool resume) { }

	// RVA: 0x28ACBE0 Offset: 0x28ACCE1 VA: 0x28ACBE0 Slot: 6
	public override void Update() { }
}

