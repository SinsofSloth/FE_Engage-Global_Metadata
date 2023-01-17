// Namespace: App
public class PhotographSelectPauseMenuItem : BasicMenuItem // TypeDefIndex: 11521
{
	// Fields
	private PhotographPauseData m_PauseData; // 0x68
	private PhotographDisposManager m_DisposManager; // 0x70
	private bool m_IsCurrentPause; // 0x78
	private string m_CharacterId; // 0x80

	// Properties
	public bool IsCurrentPause { get; }

	// Methods

	// RVA: 0x2A39750 Offset: 0x2A39851 VA: 0x2A39750
	public bool get_IsCurrentPause() { }

	// RVA: 0x2A386B0 Offset: 0x2A387B1 VA: 0x2A386B0
	public void .ctor(PhotographPauseData pauseData, PhotographDisposManager disposManager, bool isCurrentPause) { }

	// RVA: 0x2A39760 Offset: 0x2A39861 VA: 0x2A39760 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2A397C0 Offset: 0x2A398C1 VA: 0x2A397C0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2A397D0 Offset: 0x2A398D1 VA: 0x2A397D0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

