// Namespace: UnityEngine.Rendering
[HelpURLAttribute] // RVA: 0x3B400 Offset: 0x3B501 VA: 0x3B400
public class CameraSwitcher : MonoBehaviour // TypeDefIndex: 4506
{
	// Fields
	public Camera[] m_Cameras; // 0x18
	private int m_CurrentCameraIndex; // 0x20
	private Camera m_OriginalCamera; // 0x28
	private Vector3 m_OriginalCameraPosition; // 0x30
	private Quaternion m_OriginalCameraRotation; // 0x3C
	private Camera m_CurrentCamera; // 0x50
	private GUIContent[] m_CameraNames; // 0x58
	private int[] m_CameraIndices; // 0x60
	private DebugUI.EnumField m_DebugEntry; // 0x68
	private int m_DebugEntryEnumIndex; // 0x70

	// Methods

	// RVA: 0x1B2ABF0 Offset: 0x1B2ACF1 VA: 0x1B2ABF0
	private void OnEnable() { }

	// RVA: 0x1B2B5F0 Offset: 0x1B2B6F1 VA: 0x1B2B5F0
	private void OnDisable() { }

	// RVA: 0x1B2B270 Offset: 0x1B2B371 VA: 0x1B2B270
	private int GetCameraCount() { }

	// RVA: 0x1B2B680 Offset: 0x1B2B781 VA: 0x1B2B680
	private Camera GetNextCamera() { }

	// RVA: 0x1B2B6D0 Offset: 0x1B2B7D1 VA: 0x1B2B6D0
	private void SetCameraIndex(int index) { }

	// RVA: 0x1B2B910 Offset: 0x1B2BA11 VA: 0x1B2B910
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D570 Offset: 0x3D671 VA: 0x3D570
	// RVA: 0x1B2B920 Offset: 0x1B2BA21 VA: 0x1B2B920
	private int <OnEnable>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D580 Offset: 0x3D681 VA: 0x3D580
	// RVA: 0x1B2B930 Offset: 0x1B2BA31 VA: 0x1B2B930
	private void <OnEnable>b__10_1(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D590 Offset: 0x3D691 VA: 0x3D590
	// RVA: 0x1B2B940 Offset: 0x1B2BA41 VA: 0x1B2B940
	private int <OnEnable>b__10_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D5A0 Offset: 0x3D6A1 VA: 0x3D5A0
	// RVA: 0x1B2B950 Offset: 0x1B2BA51 VA: 0x1B2B950
	private void <OnEnable>b__10_3(int value) { }
}

