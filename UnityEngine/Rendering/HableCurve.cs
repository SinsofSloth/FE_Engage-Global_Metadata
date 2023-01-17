// Namespace: UnityEngine.Rendering
public class HableCurve // TypeDefIndex: 4630
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CD10 Offset: 0x3CE11 VA: 0x3CD10
	private float <whitePoint>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x3CD20 Offset: 0x3CE21 VA: 0x3CD20
	private float <inverseWhitePoint>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x3CD30 Offset: 0x3CE31 VA: 0x3CD30
	private float <x0>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x3CD40 Offset: 0x3CE41 VA: 0x3CD40
	private float <x1>k__BackingField; // 0x1C
	public readonly HableCurve.Segment[] segments; // 0x20
	public readonly HableCurve.Uniforms uniforms; // 0x28

	// Properties
	public float whitePoint { get; set; }
	public float inverseWhitePoint { get; set; }
	public float x0 { get; set; }
	public float x1 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3DAD0 Offset: 0x3DBD1 VA: 0x3DAD0
	// RVA: 0x1A108E0 Offset: 0x1A109E1 VA: 0x1A108E0
	public float get_whitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DAE0 Offset: 0x3DBE1 VA: 0x3DAE0
	// RVA: 0x1A108F0 Offset: 0x1A109F1 VA: 0x1A108F0
	private void set_whitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DAF0 Offset: 0x3DBF1 VA: 0x3DAF0
	// RVA: 0x1A10900 Offset: 0x1A10A01 VA: 0x1A10900
	public float get_inverseWhitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DB00 Offset: 0x3DC01 VA: 0x3DB00
	// RVA: 0x1A10910 Offset: 0x1A10A11 VA: 0x1A10910
	private void set_inverseWhitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DB10 Offset: 0x3DC11 VA: 0x3DB10
	// RVA: 0x1A10920 Offset: 0x1A10A21 VA: 0x1A10920
	public float get_x0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DB20 Offset: 0x3DC21 VA: 0x3DB20
	// RVA: 0x1A10930 Offset: 0x1A10A31 VA: 0x1A10930
	private void set_x0(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DB30 Offset: 0x3DC31 VA: 0x3DB30
	// RVA: 0x1A10940 Offset: 0x1A10A41 VA: 0x1A10940
	public float get_x1() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DB40 Offset: 0x3DC41 VA: 0x3DB40
	// RVA: 0x1A10950 Offset: 0x1A10A51 VA: 0x1A10950
	private void set_x1(float value) { }

	// RVA: 0x1A10960 Offset: 0x1A10A61 VA: 0x1A10960
	public void .ctor() { }

	// RVA: 0x1A10B30 Offset: 0x1A10C31 VA: 0x1A10B30
	public float Eval(float x) { }

	// RVA: 0x1A10BA0 Offset: 0x1A10CA1 VA: 0x1A10BA0
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	// RVA: 0x1A10D00 Offset: 0x1A10E01 VA: 0x1A10D00
	private void InitSegments(HableCurve.DirectParams srcParams) { }

	// RVA: 0x1A11090 Offset: 0x1A11191 VA: 0x1A11090
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	// RVA: 0x1A11020 Offset: 0x1A11121 VA: 0x1A11020
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	// RVA: 0x1A11050 Offset: 0x1A11151 VA: 0x1A11050
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }
}

