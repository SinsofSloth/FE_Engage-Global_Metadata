// Namespace: App
[DefaultMemberAttribute] // RVA: 0x279070 Offset: 0x279171 VA: 0x279070
public class ChapterRecord // TypeDefIndex: 13556
{
	// Fields
	private const int Version = 2;
	private List<ChapterRecord.Record> m_List; // 0x10
	private Dictionary<string, ChapterRecord.Record> m_Dictionary; // 0x18

	// Properties
	public int Count { get; }
	public ChapterRecord.Record Item { get; }

	// Methods

	// RVA: 0x2E17060 Offset: 0x2E17161 VA: 0x2E17060
	public void .ctor() { }

	// RVA: 0x2E17140 Offset: 0x2E17241 VA: 0x2E17140
	public int get_Count() { }

	// RVA: 0x2E17190 Offset: 0x2E17291 VA: 0x2E17190
	public ChapterRecord.Record get_Item(int index) { }

	// RVA: 0x2E17200 Offset: 0x2E17301 VA: 0x2E17200
	public ChapterRecord.Record Find(string cid) { }

	// RVA: 0x2E17280 Offset: 0x2E17381 VA: 0x2E17280
	public ChapterRecord.Record Find(ChapterData chapter) { }

	// RVA: 0x2E17310 Offset: 0x2E17411 VA: 0x2E17310
	public void Clear() { }

	// RVA: 0x2E17390 Offset: 0x2E17491 VA: 0x2E17390
	public ChapterRecord.Record TryAdd(ChapterRecord.Record record) { }

	// RVA: 0x2E17420 Offset: 0x2E17521 VA: 0x2E17420
	public ChapterRecord.Record TryAdd(string cid) { }

	// RVA: 0x2E17550 Offset: 0x2E17651 VA: 0x2E17550
	public ChapterRecord.Record TryAdd(ChapterData chapter) { }

	// RVA: 0x2E17570 Offset: 0x2E17671 VA: 0x2E17570
	public void Serialize(Stream stream) { }

	// RVA: 0x2E176A0 Offset: 0x2E177A1 VA: 0x2E176A0
	public void Deserialize(Stream stream) { }
}

