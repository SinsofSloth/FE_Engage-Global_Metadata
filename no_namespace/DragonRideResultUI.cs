// Namespace: 
public class DragonRideResultUI.DragonRideResultUITarget // TypeDefIndex: 10526
{
	// Fields
	private Transform m_Node; // 0x10
	private TextMeshProUGUI m_Text; // 0x18

	// Methods

	// RVA: 0x1F01270 Offset: 0x1F01371 VA: 0x1F01270
	public void .ctor() { }

	// RVA: 0x1F01280 Offset: 0x1F01381 VA: 0x1F01280
	public void Init(Transform baseObj) { }

	// RVA: 0x1F01370 Offset: 0x1F01471 VA: 0x1F01370
	public void SetText(string str) { }

	// RVA: 0x1F01380 Offset: 0x1F01481 VA: 0x1F01380
	public void Show() { }

	// RVA: 0x1F013B0 Offset: 0x1F014B1 VA: 0x1F013B0
	public void Hide() { }
}

// Namespace: 
private enum DragonRideResultUI.ResultPhase // TypeDefIndex: 10528
{
	// Fields
	public int value__; // 0x0
	public const DragonRideResultUI.ResultPhase PhaseBeforeOpen = 0;
	public const DragonRideResultUI.ResultPhase PhaseTitle = 1;
	public const DragonRideResultUI.ResultPhase PhaseTargetCount = 2;
	public const DragonRideResultUI.ResultPhase PhaseAssistCount = 3;
	public const DragonRideResultUI.ResultPhase PhaseScore = 4;
	public const DragonRideResultUI.ResultPhase PhaseBestScore = 5;
	public const DragonRideResultUI.ResultPhase PhaseRank = 6;
	public const DragonRideResultUI.ResultPhase PhaseOther = 7;
	public const DragonRideResultUI.ResultPhase PhaseFinish = 8;
	public const DragonRideResultUI.ResultPhase PhaseCount = 9;
}

