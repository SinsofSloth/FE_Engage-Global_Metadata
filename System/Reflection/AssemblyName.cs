// Namespace: System.Reflection
[ClassInterfaceAttribute] // RVA: 0x472290 Offset: 0x472391 VA: 0x472290
[ComVisibleAttribute] // RVA: 0x472290 Offset: 0x472391 VA: 0x472290
[ComDefaultInterfaceAttribute] // RVA: 0x472290 Offset: 0x472391 VA: 0x472290
[Serializable]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 556
{
	// Fields
	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

	// Properties
	public string Name { get; }
	public CultureInfo CultureInfo { get; }
	public AssemblyNameFlags Flags { get; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }

	// Methods

	// RVA: 0x35671F0 Offset: 0x35672F1 VA: 0x35671F0
	public void .ctor() { }

	// RVA: 0x3567220 Offset: 0x3567321 VA: 0x3567220
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x3567230 Offset: 0x3567331 VA: 0x3567230
	public void .ctor(string assemblyName) { }

	// RVA: 0x35678E0 Offset: 0x35679E1 VA: 0x35678E0
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x3567E10 Offset: 0x3567F11 VA: 0x3567E10
	public string get_Name() { }

	// RVA: 0x3567E20 Offset: 0x3567F21 VA: 0x3567E20
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x3567E30 Offset: 0x3567F31 VA: 0x3567E30
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0x3567E40 Offset: 0x3567F41 VA: 0x3567E40
	public string get_FullName() { }

	// RVA: 0x3568400 Offset: 0x3568501 VA: 0x3568400
	public Version get_Version() { }

	// RVA: 0x3568410 Offset: 0x3568511 VA: 0x3568410
	public void set_Version(Version value) { }

	// RVA: 0x35684D0 Offset: 0x35685D1 VA: 0x35684D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3568510 Offset: 0x3568611 VA: 0x3568510
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x3568770 Offset: 0x3568871 VA: 0x3568770
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x35681D0 Offset: 0x35682D1 VA: 0x35681D0
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0x3568910 Offset: 0x3568A11 VA: 0x3568910
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x3568860 Offset: 0x3568961 VA: 0x3568860
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x3568920 Offset: 0x3568A21 VA: 0x3568920 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3568C50 Offset: 0x3568D51 VA: 0x3568C50 Slot: 4
	public object Clone() { }

	// RVA: 0x3568D70 Offset: 0x3568E71 VA: 0x3568D70 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x3568E40 Offset: 0x3568F41 VA: 0x3568E40
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x3567470 Offset: 0x3567571 VA: 0x3567470
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x3568E50 Offset: 0x3568F51 VA: 0x3568E50
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }
}

