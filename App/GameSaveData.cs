// Namespace: App
public class GameSaveData // TypeDefIndex: 13587
{
	// Fields
	public const int GlobalCount = 1;
	public const int AutoCount = 1;
	public const int ManualCount = 10;
	public const int DataSize = 3145728;
	private static readonly string NXRootPath; // 0x0
	private static GameSaveData s_ReadingTarget; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x29C630 Offset: 0x29C731 VA: 0x29C630
	private GameSaveData.Types <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29C640 Offset: 0x29C741 VA: 0x29C640
	private int <Index>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x29C650 Offset: 0x29C751 VA: 0x29C650
	private GameSaveData.Types <FromType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29C660 Offset: 0x29C761 VA: 0x29C660
	private int <FromIndex>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x29C670 Offset: 0x29C771 VA: 0x29C670
	private GameSaveDataHeader <Header>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29C680 Offset: 0x29C781 VA: 0x29C680
	private bool <IsSuccess>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29C690 Offset: 0x29C791 VA: 0x29C690
	private bool <IsExcludeHeaderAndTime>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x29C6A0 Offset: 0x29C7A1 VA: 0x29C6A0
	private static bool <IsNormalizeContentsOccurred>k__BackingField; // 0x10

	// Properties
	public GameSaveData.Types Type { get; set; }
	public int Index { get; set; }
	public GameSaveData.Types FromType { get; set; }
	public int FromIndex { get; set; }
	public GameSaveDataHeader Header { get; set; }
	public bool IsSuccess { get; set; }
	public bool IsExcludeHeaderAndTime { get; set; }
	public static GameSaveData ReadingTarget { get; set; }
	public static bool IsNormalizeContentsOccurred { get; set; }

	// Methods

	// RVA: 0x26AADA0 Offset: 0x26AAEA1 VA: 0x26AADA0
	public void .ctor() { }

	// RVA: 0x26AADB0 Offset: 0x26AAEB1 VA: 0x26AADB0
	public void .ctor(GameSaveData.Types type, int index) { }

	// RVA: 0x26AADF0 Offset: 0x26AAEF1 VA: 0x26AADF0
	public void Read(ProcInst super) { }

	// RVA: 0x26AAE10 Offset: 0x26AAF11 VA: 0x26AAE10
	public void Write(ProcInst super) { }

	// RVA: 0x26AAE30 Offset: 0x26AAF31 VA: 0x26AAE30
	public void Delete(ProcInst super) { }

	// RVA: 0x26AAE50 Offset: 0x26AAF51 VA: 0x26AAE50
	public void Copy(ProcInst super) { }

	// RVA: 0x26AAE70 Offset: 0x26AAF71 VA: 0x26AAE70
	public string GetFilePath() { }

	// RVA: 0x26AB0B0 Offset: 0x26AB1B1 VA: 0x26AB0B0
	public bool IsWriteWithGlobal() { }

	// RVA: 0x26AB150 Offset: 0x26AB251 VA: 0x26AB150
	public void Serialize(Stream stream) { }

	// RVA: 0x26AB4D0 Offset: 0x26AB5D1 VA: 0x26AB4D0
	public bool Deserialize(Stream stream) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC260 Offset: 0x2CC361 VA: 0x2CC260
	// RVA: 0x26AB890 Offset: 0x26AB991 VA: 0x26AB890
	public GameSaveData.Types get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC270 Offset: 0x2CC371 VA: 0x2CC270
	// RVA: 0x26AB8A0 Offset: 0x26AB9A1 VA: 0x26AB8A0
	public void set_Type(GameSaveData.Types value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC280 Offset: 0x2CC381 VA: 0x2CC280
	// RVA: 0x26AB8B0 Offset: 0x26AB9B1 VA: 0x26AB8B0
	public int get_Index() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC290 Offset: 0x2CC391 VA: 0x2CC290
	// RVA: 0x26AB8C0 Offset: 0x26AB9C1 VA: 0x26AB8C0
	public void set_Index(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC2A0 Offset: 0x2CC3A1 VA: 0x2CC2A0
	// RVA: 0x26AB8D0 Offset: 0x26AB9D1 VA: 0x26AB8D0
	public GameSaveData.Types get_FromType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC2B0 Offset: 0x2CC3B1 VA: 0x2CC2B0
	// RVA: 0x26AB8E0 Offset: 0x26AB9E1 VA: 0x26AB8E0
	public void set_FromType(GameSaveData.Types value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC2C0 Offset: 0x2CC3C1 VA: 0x2CC2C0
	// RVA: 0x26AB8F0 Offset: 0x26AB9F1 VA: 0x26AB8F0
	public int get_FromIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC2D0 Offset: 0x2CC3D1 VA: 0x2CC2D0
	// RVA: 0x26AB900 Offset: 0x26ABA01 VA: 0x26AB900
	public void set_FromIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC2E0 Offset: 0x2CC3E1 VA: 0x2CC2E0
	// RVA: 0x26AB910 Offset: 0x26ABA11 VA: 0x26AB910
	public GameSaveDataHeader get_Header() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC2F0 Offset: 0x2CC3F1 VA: 0x2CC2F0
	// RVA: 0x26AB920 Offset: 0x26ABA21 VA: 0x26AB920
	private void set_Header(GameSaveDataHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC300 Offset: 0x2CC401 VA: 0x2CC300
	// RVA: 0x26AB930 Offset: 0x26ABA31 VA: 0x26AB930
	public bool get_IsSuccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC310 Offset: 0x2CC411 VA: 0x2CC310
	// RVA: 0x26AB940 Offset: 0x26ABA41 VA: 0x26AB940
	public void set_IsSuccess(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC320 Offset: 0x2CC421 VA: 0x2CC320
	// RVA: 0x26AB950 Offset: 0x26ABA51 VA: 0x26AB950
	public bool get_IsExcludeHeaderAndTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC330 Offset: 0x2CC431 VA: 0x2CC330
	// RVA: 0x26AB960 Offset: 0x26ABA61 VA: 0x26AB960
	public void set_IsExcludeHeaderAndTime(bool value) { }

	// RVA: 0x26AB970 Offset: 0x26ABA71 VA: 0x26AB970
	public static bool IsValid() { }

	// RVA: 0x26AB980 Offset: 0x26ABA81 VA: 0x26AB980
	public static string GetRootPath() { }

	// RVA: 0x26AAEE0 Offset: 0x26AAFE1 VA: 0x26AAEE0
	public static string GetFilePath(GameSaveData.Types type, int index = 0) { }

	// RVA: 0x26AB9F0 Offset: 0x26ABAF1 VA: 0x26AB9F0
	public static int GetFileCount(GameSaveData.Types type) { }

	// RVA: 0x26AB130 Offset: 0x26AB231 VA: 0x26AB130
	public static bool IsWriteWithGlobal(GameSaveData.Types type) { }

	// RVA: 0x26ABA20 Offset: 0x26ABB21 VA: 0x26ABA20
	public static int GetHeaderSize(GameSaveData.Types type) { }

	// RVA: 0x26ABA50 Offset: 0x26ABB51 VA: 0x26ABA50
	public static GameSaveData get_ReadingTarget() { }

	// RVA: 0x26ABAC0 Offset: 0x26ABBC1 VA: 0x26ABAC0
	public static void set_ReadingTarget(GameSaveData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC340 Offset: 0x2CC441 VA: 0x2CC340
	// RVA: 0x26ABB40 Offset: 0x26ABC41 VA: 0x26ABB40
	public static bool get_IsNormalizeContentsOccurred() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC350 Offset: 0x2CC451 VA: 0x2CC350
	// RVA: 0x26ABBB0 Offset: 0x26ABCB1 VA: 0x26ABBB0
	public static void set_IsNormalizeContentsOccurred(bool value) { }

	// RVA: 0x26AB3A0 Offset: 0x26AB4A1 VA: 0x26AB3A0
	private void SerializeCommon(Stream stream) { }

	// RVA: 0x26AC1A0 Offset: 0x26AC2A1 VA: 0x26AC1A0
	public static void SerializeData(Stream stream, bool isExcludeTime, bool isExcludeRestart) { }

	// RVA: 0x26AB7C0 Offset: 0x26AB8C1 VA: 0x26AB7C0
	private bool DeserializeCommon(Stream stream) { }

	// RVA: 0x26ACC40 Offset: 0x26ACD41 VA: 0x26ACC40
	public static bool DeserializeData(Stream stream) { }

	// RVA: 0x26AB180 Offset: 0x26AB281 VA: 0x26AB180
	private void SerializeGlobal(Stream stream) { }

	// RVA: 0x26AB500 Offset: 0x26AB601 VA: 0x26AB500
	private bool DeserializeGlobal(Stream stream) { }

	// RVA: 0x26AD410 Offset: 0x26AD511 VA: 0x26AD410
	private static void ClearGlobal() { }

	// RVA: 0x26ACA00 Offset: 0x26ACB01 VA: 0x26ACA00
	private static bool IsSortieOrMapSequence() { }

	// RVA: 0x26AD620 Offset: 0x26AD721 VA: 0x26AD620
	private static bool IsSortieSequence() { }

	// RVA: 0x26AD550 Offset: 0x26AD651 VA: 0x26AD550
	private static bool IsMapSequence() { }

	// RVA: 0x26ACAA0 Offset: 0x26ACBA1 VA: 0x26ACAA0
	private static bool IsHubSequence() { }

	// RVA: 0x26ACB70 Offset: 0x26ACC71 VA: 0x26ACB70
	private static bool IsGmapSequence() { }

	// RVA: 0x26AD6F0 Offset: 0x26AD7F1 VA: 0x26AD6F0
	private static string NormalizePath(string path) { }

	// RVA: 0x26AD790 Offset: 0x26AD891 VA: 0x26AD790
	private static string JoinPath(string path1, string path2) { }

	// RVA: 0x26AD840 Offset: 0x26AD941 VA: 0x26AD840
	private static void .cctor() { }
}

