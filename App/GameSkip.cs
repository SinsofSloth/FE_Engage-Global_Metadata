// Namespace: App
public class GameSkip : SingletonClass<GameSkip> // TypeDefIndex: 13607
{
	// Fields
	private GameSkip.Sequence m_Sequence; // 0x1C
	private GameSkip.Status m_Status; // 0x20
	private Stack<GameSkip.Status> m_Statck; // 0x28

	// Methods

	// RVA: 0x26AF950 Offset: 0x26AFA51 VA: 0x26AF950
	public void .ctor() { }

	// RVA: 0x26AFA30 Offset: 0x26AFB31 VA: 0x26AFA30
	private GameSkip.Result CalcSkipInput() { }

	// RVA: 0x26AFB90 Offset: 0x26AFC91 VA: 0x26AFB90
	private bool TstStatus(GameSkip.Status status) { }

	// RVA: 0x26AFBA0 Offset: 0x26AFCA1 VA: 0x26AFBA0
	private void SetStatus(GameSkip.Status status) { }

	// RVA: 0x26AFBB0 Offset: 0x26AFCB1 VA: 0x26AFBB0
	private void ClearStatus(GameSkip.Status status) { }

	// RVA: 0x26AFBC0 Offset: 0x26AFCC1 VA: 0x26AFBC0 Slot: 7
	protected override void OnTick() { }

	// RVA: 0x26AFDF0 Offset: 0x26AFEF1 VA: 0x26AFDF0
	public static bool DebugSkip() { }

	// RVA: 0x26AFE00 Offset: 0x26AFF01 VA: 0x26AFE00
	public static void Trigger() { }

	// RVA: 0x26AFEB0 Offset: 0x26AFFB1 VA: 0x26AFEB0
	public static void Escape() { }

	// RVA: 0x26B0060 Offset: 0x26B0161 VA: 0x26B0060
	public static void Enable() { }

	// RVA: 0x26A7910 Offset: 0x26A7A11 VA: 0x26A7910
	public static void Disable() { }

	// RVA: 0x26B0110 Offset: 0x26B0211 VA: 0x26B0110
	public static void EnableShortSkip() { }

	// RVA: 0x26B01C0 Offset: 0x26B02C1 VA: 0x26B01C0
	public static void DisableShortSkip() { }

	// RVA: 0x26AFF60 Offset: 0x26B0061 VA: 0x26AFF60
	public static bool IsSkip() { }

	// RVA: 0x26B0270 Offset: 0x26B0371 VA: 0x26B0270
	public static bool IsDisable() { }

	// RVA: 0x26B0330 Offset: 0x26B0431 VA: 0x26B0330
	public static bool IsWait() { }

	// RVA: 0x26B0400 Offset: 0x26B0501 VA: 0x26B0400
	public static bool IsBlackOut() { }

	// RVA: 0x26B0500 Offset: 0x26B0601 VA: 0x26B0500
	public static bool IsBlackOrFadeOut() { }

	// RVA: 0x26B0590 Offset: 0x26B0691 VA: 0x26B0590
	public static bool IsFadeIn() { }

	// RVA: 0x26A7820 Offset: 0x26A7921 VA: 0x26A7820
	public static void PushState() { }

	// RVA: 0x26A7AD0 Offset: 0x26A7BD1 VA: 0x26A7AD0
	public static void PopState() { }

	// RVA: 0x26B0660 Offset: 0x26B0761 VA: 0x26B0660
	public static void PushDisableAISkip() { }

	// RVA: 0x26B0730 Offset: 0x26B0831 VA: 0x26B0730
	public static void PopDisableAISkip() { }

	// RVA: 0x26B07E0 Offset: 0x26B08E1 VA: 0x26B07E0
	public static void TriggerAI() { }

	// RVA: 0x26B08C0 Offset: 0x26B09C1 VA: 0x26B08C0
	private static void WaitTime(ProcInst super, float time) { }

	// RVA: 0x26B0950 Offset: 0x26B0A51 VA: 0x26B0950
	public static ProcDesc PWaitTime(float time) { }

	// RVA: 0x26B0A40 Offset: 0x26B0B41 VA: 0x26B0A40
	public static ProcInst SuspendBind(ProcInst super) { }
}

