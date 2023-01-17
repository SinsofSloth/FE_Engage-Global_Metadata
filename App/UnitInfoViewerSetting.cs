// Namespace: App
public class UnitInfoViewerSetting : MonoBehaviour // TypeDefIndex: 9081
{
	// Fields
	[SerializeField] // RVA: 0x286B30 Offset: 0x286C31 VA: 0x286B30
	private UnitInfoViewerSetting.UnitData m_LeftUnit; // 0x18
	[SerializeField] // RVA: 0x286B40 Offset: 0x286C41 VA: 0x286B40
	private UnitInfoViewerSetting.UnitData m_RightUnit; // 0x20
	[SerializeField] // RVA: 0x286B50 Offset: 0x286C51 VA: 0x286B50
	private bool m_IsCharaOnlyTransition; // 0x28
	private UnitInfoViewerSetting.Seq m_Seq; // 0x2C

	// Methods

	// RVA: 0x242B830 Offset: 0x242B931 VA: 0x242B830
	private void Start() { }

	// RVA: 0x242B840 Offset: 0x242B941 VA: 0x242B840
	private void OnDestroy() { }

	// RVA: 0x242B900 Offset: 0x242BA01 VA: 0x242B900
	private void Update() { }

	// RVA: 0x242BCD0 Offset: 0x242BDD1 VA: 0x242BCD0
	public void CreateUnit(UnitInfo.Side side) { }

	// RVA: 0x242BFF0 Offset: 0x242C0F1 VA: 0x242BFF0
	private PersonData GetPerson(UnitInfoViewerSetting.UnitData unitData) { }

	// RVA: 0x242C090 Offset: 0x242C191 VA: 0x242C090
	private JobData GetJob(UnitInfoViewerSetting.UnitData unitData) { }

	// RVA: 0x242C130 Offset: 0x242C231 VA: 0x242C130
	private ItemData GetWeapon(UnitInfoViewerSetting.UnitData unitData) { }

	// RVA: 0x242BA30 Offset: 0x242BB31 VA: 0x242BA30
	private bool IsHidingCanvs() { }

	// RVA: 0x242BBC0 Offset: 0x242BCC1 VA: 0x242BBC0
	private void ShowCanvas() { }

	// RVA: 0x242C1E0 Offset: 0x242C2E1 VA: 0x242C1E0
	public void CharaOnlyOn() { }

	// RVA: 0x242C290 Offset: 0x242C391 VA: 0x242C290
	public void CharaOnlyOff() { }

	// RVA: 0x242C300 Offset: 0x242C401 VA: 0x242C300
	public bool IsCharaOnlyTransition() { }

	// RVA: 0x242C310 Offset: 0x242C411 VA: 0x242C310
	public bool HasUnit() { }

	// RVA: 0x242C3D0 Offset: 0x242C4D1 VA: 0x242C3D0
	public void .ctor() { }
}

