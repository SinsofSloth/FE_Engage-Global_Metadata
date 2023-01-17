// Namespace: 
[AddComponentMenu] // RVA: 0x272D10 Offset: 0x272E11 VA: 0x272D10
[DefaultExecutionOrder] // RVA: 0x272D10 Offset: 0x272E11 VA: 0x272D10
public class AkSwitch : AkDragDropTriggerHandler // TypeDefIndex: 8051
{
	// Fields
	public Switch data; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0x27F540 Offset: 0x27F641 VA: 0x27F540
	[HideInInspector] // RVA: 0x27F540 Offset: 0x27F641 VA: 0x27F540
	[SerializeField] // RVA: 0x27F540 Offset: 0x27F641 VA: 0x27F540
	private int valueIdInternal; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0x27F5A0 Offset: 0x27F6A1 VA: 0x27F5A0
	[SerializeField] // RVA: 0x27F5A0 Offset: 0x27F6A1 VA: 0x27F5A0
	[HideInInspector] // RVA: 0x27F5A0 Offset: 0x27F6A1 VA: 0x27F5A0
	private int groupIdInternal; // 0x3C
	[FormerlySerializedAsAttribute] // RVA: 0x27F600 Offset: 0x27F701 VA: 0x27F600
	[SerializeField] // RVA: 0x27F600 Offset: 0x27F701 VA: 0x27F600
	[HideInInspector] // RVA: 0x27F600 Offset: 0x27F701 VA: 0x27F600
	private byte[] valueGuidInternal; // 0x40
	[SerializeField] // RVA: 0x27F660 Offset: 0x27F761 VA: 0x27F660
	[FormerlySerializedAsAttribute] // RVA: 0x27F660 Offset: 0x27F761 VA: 0x27F660
	[HideInInspector] // RVA: 0x27F660 Offset: 0x27F761 VA: 0x27F660
	private byte[] groupGuidInternal; // 0x48

	// Properties
	protected override BaseType WwiseType { get; }
	[ObsoleteAttribute] // RVA: 0x2D4B00 Offset: 0x2D4C01 VA: 0x2D4B00
	public int valueID { get; }
	[ObsoleteAttribute] // RVA: 0x2D4B40 Offset: 0x2D4C41 VA: 0x2D4B40
	public int groupID { get; }
	[ObsoleteAttribute] // RVA: 0x2D4B80 Offset: 0x2D4C81 VA: 0x2D4B80
	public byte[] valueGuid { get; }
	[ObsoleteAttribute] // RVA: 0x2D4BC0 Offset: 0x2D4CC1 VA: 0x2D4BC0
	public byte[] groupGuid { get; }

	// Methods

	// RVA: 0x20D9860 Offset: 0x20D9961 VA: 0x20D9860 Slot: 9
	protected override BaseType get_WwiseType() { }

	// RVA: 0x20D9870 Offset: 0x20D9971 VA: 0x20D9870 Slot: 4
	public override void HandleEvent(GameObject in_gameObject) { }

	// RVA: 0x20D9920 Offset: 0x20D9A21 VA: 0x20D9920
	public int get_valueID() { }

	// RVA: 0x20D9940 Offset: 0x20D9A41 VA: 0x20D9940
	public int get_groupID() { }

	// RVA: 0x20D9960 Offset: 0x20D9A61 VA: 0x20D9960
	public byte[] get_valueGuid() { }

	// RVA: 0x20D9A20 Offset: 0x20D9B21 VA: 0x20D9A20
	public byte[] get_groupGuid() { }

	// RVA: 0x20D9AD0 Offset: 0x20D9BD1 VA: 0x20D9AD0
	public void .ctor() { }
}

