// Namespace: App
public class BattleSceneList : Pool.List<BattleScene> // TypeDefIndex: 9521
{
	// Fields
	public const int MaxScene = 512;
	public const int MaxTimes = 4;
	private BattleInfo m_Info; // 0x20
	private int m_Index; // 0x28

	// Methods

	// RVA: 0x225F4A0 Offset: 0x225F5A1 VA: 0x225F4A0
	public void .ctor(BattleInfo info) { }

	// RVA: 0x225F520 Offset: 0x225F621 VA: 0x225F520
	public bool IsEntry(BattleSide.Type side) { }

	// RVA: 0x225F620 Offset: 0x225F721 VA: 0x225F620
	public int GetCount(BattleScene.Kind kind) { }

	// RVA: 0x225F720 Offset: 0x225F821 VA: 0x225F720
	public BattleScene FindNext(BattleScene.Kind kind, int index = 0) { }

	// RVA: 0x225F840 Offset: 0x225F941 VA: 0x225F840
	public BattleScene FindPrev(BattleScene.Kind kind, int index = 0) { }

	// RVA: 0x225F900 Offset: 0x225FA01 VA: 0x225F900
	public int GetCount(BattleSide.Type side, BattleScene.Kind kind) { }

	// RVA: 0x225FA20 Offset: 0x225FB21 VA: 0x225FA20
	public bool HasGiveSkill(BattleSide.Type side, SkillData give) { }

	// RVA: 0x225FBD0 Offset: 0x225FCD1 VA: 0x225FBD0
	public bool HasChain() { }

	// RVA: 0x225FCF0 Offset: 0x225FDF1 VA: 0x225FCF0
	public int GetAttackCount(BattleSide.Type current, BattleScene.Result result = 1) { }

	// RVA: 0x225FE40 Offset: 0x225FF41 VA: 0x225FE40
	public int GetGiveSkillkCount(BattleSide.Type current, SkillData skill) { }

	// RVA: 0x225FFE0 Offset: 0x22600E1 VA: 0x225FFE0
	private static bool CanSkillCount(BattleScene scene, BattleSide.Type target, bool reversed) { }

	// RVA: 0x2260120 Offset: 0x2260221 VA: 0x2260120
	public int GetActiveSkillkCount(BattleSide.Type current) { }

	// RVA: 0x2260220 Offset: 0x2260321 VA: 0x2260220
	public int GetReciveActiveSkillkCount(BattleSide.Type reverse) { }

	// RVA: 0x2260320 Offset: 0x2260421 VA: 0x2260320
	public int GetReciveAttackCount(BattleSide.Type reverse, BattleScene.Result result = 1) { }

	// RVA: 0x2260470 Offset: 0x2260571 VA: 0x2260470
	public BattleScene Create(BattleScene.Kind kind) { }

	// RVA: 0x22604E0 Offset: 0x22605E1 VA: 0x22604E0
	public BattleScene Create(BattleScene.Kind kind, BattleInfoSide current) { }

	// RVA: 0x2260550 Offset: 0x2260651 VA: 0x2260550
	public BattleScene Create(BattleScene.Kind kind, BattleInfoSide current, BattleInfoSide target) { }

	// RVA: 0x22605D0 Offset: 0x22606D1 VA: 0x22605D0
	public BattleScene Create(BattleScene.Kind kind, BattleSide.Type current) { }

	// RVA: 0x2260640 Offset: 0x2260741 VA: 0x2260640
	public BattleScene Create(BattleScene.Kind kind, BattleSide.Type current, BattleSide.Type target) { }

	// RVA: 0x22606C0 Offset: 0x22607C1 VA: 0x22606C0 Slot: 6
	public override void Clear() { }
}

