// Namespace: UTJ
[Serializable]
public class AngleLimits // TypeDefIndex: 6345
{
	// Fields
	public bool active; // 0x10
	[RangeAttribute] // RVA: 0x5B620 Offset: 0x5B721 VA: 0x5B620
	public float min; // 0x14
	[RangeAttribute] // RVA: 0x5B640 Offset: 0x5B741 VA: 0x5B640
	public float max; // 0x18

	// Methods

	// RVA: 0x3105D00 Offset: 0x3105E01 VA: 0x3105D00
	public static Vector3 GetAngleVector(Vector3 sideVector, Vector3 forwardVector, float degrees) { }

	// RVA: 0x3105D90 Offset: 0x3105E91 VA: 0x3105D90
	public void CopyTo(AngleLimits target) { }

	// RVA: 0x3105DB0 Offset: 0x3105EB1 VA: 0x3105DB0
	private static float ComputeFalloff(float value, float range) { }

	// RVA: 0x3105E30 Offset: 0x3105F31 VA: 0x3105E30
	public bool ConstrainVector(Vector3 basisSide, Vector3 basisUp, Vector3 basisForward, float springStrength, float deltaTime, ref Vector3 vector) { }

	// RVA: 0x3106060 Offset: 0x3106161 VA: 0x3106060
	public void .ctor() { }
}

