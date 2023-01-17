// Namespace: App
public class SortieTopMenu : MiniMapBasicMenu // TypeDefIndex: 13284
{
	// Fields
	private const string TUTID_SORTIE = "TUTID_進撃準備";
	private const string TUTID_GOD = "TUTID_紋章士リュール";
	private const string TUTID_GOD2 = "TUTID_紋章士リュールの絆レベル";
	private const string TUTID_ENTRY_PANEL = "TUTID_エントリーパネル";
	public const string ENGAGE_PLUS_ATTENTION_NETWORK = "G_通信ではエンゲージ＋不可メッセージ";

	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x216F2C0 Offset: 0x216F3C1 VA: 0x216F2C0 Slot: 64
	protected override string get_FlagID() { }

	// RVA: 0x216F310 Offset: 0x216F411 VA: 0x216F310
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x216F970 Offset: 0x216FA71 VA: 0x216F970 Slot: 65
	public virtual ProcDesc[] CreateDesc() { }

	// RVA: 0x216F940 Offset: 0x216FA41 VA: 0x216F940
	private void .ctor(List<BasicMenuItem> menuItemList, SortieTopMenuContent sortieTopMenuContent) { }

	// RVA: 0x2170D10 Offset: 0x2170E11 VA: 0x2170D10 Slot: 30
	public override string GetName() { }

	// RVA: 0x2170D60 Offset: 0x2170E61 VA: 0x2170D60 Slot: 63
	protected override string GetTutorial() { }

	// RVA: 0x2170EC0 Offset: 0x2170FC1 VA: 0x2170EC0
	public void CheckEngagePlus() { }

	// RVA: 0x21710D0 Offset: 0x21711D1 VA: 0x21710D0
	public void HelpOn() { }
}

