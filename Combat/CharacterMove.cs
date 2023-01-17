// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273EA0 Offset: 0x273FA1 VA: 0x273EA0
public sealed class CharacterMove : MonoBehaviour // TypeDefIndex: 8620
{
	// Fields
	private Character _cp; // 0x18
	[HeaderAttribute] // RVA: 0x282860 Offset: 0x282961 VA: 0x282860
	public float MaxRunSpeedKMPS; // 0x20
	[HeaderAttribute] // RVA: 0x2828A0 Offset: 0x2829A1 VA: 0x2828A0
	public float TimeToMaxSpeed; // 0x24
	[HeaderAttribute] // RVA: 0x2828E0 Offset: 0x2829E1 VA: 0x2828E0
	public float TimeToZero; // 0x28
	[RangeAttribute] // RVA: 0x282920 Offset: 0x282A21 VA: 0x282920
	[HeaderAttribute] // RVA: 0x282920 Offset: 0x282A21 VA: 0x282920
	public float HeightSmoothRatio; // 0x2C
	[HeaderAttribute] // RVA: 0x282980 Offset: 0x282A81 VA: 0x282980
	public float StairInterpolationLimit; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2829C0 Offset: 0x282AC1 VA: 0x2829C0
	private float <MaxRunSpeed>k__BackingField; // 0x34
	private CharacterMove.State m_State; // 0x38
	private FXZ m_Goal; // 0x3C
	private float m_Velocity; // 0x44
	private float m_PrevY; // 0x48
	private CharacterJump m_Jump; // 0x50

	// Properties
	private Character CP { get; }
	public float MaxRunSpeed { get; set; }
	public float Acceleration { get; }
	public float Deceleration { get; }

	// Methods

	// RVA: 0x29B3260 Offset: 0x29B3361 VA: 0x29B3260
	private Character get_CP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF00 Offset: 0x2AB001 VA: 0x2AAF00
	// RVA: 0x29B3320 Offset: 0x29B3421 VA: 0x29B3320
	public float get_MaxRunSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF10 Offset: 0x2AB011 VA: 0x2AAF10
	// RVA: 0x29B3330 Offset: 0x29B3431 VA: 0x29B3330
	private void set_MaxRunSpeed(float value) { }

	// RVA: 0x29B3340 Offset: 0x29B3441 VA: 0x29B3340
	public void SetMaxRunSpeed(float value) { }

	// RVA: 0x29B3350 Offset: 0x29B3451 VA: 0x29B3350
	public float get_Acceleration() { }

	// RVA: 0x29B3360 Offset: 0x29B3461 VA: 0x29B3360
	public float get_Deceleration() { }

	// RVA: 0x29B3370 Offset: 0x29B3471 VA: 0x29B3370
	public void Stabilize() { }

	// RVA: 0x29B3380 Offset: 0x29B3481 VA: 0x29B3380
	private void Awake() { }

	// RVA: 0x29B3410 Offset: 0x29B3511 VA: 0x29B3410
	private void LateUpdate() { }

	// RVA: 0x29B3630 Offset: 0x29B3731 VA: 0x29B3630
	public void WarpTo(FXZ goal) { }

	// RVA: 0x29B36F0 Offset: 0x29B37F1 VA: 0x29B36F0
	public void RunTo(FXZ goal, CharacterMove.StartMode mode = 0) { }

	// RVA: 0x29B3820 Offset: 0x29B3921 VA: 0x29B3820
	public void RunTo(FXZ goal, bool fromMaxSpeed) { }

	// RVA: 0x29B3830 Offset: 0x29B3931 VA: 0x29B3830
	public void JumpTo(Vector3 goal, float duration, bool isGrounding) { }

	// RVA: 0x29B38A0 Offset: 0x29B39A1 VA: 0x29B38A0
	public void JumpTo(Transform target, AnimationEvent ev) { }

	// RVA: 0x29B3950 Offset: 0x29B3A51 VA: 0x29B3950
	public void Brake() { }

	// RVA: 0x29B3A50 Offset: 0x29B3B51 VA: 0x29B3A50
	public void Stop() { }

	// RVA: 0x29B34C0 Offset: 0x29B35C1 VA: 0x29B34C0
	private void UpdateMoving() { }

	// RVA: 0x29B3BD0 Offset: 0x29B3CD1 VA: 0x29B3BD0
	private void UpdateRun() { }

	// RVA: 0x29B3CC0 Offset: 0x29B3DC1 VA: 0x29B3CC0
	private void UpdateRunBrake() { }

	// RVA: 0x29B3DB0 Offset: 0x29B3EB1 VA: 0x29B3DB0
	private float AdvanceTimeAndGetDT() { }

	// RVA: 0x29B3B40 Offset: 0x29B3C41 VA: 0x29B3B40
	private void UpdateJump() { }

	// RVA: 0x29B3E80 Offset: 0x29B3F81 VA: 0x29B3E80
	public float CalcTimeToArrive(float dist, bool runMaxSpeed = False) { }

	// RVA: 0x29B3F50 Offset: 0x29B4051 VA: 0x29B3F50
	public void .ctor() { }
}

