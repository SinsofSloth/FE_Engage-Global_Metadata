// Namespace: 
public enum Light2D.LightType // TypeDefIndex: 5464
{
	// Fields
	public int value__; // 0x0
	public const Light2D.LightType Parametric = 0;
	public const Light2D.LightType Freeform = 1;
	public const Light2D.LightType Sprite = 2;
	public const Light2D.LightType Point = 3;
	public const Light2D.LightType Global = 4;
}

// Namespace: 
public enum Light2D.PointLightQuality // TypeDefIndex: 5465
{
	// Fields
	public int value__; // 0x0
	public const Light2D.PointLightQuality Fast = 0;
	public const Light2D.PointLightQuality Accurate = 1;
}

// Namespace: 
internal enum Light2DBlendStyle.TextureChannel // TypeDefIndex: 5467
{
	// Fields
	public int value__; // 0x0
	public const Light2DBlendStyle.TextureChannel None = 0;
	public const Light2DBlendStyle.TextureChannel R = 1;
	public const Light2DBlendStyle.TextureChannel G = 2;
	public const Light2DBlendStyle.TextureChannel B = 3;
	public const Light2DBlendStyle.TextureChannel A = 4;
	public const Light2DBlendStyle.TextureChannel OneMinusR = 5;
	public const Light2DBlendStyle.TextureChannel OneMinusG = 6;
	public const Light2DBlendStyle.TextureChannel OneMinusB = 7;
	public const Light2DBlendStyle.TextureChannel OneMinusA = 8;
}

// Namespace: 
internal struct Light2DBlendStyle.MaskChannelFilter // TypeDefIndex: 5468
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x483F10 Offset: 0x484011 VA: 0x483F10
	private Vector4 <mask>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x483F20 Offset: 0x484021 VA: 0x483F20
	private Vector4 <inverted>k__BackingField; // 0x10

	// Properties
	public Vector4 mask { get; set; }
	public Vector4 inverted { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x4851B0 Offset: 0x4852B1 VA: 0x4851B0
	[CompilerGeneratedAttribute] // RVA: 0x4851B0 Offset: 0x4852B1 VA: 0x4851B0
	// RVA: 0x2FA3430 Offset: 0x2FA3531 VA: 0x2FA3430
	public Vector4 get_mask() { }

	[CompilerGeneratedAttribute] // RVA: 0x4851F0 Offset: 0x4852F1 VA: 0x4851F0
	// RVA: 0x2FA3440 Offset: 0x2FA3541 VA: 0x2FA3440
	private void set_mask(Vector4 value) { }

	[IsReadOnlyAttribute] // RVA: 0x485200 Offset: 0x485301 VA: 0x485200
	[CompilerGeneratedAttribute] // RVA: 0x485200 Offset: 0x485301 VA: 0x485200
	// RVA: 0x2FA3460 Offset: 0x2FA3561 VA: 0x2FA3460
	public Vector4 get_inverted() { }

	[CompilerGeneratedAttribute] // RVA: 0x485240 Offset: 0x485341 VA: 0x485240
	// RVA: 0x2FA3470 Offset: 0x2FA3571 VA: 0x2FA3470
	private void set_inverted(Vector4 value) { }

	// RVA: 0x2FA3490 Offset: 0x2FA3591 VA: 0x2FA3490
	public void .ctor(Vector4 m, Vector4 i) { }
}

// Namespace: 
internal enum Light2DBlendStyle.BlendMode // TypeDefIndex: 5469
{
	// Fields
	public int value__; // 0x0
	public const Light2DBlendStyle.BlendMode Additive = 0;
	public const Light2DBlendStyle.BlendMode Multiply = 1;
	public const Light2DBlendStyle.BlendMode Subtractive = 2;
	public const Light2DBlendStyle.BlendMode Custom = 99;
}

// Namespace: 
[Serializable]
internal struct Light2DBlendStyle.BlendFactors // TypeDefIndex: 5470
{
	// Fields
	public float multiplicative; // 0x0
	public float additive; // 0x4
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x480230 Offset: 0x480331 VA: 0x480230
[Serializable]
private sealed class Light2DCullResult.<>c // TypeDefIndex: 5474
{
	// Fields
	public static readonly Light2DCullResult.<>c <>9; // 0x0
	public static Comparison<Light2D> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x2FA34C0 Offset: 0x2FA35C1 VA: 0x2FA34C0
	private static void .cctor() { }

	// RVA: 0x2FA3530 Offset: 0x2FA3631 VA: 0x2FA3530
	public void .ctor() { }

	// RVA: 0x2FA3540 Offset: 0x2FA3641 VA: 0x2FA3540
	internal int <SetupCulling>b__5_0(Light2D l1, Light2D l2) { }
}

