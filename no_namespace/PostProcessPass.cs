// Namespace: 
private class PostProcessPass.MaterialLibrary // TypeDefIndex: 5412
{
	// Fields
	public readonly Material stopNaN; // 0x10
	public readonly Material subpixelMorphologicalAntialiasing; // 0x18
	public readonly Material gaussianDepthOfField; // 0x20
	public readonly Material bokehDepthOfField; // 0x28
	public readonly Material cameraMotionBlur; // 0x30
	public readonly Material paniniProjection; // 0x38
	public readonly Material bloom; // 0x40
	public readonly Material uber; // 0x48
	public readonly Material finalPass; // 0x50
	public readonly Material customBlur; // 0x58
	public readonly Material customRadialBlur; // 0x60
	public readonly Material customFilter; // 0x68
	public readonly Material customUber; // 0x70

	// Methods

	// RVA: 0x2FA3D70 Offset: 0x2FA3E71 VA: 0x2FA3D70
	public void .ctor(PostProcessData data) { }

	// RVA: 0x2FA3F40 Offset: 0x2FA4041 VA: 0x2FA3F40
	private Material Load(Shader shader) { }

	// RVA: 0x2FA4150 Offset: 0x2FA4251 VA: 0x2FA4150
	internal void Cleanup() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x47FEB0 Offset: 0x47FFB1 VA: 0x47FEB0
private struct PostProcessPass.<>c__DisplayClass78_0 // TypeDefIndex: 5414
{
	// Fields
	public int source; // 0x0
	public int destination; // 0x4
	public CommandBuffer cmd; // 0x8
	public PostProcessPass <>4__this; // 0x10
	public bool tempTargetUsed; // 0x18
	public bool tempTarget2Used; // 0x19
}

