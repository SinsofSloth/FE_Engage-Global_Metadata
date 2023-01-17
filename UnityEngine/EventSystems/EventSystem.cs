// Namespace: UnityEngine.EventSystems
[AddComponentMenu] // RVA: 0x437A0 Offset: 0x438A1 VA: 0x437A0
[DisallowMultipleComponent] // RVA: 0x437A0 Offset: 0x438A1 VA: 0x437A0
public class EventSystem : UIBehaviour // TypeDefIndex: 4409
{
	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x18
	private BaseInputModule m_CurrentInputModule; // 0x20
	private static List<EventSystem> m_EventSystems; // 0x0
	[SerializeField] // RVA: 0x45970 Offset: 0x45A71 VA: 0x45970
	[FormerlySerializedAsAttribute] // RVA: 0x45970 Offset: 0x45A71 VA: 0x45970
	private GameObject m_FirstSelected; // 0x28
	[SerializeField] // RVA: 0x459C0 Offset: 0x45AC1 VA: 0x459C0
	private bool m_sendNavigationEvents; // 0x30
	[SerializeField] // RVA: 0x459D0 Offset: 0x45AD1 VA: 0x459D0
	private int m_DragThreshold; // 0x34
	private GameObject m_CurrentSelected; // 0x38
	private bool m_HasFocus; // 0x40
	private bool m_SelectionGuard; // 0x41
	private BaseEventData m_DummyData; // 0x48
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8

	// Properties
	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[ObsoleteAttribute] // RVA: 0x468A0 Offset: 0x469A1 VA: 0x468A0
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }

	// Methods

	// RVA: 0x1A4B5E0 Offset: 0x1A4B6E1 VA: 0x1A4B5E0
	public static EventSystem get_current() { }

	// RVA: 0x1A4B6B0 Offset: 0x1A4B7B1 VA: 0x1A4B6B0
	public static void set_current(EventSystem value) { }

	// RVA: 0x1A4B870 Offset: 0x1A4B971 VA: 0x1A4B870
	public bool get_sendNavigationEvents() { }

	// RVA: 0x1A4B880 Offset: 0x1A4B981 VA: 0x1A4B880
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x1A4B890 Offset: 0x1A4B991 VA: 0x1A4B890
	public int get_pixelDragThreshold() { }

	// RVA: 0x1A4B8A0 Offset: 0x1A4B9A1 VA: 0x1A4B8A0
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x1A4B8B0 Offset: 0x1A4B9B1 VA: 0x1A4B8B0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x1A4B8C0 Offset: 0x1A4B9C1 VA: 0x1A4B8C0
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x1A4B8D0 Offset: 0x1A4B9D1 VA: 0x1A4B8D0
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x1A4B8E0 Offset: 0x1A4B9E1 VA: 0x1A4B8E0
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x1A4B8F0 Offset: 0x1A4B9F1 VA: 0x1A4B8F0
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x1A4B900 Offset: 0x1A4BA01 VA: 0x1A4B900
	public bool get_isFocused() { }

	// RVA: 0x1A4B910 Offset: 0x1A4BA11 VA: 0x1A4B910
	protected void .ctor() { }

	// RVA: 0x1A3E4B0 Offset: 0x1A3E5B1 VA: 0x1A3E4B0
	public void UpdateModules() { }

	// RVA: 0x1A4B9B0 Offset: 0x1A4BAB1 VA: 0x1A4B9B0
	public bool get_alreadySelecting() { }

	// RVA: 0x1A3DDC0 Offset: 0x1A3DEC1 VA: 0x1A3DDC0
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x1A4B9C0 Offset: 0x1A4BAC1 VA: 0x1A4B9C0
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x1A4BA70 Offset: 0x1A4BB71 VA: 0x1A4BA70
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x1A4BB10 Offset: 0x1A4BC11 VA: 0x1A4BB10
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x1A4BE50 Offset: 0x1A4BF51 VA: 0x1A4BE50
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x1A4C080 Offset: 0x1A4C181 VA: 0x1A4C080
	public bool IsPointerOverGameObject() { }

	// RVA: 0x1A4C130 Offset: 0x1A4C231 VA: 0x1A4C130
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1A4C1E0 Offset: 0x1A4C2E1 VA: 0x1A4C1E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A4C280 Offset: 0x1A4C381 VA: 0x1A4C280 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A4C390 Offset: 0x1A4C491 VA: 0x1A4C390
	private void TickModules() { }

	// RVA: 0x1A4C4B0 Offset: 0x1A4C5B1 VA: 0x1A4C4B0 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x1A4C4D0 Offset: 0x1A4C5D1 VA: 0x1A4C4D0 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x1A4C780 Offset: 0x1A4C881 VA: 0x1A4C780
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x1A4C8A0 Offset: 0x1A4C9A1 VA: 0x1A4C8A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A4CA00 Offset: 0x1A4CB01 VA: 0x1A4CA00
	private static void .cctor() { }
}

