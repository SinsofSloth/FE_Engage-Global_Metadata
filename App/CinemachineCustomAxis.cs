// Namespace: App
public abstract class CinemachineCustomAxis : MonoBehaviour // TypeDefIndex: 13989
{
	// Fields
	public bool xInversion; // 0x18
	public bool yInversion; // 0x19
	public CinemachineFreeLook CinemachineFreeLook; // 0x20
	public float Fov_Top; // 0x28
	public float Fov_Middle; // 0x2C
	public float Fov_Bottom; // 0x30
	[RangeAttribute] // RVA: 0x29CF40 Offset: 0x29D041 VA: 0x29CF40
	public float Allowance; // 0x34

	// Methods

	// RVA: 0x22BFDA0 Offset: 0x22BFEA1 VA: 0x22BFDA0
	private void Start() { }

	// RVA: 0x22BFE60 Offset: 0x22BFF61 VA: 0x22BFE60
	public float GetAxisCustom(string axisName) { }

	// RVA: 0x22C05F0 Offset: 0x22C06F1 VA: 0x22C05F0
	public void Update() { }

	// RVA: 0x22C0710 Offset: 0x22C0811 VA: 0x22C0710
	protected void .ctor() { }
}

