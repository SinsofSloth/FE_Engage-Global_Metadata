// Namespace: App
internal class SoundTestPlayer : BgmPlayer // TypeDefIndex: 11328
{
	// Fields
	private GameSound.Handle m_handle; // 0x10
	private bool m_currentPause; // 0x18
	private List<GameSound.Handle> m_soundList; // 0x20

	// Methods

	// RVA: 0x29167E0 Offset: 0x29168E1 VA: 0x29167E0 Slot: 4
	public override void PauseCurrentBgm() { }

	// RVA: 0x29168A0 Offset: 0x29169A1 VA: 0x29168A0 Slot: 5
	public override bool IsPlaying() { }

	// RVA: 0x29168C0 Offset: 0x29169C1 VA: 0x29168C0 Slot: 6
	public override bool IsPlaying(string eventName) { }

	// RVA: 0x2916930 Offset: 0x2916A31 VA: 0x2916930 Slot: 7
	public override void Play(string eventName) { }

	// RVA: 0x2916AF0 Offset: 0x2916BF1 VA: 0x2916AF0 Slot: 9
	public override void Stop() { }

	// RVA: 0x2916CA0 Offset: 0x2916DA1 VA: 0x2916CA0 Slot: 10
	public override void Tick(MyRoomSoundMenu menu) { }

	// RVA: 0x2916D10 Offset: 0x2916E11 VA: 0x2916D10 Slot: 11
	public override void Close() { }

	// RVA: 0x2916EE0 Offset: 0x2916FE1 VA: 0x2916EE0
	public void .ctor() { }
}

