// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties // TypeDefIndex: 2649
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x31B00 Offset: 0x31C01 VA: 0x31B00
	private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Properties
	private static bool PlatformNeedsLibCWorkaround { get; }
	public abstract string DomainName { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x33930 Offset: 0x33A31 VA: 0x33930
	// RVA: 0x1ABE880 Offset: 0x1ABE981 VA: 0x1ABE880
	private static bool get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0x1ABE8D0 Offset: 0x1ABE9D1 VA: 0x1ABE8D0
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x1ABEB70 Offset: 0x1ABEC71 VA: 0x1ABEB70
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_DomainName();

	// RVA: 0x1ABEB80 Offset: 0x1ABEC81 VA: 0x1ABEB80
	protected void .ctor() { }
}

