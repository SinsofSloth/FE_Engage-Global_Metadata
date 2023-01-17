// Namespace: System.Reflection
[FlagsAttribute] // RVA: 0x471FF0 Offset: 0x4720F1 VA: 0x471FF0
[ComVisibleAttribute] // RVA: 0x471FF0 Offset: 0x4720F1 VA: 0x471FF0
[Serializable]
public enum ParameterAttributes // TypeDefIndex: 542
{
	// Fields
	public int value__; // 0x0
	public const ParameterAttributes None = 0;
	public const ParameterAttributes In = 1;
	public const ParameterAttributes Out = 2;
	public const ParameterAttributes Lcid = 4;
	public const ParameterAttributes Retval = 8;
	public const ParameterAttributes Optional = 16;
	public const ParameterAttributes ReservedMask = 61440;
	public const ParameterAttributes HasDefault = 4096;
	public const ParameterAttributes HasFieldMarshal = 8192;
	public const ParameterAttributes Reserved3 = 16384;
	public const ParameterAttributes Reserved4 = 32768;
}

