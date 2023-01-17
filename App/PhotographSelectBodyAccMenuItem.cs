// Namespace: App
public class PhotographSelectBodyAccMenuItem : BasicMenuItem // TypeDefIndex: 11498
{
	// Fields
	private bool m_IsCurrent; // 0x64
	private bool m_IsMascot; // 0x65
	private AccessoryData m_BodyAccData; // 0x68
	private PhotographDisposManager m_DisposManager; // 0x70

	// Properties
	public bool IsCurrent { get; }
	public bool IsMascot { get; }

	// Methods

	// RVA: 0x2A34F10 Offset: 0x2A35011 VA: 0x2A34F10
	public bool get_IsCurrent() { }

	// RVA: 0x2A34F20 Offset: 0x2A35021 VA: 0x2A34F20
	public bool get_IsMascot() { }

	// RVA: 0x2A349B0 Offset: 0x2A34AB1 VA: 0x2A349B0
	public void .ctor(AccessoryData bodyAccData, PhotographDisposManager disposManager, bool isCurrent, AccessoryShopUtility.Female gender) { }

	// RVA: 0x2A34F30 Offset: 0x2A35031 VA: 0x2A34F30 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2A34F90 Offset: 0x2A35091 VA: 0x2A34F90 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2A34FA0 Offset: 0x2A350A1 VA: 0x2A34FA0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

