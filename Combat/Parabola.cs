// Namespace: Combat
public sealed class Parabola // TypeDefIndex: 8834
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284810 Offset: 0x284911 VA: 0x284810
	private float <in_Speed>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x284820 Offset: 0x284921 VA: 0x284820
	private float <in_Mass>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x284830 Offset: 0x284931 VA: 0x284830
	private Vector3 <in_StartPos>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x284840 Offset: 0x284941 VA: 0x284840
	private Vector3 <in_EndPos>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x284850 Offset: 0x284951 VA: 0x284850
	private float <in_WeaponLength>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x284860 Offset: 0x284961 VA: 0x284860
	private float <out_FlyingTime>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x284870 Offset: 0x284971 VA: 0x284870
	private Vector3 <out_InitialVelocity>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x284880 Offset: 0x284981 VA: 0x284880
	private Vector3 <out_WorldHitDir>k__BackingField; // 0x44

	// Properties
	public float in_Speed { get; set; }
	public float in_Mass { get; set; }
	public Vector3 in_StartPos { get; set; }
	public Vector3 in_EndPos { get; set; }
	public float in_WeaponLength { get; set; }
	public float out_FlyingTime { get; set; }
	public Vector3 out_InitialVelocity { get; set; }
	public Vector3 out_WorldHitDir { get; set; }
	public Vector3 WorldCentroidOffset { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AD1D0 Offset: 0x2AD2D1 VA: 0x2AD1D0
	// RVA: 0x2365940 Offset: 0x2365A41 VA: 0x2365940
	public float get_in_Speed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD1E0 Offset: 0x2AD2E1 VA: 0x2AD1E0
	// RVA: 0x2365950 Offset: 0x2365A51 VA: 0x2365950
	public void set_in_Speed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD1F0 Offset: 0x2AD2F1 VA: 0x2AD1F0
	// RVA: 0x2365960 Offset: 0x2365A61 VA: 0x2365960
	public float get_in_Mass() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD200 Offset: 0x2AD301 VA: 0x2AD200
	// RVA: 0x2365970 Offset: 0x2365A71 VA: 0x2365970
	public void set_in_Mass(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD210 Offset: 0x2AD311 VA: 0x2AD210
	// RVA: 0x2365980 Offset: 0x2365A81 VA: 0x2365980
	public Vector3 get_in_StartPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD220 Offset: 0x2AD321 VA: 0x2AD220
	// RVA: 0x2365990 Offset: 0x2365A91 VA: 0x2365990
	public void set_in_StartPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD230 Offset: 0x2AD331 VA: 0x2AD230
	// RVA: 0x23659A0 Offset: 0x2365AA1 VA: 0x23659A0
	public Vector3 get_in_EndPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD240 Offset: 0x2AD341 VA: 0x2AD240
	// RVA: 0x23659B0 Offset: 0x2365AB1 VA: 0x23659B0
	public void set_in_EndPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD250 Offset: 0x2AD351 VA: 0x2AD250
	// RVA: 0x23659C0 Offset: 0x2365AC1 VA: 0x23659C0
	public float get_in_WeaponLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD260 Offset: 0x2AD361 VA: 0x2AD260
	// RVA: 0x23659D0 Offset: 0x2365AD1 VA: 0x23659D0
	public void set_in_WeaponLength(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD270 Offset: 0x2AD371 VA: 0x2AD270
	// RVA: 0x23659E0 Offset: 0x2365AE1 VA: 0x23659E0
	public float get_out_FlyingTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD280 Offset: 0x2AD381 VA: 0x2AD280
	// RVA: 0x23659F0 Offset: 0x2365AF1 VA: 0x23659F0
	private void set_out_FlyingTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD290 Offset: 0x2AD391 VA: 0x2AD290
	// RVA: 0x2365A00 Offset: 0x2365B01 VA: 0x2365A00
	public Vector3 get_out_InitialVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD2A0 Offset: 0x2AD3A1 VA: 0x2AD2A0
	// RVA: 0x2365A10 Offset: 0x2365B11 VA: 0x2365A10
	private void set_out_InitialVelocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD2B0 Offset: 0x2AD3B1 VA: 0x2AD2B0
	// RVA: 0x2365A20 Offset: 0x2365B21 VA: 0x2365A20
	public Vector3 get_out_WorldHitDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD2C0 Offset: 0x2AD3C1 VA: 0x2AD2C0
	// RVA: 0x2365A30 Offset: 0x2365B31 VA: 0x2365A30
	private void set_out_WorldHitDir(Vector3 value) { }

	// RVA: 0x2365A40 Offset: 0x2365B41 VA: 0x2365A40
	public Vector3 get_WorldCentroidOffset() { }

	// RVA: 0x2365A60 Offset: 0x2365B61 VA: 0x2365A60
	public void Calculate() { }

	// RVA: 0x2365DE0 Offset: 0x2365EE1 VA: 0x2365DE0
	private Vector3 CalcHitDir() { }

	// RVA: 0x2365F20 Offset: 0x2366021 VA: 0x2365F20
	public void RecalcInitialVelocity(float flyingTime) { }

	// RVA: 0x2366020 Offset: 0x2366121 VA: 0x2366020
	public static float Kmph_mps(float kmph) { }

	// RVA: 0x2365EB0 Offset: 0x2365FB1 VA: 0x2365EB0
	public static Vector3 CalculateTrajectory(float time, float mass, in Vector3 velocity) { }

	// RVA: 0x2366040 Offset: 0x2366141 VA: 0x2366040
	private static Vector2 CalculateTrajectoryVelocity2D(in Vector2 target, float power) { }

	// RVA: 0x2365B80 Offset: 0x2365C81 VA: 0x2365B80
	public static Vector3 CalculateTrajectoryVelocity(Vector3 target, float power, out float timeToHit) { }

	// RVA: 0x2365FB0 Offset: 0x23660B1 VA: 0x2365FB0
	public static Vector3 CalculateTrajectoryVelocityByTime(Vector3 target, float time) { }

	// RVA: 0x2366170 Offset: 0x2366271 VA: 0x2366170
	public void .ctor() { }
}

