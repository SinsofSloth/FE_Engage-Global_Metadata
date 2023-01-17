// Namespace: App
public class DragonRideResultUI // TypeDefIndex: 10529
{
	// Fields
	private const int cFanfareExcellentIndex = 2;
	private const int cFanfareGoodIndex = 5;
	private string[] cRankNodeList; // 0x10
	private string[] cTargetNodeList; // 0x18
	private string[] cTargetMessageList; // 0x20
	private GameObject m_Root; // 0x28
	private DragonRideResultUI.DataSet m_data; // 0x30
	private double m_Timer; // 0x38
	private DragonRideResultUI.ResultPhase m_Phase; // 0x40
	private TextMeshProUGUI m_LevelText; // 0x48
	private Transform m_BrokenTargetNode; // 0x50
	private Transform m_AssistNode; // 0x58
	private Transform m_ScoreNode; // 0x60
	private TextMeshProUGUI m_ScoreText; // 0x68
	private Transform m_RankRoot; // 0x70
	private Transform m_RankNode; // 0x78
	private Transform m_BestScoreNode; // 0x80
	private TextMeshProUGUI m_BestScoreText; // 0x88
	private Transform m_NewRecordNode; // 0x90
	private DragonRideConfig m_Config; // 0x98

	// Properties
	public bool IsFinished { get; }

	// Methods

	// RVA: 0x2DCB650 Offset: 0x2DCB751 VA: 0x2DCB650
	public void .ctor() { }

	// RVA: 0x2DCBEA0 Offset: 0x2DCBFA1 VA: 0x2DCBEA0
	public void Init(GameObject rootObj, DragonRideResultUI.DataSet data) { }

	// RVA: 0x2DD2340 Offset: 0x2DD2441 VA: 0x2DD2340
	private void NextPhase() { }

	// RVA: 0x2DCCF50 Offset: 0x2DCD051 VA: 0x2DCCF50
	public void Tick() { }

	// RVA: 0x2DCCCE0 Offset: 0x2DCCDE1 VA: 0x2DCCCE0
	public void PlayResult() { }

	// RVA: 0x2DCD420 Offset: 0x2DCD521 VA: 0x2DCD420
	public void PlayCloseAnime() { }

	// RVA: 0x2DD2360 Offset: 0x2DD2461 VA: 0x2DD2360
	private void VoiceResultPerfect() { }

	// RVA: 0x2DD23E0 Offset: 0x2DD24E1 VA: 0x2DD23E0
	private void VoiceResultGood() { }

	// RVA: 0x2DD2460 Offset: 0x2DD2561 VA: 0x2DD2460
	private void VoiceResultBad() { }

	// RVA: 0x2DCDDA0 Offset: 0x2DCDEA1 VA: 0x2DCDDA0
	public void DestroyResult() { }

	// RVA: 0x2DCD410 Offset: 0x2DCD511 VA: 0x2DCD410
	public bool get_IsFinished() { }
}

