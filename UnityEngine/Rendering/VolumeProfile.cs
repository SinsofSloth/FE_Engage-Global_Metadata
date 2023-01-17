// Namespace: UnityEngine.Rendering
[HelpURLAttribute] // RVA: 0x3C520 Offset: 0x3C621 VA: 0x3C520
public sealed class VolumeProfile : ScriptableObject // TypeDefIndex: 4689
{
	// Fields
	public List<VolumeComponent> components; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x354DE00 Offset: 0x354DF01 VA: 0x354DE00
	private void OnEnable() { }

	// RVA: 0x354DF30 Offset: 0x354E031 VA: 0x354DF30
	public void Reset() { }

	// RVA: -1 Offset: -1
	public T Add<T>(bool overrides = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386E460 Offset: 0x386E561 VA: 0x386E460
	|-VolumeProfile.Add<CustomRadialBlur>
	|-VolumeProfile.Add<object>
	*/

	// RVA: 0x354DF40 Offset: 0x354E041 VA: 0x354DF40
	public VolumeComponent Add(Type type, bool overrides = False) { }

	// RVA: -1 Offset: -1
	public void Remove<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386E5D0 Offset: 0x386E6D1 VA: 0x386E5D0
	|-VolumeProfile.Remove<object>
	*/

	// RVA: 0x354E230 Offset: 0x354E331 VA: 0x354E230
	public void Remove(Type type) { }

	// RVA: -1 Offset: -1
	public bool Has<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386E540 Offset: 0x386E641 VA: 0x386E540
	|-VolumeProfile.Has<CustomRadialBlur>
	|-VolumeProfile.Has<object>
	*/

	// RVA: 0x354E080 Offset: 0x354E181 VA: 0x354E080
	public bool Has(Type type) { }

	// RVA: 0x354E350 Offset: 0x354E451 VA: 0x354E350
	public bool HasSubclassOf(Type type) { }

	// RVA: -1 Offset: -1
	public bool TryGet<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386E660 Offset: 0x386E761 VA: 0x386E660
	|-VolumeProfile.TryGet<CustomRadialBlur>
	|-VolumeProfile.TryGet<DepthOfField>
	|-VolumeProfile.TryGet<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGet<T>(Type type, out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386E700 Offset: 0x386E801 VA: 0x386E700
	|-VolumeProfile.TryGet<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetSubclassOf<T>(Type type, out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386ECC0 Offset: 0x386EDC1 VA: 0x386ECC0
	|-VolumeProfile.TryGetSubclassOf<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetAllSubclassOf<T>(Type type, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386EA10 Offset: 0x386EB11 VA: 0x386EA10
	|-VolumeProfile.TryGetAllSubclassOf<object>
	*/

	// RVA: 0x354E4D0 Offset: 0x354E5D1 VA: 0x354E4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354E5A0 Offset: 0x354E6A1 VA: 0x354E5A0
	internal int GetComponentListHashCode() { }

	// RVA: 0x354E670 Offset: 0x354E771 VA: 0x354E670
	public void .ctor() { }
}

