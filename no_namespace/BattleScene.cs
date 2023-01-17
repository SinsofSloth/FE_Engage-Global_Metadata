// Namespace: 
public enum BattleScene.Kind // TypeDefIndex: 9517
{
	// Fields
	public int value__; // 0x0
	public const BattleScene.Kind None = 0;
	public const BattleScene.Kind Attack = 1;
	public const BattleScene.Kind Rod = 2;
	public const BattleScene.Kind Dance = 3;
	public const BattleScene.Kind Skill = 4;
	public const BattleScene.Kind GiveDirect = 5;
	public const BattleScene.Kind GiveDelay = 6;
	public const BattleScene.Kind Strip = 7;
	public const BattleScene.Kind Equip = 8;
	public const BattleScene.Kind God = 9;
	public const BattleScene.Kind Dead = 10;
	public const BattleScene.Kind EngageAttack = 11;
	public const BattleScene.Kind Separator = 12;
	public const BattleScene.Kind PushBattle = 13;
	public const BattleScene.Kind PushOrder = 14;
	public const BattleScene.Kind PushAction = 15;
	public const BattleScene.Kind PushAttack = 16;
	public const BattleScene.Kind PopAttack = 17;
	public const BattleScene.Kind PopAction = 18;
	public const BattleScene.Kind PopOrder = 19;
	public const BattleScene.Kind PopBattle = 20;
	public const BattleScene.Kind Heal = 21;
	public const BattleScene.Kind Num = 22;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x275D90 Offset: 0x275E91 VA: 0x275D90
public enum BattleScene.Result // TypeDefIndex: 9518
{
	// Fields
	public int value__; // 0x0
	public const BattleScene.Result None = 0;
	public const BattleScene.Result Hit = 1;
	public const BattleScene.Result Critical = 2;
	public const BattleScene.Result Guard = 4;
	public const BattleScene.Result Suicide = 8;
	public const BattleScene.Result Efficacy = 16;
	public const BattleScene.Result Break = 32;
	public const BattleScene.Result Blow = 64;
	public const BattleScene.Result Bounce = 128;
	public const BattleScene.Result ChainAttack = 256;
	public const BattleScene.Result ChainGuard = 512;
	public const BattleScene.Result DualGuard = 1024;
	public const BattleScene.Result EngageAttack = 2048;
	public const BattleScene.Result Physical = 4096;
	public const BattleScene.Result Magic = 8192;
	public const BattleScene.Result Ignore = 16384;
}

// Namespace: 
public class BattleScene.FieldResult : BitFieldTemplate32<BattleScene.Result> // TypeDefIndex: 9519
{
	// Methods

	// RVA: 0x1F79250 Offset: 0x1F79351 VA: 0x1F79250 Slot: 5
	protected override int ToInt(BattleScene.Result value) { }

	// RVA: 0x1F79260 Offset: 0x1F79361 VA: 0x1F79260
	public static BattleScene.Result op_Implicit(BattleScene.FieldResult self) { }

	// RVA: 0x1F79270 Offset: 0x1F79371 VA: 0x1F79270
	public void .ctor() { }
}

