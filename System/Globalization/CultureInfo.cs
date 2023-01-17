// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x473060 Offset: 0x473161 VA: 0x473060
[Serializable]
public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 724
{
	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	internal static readonly bool IsTaiwanSku; // 0x38

	// Properties
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; set; }
	public static CultureInfo CurrentUICulture { get; }
	internal string Territory { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual Calendar Calendar { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string EnglishName { get; }
	public bool IsReadOnly { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }

	// Methods

	// RVA: 0x37D5130 Offset: 0x37D5231 VA: 0x37D5130
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x37DC090 Offset: 0x37DC191 VA: 0x37DC090
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x37DD980 Offset: 0x37DDA81 VA: 0x37DD980
	public static void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x37DD9B0 Offset: 0x37DDAB1 VA: 0x37DD9B0
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x37DD9D0 Offset: 0x37DDAD1 VA: 0x37DD9D0
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x37DDF70 Offset: 0x37DE071 VA: 0x37DDF70
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x37DDFE0 Offset: 0x37DE0E1 VA: 0x37DDFE0
	internal string get_Territory() { }

	// RVA: 0x37DDFF0 Offset: 0x37DE0F1 VA: 0x37DDFF0 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x37DE000 Offset: 0x37DE101 VA: 0x37DE000 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x37DE010 Offset: 0x37DE111 VA: 0x37DE010 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x37DE340 Offset: 0x37DE441 VA: 0x37DE340 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x37DE620 Offset: 0x37DE721 VA: 0x37DE620 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x37DE820 Offset: 0x37DE921 VA: 0x37DE820 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x37DE9C0 Offset: 0x37DEAC1 VA: 0x37DE9C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x37DEA80 Offset: 0x37DEB81 VA: 0x37DEA80
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x37DEAA0 Offset: 0x37DEBA1 VA: 0x37DEAA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37DEAB0 Offset: 0x37DEBB1 VA: 0x37DEAB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x37DEAC0 Offset: 0x37DEBC1 VA: 0x37DEAC0 Slot: 12
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x37DEC30 Offset: 0x37DED31 VA: 0x37DEC30 Slot: 13
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x37DEC90 Offset: 0x37DED91 VA: 0x37DEC90
	private void CheckNeutral() { }

	// RVA: 0x37DECA0 Offset: 0x37DEDA1 VA: 0x37DECA0 Slot: 14
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x37DED40 Offset: 0x37DEE41 VA: 0x37DED40 Slot: 15
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x37DEE20 Offset: 0x37DEF21 VA: 0x37DEE20 Slot: 16
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x37DEF10 Offset: 0x37DF011 VA: 0x37DEF10 Slot: 17
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x37DEFF0 Offset: 0x37DF0F1 VA: 0x37DEFF0 Slot: 18
	public virtual string get_EnglishName() { }

	// RVA: 0x37DF040 Offset: 0x37DF141 VA: 0x37DF040
	public bool get_IsReadOnly() { }

	// RVA: 0x37DF050 Offset: 0x37DF151 VA: 0x37DF050 Slot: 19
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x37DE0D0 Offset: 0x37DE1D1 VA: 0x37DE0D0
	private void Construct() { }

	// RVA: 0x37DF180 Offset: 0x37DF281 VA: 0x37DF180
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x37DF190 Offset: 0x37DF291 VA: 0x37DF190
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x37DDC20 Offset: 0x37DDD21 VA: 0x37DDC20
	private static string get_current_locale_name() { }

	// RVA: 0x37DF1A0 Offset: 0x37DF2A1 VA: 0x37DF1A0
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x37DE7A0 Offset: 0x37DE8A1 VA: 0x37DE7A0
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x37DE610 Offset: 0x37DE711 VA: 0x37DE610
	public void .ctor(int culture) { }

	// RVA: 0x37DF360 Offset: 0x37DF461 VA: 0x37DF360
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x37DF370 Offset: 0x37DF471 VA: 0x37DF370
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x37DE600 Offset: 0x37DE701 VA: 0x37DE600
	public void .ctor(string name) { }

	// RVA: 0x37DCD10 Offset: 0x37DCE11 VA: 0x37DCD10
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x37DF700 Offset: 0x37DF801 VA: 0x37DF700
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x37DFA90 Offset: 0x37DFB91 VA: 0x37DFA90
	private void .ctor() { }

	// RVA: 0x37DFAC0 Offset: 0x37DFBC1 VA: 0x37DFAC0
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x37DFC70 Offset: 0x37DFD71 VA: 0x37DFC70
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x37DFED0 Offset: 0x37DFFD1 VA: 0x37DFED0
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x37E0110 Offset: 0x37E0211 VA: 0x37E0110
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x37DDC30 Offset: 0x37DDD31 VA: 0x37DDC30
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x37E0190 Offset: 0x37E0291 VA: 0x37E0190
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x37DF680 Offset: 0x37DF781 VA: 0x37DF680
	internal int get_CalendarType() { }

	// RVA: 0x37DE100 Offset: 0x37DE201 VA: 0x37DE100
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x37DF9C0 Offset: 0x37DFAC1 VA: 0x37DF9C0
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x37E27D0 Offset: 0x37E28D1 VA: 0x37E27D0
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x37E2840 Offset: 0x37E2941 VA: 0x37E2840
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x37E28B0 Offset: 0x37E29B1 VA: 0x37E28B0
	internal string get_SortName() { }

	// RVA: 0x37E28C0 Offset: 0x37E29C1 VA: 0x37E28C0
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x37E2970 Offset: 0x37E2A71 VA: 0x37E2970
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x37E29E0 Offset: 0x37E2AE1 VA: 0x37E29E0
	internal static void CheckDomainSafetyObject(object obj, object container) { }

	// RVA: 0x37E2B80 Offset: 0x37E2C81 VA: 0x37E2B80
	private static void .cctor() { }
}

