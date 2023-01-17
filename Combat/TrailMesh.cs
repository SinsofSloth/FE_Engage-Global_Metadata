// Namespace: Combat
public abstract class TrailMesh : MonoBehaviour // TypeDefIndex: 8866
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284A90 Offset: 0x284B91 VA: 0x284A90
	private Vector3[] <PosRoot>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x284AA0 Offset: 0x284BA1 VA: 0x284AA0
	private Vector3[] <PosTip>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x284AB0 Offset: 0x284BB1 VA: 0x284AB0
	private float <Alpha>k__BackingField; // 0x28
	public string NumberOfJoints__ReadOnly; // 0x30
	private List<Transform> JointsRoot; // 0x38
	private List<Transform> JointsTip; // 0x40
	private SkinnedMeshRenderer m_Renderer; // 0x48
	private Material m_Material; // 0x50
	private int m_HashColor; // 0x58

	// Properties
	public Vector3[] PosRoot { get; set; }
	public Vector3[] PosTip { get; set; }
	public float Alpha { get; set; }
	public bool IsAlive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AD7F0 Offset: 0x2AD8F1 VA: 0x2AD7F0
	// RVA: 0x25EC320 Offset: 0x25EC421 VA: 0x25EC320
	public Vector3[] get_PosRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD800 Offset: 0x2AD901 VA: 0x2AD800
	// RVA: 0x25EC330 Offset: 0x25EC431 VA: 0x25EC330
	public void set_PosRoot(Vector3[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD810 Offset: 0x2AD911 VA: 0x2AD810
	// RVA: 0x25EC340 Offset: 0x25EC441 VA: 0x25EC340
	public Vector3[] get_PosTip() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD820 Offset: 0x2AD921 VA: 0x2AD820
	// RVA: 0x25EC350 Offset: 0x25EC451 VA: 0x25EC350
	public void set_PosTip(Vector3[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD830 Offset: 0x2AD931 VA: 0x2AD830
	// RVA: 0x25EC360 Offset: 0x25EC461 VA: 0x25EC360
	public float get_Alpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD840 Offset: 0x2AD941 VA: 0x2AD840
	// RVA: 0x25EC370 Offset: 0x25EC471 VA: 0x25EC370
	public void set_Alpha(float value) { }

	// RVA: 0x25EC0F0 Offset: 0x25EC1F1 VA: 0x25EC0F0
	public bool get_IsAlive() { }

	// RVA: 0x25EC380 Offset: 0x25EC481 VA: 0x25EC380
	protected void Start() { }

	// RVA: 0x25EC700 Offset: 0x25EC801 VA: 0x25EC700
	private void OnDestroy() { }

	// RVA: 0x25EC890 Offset: 0x25EC991 VA: 0x25EC890
	protected void LateUpdate() { }

	// RVA: 0x25ECCA0 Offset: 0x25ECDA1 VA: 0x25ECCA0
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD850 Offset: 0x2AD951 VA: 0x2AD850
	// RVA: 0x25ECA30 Offset: 0x25ECB31 VA: 0x25ECA30
	private void <LateUpdate>g__SendPosRot|22_0(int i, ref TrailMesh.<>c__DisplayClass22_0 ) { }
}

