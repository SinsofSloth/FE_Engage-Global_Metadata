// Namespace: 
[FlagsAttribute] // RVA: 0x271E50 Offset: 0x271F51 VA: 0x271E50
private enum AkTimelineEventPlayableBehavior.Actions // TypeDefIndex: 7976
{
	// Fields
	public int value__; // 0x0
	public const AkTimelineEventPlayableBehavior.Actions None = 0;
	public const AkTimelineEventPlayableBehavior.Actions Playback = 1;
	public const AkTimelineEventPlayableBehavior.Actions Retrigger = 2;
	public const AkTimelineEventPlayableBehavior.Actions DelayedStop = 4;
	public const AkTimelineEventPlayableBehavior.Actions Seek = 8;
	public const AkTimelineEventPlayableBehavior.Actions FadeIn = 16;
	public const AkTimelineEventPlayableBehavior.Actions FadeOut = 32;
}

// Namespace: 
public class AkTimelineEventPlayableBehavior : PlayableBehaviour // TypeDefIndex: 7977
{
	// Fields
	private float currentDuration; // 0x10
	private float currentDurationProportion; // 0x14
	private bool eventIsPlaying; // 0x18
	private bool fadeinTriggered; // 0x19
	private bool fadeoutTriggered; // 0x1A
	private float previousEventStartTime; // 0x1C
	private const uint CallbackFlags = 9;
	private AkTimelineEventPlayableBehavior.Actions requiredActions; // 0x20
	private const int scrubPlaybackLengthMs = 100;
	public Event akEvent; // 0x28
	public float eventDurationMax; // 0x30
	public float eventDurationMin; // 0x34
	public float blendInDuration; // 0x38
	public float blendOutDuration; // 0x3C
	public float easeInDuration; // 0x40
	public float easeOutDuration; // 0x44
	public AkCurveInterpolation blendInCurve; // 0x48
	public AkCurveInterpolation blendOutCurve; // 0x4C
	public GameObject eventObject; // 0x50
	public bool retriggerEvent; // 0x58
	private bool wasScrubbingAndRequiresRetrigger; // 0x59
	public bool StopEventAtClipEnd; // 0x5A
	public bool PrintDebugInformation; // 0x5B
	private const float alph = 0.05;

	// Methods

	// RVA: 0x20DAAA0 Offset: 0x20DABA1 VA: 0x20DAAA0
	private void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info) { }

	// RVA: 0x20DAB80 Offset: 0x20DAC81 VA: 0x20DAB80
	private bool IsScrubbing(Playable playable, FrameData info) { }

	// RVA: 0x20DACA0 Offset: 0x20DADA1 VA: 0x20DACA0
	private void PrintInfo(string FunctionName, Playable playable, FrameData info) { }

	// RVA: 0x20DB4E0 Offset: 0x20DB5E1 VA: 0x20DB4E0 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x20DB9E0 Offset: 0x20DBAE1 VA: 0x20DB9E0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x20DBC50 Offset: 0x20DBD51 VA: 0x20DBC50 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x20DBDE0 Offset: 0x20DBEE1 VA: 0x20DBDE0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x20DB700 Offset: 0x20DB801 VA: 0x20DB700
	private bool ShouldPlay(Playable playable) { }

	// RVA: 0x20DB820 Offset: 0x20DB921 VA: 0x20DB820
	private void CheckForFadeInFadeOut(Playable playable) { }

	// RVA: 0x20DB930 Offset: 0x20DBA31 VA: 0x20DB930
	private void CheckForFadeOut(Playable playable, double currentClipTime) { }

	// RVA: 0x20DC3D0 Offset: 0x20DC4D1 VA: 0x20DC3D0
	private void TriggerFadeIn(Playable playable) { }

	// RVA: 0x20DC4F0 Offset: 0x20DC5F1 VA: 0x20DC4F0
	private void TriggerFadeOut(Playable playable) { }

	// RVA: 0x20DBDB0 Offset: 0x20DBEB1 VA: 0x20DBDB0
	private void StopEvent(int transition = 0) { }

	// RVA: 0x20DC5E0 Offset: 0x20DC6E1 VA: 0x20DC5E0
	private bool PostEvent() { }

	// RVA: 0x20DC100 Offset: 0x20DC201 VA: 0x20DC100
	private void PlayEvent() { }

	// RVA: 0x20DC2A0 Offset: 0x20DC3A1 VA: 0x20DC2A0
	private void RetriggerEvent(Playable playable) { }

	// RVA: 0x20DBB60 Offset: 0x20DBC61 VA: 0x20DBB60
	private float GetProportionalTime(Playable playable) { }

	// RVA: 0x20DC1D0 Offset: 0x20DC2D1 VA: 0x20DC1D0
	private float SeekToTime(Playable playable) { }

	// RVA: 0x20DC6A0 Offset: 0x20DC7A1 VA: 0x20DC6A0
	public void .ctor() { }
}

