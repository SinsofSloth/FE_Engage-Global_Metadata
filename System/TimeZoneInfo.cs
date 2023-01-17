// Namespace: System
[TypeForwardedFromAttribute] // RVA: 0x470BA0 Offset: 0x470CA1 VA: 0x470BA0
[Serializable]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 323
{
	// Fields
	private TimeSpan baseUtcOffset; // 0x10
	private string daylightDisplayName; // 0x18
	private string displayName; // 0x20
	private string id; // 0x28
	private static TimeZoneInfo local; // 0x0
	private List<KeyValuePair<DateTime, TimeType>> transitions; // 0x30
	private static bool readlinkNotFound; // 0x8
	private string standardDisplayName; // 0x38
	private bool supportsDaylightSavingTime; // 0x40
	private static TimeZoneInfo utc; // 0x10
	private static string timeZoneDirectory; // 0x18
	private TimeZoneInfo.AdjustmentRule[] adjustmentRules; // 0x48
	private static RegistryKey timeZoneKey; // 0x20
	private static RegistryKey localZoneKey; // 0x28
	private static ReadOnlyCollection<TimeZoneInfo> systemTimeZones; // 0x30

	// Properties
	public TimeSpan BaseUtcOffset { get; }
	public string DisplayName { get; }
	public string Id { get; }
	public static TimeZoneInfo Local { get; }
	public bool SupportsDaylightSavingTime { get; }
	public static TimeZoneInfo Utc { get; }
	private static string TimeZoneDirectory { get; }
	private static bool IsWindows { get; }
	private static RegistryKey TimeZoneKey { get; }
	private static RegistryKey LocalZoneKey { get; }

	// Methods

	// RVA: 0x1B198E0 Offset: 0x1B199E1 VA: 0x1B198E0
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x1B19920 Offset: 0x1B19A21 VA: 0x1B19920
	private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) { }

	// RVA: 0x1B1A020 Offset: 0x1B1A121 VA: 0x1B1A020
	private static TimeZoneInfo CreateLocalUnity() { }

	// RVA: 0x1B1A600 Offset: 0x1B1A701 VA: 0x1B1A600
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x1B1A720 Offset: 0x1B1A821 VA: 0x1B1A720
	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1B1A830 Offset: 0x1B1A931 VA: 0x1B1A830
	internal static extern uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1B1A940 Offset: 0x1B1AA41 VA: 0x1B1A940
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	// RVA: 0x1B1AA70 Offset: 0x1B1AB71 VA: 0x1B1AA70
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi) { }

	// RVA: 0x1B1AC30 Offset: 0x1B1AD31 VA: 0x1B1AC30
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x1B1AFE0 Offset: 0x1B1B0E1 VA: 0x1B1AFE0
	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x1B1B180 Offset: 0x1B1B281 VA: 0x1B1B180
	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	// RVA: 0x1B1BCA0 Offset: 0x1B1BDA1 VA: 0x1B1BCA0
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	// RVA: 0x1B1BF80 Offset: 0x1B1C081 VA: 0x1B1BF80
	internal static string GetLocalTimeZoneKeyNameWin32Fallback() { }

	// RVA: 0x1B1C160 Offset: 0x1B1C261 VA: 0x1B1C160
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	// RVA: 0x1B1C5A0 Offset: 0x1B1C6A1 VA: 0x1B1C5A0
	internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() { }

	// RVA: 0x1B1C880 Offset: 0x1B1C981 VA: 0x1B1C880
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x1B1C890 Offset: 0x1B1C991 VA: 0x1B1C890
	public string get_DisplayName() { }

	// RVA: 0x1B1C8A0 Offset: 0x1B1C9A1 VA: 0x1B1C8A0
	public string get_Id() { }

	// RVA: 0x1B1C8B0 Offset: 0x1B1C9B1 VA: 0x1B1C8B0
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x1B1D000 Offset: 0x1B1D101 VA: 0x1B1D000
	private static extern int readlink(string path, byte[] buffer, int buflen) { }

	// RVA: 0x1B1D0C0 Offset: 0x1B1D1C1 VA: 0x1B1D0C0
	private static string readlink(string path) { }

	// RVA: 0x1B1D300 Offset: 0x1B1D401 VA: 0x1B1D300
	private static bool TryGetNameFromPath(string path, out string name) { }

	// RVA: 0x1B1C980 Offset: 0x1B1CA81 VA: 0x1B1C980
	private static TimeZoneInfo CreateLocal() { }

	// RVA: 0x1B1DD40 Offset: 0x1B1DE41 VA: 0x1B1DD40
	private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) { }

	// RVA: 0x1B1DE30 Offset: 0x1B1DF31 VA: 0x1B1DE30
	private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) { }

	// RVA: 0x1B1EC50 Offset: 0x1B1ED51 VA: 0x1B1EC50
	public bool get_SupportsDaylightSavingTime() { }

	// RVA: 0x1B1BE90 Offset: 0x1B1BF91 VA: 0x1B1BE90
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x1B1D650 Offset: 0x1B1D751 VA: 0x1B1D650
	private static string get_TimeZoneDirectory() { }

	// RVA: 0x1B1D6F0 Offset: 0x1B1D7F1 VA: 0x1B1D6F0
	private static bool get_IsWindows() { }

	// RVA: 0x1B1D8C0 Offset: 0x1B1D9C1 VA: 0x1B1D8C0
	private static string TrimSpecial(string str) { }

	// RVA: 0x1B1EAD0 Offset: 0x1B1EBD1 VA: 0x1B1EAD0
	private static RegistryKey get_TimeZoneKey() { }

	// RVA: 0x1B1D740 Offset: 0x1B1D841 VA: 0x1B1D740
	private static RegistryKey get_LocalZoneKey() { }

	// RVA: 0x1B1ED00 Offset: 0x1B1EE01 VA: 0x1B1ED00
	private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = 0) { }

	// RVA: 0x1B1EE80 Offset: 0x1B1EF81 VA: 0x1B1EE80
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x1B1F280 Offset: 0x1B1F381 VA: 0x1B1F280
	private DateTime ConvertTimeFromUtc(DateTime dateTime) { }

	// RVA: 0x1B1F210 Offset: 0x1B1F311 VA: 0x1B1F210
	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x1B1F430 Offset: 0x1B1F531 VA: 0x1B1F430
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1B1F200 Offset: 0x1B1F301 VA: 0x1B1F200
	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	// RVA: 0x1B1F460 Offset: 0x1B1F561 VA: 0x1B1F460
	private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x1B1F6D0 Offset: 0x1B1F7D1 VA: 0x1B1F6D0
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1B1EC60 Offset: 0x1B1ED61 VA: 0x1B1EC60
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x1B1F790 Offset: 0x1B1F891 VA: 0x1B1F790
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x1B1A540 Offset: 0x1B1A641 VA: 0x1B1A540
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1B1F840 Offset: 0x1B1F941 VA: 0x1B1F840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B1F8E0 Offset: 0x1B1F9E1 VA: 0x1B1F8E0 Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x1B1DA20 Offset: 0x1B1DB21 VA: 0x1B1DA20
	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	// RVA: 0x1B1DBA0 Offset: 0x1B1DCA1 VA: 0x1B1DBA0
	private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) { }

	// RVA: 0x1B1FAD0 Offset: 0x1B1FBD1 VA: 0x1B1FAD0
	private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) { }

	// RVA: 0x1B201C0 Offset: 0x1B202C1 VA: 0x1B201C0
	private static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) { }

	// RVA: 0x1B20760 Offset: 0x1B20861 VA: 0x1B20760
	public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { }

	// RVA: 0x1B20800 Offset: 0x1B20901 VA: 0x1B20800 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B20920 Offset: 0x1B20A21 VA: 0x1B20920 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B1C410 Offset: 0x1B1C511 VA: 0x1B1C410
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	// RVA: 0x1B1F400 Offset: 0x1B1F501 VA: 0x1B1F400
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1B1F5F0 Offset: 0x1B1F6F1 VA: 0x1B1F5F0
	private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST, bool forOffset = False) { }

	// RVA: 0x1B20B00 Offset: 0x1B20C01 VA: 0x1B20B00
	private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST, bool forOffset = False) { }

	// RVA: 0x1B1F930 Offset: 0x1B1FA31 VA: 0x1B1F930
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x1B21420 Offset: 0x1B21521 VA: 0x1B21420
	public bool IsAmbiguousTime(DateTime dateTime) { }

	// RVA: 0x1B217D0 Offset: 0x1B218D1 VA: 0x1B217D0
	private bool IsAmbiguousLocalDstFromUtc(DateTime dateTime) { }

	// RVA: 0x1B21340 Offset: 0x1B21441 VA: 0x1B21340
	private bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime) { }

	// RVA: 0x1B21930 Offset: 0x1B21A31 VA: 0x1B21930
	private bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year) { }

	// RVA: 0x1B21B20 Offset: 0x1B21C21 VA: 0x1B21B20
	public bool IsDaylightSavingTime(DateTime dateTime) { }

	// RVA: 0x1B21C00 Offset: 0x1B21D01 VA: 0x1B21C00
	internal bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1B1F0B0 Offset: 0x1B1F1B1 VA: 0x1B1F0B0
	public bool IsInvalidTime(DateTime dateTime) { }

	// RVA: 0x1B21C10 Offset: 0x1B21D11 VA: 0x1B21C10 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1B21D00 Offset: 0x1B21E01 VA: 0x1B21D00
	private static void Validate(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x1B22230 Offset: 0x1B22331 VA: 0x1B22230 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B22240 Offset: 0x1B22341 VA: 0x1B22240
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B1B6B0 Offset: 0x1B1B7B1 VA: 0x1B1B6B0
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1B21180 Offset: 0x1B21281 VA: 0x1B21180
	private TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime) { }

	// RVA: 0x1B20D90 Offset: 0x1B20E91 VA: 0x1B20D90
	private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst, bool forOffset = False) { }

	// RVA: 0x1B21610 Offset: 0x1B21711 VA: 0x1B21610
	private static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year) { }

	// RVA: 0x1B205E0 Offset: 0x1B206E1 VA: 0x1B205E0
	private static TimeZoneInfo.AdjustmentRule[] ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules) { }

	// RVA: 0x1B1FFF0 Offset: 0x1B200F1 VA: 0x1B1FFF0
	private static TimeZoneInfo BuildFromStream(string id, Stream stream) { }

	// RVA: 0x1B22650 Offset: 0x1B22751 VA: 0x1B22650
	private static bool ValidTZFile(byte[] buffer, int length) { }

	// RVA: 0x1B23500 Offset: 0x1B23601 VA: 0x1B23500
	private static int SwapInt32(int i) { }

	// RVA: 0x1B23510 Offset: 0x1B23611 VA: 0x1B23510
	private static int ReadBigEndianInt32(byte[] buffer, int start) { }

	// RVA: 0x1B22780 Offset: 0x1B22881 VA: 0x1B22780
	private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) { }

	// RVA: 0x1B235A0 Offset: 0x1B236A1 VA: 0x1B235A0
	private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) { }

	// RVA: 0x1B23790 Offset: 0x1B23891 VA: 0x1B23790
	private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) { }

	// RVA: 0x1B239B0 Offset: 0x1B23AB1 VA: 0x1B239B0
	private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) { }

	// RVA: 0x1B23BB0 Offset: 0x1B23CB1 VA: 0x1B23BB0
	private static DateTime DateTimeFromUnixTime(long unix_time) { }

	// RVA: 0x1B23C00 Offset: 0x1B23D01 VA: 0x1B23C00
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1B23C40 Offset: 0x1B23D41 VA: 0x1B23C40
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1B1F730 Offset: 0x1B1F831 VA: 0x1B1F730
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1B23C70 Offset: 0x1B23D71 VA: 0x1B23C70
	internal void .ctor() { }
}

