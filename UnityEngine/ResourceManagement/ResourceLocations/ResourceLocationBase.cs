// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public class ResourceLocationBase : IResourceLocation // TypeDefIndex: 5605
{
	// Fields
	private string m_Name; // 0x10
	private string m_Id; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Data; // 0x28
	private int m_DependencyHashCode; // 0x30
	private int m_HashCode; // 0x34
	private Type m_Type; // 0x38
	private List<IResourceLocation> m_Dependencies; // 0x40
	private string m_PrimaryKey; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public object Data { get; set; }
	public string PrimaryKey { get; set; }
	public int DependencyHashCode { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x3630FE0 Offset: 0x36310E1 VA: 0x3630FE0 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x3630FF0 Offset: 0x36310F1 VA: 0x3630FF0 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x3631000 Offset: 0x3631101 VA: 0x3631000 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x3631010 Offset: 0x3631111 VA: 0x3631010 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x3631070 Offset: 0x3631171 VA: 0x3631070 Slot: 10
	public object get_Data() { }

	// RVA: 0x3631080 Offset: 0x3631181 VA: 0x3631080
	public void set_Data(object value) { }

	// RVA: 0x3631090 Offset: 0x3631191 VA: 0x3631090 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x36310A0 Offset: 0x36311A1 VA: 0x36310A0
	public void set_PrimaryKey(string value) { }

	// RVA: 0x36310B0 Offset: 0x36311B1 VA: 0x36310B0 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x36310C0 Offset: 0x36311C1 VA: 0x36310C0 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x36310D0 Offset: 0x36311D1 VA: 0x36310D0 Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x3631120 Offset: 0x3631221 VA: 0x3631120 Slot: 3
	public override string ToString() { }

	// RVA: 0x3631130 Offset: 0x3631231 VA: 0x3631130
	public void .ctor(string name, string id, string providerId, Type t, IResourceLocation[] dependencies) { }

	// RVA: 0x36313B0 Offset: 0x36314B1 VA: 0x36313B0
	public void ComputeDependencyHash() { }
}

