// Namespace: 
protected class PointerInputModule.ButtonState // TypeDefIndex: 4419
{
	// Fields
	private PointerEventData.InputButton m_Button; // 0x10
	private PointerInputModule.MouseButtonEventData m_EventData; // 0x18

	// Properties
	public PointerInputModule.MouseButtonEventData eventData { get; set; }
	public PointerEventData.InputButton button { get; set; }

	// Methods

	// RVA: 0x1BFEA00 Offset: 0x1BFEB01 VA: 0x1BFEA00
	public PointerInputModule.MouseButtonEventData get_eventData() { }

	// RVA: 0x1BFEA10 Offset: 0x1BFEB11 VA: 0x1BFEA10
	public void set_eventData(PointerInputModule.MouseButtonEventData value) { }

	// RVA: 0x1BFEA20 Offset: 0x1BFEB21 VA: 0x1BFEA20
	public PointerEventData.InputButton get_button() { }

	// RVA: 0x1BFEA30 Offset: 0x1BFEB31 VA: 0x1BFEA30
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x1BFEA40 Offset: 0x1BFEB41 VA: 0x1BFEA40
	public void .ctor() { }
}

// Namespace: 
protected class PointerInputModule.MouseState // TypeDefIndex: 4420
{
	// Fields
	private List<PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x1BFEA60 Offset: 0x1BFEB61 VA: 0x1BFEA60
	public bool AnyPressesThisFrame() { }

	// RVA: 0x1BFEB30 Offset: 0x1BFEC31 VA: 0x1BFEB30
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x1BF5230 Offset: 0x1BF5331 VA: 0x1BF5230
	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	// RVA: 0x1BFEC00 Offset: 0x1BFED01 VA: 0x1BFEC00
	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x1BFEC40 Offset: 0x1BFED41 VA: 0x1BFEC40
	public void .ctor() { }
}

// Namespace: 
public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 4421
{
	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x1BF57C0 Offset: 0x1BF58C1 VA: 0x1BF57C0
	public bool PressedThisFrame() { }

	// RVA: 0x1BF57D0 Offset: 0x1BF58D1 VA: 0x1BF57D0
	public bool ReleasedThisFrame() { }

	// RVA: 0x1BFEA50 Offset: 0x1BFEB51 VA: 0x1BFEA50
	public void .ctor() { }
}

