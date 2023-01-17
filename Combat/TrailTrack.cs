// Namespace: Combat
[Serializable]
public sealed class TrailTrack // TypeDefIndex: 8861
{
	// Fields
	public AnimationCurve RootX; // 0x10
	public AnimationCurve RootY; // 0x18
	public AnimationCurve RootZ; // 0x20
	public AnimationCurve TipX; // 0x28
	public AnimationCurve TipY; // 0x30
	public AnimationCurve TipZ; // 0x38

	// Methods

	// RVA: 0x286EFE0 Offset: 0x286F0E1 VA: 0x286EFE0
	public void Add(float time, Vector3 root, Vector3 tip) { }

	// RVA: 0x286F0A0 Offset: 0x286F1A1 VA: 0x286F0A0
	public void Evaluate(float time, out Vector3 root, out Vector3 tip) { }

	// RVA: 0x286F160 Offset: 0x286F261 VA: 0x286F160
	public void Optimize(float eps = 0.001) { }

	// RVA: 0x286F540 Offset: 0x286F641 VA: 0x286F540
	private static void Remap(FlattenedVec3Curve oc, FlattenedVec3Curve nc) { }

	// RVA: 0x286F2D0 Offset: 0x286F3D1 VA: 0x286F2D0
	public static AnimationCurve Smoothing(AnimationCurve src) { }

	// RVA: 0x286F670 Offset: 0x286F771 VA: 0x286F670
	public static bool Equals(TrailTrack A, TrailTrack B) { }

	// RVA: 0x286F8F0 Offset: 0x286F9F1 VA: 0x286F8F0
	private static bool Equals(AnimationCurve A, AnimationCurve B, float eps = 0.005) { }

	// RVA: 0x286F7C0 Offset: 0x286F8C1 VA: 0x286F7C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD780 Offset: 0x2AD881 VA: 0x2AD780
	// RVA: 0x286FBA0 Offset: 0x286FCA1 VA: 0x286FBA0
	internal static bool <Equals>g__eq|12_0(float a, float b, ref TrailTrack.<>c__DisplayClass12_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD790 Offset: 0x2AD891 VA: 0x2AD790
	// RVA: 0x286FB80 Offset: 0x286FC81 VA: 0x286FB80
	internal static bool <Equals>g__ne|12_1(float a, float b, ref TrailTrack.<>c__DisplayClass12_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD7A0 Offset: 0x2AD8A1 VA: 0x2AD7A0
	// RVA: 0x286FAE0 Offset: 0x286FBE1 VA: 0x286FAE0
	internal static float <Equals>g__TimeLength|12_2(AnimationCurve c) { }
}

