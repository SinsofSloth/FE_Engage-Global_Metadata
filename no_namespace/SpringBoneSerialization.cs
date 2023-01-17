// Namespace: 
public class SpringBoneSerialization.ExportSettings // TypeDefIndex: 6362
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5B700 Offset: 0x5B801 VA: 0x5B700
	private bool <ExportSpringBones>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x5B710 Offset: 0x5B811 VA: 0x5B710
	private bool <ExportCollision>k__BackingField; // 0x11

	// Properties
	public bool ExportSpringBones { get; set; }
	public bool ExportCollision { get; set; }

	// Methods

	// RVA: 0x3A7B180 Offset: 0x3A7B281 VA: 0x3A7B180
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1E0 Offset: 0x5C2E1 VA: 0x5C1E0
	// RVA: 0x3A7B1B0 Offset: 0x3A7B2B1 VA: 0x3A7B1B0
	public bool get_ExportSpringBones() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1F0 Offset: 0x5C2F1 VA: 0x5C1F0
	// RVA: 0x3A7B1C0 Offset: 0x3A7B2C1 VA: 0x3A7B1C0
	public void set_ExportSpringBones(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C200 Offset: 0x5C301 VA: 0x5C200
	// RVA: 0x3A7B1D0 Offset: 0x3A7B2D1 VA: 0x3A7B1D0
	public bool get_ExportCollision() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C210 Offset: 0x5C311 VA: 0x5C210
	// RVA: 0x3A7B1E0 Offset: 0x3A7B2E1 VA: 0x3A7B1E0
	public void set_ExportCollision(bool value) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B260 Offset: 0x5B361 VA: 0x5B260
private sealed class SpringBoneSerialization.ParsedSpringBoneSetup.<>c__DisplayClass4_0 // TypeDefIndex: 6363
{
	// Fields
	public GameObject colliderRoot; // 0x10

	// Methods

	// RVA: 0x3A7BC40 Offset: 0x3A7BD41 VA: 0x3A7BC40
	public void .ctor() { }

	// RVA: 0x3A7FA00 Offset: 0x3A7FB01 VA: 0x3A7FA00
	internal IEnumerable<Component> <ReadSpringBoneSetupFromText>b__2(Type type) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B270 Offset: 0x5B371 VA: 0x5B270
private sealed class SpringBoneSerialization.ParsedSpringBoneSetup.<>c__DisplayClass4_1 // TypeDefIndex: 6364
{
	// Fields
	public TextRecordParsing.Record versionRecord; // 0x10

	// Methods

	// RVA: 0x3A7BC50 Offset: 0x3A7BD51 VA: 0x3A7BC50
	public void .ctor() { }

	// RVA: 0x3A7FA10 Offset: 0x3A7FB11 VA: 0x3A7FA10
	internal bool <ReadSpringBoneSetupFromText>b__4(TextRecordParsing.Record item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B280 Offset: 0x5B381 VA: 0x5B280
[Serializable]
private sealed class SpringBoneSerialization.ParsedSpringBoneSetup.<>c // TypeDefIndex: 6365
{
	// Fields
	public static readonly SpringBoneSerialization.ParsedSpringBoneSetup.<>c <>9; // 0x0
	public static Func<Transform, string> <>9__4_0; // 0x8
	public static Func<SpringBoneSerialization.PivotSerializer, string> <>9__4_1; // 0x10
	public static Func<Component, string> <>9__4_3; // 0x18
	public static Func<SpringBoneSerialization.SpringBoneSerializer, string> <>9__8_1; // 0x20
	public static Func<Transform, bool> <>9__8_3; // 0x28
	public static Func<Transform, GameObject> <>9__8_4; // 0x30

	// Methods

	// RVA: 0x3A7F8C0 Offset: 0x3A7F9C1 VA: 0x3A7F8C0
	private static void .cctor() { }

	// RVA: 0x3A7F930 Offset: 0x3A7FA31 VA: 0x3A7F930
	public void .ctor() { }

	// RVA: 0x3A7F940 Offset: 0x3A7FA41 VA: 0x3A7F940
	internal string <ReadSpringBoneSetupFromText>b__4_0(Transform item) { }

	// RVA: 0x3A7F950 Offset: 0x3A7FA51 VA: 0x3A7F950
	internal string <ReadSpringBoneSetupFromText>b__4_1(SpringBoneSerialization.PivotSerializer record) { }

	// RVA: 0x3A7F960 Offset: 0x3A7FA61 VA: 0x3A7F960
	internal string <ReadSpringBoneSetupFromText>b__4_3(Component item) { }

	// RVA: 0x3A7F970 Offset: 0x3A7FA71 VA: 0x3A7F970
	internal string <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__8_1(SpringBoneSerialization.SpringBoneSerializer record) { }

	// RVA: 0x3A7F980 Offset: 0x3A7FA81 VA: 0x3A7F980
	internal bool <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__8_3(Transform item) { }

	// RVA: 0x3A7F9F0 Offset: 0x3A7FAF1 VA: 0x3A7F9F0
	internal GameObject <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__8_4(Transform item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B290 Offset: 0x5B391 VA: 0x5B290
private sealed class SpringBoneSerialization.ParsedSpringBoneSetup.<>c__DisplayClass8_0 // TypeDefIndex: 6366
{
	// Fields
	public IEnumerable<string> requiredBones; // 0x10
	public GameObject springBoneRoot; // 0x18

	// Methods

	// RVA: 0x3A7CE60 Offset: 0x3A7CF61 VA: 0x3A7CE60
	public void .ctor() { }

	// RVA: 0x3A7FA20 Offset: 0x3A7FB21 VA: 0x3A7FA20
	internal bool <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__0(SpringBoneSerialization.SpringBoneSerializer record) { }

	// RVA: 0x3A7FA80 Offset: 0x3A7FB81 VA: 0x3A7FA80
	internal Transform <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__2(string boneName) { }
}

// Namespace: 
public class SpringBoneSerialization.ParsedSpringBoneSetup // TypeDefIndex: 6367
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5B720 Offset: 0x5B821 VA: 0x5B720
	private IEnumerable<DynamicsSetup.ParseMessage> <Errors>k__BackingField; // 0x10
	private IEnumerable<SpringBoneSerialization.PivotSerializer> pivotRecords; // 0x18
	private IEnumerable<SpringBoneSerialization.SpringBoneSerializer> springBoneRecords; // 0x20

	// Properties
	public IEnumerable<DynamicsSetup.ParseMessage> Errors { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x5C220 Offset: 0x5C321 VA: 0x5C220
	// RVA: 0x3A7B1F0 Offset: 0x3A7B2F1 VA: 0x3A7B1F0
	public IEnumerable<DynamicsSetup.ParseMessage> get_Errors() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C230 Offset: 0x5C331 VA: 0x5C230
	// RVA: 0x3A7B200 Offset: 0x3A7B301 VA: 0x3A7B200
	public void set_Errors(IEnumerable<DynamicsSetup.ParseMessage> value) { }

	// RVA: 0x3A7B210 Offset: 0x3A7B311 VA: 0x3A7B210
	public static SpringBoneSerialization.ParsedSpringBoneSetup ReadSpringBoneSetupFromText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, IEnumerable<string> inputValidColliderNames) { }

	// RVA: 0x3A7BC70 Offset: 0x3A7BD71 VA: 0x3A7BC70
	public void BuildObjects(GameObject springBoneRoot, GameObject colliderRoot, IEnumerable<string> requiredBones) { }

	// RVA: 0x3A7C320 Offset: 0x3A7C421 VA: 0x3A7C320
	private void FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones(GameObject springBoneRoot, IEnumerable<string> requiredBones) { }

	// RVA: 0x3A7BC60 Offset: 0x3A7BD61 VA: 0x3A7BC60
	public void .ctor() { }
}

// Namespace: 
private class SpringBoneSerialization.PersistentSpringManagerProperties // TypeDefIndex: 6368
{
	// Fields
	private bool automaticUpdates; // 0x10
	private int simulationFrameRate; // 0x14
	private float dynamicRatio; // 0x18
	private Vector3 gravity; // 0x1C
	private bool collideWithGround; // 0x28
	private float groundHeight; // 0x2C
	private float bounce; // 0x30
	private float friction; // 0x34

	// Methods

	// RVA: 0x3A7C230 Offset: 0x3A7C331 VA: 0x3A7C230
	public static SpringBoneSerialization.PersistentSpringManagerProperties Create(SpringManager sourceManager) { }

	// RVA: 0x3A7CE10 Offset: 0x3A7CF11 VA: 0x3A7CE10
	public void ApplyTo(SpringManager targetManager) { }

	// RVA: 0x3A7CE70 Offset: 0x3A7CF71 VA: 0x3A7CE70
	public void .ctor() { }
}

// Namespace: 
private class SpringBoneSerialization.SpringBoneSetupMaps // TypeDefIndex: 6369
{
	// Fields
	public Dictionary<string, Transform> allChildren; // 0x10
	public Dictionary<string, SpringSphereCollider> sphereColliders; // 0x18
	public Dictionary<string, SpringCapsuleCollider> capsuleColliders; // 0x20
	public Dictionary<string, SpringPanelCollider> panelColliders; // 0x28

	// Methods

	// RVA: 0x3A7CCC0 Offset: 0x3A7CDC1 VA: 0x3A7CCC0
	public static SpringBoneSerialization.SpringBoneSetupMaps Build(GameObject springBoneRoot, GameObject colliderRoot) { }

	// RVA: 0x3A7CEB0 Offset: 0x3A7CFB1 VA: 0x3A7CEB0
	public void .ctor() { }
}

// Namespace: 
private class SpringBoneSerialization.PivotSerializer // TypeDefIndex: 6370
{
	// Fields
	public string name; // 0x10
	public string parentName; // 0x18
	public Vector3 eulerAngles; // 0x20

	// Methods

	// RVA: 0x3A7CE80 Offset: 0x3A7CF81 VA: 0x3A7CE80
	public void .ctor() { }
}

// Namespace: 
private class SpringBoneSerialization.AngleLimitSerializer // TypeDefIndex: 6371
{
	// Fields
	public bool enabled; // 0x10
	public float min; // 0x14
	public float max; // 0x18

	// Methods

	// RVA: 0x3A7B170 Offset: 0x3A7B271 VA: 0x3A7B170
	public void .ctor() { }
}

// Namespace: 
private class SpringBoneSerialization.LengthLimitSerializer // TypeDefIndex: 6372
{
	// Fields
	public string objectName; // 0x10
	public float ratio; // 0x18

	// Methods

	// RVA: 0x3A7AB10 Offset: 0x3A7AC11 VA: 0x3A7AB10
	public void .ctor() { }
}

// Namespace: 
private class SpringBoneSerialization.SpringBoneBaseSerializer // TypeDefIndex: 6373
{
	// Fields
	public string boneName; // 0x10
	public float radius; // 0x18
	public float stiffness; // 0x1C
	public float drag; // 0x20
	public Vector3 springForce; // 0x24
	public float windInfluence; // 0x30
	public string pivotName; // 0x38
	public SpringBoneSerialization.AngleLimitSerializer yAngleLimits; // 0x40
	public SpringBoneSerialization.AngleLimitSerializer zAngleLimits; // 0x48
	public float angularStiffness; // 0x50
	public SpringBoneSerialization.LengthLimitSerializer[] lengthLimits; // 0x58

	// Methods

	// RVA: 0x3A7CE90 Offset: 0x3A7CF91 VA: 0x3A7CE90
	public void .ctor() { }
}

// Namespace: 
private class SpringBoneSerialization.SpringBoneSerializer // TypeDefIndex: 6374
{
	// Fields
	public SpringBoneSerialization.SpringBoneBaseSerializer baseData; // 0x10
	public string[] colliderNames; // 0x18

	// Methods

	// RVA: 0x3A7CEA0 Offset: 0x3A7CFA1 VA: 0x3A7CEA0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B2A0 Offset: 0x5B3A1 VA: 0x5B2A0
[Serializable]
private sealed class SpringBoneSerialization.<>c // TypeDefIndex: 6375
{
	// Fields
	public static readonly SpringBoneSerialization.<>c <>9; // 0x0
	public static Func<Transform, bool> <>9__3_0; // 0x8
	public static Func<Transform, SpringBoneSerialization.LengthLimitSerializer> <>9__3_1; // 0x10
	public static Func<SpringSphereCollider, bool> <>9__5_0; // 0x18
	public static Func<SpringSphereCollider, string> <>9__5_1; // 0x20
	public static Func<SpringCapsuleCollider, bool> <>9__5_2; // 0x28
	public static Func<SpringCapsuleCollider, string> <>9__5_3; // 0x30
	public static Func<SpringPanelCollider, bool> <>9__5_4; // 0x38
	public static Func<SpringPanelCollider, string> <>9__5_5; // 0x40
	public static Func<SpringBone, bool> <>9__6_0; // 0x48
	public static Func<SpringBone, Transform> <>9__6_1; // 0x50
	public static Func<Transform, SpringBoneSerialization.PivotSerializer> <>9__6_2; // 0x58
	public static Func<string, bool> <>9__17_0; // 0x60

	// Methods

	// RVA: 0x3A7A990 Offset: 0x3A7AA91 VA: 0x3A7A990
	private static void .cctor() { }

	// RVA: 0x3A7AA00 Offset: 0x3A7AB01 VA: 0x3A7AA00
	public void .ctor() { }

	// RVA: 0x3A7AA10 Offset: 0x3A7AB11 VA: 0x3A7AA10
	internal bool <SpringBoneToBaseSerializer>b__3_0(Transform item) { }

	// RVA: 0x3A7AA80 Offset: 0x3A7AB81 VA: 0x3A7AA80
	internal SpringBoneSerialization.LengthLimitSerializer <SpringBoneToBaseSerializer>b__3_1(Transform item) { }

	// RVA: 0x3A7AB20 Offset: 0x3A7AC21 VA: 0x3A7AB20
	internal bool <AppendSpringBones>b__5_0(SpringSphereCollider item) { }

	// RVA: 0x3A7AB90 Offset: 0x3A7AC91 VA: 0x3A7AB90
	internal string <AppendSpringBones>b__5_1(SpringSphereCollider item) { }

	// RVA: 0x3A7ABA0 Offset: 0x3A7ACA1 VA: 0x3A7ABA0
	internal bool <AppendSpringBones>b__5_2(SpringCapsuleCollider item) { }

	// RVA: 0x3A7AC10 Offset: 0x3A7AD11 VA: 0x3A7AC10
	internal string <AppendSpringBones>b__5_3(SpringCapsuleCollider item) { }

	// RVA: 0x3A7AC20 Offset: 0x3A7AD21 VA: 0x3A7AC20
	internal bool <AppendSpringBones>b__5_4(SpringPanelCollider item) { }

	// RVA: 0x3A7AC90 Offset: 0x3A7AD91 VA: 0x3A7AC90
	internal string <AppendSpringBones>b__5_5(SpringPanelCollider item) { }

	// RVA: 0x3A7ACA0 Offset: 0x3A7ADA1 VA: 0x3A7ACA0
	internal bool <AppendPivots>b__6_0(SpringBone bone) { }

	// RVA: 0x3A7ADB0 Offset: 0x3A7AEB1 VA: 0x3A7ADB0
	internal Transform <AppendPivots>b__6_1(SpringBone bone) { }

	// RVA: 0x3A7ADC0 Offset: 0x3A7AEC1 VA: 0x3A7ADC0
	internal SpringBoneSerialization.PivotSerializer <AppendPivots>b__6_2(Transform pivot) { }

	// RVA: 0x3A7ADD0 Offset: 0x3A7AED1 VA: 0x3A7ADD0
	internal bool <SerializeSpringBoneRecords>b__17_0(string item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B2B0 Offset: 0x5B3B1 VA: 0x5B2B0
private sealed class SpringBoneSerialization.<>c__DisplayClass19_0 // TypeDefIndex: 6376
{
	// Fields
	public IEnumerable<string> validColliderNames; // 0x10
	public Func<string, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x3A7ADE0 Offset: 0x3A7AEE1 VA: 0x3A7ADE0
	public void .ctor() { }

	// RVA: 0x3A7ADF0 Offset: 0x3A7AEF1 VA: 0x3A7ADF0
	internal bool <VerifySpringBoneRecords>b__0(string name) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B2C0 Offset: 0x5B3C1 VA: 0x5B2C0
private sealed class SpringBoneSerialization.<>c__DisplayClass23_0 // TypeDefIndex: 6377
{
	// Fields
	public SpringBoneSerialization.SpringBoneSetupMaps setupMaps; // 0x10

	// Methods

	// RVA: 0x3A7AE60 Offset: 0x3A7AF61 VA: 0x3A7AE60
	public void .ctor() { }

	// RVA: 0x3A7AE70 Offset: 0x3A7AF71 VA: 0x3A7AE70
	internal bool <BuildSpringBoneFromSerializer>b__0(SpringBoneSerialization.LengthLimitSerializer lengthLimit) { }

	// RVA: 0x3A7AED0 Offset: 0x3A7AFD1 VA: 0x3A7AED0
	internal Transform <BuildSpringBoneFromSerializer>b__1(SpringBoneSerialization.LengthLimitSerializer lengthLimit) { }

	// RVA: 0x3A7AF30 Offset: 0x3A7B031 VA: 0x3A7AF30
	internal bool <BuildSpringBoneFromSerializer>b__2(string name) { }

	// RVA: 0x3A7AF90 Offset: 0x3A7B091 VA: 0x3A7AF90
	internal SpringSphereCollider <BuildSpringBoneFromSerializer>b__3(string name) { }

	// RVA: 0x3A7AFF0 Offset: 0x3A7B0F1 VA: 0x3A7AFF0
	internal bool <BuildSpringBoneFromSerializer>b__4(string name) { }

	// RVA: 0x3A7B050 Offset: 0x3A7B151 VA: 0x3A7B050
	internal SpringCapsuleCollider <BuildSpringBoneFromSerializer>b__5(string name) { }

	// RVA: 0x3A7B0B0 Offset: 0x3A7B1B1 VA: 0x3A7B0B0
	internal bool <BuildSpringBoneFromSerializer>b__6(string name) { }

	// RVA: 0x3A7B110 Offset: 0x3A7B211 VA: 0x3A7B110
	internal SpringPanelCollider <BuildSpringBoneFromSerializer>b__7(string name) { }
}

