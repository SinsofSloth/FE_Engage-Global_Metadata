// Namespace: App
public class RingCleaningVoiceData : StructDataArray<RingCleaningVoiceData> // TypeDefIndex: 10052
{
	// Fields
	private static readonly string[] EventNames; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x28CDD0 Offset: 0x28CED1 VA: 0x28CDD0
	private RingCleaningVoiceData.VoiceLabel <Label>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28CDE0 Offset: 0x28CEE1 VA: 0x28CDE0
	private RingCleaningVoiceData.Situation <PlaySituation>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x28CDF0 Offset: 0x28CEF1 VA: 0x28CDF0
	private bool <IsPlayCompleted>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28CE00 Offset: 0x28CF01 VA: 0x28CE00
	private string <UnitFaceAnim>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28CE10 Offset: 0x28CF11 VA: 0x28CE10
	private string <GodFaceAnim>k__BackingField; // 0x40

	// Properties
	public RingCleaningVoiceData.VoiceLabel Label { get; set; }
	public RingCleaningVoiceData.Situation PlaySituation { get; set; }
	public bool IsPlayCompleted { get; set; }
	public string UnitFaceAnim { get; set; }
	public string GodFaceAnim { get; set; }

	// Methods

	// RVA: 0x2683A80 Offset: 0x2683B81 VA: 0x2683A80
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA50 Offset: 0x2BBB51 VA: 0x2BBA50
	// RVA: 0x26844C0 Offset: 0x26845C1 VA: 0x26844C0
	public RingCleaningVoiceData.VoiceLabel get_Label() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA60 Offset: 0x2BBB61 VA: 0x2BBA60
	// RVA: 0x26844D0 Offset: 0x26845D1 VA: 0x26844D0
	private void set_Label(RingCleaningVoiceData.VoiceLabel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA70 Offset: 0x2BBB71 VA: 0x2BBA70
	// RVA: 0x26844E0 Offset: 0x26845E1 VA: 0x26844E0
	public RingCleaningVoiceData.Situation get_PlaySituation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA80 Offset: 0x2BBB81 VA: 0x2BBA80
	// RVA: 0x26844F0 Offset: 0x26845F1 VA: 0x26844F0
	private void set_PlaySituation(RingCleaningVoiceData.Situation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA90 Offset: 0x2BBB91 VA: 0x2BBA90
	// RVA: 0x2684500 Offset: 0x2684601 VA: 0x2684500
	public bool get_IsPlayCompleted() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBAA0 Offset: 0x2BBBA1 VA: 0x2BBAA0
	// RVA: 0x2684510 Offset: 0x2684611 VA: 0x2684510
	private void set_IsPlayCompleted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBAB0 Offset: 0x2BBBB1 VA: 0x2BBAB0
	// RVA: 0x2684520 Offset: 0x2684621 VA: 0x2684520
	public string get_UnitFaceAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBAC0 Offset: 0x2BBBC1 VA: 0x2BBAC0
	// RVA: 0x2684530 Offset: 0x2684631 VA: 0x2684530
	private void set_UnitFaceAnim(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBAD0 Offset: 0x2BBBD1 VA: 0x2BBAD0
	// RVA: 0x2684540 Offset: 0x2684641 VA: 0x2684540
	public string get_GodFaceAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBAE0 Offset: 0x2BBBE1 VA: 0x2BBAE0
	// RVA: 0x2684550 Offset: 0x2684651 VA: 0x2684550
	private void set_GodFaceAnim(string value) { }

	// RVA: 0x2684560 Offset: 0x2684661 VA: 0x2684560 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x26845F0 Offset: 0x26846F1 VA: 0x26845F0
	public string GetEventName() { }

	// RVA: 0x2683EF0 Offset: 0x2683FF1 VA: 0x2683EF0
	public static RingCleaningVoiceData GetRandomVoiceEvent(GodUnit god, RingCleaningVoiceData.Situation situation, bool isFinish) { }

	// RVA: 0x2684690 Offset: 0x2684791 VA: 0x2684690
	public void .ctor() { }

	// RVA: 0x2684710 Offset: 0x2684811 VA: 0x2684710
	private static void .cctor() { }
}

