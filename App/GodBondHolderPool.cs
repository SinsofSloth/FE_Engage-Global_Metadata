// Namespace: App
public class GodBondHolderPool : SingletonPool<GodBondHolderPool, GodBondHolder> // TypeDefIndex: 13468
{
	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x2CFC9E0 Offset: 0x2CFCAE1 VA: 0x2CFC9E0
	public void .ctor() { }

	// RVA: 0x2CFCA40 Offset: 0x2CFCB41 VA: 0x2CFCA40 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2CFCA50 Offset: 0x2CFCB51 VA: 0x2CFCA50
	public GodBondHolder CreateOrGet(GodData data) { }

	// RVA: 0x2CFCBE0 Offset: 0x2CFCCE1 VA: 0x2CFCBE0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2CFCC40 Offset: 0x2CFCD41 VA: 0x2CFCC40 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2CFCCB0 Offset: 0x2CFCDB1 VA: 0x2CFCCB0
	public void SerializeForRewindLatest(Stream stream, HashSet<string> excludePids) { }

	// RVA: 0x2CFCDD0 Offset: 0x2CFCED1 VA: 0x2CFCDD0
	public void DeserializeForRewindLatest(Stream stream) { }
}

