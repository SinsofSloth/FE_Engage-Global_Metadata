// Namespace: App
public class MoviePlayer : MoviePlayerBase // TypeDefIndex: 12707
{
	// Fields
	private VideoPlayer m_VideoPlayer; // 0x80
	private bool m_IsSoundEventEnable; // 0x88
	private bool m_triggerStop; // 0x89

	// Methods

	// RVA: 0x227AE80 Offset: 0x227AF81 VA: 0x227AE80
	public void .ctor(string movieFileName, bool isMovieFileNameDirect) { }

	// RVA: 0x227AF10 Offset: 0x227B011 VA: 0x227AF10
	protected void ErrorCallback(VideoPlayer player, string mess) { }

	// RVA: 0x227AF40 Offset: 0x227B041 VA: 0x227AF40
	private void LoopPointReached(VideoPlayer player) { }

	// RVA: 0x227AF60 Offset: 0x227B061 VA: 0x227AF60
	private void FrameReady(VideoPlayer player, long frameIdx) { }

	// RVA: 0x227AF80 Offset: 0x227B081 VA: 0x227AF80 Slot: 4
	public override bool SetupAfterLoadScene() { }

	// RVA: 0x227B1A0 Offset: 0x227B2A1 VA: 0x227B1A0 Slot: 5
	public override bool SetupByMovieCanvasPrefab(GameObject canvasPrefab) { }

	// RVA: 0x227B2E0 Offset: 0x227B3E1 VA: 0x227B2E0 Slot: 6
	public override bool SetMovieFilePathToVideoPlayer() { }

	// RVA: 0x227B540 Offset: 0x227B641 VA: 0x227B540
	public void EnableSoundEvent() { }

	// RVA: 0x227B550 Offset: 0x227B651 VA: 0x227B550
	public void DisableSoundEvent() { }

	// RVA: 0x227B560 Offset: 0x227B661 VA: 0x227B560
	public bool IsTruePlayEnd() { }

	// RVA: 0x227B5A0 Offset: 0x227B6A1 VA: 0x227B5A0 Slot: 7
	public override string GetScreenObjectName() { }

	// RVA: 0x227B5F0 Offset: 0x227B6F1 VA: 0x227B5F0 Slot: 8
	public override bool IsPaused() { }

	// RVA: 0x227B690 Offset: 0x227B791 VA: 0x227B690 Slot: 9
	public override bool IsPlaying() { }

	// RVA: 0x227B730 Offset: 0x227B831 VA: 0x227B730 Slot: 10
	public override bool IsPlayEnd() { }

	// RVA: 0x227B790 Offset: 0x227B891 VA: 0x227B790 Slot: 12
	public override float GetMovieLength() { }

	// RVA: 0x227B850 Offset: 0x227B951 VA: 0x227B850 Slot: 13
	public override float GetPlayingPosition() { }

	// RVA: 0x227B910 Offset: 0x227BA11 VA: 0x227B910 Slot: 15
	public override void Tick() { }

	// RVA: 0x227BD00 Offset: 0x227BE01 VA: 0x227BD00 Slot: 16
	public override void Prepare() { }

	// RVA: 0x227BD20 Offset: 0x227BE21 VA: 0x227BD20 Slot: 17
	public override bool IsPrepared() { }

	// RVA: 0x227BDC0 Offset: 0x227BEC1 VA: 0x227BDC0 Slot: 18
	public override void Play() { }

	// RVA: 0x227BE10 Offset: 0x227BF11 VA: 0x227BE10 Slot: 19
	public override void Stop() { }

	// RVA: 0x227BF20 Offset: 0x227C021 VA: 0x227BF20 Slot: 20
	public override void SuspendOn() { }

	// RVA: 0x227BF30 Offset: 0x227C031 VA: 0x227BF30 Slot: 21
	public override void SuspendOff() { }
}

