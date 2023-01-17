// Namespace: App
public class HubAccessManager // TypeDefIndex: 10650
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x293200 Offset: 0x293301 VA: 0x293200
	private string <SceneName>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x293210 Offset: 0x293311 VA: 0x293210
	private List<HubAccessData> <AccessList>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x293220 Offset: 0x293321 VA: 0x293220
	private List<HubDisposData> <DisposList>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x293230 Offset: 0x293331 VA: 0x293230
	private List<HubDisposData> <DisposItemList>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x293240 Offset: 0x293341 VA: 0x293240
	private List<ValueTuple<string, int>> <TalkLimit>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x293250 Offset: 0x293351 VA: 0x293250
	private List<AnimalData> <AnimalDataList>k__BackingField; // 0x38

	// Properties
	public string SceneName { get; set; }
	public List<HubAccessData> AccessList { get; set; }
	private List<HubDisposData> DisposList { get; set; }
	private List<HubDisposData> DisposItemList { get; set; }
	private List<ValueTuple<string, int>> TalkLimit { get; set; }
	private List<AnimalData> AnimalDataList { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C02E0 Offset: 0x2C03E1 VA: 0x2C02E0
	// RVA: 0x266FC20 Offset: 0x266FD21 VA: 0x266FC20
	public string get_SceneName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C02F0 Offset: 0x2C03F1 VA: 0x2C02F0
	// RVA: 0x266FC30 Offset: 0x266FD31 VA: 0x266FC30
	public void set_SceneName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0300 Offset: 0x2C0401 VA: 0x2C0300
	// RVA: 0x266FC40 Offset: 0x266FD41 VA: 0x266FC40
	public List<HubAccessData> get_AccessList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0310 Offset: 0x2C0411 VA: 0x2C0310
	// RVA: 0x266FC50 Offset: 0x266FD51 VA: 0x266FC50
	public void set_AccessList(List<HubAccessData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0320 Offset: 0x2C0421 VA: 0x2C0320
	// RVA: 0x266FC60 Offset: 0x266FD61 VA: 0x266FC60
	private List<HubDisposData> get_DisposList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0330 Offset: 0x2C0431 VA: 0x2C0330
	// RVA: 0x266FC70 Offset: 0x266FD71 VA: 0x266FC70
	private void set_DisposList(List<HubDisposData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0340 Offset: 0x2C0441 VA: 0x2C0340
	// RVA: 0x266FC80 Offset: 0x266FD81 VA: 0x266FC80
	private List<HubDisposData> get_DisposItemList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0350 Offset: 0x2C0451 VA: 0x2C0350
	// RVA: 0x266FC90 Offset: 0x266FD91 VA: 0x266FC90
	private void set_DisposItemList(List<HubDisposData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0360 Offset: 0x2C0461 VA: 0x2C0360
	// RVA: 0x266FCA0 Offset: 0x266FDA1 VA: 0x266FCA0
	private List<ValueTuple<string, int>> get_TalkLimit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0370 Offset: 0x2C0471 VA: 0x2C0370
	// RVA: 0x266FCB0 Offset: 0x266FDB1 VA: 0x266FCB0
	private void set_TalkLimit(List<ValueTuple<string, int>> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0380 Offset: 0x2C0481 VA: 0x2C0380
	// RVA: 0x266FCC0 Offset: 0x266FDC1 VA: 0x266FCC0
	private List<AnimalData> get_AnimalDataList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0390 Offset: 0x2C0491 VA: 0x2C0390
	// RVA: 0x266FCD0 Offset: 0x266FDD1 VA: 0x266FCD0
	private void set_AnimalDataList(List<AnimalData> value) { }

	// RVA: 0x266FCE0 Offset: 0x266FDE1 VA: 0x266FCE0
	private static bool IsItemType(HubDisposData dispos) { }

	// RVA: 0x266FD10 Offset: 0x266FE11 VA: 0x266FD10
	public void Setup(string sceneName, HubUtil.TimezoneType timezoneType) { }

	// RVA: 0x2670BB0 Offset: 0x2670CB1 VA: 0x2670BB0
	public void ConfirmContent() { }

	// RVA: 0x2670640 Offset: 0x2670741 VA: 0x2670640
	public void Reset() { }

	// RVA: 0x26711A0 Offset: 0x26712A1 VA: 0x26711A0
	public void Refresh() { }

	// RVA: 0x2670960 Offset: 0x2670A61 VA: 0x2670960
	public bool IsUsedLocator(string locatorName) { }

	// RVA: 0x2670A10 Offset: 0x2670B11 VA: 0x2670A10
	private bool TrySetAccessObject(HubDisposData data, Random random) { }

	// RVA: 0x2670B10 Offset: 0x2670C11 VA: 0x2670B10
	public bool TryRemoveAccessObject(HubDisposData data) { }

	// RVA: 0x2671DF0 Offset: 0x2671EF1 VA: 0x2671DF0
	public HubAccessData AddNewLocator(string locator) { }

	// RVA: 0x2671F60 Offset: 0x2672061 VA: 0x2671F60
	public void ClearLocator(string locator) { }

	// RVA: 0x266A170 Offset: 0x266A271 VA: 0x266A170
	public HubAccessData FindLocator(string locator) { }

	// RVA: 0x2671FE0 Offset: 0x26720E1 VA: 0x2671FE0
	public HubAccessData FindPID(string pid) { }

	// RVA: 0x2672160 Offset: 0x2672261 VA: 0x2672160
	public bool IsAlreadyLocated(string pid) { }

	// RVA: 0x2672180 Offset: 0x2672281 VA: 0x2672180
	public bool IsAvailablePID(string pid, bool disabledTalk) { }

	// RVA: 0x2672630 Offset: 0x2672731 VA: 0x2672630
	private string GetSelectedGodWithSpecial(GodUnit godUnit) { }

	// RVA: 0x26726D0 Offset: 0x26727D1 VA: 0x26726D0
	private string GetPlayerGod() { }

	// RVA: 0x26712C0 Offset: 0x26713C1 VA: 0x26712C0
	private string GetChooseID(HubDisposData data, out int count, Random random) { }

	// RVA: 0x2672840 Offset: 0x2672941 VA: 0x2672840
	private string GetChooseAnimalID(HubDisposData data, Random random) { }

	// RVA: 0x2673140 Offset: 0x2673241 VA: 0x2673140
	private string GetChooseAnimalItem(HubDisposData data) { }

	// RVA: 0x266F0E0 Offset: 0x266F1E1 VA: 0x266F0E0
	public bool EntryTalkLimit(string talkType) { }

	// RVA: 0x2673510 Offset: 0x2673611 VA: 0x2673510
	public int GetNotTakedPieceOfBond() { }

	// RVA: 0x2673670 Offset: 0x2673771 VA: 0x2673670
	public void Dump() { }

	// RVA: 0x26706A0 Offset: 0x26707A1 VA: 0x26706A0
	private List<HubDisposData> CopyDisposList(string sceneName) { }

	// RVA: 0x2670820 Offset: 0x2670921 VA: 0x2670820
	private List<AnimalData> CopyAnimalList() { }

	// RVA: 0x2670EC0 Offset: 0x2670FC1 VA: 0x2670EC0
	private void ConfirmMaterial() { }

	// RVA: 0x2673700 Offset: 0x2673801 VA: 0x2673700
	public void .ctor() { }
}

