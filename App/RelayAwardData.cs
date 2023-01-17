// Namespace: App
public class RelayAwardData : StructData<RelayAwardData> // TypeDefIndex: 10025
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28CA90 Offset: 0x28CB91 VA: 0x28CA90
	private string <Raid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28CAA0 Offset: 0x28CBA1 VA: 0x28CAA0
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28CAB0 Offset: 0x28CBB1 VA: 0x28CAB0
	private string <ResultText>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28CAC0 Offset: 0x28CBC1 VA: 0x28CAC0
	private string[] <Awards>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28CAD0 Offset: 0x28CBD1 VA: 0x28CAD0
	private RelayAwardData.FlagField <Flag>k__BackingField; // 0x40
	private static RelayAwardData.Info[] s_Infos; // 0x0

	// Properties
	public string Raid { get; set; }
	public string Name { get; set; }
	public string ResultText { get; set; }
	public string[] Awards { get; set; }
	public RelayAwardData.FlagField Flag { get; set; }

	// Methods

	// RVA: 0x253CE70 Offset: 0x253CF71 VA: 0x253CE70
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB3D0 Offset: 0x2BB4D1 VA: 0x2BB3D0
	// RVA: 0x253CF20 Offset: 0x253D021 VA: 0x253CF20
	public string get_Raid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB3E0 Offset: 0x2BB4E1 VA: 0x2BB3E0
	// RVA: 0x253CF30 Offset: 0x253D031 VA: 0x253CF30
	private void set_Raid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB3F0 Offset: 0x2BB4F1 VA: 0x2BB3F0
	// RVA: 0x253CF40 Offset: 0x253D041 VA: 0x253CF40
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB400 Offset: 0x2BB501 VA: 0x2BB400
	// RVA: 0x253CF50 Offset: 0x253D051 VA: 0x253CF50
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB410 Offset: 0x2BB511 VA: 0x2BB410
	// RVA: 0x253CF60 Offset: 0x253D061 VA: 0x253CF60
	public string get_ResultText() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB420 Offset: 0x2BB521 VA: 0x2BB420
	// RVA: 0x253CF70 Offset: 0x253D071 VA: 0x253CF70
	private void set_ResultText(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB430 Offset: 0x2BB531 VA: 0x2BB430
	// RVA: 0x253CF80 Offset: 0x253D081 VA: 0x253CF80
	public string[] get_Awards() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB440 Offset: 0x2BB541 VA: 0x2BB440
	// RVA: 0x253CF90 Offset: 0x253D091 VA: 0x253CF90
	private void set_Awards(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB450 Offset: 0x2BB551 VA: 0x2BB450
	// RVA: 0x253CFA0 Offset: 0x253D0A1 VA: 0x253CFA0
	public RelayAwardData.FlagField get_Flag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB460 Offset: 0x2BB561 VA: 0x2BB460
	// RVA: 0x253CFB0 Offset: 0x253D0B1 VA: 0x253CFB0
	private void set_Flag(RelayAwardData.FlagField value) { }

	// RVA: 0x253CFC0 Offset: 0x253D0C1 VA: 0x253CFC0
	public string GetName() { }

	// RVA: 0x253B0C0 Offset: 0x253B1C1 VA: 0x253B0C0
	public static string GetRaid(RelayAwardData.Kinds kind) { }

	// RVA: 0x253AC50 Offset: 0x253AD51 VA: 0x253AC50
	public static UnitRecord.Kinds GetRecordKind(RelayAwardData.Kinds kind) { }

	// RVA: 0x253AFC0 Offset: 0x253B0C1 VA: 0x253AFC0
	public static RelayAwardData.CompareOp GetCompareOp(RelayAwardData.Kinds kind) { }

	// RVA: 0x253B040 Offset: 0x253B141 VA: 0x253B040
	public static bool Test(RelayAwardData.Kinds kind, RelayAwardData.Flags flag) { }

	// RVA: 0x253D030 Offset: 0x253D131 VA: 0x253D030
	public static RelayAwardData TryGet(RelayAwardData.Kinds kind) { }

	// RVA: 0x253D110 Offset: 0x253D211 VA: 0x253D110 Slot: 6
	public override void OnCompletedEnd() { }

	// RVA: 0x253D9F0 Offset: 0x253DAF1 VA: 0x253D9F0 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x253D120 Offset: 0x253D221 VA: 0x253D120
	private void MakeInfos() { }

	// RVA: 0x253DA00 Offset: 0x253DB01 VA: 0x253DA00
	public void .ctor() { }
}

