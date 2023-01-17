// Namespace: App
public class UnitActors : SingletonMonoBehaviour<UnitActors> // TypeDefIndex: 8977
{
	// Fields
	private List<UnitActor> m_Actors; // 0x20
	private List<MapInfoRoot> m_ChangeEnableInfoList; // 0x28
	private List<MapInfoRoot> m_ChangeDisableInfoList; // 0x30
	private Vector4[] m_UnitPositionScales; // 0x38
	private const int CanvasVisibilityChangeCountParFrame = 1;

	// Methods

	// RVA: 0x23D8660 Offset: 0x23D8761 VA: 0x23D8660
	private void Update() { }

	// RVA: 0x23D8760 Offset: 0x23D8861 VA: 0x23D8760
	private void LateUpdate() { }

	// RVA: 0x23DA200 Offset: 0x23DA301 VA: 0x23DA200
	private void CreateActorImpl(Unit unit) { }

	// RVA: 0x23DA470 Offset: 0x23DA571 VA: 0x23DA470
	public void DeleteActorImpl(Unit unit) { }

	// RVA: 0x23DA5A0 Offset: 0x23DA6A1 VA: 0x23DA5A0
	public static void CreateActor(Unit unit) { }

	// RVA: 0x23DA660 Offset: 0x23DA761 VA: 0x23DA660
	public static void DeleteActor(Unit unit) { }

	// RVA: 0x23DA710 Offset: 0x23DA811 VA: 0x23DA710
	public void .ctor() { }
}

