// Namespace: UnityEngine.EventSystems
[ObsoleteAttribute] // RVA: 0x43930 Offset: 0x43A31 VA: 0x43930
[AddComponentMenu] // RVA: 0x43930 Offset: 0x43A31 VA: 0x43930
public class TouchInputModule : PointerInputModule // TypeDefIndex: 4425
{
	// Fields
	private Vector2 m_LastMousePosition; // 0x58
	private Vector2 m_MousePosition; // 0x60
	private PointerEventData m_InputPointerEvent; // 0x68
	[SerializeField] // RVA: 0x45AE0 Offset: 0x45BE1 VA: 0x45AE0
	[FormerlySerializedAsAttribute] // RVA: 0x45AE0 Offset: 0x45BE1 VA: 0x45AE0
	private bool m_ForceModuleActive; // 0x70

	// Properties
	[ObsoleteAttribute] // RVA: 0x469C0 Offset: 0x46AC1 VA: 0x469C0
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x1BFA060 Offset: 0x1BFA161 VA: 0x1BFA060
	protected void .ctor() { }

	// RVA: 0x1BFA070 Offset: 0x1BFA171 VA: 0x1BFA070
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x1BFA080 Offset: 0x1BFA181 VA: 0x1BFA080
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x1BFA090 Offset: 0x1BFA191 VA: 0x1BFA090
	public bool get_forceModuleActive() { }

	// RVA: 0x1BFA0A0 Offset: 0x1BFA1A1 VA: 0x1BFA0A0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x1BFA0B0 Offset: 0x1BFA1B1 VA: 0x1BFA0B0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x1BFA230 Offset: 0x1BFA331 VA: 0x1BFA230 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x1BFA270 Offset: 0x1BFA371 VA: 0x1BFA270 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x1BFA350 Offset: 0x1BFA451 VA: 0x1BFA350
	private bool UseFakeInput() { }

	// RVA: 0x1BFA380 Offset: 0x1BFA481 VA: 0x1BFA380 Slot: 17
	public override void Process() { }

	// RVA: 0x1BFA3D0 Offset: 0x1BFA4D1 VA: 0x1BFA3D0
	private void FakeTouches() { }

	// RVA: 0x1BFA4C0 Offset: 0x1BFA5C1 VA: 0x1BFA4C0
	private void ProcessTouchEvents() { }

	// RVA: 0x1BFA660 Offset: 0x1BFA761 VA: 0x1BFA660
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x1BFAEC0 Offset: 0x1BFAFC1 VA: 0x1BFAEC0 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x1BFAEF0 Offset: 0x1BFAFF1 VA: 0x1BFAEF0 Slot: 3
	public override string ToString() { }
}

