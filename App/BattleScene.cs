// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x275D50 Offset: 0x275E51 VA: 0x275D50
public class BattleScene : Pool.Node // TypeDefIndex: 9520
{
	// Fields
	private BattleSceneList m_List; // 0x10
	private BattleSide.Type m_Side; // 0x18
	private BattleSide.Type m_Target; // 0x1C
	private BattleScene.Kind m_Kind; // 0x20
	private int m_Skill; // 0x24
	private int m_Item; // 0x28
	private int m_God; // 0x2C
	private int m_Index; // 0x30
	private BattleScene.FieldResult m_Result; // 0x38
	private BattleSide.Type m_Guardian; // 0x40
	private BattleSide.ShortArray m_Hps; // 0x48
	private BattleSide.SbyteArray m_Engages; // 0x50
	private BattleSide.ShortArray m_Damages; // 0x58

	// Properties
	private string DebuggerDisplay { get; }
	public BattleSide.Type Side { get; }
	public BattleSide.Type Target { get; }
	public BattleSide.Type Guardian { get; set; }
	public BattleSide.Type Current { get; }
	public BattleSide.Type Reverse { get; }

	// Methods

	// RVA: 0x225D7B0 Offset: 0x225D8B1 VA: 0x225D7B0
	private string get_DebuggerDisplay() { }

	// RVA: 0x225E120 Offset: 0x225E221 VA: 0x225E120
	public void .ctor() { }

	// RVA: 0x225E240 Offset: 0x225E341 VA: 0x225E240
	public void Clear() { }

	// RVA: 0x225E330 Offset: 0x225E431 VA: 0x225E330 Slot: 4
	public override void OnEnter() { }

	// RVA: 0x225E340 Offset: 0x225E441 VA: 0x225E340 Slot: 5
	public override void OnExit() { }

	// RVA: 0x225E350 Offset: 0x225E451 VA: 0x225E350
	public void Setup(BattleSceneList list, BattleScene.Kind kind, BattleSide.Type current, BattleSide.Type target, BattleInfo info, int index) { }

	// RVA: 0x225E4B0 Offset: 0x225E5B1 VA: 0x225E4B0
	public BattleScene.Kind GetKind() { }

	// RVA: 0x225E4C0 Offset: 0x225E5C1 VA: 0x225E4C0
	public int GetIndex() { }

	// RVA: 0x225E4D0 Offset: 0x225E5D1 VA: 0x225E4D0
	public BattleScene.FieldResult GetResult() { }

	// RVA: 0x225E4E0 Offset: 0x225E5E1 VA: 0x225E4E0
	public bool IsResult(BattleScene.Result result) { }

	// RVA: 0x225E550 Offset: 0x225E651 VA: 0x225E550
	public BattleScene SetResult(BattleScene.Result result) { }

	// RVA: 0x225E5C0 Offset: 0x225E6C1 VA: 0x225E5C0
	public BattleScene SetKind(BattleScene.Kind kind) { }

	// RVA: 0x225E5D0 Offset: 0x225E6D1 VA: 0x225E5D0
	public int GetDamage(BattleSide.Type side) { }

	// RVA: 0x225E730 Offset: 0x225E831 VA: 0x225E730
	public int GetHeal(BattleSide.Type side) { }

	// RVA: 0x225E8A0 Offset: 0x225E9A1 VA: 0x225E8A0
	public BattleScene SetDamage(BattleSide.Type side, int damage) { }

	// RVA: 0x225E920 Offset: 0x225EA21 VA: 0x225E920
	public int GetHp(BattleSide.Type side) { }

	// RVA: 0x225E990 Offset: 0x225EA91 VA: 0x225E990
	public void AddHp(BattleSide.Type side, int value) { }

	// RVA: 0x225EA30 Offset: 0x225EB31 VA: 0x225EA30
	public void Commit(BattleInfo info) { }

	// RVA: 0x225EBA0 Offset: 0x225ECA1 VA: 0x225EBA0
	public int GetEngageCount(BattleSide.Type side) { }

	// RVA: 0x225EC10 Offset: 0x225ED11 VA: 0x225EC10
	public int GetClampDamage(BattleSide.Type side) { }

	// RVA: 0x225ED10 Offset: 0x225EE11 VA: 0x225ED10
	public BattleScene SetSkill(int skill) { }

	// RVA: 0x225ED20 Offset: 0x225EE21 VA: 0x225ED20
	public BattleScene SetSkill(SkillData skill) { }

	// RVA: 0x225ED30 Offset: 0x225EE31 VA: 0x225ED30
	public BattleScene SetSkill(string sid) { }

	// RVA: 0x225EDD0 Offset: 0x225EED1 VA: 0x225EDD0
	public SkillData GetSkill() { }

	// RVA: 0x225EE60 Offset: 0x225EF61 VA: 0x225EE60
	public BattleScene SetItem(int item) { }

	// RVA: 0x225EE70 Offset: 0x225EF71 VA: 0x225EE70
	public BattleScene SetItem(ItemData item) { }

	// RVA: 0x225EE80 Offset: 0x225EF81 VA: 0x225EE80
	public BattleScene SetItem(string iid) { }

	// RVA: 0x225EF20 Offset: 0x225F021 VA: 0x225EF20
	public ItemData GetItem() { }

	// RVA: 0x225EFB0 Offset: 0x225F0B1 VA: 0x225EFB0
	public BattleScene SetGod(GodData god) { }

	// RVA: 0x225EFC0 Offset: 0x225F0C1 VA: 0x225EFC0
	public GodData GetGod() { }

	// RVA: 0x225F050 Offset: 0x225F151 VA: 0x225F050
	public SkillData GetShowSkill() { }

	// RVA: 0x225E070 Offset: 0x225E171 VA: 0x225E070
	private string GetSkillNameForDebuggerDisplay() { }

	// RVA: 0x225F110 Offset: 0x225F211 VA: 0x225F110
	public BattleSide.Type get_Side() { }

	// RVA: 0x225F120 Offset: 0x225F221 VA: 0x225F120
	public BattleSide.Type get_Target() { }

	// RVA: 0x225F130 Offset: 0x225F231 VA: 0x225F130
	public BattleSide.Type get_Guardian() { }

	// RVA: 0x225F140 Offset: 0x225F241 VA: 0x225F140
	public void set_Guardian(BattleSide.Type value) { }

	// RVA: 0x225F150 Offset: 0x225F251 VA: 0x225F150
	public BattleSide.Type get_Current() { }

	// RVA: 0x225F160 Offset: 0x225F261 VA: 0x225F160
	public BattleSide.Type get_Reverse() { }

	// RVA: 0x225F260 Offset: 0x225F361 VA: 0x225F260
	public bool IsEntry(BattleSide.Type side) { }
}

