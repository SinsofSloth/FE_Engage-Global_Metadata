// Namespace: App
public class PhotographSelectFaceAccMenuItem : BasicMenuItem // TypeDefIndex: 11516
{
	// Fields
	private bool m_IsCurrent; // 0x64
	private bool m_IsMascot; // 0x65
	private AccessoryData m_FaceAccData; // 0x68
	private PhotographDisposManager m_DisposManager; // 0x70

	// Properties
	public bool IsCurrent { get; }
	public bool IsMascot { get; }

	// Methods

	// RVA: 0x2A379D0 Offset: 0x2A37AD1 VA: 0x2A379D0
	public bool get_IsCurrent() { }

	// RVA: 0x2A379E0 Offset: 0x2A37AE1 VA: 0x2A379E0
	public bool get_IsMascot() { }

	// RVA: 0x2A37420 Offset: 0x2A37521 VA: 0x2A37420
	public void .ctor(AccessoryData faceAccData, PhotographDisposManager disposManager, bool isCurrent) { }

	// RVA: 0x2A379F0 Offset: 0x2A37AF1 VA: 0x2A379F0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2A37A50 Offset: 0x2A37B51 VA: 0x2A37A50 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2A37A60 Offset: 0x2A37B61 VA: 0x2A37A60 Slot: 19
	public override BasicMenu.Result BCall() { }
}

