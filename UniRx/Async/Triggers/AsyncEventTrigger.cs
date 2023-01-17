// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28310 Offset: 0x28411 VA: 0x28310
public class AsyncEventTrigger : AsyncTriggerBase // TypeDefIndex: 5167
{
	// Fields
	private AsyncTriggerPromise<BaseEventData> onDeselect; // 0x30
	private AsyncTriggerPromiseDictionary<BaseEventData> onDeselects; // 0x38
	private AsyncTriggerPromise<AxisEventData> onMove; // 0x40
	private AsyncTriggerPromiseDictionary<AxisEventData> onMoves; // 0x48
	private AsyncTriggerPromise<PointerEventData> onPointerDown; // 0x50
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerDowns; // 0x58
	private AsyncTriggerPromise<PointerEventData> onPointerEnter; // 0x60
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters; // 0x68
	private AsyncTriggerPromise<PointerEventData> onPointerExit; // 0x70
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerExits; // 0x78
	private AsyncTriggerPromise<PointerEventData> onPointerUp; // 0x80
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerUps; // 0x88
	private AsyncTriggerPromise<BaseEventData> onSelect; // 0x90
	private AsyncTriggerPromiseDictionary<BaseEventData> onSelects; // 0x98
	private AsyncTriggerPromise<PointerEventData> onPointerClick; // 0xA0
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerClicks; // 0xA8
	private AsyncTriggerPromise<BaseEventData> onSubmit; // 0xB0
	private AsyncTriggerPromiseDictionary<BaseEventData> onSubmits; // 0xB8
	private AsyncTriggerPromise<PointerEventData> onDrag; // 0xC0
	private AsyncTriggerPromiseDictionary<PointerEventData> onDrags; // 0xC8
	private AsyncTriggerPromise<PointerEventData> onBeginDrag; // 0xD0
	private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags; // 0xD8
	private AsyncTriggerPromise<PointerEventData> onEndDrag; // 0xE0
	private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags; // 0xE8
	private AsyncTriggerPromise<PointerEventData> onDrop; // 0xF0
	private AsyncTriggerPromiseDictionary<PointerEventData> onDrops; // 0xF8
	private AsyncTriggerPromise<BaseEventData> onUpdateSelected; // 0x100
	private AsyncTriggerPromiseDictionary<BaseEventData> onUpdateSelecteds; // 0x108
	private AsyncTriggerPromise<PointerEventData> onInitializePotentialDrag; // 0x110
	private AsyncTriggerPromiseDictionary<PointerEventData> onInitializePotentialDrags; // 0x118
	private AsyncTriggerPromise<BaseEventData> onCancel; // 0x120
	private AsyncTriggerPromiseDictionary<BaseEventData> onCancels; // 0x128
	private AsyncTriggerPromise<PointerEventData> onScroll; // 0x130
	private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls; // 0x138

	// Methods

	// RVA: 0x2E74C20 Offset: 0x2E74D21 VA: 0x2E74C20 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E75530 Offset: 0x2E75631 VA: 0x2E75530
	private void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2E75590 Offset: 0x2E75691 VA: 0x2E75590
	public UniTask OnDeselectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75620 Offset: 0x2E75721 VA: 0x2E75620
	private void OnMove(AxisEventData eventData) { }

	// RVA: 0x2E75680 Offset: 0x2E75781 VA: 0x2E75680
	public UniTask OnMoveAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75710 Offset: 0x2E75811 VA: 0x2E75710
	private void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2E75770 Offset: 0x2E75871 VA: 0x2E75770
	public UniTask OnPointerDownAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75800 Offset: 0x2E75901 VA: 0x2E75800
	private void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2E75860 Offset: 0x2E75961 VA: 0x2E75860
	public UniTask OnPointerEnterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E758F0 Offset: 0x2E759F1 VA: 0x2E758F0
	private void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2E75950 Offset: 0x2E75A51 VA: 0x2E75950
	public UniTask OnPointerExitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E759E0 Offset: 0x2E75AE1 VA: 0x2E759E0
	private void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2E75A40 Offset: 0x2E75B41 VA: 0x2E75A40
	public UniTask OnPointerUpAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75AD0 Offset: 0x2E75BD1 VA: 0x2E75AD0
	private void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2E75B30 Offset: 0x2E75C31 VA: 0x2E75B30
	public UniTask OnSelectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75BC0 Offset: 0x2E75CC1 VA: 0x2E75BC0
	private void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2E75C20 Offset: 0x2E75D21 VA: 0x2E75C20
	public UniTask OnPointerClickAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75CB0 Offset: 0x2E75DB1 VA: 0x2E75CB0
	private void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2E75D10 Offset: 0x2E75E11 VA: 0x2E75D10
	public UniTask OnSubmitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75DA0 Offset: 0x2E75EA1 VA: 0x2E75DA0
	private void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2E75E00 Offset: 0x2E75F01 VA: 0x2E75E00
	public UniTask OnDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75E90 Offset: 0x2E75F91 VA: 0x2E75E90
	private void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2E75EF0 Offset: 0x2E75FF1 VA: 0x2E75EF0
	public UniTask OnBeginDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E75F80 Offset: 0x2E76081 VA: 0x2E75F80
	private void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2E75FE0 Offset: 0x2E760E1 VA: 0x2E75FE0
	public UniTask OnEndDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76070 Offset: 0x2E76171 VA: 0x2E76070
	private void OnDrop(PointerEventData eventData) { }

	// RVA: 0x2E760D0 Offset: 0x2E761D1 VA: 0x2E760D0
	public UniTask OnDropAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76160 Offset: 0x2E76261 VA: 0x2E76160
	private void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x2E761C0 Offset: 0x2E762C1 VA: 0x2E761C0
	public UniTask OnUpdateSelectedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76250 Offset: 0x2E76351 VA: 0x2E76250
	private void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x2E762B0 Offset: 0x2E763B1 VA: 0x2E762B0
	public UniTask OnInitializePotentialDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76340 Offset: 0x2E76441 VA: 0x2E76340
	private void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2E763A0 Offset: 0x2E764A1 VA: 0x2E763A0
	public UniTask OnCancelAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76430 Offset: 0x2E76531 VA: 0x2E76430
	private void OnScroll(PointerEventData eventData) { }

	// RVA: 0x2E76490 Offset: 0x2E76591 VA: 0x2E76490
	public UniTask OnScrollAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76520 Offset: 0x2E76621 VA: 0x2E76520
	public void .ctor() { }
}

