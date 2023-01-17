// Namespace: App
public class PhotographSelectScarfColorMenuItem : BasicMenuItem // TypeDefIndex: 11525
{
	// Fields
	private bool m_IsCurrent; // 0x64
	private PhotographDisposManager m_DisposManager; // 0x68
	private int m_ColorIdx; // 0x70
	private int m_ColorIdxOld; // 0x74

	// Properties
	public bool IsCurrent { get; }

	// Methods

	// RVA: 0x2A3A710 Offset: 0x2A3A811 VA: 0x2A3A710
	public bool get_IsCurrent() { }

	// RVA: 0x2A3A1A0 Offset: 0x2A3A2A1 VA: 0x2A3A1A0
	public void .ctor(int colorIdx, int colorIdxOld, PhotographDisposManager disposManager, bool isCurrent) { }

	// RVA: 0x2A3A720 Offset: 0x2A3A821 VA: 0x2A3A720 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2A3A860 Offset: 0x2A3A961 VA: 0x2A3A860 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2A3A870 Offset: 0x2A3A971 VA: 0x2A3A870 Slot: 19
	public override BasicMenu.Result BCall() { }
}

