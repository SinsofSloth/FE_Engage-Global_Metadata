// Namespace: UnityEngine.Playables
[NativeHeaderAttribute] // RVA: 0x73160 Offset: 0x73261 VA: 0x73160
[NativeHeaderAttribute] // RVA: 0x73160 Offset: 0x73261 VA: 0x73160
[RequiredByNativeCodeAttribute] // RVA: 0x73160 Offset: 0x73261 VA: 0x73160
public class PlayableDirector : Behaviour, IExposedPropertyTable // TypeDefIndex: 4789
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x731D0 Offset: 0x732D1 VA: 0x731D0
	[DebuggerBrowsableAttribute] // RVA: 0x731D0 Offset: 0x732D1 VA: 0x731D0
	private Action<PlayableDirector> played; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x73210 Offset: 0x73311 VA: 0x73210
	[DebuggerBrowsableAttribute] // RVA: 0x73210 Offset: 0x73311 VA: 0x73210
	private Action<PlayableDirector> paused; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x73250 Offset: 0x73351 VA: 0x73250
	[DebuggerBrowsableAttribute] // RVA: 0x73250 Offset: 0x73351 VA: 0x73250
	private Action<PlayableDirector> stopped; // 0x28

	// Properties
	public PlayState state { get; }
	public DirectorWrapMode extrapolationMode { get; set; }
	public PlayableAsset playableAsset { get; set; }
	public PlayableGraph playableGraph { get; }
	public bool playOnAwake { get; set; }
	public DirectorUpdateMode timeUpdateMode { get; set; }
	public double time { get; set; }
	public double initialTime { get; set; }
	public double duration { get; }

	// Methods

	// RVA: 0x1C66400 Offset: 0x1C66501 VA: 0x1C66400
	public PlayState get_state() { }

	// RVA: 0x1C664A0 Offset: 0x1C665A1 VA: 0x1C664A0
	public void set_extrapolationMode(DirectorWrapMode value) { }

	// RVA: 0x1C66540 Offset: 0x1C66641 VA: 0x1C66540
	public DirectorWrapMode get_extrapolationMode() { }

	// RVA: 0x1C665E0 Offset: 0x1C666E1 VA: 0x1C665E0
	public PlayableAsset get_playableAsset() { }

	// RVA: 0x1C66700 Offset: 0x1C66801 VA: 0x1C66700
	public void set_playableAsset(PlayableAsset value) { }

	// RVA: 0x1C667A0 Offset: 0x1C668A1 VA: 0x1C667A0
	public PlayableGraph get_playableGraph() { }

	// RVA: 0x1C66860 Offset: 0x1C66961 VA: 0x1C66860
	public bool get_playOnAwake() { }

	// RVA: 0x1C66900 Offset: 0x1C66A01 VA: 0x1C66900
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1C669A0 Offset: 0x1C66AA1 VA: 0x1C669A0
	public void DeferredEvaluate() { }

	// RVA: 0x1C66A40 Offset: 0x1C66B41 VA: 0x1C66A40
	public void Play(PlayableAsset asset) { }

	// RVA: 0x1C66B40 Offset: 0x1C66C41 VA: 0x1C66B40
	public void Play(PlayableAsset asset, DirectorWrapMode mode) { }

	// RVA: 0x1C66CE0 Offset: 0x1C66DE1 VA: 0x1C66CE0
	public void SetGenericBinding(Object key, Object value) { }

	// RVA: 0x1C66DA0 Offset: 0x1C66EA1 VA: 0x1C66DA0
	public void set_timeUpdateMode(DirectorUpdateMode value) { }

	// RVA: 0x1C66DF0 Offset: 0x1C66EF1 VA: 0x1C66DF0
	public DirectorUpdateMode get_timeUpdateMode() { }

	// RVA: 0x1C66E40 Offset: 0x1C66F41 VA: 0x1C66E40
	public void set_time(double value) { }

	// RVA: 0x1C66E90 Offset: 0x1C66F91 VA: 0x1C66E90
	public double get_time() { }

	// RVA: 0x1C66EE0 Offset: 0x1C66FE1 VA: 0x1C66EE0
	public void set_initialTime(double value) { }

	// RVA: 0x1C66F30 Offset: 0x1C67031 VA: 0x1C66F30
	public double get_initialTime() { }

	// RVA: 0x1C66F80 Offset: 0x1C67081 VA: 0x1C66F80
	public double get_duration() { }

	[NativeThrowsAttribute] // RVA: 0x73290 Offset: 0x73391 VA: 0x73290
	// RVA: 0x1C66FD0 Offset: 0x1C670D1 VA: 0x1C66FD0
	public void Evaluate() { }

	[NativeThrowsAttribute] // RVA: 0x732A0 Offset: 0x733A1 VA: 0x732A0
	// RVA: 0x1C66C90 Offset: 0x1C66D91 VA: 0x1C66C90
	public void Play() { }

	// RVA: 0x1C67020 Offset: 0x1C67121 VA: 0x1C67020
	public void Stop() { }

	// RVA: 0x1C67070 Offset: 0x1C67171 VA: 0x1C67070
	public void Pause() { }

	// RVA: 0x1C670C0 Offset: 0x1C671C1 VA: 0x1C670C0
	public void Resume() { }

	[NativeThrowsAttribute] // RVA: 0x732B0 Offset: 0x733B1 VA: 0x732B0
	// RVA: 0x1C67110 Offset: 0x1C67211 VA: 0x1C67110
	public void RebuildGraph() { }

	// RVA: 0x1C67160 Offset: 0x1C67261 VA: 0x1C67160 Slot: 5
	public void ClearReferenceValue(PropertyName id) { }

	// RVA: 0x1C67210 Offset: 0x1C67311 VA: 0x1C67210 Slot: 6
	public void SetReferenceValue(PropertyName id, Object value) { }

	// RVA: 0x1C672D0 Offset: 0x1C673D1 VA: 0x1C672D0 Slot: 4
	public Object GetReferenceValue(PropertyName id, out bool idValid) { }

	[NativeMethodAttribute] // RVA: 0x732C0 Offset: 0x733C1 VA: 0x732C0
	// RVA: 0x1C67390 Offset: 0x1C67491 VA: 0x1C67390
	public Object GetGenericBinding(Object key) { }

	[NativeMethodAttribute] // RVA: 0x73300 Offset: 0x73401 VA: 0x73300
	// RVA: 0x1C673E0 Offset: 0x1C674E1 VA: 0x1C673E0
	public void ClearGenericBinding(Object key) { }

	[NativeThrowsAttribute] // RVA: 0x73340 Offset: 0x73441 VA: 0x73340
	// RVA: 0x1C67430 Offset: 0x1C67531 VA: 0x1C67430
	public void RebindPlayableGraphOutputs() { }

	// RVA: 0x1C67480 Offset: 0x1C67581 VA: 0x1C67480
	internal void ProcessPendingGraphChanges() { }

	[NativeMethodAttribute] // RVA: 0x73350 Offset: 0x73451 VA: 0x73350
	// RVA: 0x1C674D0 Offset: 0x1C675D1 VA: 0x1C674D0
	internal bool HasGenericBinding(Object key) { }

	// RVA: 0x1C66450 Offset: 0x1C66551 VA: 0x1C66450
	private PlayState GetPlayState() { }

	// RVA: 0x1C664F0 Offset: 0x1C665F1 VA: 0x1C664F0
	private void SetWrapMode(DirectorWrapMode mode) { }

	// RVA: 0x1C66590 Offset: 0x1C66691 VA: 0x1C66590
	private DirectorWrapMode GetWrapMode() { }

	[NativeThrowsAttribute] // RVA: 0x73390 Offset: 0x73491 VA: 0x73390
	// RVA: 0x1C669F0 Offset: 0x1C66AF1 VA: 0x1C669F0
	private void EvaluateNextFrame() { }

	// RVA: 0x1C66800 Offset: 0x1C66901 VA: 0x1C66800
	private PlayableGraph GetGraphHandle() { }

	// RVA: 0x1C66950 Offset: 0x1C66A51 VA: 0x1C66950
	private void SetPlayOnAwake(bool on) { }

	// RVA: 0x1C668B0 Offset: 0x1C669B1 VA: 0x1C668B0
	private bool GetPlayOnAwake() { }

	[NativeThrowsAttribute] // RVA: 0x733A0 Offset: 0x734A1 VA: 0x733A0
	// RVA: 0x1C66D40 Offset: 0x1C66E41 VA: 0x1C66D40
	private void Internal_SetGenericBinding(Object key, Object value) { }

	// RVA: 0x1C66750 Offset: 0x1C66851 VA: 0x1C66750
	private void SetPlayableAsset(ScriptableObject asset) { }

	// RVA: 0x1C666B0 Offset: 0x1C667B1 VA: 0x1C666B0
	private ScriptableObject Internal_GetPlayableAsset() { }

	[CompilerGeneratedAttribute] // RVA: 0x733B0 Offset: 0x734B1 VA: 0x733B0
	// RVA: 0x1C67570 Offset: 0x1C67671 VA: 0x1C67570
	public void add_played(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x733C0 Offset: 0x734C1 VA: 0x733C0
	// RVA: 0x1C67620 Offset: 0x1C67721 VA: 0x1C67620
	public void remove_played(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x733D0 Offset: 0x734D1 VA: 0x733D0
	// RVA: 0x1C676D0 Offset: 0x1C677D1 VA: 0x1C676D0
	public void add_paused(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x733E0 Offset: 0x734E1 VA: 0x733E0
	// RVA: 0x1C67780 Offset: 0x1C67881 VA: 0x1C67780
	public void remove_paused(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x733F0 Offset: 0x734F1 VA: 0x733F0
	// RVA: 0x1C67830 Offset: 0x1C67931 VA: 0x1C67830
	public void add_stopped(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x73400 Offset: 0x73501 VA: 0x73400
	// RVA: 0x1C678E0 Offset: 0x1C679E1 VA: 0x1C678E0
	public void remove_stopped(Action<PlayableDirector> value) { }

	[NativeHeaderAttribute] // RVA: 0x73410 Offset: 0x73511 VA: 0x73410
	[StaticAccessorAttribute] // RVA: 0x73410 Offset: 0x73511 VA: 0x73410
	// RVA: 0x1C67990 Offset: 0x1C67A91 VA: 0x1C67990
	internal static void ResetFrameTiming() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x73480 Offset: 0x73581 VA: 0x73480
	// RVA: 0x1C679D0 Offset: 0x1C67AD1 VA: 0x1C679D0
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x73490 Offset: 0x73591 VA: 0x73490
	// RVA: 0x1C67A30 Offset: 0x1C67B31 VA: 0x1C67A30
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x734A0 Offset: 0x735A1 VA: 0x734A0
	// RVA: 0x1C67A90 Offset: 0x1C67B91 VA: 0x1C67A90
	private void SendOnPlayableDirectorStop() { }

	// RVA: 0x1C67AF0 Offset: 0x1C67BF1 VA: 0x1C67AF0
	public void .ctor() { }

	// RVA: 0x1C671C0 Offset: 0x1C672C1 VA: 0x1C671C0 Slot: 7
	private void ClearReferenceValue_Injected(ref PropertyName id) { }

	// RVA: 0x1C67270 Offset: 0x1C67371 VA: 0x1C67270 Slot: 8
	private void SetReferenceValue_Injected(ref PropertyName id, Object value) { }

	// RVA: 0x1C67330 Offset: 0x1C67431 VA: 0x1C67330 Slot: 9
	private Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid) { }

	// RVA: 0x1C67520 Offset: 0x1C67621 VA: 0x1C67520
	private void GetGraphHandle_Injected(out PlayableGraph ret) { }
}

