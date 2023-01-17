// Namespace: App
public class MapRanking : SingletonClass<MapRanking> // TypeDefIndex: 12206
{
	// Fields
	private List<NexRanking.Data> pairs; // 0x20

	// Properties
	protected override int Version { get; }
	public bool IsNetSucceeded { get; }

	// Methods

	// RVA: 0x278EA10 Offset: 0x278EB11 VA: 0x278EA10 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x278EAE0 Offset: 0x278EBE1 VA: 0x278EAE0 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x278EB60 Offset: 0x278EC61 VA: 0x278EB60
	public void RegisterUnit() { }

	// RVA: 0x278ED70 Offset: 0x278EE71 VA: 0x278ED70
	public bool Upload(ProcInst super) { }

	// RVA: 0x278EC50 Offset: 0x278ED51 VA: 0x278EC50
	private ChapterData GetChapter() { }

	// RVA: 0x278EF50 Offset: 0x278F051 VA: 0x278EF50 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x278EF60 Offset: 0x278F061 VA: 0x278EF60 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x278F060 Offset: 0x278F161 VA: 0x278F060 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	[ConditionalAttribute] // RVA: 0x2C8090 Offset: 0x2C8191 VA: 0x2C8090
	// RVA: 0x278F1B0 Offset: 0x278F2B1 VA: 0x278F1B0
	private void DbgDump() { }

	// RVA: 0x278EED0 Offset: 0x278EFD1 VA: 0x278EED0
	public void ClearNetSucceeded() { }

	// RVA: 0x278F3B0 Offset: 0x278F4B1 VA: 0x278F3B0
	public bool get_IsNetSucceeded() { }

	// RVA: 0x278F430 Offset: 0x278F531 VA: 0x278F430
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C80D0 Offset: 0x2C81D1 VA: 0x2C80D0
	// RVA: 0x278F4B0 Offset: 0x278F5B1 VA: 0x278F4B0
	private void <RegisterUnit>b__3_0(Unit unit) { }
}

