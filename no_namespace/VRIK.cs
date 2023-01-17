// Namespace: 
[Serializable]
public class VRIK.References // TypeDefIndex: 14351
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform spine; // 0x20
	[TooltipAttribute] // RVA: 0x29FCF0 Offset: 0x29FDF1 VA: 0x29FCF0
	public Transform chest; // 0x28
	[TooltipAttribute] // RVA: 0x29FD30 Offset: 0x29FE31 VA: 0x29FD30
	public Transform neck; // 0x30
	public Transform head; // 0x38
	[TooltipAttribute] // RVA: 0x29FD70 Offset: 0x29FE71 VA: 0x29FD70
	public Transform leftShoulder; // 0x40
	public Transform leftUpperArm; // 0x48
	public Transform leftForearm; // 0x50
	public Transform leftHand; // 0x58
	[TooltipAttribute] // RVA: 0x29FDB0 Offset: 0x29FEB1 VA: 0x29FDB0
	public Transform rightShoulder; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	[TooltipAttribute] // RVA: 0x29FDF0 Offset: 0x29FEF1 VA: 0x29FDF0
	public Transform leftThigh; // 0x80
	[TooltipAttribute] // RVA: 0x29FE30 Offset: 0x29FF31 VA: 0x29FE30
	public Transform leftCalf; // 0x88
	[TooltipAttribute] // RVA: 0x29FE70 Offset: 0x29FF71 VA: 0x29FE70
	public Transform leftFoot; // 0x90
	[TooltipAttribute] // RVA: 0x29FEB0 Offset: 0x29FFB1 VA: 0x29FEB0
	public Transform leftToes; // 0x98
	[TooltipAttribute] // RVA: 0x29FEF0 Offset: 0x29FFF1 VA: 0x29FEF0
	public Transform rightThigh; // 0xA0
	[TooltipAttribute] // RVA: 0x29FF30 Offset: 0x2A0031 VA: 0x29FF30
	public Transform rightCalf; // 0xA8
	[TooltipAttribute] // RVA: 0x29FF70 Offset: 0x2A0071 VA: 0x29FF70
	public Transform rightFoot; // 0xB0
	[TooltipAttribute] // RVA: 0x29FFB0 Offset: 0x2A00B1 VA: 0x29FFB0
	public Transform rightToes; // 0xB8

	// Properties
	public bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x1EDEFC0 Offset: 0x1EDF0C1 VA: 0x1EDEFC0
	public Transform[] GetTransforms() { }

	// RVA: 0x1EDF510 Offset: 0x1EDF611 VA: 0x1EDF510
	public bool get_isFilled() { }

	// RVA: 0x1EDF9A0 Offset: 0x1EDFAA1 VA: 0x1EDF9A0
	public bool get_isEmpty() { }

	// RVA: 0x1EDFE30 Offset: 0x1EDFF31 VA: 0x1EDFE30
	public static bool AutoDetectReferences(Transform root, out VRIK.References references) { }

	// RVA: 0x1EE0240 Offset: 0x1EE0341 VA: 0x1EE0240
	public void .ctor() { }
}

