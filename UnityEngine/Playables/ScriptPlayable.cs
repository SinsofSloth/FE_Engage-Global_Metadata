// Namespace: UnityEngine.Playables
public struct ScriptPlayable<T> : IPlayable, IEquatable<ScriptPlayable<T>> // TypeDefIndex: 4000
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly ScriptPlayable<T> m_NullPlayable; // 0x0

	// Properties
	public static ScriptPlayable<T> Null { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> get_Null() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3001170 Offset: 0x3001271 VA: 0x3001170
	|-ScriptPlayable<object>.get_Null
	|-ScriptPlayable<TimeNotificationBehaviour>.get_Null
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30012A0 Offset: 0x30013A1 VA: 0x30012A0
	|-ScriptPlayable<AkEventPlayableBehavior>.Create
	|-ScriptPlayable<AkRTPCPlayableBehaviour>.Create
	|-ScriptPlayable<AkTimelineEventPlayableBehavior>.Create
	|-ScriptPlayable<AkTimelineRtpcPlayableBehaviour>.Create
	|-ScriptPlayable<CinemachineMixer>.Create
	|-ScriptPlayable<CinemachineShotPlayable>.Create
	|-ScriptPlayable<MyRoomCaptionBehaviour>.Create
	|-ScriptPlayable<MyRoomEventBehaviour>.Create
	|-ScriptPlayable<MyRoomFadeBehaviour>.Create
	|-ScriptPlayable<MyRoomPhaseBehaviour>.Create
	|-ScriptPlayable<MyRoomVoiceBehaviour>.Create
	|-ScriptPlayable<object>.Create
	|-ScriptPlayable<PPRadialBlurPlayableBehaviour>.Create
	|-ScriptPlayable<TimeNotificationBehaviour>.Create
	|-ScriptPlayable<TimelinePlayable>.Create
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3001450 Offset: 0x3001551 VA: 0x3001450
	|-ScriptPlayable<AkRTPCPlayableBehaviour>.Create
	|-ScriptPlayable<AkTimelineRtpcPlayableBehaviour>.Create
	|-ScriptPlayable<MyRoomCaptionMID>.Create
	|-ScriptPlayable<MyRoomFadeColor>.Create
	|-ScriptPlayable<object>.Create
	|-ScriptPlayable<SimpleAnimationPlayable>.Create
	*/

	// RVA: -1 Offset: -1
	private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3001610 Offset: 0x3001711 VA: 0x3001610
	|-ScriptPlayable<object>.CreateHandle
	*/

	// RVA: -1 Offset: -1
	private static object CreateScriptInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30019E0 Offset: 0x3001AE1 VA: 0x30019E0
	|-ScriptPlayable<object>.CreateScriptInstance
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstance(IPlayableBehaviour source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3001BF0 Offset: 0x3001CF1 VA: 0x3001BF0
	|-ScriptPlayable<object>.CloneScriptInstance
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstanceFromEngineObject(Object source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3001F20 Offset: 0x3002021 VA: 0x3001F20
	|-ScriptPlayable<object>.CloneScriptInstanceFromEngineObject
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstanceFromIClonable(ICloneable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3001FD0 Offset: 0x30020D1 VA: 0x3001FD0
	|-ScriptPlayable<object>.CloneScriptInstanceFromIClonable
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(PlayableHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002070 Offset: 0x3002171 VA: 0x3002070
	|-ScriptPlayable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public PlayableHandle GetHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002220 Offset: 0x3002321 VA: 0x3002220
	|-ScriptPlayable<object>.GetHandle
	*/

	// RVA: -1 Offset: -1
	public T GetBehaviour() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002230 Offset: 0x3002331 VA: 0x3002230
	|-ScriptPlayable<AkEventPlayableBehavior>.GetBehaviour
	|-ScriptPlayable<AkRTPCPlayableBehaviour>.GetBehaviour
	|-ScriptPlayable<AkTimelineEventPlayableBehavior>.GetBehaviour
	|-ScriptPlayable<AkTimelineRtpcPlayableBehaviour>.GetBehaviour
	|-ScriptPlayable<CinemachineShotPlayable>.GetBehaviour
	|-ScriptPlayable<MyRoomCaptionMID>.GetBehaviour
	|-ScriptPlayable<MyRoomEventBehaviour>.GetBehaviour
	|-ScriptPlayable<MyRoomFadeColor>.GetBehaviour
	|-ScriptPlayable<MyRoomPhaseBehaviour>.GetBehaviour
	|-ScriptPlayable<MyRoomVoiceBehaviour>.GetBehaviour
	|-ScriptPlayable<object>.GetBehaviour
	|-ScriptPlayable<PPRadialBlurPlayableBehaviour>.GetBehaviour
	|-ScriptPlayable<SimpleAnimationPlayable>.GetBehaviour
	|-ScriptPlayable<TimeNotificationBehaviour>.GetBehaviour
	|-ScriptPlayable<TimelinePlayable>.GetBehaviour
	*/

	// RVA: -1 Offset: -1
	public static Playable op_Implicit(ScriptPlayable<T> playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002270 Offset: 0x3002371 VA: 0x3002270
	|-ScriptPlayable<AkEventPlayableBehavior>.op_Implicit
	|-ScriptPlayable<AkRTPCPlayableBehaviour>.op_Implicit
	|-ScriptPlayable<AkTimelineEventPlayableBehavior>.op_Implicit
	|-ScriptPlayable<AkTimelineRtpcPlayableBehaviour>.op_Implicit
	|-ScriptPlayable<CinemachineMixer>.op_Implicit
	|-ScriptPlayable<CinemachineShotPlayable>.op_Implicit
	|-ScriptPlayable<MyRoomCaptionBehaviour>.op_Implicit
	|-ScriptPlayable<MyRoomCaptionMID>.op_Implicit
	|-ScriptPlayable<MyRoomEventBehaviour>.op_Implicit
	|-ScriptPlayable<MyRoomFadeBehaviour>.op_Implicit
	|-ScriptPlayable<MyRoomFadeColor>.op_Implicit
	|-ScriptPlayable<MyRoomPhaseBehaviour>.op_Implicit
	|-ScriptPlayable<MyRoomVoiceBehaviour>.op_Implicit
	|-ScriptPlayable<object>.op_Implicit
	|-ScriptPlayable<PPRadialBlurPlayableBehaviour>.op_Implicit
	|-ScriptPlayable<TimeNotificationBehaviour>.op_Implicit
	|-ScriptPlayable<TimelinePlayable>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> op_Explicit(Playable playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30022D0 Offset: 0x30023D1 VA: 0x30022D0
	|-ScriptPlayable<CinemachineShotPlayable>.op_Explicit
	|-ScriptPlayable<MyRoomCaptionMID>.op_Explicit
	|-ScriptPlayable<MyRoomEventBehaviour>.op_Explicit
	|-ScriptPlayable<MyRoomFadeColor>.op_Explicit
	|-ScriptPlayable<object>.op_Explicit
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool Equals(ScriptPlayable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002350 Offset: 0x3002451 VA: 0x3002350
	|-ScriptPlayable<object>.Equals
	|-ScriptPlayable<TimeNotificationBehaviour>.Equals
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002430 Offset: 0x3002531 VA: 0x3002430
	|-ScriptPlayable<object>..cctor
	*/
}

