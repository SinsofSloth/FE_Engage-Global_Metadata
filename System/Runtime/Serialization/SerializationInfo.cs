// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x474780 Offset: 0x474881 VA: 0x474780
public sealed class SerializationInfo // TypeDefIndex: 1020
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x47D140 Offset: 0x47D241 VA: 0x47D140
	// RVA: 0x3619B60 Offset: 0x3619C61 VA: 0x3619B60
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0x47D160 Offset: 0x47D261 VA: 0x47D160
	// RVA: 0x3619B70 Offset: 0x3619C71 VA: 0x3619B70
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x3619DB0 Offset: 0x3619EB1 VA: 0x3619DB0
	public string get_FullTypeName() { }

	// RVA: 0x3619DC0 Offset: 0x3619EC1 VA: 0x3619DC0
	public string get_AssemblyName() { }

	// RVA: 0x3610C30 Offset: 0x3610D31 VA: 0x3610C30
	public void SetType(Type type) { }

	// RVA: 0x3619DE0 Offset: 0x3619EE1 VA: 0x3619DE0
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x3619DD0 Offset: 0x3619ED1 VA: 0x3619DD0
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x3619E90 Offset: 0x3619F91 VA: 0x3619E90
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x361A010 Offset: 0x361A111 VA: 0x361A010
	public int get_MemberCount() { }

	// RVA: 0x361A020 Offset: 0x361A121 VA: 0x361A020
	public Type get_ObjectType() { }

	// RVA: 0x361A030 Offset: 0x361A131 VA: 0x361A030
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x361A040 Offset: 0x361A141 VA: 0x361A040
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x3615430 Offset: 0x3615531 VA: 0x3615430
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x361A0E0 Offset: 0x361A1E1 VA: 0x361A0E0
	private void ExpandArrays() { }

	// RVA: 0x3607870 Offset: 0x3607971 VA: 0x3607870
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x36157B0 Offset: 0x36158B1 VA: 0x36157B0
	public void AddValue(string name, object value) { }

	// RVA: 0x361A410 Offset: 0x361A511 VA: 0x361A410
	public void AddValue(string name, bool value) { }

	// RVA: 0x361A4F0 Offset: 0x361A5F1 VA: 0x361A4F0
	public void AddValue(string name, char value) { }

	// RVA: 0x361A5D0 Offset: 0x361A6D1 VA: 0x361A5D0
	public void AddValue(string name, byte value) { }

	// RVA: 0x361A6B0 Offset: 0x361A7B1 VA: 0x361A6B0
	public void AddValue(string name, short value) { }

	// RVA: 0x361A790 Offset: 0x361A891 VA: 0x361A790
	public void AddValue(string name, int value) { }

	// RVA: 0x361A870 Offset: 0x361A971 VA: 0x361A870
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0x47D180 Offset: 0x47D281 VA: 0x47D180
	// RVA: 0x361A950 Offset: 0x361AA51 VA: 0x361A950
	public void AddValue(string name, ulong value) { }

	// RVA: 0x361AA30 Offset: 0x361AB31 VA: 0x361AA30
	public void AddValue(string name, float value) { }

	// RVA: 0x361AB10 Offset: 0x361AC11 VA: 0x361AB10
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x361A230 Offset: 0x361A331 VA: 0x361A230
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x361ABF0 Offset: 0x361ACF1 VA: 0x361ABF0
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x361ACE0 Offset: 0x361ADE1 VA: 0x361ACE0
	private int FindElement(string name) { }

	// RVA: 0x361ADA0 Offset: 0x361AEA1 VA: 0x361ADA0
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0x47D1A0 Offset: 0x47D2A1 VA: 0x47D1A0
	// RVA: 0x361AEB0 Offset: 0x361AFB1 VA: 0x361AEB0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x3607450 Offset: 0x3607551 VA: 0x3607450
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0x47D1C0 Offset: 0x47D2C1 VA: 0x47D1C0
	// RVA: 0x3610960 Offset: 0x3610A61 VA: 0x3610960
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x361AF60 Offset: 0x361B061 VA: 0x361AF60
	public bool GetBoolean(string name) { }

	// RVA: 0x361B0F0 Offset: 0x361B1F1 VA: 0x361B0F0
	public int GetInt32(string name) { }

	// RVA: 0x361B270 Offset: 0x361B371 VA: 0x361B270
	public long GetInt64(string name) { }

	// RVA: 0x361B3F0 Offset: 0x361B4F1 VA: 0x361B3F0
	public float GetSingle(string name) { }

	// RVA: 0x361B570 Offset: 0x361B671 VA: 0x361B570
	public string GetString(string name) { }
}

