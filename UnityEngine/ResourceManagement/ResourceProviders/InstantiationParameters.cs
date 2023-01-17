// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct InstantiationParameters // TypeDefIndex: 5583
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Quaternion m_Rotation; // 0xC
	private Transform m_Parent; // 0x20
	private bool m_InstantiateInWorldPosition; // 0x28
	private bool m_SetPositionRotation; // 0x29

	// Properties
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Transform Parent { get; }
	public bool InstantiateInWorldPosition { get; }
	public bool SetPositionRotation { get; }

	// Methods

	// RVA: 0x362DF00 Offset: 0x362E001 VA: 0x362DF00
	public Vector3 get_Position() { }

	// RVA: 0x362DF10 Offset: 0x362E011 VA: 0x362DF10
	public Quaternion get_Rotation() { }

	// RVA: 0x362DF20 Offset: 0x362E021 VA: 0x362DF20
	public Transform get_Parent() { }

	// RVA: 0x362DF30 Offset: 0x362E031 VA: 0x362DF30
	public bool get_InstantiateInWorldPosition() { }

	// RVA: 0x362DF40 Offset: 0x362E041 VA: 0x362DF40
	public bool get_SetPositionRotation() { }

	// RVA: 0x362DF50 Offset: 0x362E051 VA: 0x362DF50
	public void .ctor(Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x362DFD0 Offset: 0x362E0D1 VA: 0x362DFD0
	public void .ctor(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: -1 Offset: -1
	public TObject Instantiate<TObject>(TObject source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2959C60 Offset: 0x2959D61 VA: 0x2959C60
	|-InstantiationParameters.Instantiate<GameObject>
	|-InstantiationParameters.Instantiate<object>
	*/
}

