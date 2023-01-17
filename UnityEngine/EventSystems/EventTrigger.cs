// Namespace: UnityEngine.EventSystems
[AddComponentMenu] // RVA: 0x437F0 Offset: 0x438F1 VA: 0x437F0
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 4412
{
	// Fields
	[SerializeField] // RVA: 0x459E0 Offset: 0x45AE1 VA: 0x459E0
	[FormerlySerializedAsAttribute] // RVA: 0x459E0 Offset: 0x45AE1 VA: 0x459E0
	private List<EventTrigger.Entry> m_Delegates; // 0x18

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x468E0 Offset: 0x469E1 VA: 0x468E0
	[ObsoleteAttribute] // RVA: 0x468E0 Offset: 0x469E1 VA: 0x468E0
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x1A4CB10 Offset: 0x1A4CC11 VA: 0x1A4CB10
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x1A4CC50 Offset: 0x1A4CD51 VA: 0x1A4CC50
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x1A4CC60 Offset: 0x1A4CD61 VA: 0x1A4CC60
	protected void .ctor() { }

	// RVA: 0x1A4CBB0 Offset: 0x1A4CCB1 VA: 0x1A4CBB0
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x1A4CC70 Offset: 0x1A4CD71 VA: 0x1A4CC70
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x1A4CC80 Offset: 0x1A4CD81 VA: 0x1A4CC80
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x1A4CE90 Offset: 0x1A4CF91 VA: 0x1A4CE90 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1A4CEA0 Offset: 0x1A4CFA1 VA: 0x1A4CEA0 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1A4CEB0 Offset: 0x1A4CFB1 VA: 0x1A4CEB0 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A4CEC0 Offset: 0x1A4CFC1 VA: 0x1A4CEC0 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x1A4CED0 Offset: 0x1A4CFD1 VA: 0x1A4CED0 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A4CEE0 Offset: 0x1A4CFE1 VA: 0x1A4CEE0 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1A4CEF0 Offset: 0x1A4CFF1 VA: 0x1A4CEF0 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1A4CF00 Offset: 0x1A4D001 VA: 0x1A4CF00 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1A4CF10 Offset: 0x1A4D011 VA: 0x1A4CF10 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1A4CF20 Offset: 0x1A4D021 VA: 0x1A4CF20 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1A4CF30 Offset: 0x1A4D031 VA: 0x1A4CF30 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x1A4CF40 Offset: 0x1A4D041 VA: 0x1A4CF40 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1A4CF50 Offset: 0x1A4D051 VA: 0x1A4CF50 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1A4CF60 Offset: 0x1A4D061 VA: 0x1A4CF60 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A4CF70 Offset: 0x1A4D071 VA: 0x1A4CF70 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A4CF80 Offset: 0x1A4D081 VA: 0x1A4CF80 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1A4CF90 Offset: 0x1A4D091 VA: 0x1A4CF90 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }
}

