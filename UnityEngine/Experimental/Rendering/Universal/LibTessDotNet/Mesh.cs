// Namespace: UnityEngine.Experimental.Rendering.Universal.LibTessDotNet
internal class Mesh : MeshUtils.Pooled<Mesh> // TypeDefIndex: 5509
{
	// Fields
	internal MeshUtils.Vertex _vHead; // 0x10
	internal MeshUtils.Face _fHead; // 0x18
	internal MeshUtils.Edge _eHead; // 0x20
	internal MeshUtils.Edge _eHeadSym; // 0x28

	// Methods

	// RVA: 0x3360600 Offset: 0x3360701 VA: 0x3360600
	public void .ctor() { }

	// RVA: 0x3360850 Offset: 0x3360951 VA: 0x3360850 Slot: 4
	public override void Reset() { }

	// RVA: 0x33608B0 Offset: 0x33609B1 VA: 0x33608B0 Slot: 5
	public override void OnFree() { }

	// RVA: 0x33609B0 Offset: 0x3360AB1 VA: 0x33609B0
	public MeshUtils.Edge MakeEdge() { }

	// RVA: 0x3360D40 Offset: 0x3360E41 VA: 0x3360D40
	public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst) { }

	// RVA: 0x3361140 Offset: 0x3361241 VA: 0x3361140
	public void Delete(MeshUtils.Edge eDel) { }

	// RVA: 0x3361620 Offset: 0x3361721 VA: 0x3361620
	public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg) { }

	// RVA: 0x3361710 Offset: 0x3361811 VA: 0x3361710
	public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg) { }

	// RVA: 0x3361860 Offset: 0x3361961 VA: 0x3361860
	public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst) { }

	// RVA: 0x3361A60 Offset: 0x3361B61 VA: 0x3361A60
	public void ZapFace(MeshUtils.Face fZap) { }

	// RVA: 0x3361DC0 Offset: 0x3361EC1 VA: 0x3361DC0
	public void MergeConvexFaces(int maxVertsPerFace) { }

	[ConditionalAttribute] // RVA: 0x4853C0 Offset: 0x4854C1 VA: 0x4853C0
	// RVA: 0x3361F00 Offset: 0x3362001 VA: 0x3361F00
	public void Check() { }
}

