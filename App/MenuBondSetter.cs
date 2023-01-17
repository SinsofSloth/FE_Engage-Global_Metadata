// Namespace: App
public class MenuBondSetter : MonoBehaviour // TypeDefIndex: 11243
{
	// Fields
	[SerializeField] // RVA: 0x297240 Offset: 0x297341 VA: 0x297240
	private TextMeshProUGUI m_UnitName; // 0x18
	[SerializeField] // RVA: 0x297250 Offset: 0x297351 VA: 0x297250
	private TextMeshProUGUI m_GodName; // 0x20
	[SerializeField] // RVA: 0x297260 Offset: 0x297361 VA: 0x297260
	private TextMeshProUGUI m_BondLv; // 0x28
	[SerializeField] // RVA: 0x297270 Offset: 0x297371 VA: 0x297270
	private GameObject m_BondGauge; // 0x30

	// Methods

	// RVA: 0x28622B0 Offset: 0x28623B1 VA: 0x28622B0
	public void SetData(Unit unit, GodUnit god) { }

	// RVA: 0x2862500 Offset: 0x2862601 VA: 0x2862500
	public void SetData(Unit unit, GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x2862370 Offset: 0x2862471 VA: 0x2862370
	private void SetStatus(Unit unit, GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x28625C0 Offset: 0x28626C1 VA: 0x28625C0
	private string GetGodName(GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x28625D0 Offset: 0x28626D1 VA: 0x28625D0
	public void .ctor() { }
}

