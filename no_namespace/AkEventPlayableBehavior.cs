// Namespace: 
[FlagsAttribute] // RVA: 0x2724D0 Offset: 0x2725D1 VA: 0x2724D0
private enum AkEventPlayableBehavior.Actions // TypeDefIndex: 8020
{
	// Fields
	public int value__; // 0x0
	public const AkEventPlayableBehavior.Actions None = 0;
	public const AkEventPlayableBehavior.Actions Playback = 1;
	public const AkEventPlayableBehavior.Actions Retrigger = 2;
	public const AkEventPlayableBehavior.Actions DelayedStop = 4;
	public const AkEventPlayableBehavior.Actions Seek = 8;
	public const AkEventPlayableBehavior.Actions FadeIn = 16;
	public const AkEventPlayableBehavior.Actions FadeOut = 32;
}

// Namespace: 
[ObsoleteAttribute] // RVA: 0x272490 Offset: 0x272591 VA: 0x272490
public class AkEventPlayableBehavior : PlayableBehaviour // TypeDefIndex: 8021
{
	// Fields
	private float currentDuration; // 0x10
	private float currentDurationProportion; // 0x14
	private bool eventIsPlaying; // 0x18
	private bool fadeinTriggered; // 0x19
	private bool fadeoutTriggered; // 0x1A
	private float previousEventStartTime; // 0x1C
	private const uint CallbackFlags = 9;
	private AkEventPlayableBehavior.Actions requiredActions; // 0x20
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
	public bool overrideTrackEmitterObject; // 0x5B
	private const float alph = 0.05;

	// Methods

	// RVA: 0x3173220 Offset: 0x3173321 VA: 0x3173220
	private void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info) { }

	// RVA: 0x3173340 Offset: 0x3173441 VA: 0x3173340
	private bool IsScrubbing(FrameData info) { }

	// RVA: 0x3173370 Offset: 0x3173471 VA: 0x3173370 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x3173860 Offset: 0x3173961 VA: 0x3173860 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x3173A60 Offset: 0x3173B61 VA: 0x3173A60 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x3173B90 Offset: 0x3173C91 VA: 0x3173B90 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x3173530 Offset: 0x3173631 VA: 0x3173530
	private bool ShouldPlay(Playable playable) { }

	// RVA: 0x31736A0 Offset: 0x31737A1 VA: 0x31736A0
	private void CheckForFadeInFadeOut(Playable playable) { }

	// RVA: 0x31737B0 Offset: 0x31738B1 VA: 0x31737B0
	private void CheckForFadeOut(Playable playable, double currentClipTime) { }

	// RVA: 0x3174130 Offset: 0x3174231 VA: 0x3174130
	private void TriggerFadeIn(Playable playable) { }

	// RVA: 0x3174250 Offset: 0x3174351 VA: 0x3174250
	private void TriggerFadeOut(Playable playable) { }

	// RVA: 0x3173B60 Offset: 0x3173C61 VA: 0x3173B60
	private void StopEvent(int transition = 0) { }

	// RVA: 0x3174340 Offset: 0x3174441 VA: 0x3174340
	private bool PostEvent() { }

	// RVA: 0x3173E60 Offset: 0x3173F61 VA: 0x3173E60
	private void PlayEvent() { }

	// RVA: 0x3174000 Offset: 0x3174101 VA: 0x3174000
	private void RetriggerEvent(Playable playable) { }

	// RVA: 0x3173970 Offset: 0x3173A71 VA: 0x3173970
	private float GetProportionalTime(Playable playable) { }

	// RVA: 0x3173F30 Offset: 0x3174031 VA: 0x3173F30
	private float SeekToTime(Playable playable) { }

	// RVA: 0x3174400 Offset: 0x3174501 VA: 0x3174400
	public void .ctor() { }
}

