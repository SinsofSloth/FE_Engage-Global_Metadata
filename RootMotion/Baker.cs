// Namespace: RootMotion
[HelpURLAttribute] // RVA: 0x279890 Offset: 0x279991 VA: 0x279890
[AddComponentMenu] // RVA: 0x279890 Offset: 0x279991 VA: 0x279890
public abstract class Baker : MonoBehaviour // TypeDefIndex: 14281
{
	// Fields
	[TooltipAttribute] // RVA: 0x29E4A0 Offset: 0x29E5A1 VA: 0x29E4A0
	[RangeAttribute] // RVA: 0x29E4A0 Offset: 0x29E5A1 VA: 0x29E4A0
	public int frameRate; // 0x18
	[TooltipAttribute] // RVA: 0x29E500 Offset: 0x29E601 VA: 0x29E500
	[RangeAttribute] // RVA: 0x29E500 Offset: 0x29E601 VA: 0x29E500
	public float keyReductionError; // 0x1C
	[TooltipAttribute] // RVA: 0x29E560 Offset: 0x29E661 VA: 0x29E560
	public Baker.Mode mode; // 0x20
	[TooltipAttribute] // RVA: 0x29E5A0 Offset: 0x29E6A1 VA: 0x29E5A0
	public AnimationClip[] animationClips; // 0x28
	[TooltipAttribute] // RVA: 0x29E5E0 Offset: 0x29E6E1 VA: 0x29E5E0
	public string[] animationStates; // 0x30
	[TooltipAttribute] // RVA: 0x29E620 Offset: 0x29E721 VA: 0x29E620
	public bool loop; // 0x38
	[TooltipAttribute] // RVA: 0x29E660 Offset: 0x29E761 VA: 0x29E660
	public string saveToFolder; // 0x40
	[TooltipAttribute] // RVA: 0x29E6A0 Offset: 0x29E7A1 VA: 0x29E6A0
	public string appendName; // 0x48
	[TooltipAttribute] // RVA: 0x29E6E0 Offset: 0x29E7E1 VA: 0x29E6E0
	public string saveName; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x29E720 Offset: 0x29E821 VA: 0x29E720
	private bool <isBaking>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x29E730 Offset: 0x29E831 VA: 0x29E730
	private float <bakingProgress>k__BackingField; // 0x5C
	[HideInInspector] // RVA: 0x29E740 Offset: 0x29E841 VA: 0x29E740
	[SerializeField] // RVA: 0x29E740 Offset: 0x29E841 VA: 0x29E740
	public Animator animator; // 0x60
	[SerializeField] // RVA: 0x29E780 Offset: 0x29E881 VA: 0x29E780
	[HideInInspector] // RVA: 0x29E780 Offset: 0x29E881 VA: 0x29E780
	public PlayableDirector director; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x29E7C0 Offset: 0x29E8C1 VA: 0x29E7C0
	private float <clipLength>k__BackingField; // 0x70

	// Properties
	public bool isBaking { get; set; }
	public float bakingProgress { get; set; }
	protected float clipLength { get; set; }

	// Methods

	[ContextMenu] // RVA: 0x2CE450 Offset: 0x2CE551 VA: 0x2CE450
	// RVA: 0x2614970 Offset: 0x2614A71 VA: 0x2614970
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CE490 Offset: 0x2CE591 VA: 0x2CE490
	// RVA: 0x26149C0 Offset: 0x2614AC1 VA: 0x26149C0
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2CE4D0 Offset: 0x2CE5D1 VA: 0x2CE4D0
	// RVA: 0x2614A10 Offset: 0x2614B11 VA: 0x2614A10
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2CE510 Offset: 0x2CE611 VA: 0x2CE510
	// RVA: 0x2614A60 Offset: 0x2614B61 VA: 0x2614A60
	private void ASThread() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE550 Offset: 0x2CE651 VA: 0x2CE550
	// RVA: 0x2614AB0 Offset: 0x2614BB1 VA: 0x2614AB0
	public bool get_isBaking() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE560 Offset: 0x2CE661 VA: 0x2CE560
	// RVA: 0x2614AC0 Offset: 0x2614BC1 VA: 0x2614AC0
	private void set_isBaking(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE570 Offset: 0x2CE671 VA: 0x2CE570
	// RVA: 0x2614AD0 Offset: 0x2614BD1 VA: 0x2614AD0
	public float get_bakingProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE580 Offset: 0x2CE681 VA: 0x2CE580
	// RVA: 0x2614AE0 Offset: 0x2614BE1 VA: 0x2614AE0
	private void set_bakingProgress(float value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Transform GetCharacterRoot();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnStartBaking();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnSetLoopFrame(float time);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnSetCurves(ref AnimationClip clip);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnSetKeyframes(float time, bool lastFrame);

	[CompilerGeneratedAttribute] // RVA: 0x2CE590 Offset: 0x2CE691 VA: 0x2CE590
	// RVA: 0x2614AF0 Offset: 0x2614BF1 VA: 0x2614AF0
	protected float get_clipLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE5A0 Offset: 0x2CE6A1 VA: 0x2CE5A0
	// RVA: 0x2614B00 Offset: 0x2614C01 VA: 0x2614B00
	private void set_clipLength(float value) { }

	// RVA: 0x2614B10 Offset: 0x2614C11 VA: 0x2614B10
	public void BakeClip() { }

	// RVA: 0x2614B20 Offset: 0x2614C21 VA: 0x2614B20
	public void StartBaking() { }

	// RVA: 0x2614B30 Offset: 0x2614C31 VA: 0x2614B30
	public void StopBaking() { }

	// RVA: 0x2614B40 Offset: 0x2614C41 VA: 0x2614B40
	protected void .ctor() { }
}

