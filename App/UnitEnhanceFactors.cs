// Namespace: App
public class UnitEnhanceFactors // TypeDefIndex: 13526
{
	// Fields
	private const int Version = 6;
	private UnitEnhanceValues m_HubValues; // 0x10
	private UnitEnhanceValues m_FoodValues; // 0x18
	private UnitEnhanceValues m_ItemValues; // 0x20

	// Properties
	public UnitEnhanceValues HubValues { get; }
	public UnitEnhanceValues FoodValues { get; }
	public UnitEnhanceValues ItemValues { get; }

	// Methods

	// RVA: 0x23E2DE0 Offset: 0x23E2EE1 VA: 0x23E2DE0
	public void .ctor() { }

	// RVA: 0x23E2F70 Offset: 0x23E3071 VA: 0x23E2F70
	public void Copy(UnitEnhanceFactors factors) { }

	// RVA: 0x23E34F0 Offset: 0x23E35F1 VA: 0x23E34F0
	public void Clear() { }

	// RVA: 0x23E3820 Offset: 0x23E3921 VA: 0x23E3820
	public void SetHub(UnitEnhanceValues values) { }

	// RVA: 0x23E3A00 Offset: 0x23E3B01 VA: 0x23E3A00
	public void SetHubValue(CapabilityDefinition.Type index, int value) { }

	// RVA: 0x23E3A80 Offset: 0x23E3B81 VA: 0x23E3A80
	public void SetHubValue(int index, int value) { }

	// RVA: 0x23E3520 Offset: 0x23E3621 VA: 0x23E3520
	public void ClearHub() { }

	// RVA: 0x23E3AC0 Offset: 0x23E3BC1 VA: 0x23E3AC0
	public void SetFoodValues(UnitEnhanceValues values) { }

	// RVA: 0x23E3CA0 Offset: 0x23E3DA1 VA: 0x23E3CA0
	public void SetFoodValue(CapabilityDefinition.Type index, int value) { }

	// RVA: 0x23E3CE0 Offset: 0x23E3DE1 VA: 0x23E3CE0
	public void SetFoodValue(int index, int value) { }

	// RVA: 0x23E3620 Offset: 0x23E3721 VA: 0x23E3620
	public void ClearFoodValues() { }

	// RVA: 0x23E3D20 Offset: 0x23E3E21 VA: 0x23E3D20
	public void SetItemValue(ItemData item) { }

	// RVA: 0x23E3F40 Offset: 0x23E4041 VA: 0x23E3F40
	public void AddItemValue(ItemData item) { }

	// RVA: 0x23E4030 Offset: 0x23E4131 VA: 0x23E4030
	public void SetItemValue(int index, int value) { }

	// RVA: 0x23E3720 Offset: 0x23E3821 VA: 0x23E3720
	public void ClearItemValue() { }

	// RVA: 0x23E4070 Offset: 0x23E4171 VA: 0x23E4070
	public void Serialize(Stream stream) { }

	// RVA: 0x23E40C0 Offset: 0x23E41C1 VA: 0x23E40C0
	public void Deserialize(Stream stream) { }

	// RVA: 0x23E4350 Offset: 0x23E4451 VA: 0x23E4350
	public UnitEnhanceValues get_HubValues() { }

	// RVA: 0x23E4360 Offset: 0x23E4461 VA: 0x23E4360
	public UnitEnhanceValues get_FoodValues() { }

	// RVA: 0x23E4370 Offset: 0x23E4471 VA: 0x23E4370
	public UnitEnhanceValues get_ItemValues() { }
}

