// Namespace: 
[Serializable]
public class InteractionObject.InteractionEvent // TypeDefIndex: 14407
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A2960 Offset: 0x2A2A61 VA: 0x2A2960
	public float time; // 0x10
	[TooltipAttribute] // RVA: 0x2A29A0 Offset: 0x2A2AA1 VA: 0x2A29A0
	public bool pause; // 0x14
	[TooltipAttribute] // RVA: 0x2A29E0 Offset: 0x2A2AE1 VA: 0x2A29E0
	public bool pickUp; // 0x15
	[TooltipAttribute] // RVA: 0x2A2A20 Offset: 0x2A2B21 VA: 0x2A2A20
	public InteractionObject.AnimatorEvent[] animations; // 0x18
	[TooltipAttribute] // RVA: 0x2A2A60 Offset: 0x2A2B61 VA: 0x2A2A60
	public InteractionObject.Message[] messages; // 0x20
	[TooltipAttribute] // RVA: 0x2A2AA0 Offset: 0x2A2BA1 VA: 0x2A2AA0
	public UnityEvent unityEvent; // 0x28

	// Methods

	// RVA: 0x2220FF0 Offset: 0x22210F1 VA: 0x2220FF0
	public void Activate(Transform t) { }

	// RVA: 0x22211C0 Offset: 0x22212C1 VA: 0x22211C0
	public void .ctor() { }
}

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
public class InteractionObject.AnimatorEvent // TypeDefIndex: 14409
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A2B60 Offset: 0x2A2C61 VA: 0x2A2B60
	public Animator animator; // 0x10
	[TooltipAttribute] // RVA: 0x2A2BA0 Offset: 0x2A2CA1 VA: 0x2A2BA0
	public Animation animation; // 0x18
	[TooltipAttribute] // RVA: 0x2A2BE0 Offset: 0x2A2CE1 VA: 0x2A2BE0
	public string animationState; // 0x20
	[TooltipAttribute] // RVA: 0x2A2C20 Offset: 0x2A2D21 VA: 0x2A2C20
	public float crossfadeTime; // 0x28
	[TooltipAttribute] // RVA: 0x2A2C60 Offset: 0x2A2D61 VA: 0x2A2C60
	public int layer; // 0x2C
	[TooltipAttribute] // RVA: 0x2A2CA0 Offset: 0x2A2DA1 VA: 0x2A2CA0
	public bool resetNormalizedTime; // 0x30
	private const string empty = "";

	// Methods

	// RVA: 0x2220CE0 Offset: 0x2220DE1 VA: 0x2220CE0
	public void Activate(bool pickUp) { }

	// RVA: 0x2220E50 Offset: 0x2220F51 VA: 0x2220E50
	private void Activate(Animator animator) { }

	// RVA: 0x2220F00 Offset: 0x2221001 VA: 0x2220F00
	private void Activate(Animation animation) { }

	// RVA: 0x2220FD0 Offset: 0x22210D1 VA: 0x2220FD0
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
public class InteractionObject.WeightCurve // TypeDefIndex: 14411
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A2CE0 Offset: 0x2A2DE1 VA: 0x2A2CE0
	public InteractionObject.WeightCurve.Type type; // 0x10
	[TooltipAttribute] // RVA: 0x2A2D20 Offset: 0x2A2E21 VA: 0x2A2D20
	public AnimationCurve curve; // 0x18

	// Methods

	// RVA: 0x2221210 Offset: 0x2221311 VA: 0x2221210
	public float GetValue(float timer) { }

	// RVA: 0x2221230 Offset: 0x2221331 VA: 0x2221230
	public void .ctor() { }
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

