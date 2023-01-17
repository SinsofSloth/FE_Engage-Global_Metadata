// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472F80 Offset: 0x473081 VA: 0x472F80
[Serializable]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 706
{
	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalFieldAttribute] // RVA: 0x478D00 Offset: 0x478E01 VA: 0x478D00
	internal string[] nativeDigits; // 0xA0
	[OptionalFieldAttribute] // RVA: 0x478D40 Offset: 0x478E41 VA: 0x478D40
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalFieldAttribute] // RVA: 0x478D80 Offset: 0x478E81 VA: 0x478D80
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalFieldAttribute] // RVA: 0x478DC0 Offset: 0x478EC1 VA: 0x478DC0
	internal bool m_useUserOverride; // 0xD1
	[OptionalFieldAttribute] // RVA: 0x478E00 Offset: 0x478F01 VA: 0x478E00
	internal bool m_isInvariant; // 0xD2
	[OptionalFieldAttribute] // RVA: 0x478E40 Offset: 0x478F41 VA: 0x478E40
	internal bool validForParseAsNumber; // 0xD3
	[OptionalFieldAttribute] // RVA: 0x478E80 Offset: 0x478F81 VA: 0x478E80
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	// Properties
	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; }
	public string CurrencyDecimalSeparator { get; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; }
	public int[] NumberGroupSizes { get; }
	public int[] PercentGroupSizes { get; }
	public string CurrencyGroupSeparator { get; }
	public string CurrencySymbol { get; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; }
	public int CurrencyNegativePattern { get; }
	public int NumberNegativePattern { get; }
	public int PercentPositivePattern { get; }
	public int PercentNegativePattern { get; }
	public string NegativeInfinitySymbol { get; }
	public string NegativeSign { get; }
	public int NumberDecimalDigits { get; }
	public string NumberDecimalSeparator { get; }
	public string NumberGroupSeparator { get; }
	public int CurrencyPositivePattern { get; }
	public string PositiveInfinitySymbol { get; }
	public string PositiveSign { get; }
	public int PercentDecimalDigits { get; }
	public string PercentDecimalSeparator { get; }
	public string PercentGroupSeparator { get; }
	public string PercentSymbol { get; }
	public string PerMilleSymbol { get; }

	// Methods

	// RVA: 0x385A9F0 Offset: 0x385AAF1 VA: 0x385A9F0
	public void .ctor() { }

	[OnSerializingAttribute] // RVA: 0x47C450 Offset: 0x47C551 VA: 0x47C450
	// RVA: 0x385B0D0 Offset: 0x385B1D1 VA: 0x385B0D0
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializingAttribute] // RVA: 0x47C460 Offset: 0x47C561 VA: 0x47C460
	// RVA: 0x385B170 Offset: 0x385B271 VA: 0x385B170
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x47C470 Offset: 0x47C571 VA: 0x47C470
	// RVA: 0x385B180 Offset: 0x385B281 VA: 0x385B180
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x385AA00 Offset: 0x385AB01 VA: 0x385AA00
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x385B190 Offset: 0x385B291 VA: 0x385B190
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x385B320 Offset: 0x385B421 VA: 0x385B320
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x385B5F0 Offset: 0x385B6F1 VA: 0x385B5F0 Slot: 4
	public object Clone() { }

	// RVA: 0x385B670 Offset: 0x385B771 VA: 0x385B670
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x385B680 Offset: 0x385B781 VA: 0x385B680
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0x385B690 Offset: 0x385B791 VA: 0x385B690
	public bool get_IsReadOnly() { }

	// RVA: 0x385B6A0 Offset: 0x385B7A1 VA: 0x385B6A0
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x385B720 Offset: 0x385B821 VA: 0x385B720
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x385B7A0 Offset: 0x385B8A1 VA: 0x385B7A0
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x385B820 Offset: 0x385B921 VA: 0x385B820
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x385B830 Offset: 0x385B931 VA: 0x385B830
	public string get_CurrencySymbol() { }

	// RVA: 0x385B4F0 Offset: 0x385B5F1 VA: 0x385B4F0
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x385B840 Offset: 0x385B941 VA: 0x385B840
	public string get_NaNSymbol() { }

	// RVA: 0x385B850 Offset: 0x385B951 VA: 0x385B850
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x385B860 Offset: 0x385B961 VA: 0x385B860
	public int get_NumberNegativePattern() { }

	// RVA: 0x385B870 Offset: 0x385B971 VA: 0x385B870
	public int get_PercentPositivePattern() { }

	// RVA: 0x385B880 Offset: 0x385B981 VA: 0x385B880
	public int get_PercentNegativePattern() { }

	// RVA: 0x385B890 Offset: 0x385B991 VA: 0x385B890
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x385B8A0 Offset: 0x385B9A1 VA: 0x385B8A0
	public string get_NegativeSign() { }

	// RVA: 0x385B8B0 Offset: 0x385B9B1 VA: 0x385B8B0
	public int get_NumberDecimalDigits() { }

	// RVA: 0x385B8C0 Offset: 0x385B9C1 VA: 0x385B8C0
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x385B8D0 Offset: 0x385B9D1 VA: 0x385B8D0
	public string get_NumberGroupSeparator() { }

	// RVA: 0x385B8E0 Offset: 0x385B9E1 VA: 0x385B8E0
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x385B8F0 Offset: 0x385B9F1 VA: 0x385B8F0
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x385B900 Offset: 0x385BA01 VA: 0x385B900
	public string get_PositiveSign() { }

	// RVA: 0x385B910 Offset: 0x385BA11 VA: 0x385B910
	public int get_PercentDecimalDigits() { }

	// RVA: 0x385B920 Offset: 0x385BA21 VA: 0x385B920
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x385B930 Offset: 0x385BA31 VA: 0x385B930
	public string get_PercentGroupSeparator() { }

	// RVA: 0x385B940 Offset: 0x385BA41 VA: 0x385B940
	public string get_PercentSymbol() { }

	// RVA: 0x385B950 Offset: 0x385BA51 VA: 0x385B950
	public string get_PerMilleSymbol() { }

	// RVA: 0x385B960 Offset: 0x385BA61 VA: 0x385B960 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x385B240 Offset: 0x385B341 VA: 0x385B240
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x385BA10 Offset: 0x385BB11 VA: 0x385BA10
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x385BAE0 Offset: 0x385BBE1 VA: 0x385BAE0
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }
}

