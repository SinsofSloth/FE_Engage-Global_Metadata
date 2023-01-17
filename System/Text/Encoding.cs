// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x4713D0 Offset: 0x4714D1 VA: 0x4713D0
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 461
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0x4781D0 Offset: 0x4782D1 VA: 0x4781D0
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0x478210 Offset: 0x478311 VA: 0x478210
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0x478250 Offset: 0x478351 VA: 0x478250
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string EncodingName { get; }
	public virtual string HeaderName { get; }
	public virtual string WebName { get; }
	[ComVisibleAttribute] // RVA: 0x47DD30 Offset: 0x47DE31 VA: 0x47DD30
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0x47DD50 Offset: 0x47DE51 VA: 0x47DD50
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0x47DD70 Offset: 0x47DE71 VA: 0x47DD70
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x372FD60 Offset: 0x372FE61 VA: 0x372FD60
	protected void .ctor() { }

	// RVA: 0x372FDA0 Offset: 0x372FEA1 VA: 0x372FDA0
	protected void .ctor(int codePage) { }

	// RVA: 0x372FE30 Offset: 0x372FF31 VA: 0x372FE30 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x372FEE0 Offset: 0x372FFE1 VA: 0x372FEE0
	internal void OnDeserializing() { }

	// RVA: 0x372FF20 Offset: 0x3730021 VA: 0x372FF20
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0x47B5C0 Offset: 0x47B6C1 VA: 0x47B5C0
	// RVA: 0x372FF70 Offset: 0x3730071 VA: 0x372FF70
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x47B5D0 Offset: 0x47B6D1 VA: 0x47B5D0
	// RVA: 0x372FFB0 Offset: 0x37300B1 VA: 0x372FFB0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x47B5E0 Offset: 0x47B6E1 VA: 0x47B5E0
	// RVA: 0x3730000 Offset: 0x3730101 VA: 0x3730000
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x3730010 Offset: 0x3730111 VA: 0x3730010
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3730410 Offset: 0x3730511 VA: 0x3730410
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x37305C0 Offset: 0x37306C1 VA: 0x37305C0
	private static object get_InternalSyncObject() { }

	// RVA: 0x3730680 Offset: 0x3730781 VA: 0x3730680
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x3731E80 Offset: 0x3731F81 VA: 0x3731E80
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x3732110 Offset: 0x3732211 VA: 0x3732110
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x37321E0 Offset: 0x37322E1 VA: 0x37321E0 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x3732250 Offset: 0x3732351 VA: 0x3732250
	private void GetDataItem() { }

	// RVA: 0x3732390 Offset: 0x3732491 VA: 0x3732390 Slot: 7
	public virtual string get_EncodingName() { }

	// RVA: 0x37323A0 Offset: 0x37324A1 VA: 0x37323A0 Slot: 8
	public virtual string get_HeaderName() { }

	// RVA: 0x37323F0 Offset: 0x37324F1 VA: 0x37323F0 Slot: 9
	public virtual string get_WebName() { }

	// RVA: 0x3732440 Offset: 0x3732541 VA: 0x3732440
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x3731F90 Offset: 0x3732091 VA: 0x3731F90
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x3732450 Offset: 0x3732551 VA: 0x3732450
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x3732050 Offset: 0x3732151 VA: 0x3732050
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0x47B5F0 Offset: 0x47B6F1 VA: 0x47B5F0
	// RVA: 0x3732460 Offset: 0x3732561 VA: 0x3732460 Slot: 10
	public virtual object Clone() { }

	// RVA: 0x37324F0 Offset: 0x37325F1 VA: 0x37324F0
	public bool get_IsReadOnly() { }

	// RVA: 0x3731560 Offset: 0x3731661 VA: 0x3731560
	public static Encoding get_ASCII() { }

	// RVA: 0x3731610 Offset: 0x3731711 VA: 0x3731610
	private static Encoding get_Latin1() { }

	// RVA: 0x3732500 Offset: 0x3732601 VA: 0x3732500 Slot: 11
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetByteCount(char[] chars, int index, int count);

	[CLSCompliantAttribute] // RVA: 0x47B610 Offset: 0x47B711 VA: 0x47B610
	[ComVisibleAttribute] // RVA: 0x47B610 Offset: 0x47B711 VA: 0x47B610
	// RVA: 0x3732590 Offset: 0x3732691 VA: 0x3732590 Slot: 13
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x3732700 Offset: 0x3732801 VA: 0x3732700 Slot: 14
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x3732710 Offset: 0x3732811 VA: 0x3732710 Slot: 15
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x37327D0 Offset: 0x37328D1 VA: 0x37327D0 Slot: 17
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x37328E0 Offset: 0x37329E1 VA: 0x37328E0 Slot: 18
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x37329A0 Offset: 0x3732AA1 VA: 0x37329A0 Slot: 19
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisibleAttribute] // RVA: 0x47B650 Offset: 0x47B751 VA: 0x47B650
	[CLSCompliantAttribute] // RVA: 0x47B650 Offset: 0x47B751 VA: 0x47B650
	// RVA: 0x37329B0 Offset: 0x3732AB1 VA: 0x37329B0 Slot: 20
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisibleAttribute] // RVA: 0x47B690 Offset: 0x47B791 VA: 0x47B690
	[CLSCompliantAttribute] // RVA: 0x47B690 Offset: 0x47B791 VA: 0x47B690
	// RVA: 0x3732BD0 Offset: 0x3732CD1 VA: 0x3732BD0 Slot: 22
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x3732D50 Offset: 0x3732E51 VA: 0x3732D50 Slot: 23
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x3732D60 Offset: 0x3732E61 VA: 0x3732D60 Slot: 24
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisibleAttribute] // RVA: 0x47B6D0 Offset: 0x47B7D1 VA: 0x47B6D0
	[CLSCompliantAttribute] // RVA: 0x47B6D0 Offset: 0x47B7D1 VA: 0x47B6D0
	// RVA: 0x3732E20 Offset: 0x3732F21 VA: 0x3732E20 Slot: 26
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x3733040 Offset: 0x3733141 VA: 0x3733040 Slot: 27
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x3733050 Offset: 0x3733151 VA: 0x3733050 Slot: 28
	public virtual int get_CodePage() { }

	// RVA: 0x3733060 Offset: 0x3733161 VA: 0x3733060 Slot: 29
	public virtual Decoder GetDecoder() { }

	// RVA: 0x37330D0 Offset: 0x37331D1 VA: 0x37330D0
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x3733310 Offset: 0x3733411 VA: 0x3733310
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x3731110 Offset: 0x3731211 VA: 0x3731110
	public static Encoding get_Default() { }

	// RVA: 0x3733320 Offset: 0x3733421 VA: 0x3733320 Slot: 30
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x3733390 Offset: 0x3733491 VA: 0x3733390 Slot: 33
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x3733430 Offset: 0x3733531 VA: 0x3733430 Slot: 34
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x37311F0 Offset: 0x37312F1 VA: 0x37311F0
	public static Encoding get_Unicode() { }

	// RVA: 0x37312A0 Offset: 0x37313A1 VA: 0x37312A0
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x3731350 Offset: 0x3731451 VA: 0x3731350
	public static Encoding get_UTF7() { }

	// RVA: 0x37314B0 Offset: 0x37315B1 VA: 0x37314B0
	public static Encoding get_UTF8() { }

	// RVA: 0x3731400 Offset: 0x3731501 VA: 0x3731400
	public static Encoding get_UTF32() { }

	// RVA: 0x3733460 Offset: 0x3733561 VA: 0x3733460 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3733530 Offset: 0x3733631 VA: 0x3733530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3733590 Offset: 0x3733691 VA: 0x3733590 Slot: 35
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x3733600 Offset: 0x3733701 VA: 0x3733600 Slot: 36
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x3733670 Offset: 0x3733771 VA: 0x3733670
	internal void ThrowBytesOverflow() { }

	// RVA: 0x3733760 Offset: 0x3733861 VA: 0x3733760
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x37337D0 Offset: 0x37338D1 VA: 0x37337D0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x37338C0 Offset: 0x37339C1 VA: 0x37338C0
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

