// Namespace: App
internal class BgmSelectPlayer : BgmPlayer // TypeDefIndex: 11330
{
	// Fields
	private GameSound.Handle m_handle; // 0x10
	private List<GameSound.Handle> m_soundList; // 0x18

	// Methods

	// RVA: 0x2262FE0 Offset: 0x22630E1 VA: 0x2262FE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2262FF0 Offset: 0x22630F1 VA: 0x2262FF0 Slot: 6
	public override bool IsPlaying(string eventName) { }

	// RVA: 0x2263060 Offset: 0x2263161 VA: 0x2263060 Slot: 4
	public override void PauseCurrentBgm() { }

	// RVA: 0x2263390 Offset: 0x2263491 VA: 0x2263390 Slot: 8
	public override void PlaySelect(string eventName) { }

	// RVA: 0x22633E0 Offset: 0x22634E1 VA: 0x22633E0 Slot: 11
	public override void Close() { }

	// RVA: 0x2263690 Offset: 0x2263791 VA: 0x2263690
	public void .ctor() { }
}

