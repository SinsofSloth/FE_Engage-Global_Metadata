// Namespace: App
public class DragonRideTargetManager : SingletonClass<DragonRideTargetManager> // TypeDefIndex: 10548
{
	// Fields
	private int MaxArrayCount; // 0x1C
	private ResourceGameObject m_Prefab; // 0x20
	private GameObject m_ReserveTargetParent; // 0x28
	private int m_ReturnTargetCount; // 0x30
	private GameObject m_ReservePopupParent; // 0x38
	private int m_ReturnPopupCount; // 0x40
	private GameObject[] m_TargetArray; // 0x48
	private GameObject[] m_PopupArray; // 0x50
	private int m_ObjUseCount; // 0x58
	private int m_PopupUseCount; // 0x5C

	// Methods

	// RVA: 0x2DDC970 Offset: 0x2DDCA71 VA: 0x2DDC970
	public void .ctor() { }

	// RVA: 0x2DCDE50 Offset: 0x2DCDF51 VA: 0x2DCDE50
	public void Destruct() { }

	// RVA: 0x2DC97E0 Offset: 0x2DC98E1 VA: 0x2DC97E0
	public void Tick() { }

	// RVA: 0x2DDCD90 Offset: 0x2DDCE91 VA: 0x2DDCD90
	public int GetMaxCount() { }

	// RVA: 0x2DDBE70 Offset: 0x2DDBF71 VA: 0x2DDBE70
	public GameObject RentalTarget() { }

	// RVA: 0x2DDB140 Offset: 0x2DDB241 VA: 0x2DDB140
	public GameObject RentalPopup() { }

	// RVA: 0x2DC9FF0 Offset: 0x2DCA0F1 VA: 0x2DC9FF0
	public void CheckReserveListCondition() { }

	// RVA: 0x2DDB010 Offset: 0x2DDB111 VA: 0x2DDB010
	public void ReturnReserveTarget(GameObject target) { }

	// RVA: 0x2DDCDA0 Offset: 0x2DDCEA1 VA: 0x2DDCDA0
	public void ReturnReservePopup(GameObject target) { }

	// RVA: 0x2DDCE90 Offset: 0x2DDCF91 VA: 0x2DDCE90
	public void HideAllTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF2F0 Offset: 0x2BF3F1 VA: 0x2BF2F0
	// RVA: 0x2DDCF70 Offset: 0x2DDD071 VA: 0x2DDCF70
	private void <.ctor>b__10_0(GameObject targetHandle) { }
}

