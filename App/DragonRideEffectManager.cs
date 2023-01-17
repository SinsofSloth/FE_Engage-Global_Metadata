// Namespace: App
public class DragonRideEffectManager : SingletonClass<DragonRideEffectManager> // TypeDefIndex: 10508
{
	// Fields
	private int MaxNormalCount; // 0x1C
	private int MaxOtherTypeCount; // 0x20
	private int MaxShotCount; // 0x24
	private int MaxMaximumAssistCount; // 0x28
	private string EffecttRoot; // 0x30
	private string PathTargetNormal; // 0x38
	private string PathTargetBig; // 0x40
	private string PathTargetLink; // 0x48
	private string PathTargetSpecial; // 0x50
	private string PathShotPlayer; // 0x58
	private string PathShotAssist; // 0x60
	private string PathMaximumAssist; // 0x68
	private GameObject m_EffectParent; // 0x70
	private DragonRideEffectManager.EffectReserver m_NormalReserve; // 0x78
	private DragonRideEffectManager.EffectReserver m_BigReserve; // 0x80
	private DragonRideEffectManager.EffectReserver m_LinkReserve; // 0x88
	private DragonRideEffectManager.EffectReserver m_SpecialReserve; // 0x90
	private DragonRideEffectManager.EffectReserver m_ShotPReserve; // 0x98
	private DragonRideEffectManager.EffectReserver m_ShotAReserve; // 0xA0
	private DragonRideEffectManager.EffectReserver m_MaximumReserve; // 0xA8

	// Properties
	public DragonRideEffectManager.EffectReserver Normal { get; }
	public DragonRideEffectManager.EffectReserver Big { get; }
	public DragonRideEffectManager.EffectReserver Link { get; }
	public DragonRideEffectManager.EffectReserver Special { get; }
	public DragonRideEffectManager.EffectReserver ShotPlayer { get; }
	public DragonRideEffectManager.EffectReserver ShotAssist { get; }
	public DragonRideEffectManager.EffectReserver MaximumAssist { get; }

	// Methods

	// RVA: 0x2DC2C00 Offset: 0x2DC2D01 VA: 0x2DC2C00
	public DragonRideEffectManager.EffectReserver get_Normal() { }

	// RVA: 0x2DC2C10 Offset: 0x2DC2D11 VA: 0x2DC2C10
	public DragonRideEffectManager.EffectReserver get_Big() { }

	// RVA: 0x2DC2C20 Offset: 0x2DC2D21 VA: 0x2DC2C20
	public DragonRideEffectManager.EffectReserver get_Link() { }

	// RVA: 0x2DC2C30 Offset: 0x2DC2D31 VA: 0x2DC2C30
	public DragonRideEffectManager.EffectReserver get_Special() { }

	// RVA: 0x2DC2C40 Offset: 0x2DC2D41 VA: 0x2DC2C40
	public DragonRideEffectManager.EffectReserver get_ShotPlayer() { }

	// RVA: 0x2DC2C50 Offset: 0x2DC2D51 VA: 0x2DC2C50
	public DragonRideEffectManager.EffectReserver get_ShotAssist() { }

	// RVA: 0x2DC2C60 Offset: 0x2DC2D61 VA: 0x2DC2C60
	public DragonRideEffectManager.EffectReserver get_MaximumAssist() { }

	// RVA: 0x2DC2C70 Offset: 0x2DC2D71 VA: 0x2DC2C70
	public void .ctor() { }

	// RVA: 0x2DC3190 Offset: 0x2DC3291 VA: 0x2DC3190
	public void Destruct() { }

	// RVA: 0x2DC3260 Offset: 0x2DC3361 VA: 0x2DC3260
	public void Tick() { }

	// RVA: 0x2DC3270 Offset: 0x2DC3371 VA: 0x2DC3270
	public void CheckReserveListCondition() { }

	// RVA: 0x2DC3280 Offset: 0x2DC3381 VA: 0x2DC3280
	public void ReturnNormal(GameObject obj) { }

	// RVA: 0x2DC32A0 Offset: 0x2DC33A1 VA: 0x2DC32A0
	public void ReturnBig(GameObject obj) { }

	// RVA: 0x2DC32C0 Offset: 0x2DC33C1 VA: 0x2DC32C0
	public void ReturnLink(GameObject obj) { }

	// RVA: 0x2DC32E0 Offset: 0x2DC33E1 VA: 0x2DC32E0
	public void ReturnSpecial(GameObject obj) { }

	// RVA: 0x2DC3300 Offset: 0x2DC3401 VA: 0x2DC3300
	public void ReturnShotPlayer(GameObject obj) { }

	// RVA: 0x2DC3320 Offset: 0x2DC3421 VA: 0x2DC3320
	public void ReturnShotAssist(GameObject obj) { }

	// RVA: 0x2DC3340 Offset: 0x2DC3441 VA: 0x2DC3340
	public void ReturnMaximumAssist(GameObject obj) { }
}

