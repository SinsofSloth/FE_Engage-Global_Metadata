// Namespace: UnityEngine.Playables
[ExtensionAttribute] // RVA: 0x441220 Offset: 0x441321 VA: 0x441220
public static class PlayableExtensions // TypeDefIndex: 3992
{
	// Methods

	[ExtensionAttribute] // RVA: 0x4545F0 Offset: 0x4546F1 VA: 0x4545F0
	// RVA: -1 Offset: -1
	public static bool IsValid<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981030 Offset: 0x2981131 VA: 0x2981030
	|-PlayableExtensions.IsValid<ScriptPlayable<object>>
	|-PlayableExtensions.IsValid<ScriptPlayable<TimeNotificationBehaviour>>
	|-PlayableExtensions.IsValid<ScriptPlayable<TimelinePlayable>>
	|
	|-RVA: 0x2981120 Offset: 0x2981221 VA: 0x2981120
	|-PlayableExtensions.IsValid<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454600 Offset: 0x454701 VA: 0x454600
	// RVA: -1 Offset: -1
	public static PlayableGraph GetGraph<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980C10 Offset: 0x2980D11 VA: 0x2980C10
	|-PlayableExtensions.GetGraph<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454610 Offset: 0x454711 VA: 0x454610
	// RVA: -1 Offset: -1
	public static PlayState GetPlayState<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980DC0 Offset: 0x2980EC1 VA: 0x2980DC0
	|-PlayableExtensions.GetPlayState<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454620 Offset: 0x454721 VA: 0x454620
	// RVA: -1 Offset: -1
	public static void Play<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29811A0 Offset: 0x29812A1 VA: 0x29811A0
	|-PlayableExtensions.Play<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454630 Offset: 0x454731 VA: 0x454630
	// RVA: -1 Offset: -1
	public static void Pause<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981160 Offset: 0x2981261 VA: 0x2981160
	|-PlayableExtensions.Pause<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454640 Offset: 0x454741 VA: 0x454640
	// RVA: -1 Offset: -1
	public static void SetSpeed<U>(U playable, double value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981A40 Offset: 0x2981B41 VA: 0x2981A40
	|-PlayableExtensions.SetSpeed<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454650 Offset: 0x454751 VA: 0x454650
	// RVA: -1 Offset: -1
	public static double GetSpeed<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980E40 Offset: 0x2980F41 VA: 0x2980E40
	|-PlayableExtensions.GetSpeed<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454660 Offset: 0x454761 VA: 0x454660
	// RVA: -1 Offset: -1
	public static void SetDuration<U>(U playable, double value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981230 Offset: 0x2981331 VA: 0x2981230
	|-PlayableExtensions.SetDuration<ScriptPlayable<object>>
	|-PlayableExtensions.SetDuration<ScriptPlayable<TimeNotificationBehaviour>>
	|
	|-RVA: 0x2981330 Offset: 0x2981431 VA: 0x2981330
	|-PlayableExtensions.SetDuration<AnimationClipPlayable>
	|
	|-RVA: 0x2981380 Offset: 0x2981481 VA: 0x2981380
	|-PlayableExtensions.SetDuration<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454670 Offset: 0x454771 VA: 0x454670
	// RVA: -1 Offset: -1
	public static double GetDuration<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980AE0 Offset: 0x2980BE1 VA: 0x2980AE0
	|-PlayableExtensions.GetDuration<ScriptPlayable<CinemachineShotPlayable>>
	|-PlayableExtensions.GetDuration<ScriptPlayable<object>>
	|
	|-RVA: 0x2980BD0 Offset: 0x2980CD1 VA: 0x2980BD0
	|-PlayableExtensions.GetDuration<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454680 Offset: 0x454781 VA: 0x454680
	// RVA: -1 Offset: -1
	public static void SetTime<U>(U playable, double value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981A90 Offset: 0x2981B91 VA: 0x2981A90
	|-PlayableExtensions.SetTime<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454690 Offset: 0x454791 VA: 0x454690
	// RVA: -1 Offset: -1
	public static double GetTime<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980E80 Offset: 0x2980F81 VA: 0x2980E80
	|-PlayableExtensions.GetTime<ScriptPlayable<CinemachineShotPlayable>>
	|-PlayableExtensions.GetTime<ScriptPlayable<object>>
	|
	|-RVA: 0x2980F70 Offset: 0x2981071 VA: 0x2980F70
	|-PlayableExtensions.GetTime<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x4546A0 Offset: 0x4547A1 VA: 0x4546A0
	// RVA: -1 Offset: -1
	public static double GetPreviousTime<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980E00 Offset: 0x2980F01 VA: 0x2980E00
	|-PlayableExtensions.GetPreviousTime<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x4546B0 Offset: 0x4547B1 VA: 0x4546B0
	// RVA: -1 Offset: -1
	public static void SetDone<U>(U playable, bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29811E0 Offset: 0x29812E1 VA: 0x29811E0
	|-PlayableExtensions.SetDone<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x4546C0 Offset: 0x4547C1 VA: 0x4546C0
	// RVA: -1 Offset: -1
	public static bool IsDone<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980FF0 Offset: 0x29810F1 VA: 0x2980FF0
	|-PlayableExtensions.IsDone<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x4546D0 Offset: 0x4547D1 VA: 0x4546D0
	// RVA: -1 Offset: -1
	public static void SetPropagateSetTime<U>(U playable, bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981940 Offset: 0x2981A41 VA: 0x2981940
	|-PlayableExtensions.SetPropagateSetTime<ScriptPlayable<object>>
	|-PlayableExtensions.SetPropagateSetTime<ScriptPlayable<TimeNotificationBehaviour>>
	|-PlayableExtensions.SetPropagateSetTime<ScriptPlayable<TimelinePlayable>>
	*/

	[ExtensionAttribute] // RVA: 0x4546E0 Offset: 0x4547E1 VA: 0x4546E0
	// RVA: -1 Offset: -1
	public static void SetInputCount<U>(U playable, int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29813D0 Offset: 0x29814D1 VA: 0x29813D0
	|-PlayableExtensions.SetInputCount<ScriptPlayable<AkEventPlayableBehavior>>
	|-PlayableExtensions.SetInputCount<ScriptPlayable<AkTimelineEventPlayableBehavior>>
	|-PlayableExtensions.SetInputCount<ScriptPlayable<CinemachineMixer>>
	|-PlayableExtensions.SetInputCount<ScriptPlayable<object>>
	|-PlayableExtensions.SetInputCount<ScriptPlayable<TimeNotificationBehaviour>>
	|
	|-RVA: 0x29814D0 Offset: 0x29815D1 VA: 0x29814D0
	|-PlayableExtensions.SetInputCount<AnimationMixerPlayable>
	|
	|-RVA: 0x2981520 Offset: 0x2981621 VA: 0x2981520
	|-PlayableExtensions.SetInputCount<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x4546F0 Offset: 0x4547F1 VA: 0x4546F0
	// RVA: -1 Offset: -1
	public static int GetInputCount<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980CF0 Offset: 0x2980DF1 VA: 0x2980CF0
	|-PlayableExtensions.GetInputCount<AnimationMixerPlayable>
	|
	|-RVA: 0x2980D30 Offset: 0x2980E31 VA: 0x2980D30
	|-PlayableExtensions.GetInputCount<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454700 Offset: 0x454801 VA: 0x454700
	// RVA: -1 Offset: -1
	public static Playable GetInput<U>(U playable, int inputPort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980C50 Offset: 0x2980D51 VA: 0x2980C50
	|-PlayableExtensions.GetInput<AnimationMixerPlayable>
	|
	|-RVA: 0x2980CA0 Offset: 0x2980DA1 VA: 0x2980CA0
	|-PlayableExtensions.GetInput<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454710 Offset: 0x454811 VA: 0x454710
	// RVA: -1 Offset: -1
	public static void SetInputWeight<U>(U playable, int inputIndex, float weight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981570 Offset: 0x2981671 VA: 0x2981570
	|-PlayableExtensions.SetInputWeight<AnimationLayerMixerPlayable>
	|
	|-RVA: 0x29815D0 Offset: 0x29816D1 VA: 0x29815D0
	|-PlayableExtensions.SetInputWeight<AnimationMixerPlayable>
	|
	|-RVA: 0x2981630 Offset: 0x2981731 VA: 0x2981630
	|-PlayableExtensions.SetInputWeight<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0x2981690 Offset: 0x2981791 VA: 0x2981690
	|-PlayableExtensions.SetInputWeight<AnimationOffsetPlayable>
	|
	|-RVA: 0x29816F0 Offset: 0x29817F1 VA: 0x29816F0
	|-PlayableExtensions.SetInputWeight<AnimationRemoveScalePlayable>
	|
	|-RVA: 0x2981750 Offset: 0x2981851 VA: 0x2981750
	|-PlayableExtensions.SetInputWeight<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454720 Offset: 0x454821 VA: 0x454720
	// RVA: -1 Offset: -1
	public static void SetInputWeight<U, V>(U playable, V input, float weight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29817B0 Offset: 0x29818B1 VA: 0x29817B0
	|-PlayableExtensions.SetInputWeight<ScriptPlayable<object>, Playable>
	|-PlayableExtensions.SetInputWeight<ScriptPlayable<TimeNotificationBehaviour>, Playable>
	|
	|-RVA: 0x29818D0 Offset: 0x29819D1 VA: 0x29818D0
	|-PlayableExtensions.SetInputWeight<Playable, Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454730 Offset: 0x454831 VA: 0x454730
	// RVA: -1 Offset: -1
	public static float GetInputWeight<U>(U playable, int inputIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980D70 Offset: 0x2980E71 VA: 0x2980D70
	|-PlayableExtensions.GetInputWeight<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454740 Offset: 0x454841 VA: 0x454740
	// RVA: -1 Offset: -1
	public static void SetTraversalMode<U>(U playable, PlayableTraversalMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981C30 Offset: 0x2981D31 VA: 0x2981C30
	|-PlayableExtensions.SetTraversalMode<ScriptPlayable<object>>
	|-PlayableExtensions.SetTraversalMode<ScriptPlayable<TimelinePlayable>>
	*/

	[ExtensionAttribute] // RVA: 0x454750 Offset: 0x454851 VA: 0x454750
	// RVA: -1 Offset: -1
	internal static DirectorWrapMode GetTimeWrapMode<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980FB0 Offset: 0x29810B1 VA: 0x2980FB0
	|-PlayableExtensions.GetTimeWrapMode<Playable>
	*/

	[ExtensionAttribute] // RVA: 0x454760 Offset: 0x454861 VA: 0x454760
	// RVA: -1 Offset: -1
	internal static void SetTimeWrapMode<U>(U playable, DirectorWrapMode value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981AE0 Offset: 0x2981BE1 VA: 0x2981AE0
	|-PlayableExtensions.SetTimeWrapMode<ScriptPlayable<object>>
	|-PlayableExtensions.SetTimeWrapMode<ScriptPlayable<TimeNotificationBehaviour>>
	|
	|-RVA: 0x2981BE0 Offset: 0x2981CE1 VA: 0x2981BE0
	|-PlayableExtensions.SetTimeWrapMode<Playable>
	*/
}

