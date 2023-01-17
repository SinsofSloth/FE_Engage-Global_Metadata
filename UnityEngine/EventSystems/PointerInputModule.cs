// Namespace: UnityEngine.EventSystems
public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 4422
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
	private readonly PointerInputModule.MouseState m_MouseState; // 0x50

	// Methods

	// RVA: 0x1B70C30 Offset: 0x1B70D31 VA: 0x1B70C30
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x1B70D20 Offset: 0x1B70E21 VA: 0x1B70D20
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x1B70D80 Offset: 0x1B70E81 VA: 0x1B70D80
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x1B70FE0 Offset: 0x1B710E1 VA: 0x1B70FE0
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x1B71060 Offset: 0x1B71161 VA: 0x1B71060
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x1B710F0 Offset: 0x1B711F1 VA: 0x1B710F0 Slot: 26
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x1B71110 Offset: 0x1B71211 VA: 0x1B71110 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x1B71580 Offset: 0x1B71681 VA: 0x1B71580
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x1B71610 Offset: 0x1B71711 VA: 0x1B71610
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x1B71670 Offset: 0x1B71771 VA: 0x1B71670 Slot: 28
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x1B716C0 Offset: 0x1B717C1 VA: 0x1B716C0 Slot: 29
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x1B71A60 Offset: 0x1B71B61 VA: 0x1B71A60 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1B71B50 Offset: 0x1B71C51 VA: 0x1B71B50
	protected void ClearSelection() { }

	// RVA: 0x1B71CE0 Offset: 0x1B71DE1 VA: 0x1B71CE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B71F20 Offset: 0x1B72021 VA: 0x1B71F20
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x1B72030 Offset: 0x1B72131 VA: 0x1B72030
	protected void .ctor() { }
}

