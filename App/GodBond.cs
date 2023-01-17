// Namespace: App
public class GodBond : Pool.Node // TypeDefIndex: 13464
{
	// Fields
	private const int NormalEnemyLevelForGainAbility = 1;
	private const int RampageEnemyLevelForGainAbility = 2;
	private const int Version = 3;
	private GodData m_GodData; // 0x10
	private GodRelianceS m_RelianceS; // 0x18
	private string m_Pid; // 0x20
	private byte m_Level; // 0x28
	private ushort m_Exp; // 0x2A
	private GodInheritedSkills m_InheritedSkills; // 0x30
	private byte m_NotifiedLevelCapTalk; // 0x38
	private GodGrowthData.LevelData m_LevelData; // 0x40
	private static readonly GodGrowthData.LevelData NullLevelData; // 0x0

	// Properties
	public int Level { get; }
	public int Exp { get; }
	public SkillArray EngageSkills { get; }
	public SkillArray SynchroSkills { get; }
	public SkillArray EngagedSkills { get; }
	public WeaponMask Aptitude { get; }
	public GodInheritedSkills InheritedSkills { get; }
	public GodGrowthData.FlagField Flags { get; }

	// Methods

	// RVA: 0x2CF8B20 Offset: 0x2CF8C21 VA: 0x2CF8B20
	public void Build(GodData godData, GodRelianceS relianceS, string pid) { }

	// RVA: 0x2CF8DC0 Offset: 0x2CF8EC1 VA: 0x2CF8DC0 Slot: 4
	public override void OnEnter() { }

	// RVA: 0x2CF8DD0 Offset: 0x2CF8ED1 VA: 0x2CF8DD0 Slot: 5
	public override void OnExit() { }

	[ConditionalAttribute] // RVA: 0x2CBA10 Offset: 0x2CBB11 VA: 0x2CBA10
	// RVA: 0x2CF8DE0 Offset: 0x2CF8EE1 VA: 0x2CF8DE0
	public void DbgSetExp(int exp) { }

	// RVA: 0x2CF9460 Offset: 0x2CF9561 VA: 0x2CF9460
	public void SetExpForRewind(int exp) { }

	// RVA: 0x2CF8EE0 Offset: 0x2CF8FE1 VA: 0x2CF8EE0
	public bool CanAddExp() { }

	// RVA: 0x2CF9470 Offset: 0x2CF9571 VA: 0x2CF9470
	public bool TryAddExp(int exp) { }

	// RVA: 0x2CF95A0 Offset: 0x2CF96A1 VA: 0x2CF95A0
	public int GetLevelExp(int level) { }

	// RVA: 0x2CF97B0 Offset: 0x2CF98B1 VA: 0x2CF97B0
	public int GetCurrentLevelExp() { }

	// RVA: 0x2CF97C0 Offset: 0x2CF98C1 VA: 0x2CF97C0
	public int GetNextLevelExp() { }

	// RVA: 0x2CF9590 Offset: 0x2CF9691 VA: 0x2CF9590
	private int GetNextLevelExpInternal(out bool isLimit) { }

	// RVA: 0x2CF97F0 Offset: 0x2CF98F1 VA: 0x2CF97F0
	private int GetNextLevelExpInternal(int level, out bool isLimit) { }

	// RVA: 0x2CF9A70 Offset: 0x2CF9B71 VA: 0x2CF9A70
	public int GetNextLevelCap() { }

	// RVA: 0x2CF9AD0 Offset: 0x2CF9BD1 VA: 0x2CF9AD0
	public void LevelUp() { }

	// RVA: 0x2CF9240 Offset: 0x2CF9341 VA: 0x2CF9240
	public void SetLevel(int level) { }

	// RVA: 0x2CF9D90 Offset: 0x2CF9E91 VA: 0x2CF9D90
	public void SetLevelFromUnitReliance(RelianceData.Level unitRelianceLevel) { }

	[ConditionalAttribute] // RVA: 0x2CBA50 Offset: 0x2CBB51 VA: 0x2CBA50
	// RVA: 0x2CF9F20 Offset: 0x2CFA021 VA: 0x2CF9F20
	public void DbgSetLevel(int level) { }

	// RVA: 0x2CF9F50 Offset: 0x2CFA051 VA: 0x2CF9F50
	public bool IsLevelCapNormal() { }

	// RVA: 0x2CF9990 Offset: 0x2CF9A91 VA: 0x2CF9990
	private bool IsLevelCapNormalInternal(int level) { }

	// RVA: 0x2CF9FF0 Offset: 0x2CFA0F1 VA: 0x2CF9FF0
	public bool IsLevelCapTalk() { }

	// RVA: 0x2CF9A40 Offset: 0x2CF9B41 VA: 0x2CF9A40
	private bool IsLevelCapTalkInternal(int level) { }

	// RVA: 0x2CFA040 Offset: 0x2CFA141 VA: 0x2CFA040
	public bool IsNotifiedLevelCapTalk() { }

	// RVA: 0x2CFA120 Offset: 0x2CFA221 VA: 0x2CFA120
	public void SetNotifiedLevelCapTalk(bool flag = True) { }

	// RVA: 0x2CF9D60 Offset: 0x2CF9E61 VA: 0x2CF9D60
	public void SetNotifiedLevelCapTalk(GodData.RelianceLevel relianceLevel, bool flag = True) { }

	// RVA: 0x2CF90E0 Offset: 0x2CF91E1 VA: 0x2CF90E0
	public int GetLevelFromExp() { }

	// RVA: 0x2CF9670 Offset: 0x2CF9771 VA: 0x2CF9670
	public int GetMaxLevel() { }

	// RVA: 0x2CF9070 Offset: 0x2CF9171 VA: 0x2CF9070
	public int GetMaxLevelExp() { }

	// RVA: 0x2CF8F70 Offset: 0x2CF9071 VA: 0x2CF8F70
	public GodData.RelianceLevel GetRelianceLevel() { }

	// RVA: 0x2CFA0C0 Offset: 0x2CFA1C1 VA: 0x2CFA0C0
	public GodData.RelianceLevel GetMaxRelianceLevel() { }

	// RVA: 0x2CFA1E0 Offset: 0x2CFA2E1 VA: 0x2CFA1E0
	public bool CanBeRelianceLevelS() { }

	// RVA: 0x2CF9C90 Offset: 0x2CF9D91 VA: 0x2CF9C90
	public void SetRelianceLevelS() { }

	[ConditionalAttribute] // RVA: 0x2CBA90 Offset: 0x2CBB91 VA: 0x2CBA90
	// RVA: 0x2CFA3C0 Offset: 0x2CFA4C1 VA: 0x2CFA3C0
	public void DbgSetRelianceLevelS() { }

	// RVA: 0x2CFA170 Offset: 0x2CFA271 VA: 0x2CFA170
	private bool IsRelianceLevelS() { }

	// RVA: 0x2CFA370 Offset: 0x2CFA471 VA: 0x2CFA370
	private bool IsOtherRelianceLevelS() { }

	// RVA: 0x2CFA3D0 Offset: 0x2CFA4D1 VA: 0x2CFA3D0
	public bool CanTalk() { }

	// RVA: 0x2CFA490 Offset: 0x2CFA591 VA: 0x2CFA490
	public void UpdateForGodState(GodState godState) { }

	// RVA: 0x2CF96D0 Offset: 0x2CF97D1 VA: 0x2CF96D0
	private GodLevelData GetLevelData(int level) { }

	// RVA: 0x2CF8CF0 Offset: 0x2CF8DF1 VA: 0x2CF8CF0
	private void GainAbility(int level) { }

	// RVA: 0x2CF9BD0 Offset: 0x2CF9CD1 VA: 0x2CF9BD0
	private void GainCurrentAbility() { }

	// RVA: 0x2CFA640 Offset: 0x2CFA741 VA: 0x2CFA640
	private void GainAbilityImpl(GodData godData, int level) { }

	// RVA: 0x2CFA1A0 Offset: 0x2CFA2A1 VA: 0x2CFA1A0
	private bool IsLinkSelf() { }

	// RVA: 0x2CF8C50 Offset: 0x2CF8D51 VA: 0x2CF8C50
	private void Clear() { }

	// RVA: 0x2CFA7E0 Offset: 0x2CFA8E1 VA: 0x2CFA7E0
	public void ChangeOpponent(GodData data) { }

	// RVA: 0x2CF9F10 Offset: 0x2CFA011 VA: 0x2CF9F10
	private GodData.RelianceLevel ToGodRelianceLevel(RelianceData.Level unitRelianceLevel) { }

	// RVA: 0x2CFA7F0 Offset: 0x2CFA8F1 VA: 0x2CFA7F0
	public void Serialize(Stream stream) { }

	// RVA: 0x2CFA860 Offset: 0x2CFA961 VA: 0x2CFA860
	public void Deserialize(Stream stream) { }

	// RVA: 0x2CFAB30 Offset: 0x2CFAC31 VA: 0x2CFAB30
	public int get_Level() { }

	// RVA: 0x2CFAB40 Offset: 0x2CFAC41 VA: 0x2CFAB40
	public int get_Exp() { }

	// RVA: 0x2CFAB50 Offset: 0x2CFAC51 VA: 0x2CFAB50
	public SkillArray get_EngageSkills() { }

	// RVA: 0x2CFAB60 Offset: 0x2CFAC61 VA: 0x2CFAB60
	public SkillArray get_SynchroSkills() { }

	// RVA: 0x2CFAB70 Offset: 0x2CFAC71 VA: 0x2CFAB70
	public SkillArray get_EngagedSkills() { }

	// RVA: 0x2CFAB80 Offset: 0x2CFAC81 VA: 0x2CFAB80
	public WeaponMask get_Aptitude() { }

	// RVA: 0x2CFAB90 Offset: 0x2CFAC91 VA: 0x2CFAB90
	public GodInheritedSkills get_InheritedSkills() { }

	// RVA: 0x2CFABA0 Offset: 0x2CFACA1 VA: 0x2CFABA0
	public GodGrowthData.FlagField get_Flags() { }

	// RVA: 0x2CFABB0 Offset: 0x2CFACB1 VA: 0x2CFABB0
	public List<ItemData> GetEngageItems(BattleStyle.Types style) { }

	// RVA: 0x2CFABF0 Offset: 0x2CFACF1 VA: 0x2CFABF0
	public void .ctor() { }

	// RVA: 0x2CFAC00 Offset: 0x2CFAD01 VA: 0x2CFAC00
	private static void .cctor() { }
}

