// Namespace: 
public class SpringColliderSerialization.ParsedColliderSetup // TypeDefIndex: 6384
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5B730 Offset: 0x5B831 VA: 0x5B730
	private IEnumerable<DynamicsSetup.ParseMessage> <Errors>k__BackingField; // 0x10
	private IEnumerable<SpringColliderSerialization.IColliderSerializer> colliderRecords; // 0x18
	private IEnumerable<SpringColliderSerialization.TransformSerializer> dynamicsNullRecords; // 0x20
	private List<TextRecordParsing.Record> componentRecords; // 0x28

	// Properties
	public IEnumerable<DynamicsSetup.ParseMessage> Errors { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x5C240 Offset: 0x5C341 VA: 0x5C240
	// RVA: 0x3A7D6E0 Offset: 0x3A7D7E1 VA: 0x3A7D6E0
	public IEnumerable<DynamicsSetup.ParseMessage> get_Errors() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C250 Offset: 0x5C351 VA: 0x5C250
	// RVA: 0x3A7D6F0 Offset: 0x3A7D7F1 VA: 0x3A7D6F0
	public void set_Errors(IEnumerable<DynamicsSetup.ParseMessage> value) { }

	// RVA: 0x3A7D700 Offset: 0x3A7D801 VA: 0x3A7D700
	public static SpringColliderSerialization.ParsedColliderSetup ReadColliderSetupFromText(GameObject colliderRoot, string recordText) { }

	// RVA: 0x3A7DDA0 Offset: 0x3A7DEA1 VA: 0x3A7DDA0
	public void BuildObjects(GameObject colliderRoot) { }

	// RVA: 0x3A7E0A0 Offset: 0x3A7E1A1 VA: 0x3A7E0A0
	public IEnumerable<string> GetColliderNames() { }

	// RVA: 0x3A7DD90 Offset: 0x3A7DE91 VA: 0x3A7DD90
	public void .ctor() { }
}

// Namespace: 
private class SpringColliderSerialization.ColliderSerializerBaseInfo // TypeDefIndex: 6386
{
	// Fields
	public SpringColliderSerialization.TransformSerializer transform; // 0x10
	public string colliderType; // 0x18

	// Methods

	// RVA: 0x3A7D5E0 Offset: 0x3A7D6E1 VA: 0x3A7D5E0
	public void .ctor() { }
}

// Namespace: 
private class SpringColliderSerialization.SphereColliderSerializer : SpringColliderSerialization.IColliderSerializer // TypeDefIndex: 6388
{
	// Fields
	public SpringColliderSerialization.ColliderSerializerBaseInfo baseInfo; // 0x10
	public float radius; // 0x18
	public string linkedRenderer; // 0x20

	// Methods

	// RVA: 0x3A7E1D0 Offset: 0x3A7E2D1 VA: 0x3A7E1D0 Slot: 4
	public SpringColliderSerialization.ColliderSerializerBaseInfo GetBaseInfo() { }

	// RVA: 0x3A7E1E0 Offset: 0x3A7E2E1 VA: 0x3A7E1E0 Slot: 5
	public Component BuildColliderComponent(GameObject gameObject) { }

	// RVA: 0x3A7E290 Offset: 0x3A7E391 VA: 0x3A7E290 Slot: 6
	public string GetLinkedRendererName() { }

	// RVA: 0x3A7E2A0 Offset: 0x3A7E3A1 VA: 0x3A7E2A0
	public void .ctor() { }
}

// Namespace: 
private class SpringColliderSerialization.PanelColliderSerializer : SpringColliderSerialization.IColliderSerializer // TypeDefIndex: 6390
{
	// Fields
	public SpringColliderSerialization.ColliderSerializerBaseInfo baseInfo; // 0x10
	public float width; // 0x18
	public float height; // 0x1C
	public string linkedRenderer; // 0x20

	// Methods

	// RVA: 0x3A7D5F0 Offset: 0x3A7D6F1 VA: 0x3A7D5F0 Slot: 4
	public SpringColliderSerialization.ColliderSerializerBaseInfo GetBaseInfo() { }

	// RVA: 0x3A7D600 Offset: 0x3A7D701 VA: 0x3A7D600 Slot: 5
	public Component BuildColliderComponent(GameObject gameObject) { }

	// RVA: 0x3A7D6C0 Offset: 0x3A7D7C1 VA: 0x3A7D6C0 Slot: 6
	public string GetLinkedRendererName() { }

	// RVA: 0x3A7D6D0 Offset: 0x3A7D7D1 VA: 0x3A7D6D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B320 Offset: 0x5B421 VA: 0x5B320
private sealed class SpringColliderSerialization.<>c__DisplayClass16_0 // TypeDefIndex: 6392
{
	// Fields
	public Transform parent; // 0x10
	public string name; // 0x18

	// Methods

	// RVA: 0x3A7D3A0 Offset: 0x3A7D4A1 VA: 0x3A7D3A0
	public void .ctor() { }

	// RVA: 0x3A7D3B0 Offset: 0x3A7D4B1 VA: 0x3A7D3B0
	internal Transform <GetChildByName>b__0(int index) { }

	// RVA: 0x3A7D3C0 Offset: 0x3A7D4C1 VA: 0x3A7D3C0
	internal bool <GetChildByName>b__1(Transform child) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B340 Offset: 0x5B441 VA: 0x5B340
private sealed class SpringColliderSerialization.<>c__DisplayClass28_0 // TypeDefIndex: 6394
{
	// Fields
	public string objectName; // 0x10

	// Methods

	// RVA: 0x3A7D420 Offset: 0x3A7D521 VA: 0x3A7D420
	public void .ctor() { }

	// RVA: 0x3A7D430 Offset: 0x3A7D531 VA: 0x3A7D430
	internal bool <VerifyColliderRecords>b__0(SpringColliderSerialization.IColliderSerializer item) { }
}

