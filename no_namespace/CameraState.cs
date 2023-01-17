// Namespace: 
public enum CameraState.BlendHintValue // TypeDefIndex: 5812
{
	// Fields
	public int value__; // 0x0
	public const CameraState.BlendHintValue Nothing = 0;
	public const CameraState.BlendHintValue NoPosition = 1;
	public const CameraState.BlendHintValue NoOrientation = 2;
	public const CameraState.BlendHintValue NoTransform = 3;
	public const CameraState.BlendHintValue SphericalPositionBlend = 4;
	public const CameraState.BlendHintValue CylindricalPositionBlend = 8;
	public const CameraState.BlendHintValue RadialAimBlend = 16;
	public const CameraState.BlendHintValue IgnoreLookAtTarget = 32;
	public const CameraState.BlendHintValue NoLens = 64;
}

// Namespace: 
public struct CameraState.CustomBlendable // TypeDefIndex: 5813
{
	// Fields
	public Object m_Custom; // 0x0
	public float m_Weight; // 0x8

	// Methods

	// RVA: 0x1A730C0 Offset: 0x1A731C1 VA: 0x1A730C0
	public void .ctor(Object custom, float weight) { }
}

