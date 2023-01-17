// Namespace: UnityEngine.EventSystems
[AddComponentMenu] // RVA: 0x43A20 Offset: 0x43B21 VA: 0x43A20
[RequireComponent] // RVA: 0x43A20 Offset: 0x43B21 VA: 0x43A20
public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 4432
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x20
	[SerializeField] // RVA: 0x45B30 Offset: 0x45C31 VA: 0x45B30
	protected LayerMask m_EventMask; // 0x28
	[SerializeField] // RVA: 0x45B40 Offset: 0x45C41 VA: 0x45B40
	protected int m_MaxRayIntersections; // 0x2C
	protected int m_LastMaxRayIntersections; // 0x30
	private RaycastHit[] m_Hits; // 0x38

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x1B6E820 Offset: 0x1B6E921 VA: 0x1B6E820
	protected void .ctor() { }

	// RVA: 0x1B6F2B0 Offset: 0x1B6F3B1 VA: 0x1B6F2B0 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x1B6F380 Offset: 0x1B6F481 VA: 0x1B6F380 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x1B6F1D0 Offset: 0x1B6F2D1 VA: 0x1B6F1D0
	public int get_finalEventMask() { }

	// RVA: 0x1B6F460 Offset: 0x1B6F561 VA: 0x1B6F460
	public LayerMask get_eventMask() { }

	// RVA: 0x1B6F470 Offset: 0x1B6F571 VA: 0x1B6F470
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x1B6F480 Offset: 0x1B6F581 VA: 0x1B6F480
	public int get_maxRayIntersections() { }

	// RVA: 0x1B6F490 Offset: 0x1B6F591 VA: 0x1B6F490
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x1B6EE40 Offset: 0x1B6EF41 VA: 0x1B6EE40
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	// RVA: 0x1B6F4A0 Offset: 0x1B6F5A1 VA: 0x1B6F4A0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

