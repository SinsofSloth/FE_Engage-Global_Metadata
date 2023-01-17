// Namespace: Combat.SituationConverter
public class ConvertChainAttack : BaseConverter // TypeDefIndex: 8876
{
	// Fields
	private int m_LastChainAttackID; // 0x18
	private bool m_IsEnemyEngageAttack; // 0x1C
	private bool m_IsChainBegun; // 0x1D
	private bool m_IsAttacking; // 0x1E
	private bool m_IsChainFinished; // 0x1F

	// Methods

	// RVA: 0x23BB480 Offset: 0x23BB581 VA: 0x23BB480
	public void .ctor(CameraDataSet data) { }

	// RVA: 0x23BB4F0 Offset: 0x23BB5F1 VA: 0x23BB4F0 Slot: 4
	public override CameraPosition Convert(CameraSituation situation, string arg) { }

	// RVA: 0x23BBA60 Offset: 0x23BBB61 VA: 0x23BBA60
	private CameraPosition AttackCam() { }

	// RVA: 0x23BB7D0 Offset: 0x23BB8D1 VA: 0x23BB7D0
	private CameraPosition DamageCam() { }
}

