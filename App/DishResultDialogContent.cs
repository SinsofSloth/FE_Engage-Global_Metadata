// Namespace: App
public class DishResultDialogContent : MonoBehaviour // TypeDefIndex: 10491
{
	// Fields
	[SerializeField] // RVA: 0x28E3B0 Offset: 0x28E4B1 VA: 0x28E3B0
	private Animator m_Animator; // 0x18
	[HeaderAttribute] // RVA: 0x28E3C0 Offset: 0x28E4C1 VA: 0x28E3C0
	[SerializeField] // RVA: 0x28E3C0 Offset: 0x28E4C1 VA: 0x28E3C0
	private TextMeshProUGUI m_DishText; // 0x20
	[HeaderAttribute] // RVA: 0x28E410 Offset: 0x28E511 VA: 0x28E410
	[SerializeField] // RVA: 0x28E410 Offset: 0x28E511 VA: 0x28E410
	private TextMeshProUGUI m_GradeTitle; // 0x28
	[SerializeField] // RVA: 0x28E460 Offset: 0x28E561 VA: 0x28E460
	private List<GameObject> m_GradeList; // 0x30
	[HeaderAttribute] // RVA: 0x28E470 Offset: 0x28E571 VA: 0x28E470
	[SerializeField] // RVA: 0x28E470 Offset: 0x28E571 VA: 0x28E470
	private TextMeshProUGUI m_CondText; // 0x38
	[HeaderAttribute] // RVA: 0x28E4C0 Offset: 0x28E5C1 VA: 0x28E4C0
	[SerializeField] // RVA: 0x28E4C0 Offset: 0x28E5C1 VA: 0x28E4C0
	private List<GameObject> m_EnhanceObjectList; // 0x40
	[SerializeField] // RVA: 0x28E510 Offset: 0x28E611 VA: 0x28E510
	private GameObject m_NothingObject; // 0x48
	[HeaderAttribute] // RVA: 0x28E520 Offset: 0x28E621 VA: 0x28E520
	[SerializeField] // RVA: 0x28E520 Offset: 0x28E621 VA: 0x28E520
	private GameObject m_EnhanceBonus; // 0x50
	[SerializeField] // RVA: 0x28E570 Offset: 0x28E671 VA: 0x28E570
	private List<GameObject> m_BonusObjectList; // 0x58
	[SerializeField] // RVA: 0x28E580 Offset: 0x28E681 VA: 0x28E580
	[HeaderAttribute] // RVA: 0x28E580 Offset: 0x28E681 VA: 0x28E580
	private TextMeshProUGUI m_EveryoneText; // 0x60

	// Methods

	// RVA: 0x237A380 Offset: 0x237A481 VA: 0x237A380
	public void Open() { }

	// RVA: 0x237A7A0 Offset: 0x237A8A1 VA: 0x237A7A0
	public void Close() { }

	// RVA: 0x237A470 Offset: 0x237A571 VA: 0x237A470
	public bool IsOpening() { }

	// RVA: 0x237A890 Offset: 0x237A991 VA: 0x237A890
	public bool IsClosing() { }

	// RVA: 0x237AE40 Offset: 0x237AF41 VA: 0x237AE40
	public bool IsClosed() { }

	// RVA: 0x237AEA0 Offset: 0x237AFA1 VA: 0x237AEA0
	private void Start() { }

	// RVA: 0x2379D90 Offset: 0x2379E91 VA: 0x2379D90
	public void SetDish(Dish dish) { }

	// RVA: 0x237AFA0 Offset: 0x237B0A1 VA: 0x237AFA0
	private void SetGrade(TasteData taste) { }

	// RVA: 0x237B2D0 Offset: 0x237B3D1 VA: 0x237B2D0
	private bool SetEnhance(CapabilityDefinition.Type type, int index, int value) { }

	// RVA: 0x237B3F0 Offset: 0x237B4F1 VA: 0x237B3F0
	private bool SetBonus(CapabilityDefinition.Type type, int index, int value) { }

	// RVA: 0x237B980 Offset: 0x237BA81 VA: 0x237B980
	public void .ctor() { }
}

