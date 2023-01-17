// Namespace: RootMotion.FinalIK
public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 14356
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A0030 Offset: 0x2A0131 VA: 0x2A0030
	public FullBodyBipedIK ik; // 0x18
	[TooltipAttribute] // RVA: 0x2A0070 Offset: 0x2A0171 VA: 0x2A0070
	[RangeAttribute] // RVA: 0x2A0070 Offset: 0x2A0171 VA: 0x2A0070
	[LargeHeader] // RVA: 0x2A0070 Offset: 0x2A0171 VA: 0x2A0070
	public float positionWeight; // 0x20
	[TooltipAttribute] // RVA: 0x2A00F0 Offset: 0x2A01F1 VA: 0x2A00F0
	[RangeAttribute] // RVA: 0x2A00F0 Offset: 0x2A01F1 VA: 0x2A00F0
	public float bodyWeight; // 0x24
	[TooltipAttribute] // RVA: 0x2A0150 Offset: 0x2A0251 VA: 0x2A0150
	[RangeAttribute] // RVA: 0x2A0150 Offset: 0x2A0251 VA: 0x2A0150
	public float thighWeight; // 0x28
	[TooltipAttribute] // RVA: 0x2A01B0 Offset: 0x2A02B1 VA: 0x2A01B0
	public bool handsPullBody; // 0x2C
	[RangeAttribute] // RVA: 0x2A01F0 Offset: 0x2A02F1 VA: 0x2A01F0
	[LargeHeader] // RVA: 0x2A01F0 Offset: 0x2A02F1 VA: 0x2A01F0
	[TooltipAttribute] // RVA: 0x2A01F0 Offset: 0x2A02F1 VA: 0x2A01F0
	public float rotationWeight; // 0x30
	[TooltipAttribute] // RVA: 0x2A0270 Offset: 0x2A0371 VA: 0x2A0270
	[RangeAttribute] // RVA: 0x2A0270 Offset: 0x2A0371 VA: 0x2A0270
	public float bodyClampWeight; // 0x34
	[TooltipAttribute] // RVA: 0x2A02D0 Offset: 0x2A03D1 VA: 0x2A02D0
	[RangeAttribute] // RVA: 0x2A02D0 Offset: 0x2A03D1 VA: 0x2A02D0
	public float headClampWeight; // 0x38
	[RangeAttribute] // RVA: 0x2A0330 Offset: 0x2A0431 VA: 0x2A0330
	[TooltipAttribute] // RVA: 0x2A0330 Offset: 0x2A0431 VA: 0x2A0330
	public float bendWeight; // 0x3C
	[TooltipAttribute] // RVA: 0x2A0390 Offset: 0x2A0491 VA: 0x2A0390
	public FBBIKHeadEffector.BendBone[] bendBones; // 0x40
	[LargeHeader] // RVA: 0x2A03D0 Offset: 0x2A04D1 VA: 0x2A03D0
	[RangeAttribute] // RVA: 0x2A03D0 Offset: 0x2A04D1 VA: 0x2A03D0
	[TooltipAttribute] // RVA: 0x2A03D0 Offset: 0x2A04D1 VA: 0x2A03D0
	public float CCDWeight; // 0x48
	[TooltipAttribute] // RVA: 0x2A0450 Offset: 0x2A0551 VA: 0x2A0450
	[RangeAttribute] // RVA: 0x2A0450 Offset: 0x2A0551 VA: 0x2A0450
	public float roll; // 0x4C
	[RangeAttribute] // RVA: 0x2A04B0 Offset: 0x2A05B1 VA: 0x2A04B0
	[TooltipAttribute] // RVA: 0x2A04B0 Offset: 0x2A05B1 VA: 0x2A04B0
	public float damper; // 0x50
	[TooltipAttribute] // RVA: 0x2A0510 Offset: 0x2A0611 VA: 0x2A0510
	public Transform[] CCDBones; // 0x58
	[RangeAttribute] // RVA: 0x2A0550 Offset: 0x2A0651 VA: 0x2A0550
	[TooltipAttribute] // RVA: 0x2A0550 Offset: 0x2A0651 VA: 0x2A0550
	[LargeHeader] // RVA: 0x2A0550 Offset: 0x2A0651 VA: 0x2A0550
	public float postStretchWeight; // 0x60
	[TooltipAttribute] // RVA: 0x2A05D0 Offset: 0x2A06D1 VA: 0x2A05D0
	public float maxStretch; // 0x64
	[TooltipAttribute] // RVA: 0x2A0610 Offset: 0x2A0711 VA: 0x2A0610
	public float stretchDamper; // 0x68
	[TooltipAttribute] // RVA: 0x2A0650 Offset: 0x2A0751 VA: 0x2A0650
	public bool fixHead; // 0x6C
	[TooltipAttribute] // RVA: 0x2A0690 Offset: 0x2A0791 VA: 0x2A0690
	public Transform[] stretchBones; // 0x70
	[LargeHeader] // RVA: 0x2A06D0 Offset: 0x2A07D1 VA: 0x2A06D0
	public Vector3 chestDirection; // 0x78
	[RangeAttribute] // RVA: 0x2A0710 Offset: 0x2A0811 VA: 0x2A0710
	public float chestDirectionWeight; // 0x84
	public Transform[] chestBones; // 0x88
	public IKSolver.UpdateDelegate OnPostHeadEffectorFK; // 0x90
	private Vector3 offset; // 0x98
	private Vector3 headToBody; // 0xA4
	private Vector3 shoulderCenterToHead; // 0xB0
	private Vector3 headToLeftThigh; // 0xBC
	private Vector3 headToRightThigh; // 0xC8
	private Vector3 leftShoulderPos; // 0xD4
	private Vector3 rightShoulderPos; // 0xE0
	private float shoulderDist; // 0xEC
	private float leftShoulderDist; // 0xF0
	private float rightShoulderDist; // 0xF4
	private Quaternion chestRotation; // 0xF8
	private Quaternion headRotationRelativeToRoot; // 0x108
	private Quaternion[] ccdDefaultLocalRotations; // 0x118
	private Vector3 headLocalPosition; // 0x120
	private Quaternion headLocalRotation; // 0x12C
	private Vector3[] stretchLocalPositions; // 0x140
	private Quaternion[] stretchLocalRotations; // 0x148
	private Vector3[] chestLocalPositions; // 0x150
	private Quaternion[] chestLocalRotations; // 0x158
	private int bendBonesCount; // 0x160
	private int ccdBonesCount; // 0x164
	private int stretchBonesCount; // 0x168
	private int chestBonesCount; // 0x16C

	// Methods

	// RVA: 0x2803290 Offset: 0x2803391 VA: 0x2803290
	private void Start() { }

	// RVA: 0x28035E0 Offset: 0x28036E1 VA: 0x28035E0
	private void OnStoreDefaultLocalState() { }

	// RVA: 0x2803A80 Offset: 0x2803B81 VA: 0x2803A80
	private void OnFixTransforms() { }

	// RVA: 0x2803E30 Offset: 0x2803F31 VA: 0x2803E30
	private void OnPreRead() { }

	// RVA: 0x2804480 Offset: 0x2804581 VA: 0x2804480
	private void SpineBend() { }

	// RVA: 0x2804710 Offset: 0x2804811 VA: 0x2804710
	private void CCDPass() { }

	// RVA: 0x2804A10 Offset: 0x2804B11 VA: 0x2804A10
	private void Iterate(int iteration) { }

	// RVA: 0x28053B0 Offset: 0x28054B1 VA: 0x28053B0
	private void OnPostUpdate() { }

	// RVA: 0x2804280 Offset: 0x2804381 VA: 0x2804280
	private void ChestDirection() { }

	// RVA: 0x2805540 Offset: 0x2805641 VA: 0x2805540
	private void PostStretching() { }

	// RVA: 0x28052C0 Offset: 0x28053C1 VA: 0x28052C0
	private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset) { }

	// RVA: 0x28051E0 Offset: 0x28052E1 VA: 0x28051E0
	private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance) { }

	// RVA: 0x28057A0 Offset: 0x28058A1 VA: 0x28057A0
	private void OnDestroy() { }

	// RVA: 0x2805AB0 Offset: 0x2805BB1 VA: 0x2805AB0
	public void .ctor() { }
}

