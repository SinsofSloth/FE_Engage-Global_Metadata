// Namespace: 
public class DebugMesh : DynamicMesh // TypeDefIndex: 7611
{
	// Fields
	private const float SCALE_X = 0.03125;
	private const float SCALE_Y = 0.03125;
	private static Quaternion ROLL_90; // 0x0
	private Vector2 m_MaskUV; // 0x64

	// Properties
	public float FontSize { get; }

	// Methods

	// RVA: 0x2EA5E80 Offset: 0x2EA5F81 VA: 0x2EA5E80
	public float get_FontSize() { }

	// RVA: 0x2EA5E90 Offset: 0x2EA5F91 VA: 0x2EA5E90
	public void .ctor(int vertexCapacity) { }

	// RVA: 0x2EA5F50 Offset: 0x2EA6051 VA: 0x2EA5F50
	public void .ctor(GameObject go, int subMeshCount, int vertexCapacity) { }

	// RVA: 0x2EA6010 Offset: 0x2EA6111 VA: 0x2EA6010
	public void AddText(float x, float y, Color color, string text) { }

	// RVA: 0x2EA65A0 Offset: 0x2EA66A1 VA: 0x2EA65A0
	public void AddText(float x, float y, Color color, char[] text) { }

	// RVA: 0x2EA6680 Offset: 0x2EA6781 VA: 0x2EA6680
	public void AddLine(float x0, float y0, float x1, float y1, Color color) { }

	// RVA: 0x2EA6690 Offset: 0x2EA6791 VA: 0x2EA6690
	public void AddLine(Vector2 pos0, Vector2 pos1, Color color) { }

	// RVA: 0x2EA6A60 Offset: 0x2EA6B61 VA: 0x2EA6A60
	public void AddRect(Rect rect, Color color) { }

	// RVA: 0x2EA6B20 Offset: 0x2EA6C21 VA: 0x2EA6B20
	public void AddRect(float x, float y, float w, float h, Color color) { }

	// RVA: 0x2EA6E10 Offset: 0x2EA6F11 VA: 0x2EA6E10
	public static int GetIndex(char code) { }

	// RVA: 0x2EA6E30 Offset: 0x2EA6F31 VA: 0x2EA6E30
	public static Vector2 GetUV0(int index) { }

	// RVA: 0x2EA6E60 Offset: 0x2EA6F61 VA: 0x2EA6E60
	public static Vector2 GetUV2(int index) { }

	// RVA: 0x2EA5F40 Offset: 0x2EA6041 VA: 0x2EA5F40
	public static Vector2 GetMaskUV() { }

	// RVA: 0x2EA6EA0 Offset: 0x2EA6FA1 VA: 0x2EA6EA0
	public static Vector2 GetNumUV0(int num) { }

	// RVA: 0x2EA6EF0 Offset: 0x2EA6FF1 VA: 0x2EA6EF0
	public static Vector2 GetNumUV2(int num) { }

	// RVA: 0x2EA6F40 Offset: 0x2EA7041 VA: 0x2EA6F40
	public static Vector2 GetHexUV0(int hex) { }

	// RVA: 0x2EA6F70 Offset: 0x2EA7071 VA: 0x2EA6F70
	public static Vector2 GetHexUV2(int hex) { }

	// RVA: 0x2EA60D0 Offset: 0x2EA61D1 VA: 0x2EA60D0
	private float AddChara(float x, float y, Color32 color, char code) { }

	// RVA: 0x2EA6FB0 Offset: 0x2EA70B1 VA: 0x2EA6FB0
	private static void .cctor() { }
}

