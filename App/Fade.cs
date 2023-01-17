// Namespace: App
public class Fade // TypeDefIndex: 13838
{
	// Fields
	public const int Num = 4;
	public const float VeryFast = 0.125;
	public const float Fast = 0.25;
	public const float Normal = 0.5;
	public const float Slow = 1;
	public const float VerySlow = 2;
	private static Fade.ProcFade s_Proc; // 0x0
	private static Color[] s_Colors; // 0x8
	private static Fade.Layer s_Layer; // 0x10
	private static Stack<Fade.Layer> s_Statck; // 0x18

	// Methods

	// RVA: 0x2A18C50 Offset: 0x2A18D51 VA: 0x2A18C50
	public static void Initialize() { }

	// RVA: 0x2A18EF0 Offset: 0x2A18FF1 VA: 0x2A18EF0
	public static Color GetImageColor(Fade.Layer layer) { }

	// RVA: 0x2A19010 Offset: 0x2A19111 VA: 0x2A19010
	public static void SetImageColor(Fade.Layer layer, Color color) { }

	// RVA: 0x2A19100 Offset: 0x2A19201 VA: 0x2A19100
	public static void FadeIn(float duration = 0.5) { }

	// RVA: 0x2A19160 Offset: 0x2A19261 VA: 0x2A19160
	public static void FadeOut(float duration = 0.5) { }

	// RVA: 0x2A19220 Offset: 0x2A19321 VA: 0x2A19220
	public static void FadeOut(Color color, float duration = 0.5) { }

	// RVA: 0x2A19270 Offset: 0x2A19371 VA: 0x2A19270
	public static void FadeIn(Fade.Layer layer, float duration = 0.5) { }

	// RVA: 0x2A106C0 Offset: 0x2A107C1 VA: 0x2A106C0
	public static void FadeOut(Fade.Layer layer, float duration = 0.5) { }

	// RVA: 0x2A19540 Offset: 0x2A19641 VA: 0x2A19540
	public static void FadeOut(Fade.Layer layer, Color color, float duration = 0.5) { }

	// RVA: 0x2A19410 Offset: 0x2A19511 VA: 0x2A19410
	public static void PushLayer(Fade.Layer layer) { }

	// RVA: 0x2A194B0 Offset: 0x2A195B1 VA: 0x2A194B0
	public static void PopLayer() { }

	// RVA: 0x2A196F0 Offset: 0x2A197F1 VA: 0x2A196F0
	public static bool IsActive() { }

	// RVA: 0x2A197F0 Offset: 0x2A198F1 VA: 0x2A197F0
	public static bool IsActive(Fade.Layer layer) { }

	// RVA: 0x2A198B0 Offset: 0x2A199B1 VA: 0x2A198B0
	public static bool IsFadeOut() { }

	// RVA: 0x2A199C0 Offset: 0x2A19AC1 VA: 0x2A199C0
	public static bool IsFadeOut(Fade.Layer layer) { }

	// RVA: 0x2A19AA0 Offset: 0x2A19BA1 VA: 0x2A19AA0
	public static float GetAlpha() { }

	// RVA: 0x2A19CE0 Offset: 0x2A19DE1 VA: 0x2A19CE0
	public static bool WaitBind(ProcInst super, Fade.Layer layer = 4) { }

	// RVA: 0x2A19E80 Offset: 0x2A19F81 VA: 0x2A19E80
	public static ProcDesc BlackIn(float duration, Fade.Layer layer = 4) { }

	// RVA: 0x2A19F40 Offset: 0x2A1A041 VA: 0x2A19F40
	public static ProcDesc BlackOut(float duration, Fade.Layer layer = 4) { }

	// RVA: 0x2A1A000 Offset: 0x2A1A101 VA: 0x2A1A000
	public static ProcDesc WhiteIn(float duration, Fade.Layer layer = 4) { }

	// RVA: 0x2A1A0C0 Offset: 0x2A1A1C1 VA: 0x2A1A0C0
	public static ProcDesc WhiteOut(float duration, Fade.Layer layer = 4) { }

	// RVA: 0x2A1A180 Offset: 0x2A1A281 VA: 0x2A1A180
	public static ProcDesc FadeIn(Color color, float duration, Fade.Layer layer = 4) { }

	// RVA: 0x2A1A230 Offset: 0x2A1A331 VA: 0x2A1A230
	public static ProcDesc FadeOut(Color color, float duration, Fade.Layer layer = 4) { }

	// RVA: 0x2A1A2E0 Offset: 0x2A1A3E1 VA: 0x2A1A2E0
	public static ProcDesc FadeWait(Fade.Layer layer = 4) { }

	// RVA: 0x2A1A350 Offset: 0x2A1A451 VA: 0x2A1A350
	public void .ctor() { }

	// RVA: 0x2A1A360 Offset: 0x2A1A461 VA: 0x2A1A360
	private static void .cctor() { }
}

