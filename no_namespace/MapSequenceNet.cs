// Namespace: 
private enum MapSequenceNet.ProcDownload.Label // TypeDefIndex: 12435
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceNet.ProcDownload.Label End = 0;
}

// Namespace: 
private class MapSequenceNet.ProcDownload : ProcInst // TypeDefIndex: 12436
{
	// Methods

	// RVA: 0x2138000 Offset: 0x2138101 VA: 0x2138000
	private void Download() { }

	// RVA: 0x21380D0 Offset: 0x21381D1 VA: 0x21380D0
	private void Postdownload() { }

	// RVA: 0x2138400 Offset: 0x2138501 VA: 0x2138400
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2138690 Offset: 0x2138791 VA: 0x2138690
	public void .ctor() { }
}

// Namespace: 
private enum MapSequenceNet.ProcUpload.Label // TypeDefIndex: 12437
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceNet.ProcUpload.Label Ranking = 0;
	public const MapSequenceNet.ProcUpload.Label End = 1;
}

// Namespace: 
private class MapSequenceNet.ProcUpload : ProcInst // TypeDefIndex: 12438
{
	// Methods

	// RVA: 0x21386C0 Offset: 0x21387C1 VA: 0x21386C0
	private void UploadKillBonus() { }

	// RVA: 0x2138790 Offset: 0x2138891 VA: 0x2138790
	private void PostuploadKillBonus() { }

	// RVA: 0x2138870 Offset: 0x2138971 VA: 0x2138870
	private void UploadRanking() { }

	// RVA: 0x2138940 Offset: 0x2138A41 VA: 0x2138940
	private void PostuploadRanking() { }

	// RVA: 0x2138A20 Offset: 0x2138B21 VA: 0x2138A20
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2138E70 Offset: 0x2138F71 VA: 0x2138E70
	public void .ctor() { }
}

// Namespace: 
private class MapSequenceNet.ProcShowError.ProcDelayedHideError : ProcInst // TypeDefIndex: 12439
{
	// Methods

	// RVA: 0x21E6DF0 Offset: 0x21E6EF1 VA: 0x21E6DF0
	private void Hide() { }

	// RVA: 0x21E6E00 Offset: 0x21E6F01 VA: 0x21E6E00
	public static void Create() { }

	// RVA: 0x21E7000 Offset: 0x21E7101 VA: 0x21E7000
	public void .ctor() { }
}

// Namespace: 
private class MapSequenceNet.ProcShowError : ProcInst // TypeDefIndex: 12440
{
	// Fields
	private const float WaitSec = 0.4;
	private const float WaitDelayedSec = 0.6;

	// Methods

	// RVA: 0x21386A0 Offset: 0x21387A1 VA: 0x21386A0
	private void Show() { }

	// RVA: 0x2138190 Offset: 0x2138291 VA: 0x2138190
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x21386B0 Offset: 0x21387B1 VA: 0x21386B0
	public void .ctor() { }
}

