// Namespace: App
public abstract class MapDeployTemplate<T> : SingletonClass<T>, IMapDeploy // TypeDefIndex: 11933
{
	// Fields
	public const int MoveMax = 100;
	private MapDeployTemplate.Queue<T> m_QueueA; // 0x0
	private MapDeployTemplate.Queue<T> m_QueueB; // 0x0
	private MapDeployTemplate.Queue<T> m_ReadQueue; // 0x0
	private MapDeployTemplate.Queue<T> m_WriteQueue; // 0x0
	private int m_QueueCount; // 0x0
	private MapDeployMoveImage m_MoveImage; // 0x0
	private MapDeployAttackImage m_AttackImage; // 0x0
	private MapDeployRodImage m_RodImage; // 0x0
	private MapDeployHealImage m_HealImage; // 0x0
	private MapDeploySupportImage m_SupportImage; // 0x0
	private MapDeployInterferenceImage m_InterferenceImage; // 0x0
	private MapDeployEngageImage m_EngageImage; // 0x0
	private MapImageCoreBit m_DrawMoveImage; // 0x0
	private MapDeployActionImage m_ActionImage; // 0x0
	private MapDeployMoveImage m_MaskImage; // 0x0
	private MapDeployMoveImage m_MoveBufferA; // 0x0
	private MapDeployMoveImage m_MoveBufferB; // 0x0
	private MapImageCoreBit m_DrawMoveBufferA; // 0x0
	private MapImageCoreBit m_DrawMoveBufferB; // 0x0
	private MapDeployAttackImage m_AttackBufferA; // 0x0
	private MapDeployAttackImage m_AttackBufferB; // 0x0
	private MapDeployRodImage m_RodBufferA; // 0x0
	private MapDeployRodImage m_RodBufferB; // 0x0
	private MapDeployHealImage m_HealBufferA; // 0x0
	private MapDeployHealImage m_HealBufferB; // 0x0
	private MapDeploySupportImage m_SupportBufferA; // 0x0
	private MapDeploySupportImage m_SupportBufferB; // 0x0
	private MapDeployInterferenceImage m_InterferenceBufferA; // 0x0
	private MapDeployInterferenceImage m_InterferenceBufferB; // 0x0
	private MapDeployActionImage m_ActionBufferA; // 0x0
	private MapDeployActionImage m_ActionBufferB; // 0x0
	private MapDeployEngageImage m_EngageBufferA; // 0x0
	private MapDeployEngageImage m_EngageBufferB; // 0x0
	private MapDeployMoveImage m_MoveBufferWork; // 0x0
	private MapDeployTrickImage m_TrickBuffer; // 0x0
	private MapDeployTrickImage m_TrickBuffer2; // 0x0
	private MapDeployZocImage m_CostMaxImage; // 0x0
	private MapDeployZocImage m_CostMinImage; // 0x0
	private MapDeployZocImage m_NotMoveImage; // 0x0
	private MapDeployAttackImage m_TargetImage; // 0x0
	private MapDeployRangeImage m_RangeImage; // 0x0
	private MapDeployOverlapImage m_OverlapImage; // 0x0
	private MapDeployLandImage m_LandImage; // 0x0
	private MapDeploySupportForUnitImage m_SupportForUnitImage; // 0x0
	private MapDeployDanceImage m_DanceImage; // 0x0
	private MapDeployCannonImage m_CannonImage; // 0x0
	private MapDeployTemplate.FlagField<T> m_Flag; // 0x0
	private Force.Type m_ForceType; // 0x0
	private byte m_AreaX1; // 0x0
	private byte m_AreaZ1; // 0x0
	private byte m_AreaX2; // 0x0
	private byte m_AreaZ2; // 0x0
	private byte m_MovePower; // 0x0
	private JobData.MoveTypes m_MoveType; // 0x0
	private Unit m_Unit; // 0x0
	private ulong[] m_NoCannonBit; // 0x0
	private int[] m_NoCannonMax; // 0x0
	private ulong[] m_BitArray; // 0x0
	private int[] m_MaxArray; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x299A50 Offset: 0x299B51 VA: 0x299A50
	private int <BmapSize>k__BackingField; // 0x0

	// Properties
	public MapDeployMoveImage MoveImage { get; set; }
	public MapImageCoreBit DrawMoveImage { get; }
	public MapDeployMoveImage MoveImageA { get; }
	public MapDeployMoveImage MoveImageB { get; }
	public MapDeployAttackImage AttackImage { get; set; }
	public MapDeployAttackImage AttackImageA { get; }
	public MapDeployAttackImage AttackImageB { get; }
	public MapDeployRodImage RodImage { get; set; }
	public MapDeployHealImage HealImage { get; set; }
	public MapDeploySupportImage SupportImage { get; set; }
	public MapDeploySupportForUnitImage SupportForUnitImage { get; set; }
	public MapDeployInterferenceImage InterferenceImage { get; set; }
	public MapDeployActionImage ActionImage { get; set; }
	public MapDeployEngageImage EngageImage { get; set; }
	public MapDeployRangeImage RangeImage { get; set; }
	public MapDeployOverlapImage OverlapImage { get; set; }
	public MapDeployLandImage LandImage { get; set; }
	public MapDeployDanceImage DanceImage { get; set; }
	public MapDeployCannonImage CannonImage { get; set; }
	public MapDeployTrickImage TrickImage { get; }
	public MapDeployTrickImage TrickImage2 { get; }
	public Force.Type ForceType { get; set; }
	public int BmapSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306B1A0 Offset: 0x306B2A1 VA: 0x306B1A0
	|-MapDeployTemplate<AIDeploy>..ctor
	|-MapDeployTemplate<MapDeploy>..ctor
	|-MapDeployTemplate<MapDnagerDeploy>..ctor
	|-MapDeployTemplate<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void TurnReset(Force.Type forceType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306BA00 Offset: 0x306BB01 VA: 0x306BA00
	|-MapDeployTemplate<MapDeploy>.TurnReset
	|-MapDeployTemplate<object>.TurnReset
	*/

	// RVA: -1 Offset: -1
	public void ResetDisplayType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306BAB0 Offset: 0x306BBB1 VA: 0x306BAB0
	|-MapDeployTemplate<object>.ResetDisplayType
	*/

	// RVA: -1 Offset: -1
	public void Move(int x, int z, JobData.MoveTypes moveType, int movePower, MapDeployTemplate.Flag<T> flag = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306BB10 Offset: 0x306BC11 VA: 0x306BB10
	|-MapDeployTemplate<MapDeploy>.Move
	|-MapDeployTemplate<object>.Move
	*/

	// RVA: -1 Offset: -1
	public void Move(Unit unit, int x, int z, JobData.MoveTypes moveType, int movePower, MapDeployTemplate.Flag<T> flag = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306BB40 Offset: 0x306BC41 VA: 0x306BB40
	|-MapDeployTemplate<MapDeploy>.Move
	|-MapDeployTemplate<object>.Move
	*/

	// RVA: -1 Offset: -1
	private void UpdateSkillImage(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306C2D0 Offset: 0x306C3D1 VA: 0x306C2D0
	|-MapDeployTemplate<object>.UpdateSkillImage
	*/

	// RVA: -1 Offset: -1
	private void ClearSkillImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306CC90 Offset: 0x306CD91 VA: 0x306CC90
	|-MapDeployTemplate<object>.ClearSkillImage
	*/

	// RVA: -1 Offset: -1
	public void EventMove(int x, int z, JobData.MoveTypes moveType, int movePower, MapDeployTemplate.Flag<T> flag = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306CD10 Offset: 0x306CE11 VA: 0x306CD10
	|-MapDeployTemplate<MapDeploy>.EventMove
	|-MapDeployTemplate<object>.EventMove
	*/

	// RVA: -1 Offset: -1
	public void DisposMove(int x, int z, JobData.MoveTypes moveType, int movePower, MapDeployTemplate.Flag<T> flag = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306CD30 Offset: 0x306CE31 VA: 0x306CD30
	|-MapDeployTemplate<MapDeploy>.DisposMove
	|-MapDeployTemplate<object>.DisposMove
	*/

	// RVA: -1 Offset: -1
	public void UnitMove(Unit unit, int movePower, MapDeployTemplate.Flag<T> flag, MapDeployTemplate.Flag<T> weaponFlag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306CD50 Offset: 0x306CE51 VA: 0x306CD50
	|-MapDeployTemplate<AIDeploy>.UnitMove
	|-MapDeployTemplate<MapDeploy>.UnitMove
	|-MapDeployTemplate<object>.UnitMove
	*/

	// RVA: -1 Offset: -1
	public void UnitMoveXZ(Unit unit, int x, int z, int movePower = -1, MapDeployTemplate.Flag<T> flag = 2, MapDeployTemplate.Flag<T> weaponFlag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306CD80 Offset: 0x306CE81 VA: 0x306CD80
	|-MapDeployTemplate<AIDeploy>.UnitMoveXZ
	|-MapDeployTemplate<MapDeploy>.UnitMoveXZ
	|-MapDeployTemplate<MapDnagerDeploy>.UnitMoveXZ
	|-MapDeployTemplate<object>.UnitMoveXZ
	*/

	// RVA: -1 Offset: -1
	public void UnitMoveItem(Unit unit, UnitItem unitItem, int movePower, MapDeployTemplate.Flag<T> flag, MapDeployTemplate.Flag<T> weaponFlag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306D3E0 Offset: 0x306D4E1 VA: 0x306D3E0
	|-MapDeployTemplate<MapDeploy>.UnitMoveItem
	|-MapDeployTemplate<object>.UnitMoveItem
	*/

	// RVA: -1 Offset: -1
	public void UnitDance(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306D510 Offset: 0x306D611 VA: 0x306D510
	|-MapDeployTemplate<MapDeploy>.UnitDance
	|-MapDeployTemplate<object>.UnitDance
	*/

	// RVA: -1 Offset: -1
	public void UnitMoveAction(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306D650 Offset: 0x306D751 VA: 0x306D650
	|-MapDeployTemplate<MapDeploy>.UnitMoveAction
	|-MapDeployTemplate<object>.UnitMoveAction
	*/

	// RVA: -1 Offset: -1
	public void UnitMoveEngage(Unit unit, int movePower, MapMind.Type mind, MapDeployTemplate.Flag<T> flag, MapDeployTemplate.Flag<T> weaponFlag = 1073741824) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306D700 Offset: 0x306D801 VA: 0x306D700
	|-MapDeployTemplate<MapDeploy>.UnitMoveEngage
	|-MapDeployTemplate<MapDnagerDeploy>.UnitMoveEngage
	|-MapDeployTemplate<object>.UnitMoveEngage
	*/

	// RVA: -1 Offset: -1
	public void UnitAIMove(Unit unit, int movePower = -1, MapDeployTemplate.Flag<T> flag = 2, MapDeployTemplate.Flag<T> weaponFlag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306DC80 Offset: 0x306DD81 VA: 0x306DC80
	|-MapDeployTemplate<AIDeploy>.UnitAIMove
	|-MapDeployTemplate<object>.UnitAIMove
	*/

	// RVA: -1 Offset: -1
	public void UnitAIMoveXY(Unit unit, int x, int z, int movePower = -1, MapDeployTemplate.Flag<T> flag = 2, MapDeployTemplate.Flag<T> weaponFlag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306DD40 Offset: 0x306DE41 VA: 0x306DD40
	|-MapDeployTemplate<AIDeploy>.UnitAIMoveXY
	|-MapDeployTemplate<object>.UnitAIMoveXY
	*/

	// RVA: -1 Offset: -1
	public void UnitWarp(Unit rodUnit, Unit targetUnit, UnitItem unitItem, int flag = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306DE10 Offset: 0x306DF11 VA: 0x306DE10
	|-MapDeployTemplate<AIDeploy>.UnitWarp
	|-MapDeployTemplate<MapDeploy>.UnitWarp
	|-MapDeployTemplate<object>.UnitWarp
	*/

	// RVA: -1 Offset: -1
	private void UnitRewarp(Unit unit, SkillData skill, MapDeployTemplate.Flag<T> flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306E3D0 Offset: 0x306E4D1 VA: 0x306E3D0
	|-MapDeployTemplate<object>.UnitRewarp
	*/

	// RVA: -1 Offset: -1
	public void UnitRewarp(Unit unit, UnitItem unitItem, MapDeployTemplate.Flag<T> flag = 33554432) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306EDD0 Offset: 0x306EED1 VA: 0x306EDD0
	|-MapDeployTemplate<MapDeploy>.UnitRewarp
	|-MapDeployTemplate<object>.UnitRewarp
	*/

	// RVA: -1 Offset: -1
	public void UnitRewarp(Unit unit, int range, MapDeployTemplate.Flag<T> flag = 1073741824) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306F0A0 Offset: 0x306F1A1 VA: 0x306F0A0
	|-MapDeployTemplate<AIDeploy>.UnitRewarp
	|-MapDeployTemplate<object>.UnitRewarp
	*/

	// RVA: -1 Offset: -1
	private void UnitRewarp(Unit unit, int range, MapDeployTemplate.Flag<T> flag, MapDeployAttackImage mask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306F0C0 Offset: 0x306F1C1 VA: 0x306F0C0
	|-MapDeployTemplate<object>.UnitRewarp
	*/

	// RVA: -1 Offset: -1
	private static void RegistRewarpMoveImage(Unit unit, int argsX, int argsZ, int rewarpRange, MapDeployMoveImage move, MapDeployAttackImage mask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306F8C0 Offset: 0x306F9C1 VA: 0x306F8C0
	|-MapDeployTemplate<object>.RegistRewarpMoveImage
	*/

	// RVA: -1 Offset: -1
	public void UnitCreation(Unit rodUnit, int rodUnitItemIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306FD00 Offset: 0x306FE01 VA: 0x306FD00
	|-MapDeployTemplate<MapDeploy>.UnitCreation
	|-MapDeployTemplate<object>.UnitCreation
	*/

	// RVA: -1 Offset: -1
	public void UnitFireCannon(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3070900 Offset: 0x3070A01 VA: 0x3070900
	|-MapDeployTemplate<object>.UnitFireCannon
	*/

	// RVA: -1 Offset: -1
	public void UnitAIMoveLimit(Unit unit, MapDeployTemplate.Flag<T> flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3070D50 Offset: 0x3070E51 VA: 0x3070D50
	|-MapDeployTemplate<MapDeploy>.UnitAIMoveLimit
	|-MapDeployTemplate<object>.UnitAIMoveLimit
	*/

	// RVA: -1 Offset: -1
	public void UnitFill(Unit unit, MapDeployTemplate.Flag<T> flag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3071A40 Offset: 0x3071B41 VA: 0x3071A40
	|-MapDeployTemplate<AIDeploy>.UnitFill
	|-MapDeployTemplate<object>.UnitFill
	*/

	// RVA: -1 Offset: -1
	public void UnitFillItem(Unit unit, UnitItem unitItem, MapDeployTemplate.Flag<T> flag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3071C10 Offset: 0x3071D11 VA: 0x3071C10
	|-MapDeployTemplate<object>.UnitFillItem
	*/

	// RVA: -1 Offset: -1
	private void FillOneself(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3072430 Offset: 0x3072531 VA: 0x3072430
	|-MapDeployTemplate<object>.FillOneself
	*/

	// RVA: -1 Offset: -1
	public void UnitFillAction(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3072590 Offset: 0x3072691 VA: 0x3072590
	|-MapDeployTemplate<object>.UnitFillAction
	*/

	// RVA: -1 Offset: -1
	private void FillDragonVein() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3074250 Offset: 0x3074351 VA: 0x3074250
	|-MapDeployTemplate<object>.FillDragonVein
	*/

	// RVA: -1 Offset: -1
	private void UnitFillEngage(Unit unit, MapMind.Type mind, MapDeployTemplate.Flag<T> flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3074480 Offset: 0x3074581 VA: 0x3074480
	|-MapDeployTemplate<object>.UnitFillEngage
	*/

	// RVA: -1 Offset: -1
	public void UnitAIFillSkill(Unit unit, SkillData skill, MapDeployTemplate.Flag<T> flag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3074E50 Offset: 0x3074F51 VA: 0x3074E50
	|-MapDeployTemplate<AIDeploy>.UnitAIFillSkill
	|-MapDeployTemplate<object>.UnitAIFillSkill
	*/

	// RVA: -1 Offset: -1
	public void UnitAIFillItem(Unit unit, UnitItem unitItem, SkillData skill, MapDeployTemplate.Flag<T> flag = 50331648) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3075060 Offset: 0x3075161 VA: 0x3075060
	|-MapDeployTemplate<AIDeploy>.UnitAIFillItem
	|-MapDeployTemplate<object>.UnitAIFillItem
	*/

	// RVA: -1 Offset: -1
	public void UnitAIFillRewarp(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3075380 Offset: 0x3075481 VA: 0x3075380
	|-MapDeployTemplate<AIDeploy>.UnitAIFillRewarp
	|-MapDeployTemplate<object>.UnitAIFillRewarp
	*/

	// RVA: -1 Offset: -1
	public void RangeAround(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3075C60 Offset: 0x3075D61 VA: 0x3075C60
	|-MapDeployTemplate<AIDeploy>.RangeAround
	|-MapDeployTemplate<object>.RangeAround
	*/

	// RVA: -1 Offset: -1
	public void RangeImmobile(int xx, int zz, int rangeI, int rangeO) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3076230 Offset: 0x3076331 VA: 0x3076230
	|-MapDeployTemplate<object>.RangeImmobile
	*/

	// RVA: -1 Offset: -1
	public void UnitRangeImmobile(Unit unit, int xx, int zz, int flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3076560 Offset: 0x3076661 VA: 0x3076560
	|-MapDeployTemplate<object>.UnitRangeImmobile
	*/

	// RVA: -1 Offset: -1
	public void TargetOnly(Unit attacker, UnitItem unitItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3076940 Offset: 0x3076A41 VA: 0x3076940
	|-MapDeployTemplate<object>.TargetOnly
	*/

	// RVA: -1 Offset: -1
	public void UnitTriangle(Unit attacker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3076C10 Offset: 0x3076D11 VA: 0x3076C10
	|-MapDeployTemplate<object>.UnitTriangle
	*/

	// RVA: -1 Offset: -1
	public void SetMoveA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077010 Offset: 0x3077111 VA: 0x3077010
	|-MapDeployTemplate<AIDeploy>.SetMoveA
	|-MapDeployTemplate<MapDeploy>.SetMoveA
	|-MapDeployTemplate<object>.SetMoveA
	*/

	// RVA: -1 Offset: -1
	public void SetMoveB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077050 Offset: 0x3077151 VA: 0x3077050
	|-MapDeployTemplate<AIDeploy>.SetMoveB
	|-MapDeployTemplate<MapDeploy>.SetMoveB
	|-MapDeployTemplate<object>.SetMoveB
	*/

	// RVA: -1 Offset: -1
	public void SetAttackA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077090 Offset: 0x3077191 VA: 0x3077090
	|-MapDeployTemplate<object>.SetAttackA
	*/

	// RVA: -1 Offset: -1
	public void SetAttackB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30770A0 Offset: 0x30771A1 VA: 0x30770A0
	|-MapDeployTemplate<object>.SetAttackB
	*/

	// RVA: -1 Offset: -1
	public void SetRodA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30770B0 Offset: 0x30771B1 VA: 0x30770B0
	|-MapDeployTemplate<object>.SetRodA
	*/

	// RVA: -1 Offset: -1
	public void SetRodB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30770C0 Offset: 0x30771C1 VA: 0x30770C0
	|-MapDeployTemplate<object>.SetRodB
	*/

	// RVA: -1 Offset: -1
	public void SetHealA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30770D0 Offset: 0x30771D1 VA: 0x30770D0
	|-MapDeployTemplate<object>.SetHealA
	*/

	// RVA: -1 Offset: -1
	public void SetHealB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30770E0 Offset: 0x30771E1 VA: 0x30770E0
	|-MapDeployTemplate<object>.SetHealB
	*/

	// RVA: -1 Offset: -1
	public void SetSupportA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30770F0 Offset: 0x30771F1 VA: 0x30770F0
	|-MapDeployTemplate<object>.SetSupportA
	*/

	// RVA: -1 Offset: -1
	public void SetSupportB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077100 Offset: 0x3077201 VA: 0x3077100
	|-MapDeployTemplate<object>.SetSupportB
	*/

	// RVA: -1 Offset: -1
	public void SetInterferenceA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077110 Offset: 0x3077211 VA: 0x3077110
	|-MapDeployTemplate<object>.SetInterferenceA
	*/

	// RVA: -1 Offset: -1
	public void SetInterferenceB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077120 Offset: 0x3077221 VA: 0x3077120
	|-MapDeployTemplate<object>.SetInterferenceB
	*/

	// RVA: -1 Offset: -1
	public void SetEngageA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077130 Offset: 0x3077231 VA: 0x3077130
	|-MapDeployTemplate<object>.SetEngageA
	*/

	// RVA: -1 Offset: -1
	public void SetEngageB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077140 Offset: 0x3077241 VA: 0x3077140
	|-MapDeployTemplate<object>.SetEngageB
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void SetBufferA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077150 Offset: 0x3077251 VA: 0x3077150
	|-MapDeployTemplate<AIDeploy>.SetBufferA
	|-MapDeployTemplate<MapDeploy>.SetBufferA
	|-MapDeployTemplate<MapDnagerDeploy>.SetBufferA
	|-MapDeployTemplate<object>.SetBufferA
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void SetBufferB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077210 Offset: 0x3077311 VA: 0x3077210
	|-MapDeployTemplate<AIDeploy>.SetBufferB
	|-MapDeployTemplate<MapDeploy>.SetBufferB
	|-MapDeployTemplate<MapDnagerDeploy>.SetBufferB
	|-MapDeployTemplate<object>.SetBufferB
	*/

	// RVA: -1 Offset: -1
	public void SetMaskImage(MapDeployMoveImage image) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30772D0 Offset: 0x30773D1 VA: 0x30772D0
	|-MapDeployTemplate<MapDeploy>.SetMaskImage
	|-MapDeployTemplate<object>.SetMaskImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployMoveImage get_MoveImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30772E0 Offset: 0x30773E1 VA: 0x30772E0
	|-MapDeployTemplate<AIDeploy>.get_MoveImage
	|-MapDeployTemplate<MapDeploy>.get_MoveImage
	|-MapDeployTemplate<object>.get_MoveImage
	*/

	// RVA: -1 Offset: -1
	public void set_MoveImage(MapDeployMoveImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30772F0 Offset: 0x30773F1 VA: 0x30772F0
	|-MapDeployTemplate<MapDnagerDeploy>.set_MoveImage
	|-MapDeployTemplate<object>.set_MoveImage
	*/

	// RVA: -1 Offset: -1
	public MapImageCoreBit get_DrawMoveImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077300 Offset: 0x3077401 VA: 0x3077300
	|-MapDeployTemplate<MapDeploy>.get_DrawMoveImage
	|-MapDeployTemplate<object>.get_DrawMoveImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployMoveImage get_MoveImageA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077310 Offset: 0x3077411 VA: 0x3077310
	|-MapDeployTemplate<MapDeploy>.get_MoveImageA
	|-MapDeployTemplate<object>.get_MoveImageA
	*/

	// RVA: -1 Offset: -1
	public MapDeployMoveImage get_MoveImageB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077320 Offset: 0x3077421 VA: 0x3077320
	|-MapDeployTemplate<AIDeploy>.get_MoveImageB
	|-MapDeployTemplate<MapDeploy>.get_MoveImageB
	|-MapDeployTemplate<object>.get_MoveImageB
	*/

	// RVA: -1 Offset: -1
	public MapDeployAttackImage get_AttackImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077330 Offset: 0x3077431 VA: 0x3077330
	|-MapDeployTemplate<AIDeploy>.get_AttackImage
	|-MapDeployTemplate<MapDeploy>.get_AttackImage
	|-MapDeployTemplate<object>.get_AttackImage
	*/

	// RVA: -1 Offset: -1
	public void set_AttackImage(MapDeployAttackImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077340 Offset: 0x3077441 VA: 0x3077340
	|-MapDeployTemplate<MapDnagerDeploy>.set_AttackImage
	|-MapDeployTemplate<object>.set_AttackImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployAttackImage get_AttackImageA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077350 Offset: 0x3077451 VA: 0x3077350
	|-MapDeployTemplate<AIDeploy>.get_AttackImageA
	|-MapDeployTemplate<object>.get_AttackImageA
	*/

	// RVA: -1 Offset: -1
	public MapDeployAttackImage get_AttackImageB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077360 Offset: 0x3077461 VA: 0x3077360
	|-MapDeployTemplate<AIDeploy>.get_AttackImageB
	|-MapDeployTemplate<object>.get_AttackImageB
	*/

	// RVA: -1 Offset: -1
	public MapDeployRodImage get_RodImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077370 Offset: 0x3077471 VA: 0x3077370
	|-MapDeployTemplate<AIDeploy>.get_RodImage
	|-MapDeployTemplate<MapDeploy>.get_RodImage
	|-MapDeployTemplate<object>.get_RodImage
	*/

	// RVA: -1 Offset: -1
	public void set_RodImage(MapDeployRodImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077380 Offset: 0x3077481 VA: 0x3077380
	|-MapDeployTemplate<MapDnagerDeploy>.set_RodImage
	|-MapDeployTemplate<object>.set_RodImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployHealImage get_HealImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077390 Offset: 0x3077491 VA: 0x3077390
	|-MapDeployTemplate<MapDeploy>.get_HealImage
	|-MapDeployTemplate<object>.get_HealImage
	*/

	// RVA: -1 Offset: -1
	public void set_HealImage(MapDeployHealImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30773A0 Offset: 0x30774A1 VA: 0x30773A0
	|-MapDeployTemplate<MapDnagerDeploy>.set_HealImage
	|-MapDeployTemplate<object>.set_HealImage
	*/

	// RVA: -1 Offset: -1
	public MapDeploySupportImage get_SupportImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30773B0 Offset: 0x30774B1 VA: 0x30773B0
	|-MapDeployTemplate<MapDeploy>.get_SupportImage
	|-MapDeployTemplate<object>.get_SupportImage
	*/

	// RVA: -1 Offset: -1
	public void set_SupportImage(MapDeploySupportImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30773C0 Offset: 0x30774C1 VA: 0x30773C0
	|-MapDeployTemplate<MapDnagerDeploy>.set_SupportImage
	|-MapDeployTemplate<object>.set_SupportImage
	*/

	// RVA: -1 Offset: -1
	public MapDeploySupportForUnitImage get_SupportForUnitImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30773D0 Offset: 0x30774D1 VA: 0x30773D0
	|-MapDeployTemplate<MapDeploy>.get_SupportForUnitImage
	|-MapDeployTemplate<object>.get_SupportForUnitImage
	*/

	// RVA: -1 Offset: -1
	public void set_SupportForUnitImage(MapDeploySupportForUnitImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30773E0 Offset: 0x30774E1 VA: 0x30773E0
	|-MapDeployTemplate<object>.set_SupportForUnitImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployInterferenceImage get_InterferenceImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30773F0 Offset: 0x30774F1 VA: 0x30773F0
	|-MapDeployTemplate<MapDeploy>.get_InterferenceImage
	|-MapDeployTemplate<object>.get_InterferenceImage
	*/

	// RVA: -1 Offset: -1
	public void set_InterferenceImage(MapDeployInterferenceImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077400 Offset: 0x3077501 VA: 0x3077400
	|-MapDeployTemplate<MapDnagerDeploy>.set_InterferenceImage
	|-MapDeployTemplate<object>.set_InterferenceImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployActionImage get_ActionImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077410 Offset: 0x3077511 VA: 0x3077410
	|-MapDeployTemplate<MapDeploy>.get_ActionImage
	|-MapDeployTemplate<object>.get_ActionImage
	*/

	// RVA: -1 Offset: -1
	public void set_ActionImage(MapDeployActionImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077420 Offset: 0x3077521 VA: 0x3077420
	|-MapDeployTemplate<object>.set_ActionImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployEngageImage get_EngageImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077430 Offset: 0x3077531 VA: 0x3077430
	|-MapDeployTemplate<object>.get_EngageImage
	*/

	// RVA: -1 Offset: -1
	public void set_EngageImage(MapDeployEngageImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077440 Offset: 0x3077541 VA: 0x3077440
	|-MapDeployTemplate<MapDnagerDeploy>.set_EngageImage
	|-MapDeployTemplate<object>.set_EngageImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployRangeImage get_RangeImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077450 Offset: 0x3077551 VA: 0x3077450
	|-MapDeployTemplate<MapDeploy>.get_RangeImage
	|-MapDeployTemplate<object>.get_RangeImage
	*/

	// RVA: -1 Offset: -1
	public void set_RangeImage(MapDeployRangeImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077460 Offset: 0x3077561 VA: 0x3077460
	|-MapDeployTemplate<object>.set_RangeImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployOverlapImage get_OverlapImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077470 Offset: 0x3077571 VA: 0x3077470
	|-MapDeployTemplate<MapDeploy>.get_OverlapImage
	|-MapDeployTemplate<object>.get_OverlapImage
	*/

	// RVA: -1 Offset: -1
	public void set_OverlapImage(MapDeployOverlapImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077480 Offset: 0x3077581 VA: 0x3077480
	|-MapDeployTemplate<object>.set_OverlapImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployLandImage get_LandImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077490 Offset: 0x3077591 VA: 0x3077490
	|-MapDeployTemplate<object>.get_LandImage
	*/

	// RVA: -1 Offset: -1
	public void set_LandImage(MapDeployLandImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30774A0 Offset: 0x30775A1 VA: 0x30774A0
	|-MapDeployTemplate<object>.set_LandImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployDanceImage get_DanceImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30774B0 Offset: 0x30775B1 VA: 0x30774B0
	|-MapDeployTemplate<MapDeploy>.get_DanceImage
	|-MapDeployTemplate<object>.get_DanceImage
	*/

	// RVA: -1 Offset: -1
	public void set_DanceImage(MapDeployDanceImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30774C0 Offset: 0x30775C1 VA: 0x30774C0
	|-MapDeployTemplate<object>.set_DanceImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployCannonImage get_CannonImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30774D0 Offset: 0x30775D1 VA: 0x30774D0
	|-MapDeployTemplate<MapDeploy>.get_CannonImage
	|-MapDeployTemplate<object>.get_CannonImage
	*/

	// RVA: -1 Offset: -1
	public void set_CannonImage(MapDeployCannonImage value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30774E0 Offset: 0x30775E1 VA: 0x30774E0
	|-MapDeployTemplate<object>.set_CannonImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployTrickImage get_TrickImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30774F0 Offset: 0x30775F1 VA: 0x30774F0
	|-MapDeployTemplate<object>.get_TrickImage
	*/

	// RVA: -1 Offset: -1
	public MapDeployTrickImage get_TrickImage2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077500 Offset: 0x3077601 VA: 0x3077500
	|-MapDeployTemplate<object>.get_TrickImage2
	*/

	// RVA: -1 Offset: -1
	public Force.Type get_ForceType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077510 Offset: 0x3077611 VA: 0x3077510
	|-MapDeployTemplate<MapDeploy>.get_ForceType
	|-MapDeployTemplate<object>.get_ForceType
	*/

	// RVA: -1 Offset: -1
	public void set_ForceType(Force.Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077520 Offset: 0x3077621 VA: 0x3077520
	|-MapDeployTemplate<MapDeploy>.set_ForceType
	|-MapDeployTemplate<object>.set_ForceType
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2C71A0 Offset: 0x2C72A1 VA: 0x2C71A0
	// RVA: -1 Offset: -1
	public int get_BmapSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077530 Offset: 0x3077631 VA: 0x3077530
	|-MapDeployTemplate<object>.get_BmapSize
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2C71B0 Offset: 0x2C72B1 VA: 0x2C71B0
	// RVA: -1 Offset: -1
	private void set_BmapSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077540 Offset: 0x3077641 VA: 0x3077540
	|-MapDeployTemplate<object>.set_BmapSize
	*/

	// RVA: -1 Offset: -1
	private void SearchDir(Dir.Type dir) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077550 Offset: 0x3077651 VA: 0x3077550
	|-MapDeployTemplate<object>.SearchDir
	*/

	// RVA: -1 Offset: -1
	private bool IsOutOfArea(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077EC0 Offset: 0x3077FC1 VA: 0x3077EC0
	|-MapDeployTemplate<object>.IsOutOfArea
	*/

	// RVA: -1 Offset: -1
	private int GetCost(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3077F10 Offset: 0x3078011 VA: 0x3077F10
	|-MapDeployTemplate<object>.GetCost
	*/

	// RVA: -1 Offset: -1
	private bool IsBeforeMove(SkillData skill) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3078100 Offset: 0x3078201 VA: 0x3078100
	|-MapDeployTemplate<object>.IsBeforeMove
	*/

	// RVA: -1 Offset: -1
	private void GetRangeBit(Unit unit, ulong[] bit, int[] max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3078160 Offset: 0x3078261 VA: 0x3078160
	|-MapDeployTemplate<object>.GetRangeBit
	*/

	// RVA: -1 Offset: -1
	private void GetRangeBit(Unit unit, SkillData skill, ulong[] bitArray, int[] maxArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3078190 Offset: 0x3078291 VA: 0x3078190
	|-MapDeployTemplate<object>.GetRangeBit
	*/

	// RVA: -1 Offset: -1
	private bool IsFill(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30790D0 Offset: 0x30791D1 VA: 0x30790D0
	|-MapDeployTemplate<object>.IsFill
	*/

	// RVA: -1 Offset: -1
	private void Fill(Unit unit, SkillData skill, bool isConsiderCannon = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3079340 Offset: 0x3079441 VA: 0x3079340
	|-MapDeployTemplate<object>.Fill
	*/

	// RVA: -1 Offset: -1
	private void FillAttack(Unit unit, ulong bit, int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x307B880 Offset: 0x307B981 VA: 0x307B880
	|-MapDeployTemplate<object>.FillAttack
	*/

	// RVA: -1 Offset: -1
	private void FillRod(Unit unit, ulong bit, int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x307C180 Offset: 0x307C281 VA: 0x307C180
	|-MapDeployTemplate<object>.FillRod
	*/

	// RVA: -1 Offset: -1
	public void FillRangeImage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x307CA80 Offset: 0x307CB81 VA: 0x307CA80
	|-MapDeployTemplate<MapDeploy>.FillRangeImage
	|-MapDeployTemplate<object>.FillRangeImage
	*/

	// RVA: -1 Offset: -1
	public void FillSupportForUnitImage(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3080050 Offset: 0x3080151 VA: 0x3080050
	|-MapDeployTemplate<MapDeploy>.FillSupportForUnitImage
	|-MapDeployTemplate<object>.FillSupportForUnitImage
	*/

	// RVA: -1 Offset: -1
	private bool IsSupportRodForUnit(UnitItem unitItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3080930 Offset: 0x3080A31 VA: 0x3080930
	|-MapDeployTemplate<object>.IsSupportRodForUnit
	*/

	// RVA: -1 Offset: -1
	public void FillDanceImage(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3080980 Offset: 0x3080A81 VA: 0x3080980
	|-MapDeployTemplate<MapDeploy>.FillDanceImage
	|-MapDeployTemplate<object>.FillDanceImage
	*/

	// RVA: -1 Offset: -1
	public void FillRangeImageForCannon(Unit unit, MapDeployTemplate.Flag<T> flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3081130 Offset: 0x3081231 VA: 0x3081130
	|-MapDeployTemplate<MapDeploy>.FillRangeImageForCannon
	|-MapDeployTemplate<object>.FillRangeImageForCannon
	*/

	// RVA: -1 Offset: -1
	private void FillImage(Unit unit, ulong bit, int min, int max, MapImageCoreBit image) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3081670 Offset: 0x3081771 VA: 0x3081670
	|-MapDeployTemplate<object>.FillImage
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3082000 Offset: 0x3082101 VA: 0x3082000
	|-MapDeployTemplate<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public int GetDistance(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3082100 Offset: 0x3082201 VA: 0x3082100
	|-MapDeployTemplate<MapDeploy>.GetDistance
	|-MapDeployTemplate<object>.GetDistance
	*/

	// RVA: -1 Offset: -1
	public int GetDistance(MapRoute route, int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3082700 Offset: 0x3082801 VA: 0x3082700
	|-MapDeployTemplate<MapDeploy>.GetDistance
	|-MapDeployTemplate<object>.GetDistance
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2C71C0 Offset: 0x2C72C1 VA: 0x2C71C0
	// RVA: -1 Offset: -1
	private void <UnitFillAction>b__93_2(int x, int z, TerrainData terrain) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3082790 Offset: 0x3082891 VA: 0x3082790
	|-MapDeployTemplate<object>.<UnitFillAction>b__93_2
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2C71D0 Offset: 0x2C72D1 VA: 0x2C71D0
	// RVA: -1 Offset: -1
	private void <UnitFillAction>b__93_0(SkillData skill, int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30827E0 Offset: 0x30828E1 VA: 0x30827E0
	|-MapDeployTemplate<object>.<UnitFillAction>b__93_0
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2C71E0 Offset: 0x2C72E1 VA: 0x2C71E0
	// RVA: -1 Offset: -1
	private void <UnitFillAction>b__93_1(Unit vision) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3082830 Offset: 0x3082931 VA: 0x3082830
	|-MapDeployTemplate<object>.<UnitFillAction>b__93_1
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2C71F0 Offset: 0x2C72F1 VA: 0x2C71F0
	// RVA: -1 Offset: -1
	private void <UnitFillAction>b__93_3(Unit target, int xx, int zz) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3082890 Offset: 0x3082991 VA: 0x3082890
	|-MapDeployTemplate<object>.<UnitFillAction>b__93_3
	*/
}

