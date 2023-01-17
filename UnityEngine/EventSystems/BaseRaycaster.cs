// Namespace: UnityEngine.EventSystems
public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 4429
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x18

	// Properties
	public abstract Camera eventCamera { get; }
	[ObsoleteAttribute] // RVA: 0x46A00 Offset: 0x46B01 VA: 0x46A00
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x1A3F870 Offset: 0x1A3F971 VA: 0x1A3F870 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x1A3F880 Offset: 0x1A3F981 VA: 0x1A3F880 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x1A3F890 Offset: 0x1A3F991 VA: 0x1A3F890 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x1A3F8A0 Offset: 0x1A3F9A1 VA: 0x1A3F8A0
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x1A3F980 Offset: 0x1A3FA81 VA: 0x1A3F980 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A3FD20 Offset: 0x1A3FE21 VA: 0x1A3FD20 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A3FDA0 Offset: 0x1A3FEA1 VA: 0x1A3FDA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A3FE20 Offset: 0x1A3FF21 VA: 0x1A3FE20 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A3FE50 Offset: 0x1A3FF51 VA: 0x1A3FE50 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A3FE80 Offset: 0x1A3FF81 VA: 0x1A3FE80
	protected void .ctor() { }
}

