// Namespace: 
public interface SimpleAnimation.State // TypeDefIndex: 6316
{
	// Properties
	public abstract bool enabled { get; set; }
	public abstract bool isValid { get; }
	public abstract float time { get; set; }
	public abstract float normalizedTime { get; set; }
	public abstract float speed { get; set; }
	public abstract string name { get; set; }
	public abstract float weight { get; set; }
	public abstract float length { get; }
	public abstract AnimationClip clip { get; }
	public abstract WrapMode wrapMode { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_enabled(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_isValid();

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

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_wrapMode(WrapMode value);
}

// Namespace: 
private class SimpleAnimation.StateEnumerable.StateEnumerator : IEnumerator<SimpleAnimation.State>, IEnumerator, IDisposable // TypeDefIndex: 6317
{
	// Fields
	private SimpleAnimation m_Owner; // 0x10
	private IEnumerator<SimpleAnimationPlayable.IState> m_Impl; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	private SimpleAnimation.State System.Collections.Generic.IEnumerator<SimpleAnimation.State>.Current { get; }

	// Methods

	// RVA: 0x1C45320 Offset: 0x1C45421 VA: 0x1C45320
	public void .ctor(SimpleAnimation owner) { }

	// RVA: 0x1C47EB0 Offset: 0x1C47FB1 VA: 0x1C47EB0
	private SimpleAnimation.State GetCurrent() { }

	// RVA: 0x1C47FB0 Offset: 0x1C480B1 VA: 0x1C47FB0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1C47FC0 Offset: 0x1C480C1 VA: 0x1C47FC0 Slot: 4
	private SimpleAnimation.State System.Collections.Generic.IEnumerator<SimpleAnimation.State>.get_Current() { }

	// RVA: 0x1C47FD0 Offset: 0x1C480D1 VA: 0x1C47FD0 Slot: 5
	public void Dispose() { }

	// RVA: 0x1C47FE0 Offset: 0x1C480E1 VA: 0x1C47FE0 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1C47E00 Offset: 0x1C47F01 VA: 0x1C47E00 Slot: 8
	public void Reset() { }
}

// Namespace: 
private class SimpleAnimation.StateEnumerable : IEnumerable<SimpleAnimation.State>, IEnumerable // TypeDefIndex: 6318
{
	// Fields
	private SimpleAnimation m_Owner; // 0x10

	// Methods

	// RVA: 0x1C40270 Offset: 0x1C40371 VA: 0x1C40270
	public void .ctor(SimpleAnimation owner) { }

	// RVA: 0x1C452B0 Offset: 0x1C453B1 VA: 0x1C452B0 Slot: 4
	public IEnumerator<SimpleAnimation.State> GetEnumerator() { }

	// RVA: 0x1C454E0 Offset: 0x1C455E1 VA: 0x1C454E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class SimpleAnimation.StateImpl : SimpleAnimation.State // TypeDefIndex: 6319
{
	// Fields
	private SimpleAnimationPlayable.IState m_StateHandle; // 0x10
	private SimpleAnimation m_Component; // 0x18

	// Properties
	private bool SimpleAnimation.State.enabled { get; set; }
	private bool SimpleAnimation.State.isValid { get; }
	private float SimpleAnimation.State.time { get; set; }
	private float SimpleAnimation.State.normalizedTime { get; set; }
	private float SimpleAnimation.State.speed { get; set; }
	private string SimpleAnimation.State.name { get; set; }
	private float SimpleAnimation.State.weight { get; set; }
	private float SimpleAnimation.State.length { get; }
	private AnimationClip SimpleAnimation.State.clip { get; }
	private WrapMode SimpleAnimation.State.wrapMode { get; set; }

	// Methods

	// RVA: 0x1C401A0 Offset: 0x1C402A1 VA: 0x1C401A0
	public void .ctor(SimpleAnimationPlayable.IState handle, SimpleAnimation component) { }

	// RVA: 0x1C45550 Offset: 0x1C45651 VA: 0x1C45550 Slot: 4
	private bool SimpleAnimation.State.get_enabled() { }

	// RVA: 0x1C45600 Offset: 0x1C45701 VA: 0x1C45600 Slot: 5
	private void SimpleAnimation.State.set_enabled(bool value) { }

	// RVA: 0x1C456F0 Offset: 0x1C457F1 VA: 0x1C456F0 Slot: 6
	private bool SimpleAnimation.State.get_isValid() { }

	// RVA: 0x1C457A0 Offset: 0x1C458A1 VA: 0x1C457A0 Slot: 7
	private float SimpleAnimation.State.get_time() { }

	// RVA: 0x1C45850 Offset: 0x1C45951 VA: 0x1C45850 Slot: 8
	private void SimpleAnimation.State.set_time(float value) { }

	// RVA: 0x1C45930 Offset: 0x1C45A31 VA: 0x1C45930 Slot: 9
	private float SimpleAnimation.State.get_normalizedTime() { }

	// RVA: 0x1C459E0 Offset: 0x1C45AE1 VA: 0x1C459E0 Slot: 10
	private void SimpleAnimation.State.set_normalizedTime(float value) { }

	// RVA: 0x1C45AC0 Offset: 0x1C45BC1 VA: 0x1C45AC0 Slot: 11
	private float SimpleAnimation.State.get_speed() { }

	// RVA: 0x1C45B70 Offset: 0x1C45C71 VA: 0x1C45B70 Slot: 12
	private void SimpleAnimation.State.set_speed(float value) { }

	// RVA: 0x1C45C50 Offset: 0x1C45D51 VA: 0x1C45C50 Slot: 13
	private string SimpleAnimation.State.get_name() { }

	// RVA: 0x1C45D00 Offset: 0x1C45E01 VA: 0x1C45D00 Slot: 14
	private void SimpleAnimation.State.set_name(string value) { }

	// RVA: 0x1C45DB0 Offset: 0x1C45EB1 VA: 0x1C45DB0 Slot: 15
	private float SimpleAnimation.State.get_weight() { }

	// RVA: 0x1C45E60 Offset: 0x1C45F61 VA: 0x1C45E60 Slot: 16
	private void SimpleAnimation.State.set_weight(float value) { }

	// RVA: 0x1C45F40 Offset: 0x1C46041 VA: 0x1C45F40 Slot: 17
	private float SimpleAnimation.State.get_length() { }

	// RVA: 0x1C45FF0 Offset: 0x1C460F1 VA: 0x1C45FF0 Slot: 18
	private AnimationClip SimpleAnimation.State.get_clip() { }

	// RVA: 0x1C460A0 Offset: 0x1C461A1 VA: 0x1C460A0 Slot: 19
	private WrapMode SimpleAnimation.State.get_wrapMode() { }

	// RVA: 0x1C46150 Offset: 0x1C46251 VA: 0x1C46150 Slot: 20
	private void SimpleAnimation.State.set_wrapMode(WrapMode value) { }
}

// Namespace: 
[Serializable]
public class SimpleAnimation.EditorState // TypeDefIndex: 6320
{
	// Fields
	public AnimationClip clip; // 0x10
	public string name; // 0x18
	public bool defaultState; // 0x20

	// Methods

	// RVA: 0x1C40C70 Offset: 0x1C40D71 VA: 0x1C40C70
	public void .ctor() { }
}

// Namespace: 
[RequireComponent] // RVA: 0x8D180 Offset: 0x8D281 VA: 0x8D180
[RequireComponent] // RVA: 0x8D180 Offset: 0x8D281 VA: 0x8D180
[DefaultMemberAttribute] // RVA: 0x8D180 Offset: 0x8D281 VA: 0x8D180
public abstract class SimpleAnimation : MonoBehaviour, IAnimationClipSource // TypeDefIndex: 6321
{
	// Fields
	private const string kDefaultStateName = "Default";
	protected PlayableGraph m_Graph; // 0x18
	protected PlayableHandle m_LayerMixer; // 0x28
	protected PlayableHandle m_TransitionMixer; // 0x38
	protected Animator m_Animator; // 0x48
	protected bool m_Initialized; // 0x50
	protected bool m_IsPlaying; // 0x51
	protected SimpleAnimationPlayable m_Playable; // 0x58
	[SerializeField] // RVA: 0x8D290 Offset: 0x8D391 VA: 0x8D290
	protected bool m_PlayAutomatically; // 0x60
	[SerializeField] // RVA: 0x8D2A0 Offset: 0x8D3A1 VA: 0x8D2A0
	protected bool m_AnimatePhysics; // 0x61
	[SerializeField] // RVA: 0x8D2B0 Offset: 0x8D3B1 VA: 0x8D2B0
	protected AnimatorCullingMode m_CullingMode; // 0x64
	[SerializeField] // RVA: 0x8D2C0 Offset: 0x8D3C1 VA: 0x8D2C0
	protected WrapMode m_WrapMode; // 0x68
	[SerializeField] // RVA: 0x8D2D0 Offset: 0x8D3D1 VA: 0x8D2D0
	protected AnimationClip m_Clip; // 0x70
	[SerializeField] // RVA: 0x8D2E0 Offset: 0x8D3E1 VA: 0x8D2E0
	private SimpleAnimation.EditorState[] m_States; // 0x78

	// Properties
	public Animator animator { get; }
	public bool animatePhysics { get; set; }
	public AnimatorCullingMode cullingMode { get; set; }
	public bool isPlaying { get; }
	public bool playAutomatically { get; set; }
	public AnimationClip clip { get; set; }
	public WrapMode wrapMode { get; set; }
	public SimpleAnimation.State Item { get; }

	// Methods

	// RVA: 0x1C3E3A0 Offset: 0x1C3E4A1 VA: 0x1C3E3A0
	public Animator get_animator() { }

	// RVA: 0x1C3E460 Offset: 0x1C3E561 VA: 0x1C3E460
	public bool get_animatePhysics() { }

	// RVA: 0x1C3E470 Offset: 0x1C3E571 VA: 0x1C3E470
	public void set_animatePhysics(bool value) { }

	// RVA: 0x1C3E4A0 Offset: 0x1C3E5A1 VA: 0x1C3E4A0
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x1C3E4C0 Offset: 0x1C3E5C1 VA: 0x1C3E4C0
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x1C3E4F0 Offset: 0x1C3E5F1 VA: 0x1C3E4F0
	public bool get_isPlaying() { }

	// RVA: 0x1C3E510 Offset: 0x1C3E611 VA: 0x1C3E510
	public bool get_playAutomatically() { }

	// RVA: 0x1C3E520 Offset: 0x1C3E621 VA: 0x1C3E520
	public void set_playAutomatically(bool value) { }

	// RVA: 0x1C3E530 Offset: 0x1C3E631 VA: 0x1C3E530
	public AnimationClip get_clip() { }

	// RVA: 0x1C3E540 Offset: 0x1C3E641 VA: 0x1C3E540
	public void set_clip(AnimationClip value) { }

	// RVA: 0x1C3E670 Offset: 0x1C3E771 VA: 0x1C3E670
	public WrapMode get_wrapMode() { }

	// RVA: 0x1C3E680 Offset: 0x1C3E781 VA: 0x1C3E680
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x1C3E690 Offset: 0x1C3E791 VA: 0x1C3E690
	public void AddClip(AnimationClip clip, string newName) { }

	// RVA: 0x1C3E790 Offset: 0x1C3E891 VA: 0x1C3E790
	public void Blend(string stateName, float targetWeight, float fadeLength) { }

	// RVA: 0x1C3E940 Offset: 0x1C3EA41 VA: 0x1C3E940
	public void CrossFade(string stateName, float fadeLength) { }

	// RVA: 0x1C3EAA0 Offset: 0x1C3EBA1 VA: 0x1C3EAA0
	public void CrossFadeQueued(string stateName, float fadeLength, QueueMode queueMode) { }

	// RVA: 0x1C3EC00 Offset: 0x1C3ED01 VA: 0x1C3EC00
	public int GetClipCount() { }

	// RVA: 0x1C3ED80 Offset: 0x1C3EE81 VA: 0x1C3ED80
	public bool IsPlaying(string stateName) { }

	// RVA: 0x1C3EEB0 Offset: 0x1C3EFB1 VA: 0x1C3EEB0
	public void Stop() { }

	// RVA: 0x1C3F000 Offset: 0x1C3F101 VA: 0x1C3F000
	public void Stop(string stateName) { }

	// RVA: 0x1C3F180 Offset: 0x1C3F281 VA: 0x1C3F180
	public void Sample() { }

	// RVA: 0x1C3F190 Offset: 0x1C3F291 VA: 0x1C3F190
	public bool Play() { }

	// RVA: 0x1C3E710 Offset: 0x1C3E811 VA: 0x1C3E710
	public void AddState(AnimationClip clip, string name) { }

	// RVA: 0x1C3F8E0 Offset: 0x1C3F9E1 VA: 0x1C3F8E0
	public void RemoveState(string name) { }

	// RVA: 0x1C3FA10 Offset: 0x1C3FB11 VA: 0x1C3FA10
	public bool Play(string stateName) { }

	// RVA: 0x1C3FA70 Offset: 0x1C3FB71 VA: 0x1C3FA70
	public void PlayQueued(string stateName, QueueMode queueMode) { }

	// RVA: 0x1C3FBC0 Offset: 0x1C3FCC1 VA: 0x1C3FBC0
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x1C3FCE0 Offset: 0x1C3FDE1 VA: 0x1C3FCE0
	public void Rewind() { }

	// RVA: 0x1C3FE60 Offset: 0x1C3FF61 VA: 0x1C3FE60
	public void Rewind(string stateName) { }

	// RVA: 0x1C3FFC0 Offset: 0x1C400C1 VA: 0x1C3FFC0
	public SimpleAnimation.State GetState(string stateName) { }

	// RVA: 0x1C401F0 Offset: 0x1C402F1 VA: 0x1C401F0
	public IEnumerable<SimpleAnimation.State> GetStates() { }

	// RVA: 0x1C402B0 Offset: 0x1C403B1 VA: 0x1C402B0
	public SimpleAnimation.State get_Item(string name) { }

	// RVA: 0x1C402C0 Offset: 0x1C403C1 VA: 0x1C402C0
	public bool IsFinished(float restTime = 0) { }

	// RVA: 0x1C40470 Offset: 0x1C40571 VA: 0x1C40470
	public void SetSpeed(float speed) { }

	// RVA: 0x1C3E810 Offset: 0x1C3E911 VA: 0x1C3E810
	protected void Kick() { }

	// RVA: 0x1C40650 Offset: 0x1C40751 VA: 0x1C40650 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x1C40AB0 Offset: 0x1C40BB1 VA: 0x1C40AB0 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x1C40AF0 Offset: 0x1C40BF1 VA: 0x1C40AF0
	private void Reset() { }

	// RVA: 0x1C406A0 Offset: 0x1C407A1 VA: 0x1C406A0
	private void Initialize() { }

	// RVA: 0x1C40C80 Offset: 0x1C40D81 VA: 0x1C40C80
	private void EnsureDefaultStateExists() { }

	// RVA: 0x1C40DE0 Offset: 0x1C40EE1 VA: 0x1C40DE0 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0x1C40DF0 Offset: 0x1C40EF1 VA: 0x1C40DF0
	protected void OnDestroy() { }

	// RVA: 0x1C40E30 Offset: 0x1C40F31 VA: 0x1C40E30
	private void OnPlayableDone() { }

	// RVA: 0x1C3F440 Offset: 0x1C3F541 VA: 0x1C3F440
	private void RebuildStates() { }

	// RVA: 0x1C40E60 Offset: 0x1C40F61 VA: 0x1C40E60
	private SimpleAnimation.EditorState CreateDefaultEditorState() { }

	// RVA: 0x1C3E580 Offset: 0x1C3E681 VA: 0x1C3E580
	private static void LegacyClipCheck(AnimationClip clip) { }

	// RVA: 0x1C40F00 Offset: 0x1C41001 VA: 0x1C40F00
	private void InvalidLegacyClipError(string clipName, string stateName) { }

	// RVA: 0x1C41050 Offset: 0x1C41151 VA: 0x1C41050
	private void OnValidate() { }

	// RVA: 0x1C41770 Offset: 0x1C41871 VA: 0x1C41770 Slot: 7
	public void GetAnimationClips(List<AnimationClip> results) { }

	// RVA: 0x1C41870 Offset: 0x1C41971 VA: 0x1C41870
	protected void .ctor() { }
}

