// Namespace: App.CookingMenu
public class DishSelectMenuContent : BasicMenuContent // TypeDefIndex: 14244
{
	// Fields
	private List<Animator> m_winSubAnimatorList; // 0xE8
	private DishSelectMenuCategoryContent m_CategoryContent; // 0xF0
	[SerializeField] // RVA: 0x29E280 Offset: 0x29E381 VA: 0x29E280
	private DishSelectFoodInfoContent m_FoodInfoContent; // 0xF8
	[SerializeField] // RVA: 0x29E290 Offset: 0x29E391 VA: 0x29E290
	[HeaderAttribute] // RVA: 0x29E290 Offset: 0x29E391 VA: 0x29E290
	private TextMeshProUGUI m_BasicEffectText; // 0x100
	[SerializeField] // RVA: 0x29E2E0 Offset: 0x29E3E1 VA: 0x29E2E0
	private TextMeshProUGUI m_CanAddFoodText; // 0x108
	[SerializeField] // RVA: 0x29E2F0 Offset: 0x29E3F1 VA: 0x29E2F0
	private TextMeshProUGUI m_FavoriteText; // 0x110
	[SerializeField] // RVA: 0x29E300 Offset: 0x29E401 VA: 0x29E300
	private List<TextMeshProUGUI> m_FavoriteLikeText; // 0x118
	[SerializeField] // RVA: 0x29E310 Offset: 0x29E411 VA: 0x29E310
	private List<TextMeshProUGUI> m_FavoriteNormalText; // 0x120
	[SerializeField] // RVA: 0x29E320 Offset: 0x29E421 VA: 0x29E320
	private List<TextMeshProUGUI> m_FavoriteDislikeText; // 0x128

	// Properties
	public DishSelectFoodInfoContent FoodInfo { get; }

	// Methods

	// RVA: 0x237EAD0 Offset: 0x237EBD1 VA: 0x237EAD0 Slot: 30
	protected override void Awake() { }

	// RVA: 0x237EB00 Offset: 0x237EC01 VA: 0x237EB00
	private void SetMessage() { }

	// RVA: 0x237F000 Offset: 0x237F101 VA: 0x237F000 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x237F200 Offset: 0x237F301 VA: 0x237F200 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x237DAF0 Offset: 0x237DBF1 VA: 0x237DAF0
	public bool KeyLeft(bool isTrigger) { }

	// RVA: 0x237DDF0 Offset: 0x237DEF1 VA: 0x237DDF0
	public bool KeyRight(bool isTrigger) { }

	// RVA: 0x237F2C0 Offset: 0x237F3C1 VA: 0x237F2C0
	public DishSelectFoodInfoContent get_FoodInfo() { }

	// RVA: 0x237F2D0 Offset: 0x237F3D1 VA: 0x237F2D0
	public void .ctor() { }
}

