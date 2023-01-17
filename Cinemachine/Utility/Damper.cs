// Namespace: Cinemachine.Utility
public static class Damper // TypeDefIndex: 5904
{
	// Fields
	private const float Epsilon = 0.0001;
	public const float kNegligibleResidual = 0.01;
	private const float kLogNegligibleResidual = -4.6051702;

	// Methods

	// RVA: 0x1A81520 Offset: 0x1A81621 VA: 0x1A81520
	private static float DecayConstant(float time, float residual) { }

	// RVA: 0x1A81550 Offset: 0x1A81651 VA: 0x1A81550
	private static float DecayedRemainder(float initial, float decayConstant, float deltaTime) { }

	// RVA: 0x1A77B30 Offset: 0x1A77C31 VA: 0x1A77B30
	public static float Damp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A77FF0 Offset: 0x1A780F1 VA: 0x1A77FF0
	public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A77BD0 Offset: 0x1A77CD1 VA: 0x1A77BD0
	public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime) { }
}

