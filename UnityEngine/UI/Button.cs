// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x427E0 Offset: 0x428E1 VA: 0x427E0
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 4244
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x43C50 Offset: 0x43D51 VA: 0x43C50
	[SerializeField] // RVA: 0x43C50 Offset: 0x43D51 VA: 0x43C50
	private Button.ButtonClickedEvent m_OnClick; // 0xF8

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x1A3FEA0 Offset: 0x1A3FFA1 VA: 0x1A3FEA0
	protected void .ctor() { }

	// RVA: 0x1A3FF50 Offset: 0x1A40051 VA: 0x1A3FF50
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x1A3FF60 Offset: 0x1A40061 VA: 0x1A3FF60
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x1A3FF70 Offset: 0x1A40071 VA: 0x1A3FF70
	private void Press() { }

	// RVA: 0x1A40010 Offset: 0x1A40111 VA: 0x1A40010 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1A400B0 Offset: 0x1A401B1 VA: 0x1A400B0 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x45B50 Offset: 0x45C51 VA: 0x45B50
	// RVA: 0x1A40200 Offset: 0x1A40301 VA: 0x1A40200
	private IEnumerator OnFinishSubmit() { }
}

