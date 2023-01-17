// Namespace: 
[Serializable]
public class InteractionObject.Message // TypeDefIndex: 14408
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A2AE0 Offset: 0x2A2BE1 VA: 0x2A2AE0
	public string function; // 0x10
	[TooltipAttribute] // RVA: 0x2A2B20 Offset: 0x2A2C21 VA: 0x2A2B20
	public GameObject recipient; // 0x18
	private const string empty = "";

	// Methods

	// RVA: 0x22210C0 Offset: 0x22211C1 VA: 0x22210C0
	public void Send(Transform t) { }

	// RVA: 0x22211D0 Offset: 0x22212D1 VA: 0x22211D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public enum InteractionObject.WeightCurve.Type // TypeDefIndex: 14410
{
	// Fields
	public int value__; // 0x0
	public const InteractionObject.WeightCurve.Type PositionWeight = 0;
	public const InteractionObject.WeightCurve.Type RotationWeight = 1;
	public const InteractionObject.WeightCurve.Type PositionOffsetX = 2;
	public const InteractionObject.WeightCurve.Type PositionOffsetY = 3;
	public const InteractionObject.WeightCurve.Type PositionOffsetZ = 4;
	public const InteractionObject.WeightCurve.Type Pull = 5;
	public const InteractionObject.WeightCurve.Type Reach = 6;
	public const InteractionObject.WeightCurve.Type RotateBoneWeight = 7;
	public const InteractionObject.WeightCurve.Type Push = 8;
	public const InteractionObject.WeightCurve.Type PushParent = 9;
	public const InteractionObject.WeightCurve.Type PoserWeight = 10;
	public const InteractionObject.WeightCurve.Type BendGoalWeight = 11;
}

// Namespace: 
[Serializable]
public class InteractionObject.Multiplier // TypeDefIndex: 14412
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A2D60 Offset: 0x2A2E61 VA: 0x2A2D60
	public InteractionObject.WeightCurve.Type curve; // 0x10
	[TooltipAttribute] // RVA: 0x2A2DA0 Offset: 0x2A2EA1 VA: 0x2A2DA0
	public float multiplier; // 0x14
	[TooltipAttribute] // RVA: 0x2A2DE0 Offset: 0x2A2EE1 VA: 0x2A2DE0
	public InteractionObject.WeightCurve.Type result; // 0x18

	// Methods

	// RVA: 0x22211E0 Offset: 0x22212E1 VA: 0x22211E0
	public float GetValue(InteractionObject.WeightCurve weightCurve, float timer) { }

	// RVA: 0x2221220 Offset: 0x2221321 VA: 0x2221220
	public void .ctor() { }
}

