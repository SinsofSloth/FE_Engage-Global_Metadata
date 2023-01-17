// Namespace: Combat
public enum CameraSituation // TypeDefIndex: 8552
{
	// Fields
	public int value__; // 0x0
	public const CameraSituation EnterApproach = 1;
	public const CameraSituation EnterAttack = 2;
	public const CameraSituation EnterDamage = 4;
	public const CameraSituation SignalStart = 16;
	public const CameraSituation SignalStop = 32;
	public const CameraSituation SkillStart = 64;
	public const CameraSituation SkillStop = 128;
	public const CameraSituation ChainAttack = 1024;
	public const CameraSituation ChainGuard = 2048;
	public const CameraSituation DragonChange = 65536;
	public const CameraSituation BeginChaseArrow = 131072;
	public const CameraSituation DeadPlayer = 1048576;
	public const CameraSituation DeadBoss = 2097152;
	public const CameraSituation CombatBegin = 16777216;
	public const CameraSituation CombatEnd = 67108864;
	public const CameraSituation LevelUp = 134217728;
	public const CameraSituation LongCombat = 536870912;
	public const CameraSituation Unusable = 1073741824;
	public const CameraSituation Directly = -2147483648;
	public const CameraSituation FinInterrupt = 160;
}

