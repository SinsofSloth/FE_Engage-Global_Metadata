// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x471F20 Offset: 0x472021 VA: 0x471F20
[Serializable]
public enum MethodImplAttributes // TypeDefIndex: 539
{
	// Fields
	public int value__; // 0x0
	public const MethodImplAttributes CodeTypeMask = 3;
	public const MethodImplAttributes IL = 0;
	public const MethodImplAttributes Native = 1;
	public const MethodImplAttributes OPTIL = 2;
	public const MethodImplAttributes Runtime = 3;
	public const MethodImplAttributes ManagedMask = 4;
	public const MethodImplAttributes Unmanaged = 4;
	public const MethodImplAttributes Managed = 0;
	public const MethodImplAttributes ForwardRef = 16;
	public const MethodImplAttributes PreserveSig = 128;
	public const MethodImplAttributes InternalCall = 4096;
	public const MethodImplAttributes Synchronized = 32;
	public const MethodImplAttributes NoInlining = 8;
	[ComVisibleAttribute] // RVA: 0x478430 Offset: 0x478531 VA: 0x478430
	public const MethodImplAttributes AggressiveInlining = 256;
	public const MethodImplAttributes NoOptimization = 64;
	public const MethodImplAttributes MaxMethodImplVal = 65535;
}

