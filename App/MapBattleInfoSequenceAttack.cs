// Namespace: App
internal class MapBattleInfoSequenceAttack : MonoBehaviour // TypeDefIndex: 12481
{
	// Fields
	public TextMeshProUGUI m_DefenseDamage; // 0x18
	public Image m_DefenseArrow; // 0x20
	public Image m_DefenseDead; // 0x28
	[SpaceAttribute] // RVA: 0x29A330 Offset: 0x29A431 VA: 0x29A330
	public TextMeshProUGUI m_OffenseDamage; // 0x30
	public Image m_OffenseArrow; // 0x38
	public Image m_OffenseDead; // 0x40
	[SpaceAttribute] // RVA: 0x29A340 Offset: 0x29A441 VA: 0x29A340
	public TextMeshProUGUI m_DefenseResult; // 0x48
	public TextMeshProUGUI m_OffenseResult; // 0x50
	[SpaceAttribute] // RVA: 0x29A350 Offset: 0x29A451 VA: 0x29A350
	public Material m_DamageMaterial; // 0x58
	public Material m_HealMaterial; // 0x60
	[SpaceAttribute] // RVA: 0x29A360 Offset: 0x29A461 VA: 0x29A360
	public Sprite[] m_ArrowSprite; // 0x68
	private Material m_InstDamageMaterial; // 0x70
	private Material m_InstHealMaterial; // 0x78

	// Methods

	// RVA: 0x2326010 Offset: 0x2326111 VA: 0x2326010
	private void Awake() { }

	// RVA: 0x2324DC0 Offset: 0x2324EC1 VA: 0x2324DC0
	public void Setup(MapBattleInfoSequence.AttackInfo attack, bool isHide) { }

	// RVA: 0x2326470 Offset: 0x2326571 VA: 0x2326470
	private void SetArrow(bool isOffense, Force.Type forceType) { }

	// RVA: 0x23260C0 Offset: 0x23261C1 VA: 0x23260C0
	private void SetReceiveDamage(BattleSide.Type sideType, string atkString, bool isHeal, int receiveFirstDamage, bool isHide) { }

	// RVA: 0x23262E0 Offset: 0x23263E1 VA: 0x23262E0
	private void SetSendDamage(BattleSide.Type sideType, int atk, int sendFirstDamage) { }

	// RVA: 0x2326660 Offset: 0x2326761 VA: 0x2326660
	private void SetSceneResult(MapBattleInfoSequence.AttackInfo.SceneResult offense, MapBattleInfoSequence.AttackInfo.SceneResult defense) { }

	// RVA: 0x23268A0 Offset: 0x23269A1 VA: 0x23268A0
	private void SetDeath(BattleSide.Type side) { }

	// RVA: 0x2326930 Offset: 0x2326A31 VA: 0x2326930
	public void .ctor() { }
}

