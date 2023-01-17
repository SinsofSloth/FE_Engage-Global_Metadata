// Namespace: UnityEngine.UI
[DisallowMultipleComponent] // RVA: 0x43570 Offset: 0x43671 VA: 0x43570
[AddComponentMenu] // RVA: 0x43570 Offset: 0x43671 VA: 0x43570
public class ToggleGroup : UIBehaviour // TypeDefIndex: 4357
{
	// Fields
	[SerializeField] // RVA: 0x457C0 Offset: 0x458C1 VA: 0x457C0
	private bool m_AllowSwitchOff; // 0x18
	protected List<Toggle> m_Toggles; // 0x20

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x1BF9B30 Offset: 0x1BF9C31 VA: 0x1BF9B30
	public bool get_allowSwitchOff() { }

	// RVA: 0x1BF9B40 Offset: 0x1BF9C41 VA: 0x1BF9B40
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x1BF9B50 Offset: 0x1BF9C51 VA: 0x1BF9B50
	protected void .ctor() { }

	// RVA: 0x1BF9BF0 Offset: 0x1BF9CF1 VA: 0x1BF9BF0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1BF9C10 Offset: 0x1BF9D11 VA: 0x1BF9C10 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1BF9C30 Offset: 0x1BF9D31 VA: 0x1BF9C30
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x1BF95A0 Offset: 0x1BF96A1 VA: 0x1BF95A0
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x1BF9460 Offset: 0x1BF9561 VA: 0x1BF9460
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x1BF9500 Offset: 0x1BF9601 VA: 0x1BF9500
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x1BF8C90 Offset: 0x1BF8D91 VA: 0x1BF8C90
	public void EnsureValidState() { }

	// RVA: 0x1BF97A0 Offset: 0x1BF98A1 VA: 0x1BF97A0
	public bool AnyTogglesOn() { }

	// RVA: 0x1BF9D80 Offset: 0x1BF9E81 VA: 0x1BF9D80
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x1BF9EB0 Offset: 0x1BF9FB1 VA: 0x1BF9EB0
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x1BF9F50 Offset: 0x1BFA051 VA: 0x1BF9F50
	public void SetAllTogglesOff(bool sendCallback = True) { }
}

