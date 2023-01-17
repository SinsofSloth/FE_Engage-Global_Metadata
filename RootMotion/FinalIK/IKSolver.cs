// Namespace: RootMotion.FinalIK
[Serializable]
public abstract class IKSolver // TypeDefIndex: 14373
{
	// Fields
	[HideInInspector] // RVA: 0x2A09F0 Offset: 0x2A0AF1 VA: 0x2A09F0
	public bool executedInEditor; // 0x10
	[HideInInspector] // RVA: 0x2A0A00 Offset: 0x2A0B01 VA: 0x2A0A00
	public Vector3 IKPosition; // 0x14
	[RangeAttribute] // RVA: 0x2A0A10 Offset: 0x2A0B11 VA: 0x2A0A10
	[TooltipAttribute] // RVA: 0x2A0A10 Offset: 0x2A0B11 VA: 0x2A0A10
	public float IKPositionWeight; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2A0A70 Offset: 0x2A0B71 VA: 0x2A0A70
	private bool <initiated>k__BackingField; // 0x24
	public IKSolver.UpdateDelegate OnPreInitiate; // 0x28
	public IKSolver.UpdateDelegate OnPostInitiate; // 0x30
	public IKSolver.UpdateDelegate OnPreUpdate; // 0x38
	public IKSolver.UpdateDelegate OnPostUpdate; // 0x40
	protected bool firstInitiation; // 0x48
	[SerializeField] // RVA: 0x2A0A80 Offset: 0x2A0B81 VA: 0x2A0A80
	[HideInInspector] // RVA: 0x2A0A80 Offset: 0x2A0B81 VA: 0x2A0A80
	protected Transform root; // 0x50

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: 0x3C5CA50 Offset: 0x3C5CB51 VA: 0x3C5CA50
	public bool IsValid() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsValid(ref string message);

	// RVA: 0x3C5CAD0 Offset: 0x3C5CBD1 VA: 0x3C5CAD0
	public void Initiate(Transform root) { }

	// RVA: 0x3C5CC30 Offset: 0x3C5CD31 VA: 0x3C5CC30
	public void Update() { }

	// RVA: 0x3C5CCA0 Offset: 0x3C5CDA1 VA: 0x3C5CCA0 Slot: 5
	public virtual Vector3 GetIKPosition() { }

	// RVA: 0x3C5CCB0 Offset: 0x3C5CDB1 VA: 0x3C5CCB0
	public void SetIKPosition(Vector3 position) { }

	// RVA: 0x3C5CCC0 Offset: 0x3C5CDC1 VA: 0x3C5CCC0
	public float GetIKPositionWeight() { }

	// RVA: 0x3C5CCD0 Offset: 0x3C5CDD1 VA: 0x3C5CCD0
	public void SetIKPositionWeight(float weight) { }

	// RVA: 0x3C5CD00 Offset: 0x3C5CE01 VA: 0x3C5CD00
	public Transform GetRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF9C0 Offset: 0x2CFAC1 VA: 0x2CF9C0
	// RVA: 0x3C5CD10 Offset: 0x3C5CE11 VA: 0x3C5CD10
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF9D0 Offset: 0x2CFAD1 VA: 0x2CF9D0
	// RVA: 0x3C5CD20 Offset: 0x3C5CE21 VA: 0x3C5CD20
	private void set_initiated(bool value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IKSolver.Point[] GetPoints();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IKSolver.Point GetPoint(Transform transform);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FixTransforms();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void StoreDefaultLocalState();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnInitiate();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnUpdate();

	// RVA: 0x3C5CD30 Offset: 0x3C5CE31 VA: 0x3C5CD30
	protected void LogWarning(string message) { }

	// RVA: 0x3C5CD50 Offset: 0x3C5CE51 VA: 0x3C5CD50
	public static Transform ContainsDuplicateBone(IKSolver.Bone[] bones) { }

	// RVA: 0x3C5CE80 Offset: 0x3C5CF81 VA: 0x3C5CE80
	public static bool HierarchyIsValid(IKSolver.Bone[] bones) { }

	// RVA: 0x3C5CF30 Offset: 0x3C5D031 VA: 0x3C5CF30
	protected static float PreSolveBones(ref IKSolver.Bone[] bones) { }

	// RVA: 0x3C5D170 Offset: 0x3C5D271 VA: 0x3C5D170
	protected void .ctor() { }
}

