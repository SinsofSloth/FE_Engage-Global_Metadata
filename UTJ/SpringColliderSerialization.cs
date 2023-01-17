// Namespace: UTJ
public static class SpringColliderSerialization // TypeDefIndex: 6395
{
	// Fields
	private const string SphereColliderToken = "sp";
	private const string CapsuleColliderToken = "cp";
	private const string PanelColliderToken = "pa";

	// Methods

	// RVA: 0x310F6D0 Offset: 0x310F7D1 VA: 0x310F6D0
	public static string BuildCollisionSetupString(GameObject colliderRoot) { }

	// RVA: 0x31164D0 Offset: 0x31165D1 VA: 0x31164D0
	private static void AppendColliders(CSVBuilder builder, GameObject colliderRoot) { }

	// RVA: 0x3118D20 Offset: 0x3118E21 VA: 0x3118D20
	private static string GetComponentName(Component component) { }

	// RVA: 0x3118DD0 Offset: 0x3118ED1 VA: 0x3118DD0
	private static SpringColliderSerialization.TransformSerializer TransformToSerializer(Transform sourceTransform) { }

	// RVA: 0x3118F40 Offset: 0x3119041 VA: 0x3118F40
	private static SpringColliderSerialization.ColliderSerializerBaseInfo TransformToColliderSerializerBaseInfo(Transform sourceTransform, string colliderType) { }

	// RVA: 0x3118FD0 Offset: 0x31190D1 VA: 0x3118FD0
	private static SpringColliderSerialization.SphereColliderSerializer SphereColliderToSerializer(SpringSphereCollider sourceCollider) { }

	// RVA: 0x3119180 Offset: 0x3119281 VA: 0x3119180
	private static SpringColliderSerialization.CapsuleColliderSerializer CapsuleColliderToSerializer(SpringCapsuleCollider sourceCollider) { }

	// RVA: 0x3119330 Offset: 0x3119431 VA: 0x3119330
	private static SpringColliderSerialization.PanelColliderSerializer PanelColliderToSerializer(SpringPanelCollider sourceCollider) { }

	// RVA: 0x31183D0 Offset: 0x31184D1 VA: 0x31183D0
	private static void AppendDynamicsNulls(CSVBuilder builder, GameObject rootObject) { }

	// RVA: 0x3118870 Offset: 0x3118971 VA: 0x3118870
	private static string BuildComponentDefinitionString(GameObject colliderRoot) { }

	// RVA: -1 Offset: -1
	private static void AppendRecordItem<T>(StringBuilder builder, T item, char separator = '\x2c') { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201E4D0 Offset: 0x201E5D1 VA: 0x201E4D0
	|-SpringColliderSerialization.AppendRecordItem<object>
	|-SpringColliderSerialization.AppendRecordItem<string>
	*/

	// RVA: 0x31194E0 Offset: 0x31195E1 VA: 0x31194E0
	private static Transform CreateNewGameObject(Transform parent, string name) { }

	// RVA: 0x3119630 Offset: 0x3119731 VA: 0x3119630
	private static Transform GetChildByName(Transform parent, string name) { }

	// RVA: -1 Offset: -1
	private static T TryToFindComponent<T>(GameObject gameObject, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201E510 Offset: 0x201E611 VA: 0x201E510
	|-SpringColliderSerialization.TryToFindComponent<object>
	|-SpringColliderSerialization.TryToFindComponent<Renderer>
	*/

	// RVA: 0x3119810 Offset: 0x3119911 VA: 0x3119810
	private static IEnumerable<SpringColliderSerialization.IColliderSerializer> SerializeColliderRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords) { }

	// RVA: 0x3119E40 Offset: 0x3119F41 VA: 0x3119E40
	private static IEnumerable<SpringColliderSerialization.TransformSerializer> SerializeTransformRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords) { }

	// RVA: 0x311A1C0 Offset: 0x311A2C1 VA: 0x311A1C0
	private static bool VerifyTransformRecord(SpringColliderSerialization.TransformSerializer transformSerializer, IEnumerable<string> validParentNames, out DynamicsSetup.ParseMessage error) { }

	// RVA: 0x311A380 Offset: 0x311A481 VA: 0x311A380
	private static bool VerifyTransformRecords(IEnumerable<SpringColliderSerialization.TransformSerializer> sourceRecords, IEnumerable<string> validParentNames, List<SpringColliderSerialization.TransformSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x311A8A0 Offset: 0x311A9A1 VA: 0x311A8A0
	private static bool VerifyColliderRecords(IEnumerable<SpringColliderSerialization.IColliderSerializer> colliderRecords, GameObject rootObject, IEnumerable<string> validParentNames, List<SpringColliderSerialization.IColliderSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x311AFF0 Offset: 0x311B0F1 VA: 0x311AFF0
	private static GameObject BuildTransformFromRecord(Dictionary<string, Transform> objectMap, SpringColliderSerialization.TransformSerializer serializer) { }

	// RVA: 0x311B1B0 Offset: 0x311B2B1 VA: 0x311B1B0
	private static bool BuildColliderFromRecord(Dictionary<string, Transform> objectMap, SpringColliderSerialization.IColliderSerializer colliderSerializer) { }

	// RVA: 0x311B310 Offset: 0x311B411 VA: 0x311B310
	private static void BuildDynamicsNulls(Dictionary<string, Transform> objectMap, IEnumerable<SpringColliderSerialization.TransformSerializer> records) { }

	// RVA: 0x311B820 Offset: 0x311B921 VA: 0x311B820
	private static void BuildComponents(Dictionary<string, Transform> objectMap, IEnumerable<TextRecordParsing.Record> records) { }
}

