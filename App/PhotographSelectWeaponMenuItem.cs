// Namespace: App
public class PhotographSelectWeaponMenuItem : BasicMenuItem // TypeDefIndex: 11529
{
	// Fields
	private bool m_IsCurrent; // 0x64
	private ItemData m_WeaponData; // 0x68
	private PhotographDisposManager m_DisposManager; // 0x70

	// Properties
	public bool IsCurrent { get; }
	public ItemData WeaponData { get; }

	// Methods

	// RVA: 0x2A3B580 Offset: 0x2A3B681 VA: 0x2A3B580
	public bool get_IsCurrent() { }

	// RVA: 0x2A3B590 Offset: 0x2A3B691 VA: 0x2A3B590
	public ItemData get_WeaponData() { }

	// RVA: 0x2A3B0B0 Offset: 0x2A3B1B1 VA: 0x2A3B0B0
	public void .ctor(ItemData weaponData, PhotographDisposManager disposManager, bool isCurrent) { }

	// RVA: 0x2A3B5A0 Offset: 0x2A3B6A1 VA: 0x2A3B5A0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2A3B600 Offset: 0x2A3B701 VA: 0x2A3B600 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2A3B610 Offset: 0x2A3B711 VA: 0x2A3B610 Slot: 19
	public override BasicMenu.Result BCall() { }
}

