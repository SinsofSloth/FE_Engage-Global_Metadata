// Namespace: System.Threading
public static class Interlocked // TypeDefIndex: 802
{
	// Methods

	[ReliabilityContractAttribute] // RVA: 0x47CA70 Offset: 0x47CB71 VA: 0x47CA70
	// RVA: 0x3411750 Offset: 0x3411851 VA: 0x3411750
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x47CA90 Offset: 0x47CB91 VA: 0x47CA90
	// RVA: 0x3411760 Offset: 0x3411861 VA: 0x3411760
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContractAttribute] // RVA: 0x47CAB0 Offset: 0x47CBB1 VA: 0x47CAB0
	// RVA: 0x3411770 Offset: 0x3411871 VA: 0x3411770
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x3411780 Offset: 0x3411881 VA: 0x3411780
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x47CAD0 Offset: 0x47CBD1 VA: 0x47CAD0
	// RVA: 0x3411790 Offset: 0x3411891 VA: 0x3411790
	public static int Decrement(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x47CAF0 Offset: 0x47CBF1 VA: 0x47CAF0
	// RVA: 0x34117A0 Offset: 0x34118A1 VA: 0x34117A0
	public static int Increment(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x47CB10 Offset: 0x47CC11 VA: 0x47CB10
	// RVA: 0x34117B0 Offset: 0x34118B1 VA: 0x34117B0
	public static long Increment(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x47CB30 Offset: 0x47CC31 VA: 0x47CB30
	// RVA: 0x34117C0 Offset: 0x34118C1 VA: 0x34117C0
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x47CB50 Offset: 0x47CC51 VA: 0x47CB50
	// RVA: 0x34117D0 Offset: 0x34118D1 VA: 0x34117D0
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x34117E0 Offset: 0x34118E1 VA: 0x34117E0
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x34117F0 Offset: 0x34118F1 VA: 0x34117F0
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x47CB70 Offset: 0x47CC71 VA: 0x47CB70
	// RVA: 0x3411800 Offset: 0x3411901 VA: 0x3411800
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x3411810 Offset: 0x3411911 VA: 0x3411810
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x47CB90 Offset: 0x47CC91 VA: 0x47CB90
	[ComVisibleAttribute] // RVA: 0x47CB90 Offset: 0x47CC91 VA: 0x47CB90
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x3411820 Offset: 0x3411921 VA: 0x3411820
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContractAttribute] // RVA: 0x47CBE0 Offset: 0x47CCE1 VA: 0x47CBE0
	// RVA: 0x3411830 Offset: 0x3411931 VA: 0x3411830
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x3411840 Offset: 0x3411941 VA: 0x3411840
	public static double Exchange(ref double location1, double value) { }

	[ComVisibleAttribute] // RVA: 0x47CC00 Offset: 0x47CD01 VA: 0x47CC00
	[ReliabilityContractAttribute] // RVA: 0x47CC00 Offset: 0x47CD01 VA: 0x47CC00
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x3411850 Offset: 0x3411951 VA: 0x3411850
	public static long Read(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x47CC50 Offset: 0x47CD51 VA: 0x47CC50
	// RVA: 0x3411860 Offset: 0x3411961 VA: 0x3411860
	public static int Add(ref int location1, int value) { }
}

