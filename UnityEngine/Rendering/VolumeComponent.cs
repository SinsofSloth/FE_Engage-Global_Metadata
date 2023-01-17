// Namespace: UnityEngine.Rendering
[Serializable]
public class VolumeComponent : ScriptableObject // TypeDefIndex: 4645
{
	// Fields
	public bool active; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x3CEF0 Offset: 0x3CFF1 VA: 0x3CEF0
	private string <displayName>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x3CF00 Offset: 0x3D001 VA: 0x3CF00
	private ReadOnlyCollection<VolumeParameter> <parameters>k__BackingField; // 0x28
	[SerializeField] // RVA: 0x3CF10 Offset: 0x3D011 VA: 0x3CF10
	private bool m_AdvancedMode; // 0x30

	// Properties
	public string displayName { get; set; }
	public ReadOnlyCollection<VolumeParameter> parameters { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3DC00 Offset: 0x3DD01 VA: 0x3DC00
	// RVA: 0x354AB30 Offset: 0x354AC31 VA: 0x354AB30
	public string get_displayName() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DC10 Offset: 0x3DD11 VA: 0x3DC10
	// RVA: 0x354AB40 Offset: 0x354AC41 VA: 0x354AB40
	protected void set_displayName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DC20 Offset: 0x3DD21 VA: 0x3DC20
	// RVA: 0x354AB50 Offset: 0x354AC51 VA: 0x354AB50
	public ReadOnlyCollection<VolumeParameter> get_parameters() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DC30 Offset: 0x3DD31 VA: 0x3DC30
	// RVA: 0x354AB60 Offset: 0x354AC61 VA: 0x354AB60
	private void set_parameters(ReadOnlyCollection<VolumeParameter> value) { }

	// RVA: 0x354AB70 Offset: 0x354AC71 VA: 0x354AB70 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x354B140 Offset: 0x354B241 VA: 0x354B140 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x354B370 Offset: 0x354B471 VA: 0x354B370 Slot: 6
	public virtual void Override(VolumeComponent state, float interpFactor) { }

	// RVA: 0x354B4A0 Offset: 0x354B5A1 VA: 0x354B4A0
	public void SetAllOverridesTo(bool state) { }

	// RVA: 0x354B4B0 Offset: 0x354B5B1 VA: 0x354B4B0
	private void SetAllOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state) { }

	// RVA: 0x354B980 Offset: 0x354BA81 VA: 0x354B980 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354BA50 Offset: 0x354BB51 VA: 0x354BA50 Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x354BA60 Offset: 0x354BB61 VA: 0x354BA60
	public void Release() { }

	// RVA: 0x354BB30 Offset: 0x354BC31 VA: 0x354BB30
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DC40 Offset: 0x3DD41 VA: 0x3DC40
	// RVA: 0x354BBA0 Offset: 0x354BCA1 VA: 0x354BBA0
	private VolumeParameter <OnEnable>b__10_2(FieldInfo t) { }
}

