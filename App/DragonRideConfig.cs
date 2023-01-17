// Namespace: App
[Serializable]
public abstract class DragonRideConfig : MonoBehaviour // TypeDefIndex: 10500
{
	// Fields
	[SerializeField] // RVA: 0x28E870 Offset: 0x28E971 VA: 0x28E870
	[TooltipAttribute] // RVA: 0x28E870 Offset: 0x28E971 VA: 0x28E870
	public float TargetChainIntervalSecond; // 0x18
	[SerializeField] // RVA: 0x28E8C0 Offset: 0x28E9C1 VA: 0x28E8C0
	[TooltipAttribute] // RVA: 0x28E8C0 Offset: 0x28E9C1 VA: 0x28E8C0
	public float TargetAppearSecond; // 0x1C
	[SerializeField] // RVA: 0x28E910 Offset: 0x28EA11 VA: 0x28E910
	[TooltipAttribute] // RVA: 0x28E910 Offset: 0x28EA11 VA: 0x28E910
	public int[] ScoreBorderList_Normal; // 0x20
	[SerializeField] // RVA: 0x28E960 Offset: 0x28EA61 VA: 0x28E960
	[TooltipAttribute] // RVA: 0x28E960 Offset: 0x28EA61 VA: 0x28E960
	public int[] ScoreBorderList_Hard; // 0x28
	[TooltipAttribute] // RVA: 0x28E9B0 Offset: 0x28EAB1 VA: 0x28E9B0
	[SerializeField] // RVA: 0x28E9B0 Offset: 0x28EAB1 VA: 0x28E9B0
	public int[] ScoreBorderList_Expert; // 0x30
	[SerializeField] // RVA: 0x28EA00 Offset: 0x28EB01 VA: 0x28EA00
	[TooltipAttribute] // RVA: 0x28EA00 Offset: 0x28EB01 VA: 0x28EA00
	public Vector3 DragonModelOffset; // 0x38
	[SerializeField] // RVA: 0x28EA50 Offset: 0x28EB51 VA: 0x28EA50
	[TooltipAttribute] // RVA: 0x28EA50 Offset: 0x28EB51 VA: 0x28EA50
	public Vector3 AssistModelOffset; // 0x44
	[SerializeField] // RVA: 0x28EAA0 Offset: 0x28EBA1 VA: 0x28EAA0
	[TooltipAttribute] // RVA: 0x28EAA0 Offset: 0x28EBA1 VA: 0x28EAA0
	public Vector3 AssistBindOffsetPos; // 0x50
	[SerializeField] // RVA: 0x28EAF0 Offset: 0x28EBF1 VA: 0x28EAF0
	[TooltipAttribute] // RVA: 0x28EAF0 Offset: 0x28EBF1 VA: 0x28EAF0
	public Vector3 AssistBindOffsetRotate; // 0x5C
	[SerializeField] // RVA: 0x28EB40 Offset: 0x28EC41 VA: 0x28EB40
	[TooltipAttribute] // RVA: 0x28EB40 Offset: 0x28EC41 VA: 0x28EB40
	public float CutinKeepSec; // 0x68
	[SerializeField] // RVA: 0x28EB90 Offset: 0x28EC91 VA: 0x28EB90
	[TooltipAttribute] // RVA: 0x28EB90 Offset: 0x28EC91 VA: 0x28EB90
	public float CutinCloseSec; // 0x6C
	[TooltipAttribute] // RVA: 0x28EBE0 Offset: 0x28ECE1 VA: 0x28EBE0
	[SerializeField] // RVA: 0x28EBE0 Offset: 0x28ECE1 VA: 0x28EBE0
	public bool PopUpIsEnableScaleCulc; // 0x70
	[SerializeField] // RVA: 0x28EC30 Offset: 0x28ED31 VA: 0x28EC30
	[TooltipAttribute] // RVA: 0x28EC30 Offset: 0x28ED31 VA: 0x28EC30
	public bool IsShowScreenDustAtEventMode; // 0x71
	[SerializeField] // RVA: 0x28EC80 Offset: 0x28ED81 VA: 0x28EC80
	[TooltipAttribute] // RVA: 0x28EC80 Offset: 0x28ED81 VA: 0x28EC80
	public float CameraAccelFrame; // 0x74
	[SerializeField] // RVA: 0x28ECD0 Offset: 0x28EDD1 VA: 0x28ECD0
	[TooltipAttribute] // RVA: 0x28ECD0 Offset: 0x28EDD1 VA: 0x28ECD0
	public float CameraDecelFrame; // 0x78
	[SerializeField] // RVA: 0x28ED20 Offset: 0x28EE21 VA: 0x28ED20
	[TooltipAttribute] // RVA: 0x28ED20 Offset: 0x28EE21 VA: 0x28ED20
	public float PopUpDistanceMax; // 0x7C
	[SerializeField] // RVA: 0x28ED70 Offset: 0x28EE71 VA: 0x28ED70
	[TooltipAttribute] // RVA: 0x28ED70 Offset: 0x28EE71 VA: 0x28ED70
	public float PopUpDistanceMin; // 0x80
	[SerializeField] // RVA: 0x28EDC0 Offset: 0x28EEC1 VA: 0x28EDC0
	[TooltipAttribute] // RVA: 0x28EDC0 Offset: 0x28EEC1 VA: 0x28EDC0
	public float PopUpScaleMax; // 0x84
	[SerializeField] // RVA: 0x28EE10 Offset: 0x28EF11 VA: 0x28EE10
	[TooltipAttribute] // RVA: 0x28EE10 Offset: 0x28EF11 VA: 0x28EE10
	public DragonRideConfig.ShotConfig shotConfig; // 0x88
	[TooltipAttribute] // RVA: 0x28EE60 Offset: 0x28EF61 VA: 0x28EE60
	[SerializeField] // RVA: 0x28EE60 Offset: 0x28EF61 VA: 0x28EE60
	public DragonRideConfig.ResultConfig resultConfig; // 0x90

	// Methods

	// RVA: 0x2388F00 Offset: 0x2389001 VA: 0x2388F00
	protected void .ctor() { }
}

