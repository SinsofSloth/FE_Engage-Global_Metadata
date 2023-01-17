// Namespace: 
[Serializable]
public class IKSolverVR.VirtualBone // TypeDefIndex: 14401
{
	// Fields
	public Vector3 readPosition; // 0x10
	public Quaternion readRotation; // 0x1C
	public Vector3 solverPosition; // 0x2C
	public Quaternion solverRotation; // 0x38
	public float length; // 0x48
	public float sqrMag; // 0x4C
	public Vector3 axis; // 0x50

	// Methods

	// RVA: 0x221F240 Offset: 0x221F341 VA: 0x221F240
	public void .ctor(Vector3 position, Quaternion rotation) { }

	// RVA: 0x221F2E0 Offset: 0x221F3E1 VA: 0x221F2E0
	public void Read(Vector3 position, Quaternion rotation) { }

	// RVA: 0x221F320 Offset: 0x221F421 VA: 0x221F320
	public static void SwingRotation(IKSolverVR.VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1) { }

	// RVA: 0x221F490 Offset: 0x221F591 VA: 0x221F490
	public static float PreSolve(ref IKSolverVR.VirtualBone[] bones) { }

	// RVA: 0x221F670 Offset: 0x221F771 VA: 0x221F670
	public static void RotateAroundPoint(IKSolverVR.VirtualBone[] bones, int index, Vector3 point, Quaternion rotation) { }

	// RVA: 0x221F790 Offset: 0x221F891 VA: 0x221F790
	public static void RotateBy(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation) { }

	// RVA: 0x221F8E0 Offset: 0x221F9E1 VA: 0x221F8E0
	public static void RotateBy(IKSolverVR.VirtualBone[] bones, Quaternion rotation) { }

	// RVA: 0x221FA10 Offset: 0x221FB11 VA: 0x221FA10
	public static void RotateTo(IKSolverVR.VirtualBone[] bones, int index, Quaternion rotation) { }

	// RVA: 0x221FAC0 Offset: 0x221FBC1 VA: 0x221FAC0
	public static void SolveTrigonometric(IKSolverVR.VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	// RVA: 0x221FEA0 Offset: 0x221FFA1 VA: 0x221FEA0
	private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) { }

	// RVA: 0x2220020 Offset: 0x2220121 VA: 0x2220020
	public static void SolveFABRIK(IKSolverVR.VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset) { }

	// RVA: 0x2220410 Offset: 0x2220511 VA: 0x2220410
	private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x2220480 Offset: 0x2220581 VA: 0x2220480
	public static void SolveCCD(IKSolverVR.VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations) { }
}

