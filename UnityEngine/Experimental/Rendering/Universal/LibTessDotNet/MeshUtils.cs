// Namespace: UnityEngine.Experimental.Rendering.Universal.LibTessDotNet
internal static class MeshUtils // TypeDefIndex: 5516
{
	// Fields
	public const int Undef = -1;

	// Methods

	// RVA: 0x3360A00 Offset: 0x3360B01 VA: 0x3360A00
	public static MeshUtils.Edge MakeEdge(MeshUtils.Edge eNext) { }

	// RVA: 0x33610C0 Offset: 0x33611C1 VA: 0x33610C0
	public static void Splice(MeshUtils.Edge a, MeshUtils.Edge b) { }

	// RVA: 0x3360B60 Offset: 0x3360C61 VA: 0x3360B60
	public static void MakeVertex(MeshUtils.Edge eOrig, MeshUtils.Vertex vNext) { }

	// RVA: 0x3360C40 Offset: 0x3360D41 VA: 0x3360C40
	public static void MakeFace(MeshUtils.Edge eOrig, MeshUtils.Face fNext) { }

	// RVA: 0x3361590 Offset: 0x3361691 VA: 0x3361590
	public static void KillEdge(MeshUtils.Edge eDel) { }

	// RVA: 0x3360F60 Offset: 0x3361061 VA: 0x3360F60
	public static void KillVertex(MeshUtils.Vertex vDel, MeshUtils.Vertex newOrg) { }

	// RVA: 0x3361010 Offset: 0x3361111 VA: 0x3361010
	public static void KillFace(MeshUtils.Face fDel, MeshUtils.Face newLFace) { }

	// RVA: 0x3361F80 Offset: 0x3362081 VA: 0x3361F80
	public static float FaceArea(MeshUtils.Face f) { }
}

