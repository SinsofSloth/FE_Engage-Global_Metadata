// Namespace: 
public class VibrationManager.VibHandle // TypeDefIndex: 9168
{
	// Fields
	private const int DEVICE_COUNT_MAX = 2;
	private int m_deviceCount; // 0x10
	private VibrationDeviceHandle[] m_deviceHandles; // 0x18
	private VibrationDeviceInfo[] m_deviceInfos; // 0x20
	private VibrationValue m_value; // 0x28
	private float m_amplitudeMagnitude; // 0x38
	private VibrationFile m_file; // 0x40
	private int m_sample; // 0x48
	private bool m_sampleLoop; // 0x4C

	// Methods

	// RVA: 0x1DB9EA0 Offset: 0x1DB9FA1 VA: 0x1DB9EA0
	public void .ctor() { }

	// RVA: 0x1DB9F80 Offset: 0x1DBA081 VA: 0x1DB9F80
	public void SetupPad(NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x1DBA050 Offset: 0x1DBA151 VA: 0x1DBA050
	public void Clear() { }

	// RVA: 0x1DBA090 Offset: 0x1DBA191 VA: 0x1DBA090
	public void Set(VibrationFile file, bool isLoop) { }

	// RVA: 0x1DBA0D0 Offset: 0x1DBA1D1 VA: 0x1DBA0D0
	public void SetAmplitudeMagnitude(float amplitudeMagnitude) { }

	// RVA: 0x1DBA0E0 Offset: 0x1DBA1E1 VA: 0x1DBA0E0
	public void SetAmplitude(float ampLow, float ampHigh) { }

	// RVA: 0x1DBA0F0 Offset: 0x1DBA1F1 VA: 0x1DBA0F0
	public void SetFrequecy(float freqLow, float freqHigh) { }

	// RVA: 0x1DBA100 Offset: 0x1DBA201 VA: 0x1DBA100
	public void Update() { }
}

