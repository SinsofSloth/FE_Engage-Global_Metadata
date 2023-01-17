// Namespace: App
public class PlayReportEvent // TypeDefIndex: 13783
{
	// Fields
	private static Uid s_Uid; // 0x0
	private static string s_EventId; // 0x10
	private static int s_KeyValueCount; // 0x18

	// Methods

	// RVA: 0x29D2840 Offset: 0x29D2941 VA: 0x29D2840
	public static void Start(string eventId, Uid uid) { }

	// RVA: 0x29D3F70 Offset: 0x29D4071 VA: 0x29D3F70
	public static void End() { }

	// RVA: -1 Offset: -1
	public static void Add<T>(string key, long val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29807D0 Offset: 0x29808D1 VA: 0x29807D0
	|-PlayReportEvent.Add<object>
	*/

	// RVA: 0x29D29A0 Offset: 0x29D2AA1 VA: 0x29D29A0
	public static void Add(string key, ulong val) { }

	// RVA: 0x29D5FB0 Offset: 0x29D60B1 VA: 0x29D5FB0
	public static void Add(string key, float val) { }

	// RVA: 0x29D8730 Offset: 0x29D8831 VA: 0x29D8730
	public static void Add(string key, double val) { }

	// RVA: 0x29D2AA0 Offset: 0x29D2BA1 VA: 0x29D2AA0
	public static void Add(string key, string val) { }

	// RVA: 0x29D6630 Offset: 0x29D6731 VA: 0x29D6630
	public static void Add(string key, bool val) { }

	// RVA: 0x29D8840 Offset: 0x29D8941 VA: 0x29D8840
	public static void Add(string key, byte[] val) { }

	// RVA: 0x29D84A0 Offset: 0x29D85A1 VA: 0x29D84A0
	public static void AddStruct(string key) { }

	// RVA: 0x29D86C0 Offset: 0x29D87C1 VA: 0x29D86C0
	private static void PrepareAddReport() { }

	// RVA: 0x29D8690 Offset: 0x29D8791 VA: 0x29D8690
	private static void PlayReportWarning(Result result, string id) { }

	// RVA: -1 Offset: -1
	public static byte[] ToBytes<T>(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29809A0 Offset: 0x2980AA1 VA: 0x29809A0
	|-PlayReportEvent.ToBytes<object>
	*/

	// RVA: -1 Offset: -1
	public static T FromBytes<T>(byte[] bytes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980860 Offset: 0x2980961 VA: 0x2980860
	|-PlayReportEvent.FromBytes<object>
	*/

	// RVA: 0x29D8950 Offset: 0x29D8A51 VA: 0x29D8950
	public void .ctor() { }

	// RVA: 0x29D8960 Offset: 0x29D8A61 VA: 0x29D8960
	private static void .cctor() { }
}

