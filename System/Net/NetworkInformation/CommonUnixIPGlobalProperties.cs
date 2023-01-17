// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties // TypeDefIndex: 2653
{
	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x1B49A70 Offset: 0x1B49B71 VA: 0x1B49A70
	private static extern int getdomainname(byte[] name, int len) { }

	// RVA: 0x1B49B10 Offset: 0x1B49C11 VA: 0x1B49B10 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x1B49CF0 Offset: 0x1B49DF1 VA: 0x1B49CF0
	protected void .ctor() { }
}

