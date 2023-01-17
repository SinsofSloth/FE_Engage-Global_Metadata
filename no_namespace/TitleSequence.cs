// Namespace: 
private enum TitleSequence.Label // TypeDefIndex: 13146
{
	// Fields
	public int value__; // 0x0
	public const TitleSequence.Label Start = 0;
	public const TitleSequence.Label End = 1;
}

// Namespace: 
public class TitleSequence.ProcTitleCall : SingletonProcInst<TitleSequence.ProcTitleCall> // TypeDefIndex: 13148
{
	// Fields
	private string m_PidOrGid; // 0x78
	private bool m_IsHeroFemale; // 0x80

	// Methods

	// RVA: 0x2394B00 Offset: 0x2394C01 VA: 0x2394B00
	private void .ctor() { }

	// RVA: 0x2394B80 Offset: 0x2394C81 VA: 0x2394B80 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2395090 Offset: 0x2395191 VA: 0x2395090 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2394CC0 Offset: 0x2394DC1 VA: 0x2394CC0
	private string CalcPidOrGid() { }

	// RVA: 0x23950A0 Offset: 0x23951A1 VA: 0x23950A0
	private void PlayTitleVoice() { }

	// RVA: 0x23952E0 Offset: 0x23953E1 VA: 0x23952E0
	private void PlaySubtitleVoice() { }

	// RVA: 0x2395100 Offset: 0x2395201 VA: 0x2395100
	private void PlayVoiceCommon(string soundEventName, bool isHeroFemale) { }

	// RVA: 0x2395340 Offset: 0x2395441 VA: 0x2395340
	private void WaitUntilVoiceEnd() { }

	// RVA: 0x23953F0 Offset: 0x23954F1 VA: 0x23953F0
	private ProcDesc[] GetDesc() { }

	// RVA: 0x2395690 Offset: 0x2395791 VA: 0x2395690
	public static void Create(ProcInst super) { }
}

