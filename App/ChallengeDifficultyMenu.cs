// Namespace: App
public class ChallengeDifficultyMenu : BasicMenu // TypeDefIndex: 9773
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2876A0 Offset: 0x2877A1 VA: 0x2876A0
	private int <Difficulty>k__BackingField; // 0xC4
	private ChallengeDifficultyMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xC8
	private ChallengeMapSelectRoot m_Root; // 0xD0
	private TextMeshProUGUI m_TextDifficulty; // 0xD8

	// Properties
	public int Difficulty { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B0D30 Offset: 0x2B0E31 VA: 0x2B0D30
	// RVA: 0x29AE7C0 Offset: 0x29AE8C1 VA: 0x29AE7C0
	public int get_Difficulty() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0D40 Offset: 0x2B0E41 VA: 0x2B0D40
	// RVA: 0x29AE7D0 Offset: 0x29AE8D1 VA: 0x29AE7D0
	private void set_Difficulty(int value) { }

	// RVA: 0x29AE3D0 Offset: 0x29AE4D1 VA: 0x29AE3D0
	public static ChallengeDifficultyMenu CreateBind(ProcInst super, ChallengeMapSelectRoot root, BasicMenuContent menuContent, ChallengeDifficultyMenu.DecideEventHandler decideEventHandler, ChallengeDifficultyMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x29AE820 Offset: 0x29AE921 VA: 0x29AE820
	private void .ctor(ChallengeMapSelectRoot root, List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, ChallengeDifficultyMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x29AFA90 Offset: 0x29AFB91 VA: 0x29AFA90 Slot: 30
	public override string GetName() { }

	// RVA: 0x29AFAE0 Offset: 0x29AFBE1 VA: 0x29AFAE0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x29AFD50 Offset: 0x29AFE51 VA: 0x29AFD50 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x29AFFC0 Offset: 0x29B00C1 VA: 0x29AFFC0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x29AFFF0 Offset: 0x29B00F1 VA: 0x29AFFF0 Slot: 10
	protected override void OnDispose() { }
}

