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

