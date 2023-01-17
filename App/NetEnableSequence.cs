// Namespace: App
internal class NetEnableSequence : ProcInst // TypeDefIndex: 12716
{
	// Fields
	private bool m_WithoutConfirm; // 0x70
	private bool m_CanWriteConfig; // 0x71
	private bool m_IsNetLoginOnce; // 0x72
	private bool m_IsReflectNetResult; // 0x73
	private NetEnableSequence.ResultFunction m_ResultFunc; // 0x78
	private bool m_IsLoginSucceeded; // 0x80

	// Methods

	// RVA: 0x2352420 Offset: 0x2352521 VA: 0x2352420
	private void .ctor(ref NetEnableSequence.Arg arg) { }

	// RVA: 0x2352480 Offset: 0x2352581 VA: 0x2352480
	private void Confirm() { }

	// RVA: 0x2352520 Offset: 0x2352621 VA: 0x2352520
	private void Login() { }

	// RVA: 0x2353330 Offset: 0x2353431 VA: 0x2353330
	private void Postlogin() { }

	// RVA: 0x2353440 Offset: 0x2353541 VA: 0x2353440
	private void WaitMessageOpen() { }

	// RVA: 0x23534C0 Offset: 0x23535C1 VA: 0x23534C0
	private void WaitMessageClose() { }

	// RVA: 0x23534E0 Offset: 0x23535E1 VA: 0x23534E0
	private void Result() { }

	// RVA: 0x2353680 Offset: 0x2353781 VA: 0x2353680
	private void TryWriteConfig(bool isEnable, bool withUserData = False) { }

	// RVA: 0x2353780 Offset: 0x2353881 VA: 0x2353780
	public static void CreateBindNewPlay(ProcInst super, bool isNetLoginOnce, NetEnableSequence.ResultFunction resultFunc) { }

	// RVA: 0x2353D50 Offset: 0x2353E51 VA: 0x2353D50
	public static void CreateBindConfig(ProcInst super, NetEnableSequence.ResultFunction resultFunc) { }

	// RVA: 0x2353E80 Offset: 0x2353F81 VA: 0x2353E80
	public static void CreateBindRanking(ProcInst super, NetEnableSequence.ResultFunction resultFunc) { }

	// RVA: 0x2353FC0 Offset: 0x23540C1 VA: 0x2353FC0
	public static void CreateBindCapeTower(ProcInst super) { }

	// RVA: 0x2353860 Offset: 0x2353961 VA: 0x2353860
	private static void CreateBindImpl(ProcInst super, NetEnableSequence p) { }
}

