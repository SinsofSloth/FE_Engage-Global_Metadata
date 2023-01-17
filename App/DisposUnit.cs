// Namespace: App
public abstract class DisposUnit : MonoBehaviour // TypeDefIndex: 13997
{
	// Fields
	public const int LevelMax = 20;
	[HideInInspector] // RVA: 0x29CF60 Offset: 0x29D061 VA: 0x29CF60
	public string m_Person; // 0x18
	[HideInInspector] // RVA: 0x29CF70 Offset: 0x29D071 VA: 0x29CF70
	public string m_Job; // 0x20
	[HideInInspector] // RVA: 0x29CF80 Offset: 0x29D081 VA: 0x29CF80
	public string m_Force; // 0x28
	[HideInInspector] // RVA: 0x29CF90 Offset: 0x29D091 VA: 0x29CF90
	public int m_Level; // 0x30
	[HideInInspector] // RVA: 0x29CFA0 Offset: 0x29D0A1 VA: 0x29CFA0
	public bool m_Normal; // 0x34
	[HideInInspector] // RVA: 0x29CFB0 Offset: 0x29D0B1 VA: 0x29CFB0
	public bool m_Hard; // 0x35
	[HideInInspector] // RVA: 0x29CFC0 Offset: 0x29D0C1 VA: 0x29CFC0
	public bool m_Lunatic; // 0x36
	[HideInInspector] // RVA: 0x29CFD0 Offset: 0x29D0D1 VA: 0x29CFD0
	public bool 新規生成; // 0x37
	[HideInInspector] // RVA: 0x29CFE0 Offset: 0x29D0E1 VA: 0x29CFE0
	public bool リーダー; // 0x38
	[HideInInspector] // RVA: 0x29CFF0 Offset: 0x29D0F1 VA: 0x29CFF0
	public bool 移動禁止; // 0x39
	[HideInInspector] // RVA: 0x29D000 Offset: 0x29D101 VA: 0x29D000
	public bool 進撃位置; // 0x3A
	[HideInInspector] // RVA: 0x29D010 Offset: 0x29D111 VA: 0x29D010
	public bool 進撃強制; // 0x3B
	[HideInInspector] // RVA: 0x29D020 Offset: 0x29D121 VA: 0x29D020
	public bool 進撃固定; // 0x3C
	[HideInInspector] // RVA: 0x29D030 Offset: 0x29D131 VA: 0x29D030
	public bool 外枠配置; // 0x3D
	[HideInInspector] // RVA: 0x29D040 Offset: 0x29D141 VA: 0x29D040
	public bool ゲスト; // 0x3E
	[HideInInspector] // RVA: 0x29D050 Offset: 0x29D151 VA: 0x29D050
	public DisposUnit.Item[] m_Items; // 0x40

	// Methods

	// RVA: 0x23815C0 Offset: 0x23816C1 VA: 0x23815C0
	public Force.Type GetForceType() { }

	// RVA: 0x23816D0 Offset: 0x23817D1 VA: 0x23816D0
	public static string[] GetForceNames() { }

	// RVA: 0x23818B0 Offset: 0x23819B1 VA: 0x23818B0
	public static string GetForceName(int index) { }

	// RVA: 0x23818F0 Offset: 0x23819F1 VA: 0x23818F0
	public static int GetForceIndex(string name) { }

	// RVA: 0x2381980 Offset: 0x2381A81 VA: 0x2381980
	protected void .ctor() { }
}

