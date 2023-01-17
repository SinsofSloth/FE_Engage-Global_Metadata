// Namespace: App
public class LaterTalkSetter : MonoBehaviour // TypeDefIndex: 12576
{
	// Fields
	[HeaderAttribute] // RVA: 0x29AE60 Offset: 0x29AF61 VA: 0x29AE60
	public GameObject CharaSolo; // 0x18
	public GameObject CharaPair; // 0x20
	[HeaderAttribute] // RVA: 0x29AEA0 Offset: 0x29AFA1 VA: 0x29AEA0
	public LaterTalkSetter.UnitInfo Main; // 0x28
	[HeaderAttribute] // RVA: 0x29AEE0 Offset: 0x29AFE1 VA: 0x29AEE0
	public LaterTalkSetter.UnitInfo PairLeft; // 0x30
	public LaterTalkSetter.UnitInfo PairRight; // 0x38
	[HeaderAttribute] // RVA: 0x29AF20 Offset: 0x29B021 VA: 0x29AF20
	public Image Symbol; // 0x40
	public TextMeshProUGUI MainText; // 0x48
	private float m_BaseDispTime; // 0x50
	private float m_OthersTime; // 0x54
	private float m_WaitTimeAfter; // 0x58
	private float m_CurrentTime; // 0x5C
	private List<LaterTalkSetter.UnitData> m_UnitData; // 0x60
	private int m_UnitIndex; // 0x68
	private double m_StartTime; // 0x70

	// Properties
	public bool IsStarted { get; }
	public bool IsFinished { get; }
	public bool IsFinishedCompletely { get; }
	public LaterTalkSetter.UnitData CurrentUnit { get; }
	public LaterTalkSetter.UnitData NextUnit { get; }
	public float LastDispTime { get; }
	public float DisplayTime { get; }

	// Methods

	// RVA: 0x1F802D0 Offset: 0x1F803D1 VA: 0x1F802D0
	public void Init() { }

	// RVA: 0x1F804C0 Offset: 0x1F805C1 VA: 0x1F804C0
	public void UpdateData() { }

	// RVA: 0x1F809E0 Offset: 0x1F80AE1 VA: 0x1F809E0
	private void SetUnitData(Unit unit, LaterTalkSetter.UnitInfo info) { }

	// RVA: 0x1F81050 Offset: 0x1F81151 VA: 0x1F81050
	public bool get_IsStarted() { }

	// RVA: 0x1F81060 Offset: 0x1F81161 VA: 0x1F81060
	public bool get_IsFinished() { }

	// RVA: 0x1F810A0 Offset: 0x1F811A1 VA: 0x1F810A0
	public bool get_IsFinishedCompletely() { }

	// RVA: 0x1F80950 Offset: 0x1F80A51 VA: 0x1F80950
	public LaterTalkSetter.UnitData get_CurrentUnit() { }

	// RVA: 0x1F7FD40 Offset: 0x1F7FE41 VA: 0x1F7FD40
	public LaterTalkSetter.UnitData get_NextUnit() { }

	// RVA: 0x1F810D0 Offset: 0x1F811D1 VA: 0x1F810D0
	public float get_LastDispTime() { }

	// RVA: 0x1F81080 Offset: 0x1F81181 VA: 0x1F81080
	public float get_DisplayTime() { }

	// RVA: 0x1F81170 Offset: 0x1F81271 VA: 0x1F81170
	private void Start() { }

	// RVA: 0x1F81AE0 Offset: 0x1F81BE1 VA: 0x1F81AE0
	private void Update() { }

	// RVA: 0x1F81B30 Offset: 0x1F81C31 VA: 0x1F81B30
	public void MoveNext() { }

	// RVA: 0x1F81B40 Offset: 0x1F81C41 VA: 0x1F81B40
	public void ForceFinish(float fadeOutTime) { }

	// RVA: 0x1F81C10 Offset: 0x1F81D11 VA: 0x1F81C10
	public void .ctor() { }
}

