// Namespace: App
public class AnimalMenuSequence : SingletonProcInst<AnimalMenuSequence> // TypeDefIndex: 10445
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28E0D0 Offset: 0x28E1D1 VA: 0x28E0D0
	private AnimalInsideMenu <Inside>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x28E0E0 Offset: 0x28E1E1 VA: 0x28E0E0
	private AnimalOutsideMenu <Outside>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x28E0F0 Offset: 0x28E1F1 VA: 0x28E0F0
	private AnimalInsideMenuContent <InsideContent>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x28E100 Offset: 0x28E201 VA: 0x28E100
	private AnimalOutsideMenuContent <OutsideContent>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x28E110 Offset: 0x28E211 VA: 0x28E110
	private bool <IsOutsideSwap>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x28E120 Offset: 0x28E221 VA: 0x28E120
	private bool <IsInsideSwap>k__BackingField; // 0x99
	[CompilerGeneratedAttribute] // RVA: 0x28E130 Offset: 0x28E231 VA: 0x28E130
	private bool <IsBlankSelect>k__BackingField; // 0x9A
	[CompilerGeneratedAttribute] // RVA: 0x28E140 Offset: 0x28E241 VA: 0x28E140
	private AnimalMenuSequence.From <FromMenu>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x28E150 Offset: 0x28E251 VA: 0x28E150
	private Vector3 <CursorPosition>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x28E160 Offset: 0x28E261 VA: 0x28E160
	private AnimalData <CurrentAnimal>k__BackingField; // 0xB0
	public string[] AnimalPID; // 0xB8
	private const string PrefabPath = "UI/Hub/Farm/Prefabs/AnimalSelectRoot";
	[CompilerGeneratedAttribute] // RVA: 0x28E170 Offset: 0x28E271 VA: 0x28E170
	private GameObject <Root>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x28E180 Offset: 0x28E281 VA: 0x28E180
	private GameObject <SelectRoot>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x28E190 Offset: 0x28E291 VA: 0x28E190
	private GameObject <HelpRoot>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x28E1A0 Offset: 0x28E2A1 VA: 0x28E1A0
	private GameObject <HelpMessage>k__BackingField; // 0xD8
	private ResourceHandle m_Handle; // 0xE0
	private Animator m_RootAnim; // 0xE8

	// Properties
	public AnimalInsideMenu Inside { get; set; }
	public AnimalOutsideMenu Outside { get; set; }
	public AnimalInsideMenuContent InsideContent { get; set; }
	public AnimalOutsideMenuContent OutsideContent { get; set; }
	public bool IsOutsideSwap { get; set; }
	public bool IsInsideSwap { get; set; }
	public bool IsBlankSelect { get; set; }
	public AnimalMenuSequence.From FromMenu { get; set; }
	public Vector3 CursorPosition { get; set; }
	public AnimalData CurrentAnimal { get; set; }
	private GameObject Root { get; set; }
	private GameObject SelectRoot { get; set; }
	private GameObject HelpRoot { get; set; }
	private GameObject HelpMessage { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BE1C0 Offset: 0x2BE2C1 VA: 0x2BE1C0
	// RVA: 0x20FA3F0 Offset: 0x20FA4F1 VA: 0x20FA3F0
	public AnimalInsideMenu get_Inside() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE1D0 Offset: 0x2BE2D1 VA: 0x2BE1D0
	// RVA: 0x20FA400 Offset: 0x20FA501 VA: 0x20FA400
	public void set_Inside(AnimalInsideMenu value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE1E0 Offset: 0x2BE2E1 VA: 0x2BE1E0
	// RVA: 0x20FA410 Offset: 0x20FA511 VA: 0x20FA410
	public AnimalOutsideMenu get_Outside() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE1F0 Offset: 0x2BE2F1 VA: 0x2BE1F0
	// RVA: 0x20FA420 Offset: 0x20FA521 VA: 0x20FA420
	public void set_Outside(AnimalOutsideMenu value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE200 Offset: 0x2BE301 VA: 0x2BE200
	// RVA: 0x20FA430 Offset: 0x20FA531 VA: 0x20FA430
	public AnimalInsideMenuContent get_InsideContent() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE210 Offset: 0x2BE311 VA: 0x2BE210
	// RVA: 0x20FA440 Offset: 0x20FA541 VA: 0x20FA440
	public void set_InsideContent(AnimalInsideMenuContent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE220 Offset: 0x2BE321 VA: 0x2BE220
	// RVA: 0x20FA450 Offset: 0x20FA551 VA: 0x20FA450
	public AnimalOutsideMenuContent get_OutsideContent() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE230 Offset: 0x2BE331 VA: 0x2BE230
	// RVA: 0x20FA460 Offset: 0x20FA561 VA: 0x20FA460
	public void set_OutsideContent(AnimalOutsideMenuContent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE240 Offset: 0x2BE341 VA: 0x2BE240
	// RVA: 0x20FA470 Offset: 0x20FA571 VA: 0x20FA470
	public bool get_IsOutsideSwap() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE250 Offset: 0x2BE351 VA: 0x2BE250
	// RVA: 0x20FA480 Offset: 0x20FA581 VA: 0x20FA480
	public void set_IsOutsideSwap(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE260 Offset: 0x2BE361 VA: 0x2BE260
	// RVA: 0x20FA490 Offset: 0x20FA591 VA: 0x20FA490
	public bool get_IsInsideSwap() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE270 Offset: 0x2BE371 VA: 0x2BE270
	// RVA: 0x20FA4A0 Offset: 0x20FA5A1 VA: 0x20FA4A0
	public void set_IsInsideSwap(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE280 Offset: 0x2BE381 VA: 0x2BE280
	// RVA: 0x20FA4B0 Offset: 0x20FA5B1 VA: 0x20FA4B0
	public bool get_IsBlankSelect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE290 Offset: 0x2BE391 VA: 0x2BE290
	// RVA: 0x20FA4C0 Offset: 0x20FA5C1 VA: 0x20FA4C0
	public void set_IsBlankSelect(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE2A0 Offset: 0x2BE3A1 VA: 0x2BE2A0
	// RVA: 0x20FA4D0 Offset: 0x20FA5D1 VA: 0x20FA4D0
	public AnimalMenuSequence.From get_FromMenu() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE2B0 Offset: 0x2BE3B1 VA: 0x2BE2B0
	// RVA: 0x20FA4E0 Offset: 0x20FA5E1 VA: 0x20FA4E0
	public void set_FromMenu(AnimalMenuSequence.From value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE2C0 Offset: 0x2BE3C1 VA: 0x2BE2C0
	// RVA: 0x20FA4F0 Offset: 0x20FA5F1 VA: 0x20FA4F0
	public Vector3 get_CursorPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE2D0 Offset: 0x2BE3D1 VA: 0x2BE2D0
	// RVA: 0x20FA500 Offset: 0x20FA601 VA: 0x20FA500
	public void set_CursorPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE2E0 Offset: 0x2BE3E1 VA: 0x2BE2E0
	// RVA: 0x20FA510 Offset: 0x20FA611 VA: 0x20FA510
	public AnimalData get_CurrentAnimal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE2F0 Offset: 0x2BE3F1 VA: 0x2BE2F0
	// RVA: 0x20FA520 Offset: 0x20FA621 VA: 0x20FA520
	public void set_CurrentAnimal(AnimalData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE300 Offset: 0x2BE401 VA: 0x2BE300
	// RVA: 0x20FA530 Offset: 0x20FA631 VA: 0x20FA530
	private GameObject get_Root() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE310 Offset: 0x2BE411 VA: 0x2BE310
	// RVA: 0x20FA540 Offset: 0x20FA641 VA: 0x20FA540
	private void set_Root(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE320 Offset: 0x2BE421 VA: 0x2BE320
	// RVA: 0x20FA550 Offset: 0x20FA651 VA: 0x20FA550
	private GameObject get_SelectRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE330 Offset: 0x2BE431 VA: 0x2BE330
	// RVA: 0x20FA560 Offset: 0x20FA661 VA: 0x20FA560
	private void set_SelectRoot(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE340 Offset: 0x2BE441 VA: 0x2BE340
	// RVA: 0x20FA570 Offset: 0x20FA671 VA: 0x20FA570
	private GameObject get_HelpRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE350 Offset: 0x2BE451 VA: 0x2BE350
	// RVA: 0x20FA580 Offset: 0x20FA681 VA: 0x20FA580
	private void set_HelpRoot(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE360 Offset: 0x2BE461 VA: 0x2BE360
	// RVA: 0x20FA590 Offset: 0x20FA691 VA: 0x20FA590
	private GameObject get_HelpMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE370 Offset: 0x2BE471 VA: 0x2BE370
	// RVA: 0x20FA5A0 Offset: 0x20FA6A1 VA: 0x20FA5A0
	private void set_HelpMessage(GameObject value) { }

	// RVA: 0x20F8BC0 Offset: 0x20F8CC1 VA: 0x20F8BC0
	public static void SetHelpText(string helpText) { }

	// RVA: 0x20FA5B0 Offset: 0x20FA6B1 VA: 0x20FA5B0
	public static void JumpInside(bool isOutsideSwap) { }

	// RVA: 0x20F85A0 Offset: 0x20F86A1 VA: 0x20F85A0
	public static void JumpOutside(bool isInsideSwap) { }

	// RVA: 0x20F86D0 Offset: 0x20F87D1 VA: 0x20F86D0
	public static void JumpLeft() { }

	// RVA: 0x20FAA00 Offset: 0x20FAB01 VA: 0x20FAA00
	public static void JumpRight() { }

	// RVA: 0x20F98A0 Offset: 0x20F99A1 VA: 0x20F98A0
	public static void JumpConfirm(AnimalMenuSequence.From from) { }

	// RVA: 0x20FAB40 Offset: 0x20FAC41 VA: 0x20FAB40
	public static void JumpApply() { }

	// RVA: 0x20F8E00 Offset: 0x20F8F01 VA: 0x20F8E00
	public static int GetAnimalCount(AnimalData animal) { }

	// RVA: 0x20F9180 Offset: 0x20F9281 VA: 0x20F9180
	public static void SetCurrentAnimal(AnimalData animal) { }

	// RVA: 0x20FAD00 Offset: 0x20FAE01 VA: 0x20FAD00
	public static void SetAnimal(AnimalData animal, int selectIndex) { }

	// RVA: 0x20FAEE0 Offset: 0x20FAFE1 VA: 0x20FAEE0
	public static void SwapAnimal(int selectIndex1, int selectIndex2) { }

	// RVA: 0x20F9210 Offset: 0x20F9311 VA: 0x20F9210
	public static bool IsPlaceEmpty() { }

	// RVA: 0x20F93C0 Offset: 0x20F94C1 VA: 0x20F93C0
	public static void PlaceAnimal(AnimalData animal) { }

	// RVA: 0x20FA820 Offset: 0x20FA921 VA: 0x20FA820
	public static int GetEmptyIndex() { }

	// RVA: 0x20FB0D0 Offset: 0x20FB1D1 VA: 0x20FB0D0
	public static bool IsExistsCurrentAnimal() { }

	// RVA: 0x20FB190 Offset: 0x20FB291 VA: 0x20FB190
	private void LoadPrefabAsync() { }

	// RVA: 0x20FB240 Offset: 0x20FB341 VA: 0x20FB240
	private bool IsLoadingPrefab() { }

	// RVA: 0x20FB270 Offset: 0x20FB371 VA: 0x20FB270
	private void UnloadPrefab() { }

	// RVA: 0x20FB2C0 Offset: 0x20FB3C1 VA: 0x20FB2C0
	private void Tutorial() { }

	// RVA: 0x20FB2D0 Offset: 0x20FB3D1 VA: 0x20FB2D0
	private void Create() { }

	// RVA: 0x20FB880 Offset: 0x20FB981 VA: 0x20FB880
	public void Close() { }

	// RVA: 0x20FB930 Offset: 0x20FBA31 VA: 0x20FB930
	public bool IsClosed() { }

	// RVA: 0x20FB9E0 Offset: 0x20FBAE1 VA: 0x20FB9E0
	private void Destroy() { }

	// RVA: 0x20FB600 Offset: 0x20FB701 VA: 0x20FB600
	private void LoadData() { }

	// RVA: 0x20FBBF0 Offset: 0x20FBCF1 VA: 0x20FBBF0
	private bool IsDirtyData() { }

	// RVA: 0x20FBD80 Offset: 0x20FBE81 VA: 0x20FBD80
	private void ApplyData() { }

	// RVA: 0x20FC040 Offset: 0x20FC141 VA: 0x20FC040
	private void Init() { }

	// RVA: 0x20FC3A0 Offset: 0x20FC4A1 VA: 0x20FC3A0
	private void Return() { }

	// RVA: 0x20FC460 Offset: 0x20FC561 VA: 0x20FC460
	private void Confirm() { }

	// RVA: 0x20FC4D0 Offset: 0x20FC5D1 VA: 0x20FC4D0
	private static void RemoveIndex(int index) { }

	// RVA: 0x20FC6A0 Offset: 0x20FC7A1 VA: 0x20FC6A0
	public static void RemoveCurrentAnimal(AnimalData animal) { }

	// RVA: 0x20FC7F0 Offset: 0x20FC8F1 VA: 0x20FC7F0
	private void InitInside() { }

	// RVA: 0x20FC890 Offset: 0x20FC991 VA: 0x20FC890
	private void InitOutside() { }

	// RVA: 0x20FCA40 Offset: 0x20FCB41 VA: 0x20FCA40
	private void InitDecide() { }

	// RVA: 0x20FCAF0 Offset: 0x20FCBF1 VA: 0x20FCAF0
	private void TickInside() { }

	// RVA: 0x20FCB50 Offset: 0x20FCC51 VA: 0x20FCB50
	private void TickOutside() { }

	// RVA: 0x20FCC10 Offset: 0x20FCD11 VA: 0x20FCC10
	public static ProcInst CreateBind(ProcInst super) { }

	// RVA: 0x20FD940 Offset: 0x20FDA41 VA: 0x20FD940
	public void .ctor() { }
}

