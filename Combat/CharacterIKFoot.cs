// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273E20 Offset: 0x273F21 VA: 0x273E20
public sealed class CharacterIKFoot : MonoBehaviour // TypeDefIndex: 8610
{
	// Fields
	private AnimName.Race m_Race; // 0x18
	private Behaviour m_BodyIK; // 0x20
	private Behaviour m_RideIK; // 0x28
	private List<Behaviour> limbIKs; // 0x30

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x2B7A400 Offset: 0x2B7A501 VA: 0x2B7A400
	public void Setup(AnimName.Race race) { }

	// RVA: 0x2B7A9D0 Offset: 0x2B7AAD1 VA: 0x2B7A9D0
	public bool get_IsActive() { }

	// RVA: 0x2B7A610 Offset: 0x2B7A711 VA: 0x2B7A610
	public void SetActive(bool value) { }

	// RVA: 0x2B7AAE0 Offset: 0x2B7ABE1 VA: 0x2B7AAE0
	public void DeactivateIfHorse() { }

	// RVA: 0x2B7AB00 Offset: 0x2B7AC01 VA: 0x2B7AB00
	public void DeactivateIfDragonic() { }

	// RVA: 0x2B7AB20 Offset: 0x2B7AC21 VA: 0x2B7AB20
	public void .ctor() { }
}

