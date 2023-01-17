// Namespace: App
internal class AnimalSequence : SingletonProcInst<AnimalSequence> // TypeDefIndex: 10455
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28E220 Offset: 0x28E321 VA: 0x28E220
	private bool <IsDirtyFlag>k__BackingField; // 0x72
	private ValueTuple<string, string, string>[] PlaceData; // 0x78
	private string[] AnimalList; // 0x80
	private int AnimalLoadingCount; // 0x88

	// Properties
	public HubPlayerController Player { get; }
	public HubCamera Camera { get; }
	public bool IsDirtyFlag { get; set; }

	// Methods

	// RVA: 0x20FF680 Offset: 0x20FF781 VA: 0x20FF680
	public HubPlayerController get_Player() { }

	// RVA: 0x20FF700 Offset: 0x20FF801 VA: 0x20FF700
	public HubCamera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE460 Offset: 0x2BE561 VA: 0x2BE460
	// RVA: 0x20FF780 Offset: 0x20FF881 VA: 0x20FF780
	public bool get_IsDirtyFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE470 Offset: 0x2BE571 VA: 0x2BE470
	// RVA: 0x20FF790 Offset: 0x20FF891 VA: 0x20FF790
	public void set_IsDirtyFlag(bool value) { }

	// RVA: 0x20FF7A0 Offset: 0x20FF8A1 VA: 0x20FF7A0
	public bool IsDirty() { }

	// RVA: 0x20FF7B0 Offset: 0x20FF8B1 VA: 0x20FF7B0
	private void Init() { }

	// RVA: 0x20FF830 Offset: 0x20FF931 VA: 0x20FF830
	private void Exit() { }

	// RVA: 0x20FF8C0 Offset: 0x20FF9C1 VA: 0x20FF8C0
	private void CreateMenu() { }

	// RVA: 0x20FF8D0 Offset: 0x20FF9D1 VA: 0x20FF8D0
	private void Prepare() { }

	// RVA: 0x20FFC70 Offset: 0x20FFD71 VA: 0x20FFC70
	private void ClearLocator(GameObject locator) { }

	// RVA: 0x20FFFB0 Offset: 0x21000B1 VA: 0x20FFFB0
	private void SetupCharacterFadeLength(Character chara, float fadeDistance) { }

	// RVA: 0x2100070 Offset: 0x2100171 VA: 0x2100070
	private void SetupCharacterFadeRadius(Character chara, float radius) { }

	// RVA: 0x2100140 Offset: 0x2100241 VA: 0x2100140
	private void LoadCharacter(string pid, GameObject locator, HubAccess access, Action<HubUnitController> callback) { }

	// RVA: 0x2100330 Offset: 0x2100431 VA: 0x2100330
	private void Load() { }

	// RVA: 0x2100600 Offset: 0x2100701 VA: 0x2100600
	private void PostLoad() { }

	// RVA: 0x21006E0 Offset: 0x21007E1 VA: 0x21006E0
	public static ProcInst CreateBind(ProcInst super) { }

	// RVA: 0x2101370 Offset: 0x2101471 VA: 0x2101370
	private bool IsLoading() { }

	// RVA: 0x2100F50 Offset: 0x2101051 VA: 0x2100F50
	public void .ctor() { }
}

