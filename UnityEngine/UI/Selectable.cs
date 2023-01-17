// Namespace: UnityEngine.UI
[DisallowMultipleComponent] // RVA: 0x43340 Offset: 0x43441 VA: 0x43340
[AddComponentMenu] // RVA: 0x43340 Offset: 0x43441 VA: 0x43340
[ExecuteAlways] // RVA: 0x43340 Offset: 0x43441 VA: 0x43340
[SelectionBaseAttribute] // RVA: 0x43340 Offset: 0x43441 VA: 0x43340
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 4343
{
	// Fields
	protected static Selectable[] s_Selectables; // 0x0
	protected static int s_SelectableCount; // 0x8
	private bool m_EnableCalled; // 0x18
	[SerializeField] // RVA: 0x45330 Offset: 0x45431 VA: 0x45330
	[FormerlySerializedAsAttribute] // RVA: 0x45330 Offset: 0x45431 VA: 0x45330
	private Navigation m_Navigation; // 0x20
	[SerializeField] // RVA: 0x45380 Offset: 0x45481 VA: 0x45380
	[FormerlySerializedAsAttribute] // RVA: 0x45380 Offset: 0x45481 VA: 0x45380
	private Selectable.Transition m_Transition; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0x453D0 Offset: 0x454D1 VA: 0x453D0
	[SerializeField] // RVA: 0x453D0 Offset: 0x454D1 VA: 0x453D0
	private ColorBlock m_Colors; // 0x4C
	[SerializeField] // RVA: 0x45420 Offset: 0x45521 VA: 0x45420
	[FormerlySerializedAsAttribute] // RVA: 0x45420 Offset: 0x45521 VA: 0x45420
	private SpriteState m_SpriteState; // 0xA8
	[FormerlySerializedAsAttribute] // RVA: 0x45470 Offset: 0x45571 VA: 0x45470
	[SerializeField] // RVA: 0x45470 Offset: 0x45571 VA: 0x45470
	private AnimationTriggers m_AnimationTriggers; // 0xC8
	[TooltipAttribute] // RVA: 0x454C0 Offset: 0x455C1 VA: 0x454C0
	[SerializeField] // RVA: 0x454C0 Offset: 0x455C1 VA: 0x454C0
	private bool m_Interactable; // 0xD0
	[SerializeField] // RVA: 0x45510 Offset: 0x45611 VA: 0x45510
	[FormerlySerializedAsAttribute] // RVA: 0x45510 Offset: 0x45611 VA: 0x45510
	[FormerlySerializedAsAttribute] // RVA: 0x45510 Offset: 0x45611 VA: 0x45510
	private Graphic m_TargetGraphic; // 0xD8
	private bool m_GroupsAllowInteraction; // 0xE0
	protected int m_CurrentIndex; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x45580 Offset: 0x45681 VA: 0x45580
	private bool <isPointerInside>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x45590 Offset: 0x45691 VA: 0x45590
	private bool <isPointerDown>k__BackingField; // 0xE9
	[CompilerGeneratedAttribute] // RVA: 0x455A0 Offset: 0x456A1 VA: 0x455A0
	private bool <hasSelection>k__BackingField; // 0xEA
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xF0

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[ObsoleteAttribute] // RVA: 0x467E0 Offset: 0x468E1 VA: 0x467E0
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x1B7C3A0 Offset: 0x1B7C4A1 VA: 0x1B7C3A0
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x1B7C450 Offset: 0x1B7C551 VA: 0x1B7C450
	public static int get_allSelectableCount() { }

	// RVA: 0x1B7C4C0 Offset: 0x1B7C5C1 VA: 0x1B7C4C0
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x1B7C570 Offset: 0x1B7C671 VA: 0x1B7C570
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x1B7C660 Offset: 0x1B7C761 VA: 0x1B7C660
	public Navigation get_navigation() { }

	// RVA: 0x1B7C680 Offset: 0x1B7C781 VA: 0x1B7C680
	public void set_navigation(Navigation value) { }

	// RVA: 0x1B7C7E0 Offset: 0x1B7C8E1 VA: 0x1B7C7E0
	public Selectable.Transition get_transition() { }

	// RVA: 0x1B7C7F0 Offset: 0x1B7C8F1 VA: 0x1B7C7F0
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x1B7C8C0 Offset: 0x1B7C9C1 VA: 0x1B7C8C0
	public ColorBlock get_colors() { }

	// RVA: 0x1B7C910 Offset: 0x1B7CA11 VA: 0x1B7C910
	public void set_colors(ColorBlock value) { }

	// RVA: 0x1B7CA40 Offset: 0x1B7CB41 VA: 0x1B7CA40
	public SpriteState get_spriteState() { }

	// RVA: 0x1B7CA60 Offset: 0x1B7CB61 VA: 0x1B7CA60
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x1B7CB40 Offset: 0x1B7CC41 VA: 0x1B7CB40
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x1B7CB50 Offset: 0x1B7CC51 VA: 0x1B7CB50
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x1B7CC20 Offset: 0x1B7CD21 VA: 0x1B7CC20
	public Graphic get_targetGraphic() { }

	// RVA: 0x1B7CC30 Offset: 0x1B7CD31 VA: 0x1B7CC30
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x1B7CD00 Offset: 0x1B7CE01 VA: 0x1B7CD00
	public bool get_interactable() { }

	// RVA: 0x1B7CD10 Offset: 0x1B7CE11 VA: 0x1B7CD10
	public void set_interactable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46170 Offset: 0x46271 VA: 0x46170
	// RVA: 0x1B7CF00 Offset: 0x1B7D001 VA: 0x1B7CF00
	private bool get_isPointerInside() { }

	[CompilerGeneratedAttribute] // RVA: 0x46180 Offset: 0x46281 VA: 0x46180
	// RVA: 0x1B7CF10 Offset: 0x1B7D011 VA: 0x1B7CF10
	private void set_isPointerInside(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46190 Offset: 0x46291 VA: 0x46190
	// RVA: 0x1B7CF20 Offset: 0x1B7D021 VA: 0x1B7CF20
	private bool get_isPointerDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x461A0 Offset: 0x462A1 VA: 0x461A0
	// RVA: 0x1B7CF30 Offset: 0x1B7D031 VA: 0x1B7CF30
	private void set_isPointerDown(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x461B0 Offset: 0x462B1 VA: 0x461B0
	// RVA: 0x1B7CF40 Offset: 0x1B7D041 VA: 0x1B7CF40
	private bool get_hasSelection() { }

	[CompilerGeneratedAttribute] // RVA: 0x461C0 Offset: 0x462C1 VA: 0x461C0
	// RVA: 0x1B7CF50 Offset: 0x1B7D051 VA: 0x1B7CF50
	private void set_hasSelection(bool value) { }

	// RVA: 0x1B7A020 Offset: 0x1B7A121 VA: 0x1B7A020
	protected void .ctor() { }

	// RVA: 0x1B7CF60 Offset: 0x1B7D061 VA: 0x1B7CF60
	public Image get_image() { }

	// RVA: 0x1B7CFF0 Offset: 0x1B7D0F1 VA: 0x1B7CFF0
	public void set_image(Image value) { }

	// RVA: 0x1B7D000 Offset: 0x1B7D101 VA: 0x1B7D000
	public Animator get_animator() { }

	// RVA: 0x1B7D060 Offset: 0x1B7D161 VA: 0x1B7D060 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1B7D120 Offset: 0x1B7D221 VA: 0x1B7D120 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x1B7D340 Offset: 0x1B7D441 VA: 0x1B7D340 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x1B7D360 Offset: 0x1B7D461 VA: 0x1B7D360 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1B7A5C0 Offset: 0x1B7A6C1 VA: 0x1B7A5C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B7D450 Offset: 0x1B7D551 VA: 0x1B7D450 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1B7C770 Offset: 0x1B7C871 VA: 0x1B7C770
	private void OnSetProperty() { }

	// RVA: 0x1B7A8E0 Offset: 0x1B7A9E1 VA: 0x1B7A8E0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B7D3D0 Offset: 0x1B7D4D1 VA: 0x1B7D3D0
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x1B7D490 Offset: 0x1B7D591 VA: 0x1B7D490 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x1B7DAE0 Offset: 0x1B7DBE1 VA: 0x1B7DAE0 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x1B7DD60 Offset: 0x1B7DE61 VA: 0x1B7DD60
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x1B7E190 Offset: 0x1B7E291 VA: 0x1B7E190
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x1B7E2F0 Offset: 0x1B7E3F1 VA: 0x1B7E2F0
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x1B7BE40 Offset: 0x1B7BF41 VA: 0x1B7BE40 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x1B7BF20 Offset: 0x1B7C021 VA: 0x1B7BF20 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x1B7C000 Offset: 0x1B7C101 VA: 0x1B7C000 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x1B7C0E0 Offset: 0x1B7C1E1 VA: 0x1B7C0E0 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x1B7BCB0 Offset: 0x1B7BDB1 VA: 0x1B7BCB0 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x1B7D5E0 Offset: 0x1B7D6E1 VA: 0x1B7D5E0
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x1B7D6D0 Offset: 0x1B7D7D1 VA: 0x1B7D6D0
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x1B7D840 Offset: 0x1B7D941 VA: 0x1B7D840
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x1B7E3B0 Offset: 0x1B7E4B1 VA: 0x1B7E3B0
	protected bool IsHighlighted() { }

	// RVA: 0x1B7E420 Offset: 0x1B7E521 VA: 0x1B7E420
	protected bool IsPressed() { }

	// RVA: 0x1B7E480 Offset: 0x1B7E581 VA: 0x1B7E480
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x1B7B410 Offset: 0x1B7B511 VA: 0x1B7B410 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1B7B860 Offset: 0x1B7B961 VA: 0x1B7B860 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1B7E530 Offset: 0x1B7E631 VA: 0x1B7E530 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1B7E5E0 Offset: 0x1B7E6E1 VA: 0x1B7E5E0 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1B7E690 Offset: 0x1B7E791 VA: 0x1B7E690 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1B7E740 Offset: 0x1B7E841 VA: 0x1B7E740 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1B7E7F0 Offset: 0x1B7E8F1 VA: 0x1B7E7F0 Slot: 38
	public virtual void Select() { }

	// RVA: 0x1B7E930 Offset: 0x1B7EA31 VA: 0x1B7E930
	private static void .cctor() { }
}

