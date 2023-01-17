// Namespace: App
public class PhotographPauseData : StructDataArray<PhotographPauseData> // TypeDefIndex: 11490
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x298770 Offset: 0x298871 VA: 0x298770
	private string <PauseName>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x298780 Offset: 0x298881 VA: 0x298780
	private int <No>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x298790 Offset: 0x298891 VA: 0x298790
	private string <Mid>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x2987A0 Offset: 0x2988A1 VA: 0x2987A0
	private int <AnimeFrame>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x2987B0 Offset: 0x2988B1 VA: 0x2987B0
	private string <FaceAnime>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x2987C0 Offset: 0x2988C1 VA: 0x2987C0
	private string[] <CharaIdList>k__BackingField; // 0x50

	// Properties
	public string PauseName { get; set; }
	public int No { get; set; }
	public string Mid { get; set; }
	public int AnimeFrame { get; set; }
	public string FaceAnime { get; set; }
	public string[] CharaIdList { get; set; }
	public string Name { get; }
	public ItemData.Kinds WeaponKind { get; }

	// Methods

	// RVA: 0x2A33250 Offset: 0x2A33351 VA: 0x2A33250
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5A40 Offset: 0x2C5B41 VA: 0x2C5A40
	// RVA: 0x2A33300 Offset: 0x2A33401 VA: 0x2A33300
	public string get_PauseName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5A50 Offset: 0x2C5B51 VA: 0x2C5A50
	// RVA: 0x2A33310 Offset: 0x2A33411 VA: 0x2A33310
	private void set_PauseName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5A60 Offset: 0x2C5B61 VA: 0x2C5A60
	// RVA: 0x2A33320 Offset: 0x2A33421 VA: 0x2A33320
	public int get_No() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5A70 Offset: 0x2C5B71 VA: 0x2C5A70
	// RVA: 0x2A33330 Offset: 0x2A33431 VA: 0x2A33330
	private void set_No(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5A80 Offset: 0x2C5B81 VA: 0x2C5A80
	// RVA: 0x2A33340 Offset: 0x2A33441 VA: 0x2A33340
	public string get_Mid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5A90 Offset: 0x2C5B91 VA: 0x2C5A90
	// RVA: 0x2A33350 Offset: 0x2A33451 VA: 0x2A33350
	private void set_Mid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5AA0 Offset: 0x2C5BA1 VA: 0x2C5AA0
	// RVA: 0x2A33360 Offset: 0x2A33461 VA: 0x2A33360
	public int get_AnimeFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5AB0 Offset: 0x2C5BB1 VA: 0x2C5AB0
	// RVA: 0x2A33370 Offset: 0x2A33471 VA: 0x2A33370
	private void set_AnimeFrame(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5AC0 Offset: 0x2C5BC1 VA: 0x2C5AC0
	// RVA: 0x2A33380 Offset: 0x2A33481 VA: 0x2A33380
	public string get_FaceAnime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5AD0 Offset: 0x2C5BD1 VA: 0x2C5AD0
	// RVA: 0x2A33390 Offset: 0x2A33491 VA: 0x2A33390
	private void set_FaceAnime(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5AE0 Offset: 0x2C5BE1 VA: 0x2C5AE0
	// RVA: 0x2A333A0 Offset: 0x2A334A1 VA: 0x2A333A0
	public string[] get_CharaIdList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5AF0 Offset: 0x2C5BF1 VA: 0x2C5AF0
	// RVA: 0x2A333B0 Offset: 0x2A334B1 VA: 0x2A333B0
	private void set_CharaIdList(string[] value) { }

	// RVA: 0x2A321D0 Offset: 0x2A322D1 VA: 0x2A321D0
	public string get_Name() { }

	// RVA: 0x2A2C550 Offset: 0x2A2C651 VA: 0x2A2C550
	public ItemData.Kinds get_WeaponKind() { }

	// RVA: 0x2A2C6F0 Offset: 0x2A2C7F1 VA: 0x2A2C6F0
	public PhotographPauseData TryGetOverridePauseData(string charaId) { }

	// RVA: 0x2A333C0 Offset: 0x2A334C1 VA: 0x2A333C0
	public void .ctor() { }
}

