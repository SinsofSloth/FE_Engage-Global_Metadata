// Namespace: System.Net
[ComVisibleAttribute] // RVA: 0x30EA0 Offset: 0x30FA1 VA: 0x30EA0
[DefaultMemberAttribute] // RVA: 0x30EA0 Offset: 0x30FA1 VA: 0x30EA0
[Serializable]
public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 2480
{
	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x194A450 Offset: 0x194A551 VA: 0x194A450
	private void NormalizeCommonHeaders() { }

	// RVA: 0x194A590 Offset: 0x194A691 VA: 0x194A590
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x194A670 Offset: 0x194A771 VA: 0x194A670
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x194A730 Offset: 0x194A831 VA: 0x194A730
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x194A770 Offset: 0x194A871 VA: 0x194A770
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x194A880 Offset: 0x194A981 VA: 0x194A880
	internal void AddInternal(string name, string value) { }

	// RVA: 0x194A8E0 Offset: 0x194A9E1 VA: 0x194A8E0
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x194A940 Offset: 0x194AA41 VA: 0x194A940
	internal void RemoveInternal(string name) { }

	// RVA: 0x194A9A0 Offset: 0x194AAA1 VA: 0x194A9A0
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x194ADA0 Offset: 0x194AEA1 VA: 0x194ADA0
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x194AE30 Offset: 0x194AF31 VA: 0x194AE30
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x194AFB0 Offset: 0x194B0B1 VA: 0x194AFB0 Slot: 15
	public override void Add(string name, string value) { }

	// RVA: 0x194B160 Offset: 0x194B261 VA: 0x194B160
	public void Add(string header) { }

	// RVA: 0x194B430 Offset: 0x194B531 VA: 0x194B430 Slot: 18
	public override void Set(string name, string value) { }

	// RVA: 0x194B660 Offset: 0x194B761 VA: 0x194B660
	internal void SetInternal(string name, string value) { }

	// RVA: 0x194B880 Offset: 0x194B981 VA: 0x194B880 Slot: 19
	public override void Remove(string name) { }

	// RVA: 0x194B9D0 Offset: 0x194BAD1 VA: 0x194B9D0 Slot: 17
	public override string[] GetValues(string header) { }

	// RVA: 0x194BBE0 Offset: 0x194BCE1 VA: 0x194BBE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x194BC50 Offset: 0x194BD51 VA: 0x194BC50
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x194BF00 Offset: 0x194C001 VA: 0x194BF00
	public void .ctor() { }

	// RVA: 0x194BF80 Offset: 0x194C081 VA: 0x194BF80
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x194C090 Offset: 0x194C191 VA: 0x194C090
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194C270 Offset: 0x194C371 VA: 0x194C270 Slot: 12
	public override void OnDeserialization(object sender) { }

	// RVA: 0x194C280 Offset: 0x194C381 VA: 0x194C280 Slot: 11
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194C410 Offset: 0x194C511 VA: 0x194C410 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194C420 Offset: 0x194C521 VA: 0x194C420 Slot: 16
	public override string Get(string name) { }

	// RVA: 0x194C770 Offset: 0x194C871 VA: 0x194C770 Slot: 13
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x194C7F0 Offset: 0x194C8F1 VA: 0x194C7F0 Slot: 14
	public override int get_Count() { }

	// RVA: 0x194C830 Offset: 0x194C931 VA: 0x194C830 Slot: 20
	public override string Get(int index) { }

	// RVA: 0x194C870 Offset: 0x194C971 VA: 0x194C870 Slot: 21
	public override string GetKey(int index) { }

	// RVA: 0x194C8B0 Offset: 0x194C9B1 VA: 0x194C8B0
	private static void .cctor() { }
}

