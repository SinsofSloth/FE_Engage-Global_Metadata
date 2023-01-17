// Namespace: App
public class TroopListSortMenu : MonoBehaviour // TypeDefIndex: 13303
{
	// Fields
	public List<GameObject> m_pageRoot; // 0x18
	public List<TroopListSortMenu.SortTitle> m_sortTitle; // 0x20
	public GameObject m_cursorRoot; // 0x28
	public TextMeshProUGUI m_pageTitle; // 0x30
	public List<GameObject> m_pageIcon; // 0x38
	[HeaderAttribute] // RVA: 0x29BCF0 Offset: 0x29BDF1 VA: 0x29BCF0
	public Sprite m_upArrow; // 0x40
	public Sprite m_downArrow; // 0x48
	private int m_selectIndex; // 0x50
	private float m_posX; // 0x54
	private float m_posY; // 0x58
	private float m_fromX; // 0x5C
	private float m_fromY; // 0x60
	private float m_toX; // 0x64
	private float m_toY; // 0x68
	private float m_sizeW; // 0x6C
	private float m_sizeH; // 0x70
	private float m_fromW; // 0x74
	private float m_fromH; // 0x78
	private float m_toW; // 0x7C
	private float m_toH; // 0x80
	private float m_moveTick; // 0x84
	private float m_moveFrame; // 0x88
	private static TroopListSortMenu.SortOrder m_sortOrder; // 0x0
	private static TroopListSortMenu.SortType m_sortType; // 0x4

	// Methods

	// RVA: 0x287BA60 Offset: 0x287BB61 VA: 0x287BA60
	public void Init() { }

	// RVA: 0x287C130 Offset: 0x287C231 VA: 0x287C130
	private void SetCursorColor(Color c) { }

	// RVA: 0x287C3D0 Offset: 0x287C4D1 VA: 0x287C3D0
	private void Update() { }

	// RVA: 0x287C530 Offset: 0x287C631 VA: 0x287C530
	public int GetPageNum() { }

	// RVA: 0x2873F70 Offset: 0x2874071 VA: 0x2873F70
	public void SetPage(int page) { }

	// RVA: 0x287C6C0 Offset: 0x287C7C1 VA: 0x287C6C0
	public float GetCursorX() { }

	// RVA: 0x287C6D0 Offset: 0x287C7D1 VA: 0x287C6D0
	public float GetCursorY() { }

	// RVA: 0x287C580 Offset: 0x287C681 VA: 0x287C580
	private void SetCursorPos() { }

	// RVA: 0x287C7B0 Offset: 0x287C8B1 VA: 0x287C7B0
	private void SetNextCursorPos() { }

	// RVA: 0x2876700 Offset: 0x2876801 VA: 0x2876700
	public bool IncSelect(bool isTrigger) { }

	// RVA: 0x28767D0 Offset: 0x28768D1 VA: 0x28767D0
	public bool DecSelect(bool isTrigger) { }

	// RVA: 0x2876690 Offset: 0x2876791 VA: 0x2876690
	public int GetSelectSortPage() { }

	// RVA: 0x287C8F0 Offset: 0x287C9F1 VA: 0x287C8F0
	public TroopListSortMenu.SortOrder GetSortOrder() { }

	// RVA: 0x287C960 Offset: 0x287CA61 VA: 0x287C960
	public TroopListSortMenu.SortType GetSortType() { }

	// RVA: 0x2876420 Offset: 0x2876521 VA: 0x2876420
	public void ChangeSortOrder() { }

	// RVA: 0x28747C0 Offset: 0x28748C1 VA: 0x28747C0
	public void ShowCursor(RectTransform startRect) { }

	// RVA: 0x2874740 Offset: 0x2874841 VA: 0x2874740
	public void HideCursor() { }

	// RVA: 0x287C6E0 Offset: 0x287C7E1 VA: 0x287C6E0
	public void UpdateTextColor() { }

	// RVA: 0x2873D30 Offset: 0x2873E31 VA: 0x2873D30
	public void UpdateSortArrow() { }

	// RVA: 0x287C9D0 Offset: 0x287CAD1 VA: 0x287C9D0
	public void .ctor() { }

	// RVA: 0x287C9E0 Offset: 0x287CAE1 VA: 0x287C9E0
	private static void .cctor() { }
}

