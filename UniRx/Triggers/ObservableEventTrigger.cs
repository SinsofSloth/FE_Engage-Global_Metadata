// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13730 Offset: 0x13831 VA: 0x13730
public class ObservableEventTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IInitializePotentialDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 6811
{
	// Fields
	private Subject<BaseEventData> onDeselect; // 0x48
	private Subject<AxisEventData> onMove; // 0x50
	private Subject<PointerEventData> onPointerDown; // 0x58
	private Subject<PointerEventData> onPointerEnter; // 0x60
	private Subject<PointerEventData> onPointerExit; // 0x68
	private Subject<PointerEventData> onPointerUp; // 0x70
	private Subject<BaseEventData> onSelect; // 0x78
	private Subject<PointerEventData> onPointerClick; // 0x80
	private Subject<BaseEventData> onSubmit; // 0x88
	private Subject<PointerEventData> onDrag; // 0x90
	private Subject<PointerEventData> onBeginDrag; // 0x98
	private Subject<PointerEventData> onEndDrag; // 0xA0
	private Subject<PointerEventData> onDrop; // 0xA8
	private Subject<BaseEventData> onUpdateSelected; // 0xB0
	private Subject<PointerEventData> onInitializePotentialDrag; // 0xB8
	private Subject<BaseEventData> onCancel; // 0xC0
	private Subject<PointerEventData> onScroll; // 0xC8

	// Methods

	// RVA: 0x19DC100 Offset: 0x19DC201 VA: 0x19DC100 Slot: 18
	private void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(BaseEventData eventData) { }

	// RVA: 0x19DC170 Offset: 0x19DC271 VA: 0x19DC170
	public IObservable<BaseEventData> OnDeselectAsObservable() { }

	// RVA: 0x19DC210 Offset: 0x19DC311 VA: 0x19DC210 Slot: 19
	private void UnityEngine.EventSystems.IMoveHandler.OnMove(AxisEventData eventData) { }

	// RVA: 0x19DC280 Offset: 0x19DC381 VA: 0x19DC280
	public IObservable<AxisEventData> OnMoveAsObservable() { }

	// RVA: 0x19DC320 Offset: 0x19DC421 VA: 0x19DC320 Slot: 7
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x19DC390 Offset: 0x19DC491 VA: 0x19DC390
	public IObservable<PointerEventData> OnPointerDownAsObservable() { }

	// RVA: 0x19DC430 Offset: 0x19DC531 VA: 0x19DC430 Slot: 5
	private void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x19DC4A0 Offset: 0x19DC5A1 VA: 0x19DC4A0
	public IObservable<PointerEventData> OnPointerEnterAsObservable() { }

	// RVA: 0x19DC540 Offset: 0x19DC641 VA: 0x19DC540 Slot: 6
	private void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x19DC5B0 Offset: 0x19DC6B1 VA: 0x19DC5B0
	public IObservable<PointerEventData> OnPointerExitAsObservable() { }

	// RVA: 0x19DC650 Offset: 0x19DC751 VA: 0x19DC650 Slot: 8
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x19DC6C0 Offset: 0x19DC7C1 VA: 0x19DC6C0
	public IObservable<PointerEventData> OnPointerUpAsObservable() { }

	// RVA: 0x19DC760 Offset: 0x19DC861 VA: 0x19DC760 Slot: 17
	private void UnityEngine.EventSystems.ISelectHandler.OnSelect(BaseEventData eventData) { }

	// RVA: 0x19DC7D0 Offset: 0x19DC8D1 VA: 0x19DC7D0
	public IObservable<BaseEventData> OnSelectAsObservable() { }

	// RVA: 0x19DC870 Offset: 0x19DC971 VA: 0x19DC870 Slot: 9
	private void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x19DC8E0 Offset: 0x19DC9E1 VA: 0x19DC8E0
	public IObservable<PointerEventData> OnPointerClickAsObservable() { }

	// RVA: 0x19DC980 Offset: 0x19DCA81 VA: 0x19DC980 Slot: 20
	private void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData) { }

	// RVA: 0x19DC9F0 Offset: 0x19DCAF1 VA: 0x19DC9F0
	public IObservable<BaseEventData> OnSubmitAsObservable() { }

	// RVA: 0x19DCA90 Offset: 0x19DCB91 VA: 0x19DCA90 Slot: 12
	private void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	// RVA: 0x19DCB00 Offset: 0x19DCC01 VA: 0x19DCB00
	public IObservable<PointerEventData> OnDragAsObservable() { }

	// RVA: 0x19DCBA0 Offset: 0x19DCCA1 VA: 0x19DCBA0 Slot: 10
	private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x19DCC10 Offset: 0x19DCD11 VA: 0x19DCC10
	public IObservable<PointerEventData> OnBeginDragAsObservable() { }

	// RVA: 0x19DCCB0 Offset: 0x19DCDB1 VA: 0x19DCCB0 Slot: 13
	private void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x19DCD20 Offset: 0x19DCE21 VA: 0x19DCD20
	public IObservable<PointerEventData> OnEndDragAsObservable() { }

	// RVA: 0x19DCDC0 Offset: 0x19DCEC1 VA: 0x19DCDC0 Slot: 14
	private void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData) { }

	// RVA: 0x19DCE30 Offset: 0x19DCF31 VA: 0x19DCE30
	public IObservable<PointerEventData> OnDropAsObservable() { }

	// RVA: 0x19DCED0 Offset: 0x19DCFD1 VA: 0x19DCED0 Slot: 16
	private void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x19DCF40 Offset: 0x19DD041 VA: 0x19DCF40
	public IObservable<BaseEventData> OnUpdateSelectedAsObservable() { }

	// RVA: 0x19DCFE0 Offset: 0x19DD0E1 VA: 0x19DCFE0 Slot: 11
	private void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x19DD050 Offset: 0x19DD151 VA: 0x19DD050
	public IObservable<PointerEventData> OnInitializePotentialDragAsObservable() { }

	// RVA: 0x19DD0F0 Offset: 0x19DD1F1 VA: 0x19DD0F0 Slot: 21
	private void UnityEngine.EventSystems.ICancelHandler.OnCancel(BaseEventData eventData) { }

	// RVA: 0x19DD160 Offset: 0x19DD261 VA: 0x19DD160
	public IObservable<BaseEventData> OnCancelAsObservable() { }

	// RVA: 0x19DD200 Offset: 0x19DD301 VA: 0x19DD200 Slot: 15
	private void UnityEngine.EventSystems.IScrollHandler.OnScroll(PointerEventData eventData) { }

	// RVA: 0x19DD270 Offset: 0x19DD371 VA: 0x19DD270
	public IObservable<PointerEventData> OnScrollAsObservable() { }

	// RVA: 0x19DD310 Offset: 0x19DD411 VA: 0x19DD310 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DD4A0 Offset: 0x19DD5A1 VA: 0x19DD4A0
	public void .ctor() { }
}

