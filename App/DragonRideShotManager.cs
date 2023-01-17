// Namespace: App
public class DragonRideShotManager : SingletonClass<DragonRideShotManager> // TypeDefIndex: 10535
{
	// Fields
	private GameObject m_PoolParent; // 0x20
	private int m_UseCount; // 0x28
	private int m_ReturnCount; // 0x2C
	private GameObject[] m_ReservePoolArray; // 0x30
	private int MaxShotCount; // 0x38
	private float m_DefaultInterpSecond; // 0x3C
	private float m_DefaultShotSpeed; // 0x40
	private float m_DefaultLifeSecond; // 0x44
	private bool m_IsPenetrate; // 0x48

	// Methods

	// RVA: 0x2DD7EB0 Offset: 0x2DD7FB1 VA: 0x2DD7EB0
	public void .ctor() { }

	// RVA: 0x2DCE000 Offset: 0x2DCE101 VA: 0x2DCE000
	public void Destruct() { }

	// RVA: 0x2DD8140 Offset: 0x2DD8241 VA: 0x2DD8140
	public void SetDefaultParam(float interpSecond, float shotSpeed, float lifeSecond, bool isPenetrate) { }

	// RVA: 0x2DD8160 Offset: 0x2DD8261 VA: 0x2DD8160
	public void Tick() { }

	// RVA: 0x2DD8220 Offset: 0x2DD8321 VA: 0x2DD8220
	public void InactiveAllShot() { }

	// RVA: 0x2DD82B0 Offset: 0x2DD83B1 VA: 0x2DD82B0
	public void SetActiveShot(Vector3 pos, Vector3 target, Vector3 straight, Vector3 diff, bool isAssist, bool isSpecialTime, bool isPenetrate, bool isMaximum = False) { }

	// RVA: 0x2DD7B20 Offset: 0x2DD7C21 VA: 0x2DD7B20
	public void ResetShot(GameObject obj) { }
}

