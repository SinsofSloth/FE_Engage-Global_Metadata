// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2739B0 Offset: 0x273AB1 VA: 0x2739B0
[DefaultMemberAttribute] // RVA: 0x2739B0 Offset: 0x273AB1 VA: 0x2739B0
[Serializable]
public class CameraSwitch : MonoBehaviour // TypeDefIndex: 8560
{
	// Fields
	public Camera MainCamera; // 0x18
	public List<CameraInfo> VCameras; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x281E00 Offset: 0x281F01 VA: 0x281E00
	private Camera <SourceCamera>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x281E10 Offset: 0x281F11 VA: 0x281E10
	private CameraPosition <CurrentCamera>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x281E20 Offset: 0x281F21 VA: 0x281E20
	private CameraPosition <CurrentInterruptCamera>k__BackingField; // 0x34
	private int m_MaxPriprity; // 0x38

	// Properties
	public Camera SourceCamera { get; set; }
	public CameraPosition CurrentCamera { get; set; }
	public CameraPosition CurrentInterruptCamera { get; set; }
	public bool IsInterrupting { get; }
	public BaseCameraController Item { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9AE0 Offset: 0x2A9BE1 VA: 0x2A9AE0
	// RVA: 0x29A6840 Offset: 0x29A6941 VA: 0x29A6840
	public Camera get_SourceCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9AF0 Offset: 0x2A9BF1 VA: 0x2A9AF0
	// RVA: 0x29A6850 Offset: 0x29A6951 VA: 0x29A6850
	public void set_SourceCamera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9B00 Offset: 0x2A9C01 VA: 0x2A9B00
	// RVA: 0x29A6860 Offset: 0x29A6961 VA: 0x29A6860
	public CameraPosition get_CurrentCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9B10 Offset: 0x2A9C11 VA: 0x2A9B10
	// RVA: 0x29A6870 Offset: 0x29A6971 VA: 0x29A6870
	public void set_CurrentCamera(CameraPosition value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9B20 Offset: 0x2A9C21 VA: 0x2A9B20
	// RVA: 0x29A6880 Offset: 0x29A6981 VA: 0x29A6880
	public CameraPosition get_CurrentInterruptCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9B30 Offset: 0x2A9C31 VA: 0x2A9B30
	// RVA: 0x29A6890 Offset: 0x29A6991 VA: 0x29A6890
	public void set_CurrentInterruptCamera(CameraPosition value) { }

	// RVA: 0x29A68A0 Offset: 0x29A69A1 VA: 0x29A68A0
	public bool get_IsInterrupting() { }

	// RVA: 0x299D950 Offset: 0x299DA51 VA: 0x299D950
	public BaseCameraController get_Item(CameraPosition pos) { }

	// RVA: 0x29A68B0 Offset: 0x29A69B1 VA: 0x29A68B0
	private void Start() { }

	// RVA: 0x29A6B50 Offset: 0x29A6C51 VA: 0x29A6B50
	private void Update() { }

	// RVA: 0x29A6CA0 Offset: 0x29A6DA1 VA: 0x29A6CA0
	private void LateUpdate() { }

	// RVA: 0x29A36F0 Offset: 0x29A37F1 VA: 0x29A36F0
	public void SwitchCamera(CameraPosition nextCamera, bool force = False) { }

	// RVA: 0x29A55D0 Offset: 0x29A56D1 VA: 0x29A55D0
	internal void StartTransition(BaseCameraController nextCamera) { }

	// RVA: 0x29A6CB0 Offset: 0x29A6DB1 VA: 0x29A6CB0
	public void .ctor() { }
}

