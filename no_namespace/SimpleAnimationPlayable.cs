// Namespace: 
private class SimpleAnimationPlayable.StateEnumerable.StateEnumerator : IEnumerator<SimpleAnimationPlayable.IState>, IEnumerator, IDisposable // TypeDefIndex: 6322
{
	// Fields
	private int m_Index; // 0x10
	private int m_Version; // 0x14
	private SimpleAnimationPlayable m_Owner; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	private SimpleAnimationPlayable.IState System.Collections.Generic.IEnumerator<SimpleAnimationPlayable.IState>.Current { get; }

	// Methods

	// RVA: 0x1C46240 Offset: 0x1C46341 VA: 0x1C46240
	public void .ctor(SimpleAnimationPlayable owner) { }

	// RVA: 0x1C48110 Offset: 0x1C48211 VA: 0x1C48110
	private bool IsValid() { }

	// RVA: 0x1C48140 Offset: 0x1C48241 VA: 0x1C48140
	private SimpleAnimationPlayable.IState GetCurrentHandle(int index) { }

	// RVA: 0x1C482D0 Offset: 0x1C483D1 VA: 0x1C482D0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1C482E0 Offset: 0x1C483E1 VA: 0x1C482E0 Slot: 4
	private SimpleAnimationPlayable.IState System.Collections.Generic.IEnumerator<SimpleAnimationPlayable.IState>.get_Current() { }

	// RVA: 0x1C482F0 Offset: 0x1C483F1 VA: 0x1C482F0 Slot: 5
	public void Dispose() { }

	// RVA: 0x1C48300 Offset: 0x1C48401 VA: 0x1C48300 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1C48090 Offset: 0x1C48191 VA: 0x1C48090 Slot: 8
	public void Reset() { }
}

// Namespace: 
private class SimpleAnimationPlayable.StateEnumerable : IEnumerable<SimpleAnimationPlayable.IState>, IEnumerable // TypeDefIndex: 6323
{
	// Fields
	private SimpleAnimationPlayable m_Owner; // 0x10

	// Methods

	// RVA: 0x1C42050 Offset: 0x1C42151 VA: 0x1C42050
	public void .ctor(SimpleAnimationPlayable owner) { }

	// RVA: 0x1C461D0 Offset: 0x1C462D1 VA: 0x1C461D0 Slot: 4
	public IEnumerator<SimpleAnimationPlayable.IState> GetEnumerator() { }

	// RVA: 0x1C46300 Offset: 0x1C46401 VA: 0x1C46300 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
public interface SimpleAnimationPlayable.IState // TypeDefIndex: 6324
{
	// Properties
	public abstract bool enabled { get; set; }
	public abstract float time { get; set; }
	public abstract float normalizedTime { get; set; }
	public abstract float speed { get; set; }
	public abstract string name { get; set; }
	public abstract float weight { get; set; }
	public abstract float length { get; }
	public abstract AnimationClip clip { get; }
	public abstract WrapMode wrapMode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsValid();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_enabled(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_time();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_time(float value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_normalizedTime();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_normalizedTime(float value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_speed();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_speed(float value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_name(string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_weight();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_weight(float value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_length();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract AnimationClip get_clip();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract WrapMode get_wrapMode();
}

// Namespace: 
public class SimpleAnimationPlayable.StateHandle : SimpleAnimationPlayable.IState // TypeDefIndex: 6325
{
	// Fields
	private SimpleAnimationPlayable m_Parent; // 0x10
	private int m_Index; // 0x18
	private Playable m_Target; // 0x20

	// Properties
	public bool enabled { get; set; }
	public float time { get; set; }
	public float normalizedTime { get; set; }
	public float speed { get; set; }
	public string name { get; set; }
	public float weight { get; set; }
	public float length { get; }
	public AnimationClip clip { get; }
	public WrapMode wrapMode { get; }
	public int index { get; }

	// Methods

	// RVA: 0x1C421E0 Offset: 0x1C422E1 VA: 0x1C421E0
	public void .ctor(SimpleAnimationPlayable s, int index, Playable target) { }

	// RVA: 0x1C46370 Offset: 0x1C46471 VA: 0x1C46370 Slot: 4
	public bool IsValid() { }

	// RVA: 0x1C46390 Offset: 0x1C46491 VA: 0x1C46390 Slot: 5
	public bool get_enabled() { }

	// RVA: 0x1C46470 Offset: 0x1C46571 VA: 0x1C46470 Slot: 6
	public void set_enabled(bool value) { }

	// RVA: 0x1C46660 Offset: 0x1C46761 VA: 0x1C46660 Slot: 7
	public float get_time() { }

	// RVA: 0x1C46790 Offset: 0x1C46891 VA: 0x1C46790 Slot: 8
	public void set_time(float value) { }

	// RVA: 0x1C46870 Offset: 0x1C46971 VA: 0x1C46870 Slot: 9
	public float get_normalizedTime() { }

	// RVA: 0x1C46A90 Offset: 0x1C46B91 VA: 0x1C46A90 Slot: 10
	public void set_normalizedTime(float value) { }

	// RVA: 0x1C46B90 Offset: 0x1C46C91 VA: 0x1C46B90 Slot: 11
	public float get_speed() { }

	// RVA: 0x1C46D50 Offset: 0x1C46E51 VA: 0x1C46D50 Slot: 12
	public void set_speed(float value) { }

	// RVA: 0x1C46F10 Offset: 0x1C47011 VA: 0x1C46F10 Slot: 13
	public string get_name() { }

	// RVA: 0x1C47060 Offset: 0x1C47161 VA: 0x1C47060 Slot: 14
	public void set_name(string value) { }

	// RVA: 0x1C47200 Offset: 0x1C47301 VA: 0x1C47200 Slot: 15
	public float get_weight() { }

	// RVA: 0x1C472E0 Offset: 0x1C473E1 VA: 0x1C472E0 Slot: 16
	public void set_weight(float value) { }

	// RVA: 0x1C474A0 Offset: 0x1C475A1 VA: 0x1C474A0 Slot: 17
	public float get_length() { }

	// RVA: 0x1C47680 Offset: 0x1C47781 VA: 0x1C47680 Slot: 18
	public AnimationClip get_clip() { }

	// RVA: 0x1C477D0 Offset: 0x1C478D1 VA: 0x1C477D0 Slot: 19
	public WrapMode get_wrapMode() { }

	// RVA: 0x1C47920 Offset: 0x1C47A21 VA: 0x1C47920
	public int get_index() { }
}

// Namespace: 
private class SimpleAnimationPlayable.StateInfo // TypeDefIndex: 6326
{
	// Fields
	private bool m_Enabled; // 0x10
	private int m_Index; // 0x14
	private string m_StateName; // 0x18
	private bool m_Fading; // 0x20
	private float m_Time; // 0x24
	private float m_TargetWeight; // 0x28
	private float m_Weight; // 0x2C
	private float m_FadeSpeed; // 0x30
	private AnimationClip m_Clip; // 0x38
	private Playable m_Playable; // 0x40
	private WrapMode m_WrapMode; // 0x50
	private bool m_IsClone; // 0x54
	private bool m_ReadyForCleanup; // 0x55
	public SimpleAnimationPlayable.StateHandle m_ParentState; // 0x58
	private bool m_WeightDirty; // 0x60
	private bool m_EnabledDirty; // 0x61
	private bool m_TimeIsUpToDate; // 0x62

	// Properties
	public bool enabled { get; }
	public int index { get; set; }
	public string stateName { get; set; }
	public bool fading { get; }
	public float targetWeight { get; }
	public float weight { get; }
	public float fadeSpeed { get; }
	public float speed { get; set; }
	public float playableDuration { get; }
	public AnimationClip clip { get; }
	public bool isDone { get; }
	public Playable playable { get; }
	public WrapMode wrapMode { get; }
	public bool isClone { get; }
	public bool isReadyForCleanup { get; }
	public SimpleAnimationPlayable.StateHandle parentState { get; }
	public bool enabledDirty { get; }
	public bool weightDirty { get; }

	// Methods

	// RVA: 0x1C42620 Offset: 0x1C42721 VA: 0x1C42620
	public void Initialize(string name, AnimationClip clip, WrapMode wrapMode) { }

	// RVA: 0x1C447B0 Offset: 0x1C448B1 VA: 0x1C447B0
	public float GetTime() { }

	// RVA: 0x1C47930 Offset: 0x1C47A31 VA: 0x1C47930
	public void SetTime(float newTime) { }

	// RVA: 0x1C42C90 Offset: 0x1C42D91 VA: 0x1C42C90
	public void Enable() { }

	// RVA: 0x1C44890 Offset: 0x1C44991 VA: 0x1C44890
	public void Disable() { }

	// RVA: 0x1C42670 Offset: 0x1C42771 VA: 0x1C42670
	public void Pause() { }

	// RVA: 0x1C44690 Offset: 0x1C44791 VA: 0x1C44690
	public void Play() { }

	// RVA: 0x1C445F0 Offset: 0x1C446F1 VA: 0x1C445F0
	public void Stop() { }

	// RVA: 0x1C42CB0 Offset: 0x1C42DB1 VA: 0x1C42CB0
	public void ForceWeight(float weight) { }

	// RVA: 0x1C445E0 Offset: 0x1C446E1 VA: 0x1C445E0
	public void SetWeight(float weight) { }

	// RVA: 0x1C435A0 Offset: 0x1C436A1 VA: 0x1C435A0
	public void FadeTo(float weight, float speed) { }

	// RVA: 0x1C47A40 Offset: 0x1C47B41 VA: 0x1C47A40
	public void DestroyPlayable() { }

	// RVA: 0x1C438C0 Offset: 0x1C439C1 VA: 0x1C438C0
	public void SetAsCloneOf(SimpleAnimationPlayable.StateHandle handle) { }

	// RVA: 0x1C47AF0 Offset: 0x1C47BF1 VA: 0x1C47AF0
	public bool get_enabled() { }

	// RVA: 0x1C47B00 Offset: 0x1C47C01 VA: 0x1C47B00
	public int get_index() { }

	// RVA: 0x1C47B10 Offset: 0x1C47C11 VA: 0x1C47B10
	public void set_index(int value) { }

	// RVA: 0x1C47B20 Offset: 0x1C47C21 VA: 0x1C47B20
	public string get_stateName() { }

	// RVA: 0x1C47B30 Offset: 0x1C47C31 VA: 0x1C47B30
	public void set_stateName(string value) { }

	// RVA: 0x1C47B40 Offset: 0x1C47C41 VA: 0x1C47B40
	public bool get_fading() { }

	// RVA: 0x1C47B50 Offset: 0x1C47C51 VA: 0x1C47B50
	public float get_targetWeight() { }

	// RVA: 0x1C47B60 Offset: 0x1C47C61 VA: 0x1C47B60
	public float get_weight() { }

	// RVA: 0x1C47B70 Offset: 0x1C47C71 VA: 0x1C47B70
	public float get_fadeSpeed() { }

	// RVA: 0x1C44750 Offset: 0x1C44851 VA: 0x1C44750
	public float get_speed() { }

	// RVA: 0x1C45240 Offset: 0x1C45341 VA: 0x1C45240
	public void set_speed(float value) { }

	// RVA: 0x1C44830 Offset: 0x1C44931 VA: 0x1C44830
	public float get_playableDuration() { }

	// RVA: 0x1C47B80 Offset: 0x1C47C81 VA: 0x1C47B80
	public AnimationClip get_clip() { }

	// RVA: 0x1C47B90 Offset: 0x1C47C91 VA: 0x1C47B90
	public void SetPlayable(Playable playable) { }

	// RVA: 0x1C446F0 Offset: 0x1C447F1 VA: 0x1C446F0
	public bool get_isDone() { }

	// RVA: 0x1C47BA0 Offset: 0x1C47CA1 VA: 0x1C47BA0
	public Playable get_playable() { }

	// RVA: 0x1C47BB0 Offset: 0x1C47CB1 VA: 0x1C47BB0
	public WrapMode get_wrapMode() { }

	// RVA: 0x1C47BC0 Offset: 0x1C47CC1 VA: 0x1C47BC0
	public bool get_isClone() { }

	// RVA: 0x1C47BD0 Offset: 0x1C47CD1 VA: 0x1C47BD0
	public bool get_isReadyForCleanup() { }

	// RVA: 0x1C47BE0 Offset: 0x1C47CE1 VA: 0x1C47BE0
	public SimpleAnimationPlayable.StateHandle get_parentState() { }

	// RVA: 0x1C47BF0 Offset: 0x1C47CF1 VA: 0x1C47BF0
	public bool get_enabledDirty() { }

	// RVA: 0x1C47C00 Offset: 0x1C47D01 VA: 0x1C47C00
	public bool get_weightDirty() { }

	// RVA: 0x1C448B0 Offset: 0x1C449B1 VA: 0x1C448B0
	public void ResetDirtyFlags() { }

	// RVA: 0x1C44F80 Offset: 0x1C45081 VA: 0x1C44F80
	public void InvalidateTime() { }

	// RVA: 0x1C47C10 Offset: 0x1C47D11 VA: 0x1C47C10
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x8D270 Offset: 0x8D371 VA: 0x8D270
[Serializable]
private sealed class SimpleAnimationPlayable.StateManagement.<>c // TypeDefIndex: 6327
{
	// Fields
	public static readonly SimpleAnimationPlayable.StateManagement.<>c <>9; // 0x0
	public static Predicate<SimpleAnimationPlayable.StateInfo> <>9__7_0; // 0x8
	public static Predicate<SimpleAnimationPlayable.StateInfo> <>9__8_0; // 0x10

	// Methods

	// RVA: 0x1C48460 Offset: 0x1C48561 VA: 0x1C48460
	private static void .cctor() { }

	// RVA: 0x1C484D0 Offset: 0x1C485D1 VA: 0x1C484D0
	public void .ctor() { }

	// RVA: 0x1C484E0 Offset: 0x1C485E1 VA: 0x1C484E0
	internal bool <InsertState>b__7_0(SimpleAnimationPlayable.StateInfo s) { }

	// RVA: 0x1C484F0 Offset: 0x1C485F1 VA: 0x1C484F0
	internal bool <AnyStatePlaying>b__8_0(SimpleAnimationPlayable.StateInfo s) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x8D280 Offset: 0x8D381 VA: 0x8D280
private sealed class SimpleAnimationPlayable.StateManagement.<>c__DisplayClass11_0 // TypeDefIndex: 6328
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x1C47C30 Offset: 0x1C47D31 VA: 0x1C47C30
	public void .ctor() { }

	// RVA: 0x1C48510 Offset: 0x1C48611 VA: 0x1C48510
	internal bool <FindState>b__0(SimpleAnimationPlayable.StateInfo s) { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x8D230 Offset: 0x8D331 VA: 0x8D230
private class SimpleAnimationPlayable.StateManagement // TypeDefIndex: 6329
{
	// Fields
	private List<SimpleAnimationPlayable.StateInfo> m_States; // 0x10
	private int m_Count; // 0x18

	// Properties
	public int Count { get; }
	public SimpleAnimationPlayable.StateInfo Item { get; }

	// Methods

	// RVA: 0x1C47C20 Offset: 0x1C47D21 VA: 0x1C47C20
	public int get_Count() { }

	// RVA: 0x1C419B0 Offset: 0x1C41AB1 VA: 0x1C419B0
	public SimpleAnimationPlayable.StateInfo get_Item(int i) { }

	// RVA: 0x1C41CD0 Offset: 0x1C41DD1 VA: 0x1C41CD0
	public void .ctor() { }

	// RVA: 0x1C42440 Offset: 0x1C42541 VA: 0x1C42440
	public SimpleAnimationPlayable.StateInfo InsertState() { }

	// RVA: 0x1C432C0 Offset: 0x1C433C1 VA: 0x1C432C0
	public bool AnyStatePlaying() { }

	// RVA: 0x1C42950 Offset: 0x1C42A51 VA: 0x1C42950
	public void RemoveState(int index) { }

	// RVA: 0x1C42A10 Offset: 0x1C42B11 VA: 0x1C42A10
	public bool RemoveClip(AnimationClip clip) { }

	// RVA: 0x1C42090 Offset: 0x1C42191 VA: 0x1C42090
	public SimpleAnimationPlayable.StateInfo FindState(string name) { }

	// RVA: 0x1C43830 Offset: 0x1C43931 VA: 0x1C43830
	public void EnableState(int index) { }

	// RVA: 0x1C465E0 Offset: 0x1C466E1 VA: 0x1C465E0
	public void DisableState(int index) { }

	// RVA: 0x1C47410 Offset: 0x1C47511 VA: 0x1C47410
	public void SetInputWeight(int index, float weight) { }

	// RVA: 0x1C43130 Offset: 0x1C43231 VA: 0x1C43130
	public void SetStateTime(int index, float time) { }

	// RVA: 0x1C44B40 Offset: 0x1C44C41 VA: 0x1C44B40
	public float GetStateTime(int index) { }

	// RVA: 0x1C47C40 Offset: 0x1C47D41 VA: 0x1C47C40
	public bool IsCloneOf(int potentialCloneIndex, int originalIndex) { }

	// RVA: 0x1C46CA0 Offset: 0x1C46DA1 VA: 0x1C46CA0
	public float GetStateSpeed(int index) { }

	// RVA: 0x1C46E60 Offset: 0x1C46F61 VA: 0x1C46E60
	public void SetStateSpeed(int index, float value) { }

	// RVA: 0x1C47CE0 Offset: 0x1C47DE1 VA: 0x1C47CE0
	public float GetInputWeight(int index) { }

	// RVA: 0x1C47530 Offset: 0x1C47631 VA: 0x1C47530
	public float GetStateLength(int index) { }

	// RVA: 0x1C469C0 Offset: 0x1C46AC1 VA: 0x1C469C0
	public float GetClipLength(int index) { }

	// RVA: 0x1C47D50 Offset: 0x1C47E51 VA: 0x1C47D50
	public float GetStatePlayableDuration(int index) { }

	// RVA: 0x1C47760 Offset: 0x1C47861 VA: 0x1C47760
	public AnimationClip GetStateClip(int index) { }

	// RVA: 0x1C478B0 Offset: 0x1C479B1 VA: 0x1C478B0
	public WrapMode GetStateWrapMode(int index) { }

	// RVA: 0x1C46FF0 Offset: 0x1C470F1 VA: 0x1C46FF0
	public string GetStateName(int index) { }

	// RVA: 0x1C47180 Offset: 0x1C47281 VA: 0x1C47180
	public void SetStateName(int index, string name) { }

	// RVA: 0x1C431B0 Offset: 0x1C432B1 VA: 0x1C431B0
	public void StopState(int index, bool cleanup) { }
}

// Namespace: 
private struct SimpleAnimationPlayable.QueuedState // TypeDefIndex: 6330
{
	// Fields
	public SimpleAnimationPlayable.StateHandle state; // 0x0
	public float fadeTime; // 0x8

	// Methods

	// RVA: 0x1C43080 Offset: 0x1C43181 VA: 0x1C43080
	public void .ctor(SimpleAnimationPlayable.StateHandle s, float t) { }
}

// Namespace: 
public class SimpleAnimationPlayable : PlayableBehaviour // TypeDefIndex: 6331
{
	// Fields
	private LinkedList<SimpleAnimationPlayable.QueuedState> m_StateQueue; // 0x10
	private SimpleAnimationPlayable.StateManagement m_States; // 0x18
	private bool m_Initialized; // 0x20
	private bool m_KeepStoppedPlayablesConnected; // 0x21
	protected Playable m_ActualPlayable; // 0x28
	private AnimationMixerPlayable m_Mixer; // 0x38
	public Action onDone; // 0x48
	private int m_StatesVersion; // 0x50

	// Properties
	public bool keepStoppedPlayablesConnected { get; set; }
	protected Playable self { get; }
	public Playable playable { get; }
	protected PlayableGraph graph { get; }

	// Methods

	// RVA: 0x1C41890 Offset: 0x1C41991 VA: 0x1C41890
	public bool get_keepStoppedPlayablesConnected() { }

	// RVA: 0x1C418A0 Offset: 0x1C419A1 VA: 0x1C418A0
	public void set_keepStoppedPlayablesConnected(bool value) { }

	// RVA: 0x1C418C0 Offset: 0x1C419C1 VA: 0x1C418C0
	private void UpdateStoppedPlayablesConnections() { }

	// RVA: 0x1C41C60 Offset: 0x1C41D61 VA: 0x1C41C60
	protected Playable get_self() { }

	// RVA: 0x1C40DD0 Offset: 0x1C40ED1 VA: 0x1C40DD0
	public Playable get_playable() { }

	// RVA: 0x1C41C70 Offset: 0x1C41D71 VA: 0x1C41C70
	protected PlayableGraph get_graph() { }

	// RVA: 0x1C40B30 Offset: 0x1C40C31 VA: 0x1C40B30
	public void .ctor() { }

	// RVA: 0x1C41D60 Offset: 0x1C41E61 VA: 0x1C41D60
	public Playable GetInput(int index) { }

	// RVA: 0x1C41E30 Offset: 0x1C41F31 VA: 0x1C41E30 Slot: 15
	public override void OnPlayableCreate(Playable playable) { }

	// RVA: 0x1C41FD0 Offset: 0x1C420D1 VA: 0x1C41FD0
	public IEnumerable<SimpleAnimationPlayable.IState> GetStates() { }

	// RVA: 0x1C400F0 Offset: 0x1C401F1 VA: 0x1C400F0
	public SimpleAnimationPlayable.IState GetState(string name) { }

	// RVA: 0x1C42240 Offset: 0x1C42341 VA: 0x1C42240
	private SimpleAnimationPlayable.StateInfo DoAddClip(string name, AnimationClip clip) { }

	// RVA: 0x1C3F350 Offset: 0x1C3F451 VA: 0x1C3F350
	public bool AddClip(AnimationClip clip, string name) { }

	// RVA: 0x1C3F920 Offset: 0x1C3FA21 VA: 0x1C3F920
	public bool RemoveClip(string name) { }

	// RVA: 0x1C3FCC0 Offset: 0x1C3FDC1 VA: 0x1C3FCC0
	public bool RemoveClip(AnimationClip clip) { }

	// RVA: 0x1C3F280 Offset: 0x1C3F381 VA: 0x1C3F280
	public bool Play(string name) { }

	// RVA: 0x1C42B20 Offset: 0x1C42C21 VA: 0x1C42B20
	private bool Play(int index) { }

	// RVA: 0x1C3FAE0 Offset: 0x1C3FBE1 VA: 0x1C3FAE0
	public bool PlayQueued(string name, QueueMode queueMode) { }

	// RVA: 0x1C42DA0 Offset: 0x1C42EA1 VA: 0x1C42DA0
	private bool PlayQueued(int index, QueueMode queueMode) { }

	// RVA: 0x1C3FEB0 Offset: 0x1C3FFB1 VA: 0x1C3FEB0
	public void Rewind(string name) { }

	// RVA: 0x1C430C0 Offset: 0x1C431C1 VA: 0x1C430C0
	private void Rewind(int index) { }

	// RVA: 0x1C3FD30 Offset: 0x1C3FE31 VA: 0x1C3FD30
	public void Rewind() { }

	// RVA: 0x1C42780 Offset: 0x1C42881 VA: 0x1C42780
	private void RemoveClones(SimpleAnimationPlayable.StateInfo state) { }

	// RVA: 0x1C3F010 Offset: 0x1C3F111 VA: 0x1C3F010
	public bool Stop(string name) { }

	// RVA: 0x1C42CD0 Offset: 0x1C42DD1 VA: 0x1C42CD0
	private void DoStop(int index) { }

	// RVA: 0x1C3EEC0 Offset: 0x1C3EFC1 VA: 0x1C3EEC0
	public bool StopAll() { }

	// RVA: 0x1C3E500 Offset: 0x1C3E601 VA: 0x1C3E500
	public bool IsPlaying() { }

	// RVA: 0x1C3ED90 Offset: 0x1C3EE91 VA: 0x1C3ED90
	public bool IsPlaying(string stateName) { }

	// RVA: 0x1C43400 Offset: 0x1C43501 VA: 0x1C43400
	private bool IsClonePlaying(SimpleAnimationPlayable.StateInfo state) { }

	// RVA: 0x1C3ECC0 Offset: 0x1C3EDC1 VA: 0x1C3ECC0
	public int GetClipCount() { }

	// RVA: 0x1C43510 Offset: 0x1C43611 VA: 0x1C43510
	private void SetupLerp(SimpleAnimationPlayable.StateInfo state, float targetWeight, float time) { }

	// RVA: 0x1C435C0 Offset: 0x1C436C1 VA: 0x1C435C0
	private bool Crossfade(int index, float time) { }

	// RVA: 0x1C42EC0 Offset: 0x1C42FC1 VA: 0x1C42EC0
	private SimpleAnimationPlayable.StateInfo CloneState(int index) { }

	// RVA: 0x1C3E9B0 Offset: 0x1C3EAB1 VA: 0x1C3E9B0
	public bool Crossfade(string name, float time) { }

	// RVA: 0x1C3EB20 Offset: 0x1C3EC21 VA: 0x1C3EB20
	public bool CrossfadeQueued(string name, float time, QueueMode queueMode) { }

	// RVA: 0x1C438F0 Offset: 0x1C439F1 VA: 0x1C438F0
	private bool CrossfadeQueued(int index, float time, QueueMode queueMode) { }

	// RVA: 0x1C43A20 Offset: 0x1C43B21 VA: 0x1C43A20
	private bool Blend(int index, float targetWeight, float time) { }

	// RVA: 0x1C3E860 Offset: 0x1C3E961 VA: 0x1C3E860
	public bool Blend(string name, float targetWeight, float time) { }

	// RVA: 0x1C43B80 Offset: 0x1C43C81 VA: 0x1C43B80 Slot: 14
	public override void OnGraphStop(Playable playable) { }

	// RVA: 0x1C426D0 Offset: 0x1C427D1 VA: 0x1C426D0
	private void UpdateDoneStatus() { }

	// RVA: 0x1C43D90 Offset: 0x1C43E91 VA: 0x1C43D90
	private void CleanClonedStates() { }

	// RVA: 0x1C41B20 Offset: 0x1C41C21 VA: 0x1C41B20
	private void DisconnectInput(int index) { }

	// RVA: 0x1C41A20 Offset: 0x1C41B21 VA: 0x1C41A20
	private void ConnectInput(int index) { }

	// RVA: 0x1C43F70 Offset: 0x1C44071 VA: 0x1C43F70
	private void UpdateStates(float deltaTime) { }

	// RVA: 0x1C448C0 Offset: 0x1C449C1 VA: 0x1C448C0
	private float CalculateQueueTimes() { }

	// RVA: 0x1C44C10 Offset: 0x1C44D11 VA: 0x1C44C10
	private void ClearQueuedStates() { }

	// RVA: 0x1C44DA0 Offset: 0x1C44EA1 VA: 0x1C44DA0
	private void UpdateQueuedStates() { }

	// RVA: 0x1C44EA0 Offset: 0x1C44FA1 VA: 0x1C44EA0
	private void InvalidateStateTimes() { }

	// RVA: 0x1C44F90 Offset: 0x1C45091 VA: 0x1C44F90 Slot: 19
	public override void PrepareFrame(Playable owner, FrameData data) { }

	// RVA: 0x1C450A0 Offset: 0x1C451A1 VA: 0x1C450A0
	public bool ValidateInput(int index, Playable input) { }

	// RVA: 0x1C45220 Offset: 0x1C45321 VA: 0x1C45220
	public bool ValidateIndex(int index) { }

	// RVA: 0x1C402D0 Offset: 0x1C403D1 VA: 0x1C402D0
	public bool IsFinished(float restTime = 0) { }

	// RVA: 0x1C40560 Offset: 0x1C40661 VA: 0x1C40560
	public void SetSpeed(float speed) { }

	// RVA: 0x1C42770 Offset: 0x1C42871 VA: 0x1C42770
	private void InvalidateStates() { }

	// RVA: 0x1C42FF0 Offset: 0x1C430F1 VA: 0x1C42FF0
	private SimpleAnimationPlayable.StateHandle StateInfoToHandle(SimpleAnimationPlayable.StateInfo info) { }
}

