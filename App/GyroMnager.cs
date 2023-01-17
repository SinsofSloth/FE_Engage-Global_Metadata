// Namespace: App
public class GyroMnager // TypeDefIndex: 9141
{
	// Fields
	private bool m_IsSampling; // 0x10
	private SixAxisSensorHandle[] m_HandleList; // 0x18
	private int m_HandleCoount; // 0x20
	private SixAxisSensorState[] m_StateList; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x286C60 Offset: 0x286D61 VA: 0x286C60
	private NpadStyle <PadStyle>k__BackingField; // 0x30

	// Properties
	public NpadStyle PadStyle { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AE4F0 Offset: 0x2AE5F1 VA: 0x2AE4F0
	// RVA: 0x2DB79F0 Offset: 0x2DB7AF1 VA: 0x2DB79F0
	public NpadStyle get_PadStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE500 Offset: 0x2AE601 VA: 0x2AE500
	// RVA: 0x2DB7A00 Offset: 0x2DB7B01 VA: 0x2DB7A00
	private void set_PadStyle(NpadStyle value) { }

	// RVA: 0x2DB7A10 Offset: 0x2DB7B11 VA: 0x2DB7A10
	public void .ctor() { }

	// RVA: 0x2DB7B10 Offset: 0x2DB7C11 VA: 0x2DB7B10
	public void SetupPad(NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x2DB7C80 Offset: 0x2DB7D81 VA: 0x2DB7C80
	public void StartSampling() { }

	// RVA: 0x2DB7C10 Offset: 0x2DB7D11 VA: 0x2DB7C10
	public void StopSampling() { }

	// RVA: 0x2DB7CF0 Offset: 0x2DB7DF1 VA: 0x2DB7CF0
	public void Update() { }

	// RVA: 0x2DB7DA0 Offset: 0x2DB7EA1 VA: 0x2DB7DA0
	public SixAxisSensorState GetState(GyroMnager.DeviceType type) { }
}

