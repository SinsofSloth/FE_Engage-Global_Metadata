// Namespace: UTJ
public static class SpringBoneSerialization // TypeDefIndex: 6378
{
	// Methods

	// RVA: 0x310F500 Offset: 0x310F601 VA: 0x310F500
	public static string BuildDynamicsSetupString(GameObject rootObject, SpringBoneSerialization.ExportSettings exportSettings) { }

	// RVA: 0x310F770 Offset: 0x310F871 VA: 0x310F770
	private static SpringBoneSerialization.AngleLimitSerializer AngleLimitsToSerializer(AngleLimits sourceLimits) { }

	// RVA: 0x310F7F0 Offset: 0x310F8F1 VA: 0x310F7F0
	private static SpringBoneSerialization.SpringBoneBaseSerializer SpringBoneToBaseSerializer(SpringBone sourceBone) { }

	// RVA: 0x310FC00 Offset: 0x310FD01 VA: 0x310FC00
	private static SpringBoneSerialization.PivotSerializer PivotToSerializer(Transform sourcePivot) { }

	// RVA: 0x310FD30 Offset: 0x310FE31 VA: 0x310FD30
	private static void AppendSpringBones(CSVBuilder builder, IEnumerable<SpringBone> springBones) { }

	// RVA: 0x3110F60 Offset: 0x3111061 VA: 0x3110F60
	private static void AppendPivots(CSVBuilder builder, IEnumerable<SpringBone> springBones) { }

	// RVA: 0x310F620 Offset: 0x310F721 VA: 0x310F620
	private static string BuildSpringBoneSetupString(GameObject rootObject) { }

	// RVA: 0x31117F0 Offset: 0x31118F1 VA: 0x31117F0
	private static IEnumerable<SpringBoneSerialization.PivotSerializer> SerializePivotRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords) { }

	// RVA: 0x3111B70 Offset: 0x3111C71 VA: 0x3111B70
	private static IEnumerable<SpringBoneSerialization.SpringBoneSerializer> SerializeSpringBoneRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords) { }

	// RVA: 0x31121E0 Offset: 0x31122E1 VA: 0x31121E0
	private static bool VerifyPivotRecords(IEnumerable<SpringBoneSerialization.PivotSerializer> sourceRecords, IEnumerable<string> validParentNames, List<SpringBoneSerialization.PivotSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x3112700 Offset: 0x3112801 VA: 0x3112700
	private static bool VerifySpringBoneRecords(IEnumerable<SpringBoneSerialization.SpringBoneSerializer> sourceRecords, IEnumerable<string> validBoneNames, IEnumerable<string> validPivotNames, IEnumerable<string> validColliderNames, List<SpringBoneSerialization.SpringBoneSerializer> validRecords, out bool hasMissingColliders, List<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x3112E60 Offset: 0x3112F61 VA: 0x3112E60
	private static AngleLimits BuildAngleLimitsFromSerializer(SpringBoneSerialization.AngleLimitSerializer serializer) { }

	// RVA: 0x3112EE0 Offset: 0x3112FE1 VA: 0x3112EE0
	private static Transform FindChildByName(Transform parent, string name) { }

	// RVA: 0x3112F90 Offset: 0x3113091 VA: 0x3112F90
	private static bool BuildPivotFromSerializer(Dictionary<string, Transform> transforms, SpringBoneSerialization.PivotSerializer serializer) { }

	// RVA: 0x31131B0 Offset: 0x31132B1 VA: 0x31131B0
	private static bool BuildSpringBoneFromSerializer(SpringBoneSerialization.SpringBoneSetupMaps setupMaps, SpringBoneSerialization.SpringBoneSerializer serializer) { }
}

