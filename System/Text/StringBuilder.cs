// Namespace: System.Text
[DefaultMemberAttribute] // RVA: 0x471430 Offset: 0x471531 VA: 0x471430
[ComVisibleAttribute] // RVA: 0x471430 Offset: 0x471531 VA: 0x471430
[Serializable]
public sealed class StringBuilder : ISerializable // TypeDefIndex: 465
{
	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28
	internal const int DefaultCapacity = 16;
	private const string CapacityField = "Capacity";
	private const string MaxCapacityField = "m_MaxCapacity";
	private const string StringValueField = "m_StringValue";
	private const string ThreadIDField = "m_currentThread";
	internal const int MaxChunkSize = 8000;

	// Properties
	public int Capacity { get; set; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }

	// Methods

	// RVA: 0x36557D0 Offset: 0x36558D1 VA: 0x36557D0
	public void .ctor() { }

	// RVA: 0x3655850 Offset: 0x3655951 VA: 0x3655850
	public void .ctor(int capacity) { }

	// RVA: 0x36558F0 Offset: 0x36559F1 VA: 0x36558F0
	public void .ctor(string value) { }

	// RVA: 0x36558D0 Offset: 0x36559D1 VA: 0x36558D0
	public void .ctor(string value, int capacity) { }

	// RVA: 0x3655920 Offset: 0x3655A21 VA: 0x3655920
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x3655CB0 Offset: 0x3655DB1 VA: 0x3655CB0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3655FA0 Offset: 0x36560A1 VA: 0x3655FA0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x36560F0 Offset: 0x36561F1 VA: 0x36560F0
	public int get_Capacity() { }

	// RVA: 0x3656110 Offset: 0x3656211 VA: 0x3656110
	public void set_Capacity(int value) { }

	// RVA: 0x3656270 Offset: 0x3656371 VA: 0x3656270
	public int get_MaxCapacity() { }

	// RVA: 0x3656280 Offset: 0x3656381 VA: 0x3656280 Slot: 3
	public override string ToString() { }

	// RVA: 0x36563D0 Offset: 0x36564D1 VA: 0x36563D0
	public string ToString(int startIndex, int length) { }

	// RVA: 0x36565F0 Offset: 0x36566F1 VA: 0x36565F0
	public StringBuilder Clear() { }

	// RVA: 0x3656260 Offset: 0x3656361 VA: 0x3656260
	public int get_Length() { }

	// RVA: 0x3656620 Offset: 0x3656721 VA: 0x3656620
	public void set_Length(int value) { }

	// RVA: 0x3656910 Offset: 0x3656A11 VA: 0x3656910
	public char get_Chars(int index) { }

	// RVA: 0x36569A0 Offset: 0x3656AA1 VA: 0x36569A0
	public void set_Chars(int index, char value) { }

	// RVA: 0x36567D0 Offset: 0x36568D1 VA: 0x36567D0
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x3656C80 Offset: 0x3656D81 VA: 0x3656C80
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x3656F50 Offset: 0x3657051 VA: 0x3656F50
	public StringBuilder Append(string value) { }

	// RVA: 0x3657070 Offset: 0x3657171 VA: 0x3657070
	private void AppendHelper(string value) { }

	// RVA: 0x36570B0 Offset: 0x36571B1 VA: 0x36570B0
	public StringBuilder Append(string value, int startIndex, int count) { }

	[ComVisibleAttribute] // RVA: 0x47B710 Offset: 0x47B811 VA: 0x47B710
	// RVA: 0x3657260 Offset: 0x3657361 VA: 0x3657260
	public StringBuilder AppendLine() { }

	[ComVisibleAttribute] // RVA: 0x47B730 Offset: 0x47B831 VA: 0x47B730
	// RVA: 0x3657290 Offset: 0x3657391 VA: 0x3657290
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x36572C0 Offset: 0x36573C1 VA: 0x36572C0
	public StringBuilder Insert(int index, string value, int count) { }

	// RVA: 0x3657900 Offset: 0x3657A01 VA: 0x3657900
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x3657BB0 Offset: 0x3657CB1 VA: 0x3657BB0
	public StringBuilder Append(bool value) { }

	// RVA: 0x3657BF0 Offset: 0x3657CF1 VA: 0x3657BF0
	public StringBuilder Append(byte value) { }

	// RVA: 0x3657C80 Offset: 0x3657D81 VA: 0x3657C80
	public StringBuilder Append(char value) { }

	// RVA: 0x3657D30 Offset: 0x3657E31 VA: 0x3657D30
	public StringBuilder Append(short value) { }

	// RVA: 0x3657DC0 Offset: 0x3657EC1 VA: 0x3657DC0
	public StringBuilder Append(int value) { }

	// RVA: 0x3657E50 Offset: 0x3657F51 VA: 0x3657E50
	public StringBuilder Append(long value) { }

	// RVA: 0x3657EE0 Offset: 0x3657FE1 VA: 0x3657EE0
	public StringBuilder Append(float value) { }

	// RVA: 0x3657F70 Offset: 0x3658071 VA: 0x3657F70
	public StringBuilder Append(double value) { }

	// RVA: 0x3658000 Offset: 0x3658101 VA: 0x3658000
	public StringBuilder Append(object value) { }

	// RVA: 0x3658050 Offset: 0x3658151 VA: 0x3658050
	public StringBuilder Append(char[] value) { }

	// RVA: 0x3658090 Offset: 0x3658191 VA: 0x3658090
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x3658250 Offset: 0x3658351 VA: 0x3658250
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x3658280 Offset: 0x3658381 VA: 0x3658280
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x3658C20 Offset: 0x3658D21 VA: 0x3658C20
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x3658C90 Offset: 0x3658D91 VA: 0x3658C90
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x3658D00 Offset: 0x3658E01 VA: 0x3658D00
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x3658DC0 Offset: 0x3658EC1 VA: 0x3658DC0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x3658E30 Offset: 0x3658F31 VA: 0x3658E30
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x3658EB0 Offset: 0x3658FB1 VA: 0x3658EB0
	private static void FormatError() { }

	// RVA: 0x36582F0 Offset: 0x36583F1 VA: 0x36582F0
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x3658F10 Offset: 0x3659011 VA: 0x3658F10
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x3658F20 Offset: 0x3659021 VA: 0x3658F20
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	// RVA: 0x3659670 Offset: 0x3659771 VA: 0x3659670
	public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count) { }

	[CLSCompliantAttribute] // RVA: 0x47B750 Offset: 0x47B851 VA: 0x47B750
	// RVA: 0x3656E40 Offset: 0x3656F41 VA: 0x3656E40
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x3658160 Offset: 0x3658261 VA: 0x3658160
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x3659450 Offset: 0x3659551 VA: 0x3659450
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x3659350 Offset: 0x3659451 VA: 0x3659350
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x36577C0 Offset: 0x36578C1 VA: 0x36577C0
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x3655BD0 Offset: 0x3655CD1 VA: 0x3655BD0
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x36598B0 Offset: 0x36599B1 VA: 0x36598B0
	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x36568F0 Offset: 0x36569F1 VA: 0x36568F0
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x3659870 Offset: 0x3659971 VA: 0x3659870
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x3656A60 Offset: 0x3656B61 VA: 0x3656A60
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x3659980 Offset: 0x3659A81 VA: 0x3659980
	private void .ctor(StringBuilder from) { }

	// RVA: 0x3657460 Offset: 0x3657561 VA: 0x3657460
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	// RVA: 0x36599E0 Offset: 0x3659AE1 VA: 0x36599E0
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x3657A60 Offset: 0x3657B61 VA: 0x3657A60
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }
}

