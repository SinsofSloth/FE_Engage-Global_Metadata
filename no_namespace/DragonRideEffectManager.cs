// Namespace: 
public class DragonRideEffectManager.EffectReserver // TypeDefIndex: 10506
{
	// Fields
	private GameObject[] m_Reserve; // 0x10
	private string m_TypeName; // 0x18
	private int m_CountMax; // 0x20
	private int m_UseCount; // 0x24
	private int m_ReturnCount; // 0x28

	// Methods

	// RVA: 0x1F004B0 Offset: 0x1F005B1 VA: 0x1F004B0
	public void .ctor() { }

	// RVA: 0x1F00520 Offset: 0x1F00621 VA: 0x1F00520
	public void CreateReserve(string typeName, string path, GameObject rootObj, int max) { }

	// RVA: 0x1F00700 Offset: 0x1F00801 VA: 0x1F00700
	public GameObject RentalObj() { }

	// RVA: 0x1F00750 Offset: 0x1F00851 VA: 0x1F00750
	public void ReturnObj(GameObject rootObj, GameObject obj) { }

	// RVA: 0x1F00860 Offset: 0x1F00961 VA: 0x1F00860
	public void Destruct() { }
}

