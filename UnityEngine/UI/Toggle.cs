// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x434E0 Offset: 0x435E1 VA: 0x434E0
[RequireComponent] // RVA: 0x434E0 Offset: 0x435E1 VA: 0x434E0
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 4355
{
	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0xF8
	public Graphic graphic; // 0x100
	[SerializeField] // RVA: 0x45760 Offset: 0x45861 VA: 0x45760
	private ToggleGroup m_Group; // 0x108
	public Toggle.ToggleEvent onValueChanged; // 0x110
	[SerializeField] // RVA: 0x45770 Offset: 0x45871 VA: 0x45770
	[TooltipAttribute] // RVA: 0x45770 Offset: 0x45871 VA: 0x45770
	private bool m_IsOn; // 0x118

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0x1BF86D0 Offset: 0x1BF87D1 VA: 0x1BF86D0
	public ToggleGroup get_group() { }

	// RVA: 0x1BF86E0 Offset: 0x1BF87E1 VA: 0x1BF86E0
	public void set_group(ToggleGroup value) { }

	// RVA: 0x1BF8A90 Offset: 0x1BF8B91 VA: 0x1BF8A90
	protected void .ctor() { }

	// RVA: 0x1BF8BD0 Offset: 0x1BF8CD1 VA: 0x1BF8BD0 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1BF8BE0 Offset: 0x1BF8CE1 VA: 0x1BF8BE0 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x1BF8BF0 Offset: 0x1BF8CF1 VA: 0x1BF8BF0 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1BF8C00 Offset: 0x1BF8D01 VA: 0x1BF8C00 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1BF9080 Offset: 0x1BF9181 VA: 0x1BF9080 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1BF9150 Offset: 0x1BF9251 VA: 0x1BF9150 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1BF9180 Offset: 0x1BF9281 VA: 0x1BF9180 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1BF87A0 Offset: 0x1BF88A1 VA: 0x1BF87A0
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x1BF9770 Offset: 0x1BF9871 VA: 0x1BF9770
	public bool get_isOn() { }

	// RVA: 0x1BF9780 Offset: 0x1BF9881 VA: 0x1BF9780
	public void set_isOn(bool value) { }

	// RVA: 0x1BF9790 Offset: 0x1BF9891 VA: 0x1BF9790
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x1BF9260 Offset: 0x1BF9361 VA: 0x1BF9260
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x1BF89C0 Offset: 0x1BF8AC1 VA: 0x1BF89C0
	private void PlayEffect(bool instant) { }

	// RVA: 0x1BF9910 Offset: 0x1BF9A11 VA: 0x1BF9910 Slot: 6
	protected override void Start() { }

	// RVA: 0x1BF99D0 Offset: 0x1BF9AD1 VA: 0x1BF99D0
	private void InternalToggle() { }

	// RVA: 0x1BF9A40 Offset: 0x1BF9B41 VA: 0x1BF9A40 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1BF9AB0 Offset: 0x1BF9BB1 VA: 0x1BF9AB0 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1BF9B20 Offset: 0x1BF9C21 VA: 0x1BF9B20 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

