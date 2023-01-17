// Namespace: 
public class DynamicsSetup.ParseResults // TypeDefIndex: 6359
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5B6E0 Offset: 0x5B7E1 VA: 0x5B6E0
	private DynamicsSetup <Setup>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x5B6F0 Offset: 0x5B7F1 VA: 0x5B6F0
	private List<DynamicsSetup.ParseMessage> <Errors>k__BackingField; // 0x18

	// Properties
	public DynamicsSetup Setup { get; set; }
	public List<DynamicsSetup.ParseMessage> Errors { get; set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x3A79CF0 Offset: 0x3A79DF1 VA: 0x3A79CF0
	public void .ctor() { }

	// RVA: 0x3A79D90 Offset: 0x3A79E91 VA: 0x3A79D90
	public void .ctor(DynamicsSetup setup, IEnumerable<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x3A79E20 Offset: 0x3A79F21 VA: 0x3A79E20
	public static DynamicsSetup.ParseResults Failure(string error) { }

	// RVA: 0x3A79FD0 Offset: 0x3A7A0D1 VA: 0x3A79FD0
	public static DynamicsSetup.ParseResults Failure(IEnumerable<DynamicsSetup.ParseMessage> errors) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1A0 Offset: 0x5C2A1 VA: 0x5C1A0
	// RVA: 0x3A7A090 Offset: 0x3A7A191 VA: 0x3A7A090
	public DynamicsSetup get_Setup() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1B0 Offset: 0x5C2B1 VA: 0x5C1B0
	// RVA: 0x3A7A0A0 Offset: 0x3A7A1A1 VA: 0x3A7A0A0
	private void set_Setup(DynamicsSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1C0 Offset: 0x5C2C1 VA: 0x5C1C0
	// RVA: 0x3A7A0B0 Offset: 0x3A7A1B1 VA: 0x3A7A0B0
	public List<DynamicsSetup.ParseMessage> get_Errors() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1D0 Offset: 0x5C2D1 VA: 0x5C1D0
	// RVA: 0x3A7A0C0 Offset: 0x3A7A1C1 VA: 0x3A7A0C0
	private void set_Errors(List<DynamicsSetup.ParseMessage> value) { }

	// RVA: 0x3A7A0D0 Offset: 0x3A7A1D1 VA: 0x3A7A0D0
	public bool get_HasErrors() { }

	// RVA: 0x3A7A120 Offset: 0x3A7A221 VA: 0x3A7A120
	public void LogErrors() { }
}

