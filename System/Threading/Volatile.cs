// Namespace: System.Threading
public static class Volatile // TypeDefIndex: 814
{
	// Methods

	[ReliabilityContractAttribute] // RVA: 0x47CCD0 Offset: 0x47CDD1 VA: 0x47CCD0
	// RVA: 0x34CEEE0 Offset: 0x34CEFE1 VA: 0x34CEEE0
	public static bool Read(ref bool location) { }

	[ReliabilityContractAttribute] // RVA: 0x47CCF0 Offset: 0x47CDF1 VA: 0x47CCF0
	// RVA: 0x34CEF10 Offset: 0x34CF011 VA: 0x34CEF10
	public static int Read(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x47CD10 Offset: 0x47CE11 VA: 0x47CD10
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386DB40 Offset: 0x386DC41 VA: 0x386DB40
	|-Volatile.Read<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0x47CD30 Offset: 0x47CE31 VA: 0x47CD30
	// RVA: 0x34CEF40 Offset: 0x34CF041 VA: 0x34CEF40
	public static void Write(ref int location, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x47CD50 Offset: 0x47CE51 VA: 0x47CD50
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386DB70 Offset: 0x386DC71 VA: 0x386DB70
	|-Volatile.Write<object>
	*/
}

