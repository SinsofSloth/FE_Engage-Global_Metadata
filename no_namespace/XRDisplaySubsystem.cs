// Namespace: 
[NativeHeaderAttribute] // RVA: 0x58D60 Offset: 0x58E61 VA: 0x58D60
public struct XRDisplaySubsystem.XRRenderParameter // TypeDefIndex: 4872
{
	// Fields
	public Matrix4x4 view; // 0x0
	public Matrix4x4 projection; // 0x40
	public Rect viewport; // 0x80
	public Mesh occlusionMesh; // 0x90
	public int textureArraySlice; // 0x98
}

// Namespace: 
[NativeHeaderAttribute] // RVA: 0x58E30 Offset: 0x58F31 VA: 0x58E30
[NativeHeaderAttribute] // RVA: 0x58E30 Offset: 0x58F31 VA: 0x58E30
public struct XRDisplaySubsystem.XRBlitParams // TypeDefIndex: 4874
{
	// Fields
	public RenderTexture srcTex; // 0x0
	public int srcTexArraySlice; // 0x8
	public Rect srcRect; // 0xC
	public Rect destRect; // 0x1C
}

