// Namespace: App
public class MapEngageConfirmRoot : MonoBehaviour // TypeDefIndex: 12485
{
	// Fields
	public TextMeshProUGUI m_unitName; // 0x18
	public TextMeshProUGUI m_godName; // 0x20
	public TextMeshProUGUI m_unitNameR; // 0x28
	public List<GameObject> m_item; // 0x30
	public List<GameObject> m_skill; // 0x38

	// Methods

	// RVA: 0x21BD4B0 Offset: 0x21BD5B1 VA: 0x21BD4B0
	public void Setup(Unit unit, GodUnit god) { }

	// RVA: 0x21BDF60 Offset: 0x21BE061 VA: 0x21BDF60
	public void Setup(Unit unit, Unit target) { }

	// RVA: 0x21BD530 Offset: 0x21BD631 VA: 0x21BD530
	private void SetUnitName(GameObject obj, Unit unit) { }

	// RVA: 0x21BD650 Offset: 0x21BD751 VA: 0x21BD650
	private void SetGodName(GameObject obj, GodUnit god) { }

	// RVA: 0x21BD7D0 Offset: 0x21BD8D1 VA: 0x21BD7D0
	private void SetGodData(GodUnit god, Unit unit, Unit linkTarget) { }

	// RVA: 0x21BE080 Offset: 0x21BE181 VA: 0x21BE080
	private void SetSkill(Unit unit, GameObject obj, SkillData skill) { }

	// RVA: 0x21BE3F0 Offset: 0x21BE4F1 VA: 0x21BE3F0
	public void .ctor() { }
}

