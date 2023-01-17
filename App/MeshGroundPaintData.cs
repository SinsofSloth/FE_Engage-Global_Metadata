// Namespace: App
public abstract class MeshGroundPaintData : ScriptableObject // TypeDefIndex: 8996
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x285620 Offset: 0x285721 VA: 0x285620
	[SerializeField] // RVA: 0x285620 Offset: 0x285721 VA: 0x285620
	private bool <IsCustomSize>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x285660 Offset: 0x285761 VA: 0x285660
	[SerializeField] // RVA: 0x285660 Offset: 0x285761 VA: 0x285660
	[HideInInspector] // RVA: 0x285660 Offset: 0x285761 VA: 0x285660
	private string[] <Names>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2856B0 Offset: 0x2857B1 VA: 0x2856B0
	[SerializeField] // RVA: 0x2856B0 Offset: 0x2857B1 VA: 0x2856B0
	[HideInInspector] // RVA: 0x2856B0 Offset: 0x2857B1 VA: 0x2856B0
	private Vector2Int <SplitCount>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x285700 Offset: 0x285801 VA: 0x285700
	[HideInInspector] // RVA: 0x285700 Offset: 0x285801 VA: 0x285700
	[SerializeField] // RVA: 0x285700 Offset: 0x285801 VA: 0x285700
	private Vector2 <Size>k__BackingField; // 0x30
	[SerializeField] // RVA: 0x285750 Offset: 0x285851 VA: 0x285750
	[CompilerGeneratedAttribute] // RVA: 0x285750 Offset: 0x285851 VA: 0x285750
	[HideInInspector] // RVA: 0x285750 Offset: 0x285851 VA: 0x285750
	private Vector2 <Offset>k__BackingField; // 0x38
	[HideInInspector] // RVA: 0x2857A0 Offset: 0x2858A1 VA: 0x2857A0
	[SerializeField] // RVA: 0x2857A0 Offset: 0x2858A1 VA: 0x2857A0
	[CompilerGeneratedAttribute] // RVA: 0x2857A0 Offset: 0x2858A1 VA: 0x2857A0
	private int[] <IndexList>k__BackingField; // 0x40

	// Properties
	public bool IsCustomSize { get; set; }
	public string[] Names { get; set; }
	public Vector2Int SplitCount { get; set; }
	public Vector2 Size { get; set; }
	public Vector2 Offset { get; set; }
	public int[] IndexList { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2ADCF0 Offset: 0x2ADDF1 VA: 0x2ADCF0
	// RVA: 0x2866740 Offset: 0x2866841 VA: 0x2866740
	public bool get_IsCustomSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD00 Offset: 0x2ADE01 VA: 0x2ADD00
	// RVA: 0x2866750 Offset: 0x2866851 VA: 0x2866750
	public void set_IsCustomSize(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD10 Offset: 0x2ADE11 VA: 0x2ADD10
	// RVA: 0x2866760 Offset: 0x2866861 VA: 0x2866760
	public string[] get_Names() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD20 Offset: 0x2ADE21 VA: 0x2ADD20
	// RVA: 0x2866770 Offset: 0x2866871 VA: 0x2866770
	public void set_Names(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD30 Offset: 0x2ADE31 VA: 0x2ADD30
	// RVA: 0x2866780 Offset: 0x2866881 VA: 0x2866780
	public Vector2Int get_SplitCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD40 Offset: 0x2ADE41 VA: 0x2ADD40
	// RVA: 0x2866790 Offset: 0x2866891 VA: 0x2866790
	public void set_SplitCount(Vector2Int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD50 Offset: 0x2ADE51 VA: 0x2ADD50
	// RVA: 0x28667A0 Offset: 0x28668A1 VA: 0x28667A0
	public Vector2 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD60 Offset: 0x2ADE61 VA: 0x2ADD60
	// RVA: 0x28667B0 Offset: 0x28668B1 VA: 0x28667B0
	public void set_Size(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD70 Offset: 0x2ADE71 VA: 0x2ADD70
	// RVA: 0x28667C0 Offset: 0x28668C1 VA: 0x28667C0
	public Vector2 get_Offset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD80 Offset: 0x2ADE81 VA: 0x2ADD80
	// RVA: 0x28667D0 Offset: 0x28668D1 VA: 0x28667D0
	public void set_Offset(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADD90 Offset: 0x2ADE91 VA: 0x2ADD90
	// RVA: 0x28667E0 Offset: 0x28668E1 VA: 0x28667E0
	public int[] get_IndexList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADDA0 Offset: 0x2ADEA1 VA: 0x2ADDA0
	// RVA: 0x28667F0 Offset: 0x28668F1 VA: 0x28667F0
	public void set_IndexList(int[] value) { }

	// RVA: 0x2866800 Offset: 0x2866901 VA: 0x2866800
	public string GetName(float x, float y) { }

	// RVA: 0x28668E0 Offset: 0x28669E1 VA: 0x28668E0
	protected void .ctor() { }
}

