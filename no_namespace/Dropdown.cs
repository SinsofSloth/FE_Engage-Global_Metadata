// Namespace: 
protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 4258
{
	// Fields
	[SerializeField] // RVA: 0x44010 Offset: 0x44111 VA: 0x44010
	private Text m_Text; // 0x18
	[SerializeField] // RVA: 0x44020 Offset: 0x44121 VA: 0x44020
	private Image m_Image; // 0x20
	[SerializeField] // RVA: 0x44030 Offset: 0x44131 VA: 0x44030
	private RectTransform m_RectTransform; // 0x28
	[SerializeField] // RVA: 0x44040 Offset: 0x44141 VA: 0x44040
	private Toggle m_Toggle; // 0x30

	// Properties
	public Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x1BFCBD0 Offset: 0x1BFCCD1 VA: 0x1BFCBD0
	public Text get_text() { }

	// RVA: 0x1BFCBE0 Offset: 0x1BFCCE1 VA: 0x1BFCBE0
	public void set_text(Text value) { }

	// RVA: 0x1BFCBF0 Offset: 0x1BFCCF1 VA: 0x1BFCBF0
	public Image get_image() { }

	// RVA: 0x1BFCC00 Offset: 0x1BFCD01 VA: 0x1BFCC00
	public void set_image(Image value) { }

	// RVA: 0x1BFCC10 Offset: 0x1BFCD11 VA: 0x1BFCC10
	public RectTransform get_rectTransform() { }

	// RVA: 0x1BFCC20 Offset: 0x1BFCD21 VA: 0x1BFCC20
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x1BFCC30 Offset: 0x1BFCD31 VA: 0x1BFCC30
	public Toggle get_toggle() { }

	// RVA: 0x1BFCC40 Offset: 0x1BFCD41 VA: 0x1BFCC40
	public void set_toggle(Toggle value) { }

	// RVA: 0x1BFCC50 Offset: 0x1BFCD51 VA: 0x1BFCC50 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1BFCCE0 Offset: 0x1BFCDE1 VA: 0x1BFCCE0 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1BFCDA0 Offset: 0x1BFCEA1 VA: 0x1BFCDA0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Dropdown.OptionDataList // TypeDefIndex: 4260
{
	// Fields
	[SerializeField] // RVA: 0x44070 Offset: 0x44171 VA: 0x44070
	private List<Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x1BFCED0 Offset: 0x1BFCFD1 VA: 0x1BFCED0
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x1BFCEE0 Offset: 0x1BFCFE1 VA: 0x1BFCEE0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x1BFCEF0 Offset: 0x1BFCFF1 VA: 0x1BFCEF0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x428C0 Offset: 0x429C1 VA: 0x428C0
private sealed class Dropdown.<>c__DisplayClass62_0 // TypeDefIndex: 4262
{
	// Fields
	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x1BFC9E0 Offset: 0x1BFCAE1 VA: 0x1BFC9E0
	public void .ctor() { }

	// RVA: 0x1BFC9F0 Offset: 0x1BFCAF1 VA: 0x1BFC9F0
	internal void <Show>b__0(bool x) { }
}

