// Namespace: Combat.SituationConverter
public class ConvertEngageAttack : BaseConverter // TypeDefIndex: 8880
{
	// Fields
	private bool m_IsFirstEnterApproach; // 0x18
	private bool m_BeforeSpace; // 0x19
	private bool m_IsStartGTSP; // 0x1A

	// Methods

	// RVA: 0x23BC720 Offset: 0x23BC821 VA: 0x23BC720
	public void .ctor(CameraDataSet data) { }

	// RVA: 0x23BC730 Offset: 0x23BC831 VA: 0x23BC730 Slot: 4
	public override CameraPosition Convert(CameraSituation situation, string arg) { }

	// RVA: 0x23BCD00 Offset: 0x23BCE01 VA: 0x23BCD00
	private void CheckEnemy(CameraPosition camPos, bool invSide, bool invCam) { }
}

