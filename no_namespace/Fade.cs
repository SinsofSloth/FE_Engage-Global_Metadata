// Namespace: 
public enum Fade.Layer // TypeDefIndex: 13830
{
	// Fields
	public int value__; // 0x0
	public const Fade.Layer System = 0;
	public const Fade.Layer Skip = 1;
	public const Fade.Layer Talk = 2;
	public const Fade.Layer Combat = 3;
	public const Fade.Layer Current = 4;
}

// Namespace: 
private class Fade.FadeLayer // TypeDefIndex: 13832
{
	// Fields
	private Color m_FromColor; // 0x10
	private Color m_ToColor; // 0x20
	private float m_Duration; // 0x30
	private float m_Elapsed; // 0x34

	// Properties
	public Color ToColor { get; }

	// Methods

	// RVA: 0x22D9320 Offset: 0x22D9421 VA: 0x22D9320
	public void Exec(Color toColor, float duration) { }

	// RVA: 0x22D9470 Offset: 0x22D9571 VA: 0x22D9470
	public bool Tick(float deltaTime) { }

	// RVA: 0x22D9410 Offset: 0x22D9511 VA: 0x22D9410
	public Color GetColor() { }

	// RVA: 0x22D94C0 Offset: 0x22D95C1 VA: 0x22D94C0
	public Color get_ToColor() { }

	// RVA: 0x22D94D0 Offset: 0x22D95D1 VA: 0x22D94D0
	public bool IsActive() { }

	// RVA: 0x22D94E0 Offset: 0x22D95E1 VA: 0x22D94E0
	public bool IsAlive() { }

	// RVA: 0x22D9510 Offset: 0x22D9611 VA: 0x22D9510
	public void .ctor() { }
}

// Namespace: 
private class Fade.ProcFadeWait : ProcInst // TypeDefIndex: 13834
{
	// Fields
	private Fade.Layer m_Layer; // 0x70

	// Methods

	// RVA: 0x22DA620 Offset: 0x22DA721 VA: 0x22DA620
	public void .ctor(Fade.Layer layer) { }

	// RVA: 0x22DA650 Offset: 0x22DA751 VA: 0x22DA650 Slot: 6
	protected override void OnTick() { }
}

// Namespace: 
private class Fade.ProcDescInOut : Fade.ProcDescFade // TypeDefIndex: 13836
{
	// Fields
	private Color m_Color; // 0x18
	private float m_Duration; // 0x28
	private bool m_IsIn; // 0x2C

	// Methods

	// RVA: 0x22D9860 Offset: 0x22D9961 VA: 0x22D9860
	public void .ctor(Fade.Layer layer, Color color, float duration, bool isIn) { }

	// RVA: 0x22D98E0 Offset: 0x22D99E1 VA: 0x22D98E0 Slot: 4
	public override ProcDesc.Result Execute(ProcInst inst) { }
}

