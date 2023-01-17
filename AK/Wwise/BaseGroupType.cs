// Namespace: AK.Wwise
[Serializable]
public abstract class BaseGroupType : BaseType // TypeDefIndex: 8070
{
	// Fields
	[SerializeField] // RVA: 0x27F6C0 Offset: 0x27F7C1 VA: 0x27F6C0
	[FormerlySerializedAsAttribute] // RVA: 0x27F6C0 Offset: 0x27F7C1 VA: 0x27F6C0
	[HideInInspector] // RVA: 0x27F6C0 Offset: 0x27F7C1 VA: 0x27F6C0
	private int groupIdInternal; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x27F720 Offset: 0x27F821 VA: 0x27F720
	[HideInInspector] // RVA: 0x27F720 Offset: 0x27F821 VA: 0x27F720
	[SerializeField] // RVA: 0x27F720 Offset: 0x27F821 VA: 0x27F720
	private byte[] groupGuidInternal; // 0x28

	// Properties
	public WwiseObjectReference GroupWwiseObjectReference { get; }
	public abstract WwiseObjectType WwiseObjectGroupType { get; }
	public uint GroupId { get; }
	[ObsoleteAttribute] // RVA: 0x2D4C00 Offset: 0x2D4D01 VA: 0x2D4C00
	public int groupID { get; }
	[ObsoleteAttribute] // RVA: 0x2D4C40 Offset: 0x2D4D41 VA: 0x2D4C40
	public byte[] groupGuid { get; }

	// Methods

	// RVA: 0x28EFA90 Offset: 0x28EFB91 VA: 0x28EFA90
	public WwiseObjectReference get_GroupWwiseObjectReference() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract WwiseObjectType get_WwiseObjectGroupType();

	// RVA: 0x28EFB90 Offset: 0x28EFC91 VA: 0x28EFB90
	public uint get_GroupId() { }

	// RVA: 0x28EFC40 Offset: 0x28EFD41 VA: 0x28EFC40 Slot: 8
	public override bool IsValid() { }

	// RVA: 0x28EFDC0 Offset: 0x28EFEC1 VA: 0x28EFDC0
	public int get_groupID() { }

	// RVA: 0x28EFE70 Offset: 0x28EFF71 VA: 0x28EFE70
	public byte[] get_groupGuid() { }

	// RVA: 0x28EFF30 Offset: 0x28F0031 VA: 0x28EFF30
	protected void .ctor() { }
}

