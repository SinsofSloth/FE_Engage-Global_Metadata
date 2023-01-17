// Namespace: RootMotion.FinalIK
public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 14481
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5E60 Offset: 0x2A5F61 VA: 0x2A5E60
	public float weight; // 0x18
	[TooltipAttribute] // RVA: 0x2A5EA0 Offset: 0x2A5FA1 VA: 0x2A5EA0
	public float offset; // 0x1C
	private FullBodyBipedIK ik; // 0x20
	private bool skip; // 0x28

	// Methods

	// RVA: 0x2341950 Offset: 0x2341A51 VA: 0x2341950
	private void Start() { }

	// RVA: 0x2341A50 Offset: 0x2341B51 VA: 0x2341A50
	private void RotateShoulders() { }

	// RVA: 0x2341B30 Offset: 0x2341C31 VA: 0x2341B30
	private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset) { }

	// RVA: 0x2341E10 Offset: 0x2341F11 VA: 0x2341E10
	private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain) { }

	// RVA: 0x2341E40 Offset: 0x2341F41 VA: 0x2341E40
	private void OnDestroy() { }

	// RVA: 0x2341F70 Offset: 0x2342071 VA: 0x2341F70
	public void .ctor() { }
}

