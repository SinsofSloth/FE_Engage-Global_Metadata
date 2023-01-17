// Namespace: UnityEngine.EventSystems
[RequireComponent] // RVA: 0x43840 Offset: 0x43941 VA: 0x43840
public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 4418
{
	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x18
	private AxisEventData m_AxisEventData; // 0x20
	private EventSystem m_EventSystem; // 0x28
	private BaseEventData m_BaseEventData; // 0x30
	protected BaseInput m_InputOverride; // 0x38
	private BaseInput m_DefaultInput; // 0x40

	// Properties
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x1A3E1A0 Offset: 0x1A3E2A1 VA: 0x1A3E1A0
	public BaseInput get_input() { }

	// RVA: 0x1A3E400 Offset: 0x1A3E501 VA: 0x1A3E400
	public BaseInput get_inputOverride() { }

	// RVA: 0x1A3E410 Offset: 0x1A3E511 VA: 0x1A3E410
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x1A3E420 Offset: 0x1A3E521 VA: 0x1A3E420
	protected EventSystem get_eventSystem() { }

	// RVA: 0x1A3E430 Offset: 0x1A3E531 VA: 0x1A3E430 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A3E640 Offset: 0x1A3E741 VA: 0x1A3E640 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x1A3E670 Offset: 0x1A3E771 VA: 0x1A3E670
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x1A3E7C0 Offset: 0x1A3E8C1 VA: 0x1A3E7C0
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x1A3E840 Offset: 0x1A3E941 VA: 0x1A3E840
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x1A3E8D0 Offset: 0x1A3E9D1 VA: 0x1A3E8D0
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x1A3EA80 Offset: 0x1A3EB81 VA: 0x1A3EA80
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x1A3F0E0 Offset: 0x1A3F1E1 VA: 0x1A3F0E0 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x1A3F220 Offset: 0x1A3F321 VA: 0x1A3F220 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x1A3F2D0 Offset: 0x1A3F3D1 VA: 0x1A3F2D0 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1A3F2E0 Offset: 0x1A3F3E1 VA: 0x1A3F2E0 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x1A3F330 Offset: 0x1A3F431 VA: 0x1A3F330 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x1A3F340 Offset: 0x1A3F441 VA: 0x1A3F340 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x1A3F350 Offset: 0x1A3F451 VA: 0x1A3F350 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x1A3F360 Offset: 0x1A3F461 VA: 0x1A3F360 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x1A3F370 Offset: 0x1A3F471 VA: 0x1A3F370
	protected void .ctor() { }
}

