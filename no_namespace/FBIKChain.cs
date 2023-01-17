// Namespace: 
[Serializable]
public class FBIKChain.ChildConstraint // TypeDefIndex: 14357
{
	// Fields
	public float pushElasticity; // 0x10
	public float pullElasticity; // 0x14
	[SerializeField] // RVA: 0x2A0870 Offset: 0x2A0971 VA: 0x2A0870
	private Transform bone1; // 0x18
	[SerializeField] // RVA: 0x2A0880 Offset: 0x2A0981 VA: 0x2A0880
	private Transform bone2; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2A0890 Offset: 0x2A0991 VA: 0x2A0890
	private float <nominalDistance>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2A08A0 Offset: 0x2A09A1 VA: 0x2A08A0
	private bool <isRigid>k__BackingField; // 0x2C
	private float crossFade; // 0x30
	private float inverseCrossFade; // 0x34
	private int chain1Index; // 0x38
	private int chain2Index; // 0x3C

	// Properties
	public float nominalDistance { get; set; }
	public bool isRigid { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CF940 Offset: 0x2CFA41 VA: 0x2CF940
	// RVA: 0x1F09A70 Offset: 0x1F09B71 VA: 0x1F09A70
	public float get_nominalDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF950 Offset: 0x2CFA51 VA: 0x2CF950
	// RVA: 0x1F09A80 Offset: 0x1F09B81 VA: 0x1F09A80
	private void set_nominalDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF960 Offset: 0x2CFA61 VA: 0x2CF960
	// RVA: 0x1F09A90 Offset: 0x1F09B91 VA: 0x1F09A90
	public bool get_isRigid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF970 Offset: 0x2CFA71 VA: 0x2CF970
	// RVA: 0x1F09AA0 Offset: 0x1F09BA1 VA: 0x1F09AA0
	private void set_isRigid(bool value) { }

	// RVA: 0x1F09AB0 Offset: 0x1F09BB1 VA: 0x1F09AB0
	public void .ctor(Transform bone1, Transform bone2, float pushElasticity = 0, float pullElasticity = 0) { }

	// RVA: 0x1F09B20 Offset: 0x1F09C21 VA: 0x1F09B20
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x1F09B70 Offset: 0x1F09C71 VA: 0x1F09B70
	public void OnPreSolve(IKSolverFullBody solver) { }

	// RVA: 0x1F09CD0 Offset: 0x1F09DD1 VA: 0x1F09CD0
	public void Solve(IKSolverFullBody solver) { }
}

