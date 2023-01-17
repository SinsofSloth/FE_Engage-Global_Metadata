// Namespace: App
public class VibrationManager // TypeDefIndex: 9169
{
	// Fields
	private Dictionary<string, VibrationFile> m_vibrationFileDictionary; // 0x10
	private VibrationManager.VibHandle m_handle; // 0x18
	private IDisposable m_Stop; // 0x20

	// Methods

	// RVA: 0x26C2930 Offset: 0x26C2A31 VA: 0x26C2930
	public void .ctor() { }

	// RVA: 0x26C2C50 Offset: 0x26C2D51 VA: 0x26C2C50
	public void SetFile(VibrationFile file, bool isLoop = False) { }

	// RVA: 0x26C2C60 Offset: 0x26C2D61 VA: 0x26C2C60
	public void SetAmplitudeMagnitude(float amplitudeMagnitude) { }

	// RVA: 0x26C2C70 Offset: 0x26C2D71 VA: 0x26C2C70
	public void SetAmplitude(float ampLow, float ampHigh) { }

	// RVA: 0x26C2C80 Offset: 0x26C2D81 VA: 0x26C2C80
	public void SetFrequecy(float freqLow, float freqHigh) { }

	// RVA: 0x26C2C90 Offset: 0x26C2D91 VA: 0x26C2C90
	public void OneShot(float time, float amplitudeMagnitude, float ampLow = 0, float ampHigh = 0) { }

	// RVA: 0x26C2CB0 Offset: 0x26C2DB1 VA: 0x26C2CB0
	public void OneShot(float time, float amplitudeMagnitude, float ampLow, float ampHigh, float freqLow, float freqHigh) { }

	// RVA: 0x26C30C0 Offset: 0x26C31C1 VA: 0x26C30C0
	public void StopVibe() { }

	// RVA: 0x26C3380 Offset: 0x26C3481 VA: 0x26C3380
	public void PlayByGameSoundEvent(string eventName, float time = 3, bool isLoop = False) { }

	// RVA: 0x26C3460 Offset: 0x26C3561 VA: 0x26C3460
	public void PlayByVibrationFileName(string vibFileName, float amplitudeMagnitude, float time = 3, bool isLoop = False) { }

	// RVA: 0x26C3660 Offset: 0x26C3761 VA: 0x26C3660
	public void Update() { }

	// RVA: 0x26C3670 Offset: 0x26C3771 VA: 0x26C3670
	public void SetupPad(NpadId npadId, NpadStyle npadStyle) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE720 Offset: 0x2AE821 VA: 0x2AE720
	// RVA: 0x26C3680 Offset: 0x26C3781 VA: 0x26C3680
	private void <OneShot>b__10_0(long _) { }
}

