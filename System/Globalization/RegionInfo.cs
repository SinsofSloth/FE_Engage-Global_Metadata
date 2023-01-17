// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x473080 Offset: 0x473181 VA: 0x473080
[Serializable]
public class RegionInfo // TypeDefIndex: 728
{
	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisibleAttribute] // RVA: 0x47E000 Offset: 0x47E101 VA: 0x47E000
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODOAttribute] // RVA: 0x47E020 Offset: 0x47E121 VA: 0x47E020
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisibleAttribute] // RVA: 0x47E060 Offset: 0x47E161 VA: 0x47E060
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisibleAttribute] // RVA: 0x47E080 Offset: 0x47E181 VA: 0x47E080
	public virtual string NativeName { get; }
	[ComVisibleAttribute] // RVA: 0x47E0A0 Offset: 0x47E1A1 VA: 0x47E0A0
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x3B73BF0 Offset: 0x3B73CF1 VA: 0x3B73BF0
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x3B73EF0 Offset: 0x3B73FF1 VA: 0x3B73EF0
	public void .ctor(int culture) { }

	// RVA: 0x3B740C0 Offset: 0x3B741C1 VA: 0x3B740C0
	public void .ctor(string name) { }

	// RVA: 0x3B73CE0 Offset: 0x3B73DE1 VA: 0x3B73CE0
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x3B74010 Offset: 0x3B74111 VA: 0x3B74010
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x3B74210 Offset: 0x3B74311 VA: 0x3B74210
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x3B74220 Offset: 0x3B74321 VA: 0x3B74220 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x3B74230 Offset: 0x3B74331 VA: 0x3B74230 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x3B74240 Offset: 0x3B74341 VA: 0x3B74240 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x3B74250 Offset: 0x3B74351 VA: 0x3B74250 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x3B74260 Offset: 0x3B74361 VA: 0x3B74260 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x3B74270 Offset: 0x3B74371 VA: 0x3B74270 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x3B74320 Offset: 0x3B74421 VA: 0x3B74320 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x3B74330 Offset: 0x3B74431 VA: 0x3B74330 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x3B74340 Offset: 0x3B74441 VA: 0x3B74340 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x3B74350 Offset: 0x3B74451 VA: 0x3B74350 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x3B74360 Offset: 0x3B74461 VA: 0x3B74360 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x3B74370 Offset: 0x3B74471 VA: 0x3B74370 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x3B74380 Offset: 0x3B74481 VA: 0x3B74380 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x3B74390 Offset: 0x3B74491 VA: 0x3B74390 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3B74460 Offset: 0x3B74561 VA: 0x3B74460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3B74490 Offset: 0x3B74591 VA: 0x3B74490 Slot: 3
	public override string ToString() { }

	// RVA: 0x3B744A0 Offset: 0x3B745A1 VA: 0x3B744A0
	internal static void ClearCachedData() { }
}

