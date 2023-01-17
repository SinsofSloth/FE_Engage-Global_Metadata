// Namespace: 
public enum TroopListSortMenu.SortType // TypeDefIndex: 13300
{
	// Fields
	public int value__; // 0x0
	public const TroopListSortMenu.SortType None = 0;
	public const TroopListSortMenu.SortType Class = 1;
	public const TroopListSortMenu.SortType Level = 2;
	public const TroopListSortMenu.SortType Exp = 3;
	public const TroopListSortMenu.SortType Hp = 4;
	public const TroopListSortMenu.SortType Str = 5;
	public const TroopListSortMenu.SortType Mgc = 6;
	public const TroopListSortMenu.SortType Tec = 7;
	public const TroopListSortMenu.SortType Spd = 8;
	public const TroopListSortMenu.SortType Luc = 9;
	public const TroopListSortMenu.SortType Def = 10;
	public const TroopListSortMenu.SortType MDef = 11;
	public const TroopListSortMenu.SortType Phy = 12;
	public const TroopListSortMenu.SortType Attack = 13;
	public const TroopListSortMenu.SortType Hit = 14;
	public const TroopListSortMenu.SortType Crit = 15;
	public const TroopListSortMenu.SortType Avoid = 16;
	public const TroopListSortMenu.SortType CritAvoid = 17;
	public const TroopListSortMenu.SortType Move = 18;
}

// Namespace: 
[Serializable]
public class TroopListSortMenu.SortTitle // TypeDefIndex: 13302
{
	// Fields
	public GameObject m_root; // 0x10
	private int m_page; // 0x18
	private TroopListSortMenu.SortType m_sortType; // 0x1C
	private TextMeshProUGUI m_title; // 0x20
	private GameObject m_arrow; // 0x28

	// Methods

	// RVA: 0x23A8CB0 Offset: 0x23A8DB1 VA: 0x23A8CB0
	public void Setup(int page, string title, TroopListSortMenu.SortType type) { }

	// RVA: 0x23A8E70 Offset: 0x23A8F71 VA: 0x23A8E70
	public void SetArrow(Sprite setArrow) { }

	// RVA: 0x23A8F20 Offset: 0x23A9021 VA: 0x23A8F20
	public void SetArrowHide() { }

	// RVA: 0x23A8FA0 Offset: 0x23A90A1 VA: 0x23A8FA0
	public int GetPage() { }

	// RVA: 0x23A8FB0 Offset: 0x23A90B1 VA: 0x23A8FB0
	public TroopListSortMenu.SortType GetSortType() { }

	// RVA: 0x23A8FC0 Offset: 0x23A90C1 VA: 0x23A8FC0
	public RectTransform GetCursorRectTransform() { }

	// RVA: 0x23A9020 Offset: 0x23A9121 VA: 0x23A9020
	public void SetTextColor(bool isActive) { }

	// RVA: 0x23A9150 Offset: 0x23A9251 VA: 0x23A9150
	public void .ctor() { }
}

