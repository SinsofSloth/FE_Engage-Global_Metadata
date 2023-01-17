// Namespace: 
[AddComponentMenu] // RVA: 0x272320 Offset: 0x272421 VA: 0x272320
[ExecuteInEditMode] // RVA: 0x272320 Offset: 0x272421 VA: 0x272320
[RequireComponent] // RVA: 0x272320 Offset: 0x272421 VA: 0x272320
public class AkEnvironmentPortal : MonoBehaviour // TypeDefIndex: 8014
{
	// Fields
	public const int MAX_ENVIRONMENTS_PER_PORTAL = 2;
	public Vector3 axis; // 0x18
	public AkEnvironment[] environments; // 0x28
	private BoxCollider m_BoxCollider; // 0x30

	// Properties
	private BoxCollider BoxCollider { get; }
	public bool EnvironmentsShareAuxBus { get; }

	// Methods

	// RVA: 0x31720B0 Offset: 0x31721B1 VA: 0x31720B0
	private BoxCollider get_BoxCollider() { }

	// RVA: 0x3172180 Offset: 0x3172281 VA: 0x3172180
	public bool get_EnvironmentsShareAuxBus() { }

	// RVA: 0x3172310 Offset: 0x3172411 VA: 0x3172310
	public float GetAuxSendValueForPosition(Vector3 in_position, int index) { }

	// RVA: 0x3172470 Offset: 0x3172571 VA: 0x3172470
	public void .ctor() { }
}

