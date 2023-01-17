// Namespace: AK.Wwise
[Serializable]
public abstract class BaseType // TypeDefIndex: 8071
{
	// Fields
	[HideInInspector] // RVA: 0x27F780 Offset: 0x27F881 VA: 0x27F780
	[SerializeField] // RVA: 0x27F780 Offset: 0x27F881 VA: 0x27F780
	[FormerlySerializedAsAttribute] // RVA: 0x27F780 Offset: 0x27F881 VA: 0x27F780
	private int idInternal; // 0x10
	[SerializeField] // RVA: 0x27F7E0 Offset: 0x27F8E1 VA: 0x27F7E0
	[HideInInspector] // RVA: 0x27F7E0 Offset: 0x27F8E1 VA: 0x27F7E0
	[FormerlySerializedAsAttribute] // RVA: 0x27F7E0 Offset: 0x27F8E1 VA: 0x27F7E0
	private byte[] valueGuidInternal; // 0x18

	// Properties
	public abstract WwiseObjectReference ObjectReference { get; set; }
	public abstract WwiseObjectType WwiseObjectType { get; }
	public virtual string Name { get; }
	public uint Id { get; }
	public static uint InvalidId { get; }
	[ObsoleteAttribute] // RVA: 0x2D4C80 Offset: 0x2D4D81 VA: 0x2D4C80
	public int ID { get; }
	[ObsoleteAttribute] // RVA: 0x2D4CC0 Offset: 0x2D4DC1 VA: 0x2D4CC0
	public byte[] valueGuid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract WwiseObjectReference get_ObjectReference();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_ObjectReference(WwiseObjectReference value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract WwiseObjectType get_WwiseObjectType();

	// RVA: 0x28F0190 Offset: 0x28F0291 VA: 0x28F0190 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x28F0220 Offset: 0x28F0321 VA: 0x28F0220
	public uint get_Id() { }

	// RVA: 0x28F0270 Offset: 0x28F0371 VA: 0x28F0270
	public static uint get_InvalidId() { }

	// RVA: 0x28EFD30 Offset: 0x28EFE31 VA: 0x28EFD30 Slot: 8
	public virtual bool IsValid() { }

	// RVA: 0x28F0280 Offset: 0x28F0381 VA: 0x28F0280
	public bool Validate() { }

	// RVA: 0x28F0370 Offset: 0x28F0471 VA: 0x28F0370
	protected void Verify(AKRESULT result) { }

	// RVA: 0x28F0380 Offset: 0x28F0481 VA: 0x28F0380 Slot: 3
	public override string ToString() { }

	// RVA: 0x28F0420 Offset: 0x28F0521 VA: 0x28F0420
	public int get_ID() { }

	// RVA: 0x28F0470 Offset: 0x28F0571 VA: 0x28F0470
	public byte[] get_valueGuid() { }

	// RVA: 0x28EFF40 Offset: 0x28F0041 VA: 0x28EFF40
	protected void .ctor() { }
}

