// Namespace: nn.nfp
public static class Nfp // TypeDefIndex: 14545
{
	// Fields
	public const int DeviceCountMax = 9;
	public const int UidLengthMax = 10;
	public const int NicknameLengthMax = 10;
	public const int CharacterIdSize = 3;
	public const uint ErrorCodeUnknown = 4294967295;

	// Properties
	public static ErrorRange ResultNfcDeviceNotFound { get; }
	public static ErrorRange ResultNfcDisabled { get; }
	public static ErrorRange ResultNeedRetry { get; }
	public static ErrorRange ResultNeedRestart { get; }
	public static ErrorRange ResultNeedRegister { get; }
	public static ErrorRange ResultNeedCreate { get; }
	public static ErrorRange ResultNeedRestore { get; }
	public static ErrorRange ResultNeedFormat { get; }
	public static ErrorRange ResultAccessIdMisMatch { get; }
	public static ErrorRange ResultNotBroken { get; }
	public static ErrorRange ResultAlreadyCreated { get; }
	public static ErrorRange ResultNotSupported { get; }
	public static ErrorRange ResultInvalidFormatVersion { get; }
	public static ErrorRange ResultMaxNfcDeviceActivated { get; }
	public static ErrorRange ResultConflictFunction { get; }
	public static ErrorRange ResultNotUpdated { get; }

	// Methods

	// RVA: 0x2358DE0 Offset: 0x2358EE1 VA: 0x2358DE0
	public static extern Result AttachActivateEvent(ref uint outEventIndex, DeviceHandle deviceHandle) { }

	// RVA: 0x2358E40 Offset: 0x2358F41 VA: 0x2358E40
	public static extern bool IsActivatedDevice(DeviceHandle deviceHandle) { }

	// RVA: 0x2358E90 Offset: 0x2358F91 VA: 0x2358E90
	public static extern bool IsActivatedDevice(uint eventIndex) { }

	// RVA: 0x2358EB0 Offset: 0x2358FB1 VA: 0x2358EB0
	public static extern void DestroyActivatedEvent(DeviceHandle deviceHandle) { }

	// RVA: 0x2358EF0 Offset: 0x2358FF1 VA: 0x2358EF0
	public static extern void DestroyActivatedEvent(uint eventIndex) { }

	// RVA: 0x2358F00 Offset: 0x2359001 VA: 0x2358F00
	public static extern Result AttachDeactivateEvent(ref uint outEventIndex, DeviceHandle deviceHandle) { }

	// RVA: 0x2358F60 Offset: 0x2359061 VA: 0x2358F60
	public static extern bool IsDeactivatedDevice(DeviceHandle deviceHandle) { }

	// RVA: 0x2358FB0 Offset: 0x23590B1 VA: 0x2358FB0
	public static extern bool IsDeactivatedDevice(uint eventIndex) { }

	// RVA: 0x2358FD0 Offset: 0x23590D1 VA: 0x2358FD0
	public static extern void DestroyDeactivatedEvent(DeviceHandle deviceHandle) { }

	// RVA: 0x2359010 Offset: 0x2359111 VA: 0x2359010
	public static extern void DestroyDeactivatedEvent(uint eventIndex) { }

	// RVA: 0x2359020 Offset: 0x2359121 VA: 0x2359020
	public static extern void AttachAvailabilityChangeEvent() { }

	// RVA: 0x2359030 Offset: 0x2359131 VA: 0x2359030
	public static extern bool IsAvailabilityChanged() { }

	// RVA: 0x2359050 Offset: 0x2359151 VA: 0x2359050
	public static extern void DestroyAvailabilityChangeEvent() { }

	// RVA: 0x2359060 Offset: 0x2359161 VA: 0x2359060
	public static extern void InitializeSystem() { }

	// RVA: 0x2359070 Offset: 0x2359171 VA: 0x2359070
	public static extern void FinalizeSystem() { }

	// RVA: 0x2359080 Offset: 0x2359181 VA: 0x2359080
	public static extern State GetState() { }

	// RVA: 0x2359090 Offset: 0x2359191 VA: 0x2359090
	public static extern DeviceState GetDeviceState(DeviceHandle deviceHandle) { }

	// RVA: 0x23590E0 Offset: 0x23591E1 VA: 0x23590E0
	public static extern Result GetNpadId(ref NpadId outNpadId, DeviceHandle deviceHandle) { }

	// RVA: 0x2359140 Offset: 0x2359241 VA: 0x2359140
	public static ErrorRange get_ResultNfcDeviceNotFound() { }

	// RVA: 0x2359180 Offset: 0x2359281 VA: 0x2359180
	public static ErrorRange get_ResultNfcDisabled() { }

	// RVA: 0x23591C0 Offset: 0x23592C1 VA: 0x23591C0
	public static ErrorRange get_ResultNeedRetry() { }

	// RVA: 0x2359200 Offset: 0x2359301 VA: 0x2359200
	public static ErrorRange get_ResultNeedRestart() { }

	// RVA: 0x2359240 Offset: 0x2359341 VA: 0x2359240
	public static ErrorRange get_ResultNeedRegister() { }

	// RVA: 0x2359280 Offset: 0x2359381 VA: 0x2359280
	public static ErrorRange get_ResultNeedCreate() { }

	// RVA: 0x23592C0 Offset: 0x23593C1 VA: 0x23592C0
	public static ErrorRange get_ResultNeedRestore() { }

	// RVA: 0x2359300 Offset: 0x2359401 VA: 0x2359300
	public static ErrorRange get_ResultNeedFormat() { }

	// RVA: 0x2359340 Offset: 0x2359441 VA: 0x2359340
	public static ErrorRange get_ResultAccessIdMisMatch() { }

	// RVA: 0x2359380 Offset: 0x2359481 VA: 0x2359380
	public static ErrorRange get_ResultNotBroken() { }

	// RVA: 0x23593C0 Offset: 0x23594C1 VA: 0x23593C0
	public static ErrorRange get_ResultAlreadyCreated() { }

	// RVA: 0x2359400 Offset: 0x2359501 VA: 0x2359400
	public static ErrorRange get_ResultNotSupported() { }

	// RVA: 0x2359440 Offset: 0x2359541 VA: 0x2359440
	public static ErrorRange get_ResultInvalidFormatVersion() { }

	// RVA: 0x2359480 Offset: 0x2359581 VA: 0x2359480
	public static ErrorRange get_ResultMaxNfcDeviceActivated() { }

	// RVA: 0x23594C0 Offset: 0x23595C1 VA: 0x23594C0
	public static ErrorRange get_ResultConflictFunction() { }

	// RVA: 0x2359500 Offset: 0x2359601 VA: 0x2359500
	public static ErrorRange get_ResultNotUpdated() { }

	// RVA: 0x2359540 Offset: 0x2359641 VA: 0x2359540
	public static extern Result ListDevices([In] [Out] DeviceHandle[] outBuffer, ref int outCount, int bufferCount) { }

	// RVA: 0x2359680 Offset: 0x2359781 VA: 0x2359680
	public static extern Result StartDetection(DeviceHandle deviceHandle) { }

	// RVA: 0x23596D0 Offset: 0x23597D1 VA: 0x23596D0
	public static extern Result StopDetection(DeviceHandle deviceHandle) { }

	// RVA: 0x2359720 Offset: 0x2359821 VA: 0x2359720
	public static extern Result Mount(DeviceHandle deviceHandle, ModelType modelType) { }

	// RVA: 0x2359780 Offset: 0x2359881 VA: 0x2359780
	public static extern Result Mount(DeviceHandle deviceHandle, ModelType modelType, MountTarget mountTarget) { }

	// RVA: 0x23597E0 Offset: 0x23598E1 VA: 0x23597E0
	public static extern Result Unmount(DeviceHandle deviceHandle) { }

	// RVA: 0x2359830 Offset: 0x2359931 VA: 0x2359830
	public static extern Result Restore(DeviceHandle deviceHandle) { }

	// RVA: 0x2359880 Offset: 0x2359981 VA: 0x2359880
	public static extern Result GetTagInfo(ref TagInfo outTagInfo, DeviceHandle deviceHandle) { }

	// RVA: 0x2359940 Offset: 0x2359A41 VA: 0x2359940
	public static extern Result GetCommonInfo(ref CommonInfo outCommonInfo, DeviceHandle deviceHandle) { }

	// RVA: 0x23599F0 Offset: 0x2359AF1 VA: 0x23599F0
	public static extern Result GetModelInfo(ref ModelInfo outModelInfo, DeviceHandle deviceHandle) { }
}

