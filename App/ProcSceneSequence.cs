// Namespace: App
public abstract class ProcSceneSequence<T> : SingletonProcInst<T> // TypeDefIndex: 14088
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29D920 Offset: 0x29DA21 VA: 0x29D920
	private string <SceneName>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x29D930 Offset: 0x29DA31 VA: 0x29D930
	private LoadSceneMode <SceneMode>k__BackingField; // 0x0

	// Properties
	public virtual string SceneName { get; set; }
	public virtual LoadSceneMode SceneMode { get; set; }
	protected virtual LoadingManager.Modes LoadingMode { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDCE0 Offset: 0x2CDDE1 VA: 0x2CDCE0
	// RVA: -1 Offset: -1 Slot: 22
	public virtual string get_SceneName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A855C0 Offset: 0x2A856C1 VA: 0x2A855C0
	|-ProcSceneSequence<EventDemoSequence>.get_SceneName
	|-ProcSceneSequence<GmapSequence>.get_SceneName
	|-ProcSceneSequence<HubSequence>.get_SceneName
	|-ProcSceneSequence<JobIntroSequence>.get_SceneName
	|-ProcSceneSequence<MainSequence>.get_SceneName
	|-ProcSceneSequence<MapSequence>.get_SceneName
	|-ProcSceneSequence<object>.get_SceneName
	|-ProcSceneSequence<TitleLoopSequence>.get_SceneName
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CDCF0 Offset: 0x2CDDF1 VA: 0x2CDCF0
	// RVA: -1 Offset: -1 Slot: 23
	public virtual void set_SceneName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A855D0 Offset: 0x2A856D1 VA: 0x2A855D0
	|-ProcSceneSequence<EventDemoSequence>.set_SceneName
	|-ProcSceneSequence<GmapSequence>.set_SceneName
	|-ProcSceneSequence<HubAccessoryRoom>.set_SceneName
	|-ProcSceneSequence<HubSequence>.set_SceneName
	|-ProcSceneSequence<JobIntroSequence>.set_SceneName
	|-ProcSceneSequence<MainSequence>.set_SceneName
	|-ProcSceneSequence<MapSequence>.set_SceneName
	|-ProcSceneSequence<object>.set_SceneName
	|-ProcSceneSequence<TitleLoopSequence>.set_SceneName
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CDD00 Offset: 0x2CDE01 VA: 0x2CDD00
	// RVA: -1 Offset: -1 Slot: 24
	public virtual LoadSceneMode get_SceneMode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A855E0 Offset: 0x2A856E1 VA: 0x2A855E0
	|-ProcSceneSequence<EventDemoSequence>.get_SceneMode
	|-ProcSceneSequence<GmapSequence>.get_SceneMode
	|-ProcSceneSequence<HubAccessoryRoom>.get_SceneMode
	|-ProcSceneSequence<HubSequence>.get_SceneMode
	|-ProcSceneSequence<JobIntroSequence>.get_SceneMode
	|-ProcSceneSequence<MainSequence>.get_SceneMode
	|-ProcSceneSequence<MapSequence>.get_SceneMode
	|-ProcSceneSequence<object>.get_SceneMode
	|-ProcSceneSequence<TitleLoopSequence>.get_SceneMode
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CDD10 Offset: 0x2CDE11 VA: 0x2CDD10
	// RVA: -1 Offset: -1 Slot: 25
	public virtual void set_SceneMode(LoadSceneMode value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A855F0 Offset: 0x2A856F1 VA: 0x2A855F0
	|-ProcSceneSequence<EventDemoSequence>.set_SceneMode
	|-ProcSceneSequence<GmapSequence>.set_SceneMode
	|-ProcSceneSequence<HubAccessoryRoom>.set_SceneMode
	|-ProcSceneSequence<HubSequence>.set_SceneMode
	|-ProcSceneSequence<JobIntroSequence>.set_SceneMode
	|-ProcSceneSequence<MainSequence>.set_SceneMode
	|-ProcSceneSequence<MapSequence>.set_SceneMode
	|-ProcSceneSequence<object>.set_SceneMode
	|-ProcSceneSequence<TitleLoopSequence>.set_SceneMode
	*/

	// RVA: -1 Offset: -1
	public void LoadScene() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85600 Offset: 0x2A85701 VA: 0x2A85600
	|-ProcSceneSequence<GmapSequence>.LoadScene
	|-ProcSceneSequence<JobIntroSequence>.LoadScene
	|-ProcSceneSequence<MapSequence>.LoadScene
	|-ProcSceneSequence<object>.LoadScene
	*/

	// RVA: -1 Offset: -1
	public void LoadScene(string name, LoadSceneMode mode = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85670 Offset: 0x2A85771 VA: 0x2A85670
	|-ProcSceneSequence<EventDemoSequence>.LoadScene
	|-ProcSceneSequence<HubAccessoryRoom>.LoadScene
	|-ProcSceneSequence<HubSequence>.LoadScene
	|-ProcSceneSequence<MainSequence>.LoadScene
	|-ProcSceneSequence<object>.LoadScene
	*/

	// RVA: -1 Offset: -1
	public void UnloadScene() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85700 Offset: 0x2A85801 VA: 0x2A85700
	|-ProcSceneSequence<GmapSequence>.UnloadScene
	|-ProcSceneSequence<HubSequence>.UnloadScene
	|-ProcSceneSequence<JobIntroSequence>.UnloadScene
	|-ProcSceneSequence<MainSequence>.UnloadScene
	|-ProcSceneSequence<MapSequence>.UnloadScene
	|-ProcSceneSequence<object>.UnloadScene
	*/

	// RVA: -1 Offset: -1
	public void UnloadScene(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A857D0 Offset: 0x2A858D1 VA: 0x2A857D0
	|-ProcSceneSequence<EventDemoSequence>.UnloadScene
	|-ProcSceneSequence<HubAccessoryRoom>.UnloadScene
	|-ProcSceneSequence<object>.UnloadScene
	*/

	// RVA: -1 Offset: -1
	public void BindLoading() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85850 Offset: 0x2A85951 VA: 0x2A85850
	|-ProcSceneSequence<GmapSequence>.BindLoading
	|-ProcSceneSequence<HubSequence>.BindLoading
	|-ProcSceneSequence<MapSequence>.BindLoading
	|-ProcSceneSequence<object>.BindLoading
	*/

	// RVA: -1 Offset: -1
	public void UnbindLoading() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A858E0 Offset: 0x2A859E1 VA: 0x2A858E0
	|-ProcSceneSequence<GmapSequence>.UnbindLoading
	|-ProcSceneSequence<HubSequence>.UnbindLoading
	|-ProcSceneSequence<MapSequence>.UnbindLoading
	|-ProcSceneSequence<object>.UnbindLoading
	*/

	// RVA: -1 Offset: -1 Slot: 26
	protected virtual LoadingManager.Modes get_LoadingMode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85950 Offset: 0x2A85A51 VA: 0x2A85950
	|-ProcSceneSequence<EventDemoSequence>.get_LoadingMode
	|-ProcSceneSequence<HubAccessoryRoom>.get_LoadingMode
	|-ProcSceneSequence<HubSequence>.get_LoadingMode
	|-ProcSceneSequence<JobIntroSequence>.get_LoadingMode
	|-ProcSceneSequence<MainSequence>.get_LoadingMode
	|-ProcSceneSequence<object>.get_LoadingMode
	|-ProcSceneSequence<TitleLoopSequence>.get_LoadingMode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85960 Offset: 0x2A85A61 VA: 0x2A85960
	|-ProcSceneSequence<EventDemoSequence>..ctor
	|-ProcSceneSequence<GmapSequence>..ctor
	|-ProcSceneSequence<HubAccessoryRoom>..ctor
	|-ProcSceneSequence<HubSequence>..ctor
	|-ProcSceneSequence<JobIntroSequence>..ctor
	|-ProcSceneSequence<MainSequence>..ctor
	|-ProcSceneSequence<MapSequence>..ctor
	|-ProcSceneSequence<object>..ctor
	|-ProcSceneSequence<TitleLoopSequence>..ctor
	*/
}

