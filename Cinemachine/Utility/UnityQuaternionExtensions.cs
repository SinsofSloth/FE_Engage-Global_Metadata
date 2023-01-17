// Namespace: Cinemachine.Utility
[ExtensionAttribute] // RVA: 0x1BEF0 Offset: 0x1BFF1 VA: 0x1BEF0
public static class UnityQuaternionExtensions // TypeDefIndex: 5909
{
	// Methods

	// RVA: 0x1A86660 Offset: 0x1A86761 VA: 0x1A86660
	public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up) { }

	[ExtensionAttribute] // RVA: 0x24160 Offset: 0x24261 VA: 0x24160
	// RVA: 0x1A86940 Offset: 0x1A86A41 VA: 0x1A86940
	public static Quaternion Normalized(Quaternion q) { }

	[ExtensionAttribute] // RVA: 0x24170 Offset: 0x24271 VA: 0x24170
	// RVA: 0x1A869A0 Offset: 0x1A86AA1 VA: 0x1A869A0
	public static Vector2 GetCameraRotationToTarget(Quaternion orient, Vector3 lookAtDir, Vector3 worldUp) { }

	[ExtensionAttribute] // RVA: 0x24180 Offset: 0x24281 VA: 0x24180
	// RVA: 0x1A86E50 Offset: 0x1A86F51 VA: 0x1A86E50
	public static Quaternion ApplyCameraRotation(Quaternion orient, Vector2 rot, Vector3 worldUp) { }
}

