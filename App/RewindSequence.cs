// Namespace: App
public class RewindSequence : SingletonProcInst<RewindSequence> // TypeDefIndex: 13107
{
	// Fields
	private const string EffectForStartPath = "Effects/Field/Common/Return/Prefabs/Eff_Return_00";
	private const float EffectForStart_Sec = 0.5;
	private const float EffectUnitForStart_Sec = 0.5;
	private const float EffectForExecuteRewind_Sec = 0.5;
	private const float EffectForCancelRewind_Sec = 0.25;
	private bool m_IsRewindToPhaseBegin; // 0x72
	private float m_WaitTime; // 0x74
	private GameObject m_EffectForStartObject; // 0x78
	private int m_CursorInitX; // 0x80
	private int m_CursorInitZ; // 0x84

	// Methods

	// RVA: 0x2675810 Offset: 0x2675911 VA: 0x2675810
	private void .ctor() { }

	// RVA: 0x2675B40 Offset: 0x2675C41 VA: 0x2675B40 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2675B50 Offset: 0x2675C51 VA: 0x2675B50 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2675BC0 Offset: 0x2675CC1 VA: 0x2675BC0
	private void LoadResource() { }

	// RVA: 0x2675C60 Offset: 0x2675D61 VA: 0x2675C60
	private void UnloadResource() { }

	// RVA: 0x2675D70 Offset: 0x2675E71 VA: 0x2675D70
	private bool IsLoadingResource() { }

	// RVA: 0x2675E00 Offset: 0x2675F01 VA: 0x2675E00
	private void InitEffectForStart() { }

	// RVA: 0x2676160 Offset: 0x2676261 VA: 0x2676160
	private void WaitEffectForStart() { }

	// RVA: 0x26762E0 Offset: 0x26763E1 VA: 0x26762E0
	private void Start() { }

	// RVA: 0x26762F0 Offset: 0x26763F1 VA: 0x26762F0
	private void CreateMenu() { }

	// RVA: 0x2676390 Offset: 0x2676491 VA: 0x2676390
	private void InitEffectForExecuteRewind() { }

	// RVA: 0x2676420 Offset: 0x2676521 VA: 0x2676420
	private void WaitEffectForExecuteRewind() { }

	// RVA: 0x2676530 Offset: 0x2676631 VA: 0x2676530
	private void ExecuteRewind() { }

	// RVA: 0x26768F0 Offset: 0x26769F1 VA: 0x26768F0
	private void InitEffectForCancelRewind() { }

	// RVA: 0x2676980 Offset: 0x2676A81 VA: 0x2676980
	private void WaitEffectForCancelRewind() { }

	// RVA: 0x2676AA0 Offset: 0x2676BA1 VA: 0x2676AA0
	private void ReturnMapCursor() { }

	// RVA: 0x2676BA0 Offset: 0x2676CA1 VA: 0x2676BA0
	private void CancelRewind() { }

	// RVA: 0x2676C10 Offset: 0x2676D11 VA: 0x2676C10
	private ProcDesc[] GetDesc() { }

	// RVA: 0x26775F0 Offset: 0x26776F1 VA: 0x26775F0
	public void SetRewindToPhaseBegin(bool isRewindToPhaseBegin) { }

	// RVA: 0x2677600 Offset: 0x2677701 VA: 0x2677600
	public void JumpToExecuteRewind() { }

	// RVA: 0x26776C0 Offset: 0x26777C1 VA: 0x26776C0
	public void JumpToCancelRewind() { }

	// RVA: 0x2677780 Offset: 0x2677881 VA: 0x2677780
	public static void CreateBind(ProcInst super) { }
}

