// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x279F40 Offset: 0x27A041 VA: 0x279F40
[AddComponentMenu] // RVA: 0x279F40 Offset: 0x27A041 VA: 0x279F40
public class InteractionObject : MonoBehaviour // TypeDefIndex: 14413
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A2880 Offset: 0x2A2981 VA: 0x2A2880
	public Transform otherLookAtTarget; // 0x18
	[TooltipAttribute] // RVA: 0x2A28C0 Offset: 0x2A29C1 VA: 0x2A28C0
	public Transform otherTargetsRoot; // 0x20
	[TooltipAttribute] // RVA: 0x2A2900 Offset: 0x2A2A01 VA: 0x2A2900
	public Transform positionOffsetSpace; // 0x28
	public InteractionObject.WeightCurve[] weightCurves; // 0x30
	public InteractionObject.Multiplier[] multipliers; // 0x38
	public InteractionObject.InteractionEvent[] events; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x2A2940 Offset: 0x2A2A41 VA: 0x2A2940
	private float <length>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x2A2950 Offset: 0x2A2A51 VA: 0x2A2950
	private InteractionSystem <lastUsedInteractionSystem>k__BackingField; // 0x50
	private InteractionTarget[] targets; // 0x58

	// Properties
	public float length { get; set; }
	public InteractionSystem lastUsedInteractionSystem { get; set; }
	public Transform lookAtTarget { get; }
	public Transform targetsRoot { get; }

	// Methods

	[ContextMenu] // RVA: 0x2CFC00 Offset: 0x2CFD01 VA: 0x2CFC00
	// RVA: 0x2C525C0 Offset: 0x2C526C1 VA: 0x2C525C0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CFC40 Offset: 0x2CFD41 VA: 0x2CFC40
	// RVA: 0x2C52610 Offset: 0x2C52711 VA: 0x2C52610
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2CFC80 Offset: 0x2CFD81 VA: 0x2CFC80
	// RVA: 0x2C52660 Offset: 0x2C52761 VA: 0x2C52660
	private void OpenTutorial1() { }

	[ContextMenu] // RVA: 0x2CFCC0 Offset: 0x2CFDC1 VA: 0x2CFCC0
	// RVA: 0x2C526B0 Offset: 0x2C527B1 VA: 0x2C526B0
	private void OpenTutorial2() { }

	[ContextMenu] // RVA: 0x2CFD00 Offset: 0x2CFE01 VA: 0x2CFD00
	// RVA: 0x2C52700 Offset: 0x2C52801 VA: 0x2C52700
	private void OpenTutorial3() { }

	[ContextMenu] // RVA: 0x2CFD40 Offset: 0x2CFE41 VA: 0x2CFD40
	// RVA: 0x2C52750 Offset: 0x2C52851 VA: 0x2C52750
	private void OpenTutorial4() { }

	[ContextMenu] // RVA: 0x2CFD80 Offset: 0x2CFE81 VA: 0x2CFD80
	// RVA: 0x2C527A0 Offset: 0x2C528A1 VA: 0x2C527A0
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2CFDC0 Offset: 0x2CFEC1 VA: 0x2CFDC0
	// RVA: 0x2C527F0 Offset: 0x2C528F1 VA: 0x2C527F0
	private void ASThread() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFE00 Offset: 0x2CFF01 VA: 0x2CFE00
	// RVA: 0x2C52840 Offset: 0x2C52941 VA: 0x2C52840
	public float get_length() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFE10 Offset: 0x2CFF11 VA: 0x2CFE10
	// RVA: 0x2C52850 Offset: 0x2C52951 VA: 0x2C52850
	private void set_length(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFE20 Offset: 0x2CFF21 VA: 0x2CFE20
	// RVA: 0x2C52860 Offset: 0x2C52961 VA: 0x2C52860
	public InteractionSystem get_lastUsedInteractionSystem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFE30 Offset: 0x2CFF31 VA: 0x2CFE30
	// RVA: 0x2C52870 Offset: 0x2C52971 VA: 0x2C52870
	private void set_lastUsedInteractionSystem(InteractionSystem value) { }

	// RVA: 0x2C52880 Offset: 0x2C52981 VA: 0x2C52880
	public void Initiate() { }

	// RVA: 0x2C52A90 Offset: 0x2C52B91 VA: 0x2C52A90
	public Transform get_lookAtTarget() { }

	// RVA: 0x2C52B30 Offset: 0x2C52C31 VA: 0x2C52B30
	public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem) { }

	// RVA: 0x2C507C0 Offset: 0x2C508C1 VA: 0x2C507C0
	public bool CurveUsed(InteractionObject.WeightCurve.Type type) { }

	// RVA: 0x2C52C90 Offset: 0x2C52D91 VA: 0x2C52C90
	public InteractionTarget[] GetTargets() { }

	// RVA: 0x2C50640 Offset: 0x2C50741 VA: 0x2C50640
	public Transform GetTarget(FullBodyBipedEffector effectorType, string tag) { }

	// RVA: 0x2C507B0 Offset: 0x2C508B1 VA: 0x2C507B0
	public void OnStartInteraction(InteractionSystem interactionSystem) { }

	// RVA: 0x2C50EF0 Offset: 0x2C50FF1 VA: 0x2C50EF0
	public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight) { }

	// RVA: 0x2C51850 Offset: 0x2C51951 VA: 0x2C51850
	public float GetValue(InteractionObject.WeightCurve.Type weightCurveType, InteractionTarget target, float timer) { }

	// RVA: 0x2C51D30 Offset: 0x2C51E31 VA: 0x2C51D30
	public Transform get_targetsRoot() { }

	// RVA: 0x2C531D0 Offset: 0x2C532D1 VA: 0x2C531D0
	private void Start() { }

	// RVA: 0x2C52D10 Offset: 0x2C52E11 VA: 0x2C52D10
	private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionObject.WeightCurve.Type type, float value, float weight) { }

	// RVA: 0x2C52CA0 Offset: 0x2C52DA1 VA: 0x2C52CA0
	private Transform GetTarget(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C53150 Offset: 0x2C53251 VA: 0x2C53150
	private int GetWeightCurveIndex(InteractionObject.WeightCurve.Type weightCurveType) { }

	// RVA: 0x2C531E0 Offset: 0x2C532E1 VA: 0x2C531E0
	private int GetMultiplierIndex(InteractionObject.WeightCurve.Type weightCurveType) { }

	// RVA: 0x2C53260 Offset: 0x2C53361 VA: 0x2C53260
	public void .ctor() { }
}

