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
public class Dropdown.OptionData // TypeDefIndex: 4259
{
	// Fields
	[SerializeField] // RVA: 0x44050 Offset: 0x44151 VA: 0x44050
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x44060 Offset: 0x44161 VA: 0x44060
	private Sprite m_Image; // 0x18

	// Properties
	public string text { get; set; }
	public Sprite image { get; set; }

	// Methods

	// RVA: 0x1BFCDB0 Offset: 0x1BFCEB1 VA: 0x1BFCDB0
	public string get_text() { }

	// RVA: 0x1BFCDC0 Offset: 0x1BFCEC1 VA: 0x1BFCDC0
	public void set_text(string value) { }

	// RVA: 0x1BFCDD0 Offset: 0x1BFCED1 VA: 0x1BFCDD0
	public Sprite get_image() { }

	// RVA: 0x1BFCDE0 Offset: 0x1BFCEE1 VA: 0x1BFCDE0
	public void set_image(Sprite value) { }

	// RVA: 0x1BFCDF0 Offset: 0x1BFCEF1 VA: 0x1BFCDF0
	public void .ctor() { }

	// RVA: 0x1BFCE00 Offset: 0x1BFCF01 VA: 0x1BFCE00
	public void .ctor(string text) { }

	// RVA: 0x1BFCE40 Offset: 0x1BFCF41 VA: 0x1BFCE40
	public void .ctor(Sprite image) { }

	// RVA: 0x1BFCE80 Offset: 0x1BFCF81 VA: 0x1BFCE80
	public void .ctor(string text, Sprite image) { }
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
[Serializable]
public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 4261
{
	// Methods

	// RVA: 0x1BFCB70 Offset: 0x1BFCC71 VA: 0x1BFCB70
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x428D0 Offset: 0x429D1 VA: 0x428D0
private sealed class Dropdown.<DelayedDestroyDropdownList>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4263
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public Dropdown <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x45C80 Offset: 0x45D81 VA: 0x45C80
	// RVA: 0x1BFCA10 Offset: 0x1BFCB11 VA: 0x1BFCA10
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x45C90 Offset: 0x45D91 VA: 0x45C90
	// RVA: 0x1BFCA40 Offset: 0x1BFCB41 VA: 0x1BFCA40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BFCA50 Offset: 0x1BFCB51 VA: 0x1BFCA50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x45CA0 Offset: 0x45DA1 VA: 0x45CA0
	// RVA: 0x1BFCB10 Offset: 0x1BFCC11 VA: 0x1BFCB10 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x45CB0 Offset: 0x45DB1 VA: 0x45CB0
	// RVA: 0x1BFCB20 Offset: 0x1BFCC21 VA: 0x1BFCB20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x45CC0 Offset: 0x45DC1 VA: 0x45CC0
	// RVA: 0x1BFCB60 Offset: 0x1BFCC61 VA: 0x1BFCB60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

