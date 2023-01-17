// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetLabelReference : IKeyEvaluator // TypeDefIndex: 7283
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x65600 Offset: 0x65701 VA: 0x65600
	[SerializeField] // RVA: 0x65600 Offset: 0x65701 VA: 0x65600
	private string m_LabelString; // 0x10

	// Properties
	public string labelString { get; set; }
	public object RuntimeKey { get; }

	// Methods

	// RVA: 0x3094B40 Offset: 0x3094C41 VA: 0x3094B40
	public string get_labelString() { }

	// RVA: 0x3094B50 Offset: 0x3094C51 VA: 0x3094B50
	public void set_labelString(string value) { }

	// RVA: 0x3094B60 Offset: 0x3094C61 VA: 0x3094B60 Slot: 4
	public object get_RuntimeKey() { }

	// RVA: 0x3094BE0 Offset: 0x3094CE1 VA: 0x3094BE0 Slot: 5
	public bool RuntimeKeyIsValid() { }

	// RVA: 0x3094C70 Offset: 0x3094D71 VA: 0x3094C70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3094C80 Offset: 0x3094D81 VA: 0x3094C80
	public void .ctor() { }
}

