// Namespace: App
public class TalkSound // TypeDefIndex: 13392
{
	// Fields
	private string m_Mid; // 0x10
	private string m_SoundCmdExecBefore; // 0x18
	private string m_SoundCmdExecAfter; // 0x20
	private string m_ReservedTalkVoice; // 0x28
	private string m_ReservedPersonVoice; // 0x30
	private string m_ReservedPersonPid; // 0x38
	private string m_ReservedPersonSwitchName; // 0x40
	private string m_PersonVoice; // 0x48

	// Methods

	// RVA: 0x2C34A80 Offset: 0x2C34B81 VA: 0x2C34A80
	public string GetPersonVoice() { }

	// RVA: 0x2C31750 Offset: 0x2C31851 VA: 0x2C31750
	public void Init(string mid) { }

	// RVA: 0x2C31460 Offset: 0x2C31561 VA: 0x2C31460
	public bool TickBefore(ProcInst parentProc) { }

	// RVA: 0x2C31580 Offset: 0x2C31681 VA: 0x2C31580
	public bool TickAfter(ProcInst parentProc) { }

	// RVA: 0x2C31610 Offset: 0x2C31711 VA: 0x2C31610
	public void PostTalkStartSoundEvent() { }

	// RVA: 0x2C34920 Offset: 0x2C34A21 VA: 0x2C34920
	public void PostTalkEndSoundEvent() { }

	// RVA: 0x2C34E90 Offset: 0x2C34F91 VA: 0x2C34E90
	private string[] GetArgs(string line) { }

	// RVA: 0x2C34F20 Offset: 0x2C35021 VA: 0x2C34F20
	private TalkSound.SoundType GetSoundType(string[] args) { }

	// RVA: 0x2C34B50 Offset: 0x2C34C51 VA: 0x2C34B50
	private bool ExecLine(string line, ProcInst parentProc) { }

	// RVA: 0x2C34A90 Offset: 0x2C34B91 VA: 0x2C34A90
	private string GetLine(string str, out string line) { }

	// RVA: 0x2C329B0 Offset: 0x2C32AB1 VA: 0x2C329B0
	public void TryPlayReservedVoice(Character character) { }

	// RVA: 0x2C357A0 Offset: 0x2C358A1 VA: 0x2C357A0
	private bool TryPlayReservedTalkVoice(Character character) { }

	// RVA: 0x2C35860 Offset: 0x2C35961 VA: 0x2C35860
	private void TryPlayReservedPersonVoice(Character character) { }

	// RVA: 0x2C32930 Offset: 0x2C32A31 VA: 0x2C32930
	public void StopAllVoice() { }

	// RVA: 0x2C35AA0 Offset: 0x2C35BA1 VA: 0x2C35AA0
	public void OnDrawMonitor(DebugMonitor monitor) { }

	// RVA: 0x2C2BFA0 Offset: 0x2C2C0A1 VA: 0x2C2BFA0
	public static List<string> MessFileNameToSoundBankName(string messFileName) { }

	// RVA: 0x2C35AB0 Offset: 0x2C35BB1 VA: 0x2C35AB0
	public static string GetRelianceSoundBankName(int patchIndex = -1) { }

	// RVA: 0x2C2BB20 Offset: 0x2C2BC21 VA: 0x2C2BB20
	public static List<string> GetRelianceSoundBankNameAll() { }

	// RVA: 0x2C35B60 Offset: 0x2C35C61 VA: 0x2C35B60
	public static string GetGodRelianceSoundBankName(int patchIndex = -1) { }

	// RVA: 0x2C2BCA0 Offset: 0x2C2BDA1 VA: 0x2C2BCA0
	public static List<string> GetGodRelianceSoundBankNameAll() { }

	// RVA: 0x2C35C10 Offset: 0x2C35D11 VA: 0x2C35C10
	public static string GetHubCommonSoundBankName(int patchIndex = -1) { }

	// RVA: 0x2C2BE20 Offset: 0x2C2BF21 VA: 0x2C2BE20
	public static List<string> GetHubCommonSoundBankNameAll() { }

	// RVA: 0x2C29A10 Offset: 0x2C29B11 VA: 0x2C29A10
	public static string MidToSoundEvent(string mid) { }

	// RVA: 0x2C35CC0 Offset: 0x2C35DC1 VA: 0x2C35CC0
	private static int GetInt(string str) { }

	// RVA: 0x2C35D60 Offset: 0x2C35E61 VA: 0x2C35D60
	private static float GetFloat(string str) { }

	// RVA: 0x2C35E00 Offset: 0x2C35F01 VA: 0x2C35E00
	private static int GetFadeSpeedMsec(string str) { }

	// RVA: 0x2C36080 Offset: 0x2C36181 VA: 0x2C36080
	private static Force.Type GetForceType(string str) { }

	// RVA: 0x2C34FD0 Offset: 0x2C350D1 VA: 0x2C34FD0
	private bool TryExecAction(string[] args) { }

	// RVA: 0x2C31740 Offset: 0x2C31841 VA: 0x2C31740
	public void .ctor() { }
}

