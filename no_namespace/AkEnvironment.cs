// Namespace: 
[AddComponentMenu] // RVA: 0x272280 Offset: 0x272381 VA: 0x272280
[ExecuteInEditMode] // RVA: 0x272280 Offset: 0x272381 VA: 0x272280
[RequireComponent] // RVA: 0x272280 Offset: 0x272381 VA: 0x272280
public class AkEnvironment : MonoBehaviour // TypeDefIndex: 8013
{
	// Fields
	public const int MAX_NB_ENVIRONMENTS = 4;
	public static AkEnvironment.AkEnvironment_CompareByPriority s_compareByPriority; // 0x0
	public static AkEnvironment.AkEnvironment_CompareBySelectionAlgorithm s_compareBySelectionAlgorithm; // 0x8
	public bool excludeOthers; // 0x18
	public bool isDefault; // 0x19
	public AuxBus data; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x27E9C0 Offset: 0x27EAC1 VA: 0x27E9C0
	private Collider <Collider>k__BackingField; // 0x28
	public int priority; // 0x30
	[SerializeField] // RVA: 0x27E9D0 Offset: 0x27EAD1 VA: 0x27E9D0
	[HideInInspector] // RVA: 0x27E9D0 Offset: 0x27EAD1 VA: 0x27E9D0
	[FormerlySerializedAsAttribute] // RVA: 0x27E9D0 Offset: 0x27EAD1 VA: 0x27E9D0
	private int auxBusIdInternal; // 0x34
	[HideInInspector] // RVA: 0x27EA30 Offset: 0x27EB31 VA: 0x27EA30
	[FormerlySerializedAsAttribute] // RVA: 0x27EA30 Offset: 0x27EB31 VA: 0x27EA30
	[SerializeField] // RVA: 0x27EA30 Offset: 0x27EB31 VA: 0x27EA30
	private byte[] valueGuidInternal; // 0x38

	// Properties
	public Collider Collider { get; set; }
	[ObsoleteAttribute] // RVA: 0x2D4880 Offset: 0x2D4981 VA: 0x2D4880
	public int m_auxBusID { get; }
	[ObsoleteAttribute] // RVA: 0x2D48C0 Offset: 0x2D49C1 VA: 0x2D48C0
	public byte[] valueGuid { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A7180 Offset: 0x2A7281 VA: 0x2A7180
	// RVA: 0x3171DE0 Offset: 0x3171EE1 VA: 0x3171DE0
	public Collider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7190 Offset: 0x2A7291 VA: 0x2A7190
	// RVA: 0x3171DF0 Offset: 0x3171EF1 VA: 0x3171DF0
	private void set_Collider(Collider value) { }

	// RVA: 0x3171E00 Offset: 0x3171F01 VA: 0x3171E00
	public void Awake() { }

	// RVA: 0x3171E70 Offset: 0x3171F71 VA: 0x3171E70
	public int get_m_auxBusID() { }

	// RVA: 0x3171E90 Offset: 0x3171F91 VA: 0x3171E90
	public byte[] get_valueGuid() { }

	[ObsoleteAttribute] // RVA: 0x2A71A0 Offset: 0x2A72A1 VA: 0x2A71A0
	// RVA: 0x3171F50 Offset: 0x3172051 VA: 0x3171F50
	public uint GetAuxBusID() { }

	[ObsoleteAttribute] // RVA: 0x2A71E0 Offset: 0x2A72E1 VA: 0x2A71E0
	// RVA: 0x3171F60 Offset: 0x3172061 VA: 0x3171F60
	public Collider GetCollider() { }

	// RVA: 0x3171F70 Offset: 0x3172071 VA: 0x3171F70
	public void .ctor() { }

	// RVA: 0x3171FF0 Offset: 0x31720F1 VA: 0x3171FF0
	private static void .cctor() { }
}

