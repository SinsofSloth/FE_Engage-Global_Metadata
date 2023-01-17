// Namespace: UnityEngine.EventSystems
public class BaseEventData : AbstractEventData // TypeDefIndex: 4386
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x1A3DD50 Offset: 0x1A3DE51 VA: 0x1A3DD50
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1A3DD90 Offset: 0x1A3DE91 VA: 0x1A3DD90
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x1A3DDA0 Offset: 0x1A3DEA1 VA: 0x1A3DDA0
	public GameObject get_selectedObject() { }

	// RVA: 0x1A3DDB0 Offset: 0x1A3DEB1 VA: 0x1A3DDB0
	public void set_selectedObject(GameObject value) { }
}

