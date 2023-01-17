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

