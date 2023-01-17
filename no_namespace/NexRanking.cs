// Namespace: 
public struct NexRanking.Data // TypeDefIndex: 12742
{
	// Fields
	public int personIndex; // 0x0
	public int godIndex; // 0x4

	// Methods

	// RVA: 0x26F1410 Offset: 0x26F1511 VA: 0x26F1410
	public void Clear() { }
}

// Namespace: 
private class NexRanking.DownloadSequence : ProcInst // TypeDefIndex: 12744
{
	// Fields
	private const uint MaxBatch = 100;
	private NexRanking.Data[] m_Data; // 0x70
	private long[] m_RatingValues; // 0x78
	private int m_DataIndex; // 0x80
	private int m_ChapterIndex; // 0x84
	private ulong m_StartDataId; // 0x88
	private int m_StartSlot; // 0x90
	private ulong m_EndDataId; // 0x98
	private int m_EndSlot; // 0xA0
	private List<ulong> m_DataIds; // 0xA8

	// Methods

	// RVA: 0x26F1420 Offset: 0x26F1521 VA: 0x26F1420
	private void .ctor(string cid, NexRanking.Data[] data) { }

	// RVA: 0x26F15D0 Offset: 0x26F16D1 VA: 0x26F15D0
	private void Login() { }

	// RVA: 0x26F1640 Offset: 0x26F1741 VA: 0x26F1640
	private void Postlogin() { }

	// RVA: 0x26F17E0 Offset: 0x26F18E1 VA: 0x26F17E0
	private void GetRating() { }

	// RVA: 0x26F1A90 Offset: 0x26F1B91 VA: 0x26F1A90
	private void GetRatingResult(AsyncResult asyncResult, List<DataStoreMetaInfo> infos, List<DataStoreResult> results) { }

	// RVA: 0x26F1E20 Offset: 0x26F1F21 VA: 0x26F1E20
	private void Succeeded() { }

	// RVA: 0x26F1EA0 Offset: 0x26F1FA1 VA: 0x26F1EA0
	private void Error() { }

	// RVA: 0x26F1F10 Offset: 0x26F2011 VA: 0x26F1F10
	public static void CreateBind(ProcInst super, string cid, NexRanking.Data[] data) { }
}

// Namespace: 
private class NexRanking.UploadSequence : ProcInst // TypeDefIndex: 12746
{
	// Fields
	private const uint MaxBatch = 16;
	private const uint MaxRatingSlot = 16;
	private NexRanking.Data[] m_Pairs; // 0x70
	private int m_DataIndex; // 0x78
	private int m_ChapterIndex; // 0x7C

	// Methods

	// RVA: 0x26F2620 Offset: 0x26F2721 VA: 0x26F2620
	private void Login() { }

	// RVA: 0x26F2690 Offset: 0x26F2791 VA: 0x26F2690
	private void Postlogin() { }

	// RVA: 0x26F2830 Offset: 0x26F2931 VA: 0x26F2830
	private void .ctor(string cid, NexRanking.Data[] pairs) { }

	// RVA: 0x26F2910 Offset: 0x26F2A11 VA: 0x26F2910
	private void UploadRating() { }

	// RVA: 0x26F2F00 Offset: 0x26F3001 VA: 0x26F2F00
	private void UpdateRatingResult(AsyncResult asyncResult, List<DataStoreRatingInfo> info, List<DataStoreResult> resultList) { }

	// RVA: 0x26F3010 Offset: 0x26F3111 VA: 0x26F3010
	private void Succeeded() { }

	// RVA: 0x26F3090 Offset: 0x26F3191 VA: 0x26F3090
	private void Error() { }

	// RVA: 0x26F3100 Offset: 0x26F3201 VA: 0x26F3100
	public static void CreateBind(ProcInst super, string cid, NexRanking.Data[] pairs) { }
}

