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

