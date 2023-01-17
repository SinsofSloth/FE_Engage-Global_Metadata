// Namespace: App
public abstract class BgmPlayer // TypeDefIndex: 11327
{
	// Methods

	// RVA: 0x2262E50 Offset: 0x2262F51 VA: 0x2262E50 Slot: 4
	public virtual void PauseCurrentBgm() { }

	// RVA: 0x2262E60 Offset: 0x2262F61 VA: 0x2262E60 Slot: 5
	public virtual bool IsPlaying() { }

	// RVA: 0x2262E70 Offset: 0x2262F71 VA: 0x2262E70 Slot: 6
	public virtual bool IsPlaying(string eventName) { }

	// RVA: 0x2262E80 Offset: 0x2262F81 VA: 0x2262E80 Slot: 7
	public virtual void Play(string eventName) { }

	// RVA: 0x2262E90 Offset: 0x2262F91 VA: 0x2262E90 Slot: 8
	public virtual void PlaySelect(string eventName) { }

	// RVA: 0x2262EA0 Offset: 0x2262FA1 VA: 0x2262EA0 Slot: 9
	public virtual void Stop() { }

	// RVA: 0x2262EB0 Offset: 0x2262FB1 VA: 0x2262EB0 Slot: 10
	public virtual void Tick(MyRoomSoundMenu menu) { }

	// RVA: 0x2262EC0 Offset: 0x2262FC1 VA: 0x2262EC0 Slot: 11
	public virtual void Close() { }

	// RVA: 0x2262ED0 Offset: 0x2262FD1 VA: 0x2262ED0
	protected static GameSound.Handle PlaySound(string eventName) { }

	// RVA: 0x2262FD0 Offset: 0x22630D1 VA: 0x2262FD0
	protected void .ctor() { }
}

