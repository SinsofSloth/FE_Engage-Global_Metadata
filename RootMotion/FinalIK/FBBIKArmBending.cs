// Namespace: RootMotion.FinalIK
public class FBBIKArmBending : MonoBehaviour // TypeDefIndex: 14354
{
	// Fields
	public FullBodyBipedIK ik; // 0x18
	public Vector3 bendDirectionOffsetLeft; // 0x20
	public Vector3 bendDirectionOffsetRight; // 0x2C
	public Vector3 characterSpaceBendOffsetLeft; // 0x38
	public Vector3 characterSpaceBendOffsetRight; // 0x44
	private Quaternion leftHandTargetRotation; // 0x50
	private Quaternion rightHandTargetRotation; // 0x60
	private bool initiated; // 0x70

	// Methods

	// RVA: 0x2802C50 Offset: 0x2802D51 VA: 0x2802C50
	private void LateUpdate() { }

	// RVA: 0x2802FF0 Offset: 0x28030F1 VA: 0x2802FF0
	private void OnPostFBBIK() { }

	// RVA: 0x2803150 Offset: 0x2803251 VA: 0x2803150
	private void OnDestroy() { }

	// RVA: 0x2803280 Offset: 0x2803381 VA: 0x2803280
	public void .ctor() { }
}

