// Namespace: App
public class InvestmentNationDataMenu : MonoBehaviour // TypeDefIndex: 11434
{
	// Fields
	public TextMeshProUGUI m_nationTitle; // 0x18
	public GameObject m_arrowL; // 0x20
	public GameObject m_arrowR; // 0x28
	public Image m_bgSymbol; // 0x30
	[HeaderAttribute] // RVA: 0x298170 Offset: 0x298271 VA: 0x298170
	public TextMeshProUGUI m_materialTitle; // 0x38
	public TextMeshProUGUI m_foodTitle; // 0x40
	public TextMeshProUGUI m_animalTitle; // 0x48
	[HeaderAttribute] // RVA: 0x2981B0 Offset: 0x2982B1 VA: 0x2981B0
	public InvestmentNationDataMenu.ItemInfo m_ironData; // 0x50
	public InvestmentNationDataMenu.ItemInfo m_steelData; // 0x58
	public InvestmentNationDataMenu.ItemInfo m_silverData; // 0x60
	public InvestmentNationDataMenu.ItemInfo m_pieceOfBondData; // 0x68
	[HeaderAttribute] // RVA: 0x2981F0 Offset: 0x2982F1 VA: 0x2981F0
	public List<InvestmentNationDataMenu.ItemInfo> m_foodstuffData; // 0x70
	[HeaderAttribute] // RVA: 0x298230 Offset: 0x298331 VA: 0x298230
	public List<InvestmentNationDataMenu.AnimalInfo> m_animalData; // 0x78
	[HeaderAttribute] // RVA: 0x298270 Offset: 0x298371 VA: 0x298270
	public List<GameObject> m_pageIcon; // 0x80
	private int m_index; // 0x88
	private int m_investmentEnableCnt; // 0x8C
	private bool m_isClose; // 0x90

	// Methods

	// RVA: 0x2B5D090 Offset: 0x2B5D191 VA: 0x2B5D090
	public void Setup(int index) { }

	// RVA: 0x2B5D5E0 Offset: 0x2B5D6E1 VA: 0x2B5D5E0
	private void SetupNation() { }

	// RVA: 0x2B5DC20 Offset: 0x2B5DD21 VA: 0x2B5DC20
	private void Update() { }

	// RVA: 0x2B5EC20 Offset: 0x2B5ED21 VA: 0x2B5EC20
	public int GetNationIndex() { }

	// RVA: 0x2B5EC30 Offset: 0x2B5ED31 VA: 0x2B5EC30
	public bool IsClosed() { }

	// RVA: 0x2B5ECB0 Offset: 0x2B5EDB1 VA: 0x2B5ECB0
	public void .ctor() { }
}

