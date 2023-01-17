// Namespace: 
private enum PostProcessPass.CaptureMode // TypeDefIndex: 5411
{
	// Fields
	public int value__; // 0x0
	public const PostProcessPass.CaptureMode None = 0;
	public const PostProcessPass.CaptureMode Capture = 1;
	public const PostProcessPass.CaptureMode Copy = 2;
}

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
private static class PostProcessPass.ShaderConstants // TypeDefIndex: 5413
{
	// Fields
	public static readonly int _TempTarget; // 0x0
	public static readonly int _TempTarget2; // 0x4
	public static readonly int _StencilRef; // 0x8
	public static readonly int _StencilMask; // 0xC
	public static readonly int _FullCoCTexture; // 0x10
	public static readonly int _HalfCoCTexture; // 0x14
	public static readonly int _DofTexture; // 0x18
	public static readonly int _CoCParams; // 0x1C
	public static readonly int _BokehKernel; // 0x20
	public static readonly int _PongTexture; // 0x24
	public static readonly int _PingTexture; // 0x28
	public static readonly int _Metrics; // 0x2C
	public static readonly int _AreaTexture; // 0x30
	public static readonly int _SearchTexture; // 0x34
	public static readonly int _EdgeTexture; // 0x38
	public static readonly int _BlendTexture; // 0x3C
	public static readonly int _ColorTexture; // 0x40
	public static readonly int _Params; // 0x44
	public static readonly int _SourceTexLowMip; // 0x48
	public static readonly int _Bloom_Params; // 0x4C
	public static readonly int _Bloom_RGBM; // 0x50
	public static readonly int _Bloom_Texture; // 0x54
	public static readonly int _LensDirt_Texture; // 0x58
	public static readonly int _LensDirt_Params; // 0x5C
	public static readonly int _LensDirt_Intensity; // 0x60
	public static readonly int _Distortion_Params1; // 0x64
	public static readonly int _Distortion_Params2; // 0x68
	public static readonly int _Chroma_Params; // 0x6C
	public static readonly int _Vignette_Params1; // 0x70
	public static readonly int _Vignette_Params2; // 0x74
	public static readonly int _Lut_Params; // 0x78
	public static readonly int _UserLut_Params; // 0x7C
	public static readonly int _InternalLut; // 0x80
	public static readonly int _UserLut; // 0x84
	public static readonly int _DownSampleScaleFactor; // 0x88
	public static readonly int _FullscreenProjMat; // 0x8C
	public static int[] _BloomMipUp; // 0x90
	public static int[] _BloomMipDown; // 0x98
	public static readonly int _CustomPPCharaMask; // 0xA0
	public static readonly int _CustomColorGrading_Params; // 0xA4
	public static readonly int _CustomBlurTempTexture; // 0xA8
	public static readonly int _CustomBlur_Params; // 0xAC
	public static readonly int _CustomBlur_Params2; // 0xB0
	public static readonly int _CustomFinalMonoColor; // 0xB4
	public static readonly int _CustomFilterParams0; // 0xB8
	public static readonly int _CustomFilterParams1; // 0xBC
	public static readonly int _CustomGradationFilter_Params1; // 0xC0
	public static readonly int _CustomGradationFilter_Params2; // 0xC4

	// Methods

	// RVA: 0x2FA4250 Offset: 0x2FA4351 VA: 0x2FA4250
	private static void .cctor() { }
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x47FEC0 Offset: 0x47FFC1 VA: 0x47FEC0
private struct PostProcessPass.<>c__DisplayClass79_0 // TypeDefIndex: 5415
{
	// Fields
	public int source; // 0x0
	public int destination; // 0x4
	public CommandBuffer cmd; // 0x8
	public PostProcessPass <>4__this; // 0x10
	public bool tempTargetUsed; // 0x18
	public bool tempTarget2Used; // 0x19
}

