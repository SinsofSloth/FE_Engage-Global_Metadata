// Namespace: App
public class MapSequenceHuman : SingletonProcInst<MapSequenceHuman> // TypeDefIndex: 12426
{
	// Fields
	private Unit m_JobIntroUnit; // 0x78
	private MapKeyHelp.Types m_JobIntroKeyHelpType; // 0x80
	private MapSequenceHuman.Label m_ReturnLabel; // 0x84
	private int m_OldUnitX; // 0x88
	private int m_OldUnitZ; // 0x8C
	private int m_OldCursorX; // 0x90
	private int m_OldCursorZ; // 0x94
	private int m_OldPickupX; // 0x98
	private int m_OldPickupZ; // 0x9C
	private int m_EngageX; // 0xA0
	private int m_EngageZ; // 0xA4
	private int m_EnterX; // 0xA8
	private int m_EnterZ; // 0xAC
	private bool m_IsEnemyAttackRange; // 0xB0
	private bool m_IsUpdateSupportSkill; // 0xB1
	private Unit m_UpdateSupportSkillUnit; // 0xB8
	private MapSequenceHuman.OperateMode m_OperateMode; // 0xC0
	private const MapDeployTemplate.Flag<MapDeploy> PlayerMoveMask = 16390;
	private const MapDeployTemplate.Flag<MapDeploy> EnemyMoveMask = 16386;
	private const MapDeployTemplate.Flag<MapDeploy> FreeWeaponMask = 50331648;
	private const MapDeployTemplate.Flag<MapDeploy> PickWeaponMask = 50331648;
	private const float WaitPickFreeCursor = 0.125;

	// Properties
	public int OldCursorX { get; }
	public int OldCursorZ { get; }
	public int EngageX { set; }
	public int EngageZ { set; }

	// Methods

	// RVA: 0x1D935A0 Offset: 0x1D936A1 VA: 0x1D935A0
	private void .ctor() { }

	// RVA: 0x1D93750 Offset: 0x1D93851 VA: 0x1D93750 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1D938B0 Offset: 0x1D939B1 VA: 0x1D938B0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1D93A20 Offset: 0x1D93B21 VA: 0x1D93A20 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x1D93B30 Offset: 0x1D93C31 VA: 0x1D93B30
	public MapSequenceHuman.OperateMode GetOperateMode() { }

	// RVA: 0x1D93B40 Offset: 0x1D93C41 VA: 0x1D93B40
	public MapSequenceHuman.OperateMode GetDefaultOperateMode() { }

	// RVA: 0x1D93BF0 Offset: 0x1D93CF1 VA: 0x1D93BF0
	public void SetOperateMode(MapSequenceHuman.OperateMode mode = 0) { }

	// RVA: 0x1D90E00 Offset: 0x1D90F01 VA: 0x1D90E00
	public void SetEngagePos() { }

	// RVA: 0x1D93C90 Offset: 0x1D93D91 VA: 0x1D93C90
	public void ResetEngagePos() { }

	// RVA: 0x1D93CA0 Offset: 0x1D93DA1 VA: 0x1D93CA0
	public bool IsEngagePos(Unit unit) { }

	// RVA: 0x1D93D40 Offset: 0x1D93E41 VA: 0x1D93D40
	public void SetEnterPos(int x, int z) { }

	// RVA: 0x1D93D50 Offset: 0x1D93E51 VA: 0x1D93D50
	private MapSequenceHuman.NextMode GetNextMode(string name) { }

	// RVA: 0x1D93D80 Offset: 0x1D93E81 VA: 0x1D93D80
	private Unit GetManualNextUnit(int x, int z, bool isReverse) { }

	// RVA: 0x1D94950 Offset: 0x1D94A51 VA: 0x1D94950
	private Unit GetAutoNextUnit(int x, int z) { }

	// RVA: 0x1D94AC0 Offset: 0x1D94BC1 VA: 0x1D94AC0
	private void StartBranch() { }

	// RVA: 0x1D95010 Offset: 0x1D95111 VA: 0x1D95010
	private void FreeCursorPrepare() { }

	// RVA: 0x1D965A0 Offset: 0x1D966A1 VA: 0x1D965A0
	private void FreeCursorTick() { }

	// RVA: 0x1D98150 Offset: 0x1D98251 VA: 0x1D98150
	private bool FreeCursorDecide() { }

	// RVA: 0x1D98640 Offset: 0x1D98741 VA: 0x1D98640
	private void SystemMenuOpen() { }

	// RVA: 0x1D978D0 Offset: 0x1D979D1 VA: 0x1D978D0
	private bool SortieCursorDecide() { }

	// RVA: 0x1D993D0 Offset: 0x1D994D1 VA: 0x1D993D0
	private void SortieCursorDecideTranspose() { }

	// RVA: 0x1D97F10 Offset: 0x1D98011 VA: 0x1D97F10
	private bool SortieCursorCancel() { }

	// RVA: 0x1D99A90 Offset: 0x1D99B91 VA: 0x1D99A90
	private bool SortieCursorSortieEnd() { }

	// RVA: 0x1D99C50 Offset: 0x1D99D51 VA: 0x1D99C50
	private void SortiePositionChanged() { }

	// RVA: 0x1D99CC0 Offset: 0x1D99DC1 VA: 0x1D99CC0
	private void PickCursorPrepare() { }

	// RVA: 0x1D9A050 Offset: 0x1D9A151 VA: 0x1D9A050
	public static void UpdateDeploy(Unit unit) { }

	// RVA: 0x1D9A2A0 Offset: 0x1D9A3A1 VA: 0x1D9A2A0
	public static bool IsMoveOut(Unit unit, int x, int z) { }

	// RVA: 0x1D9A490 Offset: 0x1D9A591 VA: 0x1D9A490
	private void PickCursorResumePrepare() { }

	// RVA: 0x1D9B3D0 Offset: 0x1D9B4D1 VA: 0x1D9B3D0
	private void PickupTutorial() { }

	// RVA: 0x1D9B4C0 Offset: 0x1D9B5C1 VA: 0x1D9B4C0
	private void PickupEventBegin() { }

	// RVA: 0x1D9B750 Offset: 0x1D9B851 VA: 0x1D9B750
	private void PickupEvent() { }

	// RVA: 0x1D9B880 Offset: 0x1D9B981 VA: 0x1D9B880
	private void PickupEventEnd() { }

	// RVA: 0x1D9B910 Offset: 0x1D9BA11 VA: 0x1D9B910
	private void PickCursorTick() { }

	// RVA: 0x1D9E180 Offset: 0x1D9E281 VA: 0x1D9E180
	private void CommitMapPanelTargetForIndirect(Unit unit) { }

	// RVA: 0x1D9CD20 Offset: 0x1D9CE21 VA: 0x1D9CD20
	private void UpdateSupportSkill() { }

	// RVA: 0x1D9CAF0 Offset: 0x1D9CBF1 VA: 0x1D9CAF0
	private void UpdateSupportSkill(int x, int z) { }

	// RVA: 0x1D9E520 Offset: 0x1D9E621 VA: 0x1D9E520
	private bool CanShortCommand(Unit unit) { }

	// RVA: 0x1D9E590 Offset: 0x1D9E691 VA: 0x1D9E590
	private bool CanShortCommandForChangeWeapon(Unit unit) { }

	// RVA: 0x1D9DB80 Offset: 0x1D9DC81 VA: 0x1D9DB80
	private bool PickUnitTick(MapSequenceHuman.Label label) { }

	// RVA: 0x1D9CFD0 Offset: 0x1D9D0D1 VA: 0x1D9CFD0
	private bool PickCursorDecide() { }

	// RVA: 0x1D9D770 Offset: 0x1D9D871 VA: 0x1D9D770
	private bool PickCursorCancel() { }

	// RVA: 0x1D9F5F0 Offset: 0x1D9F6F1 VA: 0x1D9F5F0
	private void PickFreeCursorPrepare() { }

	// RVA: 0x1D9FC40 Offset: 0x1D9FD41 VA: 0x1D9FC40
	private void UpdateScreenInfoForPickFreeCursor() { }

	// RVA: 0x1D9AB60 Offset: 0x1D9AC61 VA: 0x1D9AB60
	public void UpdateRoute(int x, int z) { }

	// RVA: 0x1DA0370 Offset: 0x1DA0471 VA: 0x1DA0370
	private void PickFreeCursorTick() { }

	// RVA: 0x1DA1350 Offset: 0x1DA1451 VA: 0x1DA1350
	private void PickFreeCursorBrunch() { }

	// RVA: 0x1DA0FB0 Offset: 0x1DA10B1 VA: 0x1DA0FB0
	private void PickFreeCursorCancel() { }

	// RVA: 0x1D9ED30 Offset: 0x1D9EE31 VA: 0x1D9ED30
	private void DesignateTargetUnit() { }

	// RVA: 0x1DA18B0 Offset: 0x1DA19B1 VA: 0x1DA18B0
	private void PickMoveResume() { }

	// RVA: 0x1DA19F0 Offset: 0x1DA1AF1 VA: 0x1DA19F0
	private void MoveUnit() { }

	// RVA: 0x1DA1B00 Offset: 0x1DA1C01 VA: 0x1DA1B00
	private void WaitMovingUnit() { }

	// RVA: 0x1DA1BB0 Offset: 0x1DA1CB1 VA: 0x1DA1BB0
	private void PostMoveUnit() { }

	// RVA: 0x1DA1C80 Offset: 0x1DA1D81 VA: 0x1DA1C80
	private void WarpCursorPrepare() { }

	// RVA: 0x1DA2470 Offset: 0x1DA2571 VA: 0x1DA2470
	private void WarpCursorTick() { }

	// RVA: 0x1DA20A0 Offset: 0x1DA21A1 VA: 0x1DA20A0
	private void SetCursorMindForWarp() { }

	// RVA: 0x1DA2EC0 Offset: 0x1DA2FC1 VA: 0x1DA2EC0
	private bool WarpCursorDecide() { }

	// RVA: 0x1DA3570 Offset: 0x1DA3671 VA: 0x1DA3570
	private bool WarpCursorCancel() { }

	// RVA: 0x1DA3910 Offset: 0x1DA3A11 VA: 0x1DA3910
	private void RewarpCursorPrepare() { }

	// RVA: 0x1DA3DF0 Offset: 0x1DA3EF1 VA: 0x1DA3DF0
	private void UpdateUnitRewarp() { }

	// RVA: 0x1DA4350 Offset: 0x1DA4451 VA: 0x1DA4350
	private void RewarpCursorTick() { }

	// RVA: 0x1DA3F80 Offset: 0x1DA4081 VA: 0x1DA3F80
	private void SetCursorMindForRewarp() { }

	// RVA: 0x1DA4D10 Offset: 0x1DA4E11 VA: 0x1DA4D10
	private bool RewarpCursorDecide() { }

	// RVA: 0x1DA53B0 Offset: 0x1DA54B1 VA: 0x1DA53B0
	private bool RewarpCursorCancel() { }

	// RVA: 0x1DA58A0 Offset: 0x1DA59A1 VA: 0x1DA58A0
	private void CreationCursorPrepare() { }

	// RVA: 0x1DA60C0 Offset: 0x1DA61C1 VA: 0x1DA60C0
	private void CreationCursorTick() { }

	// RVA: 0x1DA5D10 Offset: 0x1DA5E11 VA: 0x1DA5D10
	private void SetCursorMindForCreation() { }

	// RVA: 0x1DA6900 Offset: 0x1DA6A01 VA: 0x1DA6900
	private bool CreationCursorDecide() { }

	// RVA: 0x1DA6EE0 Offset: 0x1DA6FE1 VA: 0x1DA6EE0
	private bool CreationCursorCancel() { }

	// RVA: 0x1DA7210 Offset: 0x1DA7311 VA: 0x1DA7210
	private void FireCannonCursorPrepare() { }

	// RVA: 0x1DA7DF0 Offset: 0x1DA7EF1 VA: 0x1DA7DF0
	private void FireCannonCursorTick() { }

	// RVA: 0x1DA7A40 Offset: 0x1DA7B41 VA: 0x1DA7A40
	private void SetCursorMindForFireCannon() { }

	// RVA: 0x1DA86A0 Offset: 0x1DA87A1 VA: 0x1DA86A0
	private bool FireCannonCursorDecide() { }

	// RVA: 0x1DA8F80 Offset: 0x1DA9081 VA: 0x1DA8F80
	private bool IsUseFireCannon(int x, int z) { }

	// RVA: 0x1DA8B90 Offset: 0x1DA8C91 VA: 0x1DA8B90
	private bool FireCannonCursorCancel() { }

	// RVA: 0x1DA9150 Offset: 0x1DA9251 VA: 0x1DA9150
	private void TalkPrepare() { }

	// RVA: 0x1DA9240 Offset: 0x1DA9341 VA: 0x1DA9240
	private void Talked() { }

	// RVA: 0x1DA93B0 Offset: 0x1DA94B1 VA: 0x1DA93B0
	private void CreateSystemMenu() { }

	// RVA: 0x1DA9420 Offset: 0x1DA9521 VA: 0x1DA9420
	private void TargetEvent() { }

	// RVA: 0x1DA94C0 Offset: 0x1DA95C1 VA: 0x1DA94C0
	private void UnitCommandPrepare() { }

	// RVA: 0x1DA9860 Offset: 0x1DA9961 VA: 0x1DA9860
	private void UnitCommandPrepareEvent() { }

	// RVA: 0x1DA9900 Offset: 0x1DA9A01 VA: 0x1DA9900
	private void UnitCommandCancel() { }

	// RVA: 0x1DAA170 Offset: 0x1DAA271 VA: 0x1DAA170
	private void AttackMenuPrepare() { }

	// RVA: 0x1DAA260 Offset: 0x1DAA361 VA: 0x1DAA260
	private void RodMenuPrepare() { }

	// RVA: 0x1DAA2E0 Offset: 0x1DAA3E1 VA: 0x1DAA2E0
	private void UnitMenuPrepare() { }

	// RVA: 0x1DAA370 Offset: 0x1DAA471 VA: 0x1DAA370
	private void ItemMenuPrepare() { }

	// RVA: 0x1DAA410 Offset: 0x1DAA511 VA: 0x1DAA410
	private void EnchantMenuPrepare() { }

	// RVA: 0x1DAA4B0 Offset: 0x1DAA5B1 VA: 0x1DAA4B0
	private void CreateBindAttack() { }

	// RVA: 0x1DAA640 Offset: 0x1DAA741 VA: 0x1DAA640
	private void CreateBindEngageAttack() { }

	// RVA: 0x1DAA700 Offset: 0x1DAA801 VA: 0x1DAA700
	private void CreateBindEngageCharge() { }

	// RVA: 0x1DAA7C0 Offset: 0x1DAA8C1 VA: 0x1DAA7C0
	private void CreateBindEngageWait() { }

	// RVA: 0x1DAA880 Offset: 0x1DAA981 VA: 0x1DAA880
	private void CreateBindEngageRewarp() { }

	// RVA: 0x1DAA940 Offset: 0x1DAAA41 VA: 0x1DAA940
	private void CreateBindEngageRod() { }

	// RVA: 0x1DAAA00 Offset: 0x1DAAB01 VA: 0x1DAAA00
	private void PreItemMenuTrade() { }

	// RVA: 0x1DAAA80 Offset: 0x1DAAB81 VA: 0x1DAAA80
	private void PostItemMenuTrade() { }

	// RVA: 0x1DAABF0 Offset: 0x1DAACF1 VA: 0x1DAABF0
	private void TransporterMenuInitialize() { }

	// RVA: 0x1DAAD30 Offset: 0x1DAAE31 VA: 0x1DAAD30
	private void TransporterMenu() { }

	// RVA: 0x1DAAD40 Offset: 0x1DAAE41 VA: 0x1DAAD40
	private void TransporterMenuFinalize() { }

	// RVA: 0x1DA9250 Offset: 0x1DA9351 VA: 0x1DA9250
	private void ResetTarget() { }

	// RVA: 0x1DAAE30 Offset: 0x1DAAF31 VA: 0x1DAAE30
	private void PostEngage() { }

	// RVA: 0x1DAAFB0 Offset: 0x1DAB0B1 VA: 0x1DAAFB0
	private void UpdatePosition() { }

	// RVA: 0x1DAB040 Offset: 0x1DAB141 VA: 0x1DAB040
	private void GameEndBranch() { }

	// RVA: 0x1DAB290 Offset: 0x1DAB391 VA: 0x1DAB290
	private void MindEncBranch() { }

	// RVA: 0x1DAB380 Offset: 0x1DAB481 VA: 0x1DAB380
	private void AutoTurnEnd() { }

	// RVA: 0x1DAB680 Offset: 0x1DAB781 VA: 0x1DAB680
	private void GodOutAll() { }

	// RVA: 0x1DAB880 Offset: 0x1DAB981 VA: 0x1DAB880
	private void HumanTurnEnd() { }

	// RVA: 0x1D97760 Offset: 0x1D97861 VA: 0x1D97760
	private bool JobIntroDecide(int x, int z, MapSequenceHuman.Label label) { }

	// RVA: 0x1D9E8F0 Offset: 0x1D9E9F1 VA: 0x1D9E8F0
	private bool JobIntroDecide(MapSequenceHuman.Label label) { }

	// RVA: 0x1DABCA0 Offset: 0x1DABDA1 VA: 0x1DABCA0
	private void CreateJobIntro() { }

	// RVA: 0x1DABCB0 Offset: 0x1DABDB1 VA: 0x1DABCB0
	private void JobIntroBranch() { }

	// RVA: 0x1DABD20 Offset: 0x1DABE21 VA: 0x1DABD20
	private void JobIntroKeyHelpRequest() { }

	// RVA: 0x1DABDC0 Offset: 0x1DABEC1 VA: 0x1DABDC0
	private void JobIntroKeyHelpBack() { }

	// RVA: 0x1D99260 Offset: 0x1D99361 VA: 0x1D99260
	private bool CanFocusUnit(Unit unit, Force.Type forceType, Unit skipUnit) { }

	// RVA: 0x1D94CC0 Offset: 0x1D94DC1 VA: 0x1D94CC0
	private Unit GetPickUnit(Unit unit) { }

	// RVA: 0x1D94C70 Offset: 0x1D94D71 VA: 0x1D94C70
	private Unit GetFirstUnit(Force.Type forceType) { }

	// RVA: 0x1D94350 Offset: 0x1D94451 VA: 0x1D94350
	private Unit GetPatrolUnit(int cx, int cz, Force.Type forceType, bool isReverse = False, Unit skipUnit) { }

	// RVA: 0x1DAC000 Offset: 0x1DAC101 VA: 0x1DAC000
	private bool IsGetPatrolUnit(int x, int z, Unit unit, Force.Type forceType, Unit skipUnit) { }

	// RVA: 0x1D93F80 Offset: 0x1D94081 VA: 0x1D93F80
	private Unit GetClosestUnit(int cx, int cz, Force.Type forceType, bool isReverse = False, Unit skipUnit) { }

	// RVA: 0x1D947C0 Offset: 0x1D948C1 VA: 0x1D947C0
	private Unit GetOrderUnit(int cx, int cz, Force.Type forceType, bool isReverse = False, Unit skipUnit) { }

	// RVA: 0x1DAC070 Offset: 0x1DAC171 VA: 0x1DAC070
	private void UpdateMoveImage(Unit unit, MapDeployTemplate.Flag<MapDeploy> weaponFlag) { }

	// RVA: 0x1D99130 Offset: 0x1D99231 VA: 0x1D99130
	private void FreeCursorSetMoveImage(Unit unit) { }

	// RVA: 0x1D987F0 Offset: 0x1D988F1 VA: 0x1D987F0
	private bool UnitInfoTick() { }

	// RVA: 0x1D98B50 Offset: 0x1D98C51 VA: 0x1D98B50
	private bool DangerOneTick() { }

	// RVA: 0x1D99140 Offset: 0x1D99241 VA: 0x1D99140
	private void MapNavigationTick() { }

	// RVA: 0x1DAC340 Offset: 0x1DAC441 VA: 0x1DAC340
	private void ShowInfo() { }

	// RVA: 0x1DAC440 Offset: 0x1DAC541 VA: 0x1DAC440
	private void HideInfo() { }

	// RVA: 0x1DAC630 Offset: 0x1DAC731 VA: 0x1DAC630
	private void HidePanel() { }

	// RVA: 0x1DAC740 Offset: 0x1DAC841 VA: 0x1DAC740
	private void UpdateInfo() { }

	// RVA: 0x1DAC7A0 Offset: 0x1DAC8A1 VA: 0x1DAC7A0
	private void ShowMinimap() { }

	// RVA: 0x1DAC7B0 Offset: 0x1DAC8B1 VA: 0x1DAC7B0
	private void HideMinimap() { }

	// RVA: 0x1DAC7C0 Offset: 0x1DAC8C1 VA: 0x1DAC7C0
	private void ShowDamageInfo() { }

	// RVA: 0x1DA5890 Offset: 0x1DA5991 VA: 0x1DA5890
	private void HideDamageInfo() { }

	// RVA: 0x1DAC7D0 Offset: 0x1DAC8D1 VA: 0x1DAC7D0
	private void HideInfoExceptUnitInfo() { }

	// RVA: 0x1DAC840 Offset: 0x1DAC941 VA: 0x1DAC840
	public void JumpForRemove(Unit unit) { }

	// RVA: 0x1DAC9D0 Offset: 0x1DACAD1 VA: 0x1DAC9D0
	public void JumpForRemagic(Unit unit) { }

	// RVA: 0x1D95D90 Offset: 0x1D95E91 VA: 0x1D95D90
	private void SetActiveUnit(Unit target, bool isPickup) { }

	// RVA: 0x1D9B0F0 Offset: 0x1D9B1F1 VA: 0x1D9B0F0
	private void UpdateUnitInfo(bool isUpdateKeyHelp = True) { }

	// RVA: 0x1D9CCD0 Offset: 0x1D9CDD1 VA: 0x1D9CCD0
	private void UpdateUnitInfo(int x, int z, bool isUpdateKeyHelp = True) { }

	// RVA: 0x1DACBA0 Offset: 0x1DACCA1 VA: 0x1DACBA0
	private void UnitInfoInPickCursor(int x, int z) { }

	// RVA: 0x1DA1850 Offset: 0x1DA1951 VA: 0x1DA1850
	private void HideUnitInfoCharaImage() { }

	// RVA: 0x1DAD270 Offset: 0x1DAD371 VA: 0x1DAD270
	private void ShowUnitInfoCharaImage() { }

	// RVA: 0x1D9FC70 Offset: 0x1D9FD71 VA: 0x1D9FC70
	private void UnitInfoForPickFreeCursor() { }

	// RVA: 0x1DACAF0 Offset: 0x1DACBF1 VA: 0x1DACAF0
	private void KeyHelpInFreeCursor(Unit unit) { }

	// RVA: 0x1DAD2D0 Offset: 0x1DAD3D1 VA: 0x1DAD2D0
	private MapKeyHelp.Types GetPickKeyHelpType(Unit mindUnit, bool isDetail, bool isWeaponChange) { }

	// RVA: 0x1DA00C0 Offset: 0x1DA01C1 VA: 0x1DA00C0
	private void KeyHelpInPickCursor() { }

	// RVA: 0x1DACE60 Offset: 0x1DACF61 VA: 0x1DACE60
	private void KeyHelpInPickCursor(int x, int z) { }

	// RVA: 0x1DAD3C0 Offset: 0x1DAD4C1 VA: 0x1DAD3C0
	private void PickEngageBranch() { }

	// RVA: 0x1D99A10 Offset: 0x1D99B11 VA: 0x1D99A10
	private void KeyHelpHide() { }

	// RVA: 0x1D962F0 Offset: 0x1D963F1 VA: 0x1D962F0
	private void UpdateTerrainInfo() { }

	// RVA: 0x1DAD130 Offset: 0x1DAD231 VA: 0x1DAD130
	private void UpdateTerrainInfo(int x, int z) { }

	// RVA: 0x1DA97C0 Offset: 0x1DA98C1 VA: 0x1DA97C0
	private void UpdateLeftTerrainInfo(int x, int z) { }

	// RVA: 0x1DABE50 Offset: 0x1DABF51 VA: 0x1DABE50
	public static int GetUnitIndexFromImage(int x, int z) { }

	// RVA: 0x1DAD500 Offset: 0x1DAD601 VA: 0x1DAD500
	public void DirectAttackStart() { }

	// RVA: 0x1DAD590 Offset: 0x1DAD691 VA: 0x1DAD590
	public void DirectAttackWait() { }

	// RVA: 0x1DAD640 Offset: 0x1DAD741 VA: 0x1DAD640
	public void DirectAttackDecide() { }

	// RVA: 0x1D976E0 Offset: 0x1D977E1 VA: 0x1D976E0
	private void CursorSound() { }

	// RVA: 0x1DAE9A0 Offset: 0x1DAEAA1 VA: 0x1DAE9A0
	private void EngageRewarpPrepare() { }

	// RVA: 0x1DAEEA0 Offset: 0x1DAEFA1 VA: 0x1DAEEA0
	private void EngageRewarpCancel() { }

	// RVA: 0x1DAF060 Offset: 0x1DAF161 VA: 0x1DAF060
	private void EngageBeforeEvent() { }

	// RVA: 0x1DAF100 Offset: 0x1DAF201 VA: 0x1DAF100
	private void EngageAfterEvent() { }

	// RVA: 0x1D93A30 Offset: 0x1D93B31 VA: 0x1D93A30
	private void MapEnd() { }

	// RVA: 0x1DAF1A0 Offset: 0x1DAF2A1 VA: 0x1DAF1A0
	public void Restart(GameUserRestartData.Targtes target) { }

	// RVA: 0x1DAF2B0 Offset: 0x1DAF3B1 VA: 0x1DAF2B0
	private void SaveAndSuspendMenuBefore() { }

	// RVA: 0x1DAF440 Offset: 0x1DAF541 VA: 0x1DAF440
	private void SaveAndSuspendMenuAfter() { }

	// RVA: 0x1DAF610 Offset: 0x1DAF711 VA: 0x1DAF610
	private void MindPrepare() { }

	// RVA: 0x1D95640 Offset: 0x1D95741 VA: 0x1D95640
	private void UpdateDamageForecast() { }

	// RVA: 0x1DAF7E0 Offset: 0x1DAF8E1 VA: 0x1DAF7E0
	public int get_OldCursorX() { }

	// RVA: 0x1DAF7F0 Offset: 0x1DAF8F1 VA: 0x1DAF7F0
	public int get_OldCursorZ() { }

	// RVA: 0x1DAF800 Offset: 0x1DAF901 VA: 0x1DAF800
	public void set_EngageX(int value) { }

	// RVA: 0x1DAF810 Offset: 0x1DAF911 VA: 0x1DAF810
	public void set_EngageZ(int value) { }

	// RVA: 0x1DAF820 Offset: 0x1DAF921 VA: 0x1DAF820
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1DAF830 Offset: 0x1DAF931 VA: 0x1DAF830
	public static void CreateBind(ProcInst super, bool isResume) { }
}

