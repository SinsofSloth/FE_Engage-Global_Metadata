// Namespace: Combat
public class CameraPositionData : MonoBehaviour // TypeDefIndex: 8558
{
	// Fields
	public CameraPositionData.CameraShakeSettings ShakeSetting; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x281B50 Offset: 0x281C51 VA: 0x281B50
	private bool <IsReverse>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x281B60 Offset: 0x281C61 VA: 0x281B60
	private Vector3 <BattleCenter>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x281B70 Offset: 0x281C71 VA: 0x281B70
	private Vector3 <BattleVector>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x281B80 Offset: 0x281C81 VA: 0x281B80
	private Vector3 <BattleNormalVector>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x281B90 Offset: 0x281C91 VA: 0x281B90
	private float <BattleDistance>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x281BA0 Offset: 0x281CA1 VA: 0x281BA0
	private Vector3[] <BasePosition>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x281BB0 Offset: 0x281CB1 VA: 0x281BB0
	private Character[] <CharaArray>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x281BC0 Offset: 0x281CC1 VA: 0x281BC0
	private float[] <m_DeadHeight>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x281BD0 Offset: 0x281CD1 VA: 0x281BD0
	private float[] <UnitTall>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x281BE0 Offset: 0x281CE1 VA: 0x281BE0
	private CharacterJoint[] <JointList>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x281BF0 Offset: 0x281CF1 VA: 0x281BF0
	private bool[] <IsBeforeDragonChange>k__BackingField; // 0x78
	private GameParam.Holder m_DrawCount; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x281C00 Offset: 0x281D01 VA: 0x281C00
	private readonly List<Vector3>[] <LookAtStacks>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x281C10 Offset: 0x281D11 VA: 0x281C10
	private readonly LineRenderer[] <Lines>k__BackingField; // 0x90

	// Properties
	public bool IsReverse { get; set; }
	public Vector3 BattleCenter { get; set; }
	public Vector3 BattleVector { get; set; }
	public Vector3 BattleNormalVector { get; set; }
	public float BattleDistance { get; set; }
	public Vector3[] BasePosition { get; set; }
	public Character[] CharaArray { get; set; }
	private float[] m_DeadHeight { get; set; }
	private float[] UnitTall { get; set; }
	public CharacterJoint[] JointList { get; set; }
	public bool[] IsBeforeDragonChange { get; set; }
	public bool IsInitialized { get; }
	public bool IsCharacterLoadFinished { get; }
	private List<Vector3>[] LookAtStacks { get; }
	private LineRenderer[] Lines { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9960 Offset: 0x2A9A61 VA: 0x2A9960
	// RVA: 0x29A5980 Offset: 0x29A5A81 VA: 0x29A5980
	public bool get_IsReverse() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9970 Offset: 0x2A9A71 VA: 0x2A9970
	// RVA: 0x29A5990 Offset: 0x29A5A91 VA: 0x29A5990
	private void set_IsReverse(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9980 Offset: 0x2A9A81 VA: 0x2A9980
	// RVA: 0x29A59A0 Offset: 0x29A5AA1 VA: 0x29A59A0
	public Vector3 get_BattleCenter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9990 Offset: 0x2A9A91 VA: 0x2A9990
	// RVA: 0x29A59B0 Offset: 0x29A5AB1 VA: 0x29A59B0
	private void set_BattleCenter(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A99A0 Offset: 0x2A9AA1 VA: 0x2A99A0
	// RVA: 0x29A59C0 Offset: 0x29A5AC1 VA: 0x29A59C0
	public Vector3 get_BattleVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A99B0 Offset: 0x2A9AB1 VA: 0x2A99B0
	// RVA: 0x29A59D0 Offset: 0x29A5AD1 VA: 0x29A59D0
	private void set_BattleVector(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A99C0 Offset: 0x2A9AC1 VA: 0x2A99C0
	// RVA: 0x29A59E0 Offset: 0x29A5AE1 VA: 0x29A59E0
	public Vector3 get_BattleNormalVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A99D0 Offset: 0x2A9AD1 VA: 0x2A99D0
	// RVA: 0x29A59F0 Offset: 0x29A5AF1 VA: 0x29A59F0
	private void set_BattleNormalVector(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A99E0 Offset: 0x2A9AE1 VA: 0x2A99E0
	// RVA: 0x29A5A00 Offset: 0x29A5B01 VA: 0x29A5A00
	public float get_BattleDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A99F0 Offset: 0x2A9AF1 VA: 0x2A99F0
	// RVA: 0x29A5A10 Offset: 0x29A5B11 VA: 0x29A5A10
	private void set_BattleDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A00 Offset: 0x2A9B01 VA: 0x2A9A00
	// RVA: 0x29A5A20 Offset: 0x29A5B21 VA: 0x29A5A20
	public Vector3[] get_BasePosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A10 Offset: 0x2A9B11 VA: 0x2A9A10
	// RVA: 0x29A5A30 Offset: 0x29A5B31 VA: 0x29A5A30
	private void set_BasePosition(Vector3[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A20 Offset: 0x2A9B21 VA: 0x2A9A20
	// RVA: 0x29A5A40 Offset: 0x29A5B41 VA: 0x29A5A40
	public Character[] get_CharaArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A30 Offset: 0x2A9B31 VA: 0x2A9A30
	// RVA: 0x29A5A50 Offset: 0x29A5B51 VA: 0x29A5A50
	private void set_CharaArray(Character[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A40 Offset: 0x2A9B41 VA: 0x2A9A40
	// RVA: 0x29A5A60 Offset: 0x29A5B61 VA: 0x29A5A60
	private float[] get_m_DeadHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A50 Offset: 0x2A9B51 VA: 0x2A9A50
	// RVA: 0x29A5A70 Offset: 0x29A5B71 VA: 0x29A5A70
	private void set_m_DeadHeight(float[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A60 Offset: 0x2A9B61 VA: 0x2A9A60
	// RVA: 0x29A5A80 Offset: 0x29A5B81 VA: 0x29A5A80
	private float[] get_UnitTall() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A70 Offset: 0x2A9B71 VA: 0x2A9A70
	// RVA: 0x29A5A90 Offset: 0x29A5B91 VA: 0x29A5A90
	private void set_UnitTall(float[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A80 Offset: 0x2A9B81 VA: 0x2A9A80
	// RVA: 0x29A5AA0 Offset: 0x29A5BA1 VA: 0x29A5AA0
	public CharacterJoint[] get_JointList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9A90 Offset: 0x2A9B91 VA: 0x2A9A90
	// RVA: 0x29A5AB0 Offset: 0x29A5BB1 VA: 0x29A5AB0
	private void set_JointList(CharacterJoint[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9AA0 Offset: 0x2A9BA1 VA: 0x2A9AA0
	// RVA: 0x29A5AC0 Offset: 0x29A5BC1 VA: 0x29A5AC0
	public bool[] get_IsBeforeDragonChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9AB0 Offset: 0x2A9BB1 VA: 0x2A9AB0
	// RVA: 0x29A5AD0 Offset: 0x29A5BD1 VA: 0x29A5AD0
	public void set_IsBeforeDragonChange(bool[] value) { }

	// RVA: 0x29A5AE0 Offset: 0x29A5BE1 VA: 0x29A5AE0
	public bool get_IsInitialized() { }

	// RVA: 0x299BD20 Offset: 0x299BE21 VA: 0x299BD20
	public bool get_IsCharacterLoadFinished() { }

	// RVA: 0x29A5140 Offset: 0x29A5241 VA: 0x29A5140
	public void LateUpdate() { }

	// RVA: 0x299DAC0 Offset: 0x299DBC1 VA: 0x299DAC0
	public void UpdateImpl() { }

	// RVA: 0x29A40E0 Offset: 0x29A41E1 VA: 0x29A40E0
	public void Initialize(CombatRecord record) { }

	// RVA: 0x29A4BA0 Offset: 0x29A4CA1 VA: 0x29A4BA0
	public void Initialize(Character[] chara) { }

	// RVA: 0x299A660 Offset: 0x299A761 VA: 0x299A660
	public Vector3 GetCenter(int side) { }

	// RVA: 0x29A6380 Offset: 0x29A6481 VA: 0x29A6380
	public float GeTall(int side) { }

	// RVA: 0x29A6130 Offset: 0x29A6231 VA: 0x29A6130
	private void LoadTall(CombatRecord record) { }

	// RVA: 0x29A6260 Offset: 0x29A6361 VA: 0x29A6260
	private void LoadTall(Character[] charaArray) { }

	// RVA: 0x29A5AF0 Offset: 0x29A5BF1 VA: 0x29A5AF0
	private void LoadJoint() { }

	// RVA: 0x29A5D40 Offset: 0x29A5E41 VA: 0x29A5D40
	private void CulculateInfo(bool isInitialize, CombatRecord record) { }

	// RVA: 0x299B4B0 Offset: 0x299B5B1 VA: 0x299B4B0
	public Vector3 GetJointPos(int side, CameraPositionData.TargetJoint target) { }

	// RVA: 0x299D160 Offset: 0x299D261 VA: 0x299D160
	public Transform GetJoint(int side, CameraPositionData.TargetJoint t) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9AC0 Offset: 0x2A9BC1 VA: 0x2A9AC0
	// RVA: 0x29A63C0 Offset: 0x29A64C1 VA: 0x29A63C0
	private List<Vector3>[] get_LookAtStacks() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9AD0 Offset: 0x2A9BD1 VA: 0x2A9AD0
	// RVA: 0x29A63D0 Offset: 0x29A64D1 VA: 0x29A63D0
	private LineRenderer[] get_Lines() { }

	// RVA: 0x29A63E0 Offset: 0x29A64E1 VA: 0x29A63E0
	public void .ctor() { }
}

