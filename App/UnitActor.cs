// Namespace: App
[ExecuteInEditMode] // RVA: 0x274D80 Offset: 0x274E81 VA: 0x274D80
public abstract class UnitActor : MonoBehaviour // TypeDefIndex: 8976
{
	// Fields
	private GameObject m_Models; // 0x18
	private UnitModel m_UnitModel; // 0x20
	private UnitModel m_GodModel; // 0x28
	private GameObject m_Effect; // 0x30
	private Unit m_Unit; // 0x38
	private UnitActor.StatusField m_Status; // 0x40
	private BindHolder m_Binder; // 0x48
	private Vector3 m_Position; // 0x50
	private InterpolatorRotation m_Rotation; // 0x60
	private Quaternion m_SlopeRotation; // 0x68
	private Vector3 m_SlopeOffset; // 0x78
	private InterpolatorVector3 m_Moving; // 0x88
	private const int SHAKE_COUNT = 16;
	private int m_ShakeCount; // 0x90
	private float m_ShakeScale; // 0x94
	private Vector3 m_ShakeOffset; // 0x98

	// Properties
	public Unit Unit { get; set; }
	public UnitModel UnitModel { get; }
	public UnitModel GodModel { get; }
	public bool IsVisible { get; }
	public AssetTable.Sound Sound { get; }
	public Vector3 Position { get; set; }
	public bool IsMoving { get; }
	public int CellX { get; }
	public int CellZ { get; }
	public Vector3 SizeOffset { get; }
	public int BmapSize { get; }
	public Vector3 Direction { get; }

	// Methods

	// RVA: 0x23CBB80 Offset: 0x23CBC81 VA: 0x23CBB80
	public Unit get_Unit() { }

	// RVA: 0x23CBB90 Offset: 0x23CBC91 VA: 0x23CBB90
	public void set_Unit(Unit value) { }

	// RVA: 0x23CBBA0 Offset: 0x23CBCA1 VA: 0x23CBBA0
	public UnitModel get_UnitModel() { }

	// RVA: 0x23CBBB0 Offset: 0x23CBCB1 VA: 0x23CBBB0
	public UnitModel get_GodModel() { }

	// RVA: 0x23CBBC0 Offset: 0x23CBCC1 VA: 0x23CBBC0
	public bool get_IsVisible() { }

	// RVA: 0x23CBC70 Offset: 0x23CBD71 VA: 0x23CBC70
	public AssetTable.Sound get_Sound() { }

	// RVA: 0x23CBD50 Offset: 0x23CBE51 VA: 0x23CBD50
	public Vector3 get_Position() { }

	// RVA: 0x23CBD60 Offset: 0x23CBE61 VA: 0x23CBD60
	public void set_Position(Vector3 value) { }

	// RVA: 0x23CCA80 Offset: 0x23CCB81 VA: 0x23CCA80
	public Vector3 GetCellCenterPosition() { }

	// RVA: 0x23CD6C0 Offset: 0x23CD7C1 VA: 0x23CD6C0
	private Vector3 GetTargetPosition() { }

	// RVA: 0x23CD740 Offset: 0x23CD841 VA: 0x23CD740
	public int GetTargetX() { }

	// RVA: 0x23CD830 Offset: 0x23CD931 VA: 0x23CD830
	public int GetTargetZ() { }

	// RVA: 0x23CD920 Offset: 0x23CDA21 VA: 0x23CD920
	public bool get_IsMoving() { }

	// RVA: 0x23CD940 Offset: 0x23CDA41 VA: 0x23CD940
	public void Move(Vector3 pos, float time) { }

	// RVA: 0x23CD9C0 Offset: 0x23CDAC1 VA: 0x23CD9C0
	public Vector3 GetStartPos() { }

	// RVA: 0x23CDA40 Offset: 0x23CDB41 VA: 0x23CDA40
	public Vector3 GetGoalPos() { }

	// RVA: 0x23CDAC0 Offset: 0x23CDBC1 VA: 0x23CDAC0
	public float GetRate() { }

	// RVA: 0x23CDAE0 Offset: 0x23CDBE1 VA: 0x23CDAE0
	public static AssetTable.Modes GetAssetMode() { }

	// RVA: 0x23CDB70 Offset: 0x23CDC71 VA: 0x23CDB70
	private static GodUnit GetGodUnit(Unit unit) { }

	// RVA: 0x23CDC20 Offset: 0x23CDD21 VA: 0x23CDC20
	private static Unit GetHauntUnit(Unit unit) { }

	// RVA: 0x23CDD40 Offset: 0x23CDE41 VA: 0x23CDD40
	private void TryCreateUnitModel() { }

	// RVA: 0x23CDE10 Offset: 0x23CDF11 VA: 0x23CDE10
	private void TryCreateGodUnitModel(bool reverse) { }

	// RVA: 0x23CDF60 Offset: 0x23CE061 VA: 0x23CDF60
	public bool LoadAsync(string[] conditions) { }

	// RVA: 0x23CE580 Offset: 0x23CE681 VA: 0x23CE580
	public void Unload() { }

	// RVA: 0x23CE610 Offset: 0x23CE711 VA: 0x23CE610
	public void Awake() { }

	// RVA: 0x23CE6C0 Offset: 0x23CE7C1 VA: 0x23CE6C0
	public void PreTick() { }

	// RVA: 0x23D0A30 Offset: 0x23D0B31 VA: 0x23D0A30
	public void PostTick() { }

	// RVA: 0x23D0A90 Offset: 0x23D0B91 VA: 0x23D0A90
	private void UpdateEffect() { }

	// RVA: 0x23D0D60 Offset: 0x23D0E61 VA: 0x23D0D60
	public bool IsLoading() { }

	// RVA: 0x23D0E60 Offset: 0x23D0F61 VA: 0x23D0E60
	public void UpdateLoading() { }

	// RVA: 0x23D0EB0 Offset: 0x23D0FB1 VA: 0x23D0EB0
	public void Reload() { }

	// RVA: 0x23D0F10 Offset: 0x23D1011 VA: 0x23D0F10
	public void UpdateStatus() { }

	// RVA: 0x23D1130 Offset: 0x23D1231 VA: 0x23D1130
	private void UpdateMoving() { }

	// RVA: 0x23D2D80 Offset: 0x23D2E81 VA: 0x23D2D80
	private void UpdateRotate() { }

	// RVA: 0x23D2FB0 Offset: 0x23D30B1 VA: 0x23D2FB0
	private void UpdateShake() { }

	// RVA: 0x23D30C0 Offset: 0x23D31C1 VA: 0x23D30C0
	public UnitAnim.Types GetAnim() { }

	// RVA: 0x23D3170 Offset: 0x23D3271 VA: 0x23D3170
	public UnitAnim.Types GetIdleAnim() { }

	// RVA: 0x23D3220 Offset: 0x23D3321 VA: 0x23D3220
	public Animator GetAnimator() { }

	// RVA: 0x23D32D0 Offset: 0x23D33D1 VA: 0x23D32D0
	public void SetIdleAnim(UnitAnim.Types type, UnitAnim.Times time = 2) { }

	// RVA: 0x23D33E0 Offset: 0x23D34E1 VA: 0x23D33E0
	public void SetIdleAnim(UnitSequence.Action action, UnitAnim.Times time = 2) { }

	// RVA: 0x23D33F0 Offset: 0x23D34F1 VA: 0x23D33F0
	public void PlayAction(UnitSequence.Action action) { }

	// RVA: 0x23D3730 Offset: 0x23D3831 VA: 0x23D3730
	public void PlayCancel(UnitSequence.Action action) { }

	// RVA: 0x23D37C0 Offset: 0x23D38C1 VA: 0x23D37C0
	public bool TryPlayAction(UnitSequence.Action action) { }

	// RVA: 0x23D2CB0 Offset: 0x23D2DB1 VA: 0x23D2CB0
	public void ResetIdleAnim() { }

	// RVA: 0x23CE4D0 Offset: 0x23CE5D1 VA: 0x23CE4D0
	public void PlayIdle(UnitAnim.Times time = 2) { }

	// RVA: 0x23D3960 Offset: 0x23D3A61 VA: 0x23D3960
	public void PlayIdle(UnitSequence.Action action, UnitAnim.Times time = 2) { }

	// RVA: 0x23D3460 Offset: 0x23D3561 VA: 0x23D3460
	public void PlayAnim(UnitAnim.Types type, UnitAnim.Times time = 2) { }

	// RVA: 0x23D3A20 Offset: 0x23D3B21 VA: 0x23D3A20
	private bool PlaySkill(SkillData skill, EffectSequence.Kind kind) { }

	// RVA: 0x23D3C30 Offset: 0x23D3D31 VA: 0x23D3C30
	private bool PlaySkill(SkillData skill, EffectSequence.Kind kind, Vector3 position, Quaternion rotation, bool isCaption) { }

	// RVA: 0x23D3ED0 Offset: 0x23D3FD1 VA: 0x23D3ED0
	public bool PlayActiveSkill(SkillData skill) { }

	// RVA: 0x23D3EE0 Offset: 0x23D3FE1 VA: 0x23D3EE0
	public bool PlayShootSkill(SkillData skill) { }

	// RVA: 0x23D3EF0 Offset: 0x23D3FF1 VA: 0x23D3EF0
	public bool PlayShootSkill(SkillData skill, Vector3 position, Quaternion rotation) { }

	// RVA: 0x23D3F00 Offset: 0x23D4001 VA: 0x23D3F00
	public bool PlayEffect(string eid) { }

	// RVA: 0x23D3F90 Offset: 0x23D4091 VA: 0x23D3F90
	public bool PlayEffect(EffectData data) { }

	// RVA: 0x23D3DF0 Offset: 0x23D3EF1 VA: 0x23D3DF0
	public bool PlayEffect(EffectData data, Vector3 position, Quaternion rotation) { }

	// RVA: 0x23D40E0 Offset: 0x23D41E1 VA: 0x23D40E0
	public void PlayEngageCount(Vector3 start, Vector3 goal, int count, float delayTime) { }

	// RVA: 0x23D3B00 Offset: 0x23D3C01 VA: 0x23D3B00
	public Vector3 GetEffectPosition() { }

	// RVA: 0x23D3BC0 Offset: 0x23D3CC1 VA: 0x23D3BC0
	public Quaternion GetEffectRotation() { }

	// RVA: 0x23D4260 Offset: 0x23D4361 VA: 0x23D4260
	public void PlayHitSkill(SkillData skill) { }

	// RVA: 0x23D4330 Offset: 0x23D4431 VA: 0x23D4330
	public void SetSpeed(float speed) { }

	// RVA: 0x23D4440 Offset: 0x23D4541 VA: 0x23D4440
	public float GetSpeed() { }

	// RVA: 0x23D44F0 Offset: 0x23D45F1 VA: 0x23D44F0
	public void ActionBind() { }

	// RVA: 0x23D4580 Offset: 0x23D4681 VA: 0x23D4580
	public void ActionUnbind() { }

	// RVA: 0x23D4610 Offset: 0x23D4711 VA: 0x23D4610
	public bool IsActionBind() { }

	// RVA: 0x23D4630 Offset: 0x23D4731 VA: 0x23D4630
	public void SetStatus(UnitActor.Status status) { }

	// RVA: 0x23D46A0 Offset: 0x23D47A1 VA: 0x23D46A0
	public void ClearStatus(UnitActor.Status status) { }

	// RVA: 0x23D4710 Offset: 0x23D4811 VA: 0x23D4710
	public bool CheckStatus(UnitActor.Status status) { }

	// RVA: 0x23CBD70 Offset: 0x23CBE71 VA: 0x23CBD70
	private void CommitPosition() { }

	// RVA: 0x23D2EE0 Offset: 0x23D2FE1 VA: 0x23D2EE0
	private void CommitRotation() { }

	// RVA: 0x23D4780 Offset: 0x23D4881 VA: 0x23D4780
	public void UpdatePosition() { }

	// RVA: 0x23D5430 Offset: 0x23D5531 VA: 0x23D5430
	public int get_CellX() { }

	// RVA: 0x23D54E0 Offset: 0x23D55E1 VA: 0x23D54E0
	public int get_CellZ() { }

	// RVA: 0x23D5590 Offset: 0x23D5691 VA: 0x23D5590
	public Vector3 get_SizeOffset() { }

	// RVA: 0x23D55F0 Offset: 0x23D56F1 VA: 0x23D55F0
	public int get_BmapSize() { }

	// RVA: 0x23D5610 Offset: 0x23D5711 VA: 0x23D5610
	public void Rotation(float angle) { }

	// RVA: 0x23D5750 Offset: 0x23D5851 VA: 0x23D5750
	public void Rotation(Dir.Type dir) { }

	// RVA: 0x23D5780 Offset: 0x23D5881 VA: 0x23D5780
	private static float Cross(Vector2 v1, Vector2 v2) { }

	// RVA: 0x23D5790 Offset: 0x23D5891 VA: 0x23D5790
	public void Rotation(Vector3 dir) { }

	// RVA: 0x23D5950 Offset: 0x23D5A51 VA: 0x23D5950
	public void Rotation(int x, int z) { }

	// RVA: 0x23D74A0 Offset: 0x23D75A1 VA: 0x23D74A0
	public void Rotation(Unit target) { }

	// RVA: 0x23D7920 Offset: 0x23D7A21 VA: 0x23D7920
	public void SetSlope(Quaternion rotation, Vector3 offset) { }

	// RVA: 0x23D5730 Offset: 0x23D5831 VA: 0x23D5730
	private static float GetAngleLength(float current, float target) { }

	// RVA: 0x23D7960 Offset: 0x23D7A61 VA: 0x23D7960
	private bool IsRider() { }

	// RVA: 0x23D7980 Offset: 0x23D7A81 VA: 0x23D7980
	public float GetFrontAngle() { }

	// RVA: 0x23D7A00 Offset: 0x23D7B01 VA: 0x23D7A00
	public float GetFrontRange() { }

	// RVA: 0x23D7A80 Offset: 0x23D7B81 VA: 0x23D7A80
	private float GetFrontDelta(float angle, float range) { }

	// RVA: 0x23D7BC0 Offset: 0x23D7CC1 VA: 0x23D7BC0
	private static Vector3 GetDirection(float angle) { }

	// RVA: 0x23D3570 Offset: 0x23D3671 VA: 0x23D3570
	private void RotationFixed() { }

	// RVA: 0x23D7C10 Offset: 0x23D7D11 VA: 0x23D7C10
	public Vector3 get_Direction() { }

	// RVA: 0x23D3790 Offset: 0x23D3891 VA: 0x23D3790
	public void InstantRotation() { }

	// RVA: 0x23D7CB0 Offset: 0x23D7DB1 VA: 0x23D7CB0
	public void Shake(float scale = 1) { }

	// RVA: 0x23D7CC0 Offset: 0x23D7DC1 VA: 0x23D7CC0
	public float GetAlpha() { }

	// RVA: 0x23D7D70 Offset: 0x23D7E71 VA: 0x23D7D70
	public void ImpactShine() { }

	// RVA: 0x23D7E20 Offset: 0x23D7F21 VA: 0x23D7E20
	public void HealShine() { }

	// RVA: 0x23D7E70 Offset: 0x23D7F71 VA: 0x23D7E70
	public void SkillShine() { }

	// RVA: 0x23D7DC0 Offset: 0x23D7EC1 VA: 0x23D7DC0
	public void Shine(float time = 0.25) { }

	// RVA: 0x23D7EC0 Offset: 0x23D7FC1 VA: 0x23D7EC0
	public void BrightOn() { }

	// RVA: 0x23D7F10 Offset: 0x23D8011 VA: 0x23D7F10
	public void BrightOff() { }

	// RVA: 0x23D7F60 Offset: 0x23D8061 VA: 0x23D7F60
	public void FadeIn(float time = 0.25) { }

	// RVA: 0x23D7FC0 Offset: 0x23D80C1 VA: 0x23D7FC0
	public void FadeOut(float time = 0.25) { }

	// RVA: 0x23D8020 Offset: 0x23D8121 VA: 0x23D8020
	public void GodIn() { }

	// RVA: 0x23D80B0 Offset: 0x23D81B1 VA: 0x23D80B0
	public void GodOut() { }

	// RVA: 0x23D8140 Offset: 0x23D8241 VA: 0x23D8140
	private static bool IsOutSight(int x, int z, Dir.Type[] routes) { }

	// RVA: 0x23D8280 Offset: 0x23D8381 VA: 0x23D8280
	private static bool IsMoveSkip(int x, int z, Dir.Type[] routes, MapMoveFlag flag) { }

	// RVA: 0x23D8310 Offset: 0x23D8411 VA: 0x23D8310
	public void MoveRoute(ProcInst super, Dir.Type[] routes, MapMoveFlag flag = 0) { }

	// RVA: 0x23D8330 Offset: 0x23D8431 VA: 0x23D8330
	public void MoveRoute(ProcInst super, Dir.Type[] routes, int fromX, int fromZ, MapMoveFlag flag = 0) { }

	// RVA: 0x23D84A0 Offset: 0x23D85A1 VA: 0x23D84A0
	public void MoveRouteInstant(Dir.Type[] routes, MapMoveFlag flag = 0) { }

	// RVA: 0x23D8400 Offset: 0x23D8501 VA: 0x23D8400
	public void MoveRouteInstant(Dir.Type[] routes, int fromX, int fromZ, MapMoveFlag flag) { }

	// RVA: 0x23D84C0 Offset: 0x23D85C1 VA: 0x23D84C0
	public void UpdateMoved(MapMoveFlag flag = 0) { }

	// RVA: 0x23D84D0 Offset: 0x23D85D1 VA: 0x23D84D0
	protected void .ctor() { }
}

