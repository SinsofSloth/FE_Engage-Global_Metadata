// Namespace: App
public class BattleRecordSetter : MonoBehaviour // TypeDefIndex: 12527
{
	// Fields
	[HeaderAttribute] // RVA: 0x29A940 Offset: 0x29AA41 VA: 0x29A940
	public TextMeshProUGUI InfoTitle; // 0x18
	[HeaderAttribute] // RVA: 0x29A980 Offset: 0x29AA81 VA: 0x29A980
	public GameObject Records; // 0x20
	[HeaderAttribute] // RVA: 0x29A9C0 Offset: 0x29AAC1 VA: 0x29A9C0
	public GameObject RecordPrefab; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29AA00 Offset: 0x29AB01 VA: 0x29AA00
	private int <ScrollTimePattern>k__BackingField; // 0x30
	private float m_ScrollTime; // 0x34
	private float m_StartPos; // 0x38
	private float m_RecordLength; // 0x3C
	private float m_ScrolledTime; // 0x40
	private List<RectTransform> m_RecordList; // 0x48
	private double m_StartTime; // 0x50

	// Properties
	public int ScrollTimePattern { get; set; }
	public bool IsFinished { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9700 Offset: 0x2C9801 VA: 0x2C9700
	// RVA: 0x225D520 Offset: 0x225D621 VA: 0x225D520
	public int get_ScrollTimePattern() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9710 Offset: 0x2C9811 VA: 0x2C9710
	// RVA: 0x225D530 Offset: 0x225D631 VA: 0x225D530
	private void set_ScrollTimePattern(int value) { }

	// RVA: 0x225D540 Offset: 0x225D641 VA: 0x225D540
	public bool get_IsFinished() { }

	// RVA: 0x225CF50 Offset: 0x225D051 VA: 0x225CF50
	public void Initialize() { }

	// RVA: 0x225D560 Offset: 0x225D661 VA: 0x225D560
	private void Update() { }

	// RVA: 0x225D7A0 Offset: 0x225D8A1 VA: 0x225D7A0
	public void .ctor() { }
}

