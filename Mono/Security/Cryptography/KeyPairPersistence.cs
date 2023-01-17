// Namespace: Mono.Security.Cryptography
internal class KeyPairPersistence // TypeDefIndex: 61
{
	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x3419370 Offset: 0x3419471 VA: 0x3419370
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x3419380 Offset: 0x3419481 VA: 0x3419380
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x3419540 Offset: 0x3419641 VA: 0x3419540
	public string get_Filename() { }

	// RVA: 0x341A790 Offset: 0x341A891 VA: 0x341A790
	public string get_KeyValue() { }

	// RVA: 0x341A7A0 Offset: 0x341A8A1 VA: 0x341A7A0
	public void set_KeyValue(string value) { }

	// RVA: 0x341A7D0 Offset: 0x341A8D1 VA: 0x341A7D0
	public bool Load() { }

	// RVA: 0x341AA60 Offset: 0x341AB61 VA: 0x341AA60
	public void Save() { }

	// RVA: 0x341B0A0 Offset: 0x341B1A1 VA: 0x341B0A0
	public void Remove() { }

	// RVA: 0x341A010 Offset: 0x341A111 VA: 0x341A010
	private static string get_UserPath() { }

	// RVA: 0x3419890 Offset: 0x3419991 VA: 0x3419890
	private static string get_MachinePath() { }

	// RVA: 0x341B230 Offset: 0x341B331 VA: 0x341B230
	internal static bool _CanSecure(string root) { }

	// RVA: 0x341B240 Offset: 0x341B341 VA: 0x341B240
	internal static bool _ProtectUser(string path) { }

	// RVA: 0x341B250 Offset: 0x341B351 VA: 0x341B250
	internal static bool _ProtectMachine(string path) { }

	// RVA: 0x341B260 Offset: 0x341B361 VA: 0x341B260
	internal static bool _IsUserProtected(string path) { }

	// RVA: 0x341B270 Offset: 0x341B371 VA: 0x341B270
	internal static bool _IsMachineProtected(string path) { }

	// RVA: 0x341B280 Offset: 0x341B381 VA: 0x341B280
	private static bool CanSecure(string path) { }

	// RVA: 0x341AFF0 Offset: 0x341B0F1 VA: 0x341AFF0
	private static bool ProtectUser(string path) { }

	// RVA: 0x341AF40 Offset: 0x341B041 VA: 0x341AF40
	private static bool ProtectMachine(string path) { }

	// RVA: 0x341B0D0 Offset: 0x341B1D1 VA: 0x341B0D0
	private static bool IsUserProtected(string path) { }

	// RVA: 0x341B180 Offset: 0x341B281 VA: 0x341B180
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x341A7C0 Offset: 0x341A8C1 VA: 0x341A7C0
	private bool get_CanChange() { }

	// RVA: 0x341B360 Offset: 0x341B461 VA: 0x341B360
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x3419880 Offset: 0x3419981 VA: 0x3419880
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x3419710 Offset: 0x3419811 VA: 0x3419710
	private string get_ContainerName() { }

	// RVA: 0x34194A0 Offset: 0x34195A1 VA: 0x34194A0
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x341A930 Offset: 0x341AA31 VA: 0x341A930
	private void FromXml(string xml) { }

	// RVA: 0x341AD30 Offset: 0x341AE31 VA: 0x341AD30
	private string ToXml() { }

	// RVA: 0x341B3D0 Offset: 0x341B4D1 VA: 0x341B3D0
	private static void .cctor() { }
}

