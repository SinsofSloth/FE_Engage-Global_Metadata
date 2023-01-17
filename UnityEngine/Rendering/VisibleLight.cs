// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x441090 Offset: 0x441191 VA: 0x441090
public struct VisibleLight : IEquatable<VisibleLight> // TypeDefIndex: 3970
{
	// Fields
	private LightType m_LightType; // 0x0
	private Color m_FinalColor; // 0x4
	private Rect m_ScreenRect; // 0x14
	private Matrix4x4 m_LocalToWorldMatrix; // 0x24
	private float m_Range; // 0x64
	private float m_SpotAngle; // 0x68
	private int m_InstanceId; // 0x6C
	private VisibleLightFlags m_Flags; // 0x70

	// Properties
	public Light light { get; }
	public LightType lightType { get; }
	public Color finalColor { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public float range { get; }
	public float spotAngle { get; }

	// Methods

	// RVA: 0x38519F0 Offset: 0x3851AF1 VA: 0x38519F0
	public Light get_light() { }

	// RVA: 0x3851AB0 Offset: 0x3851BB1 VA: 0x3851AB0
	public LightType get_lightType() { }

	// RVA: 0x3851AC0 Offset: 0x3851BC1 VA: 0x3851AC0
	public Color get_finalColor() { }

	// RVA: 0x3851AD0 Offset: 0x3851BD1 VA: 0x3851AD0
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x3851B10 Offset: 0x3851C11 VA: 0x3851B10
	public float get_range() { }

	// RVA: 0x3851B20 Offset: 0x3851C21 VA: 0x3851B20
	public float get_spotAngle() { }

	// RVA: 0x3851B30 Offset: 0x3851C31 VA: 0x3851B30 Slot: 4
	public bool Equals(VisibleLight other) { }

	// RVA: 0x3851C90 Offset: 0x3851D91 VA: 0x3851C90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3851D70 Offset: 0x3851E71 VA: 0x3851D70 Slot: 2
	public override int GetHashCode() { }
}

