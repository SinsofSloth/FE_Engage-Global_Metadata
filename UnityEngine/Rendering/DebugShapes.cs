// Namespace: UnityEngine.Rendering
public class DebugShapes // TypeDefIndex: 4555
{
	// Fields
	private static DebugShapes s_Instance; // 0x0
	private Mesh m_sphereMesh; // 0x10
	private Mesh m_boxMesh; // 0x18
	private Mesh m_coneMesh; // 0x20
	private Mesh m_pyramidMesh; // 0x28

	// Properties
	public static DebugShapes instance { get; }

	// Methods

	// RVA: 0x1B35E00 Offset: 0x1B35F01 VA: 0x1B35E00
	public static DebugShapes get_instance() { }

	// RVA: 0x1B35EF0 Offset: 0x1B35FF1 VA: 0x1B35EF0
	private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv) { }

	// RVA: 0x1B364E0 Offset: 0x1B365E1 VA: 0x1B364E0
	private void BuildBox(ref Mesh outputMesh, float length, float width, float height) { }

	// RVA: 0x1B36C00 Offset: 0x1B36D01 VA: 0x1B36C00
	private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides) { }

	// RVA: 0x1B37550 Offset: 0x1B37651 VA: 0x1B37550
	private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth) { }

	// RVA: 0x1B378C0 Offset: 0x1B379C1 VA: 0x1B378C0
	private void BuildShapes() { }

	// RVA: 0x1B37A10 Offset: 0x1B37B11 VA: 0x1B37A10
	private void RebuildResources() { }

	// RVA: 0x1B37B30 Offset: 0x1B37C31 VA: 0x1B37B30
	public Mesh RequestSphereMesh() { }

	// RVA: 0x1B37B60 Offset: 0x1B37C61 VA: 0x1B37B60
	public Mesh RequestBoxMesh() { }

	// RVA: 0x1B37B90 Offset: 0x1B37C91 VA: 0x1B37B90
	public Mesh RequestConeMesh() { }

	// RVA: 0x1B37BC0 Offset: 0x1B37CC1 VA: 0x1B37BC0
	public Mesh RequestPyramidMesh() { }

	// RVA: 0x1B35EE0 Offset: 0x1B35FE1 VA: 0x1B35EE0
	public void .ctor() { }

	// RVA: 0x1B37BF0 Offset: 0x1B37CF1 VA: 0x1B37BF0
	private static void .cctor() { }
}

