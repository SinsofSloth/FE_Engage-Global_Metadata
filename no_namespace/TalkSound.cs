// Namespace: 
private class TalkSound.WaitSE : ProcInst // TypeDefIndex: 13390
{
	// Fields
	private const float MinimumWaitSec = 0.3;
	private float m_Sec; // 0x70

	// Methods

	// RVA: 0x238B480 Offset: 0x238B581 VA: 0x238B480 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x238B550 Offset: 0x238B651 VA: 0x238B550
	public void .ctor() { }
}

// Namespace: 
private enum TalkSound.SoundType // TypeDefIndex: 13391
{
	// Fields
	public int value__; // 0x0
	public const TalkSound.SoundType Se = 0;
	public const TalkSound.SoundType Voice = 1;
	public const TalkSound.SoundType General = 2;
	public const TalkSound.SoundType Bgm = 2;
	public const TalkSound.SoundType Env = 2;
}

