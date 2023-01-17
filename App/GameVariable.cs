// Namespace: App
public class GameVariable // TypeDefIndex: 13630
{
	// Fields
	private const byte Type_Number = 0;
	private const byte Type_String = 1;
	private const int Version = 0;
	private const int VersionForOnline = 0;
	private int m_Capacity; // 0x10
	private Dictionary<string, GameVariable.Value> m_Dictionary; // 0x18
	private HashSet<string> m_Rewindable; // 0x20
	private List<string> m_Monitors; // 0x28

	// Properties
	public int Count { get; }
	public int Capacity { get; }

	// Methods

	// RVA: 0x28D9FA0 Offset: 0x28DA0A1 VA: 0x28D9FA0
	public void .ctor(int capacity) { }

	// RVA: 0x28DD710 Offset: 0x28DD811 VA: 0x28DD710
	public int get_Count() { }

	// RVA: 0x28DD770 Offset: 0x28DD871 VA: 0x28DD770
	public int get_Capacity() { }

	// RVA: 0x28DD780 Offset: 0x28DD881 VA: 0x28DD780
	public bool CanRwind(string key) { }

	// RVA: 0x28D25B0 Offset: 0x28D26B1 VA: 0x28D25B0
	public bool Entry(string key, int num = 0) { }

	// RVA: 0x28DD8C0 Offset: 0x28DD9C1 VA: 0x28DD8C0
	public bool Entry(string key, string str) { }

	// RVA: 0x28DD970 Offset: 0x28DDA71 VA: 0x28DD970
	public bool EntryNoRewind(string key, int num = 0) { }

	// RVA: 0x28DDA70 Offset: 0x28DDB71 VA: 0x28DDA70
	public bool EntryNoRewind(string key, string str) { }

	// RVA: 0x28DD7E0 Offset: 0x28DD8E1 VA: 0x28DD7E0
	private void EntryImpl(string key, GameVariable.Value value, bool rewindable) { }

	// RVA: 0x28DDB70 Offset: 0x28DDC71 VA: 0x28DDB70
	public bool Remove(string key) { }

	// RVA: 0x28DDC00 Offset: 0x28DDD01 VA: 0x28DDC00
	public void RemoveImpl(string key) { }

	// RVA: 0x28DDCE0 Offset: 0x28DDDE1 VA: 0x28DDCE0
	public int Get(string key) { }

	// RVA: 0x28DDD60 Offset: 0x28DDE61 VA: 0x28DDD60
	public bool IsString(string key) { }

	// RVA: 0x28DDDE0 Offset: 0x28DDEE1 VA: 0x28DDDE0
	public int GetNumber(string key) { }

	// RVA: 0x28DDE60 Offset: 0x28DDF61 VA: 0x28DDE60
	public bool GetBool(string key) { }

	// RVA: 0x28DDEF0 Offset: 0x28DDFF1 VA: 0x28DDEF0
	public bool TryGetBool(string key) { }

	// RVA: 0x28DDF80 Offset: 0x28DE081 VA: 0x28DDF80
	public string GetString(string key) { }

	// RVA: 0x28DE000 Offset: 0x28DE101 VA: 0x28DE000
	public int TryGet(string key, int empty = 0) { }

	// RVA: 0x28DE090 Offset: 0x28DE191 VA: 0x28DE090
	public bool TryGet(string key, out int result) { }

	// RVA: 0x28DE120 Offset: 0x28DE221 VA: 0x28DE120
	public void Set(string key, bool enable) { }

	// RVA: 0x28DE3C0 Offset: 0x28DE4C1 VA: 0x28DE3C0
	public void Set(string key, int num) { }

	// RVA: 0x28DE530 Offset: 0x28DE631 VA: 0x28DE530
	public void Set(string key, string str) { }

	// RVA: 0x28DE6A0 Offset: 0x28DE7A1 VA: 0x28DE6A0
	public void SetNumber(string key, int num) { }

	// RVA: 0x28DE800 Offset: 0x28DE901 VA: 0x28DE800
	public void SetString(string key, string str) { }

	// RVA: 0x28DE960 Offset: 0x28DEA61 VA: 0x28DE960
	public int Add(string key, int count = 1, int min = 0, int max = 999999) { }

	// RVA: 0x28D1670 Offset: 0x28D1771 VA: 0x28D1670
	public void ClearAll() { }

	// RVA: 0x28D28E0 Offset: 0x28D29E1 VA: 0x28D28E0
	public void ClearLocal() { }

	// RVA: 0x28DEC70 Offset: 0x28DED71 VA: 0x28DEC70
	public void ClearChapter() { }

	// RVA: 0x28DEE50 Offset: 0x28DEF51 VA: 0x28DEE50
	public void ClearHub() { }

	// RVA: 0x28DF080 Offset: 0x28DF181 VA: 0x28DF080
	public void ClearStartsWith(string name) { }

	// RVA: 0x28DF0B0 Offset: 0x28DF1B1 VA: 0x28DF0B0
	public List<string> FindStartsWith(string name) { }

	// RVA: 0x28DEB40 Offset: 0x28DEC41 VA: 0x28DEB40
	private void ClearKeys(List<string> keys) { }

	// RVA: 0x28DF260 Offset: 0x28DF361 VA: 0x28DF260
	public bool IsExist(string key) { }

	// RVA: 0x28DF2C0 Offset: 0x28DF3C1 VA: 0x28DF2C0
	public static bool IsLocal(string key) { }

	// RVA: 0x28DF380 Offset: 0x28DF481 VA: 0x28DF380
	public static bool IsChapter(string key) { }

	// RVA: 0x28DF3F0 Offset: 0x28DF4F1 VA: 0x28DF3F0
	public static bool IsHub(string key) { }

	// RVA: 0x28DF4B0 Offset: 0x28DF5B1 VA: 0x28DF4B0
	public static bool IsGlobal(string key) { }

	// RVA: 0x28D6F60 Offset: 0x28D7061 VA: 0x28D6F60
	public void Serialize(Stream stream) { }

	// RVA: 0x28D85F0 Offset: 0x28D86F1 VA: 0x28D85F0
	public void Deserialize(Stream stream) { }

	// RVA: 0x28DF520 Offset: 0x28DF621 VA: 0x28DF520
	private void SerializeKeyValue(Stream stream, KeyValuePair<string, GameVariable.Value> keyValue) { }

	// RVA: 0x28DF5E0 Offset: 0x28DF6E1 VA: 0x28DF5E0
	private void DeserializeKeyValue(Stream stream) { }

	// RVA: 0x28D9910 Offset: 0x28D9A11 VA: 0x28D9910
	public void SerializeForOnline(Stream stream) { }

	// RVA: 0x28D9B60 Offset: 0x28D9C61 VA: 0x28D9B60
	public void DeserializeForOnline(Stream stream) { }

	// RVA: 0x28DFE50 Offset: 0x28DFF51 VA: 0x28DFE50
	public List<string> FindKeys(string header) { }

	// RVA: 0x28E0000 Offset: 0x28E0101 VA: 0x28E0000
	public string GetName(string key) { }
}

