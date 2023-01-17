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

