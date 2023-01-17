// Namespace: UTJ
public class DynamicsSetup // TypeDefIndex: 6361
{
	// Fields
	private const int UnknownVersion = -1;
	private DynamicsSetup.ImportSettings importSettings; // 0x10
	private GameObject springBoneRoot; // 0x18
	private GameObject colliderRoot; // 0x20
	private SpringBoneSerialization.ParsedSpringBoneSetup springBoneSetup; // 0x28
	private SpringColliderSerialization.ParsedColliderSetup colliderSetup; // 0x30

	// Methods

	// RVA: 0x3108180 Offset: 0x3108281 VA: 0x3108180
	public static bool BuildFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, DynamicsSetup.ImportSettings importSettings, IEnumerable<string> requiredBones) { }

	// RVA: 0x3108200 Offset: 0x3108301 VA: 0x3108200
	public static DynamicsSetup.ParseResults ParseFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, DynamicsSetup.ImportSettings importSettings) { }

	// RVA: 0x3108370 Offset: 0x3108471 VA: 0x3108370
	public void Build(IEnumerable<string> requiredBones) { }

	// RVA: 0x31086F0 Offset: 0x31087F1 VA: 0x31086F0
	public static int GetVersionFromSetupRecords(List<TextRecordParsing.Record> sourceRecords, out TextRecordParsing.Record versionRecord) { }

	// RVA: 0x3108870 Offset: 0x3108971 VA: 0x3108870
	public static object SerializeObjectFromStrings(Type type, IEnumerable<string> sourceItems, string firstOptionalField, ref DynamicsSetup.ParseMessage error) { }

	// RVA: -1 Offset: -1
	public static T SerializeObjectFromStrings<T>(IEnumerable<string> sourceItems, string firstOptionalField, ref DynamicsSetup.ParseMessage error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A1CE0 Offset: 0x22A1DE1 VA: 0x22A1CE0
	|-DynamicsSetup.SerializeObjectFromStrings<object>
	|-DynamicsSetup.SerializeObjectFromStrings<SpringBoneSerialization.PivotSerializer>
	|-DynamicsSetup.SerializeObjectFromStrings<SpringColliderSerialization.ColliderSerializerBaseInfo>
	|-DynamicsSetup.SerializeObjectFromStrings<SpringColliderSerialization.TransformSerializer>
	*/

	// RVA: 0x3108A80 Offset: 0x3108B81 VA: 0x3108A80
	private static int GetVersionFromSetupRecords(List<TextRecordParsing.Record> sourceRecords) { }

	// RVA: 0x3108AB0 Offset: 0x3108BB1 VA: 0x3108AB0
	private static bool VerifyVersionAndDetectContents(string recordText, DynamicsSetup.ImportSettings importSettings, out string errorMessage) { }

	// RVA: 0x31083E0 Offset: 0x31084E1 VA: 0x31083E0
	private static DynamicsSetup.ParseResults InternalParseFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, DynamicsSetup.ImportSettings importSettings) { }

	// RVA: 0x3108CC0 Offset: 0x3108DC1 VA: 0x3108CC0
	public void .ctor() { }
}

