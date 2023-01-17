// Namespace: UnityEngine.ResourceManagement.Util
[Serializable]
public struct SerializedType // TypeDefIndex: 5570
{
	// Fields
	[SerializeField] // RVA: 0x72620 Offset: 0x72721 VA: 0x72620
	[FormerlySerializedAsAttribute] // RVA: 0x72620 Offset: 0x72721 VA: 0x72620
	private string m_AssemblyName; // 0x0
	[SerializeField] // RVA: 0x72670 Offset: 0x72771 VA: 0x72670
	[FormerlySerializedAsAttribute] // RVA: 0x72670 Offset: 0x72771 VA: 0x72670
	private string m_ClassName; // 0x8
	private Type m_CachedType; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x726C0 Offset: 0x727C1 VA: 0x726C0
	private bool <ValueChanged>k__BackingField; // 0x18

	// Properties
	public string AssemblyName { get; }
	public string ClassName { get; }
	public Type Value { get; set; }
	public bool ValueChanged { get; set; }

	// Methods

	// RVA: 0x3636AA0 Offset: 0x3636BA1 VA: 0x3636AA0
	public string get_AssemblyName() { }

	// RVA: 0x3636AB0 Offset: 0x3636BB1 VA: 0x3636AB0
	public string get_ClassName() { }

	// RVA: 0x3636AC0 Offset: 0x3636BC1 VA: 0x3636AC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x36305D0 Offset: 0x36306D1 VA: 0x36305D0
	public Type get_Value() { }

	// RVA: 0x3636B80 Offset: 0x3636C81 VA: 0x3636B80
	public void set_Value(Type value) { }

	[IsReadOnlyAttribute] // RVA: 0x72E40 Offset: 0x72F41 VA: 0x72E40
	[CompilerGeneratedAttribute] // RVA: 0x72E40 Offset: 0x72F41 VA: 0x72E40
	// RVA: 0x3636C80 Offset: 0x3636D81 VA: 0x3636C80
	public bool get_ValueChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x72E80 Offset: 0x72F81 VA: 0x72E80
	// RVA: 0x3636C90 Offset: 0x3636D91 VA: 0x3636C90
	public void set_ValueChanged(bool value) { }
}

