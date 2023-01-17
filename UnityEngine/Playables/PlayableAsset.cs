// Namespace: UnityEngine.Playables
[AssetFileNameExtensionAttribute] // RVA: 0x441170 Offset: 0x441271 VA: 0x441170
[RequiredByNativeCodeAttribute] // RVA: 0x441170 Offset: 0x441271 VA: 0x441170
[Serializable]
public abstract class PlayableAsset : ScriptableObject, IPlayableAsset // TypeDefIndex: 3987
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x34900E0 Offset: 0x34901E1 VA: 0x34900E0 Slot: 7
	public virtual double get_duration() { }

	// RVA: 0x3490150 Offset: 0x3490251 VA: 0x3490150 Slot: 8
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4545C0 Offset: 0x4546C1 VA: 0x4545C0
	// RVA: 0x34901C0 Offset: 0x34902C1 VA: 0x34901C0
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4545D0 Offset: 0x4546D1 VA: 0x4545D0
	// RVA: 0x34903C0 Offset: 0x34904C1 VA: 0x34903C0
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x34903F0 Offset: 0x34904F1 VA: 0x34903F0
	protected void .ctor() { }
}

