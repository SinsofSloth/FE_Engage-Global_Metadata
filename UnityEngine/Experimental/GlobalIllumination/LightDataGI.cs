// Namespace: UnityEngine.Experimental.GlobalIllumination
[UsedByNativeCodeAttribute] // RVA: 0x441500 Offset: 0x441601 VA: 0x441500
public struct LightDataGI // TypeDefIndex: 4016
{
	// Fields
	public int instanceID; // 0x0
	public int cookieID; // 0x4
	public float cookieScale; // 0x8
	public LinearColor color; // 0xC
	public LinearColor indirectColor; // 0x1C
	public Quaternion orientation; // 0x2C
	public Vector3 position; // 0x3C
	public float range; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public float shape0; // 0x54
	public float shape1; // 0x58
	public LightType type; // 0x5C
	public LightMode mode; // 0x5D
	public byte shadow; // 0x5E
	public FalloffType falloff; // 0x5F

	// Methods

	// RVA: 0x2F294B0 Offset: 0x2F295B1 VA: 0x2F294B0
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	// RVA: 0x2F29540 Offset: 0x2F29641 VA: 0x2F29540
	public void Init(ref PointLight light, ref Cookie cookie) { }

	// RVA: 0x2F29600 Offset: 0x2F29701 VA: 0x2F29600
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	// RVA: 0x2F296B0 Offset: 0x2F297B1 VA: 0x2F296B0
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	// RVA: 0x2F29750 Offset: 0x2F29851 VA: 0x2F29750
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	// RVA: 0x2F297E0 Offset: 0x2F298E1 VA: 0x2F297E0
	public void InitNoBake(int lightInstanceID) { }
}

