// Namespace: Mono.Net.Security
internal static class MonoTlsProviderFactory // TypeDefIndex: 2200
{
	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MonoTlsProvider defaultProvider; // 0x10
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
	private static Dictionary<Guid, MonoTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48
	internal static readonly Guid LegacyId; // 0x58

	// Methods

	// RVA: 0x1AC9EB0 Offset: 0x1AC9FB1 VA: 0x1AC9EB0
	internal static MonoTlsProvider GetProviderInternal() { }

	// RVA: 0x1AC9FF0 Offset: 0x1ACA0F1 VA: 0x1AC9FF0
	internal static void InitializeInternal() { }

	// RVA: 0x1ACA940 Offset: 0x1ACAA41 VA: 0x1ACA940
	private static MonoTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x1ACA3E0 Offset: 0x1ACA4E1 VA: 0x1ACA3E0
	private static void InitializeProviderRegistration() { }

	// RVA: 0x1ACA880 Offset: 0x1ACA981 VA: 0x1ACA880
	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x1ACAEA0 Offset: 0x1ACAFA1 VA: 0x1ACAEA0
	internal static MonoTlsProvider GetProvider() { }

	// RVA: 0x1ACAF50 Offset: 0x1ACB051 VA: 0x1ACAF50
	private static void .cctor() { }
}

