// Namespace: System.Resources
[ComVisibleAttribute] // RVA: 0x471590 Offset: 0x471691 VA: 0x471590
[Serializable]
public class ResourceManager // TypeDefIndex: 492
{
	// Fields
	[ObsoleteAttribute] // RVA: 0x478320 Offset: 0x478421 VA: 0x478320
	protected Hashtable ResourceSets; // 0x10
	private Dictionary<string, ResourceSet> _resourceSets; // 0x18
	protected Assembly MainAssembly; // 0x20
	private CultureInfo _neutralResourcesCulture; // 0x28
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; // 0x30
	private bool UseManifest; // 0x38
	[OptionalFieldAttribute] // RVA: 0x478360 Offset: 0x478461 VA: 0x478360
	private bool UseSatelliteAssem; // 0x39
	[OptionalFieldAttribute] // RVA: 0x4783A0 Offset: 0x4784A1 VA: 0x4783A0
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x3C
	[OptionalFieldAttribute] // RVA: 0x4783B0 Offset: 0x4784B1 VA: 0x4783B0
	private Assembly _callingAssembly; // 0x40
	[OptionalFieldAttribute] // RVA: 0x4783F0 Offset: 0x4784F1 VA: 0x4783F0
	private RuntimeAssembly m_callingAssembly; // 0x48
	private IResourceGroveler resourceGroveler; // 0x50
	public static readonly int MagicNumber; // 0x0
	public static readonly int HeaderVersionNumber; // 0x4
	private static readonly Type _minResourceSet; // 0x8
	internal static readonly string ResReaderTypeName; // 0x10
	internal static readonly string ResSetTypeName; // 0x18
	internal static readonly string MscorlibName; // 0x20
	internal static readonly int DEBUG; // 0x28

	// Methods

	// RVA: 0x3222780 Offset: 0x3222881 VA: 0x3222780
	private void Init() { }

	// RVA: 0x3222820 Offset: 0x3222921 VA: 0x3222820
	protected void .ctor() { }

	[OnDeserializingAttribute] // RVA: 0x47BC20 Offset: 0x47BD21 VA: 0x47BC20
	// RVA: 0x3222910 Offset: 0x3222A11 VA: 0x3222910
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x47BC30 Offset: 0x47BD31 VA: 0x47BC30
	// RVA: 0x3222960 Offset: 0x3222A61 VA: 0x3222960
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x47BC40 Offset: 0x47BD41 VA: 0x47BC40
	// RVA: 0x3222B80 Offset: 0x3222C81 VA: 0x3222B80
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x3222C10 Offset: 0x3222D11 VA: 0x3222C10
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x3222E80 Offset: 0x3222F81 VA: 0x3222E80
	private static void .cctor() { }
}

