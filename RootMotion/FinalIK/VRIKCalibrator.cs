// Namespace: RootMotion.FinalIK
public static class VRIKCalibrator // TypeDefIndex: 14485
{
	// Methods

	// RVA: 0x2A40470 Offset: 0x2A40571 VA: 0x2A40470
	public static void RecalibrateScale(VRIK ik, VRIKCalibrator.CalibrationData data, VRIKCalibrator.Settings settings) { }

	// RVA: 0x2A40480 Offset: 0x2A40581 VA: 0x2A40480
	public static void RecalibrateScale(VRIK ik, VRIKCalibrator.CalibrationData data, float scaleMlp) { }

	// RVA: 0x2A40620 Offset: 0x2A40721 VA: 0x2A40620
	private static void CalibrateScale(VRIK ik, VRIKCalibrator.Settings settings) { }

	// RVA: 0x2A40560 Offset: 0x2A40661 VA: 0x2A40560
	private static void CalibrateScale(VRIK ik, float scaleMlp = 1) { }

	// RVA: 0x2A406E0 Offset: 0x2A407E1 VA: 0x2A406E0
	public static VRIKCalibrator.CalibrationData Calibrate(VRIK ik, VRIKCalibrator.Settings settings, Transform headTracker, Transform bodyTracker, Transform leftHandTracker, Transform rightHandTracker, Transform leftFootTracker, Transform rightFootTracker) { }

	// RVA: 0x2A416A0 Offset: 0x2A417A1 VA: 0x2A416A0
	private static void CalibrateLeg(VRIKCalibrator.Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) { }

	// RVA: 0x2A41E00 Offset: 0x2A41F01 VA: 0x2A41E00
	public static void Calibrate(VRIK ik, VRIKCalibrator.CalibrationData data, Transform headTracker, Transform bodyTracker, Transform leftHandTracker, Transform rightHandTracker, Transform leftFootTracker, Transform rightFootTracker) { }

	// RVA: 0x2A426F0 Offset: 0x2A427F1 VA: 0x2A426F0
	private static void CalibrateLeg(VRIKCalibrator.CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) { }

	// RVA: 0x2A42A90 Offset: 0x2A42B91 VA: 0x2A42A90
	public static VRIKCalibrator.CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1) { }

	// RVA: 0x2A42D30 Offset: 0x2A42E31 VA: 0x2A42D30
	public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset) { }

	// RVA: 0x2A43310 Offset: 0x2A43411 VA: 0x2A43310
	public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset) { }

	// RVA: 0x2A430F0 Offset: 0x2A431F1 VA: 0x2A430F0
	public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset) { }

	// RVA: 0x2A43520 Offset: 0x2A43621 VA: 0x2A43520
	private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft) { }

	// RVA: 0x2A43760 Offset: 0x2A43861 VA: 0x2A43760
	public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm) { }

	// RVA: 0x2A43840 Offset: 0x2A43941 VA: 0x2A43840
	public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm) { }
}

