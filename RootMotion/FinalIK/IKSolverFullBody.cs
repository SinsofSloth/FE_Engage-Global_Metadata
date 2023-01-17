// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverFullBody : IKSolver // TypeDefIndex: 14379
{
	// Fields
	[RangeAttribute] // RVA: 0x2A0B80 Offset: 0x2A0C81 VA: 0x2A0B80
	public int iterations; // 0x58
	public FBIKChain[] chain; // 0x60
	public IKEffector[] effectors; // 0x68
	public IKMappingSpine spineMapping; // 0x70
	public IKMappingBone[] boneMappings; // 0x78
	public IKMappingLimb[] limbMappings; // 0x80
	public bool FABRIKPass; // 0x88
	public IKSolver.UpdateDelegate OnPreRead; // 0x90
	public IKSolver.UpdateDelegate OnPreSolve; // 0x98
	public IKSolver.IterationDelegate OnPreIteration; // 0xA0
	public IKSolver.IterationDelegate OnPostIteration; // 0xA8
	public IKSolver.UpdateDelegate OnPreBend; // 0xB0
	public IKSolver.UpdateDelegate OnPostSolve; // 0xB8
	public IKSolver.UpdateDelegate OnStoreDefaultLocalState; // 0xC0
	public IKSolver.UpdateDelegate OnFixTransforms; // 0xC8

	// Methods

	// RVA: 0x3C635F0 Offset: 0x3C636F1 VA: 0x3C635F0
	public IKEffector GetEffector(Transform t) { }

	// RVA: 0x3C636F0 Offset: 0x3C637F1 VA: 0x3C636F0
	public FBIKChain GetChain(Transform transform) { }

	// RVA: 0x3C63750 Offset: 0x3C63851 VA: 0x3C63750
	public int GetChainIndex(Transform transform) { }

	// RVA: 0x3C63880 Offset: 0x3C63981 VA: 0x3C63880
	public IKSolver.Node GetNode(int chainIndex, int nodeIndex) { }

	// RVA: 0x3C638D0 Offset: 0x3C639D1 VA: 0x3C638D0
	public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex) { }

	// RVA: 0x3C63950 Offset: 0x3C63A51 VA: 0x3C63950 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x3C63AE0 Offset: 0x3C63BE1 VA: 0x3C63AE0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x3C63C20 Offset: 0x3C63D21 VA: 0x3C63C20 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x3C63E20 Offset: 0x3C63F21 VA: 0x3C63E20 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x3C63F00 Offset: 0x3C64001 VA: 0x3C63F00 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x3C63FF0 Offset: 0x3C640F1 VA: 0x3C63FF0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C64150 Offset: 0x3C64251 VA: 0x3C64150 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C642B0 Offset: 0x3C643B1 VA: 0x3C642B0 Slot: 12
	protected virtual void ReadPose() { }

	// RVA: 0x3C644F0 Offset: 0x3C645F1 VA: 0x3C644F0 Slot: 13
	protected virtual void Solve() { }

	// RVA: 0x3C647D0 Offset: 0x3C648D1 VA: 0x3C647D0 Slot: 14
	protected virtual void ApplyBendConstraints() { }

	// RVA: 0x3C64810 Offset: 0x3C64911 VA: 0x3C64810 Slot: 15
	protected virtual void WritePose() { }

	// RVA: 0x3C64900 Offset: 0x3C64A01 VA: 0x3C64900
	public void .ctor() { }
}

