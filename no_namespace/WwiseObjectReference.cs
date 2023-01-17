// Namespace: 
public abstract class WwiseObjectReference : ScriptableObject // TypeDefIndex: 7987
{
	// Fields
	[AkShowOnlyAttribute] // RVA: 0x27E5D0 Offset: 0x27E6D1 VA: 0x27E5D0
	[SerializeField] // RVA: 0x27E5D0 Offset: 0x27E6D1 VA: 0x27E5D0
	private string objectName; // 0x18
	[AkShowOnlyAttribute] // RVA: 0x27E610 Offset: 0x27E711 VA: 0x27E610
	[SerializeField] // RVA: 0x27E610 Offset: 0x27E711 VA: 0x27E610
	private uint id; // 0x20
	[SerializeField] // RVA: 0x27E650 Offset: 0x27E751 VA: 0x27E650
	[AkShowOnlyAttribute] // RVA: 0x27E650 Offset: 0x27E751 VA: 0x27E650
	private string guid; // 0x28

	// Properties
	public Guid Guid { get; }
	public string ObjectName { get; }
	public virtual string DisplayName { get; }
	public uint Id { get; }
	public abstract WwiseObjectType WwiseObjectType { get; }

	// Methods

	// RVA: 0x26D9080 Offset: 0x26D9181 VA: 0x26D9080
	public Guid get_Guid() { }

	// RVA: 0x26D9130 Offset: 0x26D9231 VA: 0x26D9130
	public string get_ObjectName() { }

	// RVA: 0x26D9140 Offset: 0x26D9241 VA: 0x26D9140 Slot: 4
	public virtual string get_DisplayName() { }

	// RVA: 0x26D9150 Offset: 0x26D9251 VA: 0x26D9150
	public uint get_Id() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract WwiseObjectType get_WwiseObjectType();

	// RVA: 0x26D8CB0 Offset: 0x26D8DB1 VA: 0x26D8CB0
	protected void .ctor() { }
}

