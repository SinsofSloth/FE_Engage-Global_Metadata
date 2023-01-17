// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x34F60 Offset: 0x35061 VA: 0x34F60
[NativeHeaderAttribute] // RVA: 0x34F60 Offset: 0x35061 VA: 0x34F60
public class HumanPoseHandler : IDisposable // TypeDefIndex: 4113
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[FreeFunctionAttribute] // RVA: 0x38500 Offset: 0x38601 VA: 0x38500
	// RVA: 0x3EDE020 Offset: 0x3EDE121 VA: 0x3EDE020
	private static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root) { }

	[FreeFunctionAttribute] // RVA: 0x38540 Offset: 0x38641 VA: 0x38540
	// RVA: 0x3EDE070 Offset: 0x3EDE171 VA: 0x3EDE070
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x3EDE0C0 Offset: 0x3EDE1C1 VA: 0x3EDE0C0
	private void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] float[] muscles) { }

	// RVA: 0x3EDE130 Offset: 0x3EDE231 VA: 0x3EDE130 Slot: 4
	public void Dispose() { }

	// RVA: 0x3EDE1F0 Offset: 0x3EDE2F1 VA: 0x3EDE1F0
	public void .ctor(Avatar avatar, Transform root) { }

	// RVA: 0x3EDE410 Offset: 0x3EDE511 VA: 0x3EDE410
	public void GetHumanPose(ref HumanPose humanPose) { }
}

