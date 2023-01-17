// Namespace: UnityEngine.EventSystems
public class PointerEventData : BaseEventData // TypeDefIndex: 4389
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x45830 Offset: 0x45931 VA: 0x45830
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x45840 Offset: 0x45941 VA: 0x45840
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x45850 Offset: 0x45951 VA: 0x45850
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x45860 Offset: 0x45961 VA: 0x45860
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x45870 Offset: 0x45971 VA: 0x45870
	private GameObject <pointerClick>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x45880 Offset: 0x45981 VA: 0x45880
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x45890 Offset: 0x45991 VA: 0x45890
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0x98
	public List<GameObject> hovered; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x458A0 Offset: 0x459A1 VA: 0x458A0
	private bool <eligibleForClick>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x458B0 Offset: 0x459B1 VA: 0x458B0
	private int <pointerId>k__BackingField; // 0xEC
	[CompilerGeneratedAttribute] // RVA: 0x458C0 Offset: 0x459C1 VA: 0x458C0
	private Vector2 <position>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x458D0 Offset: 0x459D1 VA: 0x458D0
	private Vector2 <delta>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x458E0 Offset: 0x459E1 VA: 0x458E0
	private Vector2 <pressPosition>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x458F0 Offset: 0x459F1 VA: 0x458F0
	private Vector3 <worldPosition>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x45900 Offset: 0x45A01 VA: 0x45900
	private Vector3 <worldNormal>k__BackingField; // 0x114
	[CompilerGeneratedAttribute] // RVA: 0x45910 Offset: 0x45A11 VA: 0x45910
	private float <clickTime>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x45920 Offset: 0x45A21 VA: 0x45920
	private int <clickCount>k__BackingField; // 0x124
	[CompilerGeneratedAttribute] // RVA: 0x45930 Offset: 0x45A31 VA: 0x45930
	private Vector2 <scrollDelta>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x45940 Offset: 0x45A41 VA: 0x45940
	private bool <useDragThreshold>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x45950 Offset: 0x45A51 VA: 0x45950
	private bool <dragging>k__BackingField; // 0x131
	[CompilerGeneratedAttribute] // RVA: 0x45960 Offset: 0x45A61 VA: 0x45960
	private PointerEventData.InputButton <button>k__BackingField; // 0x134

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public GameObject pointerClick { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x46820 Offset: 0x46921 VA: 0x46820
	public Vector3 worldPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x46860 Offset: 0x46961 VA: 0x46860
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x46450 Offset: 0x46551 VA: 0x46450
	// RVA: 0x1B6F8D0 Offset: 0x1B6F9D1 VA: 0x1B6F8D0
	public GameObject get_pointerEnter() { }

	[CompilerGeneratedAttribute] // RVA: 0x46460 Offset: 0x46561 VA: 0x46460
	// RVA: 0x1B6F8E0 Offset: 0x1B6F9E1 VA: 0x1B6F8E0
	public void set_pointerEnter(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46470 Offset: 0x46571 VA: 0x46470
	// RVA: 0x1B6F8F0 Offset: 0x1B6F9F1 VA: 0x1B6F8F0
	public GameObject get_lastPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x46480 Offset: 0x46581 VA: 0x46480
	// RVA: 0x1B6F900 Offset: 0x1B6FA01 VA: 0x1B6F900
	private void set_lastPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46490 Offset: 0x46591 VA: 0x46490
	// RVA: 0x1B6F910 Offset: 0x1B6FA11 VA: 0x1B6F910
	public GameObject get_rawPointerPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x464A0 Offset: 0x465A1 VA: 0x464A0
	// RVA: 0x1B6F920 Offset: 0x1B6FA21 VA: 0x1B6F920
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x464B0 Offset: 0x465B1 VA: 0x464B0
	// RVA: 0x1B6F930 Offset: 0x1B6FA31 VA: 0x1B6F930
	public GameObject get_pointerDrag() { }

	[CompilerGeneratedAttribute] // RVA: 0x464C0 Offset: 0x465C1 VA: 0x464C0
	// RVA: 0x1B6F940 Offset: 0x1B6FA41 VA: 0x1B6F940
	public void set_pointerDrag(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x464D0 Offset: 0x465D1 VA: 0x464D0
	// RVA: 0x1B6F950 Offset: 0x1B6FA51 VA: 0x1B6F950
	public GameObject get_pointerClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x464E0 Offset: 0x465E1 VA: 0x464E0
	// RVA: 0x1B6F960 Offset: 0x1B6FA61 VA: 0x1B6F960
	public void set_pointerClick(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x464F0 Offset: 0x465F1 VA: 0x464F0
	// RVA: 0x1B6F970 Offset: 0x1B6FA71 VA: 0x1B6F970
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x46500 Offset: 0x46601 VA: 0x46500
	// RVA: 0x1B6F9A0 Offset: 0x1B6FAA1 VA: 0x1B6F9A0
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46510 Offset: 0x46611 VA: 0x46510
	// RVA: 0x1B6F9D0 Offset: 0x1B6FAD1 VA: 0x1B6F9D0
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x46520 Offset: 0x46621 VA: 0x46520
	// RVA: 0x1B6FA00 Offset: 0x1B6FB01 VA: 0x1B6FA00
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46530 Offset: 0x46631 VA: 0x46530
	// RVA: 0x1B6FA30 Offset: 0x1B6FB31 VA: 0x1B6FA30
	public bool get_eligibleForClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x46540 Offset: 0x46641 VA: 0x46540
	// RVA: 0x1B6FA40 Offset: 0x1B6FB41 VA: 0x1B6FA40
	public void set_eligibleForClick(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46550 Offset: 0x46651 VA: 0x46550
	// RVA: 0x1B6FA50 Offset: 0x1B6FB51 VA: 0x1B6FA50
	public int get_pointerId() { }

	[CompilerGeneratedAttribute] // RVA: 0x46560 Offset: 0x46661 VA: 0x46560
	// RVA: 0x1B6FA60 Offset: 0x1B6FB61 VA: 0x1B6FA60
	public void set_pointerId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46570 Offset: 0x46671 VA: 0x46570
	// RVA: 0x1B6FA70 Offset: 0x1B6FB71 VA: 0x1B6FA70
	public Vector2 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x46580 Offset: 0x46681 VA: 0x46580
	// RVA: 0x1B6FA80 Offset: 0x1B6FB81 VA: 0x1B6FA80
	public void set_position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46590 Offset: 0x46691 VA: 0x46590
	// RVA: 0x1B6FA90 Offset: 0x1B6FB91 VA: 0x1B6FA90
	public Vector2 get_delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x465A0 Offset: 0x466A1 VA: 0x465A0
	// RVA: 0x1B6FAA0 Offset: 0x1B6FBA1 VA: 0x1B6FAA0
	public void set_delta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x465B0 Offset: 0x466B1 VA: 0x465B0
	// RVA: 0x1B6FAB0 Offset: 0x1B6FBB1 VA: 0x1B6FAB0
	public Vector2 get_pressPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x465C0 Offset: 0x466C1 VA: 0x465C0
	// RVA: 0x1B6FAC0 Offset: 0x1B6FBC1 VA: 0x1B6FAC0
	public void set_pressPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x465D0 Offset: 0x466D1 VA: 0x465D0
	// RVA: 0x1B6FAD0 Offset: 0x1B6FBD1 VA: 0x1B6FAD0
	public Vector3 get_worldPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x465E0 Offset: 0x466E1 VA: 0x465E0
	// RVA: 0x1B6FAE0 Offset: 0x1B6FBE1 VA: 0x1B6FAE0
	public void set_worldPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x465F0 Offset: 0x466F1 VA: 0x465F0
	// RVA: 0x1B6FAF0 Offset: 0x1B6FBF1 VA: 0x1B6FAF0
	public Vector3 get_worldNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x46600 Offset: 0x46701 VA: 0x46600
	// RVA: 0x1B6FB00 Offset: 0x1B6FC01 VA: 0x1B6FB00
	public void set_worldNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46610 Offset: 0x46711 VA: 0x46610
	// RVA: 0x1B6FB10 Offset: 0x1B6FC11 VA: 0x1B6FB10
	public float get_clickTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x46620 Offset: 0x46721 VA: 0x46620
	// RVA: 0x1B6FB20 Offset: 0x1B6FC21 VA: 0x1B6FB20
	public void set_clickTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46630 Offset: 0x46731 VA: 0x46630
	// RVA: 0x1B6FB30 Offset: 0x1B6FC31 VA: 0x1B6FB30
	public int get_clickCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x46640 Offset: 0x46741 VA: 0x46640
	// RVA: 0x1B6FB40 Offset: 0x1B6FC41 VA: 0x1B6FB40
	public void set_clickCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46650 Offset: 0x46751 VA: 0x46650
	// RVA: 0x1B6FB50 Offset: 0x1B6FC51 VA: 0x1B6FB50
	public Vector2 get_scrollDelta() { }

	[CompilerGeneratedAttribute] // RVA: 0x46660 Offset: 0x46761 VA: 0x46660
	// RVA: 0x1B6FB60 Offset: 0x1B6FC61 VA: 0x1B6FB60
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46670 Offset: 0x46771 VA: 0x46670
	// RVA: 0x1B6FB70 Offset: 0x1B6FC71 VA: 0x1B6FB70
	public bool get_useDragThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x46680 Offset: 0x46781 VA: 0x46680
	// RVA: 0x1B6FB80 Offset: 0x1B6FC81 VA: 0x1B6FB80
	public void set_useDragThreshold(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x46690 Offset: 0x46791 VA: 0x46690
	// RVA: 0x1B6FB90 Offset: 0x1B6FC91 VA: 0x1B6FB90
	public bool get_dragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x466A0 Offset: 0x467A1 VA: 0x466A0
	// RVA: 0x1B6FBA0 Offset: 0x1B6FCA1 VA: 0x1B6FBA0
	public void set_dragging(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x466B0 Offset: 0x467B1 VA: 0x466B0
	// RVA: 0x1B6FBB0 Offset: 0x1B6FCB1 VA: 0x1B6FBB0
	public PointerEventData.InputButton get_button() { }

	[CompilerGeneratedAttribute] // RVA: 0x466C0 Offset: 0x467C1 VA: 0x466C0
	// RVA: 0x1B6FBC0 Offset: 0x1B6FCC1 VA: 0x1B6FBC0
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x1B6FBD0 Offset: 0x1B6FCD1 VA: 0x1B6FBD0
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1B6FCD0 Offset: 0x1B6FDD1 VA: 0x1B6FCD0
	public bool IsPointerMoving() { }

	// RVA: 0x1B6FD10 Offset: 0x1B6FE11 VA: 0x1B6FD10
	public bool IsScrolling() { }

	// RVA: 0x1B6FD50 Offset: 0x1B6FE51 VA: 0x1B6FD50
	public Camera get_enterEventCamera() { }

	// RVA: 0x1B6FDF0 Offset: 0x1B6FEF1 VA: 0x1B6FDF0
	public Camera get_pressEventCamera() { }

	// RVA: 0x1B6FE90 Offset: 0x1B6FF91 VA: 0x1B6FE90
	public GameObject get_pointerPress() { }

	// RVA: 0x1B6FEA0 Offset: 0x1B6FFA1 VA: 0x1B6FEA0
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x1B6FF60 Offset: 0x1B70061 VA: 0x1B6FF60 Slot: 3
	public override string ToString() { }
}

