// Namespace: 
private class TitleSequence.PedestalData : StructData<TitleSequence.PedestalData> // TypeDefIndex: 13145
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29BAA0 Offset: 0x29BBA1 VA: 0x29BAA0
	private string <PedestalName>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29BAB0 Offset: 0x29BBB1 VA: 0x29BAB0
	private string <Cid>k__BackingField; // 0x28

	// Properties
	public string PedestalName { get; set; }
	public string Cid { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB3F0 Offset: 0x2CB4F1 VA: 0x2CB3F0
	// RVA: 0x2394990 Offset: 0x2394A91 VA: 0x2394990
	public string get_PedestalName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB400 Offset: 0x2CB501 VA: 0x2CB400
	// RVA: 0x23949A0 Offset: 0x2394AA1 VA: 0x23949A0
	private void set_PedestalName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB410 Offset: 0x2CB511 VA: 0x2CB410
	// RVA: 0x23949B0 Offset: 0x2394AB1 VA: 0x23949B0
	public string get_Cid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB420 Offset: 0x2CB521 VA: 0x2CB420
	// RVA: 0x23949C0 Offset: 0x2394AC1 VA: 0x23949C0
	private void set_Cid(string value) { }

	// RVA: 0x23949D0 Offset: 0x2394AD1 VA: 0x23949D0
	public void .ctor() { }

	// RVA: 0x2394A50 Offset: 0x2394B51 VA: 0x2394A50
	public static void Load() { }
}

// Namespace: 
private enum TitleSequence.Label // TypeDefIndex: 13146
{
	// Fields
	public int value__; // 0x0
	public const TitleSequence.Label Start = 0;
	public const TitleSequence.Label End = 1;
}

// Namespace: 
private class TitleSequence.ProcTitleCall.TitleCallData : StructData<TitleSequence.ProcTitleCall.TitleCallData> // TypeDefIndex: 13147
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29BAC0 Offset: 0x29BBC1 VA: 0x29BAC0
	private string <PidOrGid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29BAD0 Offset: 0x29BBD1 VA: 0x29BAD0
	private string <Cid>k__BackingField; // 0x28

	// Properties
	public string PidOrGid { get; set; }
	public string Cid { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB430 Offset: 0x2CB531 VA: 0x2CB430
	// RVA: 0x21FD1A0 Offset: 0x21FD2A1 VA: 0x21FD1A0
	public string get_PidOrGid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB440 Offset: 0x2CB541 VA: 0x2CB440
	// RVA: 0x21FD1B0 Offset: 0x21FD2B1 VA: 0x21FD1B0
	private void set_PidOrGid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB450 Offset: 0x2CB551 VA: 0x2CB450
	// RVA: 0x21FD1C0 Offset: 0x21FD2C1 VA: 0x21FD1C0
	public string get_Cid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB460 Offset: 0x2CB561 VA: 0x2CB460
	// RVA: 0x21FD1D0 Offset: 0x21FD2D1 VA: 0x21FD1D0
	private void set_Cid(string value) { }

	// RVA: 0x21FD1E0 Offset: 0x21FD2E1 VA: 0x21FD1E0
	public void .ctor() { }

	// RVA: 0x21FD260 Offset: 0x21FD361 VA: 0x21FD260
	public static void Load() { }
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

