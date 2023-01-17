// Namespace: App
public class BondPopUpController : MonoBehaviour // TypeDefIndex: 11729
{
	// Fields
	private const string PrefabPath = "UI/Hub/ReliancePopUp/Prefabs/BondPopUpRoot";
	[SerializeField] // RVA: 0x298DE0 Offset: 0x298EE1 VA: 0x298DE0
	private GameObject m_PopupObject; // 0x18
	[SerializeField] // RVA: 0x298DF0 Offset: 0x298EF1 VA: 0x298DF0
	private Animator m_Animator; // 0x20
	[SerializeField] // RVA: 0x298E00 Offset: 0x298F01 VA: 0x298E00
	private UnitIcon m_UnitIcon; // 0x28
	[SerializeField] // RVA: 0x298E10 Offset: 0x298F11 VA: 0x298E10
	private UnitIcon m_GodIcon; // 0x30

	// Methods

	// RVA: 0x2C797C0 Offset: 0x2C798C1 VA: 0x2C797C0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2C79860 Offset: 0x2C79961 VA: 0x2C79860
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2C798E0 Offset: 0x2C799E1 VA: 0x2C798E0
	public static void UnloadPrefab() { }

	// RVA: 0x2C79960 Offset: 0x2C79A61 VA: 0x2C79960
	public static BondPopUpController Create(Unit unit, GodUnit god, float offsetPosY = 0) { }

	// RVA: 0x2C79A10 Offset: 0x2C79B11 VA: 0x2C79A10
	public static BondPopUpController Create(Unit unit, GodData god, float offsetPosY = 0) { }

	// RVA: 0x2C79CE0 Offset: 0x2C79DE1 VA: 0x2C79CE0
	public void .ctor() { }

	// RVA: 0x2C79C30 Offset: 0x2C79D31 VA: 0x2C79C30
	public void Initialize(float offsetPosY = 0) { }

	// RVA: 0x2C79CF0 Offset: 0x2C79DF1 VA: 0x2C79CF0
	private void Update() { }

	// RVA: 0x2C79CA0 Offset: 0x2C79DA1 VA: 0x2C79CA0
	public void SetIcon(Unit unit, GodData god) { }
}

