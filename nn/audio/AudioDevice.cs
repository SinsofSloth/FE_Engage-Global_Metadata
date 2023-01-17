// Namespace: nn.audio
public static class AudioDevice // TypeDefIndex: 14777
{
	// Fields
	public const float OutputVolumeMax = 128;
	public const float OutputVolumeMin = 0;

	// Methods

	// RVA: 0x26100E0 Offset: 0x26101E1 VA: 0x26100E0
	public static extern bool SetOutputVolume(AudioDevice.AudioDeviceName deviceName, float volume) { }

	// RVA: 0x2610100 Offset: 0x2610201 VA: 0x2610100
	public static extern AudioDevice.AudioDeviceName InitNotificationForOutput() { }

	// RVA: 0x2610110 Offset: 0x2610211 VA: 0x2610110
	public static extern AudioDevice.AudioDeviceName TickNotificationForOutput() { }
}

