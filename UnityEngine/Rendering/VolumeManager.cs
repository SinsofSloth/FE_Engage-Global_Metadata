// Namespace: UnityEngine.Rendering
public sealed class VolumeManager // TypeDefIndex: 4647
{
	// Fields
	private static readonly Lazy<VolumeManager> s_Instance; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x3CF20 Offset: 0x3D021 VA: 0x3CF20
	private VolumeStack <stack>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x3CF30 Offset: 0x3D031 VA: 0x3CF30
	private IEnumerable<Type> <baseComponentTypes>k__BackingField; // 0x18
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<Volume>> m_SortedVolumes; // 0x20
	private readonly List<Volume> m_Volumes; // 0x28
	private readonly Dictionary<int, bool> m_SortNeeded; // 0x30
	private readonly List<VolumeComponent> m_ComponentsDefaultState; // 0x38
	private readonly List<Collider> m_TempColliders; // 0x40

	// Properties
	public static VolumeManager instance { get; }
	public VolumeStack stack { get; set; }
	public IEnumerable<Type> baseComponentTypes { get; set; }

	// Methods

	// RVA: 0x354A280 Offset: 0x354A381 VA: 0x354A280
	public static VolumeManager get_instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DC50 Offset: 0x3DD51 VA: 0x3DC50
	// RVA: 0x354BCB0 Offset: 0x354BDB1 VA: 0x354BCB0
	public VolumeStack get_stack() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DC60 Offset: 0x3DD61 VA: 0x3DC60
	// RVA: 0x354BCC0 Offset: 0x354BDC1 VA: 0x354BCC0
	private void set_stack(VolumeStack value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DC70 Offset: 0x3DD71 VA: 0x3DC70
	// RVA: 0x354BCD0 Offset: 0x354BDD1 VA: 0x354BCD0
	public IEnumerable<Type> get_baseComponentTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DC80 Offset: 0x3DD81 VA: 0x3DC80
	// RVA: 0x354BCE0 Offset: 0x354BDE1 VA: 0x354BCE0
	private void set_baseComponentTypes(IEnumerable<Type> value) { }

	// RVA: 0x354BCF0 Offset: 0x354BDF1 VA: 0x354BCF0
	private void .ctor() { }

	// RVA: 0x354C3A0 Offset: 0x354C4A1 VA: 0x354C3A0
	public VolumeStack CreateStack() { }

	// RVA: 0x354C7B0 Offset: 0x354C8B1 VA: 0x354C7B0
	public void DestroyStack(VolumeStack stack) { }

	// RVA: 0x354BF30 Offset: 0x354C031 VA: 0x354BF30
	private void ReloadBaseTypes() { }

	// RVA: 0x354A300 Offset: 0x354A401 VA: 0x354A300
	public void Register(Volume volume, int layer) { }

	// RVA: 0x354A5C0 Offset: 0x354A6C1 VA: 0x354A5C0
	public void Unregister(Volume volume, int layer) { }

	// RVA: -1 Offset: -1
	public bool IsComponentActiveInMask<T>(LayerMask layerMask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386DBA0 Offset: 0x386DCA1 VA: 0x386DBA0
	|-VolumeManager.IsComponentActiveInMask<object>
	*/

	// RVA: 0x354A980 Offset: 0x354AA81 VA: 0x354A980
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x354AAD0 Offset: 0x354ABD1 VA: 0x354AAD0
	internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer) { }

	// RVA: 0x354C930 Offset: 0x354CA31 VA: 0x354C930
	private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor) { }

	// RVA: 0x354CB40 Offset: 0x354CC41 VA: 0x354CB40
	private void ReplaceData(VolumeStack stack, List<VolumeComponent> components) { }

	[ConditionalAttribute] // RVA: 0x3DC90 Offset: 0x3DD91 VA: 0x3DC90
	// RVA: 0x354CDA0 Offset: 0x354CEA1 VA: 0x354CDA0
	public void CheckBaseTypes() { }

	[ConditionalAttribute] // RVA: 0x3DCD0 Offset: 0x3DDD1 VA: 0x3DCD0
	// RVA: 0x354CE60 Offset: 0x354CF61 VA: 0x354CE60
	public void CheckStack(VolumeStack stack) { }

	// RVA: 0x354D060 Offset: 0x354D161 VA: 0x354D060
	public void Update(Transform trigger, LayerMask layerMask) { }

	// RVA: 0x354D080 Offset: 0x354D181 VA: 0x354D080
	public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask) { }

	// RVA: 0x354D9E0 Offset: 0x354DAE1 VA: 0x354D9E0
	public void UpdateByVolumeProfile(VolumeProfile profile) { }

	// RVA: 0x354DA90 Offset: 0x354DB91 VA: 0x354DA90
	public Volume[] GetVolumes(LayerMask layerMask) { }

	// RVA: 0x354D6B0 Offset: 0x354D7B1 VA: 0x354D6B0
	private List<Volume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x354DAF0 Offset: 0x354DBF1 VA: 0x354DAF0
	private static void SortByPriority(List<Volume> volumes) { }

	// RVA: 0x354DC50 Offset: 0x354DD51 VA: 0x354DC50
	private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera) { }

	// RVA: 0x354DC60 Offset: 0x354DD61 VA: 0x354DC60
	private static void .cctor() { }
}

