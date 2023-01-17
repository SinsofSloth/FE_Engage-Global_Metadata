// Namespace: 
[Serializable]
public class ExpSetter.ExpWindow // TypeDefIndex: 13418
{
	// Fields
	public GameObject m_Root; // 0x10
	public TextMeshProUGUI m_Name; // 0x18
	public TextMeshProUGUI m_RestExp; // 0x20
	public TextMeshProUGUI m_GetExp; // 0x28
	public TextMeshProUGUI m_SpValue; // 0x30
	public GameObject m_ExpValue; // 0x38
	public GameObject m_LevelMax; // 0x40
	public GameObject m_Gauge; // 0x48
	public Material m_MaxColor; // 0x50
	private int m_OldLevel; // 0x58

	// Methods

	// RVA: 0x1F09180 Offset: 0x1F09281 VA: 0x1F09180
	public void SetupUnit(Unit unit, int gainExp) { }

	// RVA: 0x1F09480 Offset: 0x1F09581 VA: 0x1F09480
	public void UpdateUnit(Unit unit) { }

	// RVA: 0x1F09630 Offset: 0x1F09731 VA: 0x1F09630
	public void UpdateAddExp(int exp) { }

	// RVA: 0x1F09330 Offset: 0x1F09431 VA: 0x1F09330
	private void SetLevelMax() { }

	// RVA: 0x1F09310 Offset: 0x1F09411 VA: 0x1F09310
	private bool IsLevelMax(Unit unit) { }

	// RVA: 0x1F09810 Offset: 0x1F09911 VA: 0x1F09810
	public void .ctor() { }
}

