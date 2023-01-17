// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x2760C0 Offset: 0x2761C1 VA: 0x2760C0
public class EffectData : StructData<EffectData> // TypeDefIndex: 9881
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x289F50 Offset: 0x28A051 VA: 0x289F50
	private string <Eid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x289F60 Offset: 0x28A061 VA: 0x289F60
	private string <FilePath>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x289F70 Offset: 0x28A071 VA: 0x289F70
	private string <SoundLabel>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x289F80 Offset: 0x28A081 VA: 0x289F80
	private EffectData.Types <Type>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x289F90 Offset: 0x28A091 VA: 0x289F90
	private float <DelayTime>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x289FA0 Offset: 0x28A0A1 VA: 0x289FA0
	private float <WaitTime>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x289FB0 Offset: 0x28A0B1 VA: 0x289FB0
	private float <ShakeTime>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x289FC0 Offset: 0x28A0C1 VA: 0x289FC0
	private float <ShakeMagnitude>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x289FD0 Offset: 0x28A0D1 VA: 0x289FD0
	private EffectData.Residents <Resident>k__BackingField; // 0x4C
	private string[] m_FilePaths; // 0x50
	private static BindHolder s_Binder; // 0x0

	// Properties
	public string Eid { get; set; }
	public string FilePath { get; set; }
	public string SoundLabel { get; set; }
	public EffectData.Types Type { get; set; }
	public float DelayTime { get; set; }
	public float WaitTime { get; set; }
	public float ShakeTime { get; set; }
	public float ShakeMagnitude { get; set; }
	public EffectData.Residents Resident { get; set; }

	// Methods

	// RVA: 0x25F2800 Offset: 0x25F2901 VA: 0x25F2800
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5D30 Offset: 0x2B5E31 VA: 0x2B5D30
	// RVA: 0x25F28B0 Offset: 0x25F29B1 VA: 0x25F28B0
	public string get_Eid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5D40 Offset: 0x2B5E41 VA: 0x2B5D40
	// RVA: 0x25F28C0 Offset: 0x25F29C1 VA: 0x25F28C0
	private void set_Eid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5D50 Offset: 0x2B5E51 VA: 0x2B5D50
	// RVA: 0x25F28D0 Offset: 0x25F29D1 VA: 0x25F28D0
	public string get_FilePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5D60 Offset: 0x2B5E61 VA: 0x2B5D60
	// RVA: 0x25F28E0 Offset: 0x25F29E1 VA: 0x25F28E0
	private void set_FilePath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5D70 Offset: 0x2B5E71 VA: 0x2B5D70
	// RVA: 0x25F28F0 Offset: 0x25F29F1 VA: 0x25F28F0
	public string get_SoundLabel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5D80 Offset: 0x2B5E81 VA: 0x2B5D80
	// RVA: 0x25F2900 Offset: 0x25F2A01 VA: 0x25F2900
	private void set_SoundLabel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5D90 Offset: 0x2B5E91 VA: 0x2B5D90
	// RVA: 0x25F2910 Offset: 0x25F2A11 VA: 0x25F2910
	public EffectData.Types get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5DA0 Offset: 0x2B5EA1 VA: 0x2B5DA0
	// RVA: 0x25F2920 Offset: 0x25F2A21 VA: 0x25F2920
	private void set_Type(EffectData.Types value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5DB0 Offset: 0x2B5EB1 VA: 0x2B5DB0
	// RVA: 0x25F2930 Offset: 0x25F2A31 VA: 0x25F2930
	public float get_DelayTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5DC0 Offset: 0x2B5EC1 VA: 0x2B5DC0
	// RVA: 0x25F2940 Offset: 0x25F2A41 VA: 0x25F2940
	private void set_DelayTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5DD0 Offset: 0x2B5ED1 VA: 0x2B5DD0
	// RVA: 0x25F2950 Offset: 0x25F2A51 VA: 0x25F2950
	public float get_WaitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5DE0 Offset: 0x2B5EE1 VA: 0x2B5DE0
	// RVA: 0x25F2960 Offset: 0x25F2A61 VA: 0x25F2960
	private void set_WaitTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5DF0 Offset: 0x2B5EF1 VA: 0x2B5DF0
	// RVA: 0x25F2970 Offset: 0x25F2A71 VA: 0x25F2970
	public float get_ShakeTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E00 Offset: 0x2B5F01 VA: 0x2B5E00
	// RVA: 0x25F2980 Offset: 0x25F2A81 VA: 0x25F2980
	private void set_ShakeTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E10 Offset: 0x2B5F11 VA: 0x2B5E10
	// RVA: 0x25F2990 Offset: 0x25F2A91 VA: 0x25F2990
	public float get_ShakeMagnitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E20 Offset: 0x2B5F21 VA: 0x2B5E20
	// RVA: 0x25F29A0 Offset: 0x25F2AA1 VA: 0x25F29A0
	private void set_ShakeMagnitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E30 Offset: 0x2B5F31 VA: 0x2B5E30
	// RVA: 0x25F29B0 Offset: 0x25F2AB1 VA: 0x25F29B0
	public EffectData.Residents get_Resident() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E40 Offset: 0x2B5F41 VA: 0x2B5E40
	// RVA: 0x25F29C0 Offset: 0x25F2AC1 VA: 0x25F29C0
	private void set_Resident(EffectData.Residents value) { }

	// RVA: 0x25F29D0 Offset: 0x25F2AD1 VA: 0x25F29D0 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x25F2B60 Offset: 0x25F2C61 VA: 0x25F2B60 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x25F2B70 Offset: 0x25F2C71 VA: 0x25F2B70
	public string GetPath(EffectData.Modes mode) { }

	// RVA: 0x25F2BB0 Offset: 0x25F2CB1 VA: 0x25F2BB0
	public ResourceObject PlayCombat(GameObject parent) { }

	// RVA: 0x25F2E40 Offset: 0x25F2F41 VA: 0x25F2E40
	public ResourceObject PlayBmap(GameObject parent) { }

	// RVA: 0x25F2BC0 Offset: 0x25F2CC1 VA: 0x25F2BC0
	public ResourceObject Play(EffectData.Modes mode, GameObject parent, float delayTime = 0) { }

	// RVA: 0x25F2E50 Offset: 0x25F2F51 VA: 0x25F2E50
	public static bool IsBind() { }

	// RVA: 0x25F2EC0 Offset: 0x25F2FC1 VA: 0x25F2EC0
	public void .ctor() { }

	// RVA: 0x25F2F40 Offset: 0x25F3041 VA: 0x25F2F40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E50 Offset: 0x2B5F51 VA: 0x2B5E50
	// RVA: 0x25F2FC0 Offset: 0x25F30C1 VA: 0x25F2FC0
	private void <Play>b__46_0(GameObject go) { }
}

