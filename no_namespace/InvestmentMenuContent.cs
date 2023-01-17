// Namespace: 
[Serializable]
public class InvestmentMenuContent.BattleEnemyInfo // TypeDefIndex: 11427
{
	// Fields
	public GameObject m_root; // 0x10
	public TextMeshProUGUI m_title; // 0x18
	public TextMeshProUGUI m_current; // 0x20
	public TextMeshProUGUI m_next; // 0x28
	public TextMeshProUGUI m_nextPercent; // 0x30

	// Methods

	// RVA: 0x2227000 Offset: 0x2227101 VA: 0x2227000
	public void SetTitle(string title) { }

	// RVA: 0x2227080 Offset: 0x2227181 VA: 0x2227080
	public void SetValue(int current, int next) { }

	// RVA: 0x2227280 Offset: 0x2227381 VA: 0x2227280
	public void SetValueMax(int current) { }

	// RVA: 0x2227310 Offset: 0x2227411 VA: 0x2227310
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InvestmentMenuContent.DropItemInfo // TypeDefIndex: 11428
{
	// Fields
	public GameObject m_root; // 0x10
	private Image m_icon; // 0x18
	private TextMeshProUGUI m_title; // 0x20
	private TextMeshProUGUI m_current; // 0x28
	private TextMeshProUGUI m_nextCode; // 0x30
	private TextMeshProUGUI m_next; // 0x38

	// Methods

	// RVA: 0x2227320 Offset: 0x2227421 VA: 0x2227320
	public void SetupObj() { }

	// RVA: 0x2227550 Offset: 0x2227651 VA: 0x2227550
	public void Show() { }

	// RVA: 0x22275D0 Offset: 0x22276D1 VA: 0x22275D0
	public void Hide() { }

	// RVA: 0x2227650 Offset: 0x2227751 VA: 0x2227650
	public void SetTitle(string title) { }

	// RVA: 0x22276D0 Offset: 0x22277D1 VA: 0x22276D0
	public void SetValue(int current, int next) { }

	// RVA: 0x22278A0 Offset: 0x22279A1 VA: 0x22278A0
	public void SetIcon(string iconName) { }

	// RVA: 0x2227980 Offset: 0x2227A81 VA: 0x2227980
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InvestmentMenuContent.AnimalInfo // TypeDefIndex: 11429
{
	// Fields
	public GameObject m_root; // 0x10
	private Image m_icon; // 0x18
	private TextMeshProUGUI m_name; // 0x20
	private TextMeshProUGUI m_text; // 0x28

	// Methods

	// RVA: 0x2226B60 Offset: 0x2226C61 VA: 0x2226B60
	public void SetupObj() { }

	// RVA: 0x2226D10 Offset: 0x2226E11 VA: 0x2226D10
	public void Set(string animalId) { }

	// RVA: 0x2226F10 Offset: 0x2227011 VA: 0x2226F10
	public void SetIcon(string iconName) { }

	// RVA: 0x2226E90 Offset: 0x2226F91 VA: 0x2226E90
	public void Hide() { }

	// RVA: 0x2226FF0 Offset: 0x22270F1 VA: 0x2226FF0
	public void .ctor() { }
}

