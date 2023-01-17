// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42830 Offset: 0x42931 VA: 0x42830
[RequireComponent] // RVA: 0x42830 Offset: 0x42931 VA: 0x42830
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 4264
{
	// Fields
	[SerializeField] // RVA: 0x43EC0 Offset: 0x43FC1 VA: 0x43EC0
	private RectTransform m_Template; // 0xF8
	[SerializeField] // RVA: 0x43ED0 Offset: 0x43FD1 VA: 0x43ED0
	private Text m_CaptionText; // 0x100
	[SerializeField] // RVA: 0x43EE0 Offset: 0x43FE1 VA: 0x43EE0
	private Image m_CaptionImage; // 0x108
	[SpaceAttribute] // RVA: 0x43EF0 Offset: 0x43FF1 VA: 0x43EF0
	[SerializeField] // RVA: 0x43EF0 Offset: 0x43FF1 VA: 0x43EF0
	private Text m_ItemText; // 0x110
	[SerializeField] // RVA: 0x43F30 Offset: 0x44031 VA: 0x43F30
	private Image m_ItemImage; // 0x118
	[SpaceAttribute] // RVA: 0x43F40 Offset: 0x44041 VA: 0x43F40
	[SerializeField] // RVA: 0x43F40 Offset: 0x44041 VA: 0x43F40
	private int m_Value; // 0x120
	[SpaceAttribute] // RVA: 0x43F80 Offset: 0x44081 VA: 0x43F80
	[SerializeField] // RVA: 0x43F80 Offset: 0x44081 VA: 0x43F80
	private Dropdown.OptionDataList m_Options; // 0x128
	[SerializeField] // RVA: 0x43FC0 Offset: 0x440C1 VA: 0x43FC0
	[SpaceAttribute] // RVA: 0x43FC0 Offset: 0x440C1 VA: 0x43FC0
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x130
	[SerializeField] // RVA: 0x44000 Offset: 0x44101 VA: 0x44000
	private float m_AlphaFadeSpeed; // 0x138
	private GameObject m_Dropdown; // 0x140
	private GameObject m_Blocker; // 0x148
	private List<Dropdown.DropdownItem> m_Items; // 0x150
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x158
	private bool validTemplate; // 0x160
	private static Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x1A48520 Offset: 0x1A48621 VA: 0x1A48520
	public RectTransform get_template() { }

	// RVA: 0x1A479A0 Offset: 0x1A47AA1 VA: 0x1A479A0
	public void set_template(RectTransform value) { }

	// RVA: 0x1A48530 Offset: 0x1A48631 VA: 0x1A48530
	public Text get_captionText() { }

	// RVA: 0x1A479D0 Offset: 0x1A47AD1 VA: 0x1A479D0
	public void set_captionText(Text value) { }

	// RVA: 0x1A48540 Offset: 0x1A48641 VA: 0x1A48540
	public Image get_captionImage() { }

	// RVA: 0x1A48550 Offset: 0x1A48651 VA: 0x1A48550
	public void set_captionImage(Image value) { }

	// RVA: 0x1A48580 Offset: 0x1A48681 VA: 0x1A48580
	public Text get_itemText() { }

	// RVA: 0x1A47A00 Offset: 0x1A47B01 VA: 0x1A47A00
	public void set_itemText(Text value) { }

	// RVA: 0x1A48590 Offset: 0x1A48691 VA: 0x1A48590
	public Image get_itemImage() { }

	// RVA: 0x1A485A0 Offset: 0x1A486A1 VA: 0x1A485A0
	public void set_itemImage(Image value) { }

	// RVA: 0x1A47A30 Offset: 0x1A47B31 VA: 0x1A47A30
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x1A485D0 Offset: 0x1A486D1 VA: 0x1A485D0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x1A48600 Offset: 0x1A48701 VA: 0x1A48600
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x1A48610 Offset: 0x1A48711 VA: 0x1A48610
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0x1A48620 Offset: 0x1A48721 VA: 0x1A48620
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1A48630 Offset: 0x1A48731 VA: 0x1A48630
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1A48640 Offset: 0x1A48741 VA: 0x1A48640
	public int get_value() { }

	// RVA: 0x1A48650 Offset: 0x1A48751 VA: 0x1A48650
	public void set_value(int value) { }

	// RVA: 0x1A48760 Offset: 0x1A48861 VA: 0x1A48760
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1A48660 Offset: 0x1A48761 VA: 0x1A48660
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x1A48770 Offset: 0x1A48871 VA: 0x1A48770
	protected void .ctor() { }

	// RVA: 0x1A488C0 Offset: 0x1A489C1 VA: 0x1A488C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1A489F0 Offset: 0x1A48AF1 VA: 0x1A489F0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1A48AA0 Offset: 0x1A48BA1 VA: 0x1A48AA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A47A40 Offset: 0x1A47B41 VA: 0x1A47A40
	public void RefreshShownValue() { }

	// RVA: 0x1A48D00 Offset: 0x1A48E01 VA: 0x1A48D00
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x1A48D70 Offset: 0x1A48E71 VA: 0x1A48D70
	public void AddOptions(List<string> options) { }

	// RVA: 0x1A48E90 Offset: 0x1A48F91 VA: 0x1A48E90
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x1A48FB0 Offset: 0x1A490B1 VA: 0x1A48FB0
	public void ClearOptions() { }

	// RVA: 0x1A49020 Offset: 0x1A49121 VA: 0x1A49020
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A1810 Offset: 0x22A1911 VA: 0x22A1810
	|-Dropdown.GetOrAddComponent<Canvas>
	|-Dropdown.GetOrAddComponent<CanvasGroup>
	|-Dropdown.GetOrAddComponent<GraphicRaycaster>
	|-Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x1A49750 Offset: 0x1A49851 VA: 0x1A49750 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1A4A530 Offset: 0x1A4A631 VA: 0x1A4A530 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1A4A540 Offset: 0x1A4A641 VA: 0x1A4A540 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1A49760 Offset: 0x1A49861 VA: 0x1A49760
	public void Show() { }

	// RVA: 0x1A4AB70 Offset: 0x1A4AC71 VA: 0x1A4AB70 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x1A4AFC0 Offset: 0x1A4B0C1 VA: 0x1A4AFC0 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1A4B030 Offset: 0x1A4B131 VA: 0x1A4B030 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x1A4B0B0 Offset: 0x1A4B1B1 VA: 0x1A4B0B0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1A4B120 Offset: 0x1A4B221 VA: 0x1A4B120 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1A4B1A0 Offset: 0x1A4B2A1 VA: 0x1A4B1A0 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x1A4A720 Offset: 0x1A4A821 VA: 0x1A4A720
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x1A4B1B0 Offset: 0x1A4B2B1 VA: 0x1A4B1B0
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1A4A9D0 Offset: 0x1A4AAD1 VA: 0x1A4A9D0
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1A4B2D0 Offset: 0x1A4B3D1 VA: 0x1A4B2D0
	private void SetAlpha(float alpha) { }

	// RVA: 0x1A4A550 Offset: 0x1A4A651 VA: 0x1A4A550
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0x45C10 Offset: 0x45D11 VA: 0x45C10
	// RVA: 0x1A4B3A0 Offset: 0x1A4B4A1 VA: 0x1A4B3A0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1A48B60 Offset: 0x1A48C61 VA: 0x1A48B60
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x1A4B430 Offset: 0x1A4B531 VA: 0x1A4B430
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x1A4B560 Offset: 0x1A4B661 VA: 0x1A4B560
	private static void .cctor() { }
}

