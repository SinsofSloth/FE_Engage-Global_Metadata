// Namespace: 
[DefaultExecutionOrder] // RVA: 0x272C70 Offset: 0x272D71 VA: 0x272C70
[AddComponentMenu] // RVA: 0x272C70 Offset: 0x272D71 VA: 0x272C70
public class AkState : AkDragDropTriggerHandler // TypeDefIndex: 8049
{
	// Fields
	public State data; // 0x30
	[HideInInspector] // RVA: 0x27F1C0 Offset: 0x27F2C1 VA: 0x27F1C0
	[FormerlySerializedAsAttribute] // RVA: 0x27F1C0 Offset: 0x27F2C1 VA: 0x27F1C0
	[SerializeField] // RVA: 0x27F1C0 Offset: 0x27F2C1 VA: 0x27F1C0
	private int valueIdInternal; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0x27F220 Offset: 0x27F321 VA: 0x27F220
	[SerializeField] // RVA: 0x27F220 Offset: 0x27F321 VA: 0x27F220
	[HideInInspector] // RVA: 0x27F220 Offset: 0x27F321 VA: 0x27F220
	private int groupIdInternal; // 0x3C
	[HideInInspector] // RVA: 0x27F280 Offset: 0x27F381 VA: 0x27F280
	[SerializeField] // RVA: 0x27F280 Offset: 0x27F381 VA: 0x27F280
	[FormerlySerializedAsAttribute] // RVA: 0x27F280 Offset: 0x27F381 VA: 0x27F280
	private byte[] valueGuidInternal; // 0x40
	[HideInInspector] // RVA: 0x27F2E0 Offset: 0x27F3E1 VA: 0x27F2E0
	[SerializeField] // RVA: 0x27F2E0 Offset: 0x27F3E1 VA: 0x27F2E0
	[FormerlySerializedAsAttribute] // RVA: 0x27F2E0 Offset: 0x27F3E1 VA: 0x27F2E0
	private byte[] groupGuidInternal; // 0x48

	// Properties
	protected override BaseType WwiseType { get; }
	[ObsoleteAttribute] // RVA: 0x2D49C0 Offset: 0x2D4AC1 VA: 0x2D49C0
	public int valueID { get; }
	[ObsoleteAttribute] // RVA: 0x2D4A00 Offset: 0x2D4B01 VA: 0x2D4A00
	public int groupID { get; }
	[ObsoleteAttribute] // RVA: 0x2D4A40 Offset: 0x2D4B41 VA: 0x2D4A40
	public byte[] valueGuid { get; }
	[ObsoleteAttribute] // RVA: 0x2D4A80 Offset: 0x2D4B81 VA: 0x2D4A80
	public byte[] groupGuid { get; }

	// Methods

	// RVA: 0x20D6D40 Offset: 0x20D6E41 VA: 0x20D6D40 Slot: 9
	protected override BaseType get_WwiseType() { }

	// RVA: 0x20D6D50 Offset: 0x20D6E51 VA: 0x20D6D50 Slot: 4
	public override void HandleEvent(GameObject in_gameObject) { }

	// RVA: 0x20D6D60 Offset: 0x20D6E61 VA: 0x20D6D60
	public int get_valueID() { }

	// RVA: 0x20D6D80 Offset: 0x20D6E81 VA: 0x20D6D80
	public int get_groupID() { }

	// RVA: 0x20D6DA0 Offset: 0x20D6EA1 VA: 0x20D6DA0
	public byte[] get_valueGuid() { }

	// RVA: 0x20D6E60 Offset: 0x20D6F61 VA: 0x20D6E60
	public byte[] get_groupGuid() { }

	// RVA: 0x20D6F10 Offset: 0x20D7011 VA: 0x20D6F10
	public void .ctor() { }
}

