// Namespace: App
public class BattleRecordLineSetter : MonoBehaviour // TypeDefIndex: 12526
{
	// Fields
	[HeaderAttribute] // RVA: 0x29A840 Offset: 0x29A941 VA: 0x29A840
	public TextMeshProUGUI InfoTurnCount; // 0x18
	public TextMeshProUGUI InfoTime; // 0x20
	public TextMeshProUGUI InfoMVP; // 0x28
	[HeaderAttribute] // RVA: 0x29A880 Offset: 0x29A981 VA: 0x29A880
	public TextMeshProUGUI ChapterNumber; // 0x30
	public TextMeshProUGUI ChapterName; // 0x38
	public TextMeshProUGUI TurnCount; // 0x40
	public TextMeshProUGUI Time; // 0x48
	[HeaderAttribute] // RVA: 0x29A8C0 Offset: 0x29A9C1 VA: 0x29A8C0
	public GameObject MVPSolo; // 0x50
	public TextMeshProUGUI MVPSoloUnit; // 0x58
	public UnitIcon MVPSoloImg; // 0x60
	[HeaderAttribute] // RVA: 0x29A900 Offset: 0x29AA01 VA: 0x29A900
	public GameObject MVPDuet; // 0x68
	public TextMeshProUGUI MVPDuetUnit; // 0x70
	public TextMeshProUGUI MVPDuetEmblem; // 0x78
	public UnitIcon MVPDuetUnitImg; // 0x80
	public UnitIcon MVPDuetEmblemImg; // 0x88

	// Methods

	// RVA: 0x225BC70 Offset: 0x225BD71 VA: 0x225BC70
	internal void Set(ChapterRecord.Record rec) { }

	// RVA: 0x225BDD0 Offset: 0x225BED1 VA: 0x225BDD0
	private void SetData(string cid, int turn, float time, string pid, string jid, string gid) { }

	// RVA: 0x225C5C0 Offset: 0x225C6C1 VA: 0x225C5C0
	public void .ctor() { }
}

