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

