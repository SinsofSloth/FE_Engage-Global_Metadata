// Namespace: UnityEngine.Rendering.Universal
internal struct XRView // TypeDefIndex: 5377
{
	// Fields
	internal readonly Matrix4x4 projMatrix; // 0x0
	internal readonly Matrix4x4 viewMatrix; // 0x40
	internal readonly Rect viewport; // 0x80
	internal readonly Mesh occlusionMesh; // 0x90
	internal readonly int textureArraySlice; // 0x98

	// Methods

	// RVA: 0x2F9F050 Offset: 0x2F9F151 VA: 0x2F9F050
	internal void .ctor(Matrix4x4 proj, Matrix4x4 view, Rect vp, int dstSlice) { }

	// RVA: 0x2F9ED70 Offset: 0x2F9EE71 VA: 0x2F9ED70
	internal void .ctor(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter) { }
}

