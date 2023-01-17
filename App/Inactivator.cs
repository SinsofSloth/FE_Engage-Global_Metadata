// Namespace: App
[DisallowMultipleComponent] // RVA: 0x279410 Offset: 0x279511 VA: 0x279410
public abstract class Inactivator : MonoBehaviour // TypeDefIndex: 14015
{
	// Fields
	[HideInInspector] // RVA: 0x29D260 Offset: 0x29D361 VA: 0x29D260
	public Inactivator.Flags m_Flags; // 0x18
	[HideInInspector] // RVA: 0x29D270 Offset: 0x29D371 VA: 0x29D270
	public string m_Variable; // 0x20

	// Methods

	// RVA: 0x2C46620 Offset: 0x2C46721 VA: 0x2C46620
	public bool IsUsed() { }

	// RVA: 0x2C46660 Offset: 0x2C46761 VA: 0x2C46660
	private static Inactivator.Kind GetKind() { }

	// RVA: 0x2C46800 Offset: 0x2C46901 VA: 0x2C46800
	public void Awake() { }

	// RVA: 0x2C469C0 Offset: 0x2C46AC1 VA: 0x2C469C0
	protected void .ctor() { }
}

