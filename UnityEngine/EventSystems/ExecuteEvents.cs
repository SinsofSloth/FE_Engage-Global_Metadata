// Namespace: UnityEngine.EventSystems
public static class ExecuteEvents // TypeDefIndex: 4416
{
	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x80
	private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3160 Offset: 0x22B3261 VA: 0x22B3160
	|-ExecuteEvents.ValidateEventData<AxisEventData>
	|-ExecuteEvents.ValidateEventData<object>
	|-ExecuteEvents.ValidateEventData<PointerEventData>
	*/

	// RVA: 0x1A4CFA0 Offset: 0x1A4D0A1 VA: 0x1A4CFA0
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D0A0 Offset: 0x1A4D1A1 VA: 0x1A4D0A0
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D1A0 Offset: 0x1A4D2A1 VA: 0x1A4D1A0
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D2A0 Offset: 0x1A4D3A1 VA: 0x1A4D2A0
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D3A0 Offset: 0x1A4D4A1 VA: 0x1A4D3A0
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D4A0 Offset: 0x1A4D5A1 VA: 0x1A4D4A0
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D5A0 Offset: 0x1A4D6A1 VA: 0x1A4D5A0
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D6A0 Offset: 0x1A4D7A1 VA: 0x1A4D6A0
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D7A0 Offset: 0x1A4D8A1 VA: 0x1A4D7A0
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D8A0 Offset: 0x1A4D9A1 VA: 0x1A4D8A0
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4D9A0 Offset: 0x1A4DAA1 VA: 0x1A4D9A0
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4DAA0 Offset: 0x1A4DBA1 VA: 0x1A4DAA0
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4DB50 Offset: 0x1A4DC51 VA: 0x1A4DB50
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4DC00 Offset: 0x1A4DD01 VA: 0x1A4DC00
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4DCB0 Offset: 0x1A4DDB1 VA: 0x1A4DCB0
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4DDB0 Offset: 0x1A4DEB1 VA: 0x1A4DDB0
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4DE60 Offset: 0x1A4DF61 VA: 0x1A4DE60
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4DF10 Offset: 0x1A4E011 VA: 0x1A4DF10
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x1A4DF80 Offset: 0x1A4E081 VA: 0x1A4DF80
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x1A4DFF0 Offset: 0x1A4E0F1 VA: 0x1A4DFF0
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x1A4E060 Offset: 0x1A4E161 VA: 0x1A4E060
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x1A4E0D0 Offset: 0x1A4E1D1 VA: 0x1A4E0D0
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x1A4E140 Offset: 0x1A4E241 VA: 0x1A4E140
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x1A4E1B0 Offset: 0x1A4E2B1 VA: 0x1A4E1B0
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x1A4E220 Offset: 0x1A4E321 VA: 0x1A4E220
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x1A4E290 Offset: 0x1A4E391 VA: 0x1A4E290
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x1A4E300 Offset: 0x1A4E401 VA: 0x1A4E300
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x1A4E370 Offset: 0x1A4E471 VA: 0x1A4E370
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x1A4E3E0 Offset: 0x1A4E4E1 VA: 0x1A4E3E0
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x1A4E450 Offset: 0x1A4E551 VA: 0x1A4E450
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x1A4E4C0 Offset: 0x1A4E5C1 VA: 0x1A4E4C0
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x1A4E530 Offset: 0x1A4E631 VA: 0x1A4E530
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x1A4E5A0 Offset: 0x1A4E6A1 VA: 0x1A4E5A0
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x1A4E610 Offset: 0x1A4E711 VA: 0x1A4E610
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x1A4E680 Offset: 0x1A4E781 VA: 0x1A4E680
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B2520 Offset: 0x22B2621 VA: 0x22B2520
	|-ExecuteEvents.Execute<IBeginDragHandler>
	|-ExecuteEvents.Execute<ICancelHandler>
	|-ExecuteEvents.Execute<IDeselectHandler>
	|-ExecuteEvents.Execute<IDragHandler>
	|-ExecuteEvents.Execute<IEndDragHandler>
	|-ExecuteEvents.Execute<IInitializePotentialDragHandler>
	|-ExecuteEvents.Execute<IMoveHandler>
	|-ExecuteEvents.Execute<IPointerClickHandler>
	|-ExecuteEvents.Execute<IPointerEnterHandler>
	|-ExecuteEvents.Execute<IPointerExitHandler>
	|-ExecuteEvents.Execute<IPointerUpHandler>
	|-ExecuteEvents.Execute<ISelectHandler>
	|-ExecuteEvents.Execute<ISubmitHandler>
	|-ExecuteEvents.Execute<IUpdateSelectedHandler>
	|-ExecuteEvents.Execute<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B29C0 Offset: 0x22B2AC1 VA: 0x22B29C0
	|-ExecuteEvents.ExecuteHierarchy<IDropHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>
	|-ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>
	|-ExecuteEvents.ExecuteHierarchy<IScrollHandler>
	|-ExecuteEvents.ExecuteHierarchy<object>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3040 Offset: 0x22B3141 VA: 0x22B3040
	|-ExecuteEvents.ShouldSendToComponent<object>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B2CA0 Offset: 0x22B2DA1 VA: 0x22B2CA0
	|-ExecuteEvents.GetEventList<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B2420 Offset: 0x22B2521 VA: 0x22B2420
	|-ExecuteEvents.CanHandleEvent<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B2B40 Offset: 0x22B2C41 VA: 0x22B2B40
	|-ExecuteEvents.GetEventHandler<IDragHandler>
	|-ExecuteEvents.GetEventHandler<IPointerClickHandler>
	|-ExecuteEvents.GetEventHandler<IScrollHandler>
	|-ExecuteEvents.GetEventHandler<ISelectHandler>
	|-ExecuteEvents.GetEventHandler<object>
	*/

	// RVA: 0x1A4E820 Offset: 0x1A4E921 VA: 0x1A4E820
	private static void .cctor() { }
}

