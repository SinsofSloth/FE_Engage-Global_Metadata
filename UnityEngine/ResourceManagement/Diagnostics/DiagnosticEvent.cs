// Namespace: UnityEngine.ResourceManagement.Diagnostics
[Serializable]
public struct DiagnosticEvent // TypeDefIndex: 5606
{
	// Fields
	[SerializeField] // RVA: 0x72A60 Offset: 0x72B61 VA: 0x72A60
	private string m_Graph; // 0x0
	[SerializeField] // RVA: 0x72A70 Offset: 0x72B71 VA: 0x72A70
	private int[] m_Dependencies; // 0x8
	[SerializeField] // RVA: 0x72A80 Offset: 0x72B81 VA: 0x72A80
	private int m_ObjectId; // 0x10
	[SerializeField] // RVA: 0x72A90 Offset: 0x72B91 VA: 0x72A90
	private string m_DisplayName; // 0x18
	[SerializeField] // RVA: 0x72AA0 Offset: 0x72BA1 VA: 0x72AA0
	private int m_Stream; // 0x20
	[SerializeField] // RVA: 0x72AB0 Offset: 0x72BB1 VA: 0x72AB0
	private int m_Frame; // 0x24
	[SerializeField] // RVA: 0x72AC0 Offset: 0x72BC1 VA: 0x72AC0
	private int m_Value; // 0x28

	// Properties
	public string Graph { get; }
	public int ObjectId { get; }
	public string DisplayName { get; }
	public int[] Dependencies { get; }
	public int Stream { get; }
	public int Frame { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x362A7F0 Offset: 0x362A8F1 VA: 0x362A7F0
	public string get_Graph() { }

	// RVA: 0x362A800 Offset: 0x362A901 VA: 0x362A800
	public int get_ObjectId() { }

	// RVA: 0x362A810 Offset: 0x362A911 VA: 0x362A810
	public string get_DisplayName() { }

	// RVA: 0x362A820 Offset: 0x362A921 VA: 0x362A820
	public int[] get_Dependencies() { }

	// RVA: 0x362A830 Offset: 0x362A931 VA: 0x362A830
	public int get_Stream() { }

	// RVA: 0x362A840 Offset: 0x362A941 VA: 0x362A840
	public int get_Frame() { }

	// RVA: 0x362A850 Offset: 0x362A951 VA: 0x362A850
	public int get_Value() { }

	// RVA: 0x362A860 Offset: 0x362A961 VA: 0x362A860
	public void .ctor(string graph, string name, int id, int stream, int frame, int value, int[] deps) { }

	// RVA: 0x362A8E0 Offset: 0x362A9E1 VA: 0x362A8E0
	internal byte[] Serialize() { }

	// RVA: 0x362A990 Offset: 0x362AA91 VA: 0x362A990
	public static DiagnosticEvent Deserialize(byte[] data) { }
}

