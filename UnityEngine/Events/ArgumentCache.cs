// Namespace: UnityEngine.Events
[Serializable]
internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 3682
{
	// Fields
	[SerializeField] // RVA: 0x443EE0 Offset: 0x443FE1 VA: 0x443EE0
	[FormerlySerializedAsAttribute] // RVA: 0x443EE0 Offset: 0x443FE1 VA: 0x443EE0
	private Object m_ObjectArgument; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x443F30 Offset: 0x444031 VA: 0x443F30
	[SerializeField] // RVA: 0x443F30 Offset: 0x444031 VA: 0x443F30
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[SerializeField] // RVA: 0x443F80 Offset: 0x444081 VA: 0x443F80
	[FormerlySerializedAsAttribute] // RVA: 0x443F80 Offset: 0x444081 VA: 0x443F80
	private int m_IntArgument; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x443FD0 Offset: 0x4440D1 VA: 0x443FD0
	[SerializeField] // RVA: 0x443FD0 Offset: 0x4440D1 VA: 0x443FD0
	private float m_FloatArgument; // 0x24
	[SerializeField] // RVA: 0x444020 Offset: 0x444121 VA: 0x444020
	[FormerlySerializedAsAttribute] // RVA: 0x444020 Offset: 0x444121 VA: 0x444020
	private string m_StringArgument; // 0x28
	[SerializeField] // RVA: 0x444070 Offset: 0x444171 VA: 0x444070
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }

	// Methods

	// RVA: 0x2F0A7F0 Offset: 0x2F0A8F1 VA: 0x2F0A7F0
	public Object get_unityObjectArgument() { }

	// RVA: 0x2F0A800 Offset: 0x2F0A901 VA: 0x2F0A800
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x2F0A810 Offset: 0x2F0A911 VA: 0x2F0A810
	public int get_intArgument() { }

	// RVA: 0x2F0A820 Offset: 0x2F0A921 VA: 0x2F0A820
	public float get_floatArgument() { }

	// RVA: 0x2F0A830 Offset: 0x2F0A931 VA: 0x2F0A830
	public string get_stringArgument() { }

	// RVA: 0x2F0A840 Offset: 0x2F0A941 VA: 0x2F0A840
	public bool get_boolArgument() { }

	// RVA: 0x2F0A850 Offset: 0x2F0A951 VA: 0x2F0A850 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2F0A890 Offset: 0x2F0A991 VA: 0x2F0A890 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2F0A8D0 Offset: 0x2F0A9D1 VA: 0x2F0A8D0
	public void .ctor() { }
}

