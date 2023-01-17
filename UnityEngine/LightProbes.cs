// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C720 Offset: 0x43C821 VA: 0x43C720
public sealed class LightProbes : Object // TypeDefIndex: 3449
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x4428D0 Offset: 0x4429D1 VA: 0x4428D0
	[DebuggerBrowsableAttribute] // RVA: 0x4428D0 Offset: 0x4429D1 VA: 0x4428D0
	private static Action tetrahedralizationCompleted; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x442910 Offset: 0x442A11 VA: 0x442910
	[DebuggerBrowsableAttribute] // RVA: 0x442910 Offset: 0x442A11 VA: 0x442910
	private static Action needsRetetrahedralization; // 0x8

	// Properties
	public Vector3[] positions { get; }
	public SphericalHarmonicsL2[] bakedProbes { get; set; }
	public int count { get; }
	public int cellCount { get; }
	[ObsoleteAttribute] // RVA: 0x459740 Offset: 0x459841 VA: 0x459740
	[EditorBrowsableAttribute] // RVA: 0x459740 Offset: 0x459841 VA: 0x459740
	public float[] coefficients { get; set; }

	// Methods

	// RVA: 0x2F29870 Offset: 0x2F29971 VA: 0x2F29870
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x4479D0 Offset: 0x447AD1 VA: 0x4479D0
	// RVA: 0x2F298E0 Offset: 0x2F299E1 VA: 0x2F298E0
	public static void add_tetrahedralizationCompleted(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4479E0 Offset: 0x447AE1 VA: 0x4479E0
	// RVA: 0x2F299A0 Offset: 0x2F29AA1 VA: 0x2F299A0
	public static void remove_tetrahedralizationCompleted(Action value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4479F0 Offset: 0x447AF1 VA: 0x4479F0
	// RVA: 0x2F29A60 Offset: 0x2F29B61 VA: 0x2F29A60
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	[CompilerGeneratedAttribute] // RVA: 0x447A00 Offset: 0x447B01 VA: 0x447A00
	// RVA: 0x2F29AC0 Offset: 0x2F29BC1 VA: 0x2F29AC0
	public static void add_needsRetetrahedralization(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x447A10 Offset: 0x447B11 VA: 0x447A10
	// RVA: 0x2F29B90 Offset: 0x2F29C91 VA: 0x2F29B90
	public static void remove_needsRetetrahedralization(Action value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447A20 Offset: 0x447B21 VA: 0x447A20
	// RVA: 0x2F29C60 Offset: 0x2F29D61 VA: 0x2F29C60
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	[FreeFunctionAttribute] // RVA: 0x447A30 Offset: 0x447B31 VA: 0x447A30
	// RVA: 0x2F29CC0 Offset: 0x2F29DC1 VA: 0x2F29CC0
	public static void Tetrahedralize() { }

	[FreeFunctionAttribute] // RVA: 0x447A40 Offset: 0x447B41 VA: 0x447A40
	// RVA: 0x2F29D00 Offset: 0x2F29E01 VA: 0x2F29D00
	public static void TetrahedralizeAsync() { }

	[FreeFunctionAttribute] // RVA: 0x447A50 Offset: 0x447B51 VA: 0x447A50
	// RVA: 0x2F29D40 Offset: 0x2F29E41 VA: 0x2F29D40
	public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }

	[FreeFunctionAttribute] // RVA: 0x447A60 Offset: 0x447B61 VA: 0x447A60
	// RVA: 0x2F29E10 Offset: 0x2F29F11 VA: 0x2F29E10
	internal static bool AreLightProbesAllowed(Renderer renderer) { }

	// RVA: 0x2F29E60 Offset: 0x2F29F61 VA: 0x2F29E60
	public static void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) { }

	// RVA: 0x2F2A070 Offset: 0x2F2A171 VA: 0x2F2A070
	public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes) { }

	[NativeNameAttribute] // RVA: 0x447A70 Offset: 0x447B71 VA: 0x447A70
	[FreeFunctionAttribute] // RVA: 0x447A70 Offset: 0x447B71 VA: 0x447A70
	// RVA: 0x2F2A000 Offset: 0x2F2A101 VA: 0x2F2A000
	internal static void CalculateInterpolatedLightAndOcclusionProbes_Internal(Vector3[] positions, int positionsCount, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) { }

	[NativeNameAttribute] // RVA: 0x447AC0 Offset: 0x447BC1 VA: 0x447AC0
	[FreeFunctionAttribute] // RVA: 0x447AC0 Offset: 0x447BC1 VA: 0x447AC0
	// RVA: 0x2F2A310 Offset: 0x2F2A411 VA: 0x2F2A310
	public Vector3[] get_positions() { }

	[NativeNameAttribute] // RVA: 0x447B20 Offset: 0x447C21 VA: 0x447B20
	[FreeFunctionAttribute] // RVA: 0x447B20 Offset: 0x447C21 VA: 0x447B20
	// RVA: 0x2F2A360 Offset: 0x2F2A461 VA: 0x2F2A360
	public SphericalHarmonicsL2[] get_bakedProbes() { }

	[FreeFunctionAttribute] // RVA: 0x447B80 Offset: 0x447C81 VA: 0x447B80
	[NativeNameAttribute] // RVA: 0x447B80 Offset: 0x447C81 VA: 0x447B80
	// RVA: 0x2F2A3B0 Offset: 0x2F2A4B1 VA: 0x2F2A3B0
	public void set_bakedProbes(SphericalHarmonicsL2[] value) { }

	[FreeFunctionAttribute] // RVA: 0x447BE0 Offset: 0x447CE1 VA: 0x447BE0
	[NativeNameAttribute] // RVA: 0x447BE0 Offset: 0x447CE1 VA: 0x447BE0
	// RVA: 0x2F2A400 Offset: 0x2F2A501 VA: 0x2F2A400
	public int get_count() { }

	[FreeFunctionAttribute] // RVA: 0x447C40 Offset: 0x447D41 VA: 0x447C40
	[NativeNameAttribute] // RVA: 0x447C40 Offset: 0x447D41 VA: 0x447C40
	// RVA: 0x2F2A450 Offset: 0x2F2A551 VA: 0x2F2A450
	public int get_cellCount() { }

	[FreeFunctionAttribute] // RVA: 0x447CA0 Offset: 0x447DA1 VA: 0x447CA0
	[NativeNameAttribute] // RVA: 0x447CA0 Offset: 0x447DA1 VA: 0x447CA0
	// RVA: 0x2F2A4A0 Offset: 0x2F2A5A1 VA: 0x2F2A4A0
	internal static int GetCount() { }

	[EditorBrowsableAttribute] // RVA: 0x447CF0 Offset: 0x447DF1 VA: 0x447CF0
	[ObsoleteAttribute] // RVA: 0x447CF0 Offset: 0x447DF1 VA: 0x447CF0
	// RVA: 0x2F2A4E0 Offset: 0x2F2A5E1 VA: 0x2F2A4E0
	public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, float[] coefficients) { }

	// RVA: 0x2F2A4F0 Offset: 0x2F2A5F1 VA: 0x2F2A4F0
	public float[] get_coefficients() { }

	// RVA: 0x2F2A540 Offset: 0x2F2A641 VA: 0x2F2A540
	public void set_coefficients(float[] value) { }

	// RVA: 0x2F29DB0 Offset: 0x2F29EB1 VA: 0x2F29DB0
	private static void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }
}

