// Namespace: UnityEngine.Rendering
public static class CoreMatrixUtils // TypeDefIndex: 4622
{
	// Methods

	// RVA: 0x1B2D620 Offset: 0x1B2D721 VA: 0x1B2D620
	public static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation) { }

	// RVA: 0x1B2D6A0 Offset: 0x1B2D7A1 VA: 0x1B2D6A0
	public static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation) { }

	// RVA: 0x1B2D760 Offset: 0x1B2D861 VA: 0x1B2D760
	public static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs) { }

	// RVA: 0x1B2D820 Offset: 0x1B2D921 VA: 0x1B2D820
	private static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs) { }

	// RVA: 0x1B2D8D0 Offset: 0x1B2D9D1 VA: 0x1B2D8D0
	private static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs) { }

	// RVA: 0x1B2D9C0 Offset: 0x1B2DAC1 VA: 0x1B2D9C0
	public static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered) { }

	// RVA: 0x1B2DB20 Offset: 0x1B2DC21 VA: 0x1B2DB20
	public static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered) { }
}

