// Namespace: App
public class AI : SingletonClass<AI> // TypeDefIndex: 9233
{
	// Fields
	private AIOrder m_Order; // 0x20
	private AIThink m_Think; // 0x28
	private AICannon m_Cannon; // 0x30
	private AIInterruptAttack m_InterruptAttack; // 0x38
	private AI.Seq m_Seq; // 0x40
	private bool m_Crossfire; // 0x44
	private bool m_IsTargetUpdate; // 0x45
	private bool m_IsVersus; // 0x46
	private bool m_IsVersusCasual; // 0x47
	private bool m_IsVersusRankedOrMock; // 0x48

	// Properties
	public AIOrder Order { get; }
	public AIThink Think { get; }
	public AICannon Cannon { get; }
	public AIInterruptAttack InterruptAttack { get; }

	// Methods

	// RVA: 0x1C9E900 Offset: 0x1C9EA01 VA: 0x1C9E900
	public void .ctor() { }

	// RVA: 0x1C9F280 Offset: 0x1C9F381 VA: 0x1C9F280
	public AIOrder get_Order() { }

	// RVA: 0x1C9F290 Offset: 0x1C9F391 VA: 0x1C9F290
	public AIThink get_Think() { }

	// RVA: 0x1C9F2A0 Offset: 0x1C9F3A1 VA: 0x1C9F2A0
	public AICannon get_Cannon() { }

	// RVA: 0x1C9F2B0 Offset: 0x1C9F3B1 VA: 0x1C9F2B0
	public AIInterruptAttack get_InterruptAttack() { }

	// RVA: 0x1C9F2C0 Offset: 0x1C9F3C1 VA: 0x1C9F2C0
	public void SetSeq(AI.Seq seq) { }

	// RVA: 0x1C9F2D0 Offset: 0x1C9F3D1 VA: 0x1C9F2D0
	public void SetCrossfire(bool enable) { }

	// RVA: 0x1C9F2E0 Offset: 0x1C9F3E1 VA: 0x1C9F2E0
	public bool IsVersus() { }

	// RVA: 0x1C9F2F0 Offset: 0x1C9F3F1 VA: 0x1C9F2F0
	public bool IsVersusCasual() { }

	// RVA: 0x1C9F300 Offset: 0x1C9F401 VA: 0x1C9F300
	public bool IsVersusRankedOrMock() { }

	// RVA: 0x1C9F310 Offset: 0x1C9F411 VA: 0x1C9F310
	public static bool IsEntrust() { }

	// RVA: 0x1C9F3A0 Offset: 0x1C9F4A1 VA: 0x1C9F3A0
	public static Random Rand() { }

	// RVA: 0x1C9F3B0 Offset: 0x1C9F4B1 VA: 0x1C9F3B0
	public static bool IsRandom() { }

	// RVA: 0x1C9F3E0 Offset: 0x1C9F4E1 VA: 0x1C9F3E0
	public void Processing() { }

	// RVA: 0x1CA0080 Offset: 0x1CA0181 VA: 0x1CA0080
	public void SetupForEngageOrGodChange(Unit unit) { }

	// RVA: 0x1CA0090 Offset: 0x1CA0191 VA: 0x1CA0090
	public bool IsOrderUnitEngageOrGodChange() { }

	// RVA: 0x1CA00C0 Offset: 0x1CA01C1 VA: 0x1CA00C0
	public void SetupForRemove(Unit unit) { }

	// RVA: 0x1CA00D0 Offset: 0x1CA01D1 VA: 0x1CA00D0
	public bool IsOrderUnitRemove() { }

	// RVA: 0x1CA0100 Offset: 0x1CA0201 VA: 0x1CA0100
	public void SetupForRemagic(Unit unit) { }

	// RVA: 0x1CA0110 Offset: 0x1CA0211 VA: 0x1CA0110
	public bool IsOrderUnitRemagic() { }

	// RVA: 0x1CA0140 Offset: 0x1CA0241 VA: 0x1CA0140
	public void SetupForRerewarp(Unit unit) { }

	// RVA: 0x1CA0150 Offset: 0x1CA0251 VA: 0x1CA0150
	public bool IsOrderUnitRerewarp() { }

	// RVA: 0x1C9F470 Offset: 0x1C9F571 VA: 0x1C9F470
	private void iInitialize() { }

	// RVA: 0x1C9F840 Offset: 0x1C9F941 VA: 0x1C9F840
	private bool iProcessing() { }

	// RVA: 0x1CA0180 Offset: 0x1CA0281 VA: 0x1CA0180
	private bool iProcessingRemove() { }

	// RVA: 0x1CA0460 Offset: 0x1CA0561 VA: 0x1CA0460
	private bool iProcessingRemagic() { }

	// RVA: 0x1CA0740 Offset: 0x1CA0841 VA: 0x1CA0740
	private bool iProcessingRerewarp() { }

	// RVA: 0x1C9FBA0 Offset: 0x1C9FCA1 VA: 0x1C9FBA0
	private bool iCrossfire() { }

	// RVA: 0x1C9FD40 Offset: 0x1C9FE41 VA: 0x1C9FD40
	private bool iInterruptAttack() { }

	// RVA: 0x1CA1C00 Offset: 0x1CA1D01 VA: 0x1CA1C00
	private void Completion(Unit unit) { }

	// RVA: 0x1C9FEA0 Offset: 0x1C9FFA1 VA: 0x1C9FEA0
	private void iFinalize() { }

	[ConditionalAttribute] // RVA: 0x2AE7C0 Offset: 0x2AE8C1 VA: 0x2AE7C0
	// RVA: 0x1CA2F10 Offset: 0x1CA3011 VA: 0x1CA2F10
	private void DbgPLCPrepare() { }

	[ConditionalAttribute] // RVA: 0x2AE800 Offset: 0x2AE901 VA: 0x2AE800
	// RVA: 0x1CA2F20 Offset: 0x1CA3021 VA: 0x1CA2F20
	private void DbgPLCAddLog() { }

	[ConditionalAttribute] // RVA: 0x2AE840 Offset: 0x2AE941 VA: 0x2AE840
	// RVA: 0x1CA2F30 Offset: 0x1CA3031 VA: 0x1CA2F30
	private void DbgPLCUnknownSeq() { }

	[ConditionalAttribute] // RVA: 0x2AE880 Offset: 0x2AE981 VA: 0x2AE880
	// RVA: 0x1CA2F40 Offset: 0x1CA3041 VA: 0x1CA2F40
	private void DbgPLCCheckLoopCount() { }
}

