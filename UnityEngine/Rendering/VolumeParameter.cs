// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3BC10 Offset: 0x3BD11 VA: 0x3BC10
[Serializable]
public class VolumeParameter<T> : VolumeParameter, IEquatable<VolumeParameter<T>> // TypeDefIndex: 4650
{
	// Fields
	[SerializeField] // RVA: 0x3CF50 Offset: 0x3D051 VA: 0x3CF50
	protected T m_Value; // 0x0

	// Properties
	public virtual T value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public virtual T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD7190 Offset: 0x2FD7291 VA: 0x2FD7190
	|-VolumeParameter<AnimationCurve>.get_value
	|-VolumeParameter<Cubemap>.get_value
	|-VolumeParameter<object>.get_value
	|-VolumeParameter<RenderTexture>.get_value
	|-VolumeParameter<Texture>.get_value
	|-VolumeParameter<TextureCurve>.get_value
	|
	|-RVA: 0x2FD4F90 Offset: 0x2FD5091 VA: 0x2FD4F90
	|-VolumeParameter<bool>.get_value
	|
	|-RVA: 0x2FD5600 Offset: 0x2FD5701 VA: 0x2FD5600
	|-VolumeParameter<Color>.get_value
	|
	|-RVA: 0x2FD63D0 Offset: 0x2FD64D1 VA: 0x2FD63D0
	|-VolumeParameter<DepthOfFieldMode>.get_value
	|-VolumeParameter<FilmGrainLookup>.get_value
	|-VolumeParameter<Int32Enum>.get_value
	|-VolumeParameter<MotionBlurMode>.get_value
	|-VolumeParameter<MotionBlurQuality>.get_value
	|-VolumeParameter<TonemappingMode>.get_value
	|
	|-RVA: 0x2FD5D90 Offset: 0x2FD5E91 VA: 0x2FD5D90
	|-VolumeParameter<int>.get_value
	|
	|-RVA: 0x2FD6A90 Offset: 0x2FD6B91 VA: 0x2FD6A90
	|-VolumeParameter<LayerMask>.get_value
	|
	|-RVA: 0x2FD7780 Offset: 0x2FD7881 VA: 0x2FD7780
	|-VolumeParameter<float>.get_value
	|
	|-RVA: 0x2FD7DD0 Offset: 0x2FD7ED1 VA: 0x2FD7DD0
	|-VolumeParameter<Vector2>.get_value
	|
	|-RVA: 0x2FD8460 Offset: 0x2FD8561 VA: 0x2FD8460
	|-VolumeParameter<Vector3>.get_value
	|
	|-RVA: 0x2FD8B90 Offset: 0x2FD8C91 VA: 0x2FD8B90
	|-VolumeParameter<Vector4>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void set_value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD71A0 Offset: 0x2FD72A1 VA: 0x2FD71A0
	|-VolumeParameter<AnimationCurve>.set_value
	|-VolumeParameter<Cubemap>.set_value
	|-VolumeParameter<object>.set_value
	|-VolumeParameter<RenderTexture>.set_value
	|-VolumeParameter<Texture>.set_value
	|-VolumeParameter<TextureCurve>.set_value
	|
	|-RVA: 0x2FD4FA0 Offset: 0x2FD50A1 VA: 0x2FD4FA0
	|-VolumeParameter<bool>.set_value
	|
	|-RVA: 0x2FD5610 Offset: 0x2FD5711 VA: 0x2FD5610
	|-VolumeParameter<Color>.set_value
	|
	|-RVA: 0x2FD63E0 Offset: 0x2FD64E1 VA: 0x2FD63E0
	|-VolumeParameter<DepthOfFieldMode>.set_value
	|-VolumeParameter<FilmGrainLookup>.set_value
	|-VolumeParameter<Int32Enum>.set_value
	|-VolumeParameter<MotionBlurMode>.set_value
	|-VolumeParameter<MotionBlurQuality>.set_value
	|-VolumeParameter<TonemappingMode>.set_value
	|
	|-RVA: 0x2FD5DA0 Offset: 0x2FD5EA1 VA: 0x2FD5DA0
	|-VolumeParameter<int>.set_value
	|
	|-RVA: 0x2FD6AA0 Offset: 0x2FD6BA1 VA: 0x2FD6AA0
	|-VolumeParameter<LayerMask>.set_value
	|
	|-RVA: 0x2FD7790 Offset: 0x2FD7891 VA: 0x2FD7790
	|-VolumeParameter<float>.set_value
	|
	|-RVA: 0x2FD7DE0 Offset: 0x2FD7EE1 VA: 0x2FD7DE0
	|-VolumeParameter<Vector2>.set_value
	|
	|-RVA: 0x2FD8470 Offset: 0x2FD8571 VA: 0x2FD8470
	|-VolumeParameter<Vector3>.set_value
	|
	|-RVA: 0x2FD8BA0 Offset: 0x2FD8CA1 VA: 0x2FD8BA0
	|-VolumeParameter<Vector4>.set_value
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4FB0 Offset: 0x2FD50B1 VA: 0x2FD4FB0
	|-VolumeParameter<bool>..ctor
	|
	|-RVA: 0x2FD5630 Offset: 0x2FD5731 VA: 0x2FD5630
	|-VolumeParameter<Color>..ctor
	|
	|-RVA: 0x2FD5DB0 Offset: 0x2FD5EB1 VA: 0x2FD5DB0
	|-VolumeParameter<int>..ctor
	|
	|-RVA: 0x2FD63F0 Offset: 0x2FD64F1 VA: 0x2FD63F0
	|-VolumeParameter<Int32Enum>..ctor
	|
	|-RVA: 0x2FD6AB0 Offset: 0x2FD6BB1 VA: 0x2FD6AB0
	|-VolumeParameter<LayerMask>..ctor
	|
	|-RVA: 0x2FD71B0 Offset: 0x2FD72B1 VA: 0x2FD71B0
	|-VolumeParameter<object>..ctor
	|
	|-RVA: 0x2FD77A0 Offset: 0x2FD78A1 VA: 0x2FD77A0
	|-VolumeParameter<float>..ctor
	|
	|-RVA: 0x2FD7DF0 Offset: 0x2FD7EF1 VA: 0x2FD7DF0
	|-VolumeParameter<Vector2>..ctor
	|
	|-RVA: 0x2FD8480 Offset: 0x2FD8581 VA: 0x2FD8480
	|-VolumeParameter<Vector3>..ctor
	|
	|-RVA: 0x2FD8BC0 Offset: 0x2FD8CC1 VA: 0x2FD8BC0
	|-VolumeParameter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(T value, bool overrideState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD71D0 Offset: 0x2FD72D1 VA: 0x2FD71D0
	|-VolumeParameter<AnimationCurve>..ctor
	|-VolumeParameter<Cubemap>..ctor
	|-VolumeParameter<object>..ctor
	|-VolumeParameter<RenderTexture>..ctor
	|-VolumeParameter<Texture>..ctor
	|-VolumeParameter<TextureCurve>..ctor
	|
	|-RVA: 0x2FD4FD0 Offset: 0x2FD50D1 VA: 0x2FD4FD0
	|-VolumeParameter<bool>..ctor
	|
	|-RVA: 0x2FD5660 Offset: 0x2FD5761 VA: 0x2FD5660
	|-VolumeParameter<Color>..ctor
	|
	|-RVA: 0x2FD6410 Offset: 0x2FD6511 VA: 0x2FD6410
	|-VolumeParameter<DepthOfFieldMode>..ctor
	|-VolumeParameter<FilmGrainLookup>..ctor
	|-VolumeParameter<Int32Enum>..ctor
	|-VolumeParameter<MotionBlurMode>..ctor
	|-VolumeParameter<MotionBlurQuality>..ctor
	|-VolumeParameter<TonemappingMode>..ctor
	|
	|-RVA: 0x2FD5DD0 Offset: 0x2FD5ED1 VA: 0x2FD5DD0
	|-VolumeParameter<int>..ctor
	|
	|-RVA: 0x2FD6AD0 Offset: 0x2FD6BD1 VA: 0x2FD6AD0
	|-VolumeParameter<LayerMask>..ctor
	|
	|-RVA: 0x2FD77C0 Offset: 0x2FD78C1 VA: 0x2FD77C0
	|-VolumeParameter<float>..ctor
	|
	|-RVA: 0x2FD7E10 Offset: 0x2FD7F11 VA: 0x2FD7E10
	|-VolumeParameter<Vector2>..ctor
	|
	|-RVA: 0x2FD84B0 Offset: 0x2FD85B1 VA: 0x2FD84B0
	|-VolumeParameter<Vector3>..ctor
	|
	|-RVA: 0x2FD8BF0 Offset: 0x2FD8CF1 VA: 0x2FD8BF0
	|-VolumeParameter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override void Interp(VolumeParameter from, VolumeParameter to, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD7230 Offset: 0x2FD7331 VA: 0x2FD7230
	|-VolumeParameter<AnimationCurve>.Interp
	|-VolumeParameter<Cubemap>.Interp
	|-VolumeParameter<object>.Interp
	|-VolumeParameter<RenderTexture>.Interp
	|-VolumeParameter<Texture>.Interp
	|-VolumeParameter<TextureCurve>.Interp
	|
	|-RVA: 0x2FD5020 Offset: 0x2FD5121 VA: 0x2FD5020
	|-VolumeParameter<bool>.Interp
	|
	|-RVA: 0x2FD56D0 Offset: 0x2FD57D1 VA: 0x2FD56D0
	|-VolumeParameter<Color>.Interp
	|
	|-RVA: 0x2FD6460 Offset: 0x2FD6561 VA: 0x2FD6460
	|-VolumeParameter<DepthOfFieldMode>.Interp
	|-VolumeParameter<FilmGrainLookup>.Interp
	|-VolumeParameter<Int32Enum>.Interp
	|-VolumeParameter<MotionBlurMode>.Interp
	|-VolumeParameter<MotionBlurQuality>.Interp
	|-VolumeParameter<TonemappingMode>.Interp
	|
	|-RVA: 0x2FD5E20 Offset: 0x2FD5F21 VA: 0x2FD5E20
	|-VolumeParameter<int>.Interp
	|
	|-RVA: 0x2FD6B20 Offset: 0x2FD6C21 VA: 0x2FD6B20
	|-VolumeParameter<LayerMask>.Interp
	|
	|-RVA: 0x2FD7810 Offset: 0x2FD7911 VA: 0x2FD7810
	|-VolumeParameter<float>.Interp
	|
	|-RVA: 0x2FD7E60 Offset: 0x2FD7F61 VA: 0x2FD7E60
	|-VolumeParameter<Vector2>.Interp
	|
	|-RVA: 0x2FD8510 Offset: 0x2FD8611 VA: 0x2FD8510
	|-VolumeParameter<Vector3>.Interp
	|
	|-RVA: 0x2FD8C60 Offset: 0x2FD8D61 VA: 0x2FD8C60
	|-VolumeParameter<Vector4>.Interp
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void Interp(T from, T to, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD72C0 Offset: 0x2FD73C1 VA: 0x2FD72C0
	|-VolumeParameter<AnimationCurve>.Interp
	|-VolumeParameter<Cubemap>.Interp
	|-VolumeParameter<object>.Interp
	|-VolumeParameter<RenderTexture>.Interp
	|-VolumeParameter<Texture>.Interp
	|-VolumeParameter<TextureCurve>.Interp
	|
	|-RVA: 0x2FD50B0 Offset: 0x2FD51B1 VA: 0x2FD50B0
	|-VolumeParameter<bool>.Interp
	|
	|-RVA: 0x2FD57A0 Offset: 0x2FD58A1 VA: 0x2FD57A0
	|-VolumeParameter<Color>.Interp
	|
	|-RVA: 0x2FD64F0 Offset: 0x2FD65F1 VA: 0x2FD64F0
	|-VolumeParameter<DepthOfFieldMode>.Interp
	|-VolumeParameter<FilmGrainLookup>.Interp
	|-VolumeParameter<Int32Enum>.Interp
	|-VolumeParameter<MotionBlurMode>.Interp
	|-VolumeParameter<MotionBlurQuality>.Interp
	|-VolumeParameter<TonemappingMode>.Interp
	|
	|-RVA: 0x2FD5EB0 Offset: 0x2FD5FB1 VA: 0x2FD5EB0
	|-VolumeParameter<int>.Interp
	|
	|-RVA: 0x2FD6BB0 Offset: 0x2FD6CB1 VA: 0x2FD6BB0
	|-VolumeParameter<LayerMask>.Interp
	|
	|-RVA: 0x2FD78A0 Offset: 0x2FD79A1 VA: 0x2FD78A0
	|-VolumeParameter<float>.Interp
	|
	|-RVA: 0x2FD7F00 Offset: 0x2FD8001 VA: 0x2FD7F00
	|-VolumeParameter<Vector2>.Interp
	|
	|-RVA: 0x2FD85C0 Offset: 0x2FD86C1 VA: 0x2FD85C0
	|-VolumeParameter<Vector3>.Interp
	|
	|-RVA: 0x2FD8D30 Offset: 0x2FD8E31 VA: 0x2FD8D30
	|-VolumeParameter<Vector4>.Interp
	*/

	// RVA: -1 Offset: -1
	public void Override(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD50D0 Offset: 0x2FD51D1 VA: 0x2FD50D0
	|-VolumeParameter<bool>.Override
	|
	|-RVA: 0x2FD57D0 Offset: 0x2FD58D1 VA: 0x2FD57D0
	|-VolumeParameter<Color>.Override
	|
	|-RVA: 0x2FD5EC0 Offset: 0x2FD5FC1 VA: 0x2FD5EC0
	|-VolumeParameter<int>.Override
	|
	|-RVA: 0x2FD6500 Offset: 0x2FD6601 VA: 0x2FD6500
	|-VolumeParameter<Int32Enum>.Override
	|
	|-RVA: 0x2FD6BC0 Offset: 0x2FD6CC1 VA: 0x2FD6BC0
	|-VolumeParameter<LayerMask>.Override
	|
	|-RVA: 0x2FD72D0 Offset: 0x2FD73D1 VA: 0x2FD72D0
	|-VolumeParameter<object>.Override
	|
	|-RVA: 0x2FD78B0 Offset: 0x2FD79B1 VA: 0x2FD78B0
	|-VolumeParameter<float>.Override
	|
	|-RVA: 0x2FD7F20 Offset: 0x2FD8021 VA: 0x2FD7F20
	|-VolumeParameter<Vector2>.Override
	|
	|-RVA: 0x2FD85E0 Offset: 0x2FD86E1 VA: 0x2FD85E0
	|-VolumeParameter<Vector3>.Override
	|
	|-RVA: 0x2FD8D60 Offset: 0x2FD8E61 VA: 0x2FD8D60
	|-VolumeParameter<Vector4>.Override
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void SetValue(VolumeParameter parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD7310 Offset: 0x2FD7411 VA: 0x2FD7310
	|-VolumeParameter<AnimationCurve>.SetValue
	|-VolumeParameter<Cubemap>.SetValue
	|-VolumeParameter<object>.SetValue
	|-VolumeParameter<RenderTexture>.SetValue
	|-VolumeParameter<Texture>.SetValue
	|-VolumeParameter<TextureCurve>.SetValue
	|
	|-RVA: 0x2FD5110 Offset: 0x2FD5211 VA: 0x2FD5110
	|-VolumeParameter<bool>.SetValue
	|
	|-RVA: 0x2FD5830 Offset: 0x2FD5931 VA: 0x2FD5830
	|-VolumeParameter<Color>.SetValue
	|
	|-RVA: 0x2FD6540 Offset: 0x2FD6641 VA: 0x2FD6540
	|-VolumeParameter<DepthOfFieldMode>.SetValue
	|-VolumeParameter<FilmGrainLookup>.SetValue
	|-VolumeParameter<Int32Enum>.SetValue
	|-VolumeParameter<MotionBlurMode>.SetValue
	|-VolumeParameter<MotionBlurQuality>.SetValue
	|-VolumeParameter<TonemappingMode>.SetValue
	|
	|-RVA: 0x2FD5F00 Offset: 0x2FD6001 VA: 0x2FD5F00
	|-VolumeParameter<int>.SetValue
	|
	|-RVA: 0x2FD6C00 Offset: 0x2FD6D01 VA: 0x2FD6C00
	|-VolumeParameter<LayerMask>.SetValue
	|
	|-RVA: 0x2FD78F0 Offset: 0x2FD79F1 VA: 0x2FD78F0
	|-VolumeParameter<float>.SetValue
	|
	|-RVA: 0x2FD7F70 Offset: 0x2FD8071 VA: 0x2FD7F70
	|-VolumeParameter<Vector2>.SetValue
	|
	|-RVA: 0x2FD8640 Offset: 0x2FD8741 VA: 0x2FD8640
	|-VolumeParameter<Vector3>.SetValue
	|
	|-RVA: 0x2FD8DC0 Offset: 0x2FD8EC1 VA: 0x2FD8DC0
	|-VolumeParameter<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD7360 Offset: 0x2FD7461 VA: 0x2FD7360
	|-VolumeParameter<AnimationCurve>.GetHashCode
	|-VolumeParameter<Cubemap>.GetHashCode
	|-VolumeParameter<object>.GetHashCode
	|-VolumeParameter<RenderTexture>.GetHashCode
	|-VolumeParameter<Texture>.GetHashCode
	|-VolumeParameter<TextureCurve>.GetHashCode
	|
	|-RVA: 0x2FD5150 Offset: 0x2FD5251 VA: 0x2FD5150
	|-VolumeParameter<bool>.GetHashCode
	|
	|-RVA: 0x2FD5880 Offset: 0x2FD5981 VA: 0x2FD5880
	|-VolumeParameter<Color>.GetHashCode
	|
	|-RVA: 0x2FD6580 Offset: 0x2FD6681 VA: 0x2FD6580
	|-VolumeParameter<DepthOfFieldMode>.GetHashCode
	|-VolumeParameter<FilmGrainLookup>.GetHashCode
	|-VolumeParameter<Int32Enum>.GetHashCode
	|-VolumeParameter<MotionBlurMode>.GetHashCode
	|-VolumeParameter<MotionBlurQuality>.GetHashCode
	|-VolumeParameter<TonemappingMode>.GetHashCode
	|
	|-RVA: 0x2FD5F40 Offset: 0x2FD6041 VA: 0x2FD5F40
	|-VolumeParameter<int>.GetHashCode
	|
	|-RVA: 0x2FD6C40 Offset: 0x2FD6D41 VA: 0x2FD6C40
	|-VolumeParameter<LayerMask>.GetHashCode
	|
	|-RVA: 0x2FD7930 Offset: 0x2FD7A31 VA: 0x2FD7930
	|-VolumeParameter<float>.GetHashCode
	|
	|-RVA: 0x2FD7FB0 Offset: 0x2FD80B1 VA: 0x2FD7FB0
	|-VolumeParameter<Vector2>.GetHashCode
	|
	|-RVA: 0x2FD8690 Offset: 0x2FD8791 VA: 0x2FD8690
	|-VolumeParameter<Vector3>.GetHashCode
	|
	|-RVA: 0x2FD8E10 Offset: 0x2FD8F11 VA: 0x2FD8E10
	|-VolumeParameter<Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD7420 Offset: 0x2FD7521 VA: 0x2FD7420
	|-VolumeParameter<AnimationCurve>.ToString
	|-VolumeParameter<Cubemap>.ToString
	|-VolumeParameter<object>.ToString
	|-VolumeParameter<RenderTexture>.ToString
	|-VolumeParameter<Texture>.ToString
	|-VolumeParameter<TextureCurve>.ToString
	|
	|-RVA: 0x2FD5220 Offset: 0x2FD5321 VA: 0x2FD5220
	|-VolumeParameter<bool>.ToString
	|
	|-RVA: 0x2FD5960 Offset: 0x2FD5A61 VA: 0x2FD5960
	|-VolumeParameter<Color>.ToString
	|
	|-RVA: 0x2FD6670 Offset: 0x2FD6771 VA: 0x2FD6670
	|-VolumeParameter<DepthOfFieldMode>.ToString
	|-VolumeParameter<FilmGrainLookup>.ToString
	|-VolumeParameter<Int32Enum>.ToString
	|-VolumeParameter<MotionBlurMode>.ToString
	|-VolumeParameter<MotionBlurQuality>.ToString
	|-VolumeParameter<TonemappingMode>.ToString
	|
	|-RVA: 0x2FD6000 Offset: 0x2FD6101 VA: 0x2FD6000
	|-VolumeParameter<int>.ToString
	|
	|-RVA: 0x2FD6D50 Offset: 0x2FD6E51 VA: 0x2FD6D50
	|-VolumeParameter<LayerMask>.ToString
	|
	|-RVA: 0x2FD79F0 Offset: 0x2FD7AF1 VA: 0x2FD79F0
	|-VolumeParameter<float>.ToString
	|
	|-RVA: 0x2FD8080 Offset: 0x2FD8181 VA: 0x2FD8080
	|-VolumeParameter<Vector2>.ToString
	|
	|-RVA: 0x2FD8770 Offset: 0x2FD8871 VA: 0x2FD8770
	|-VolumeParameter<Vector3>.ToString
	|
	|-RVA: 0x2FD8EF0 Offset: 0x2FD8FF1 VA: 0x2FD8EF0
	|-VolumeParameter<Vector4>.ToString
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(VolumeParameter<T> lhs, T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD5310 Offset: 0x2FD5411 VA: 0x2FD5310
	|-VolumeParameter<bool>.op_Equality
	|
	|-RVA: 0x2FD5A50 Offset: 0x2FD5B51 VA: 0x2FD5A50
	|-VolumeParameter<Color>.op_Equality
	|
	|-RVA: 0x2FD60F0 Offset: 0x2FD61F1 VA: 0x2FD60F0
	|-VolumeParameter<int>.op_Equality
	|
	|-RVA: 0x2FD6760 Offset: 0x2FD6861 VA: 0x2FD6760
	|-VolumeParameter<Int32Enum>.op_Equality
	|-VolumeParameter<MotionBlurMode>.op_Equality
	|
	|-RVA: 0x2FD6E40 Offset: 0x2FD6F41 VA: 0x2FD6E40
	|-VolumeParameter<LayerMask>.op_Equality
	|
	|-RVA: 0x2FD74E0 Offset: 0x2FD75E1 VA: 0x2FD74E0
	|-VolumeParameter<object>.op_Equality
	|
	|-RVA: 0x2FD7AE0 Offset: 0x2FD7BE1 VA: 0x2FD7AE0
	|-VolumeParameter<float>.op_Equality
	|
	|-RVA: 0x2FD8170 Offset: 0x2FD8271 VA: 0x2FD8170
	|-VolumeParameter<Vector2>.op_Equality
	|
	|-RVA: 0x2FD8860 Offset: 0x2FD8961 VA: 0x2FD8860
	|-VolumeParameter<Vector3>.op_Equality
	|
	|-RVA: 0x2FD8FE0 Offset: 0x2FD90E1 VA: 0x2FD8FE0
	|-VolumeParameter<Vector4>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(VolumeParameter<T> lhs, T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD53C0 Offset: 0x2FD54C1 VA: 0x2FD53C0
	|-VolumeParameter<bool>.op_Inequality
	|
	|-RVA: 0x2FD5B20 Offset: 0x2FD5C21 VA: 0x2FD5B20
	|-VolumeParameter<Color>.op_Inequality
	|
	|-RVA: 0x2FD6190 Offset: 0x2FD6291 VA: 0x2FD6190
	|-VolumeParameter<int>.op_Inequality
	|
	|-RVA: 0x2FD6850 Offset: 0x2FD6951 VA: 0x2FD6850
	|-VolumeParameter<Int32Enum>.op_Inequality
	|
	|-RVA: 0x2FD6F50 Offset: 0x2FD7051 VA: 0x2FD6F50
	|-VolumeParameter<LayerMask>.op_Inequality
	|
	|-RVA: 0x2FD7540 Offset: 0x2FD7641 VA: 0x2FD7540
	|-VolumeParameter<object>.op_Inequality
	|
	|-RVA: 0x2FD7B90 Offset: 0x2FD7C91 VA: 0x2FD7B90
	|-VolumeParameter<float>.op_Inequality
	|
	|-RVA: 0x2FD8220 Offset: 0x2FD8321 VA: 0x2FD8220
	|-VolumeParameter<Vector2>.op_Inequality
	|
	|-RVA: 0x2FD8930 Offset: 0x2FD8A31 VA: 0x2FD8930
	|-VolumeParameter<Vector3>.op_Inequality
	|
	|-RVA: 0x2FD90B0 Offset: 0x2FD91B1 VA: 0x2FD90B0
	|-VolumeParameter<Vector4>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool Equals(VolumeParameter<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD75D0 Offset: 0x2FD76D1 VA: 0x2FD75D0
	|-VolumeParameter<AnimationCurve>.Equals
	|-VolumeParameter<Cubemap>.Equals
	|-VolumeParameter<object>.Equals
	|-VolumeParameter<RenderTexture>.Equals
	|-VolumeParameter<Texture>.Equals
	|-VolumeParameter<TextureCurve>.Equals
	|
	|-RVA: 0x2FD5450 Offset: 0x2FD5551 VA: 0x2FD5450
	|-VolumeParameter<bool>.Equals
	|
	|-RVA: 0x2FD5BD0 Offset: 0x2FD5CD1 VA: 0x2FD5BD0
	|-VolumeParameter<Color>.Equals
	|
	|-RVA: 0x2FD68E0 Offset: 0x2FD69E1 VA: 0x2FD68E0
	|-VolumeParameter<DepthOfFieldMode>.Equals
	|-VolumeParameter<FilmGrainLookup>.Equals
	|-VolumeParameter<Int32Enum>.Equals
	|-VolumeParameter<MotionBlurMode>.Equals
	|-VolumeParameter<MotionBlurQuality>.Equals
	|-VolumeParameter<TonemappingMode>.Equals
	|
	|-RVA: 0x2FD6220 Offset: 0x2FD6321 VA: 0x2FD6220
	|-VolumeParameter<int>.Equals
	|
	|-RVA: 0x2FD6FE0 Offset: 0x2FD70E1 VA: 0x2FD6FE0
	|-VolumeParameter<LayerMask>.Equals
	|
	|-RVA: 0x2FD7C20 Offset: 0x2FD7D21 VA: 0x2FD7C20
	|-VolumeParameter<float>.Equals
	|
	|-RVA: 0x2FD82B0 Offset: 0x2FD83B1 VA: 0x2FD82B0
	|-VolumeParameter<Vector2>.Equals
	|
	|-RVA: 0x2FD89D0 Offset: 0x2FD8AD1 VA: 0x2FD89D0
	|-VolumeParameter<Vector3>.Equals
	|
	|-RVA: 0x2FD9160 Offset: 0x2FD9261 VA: 0x2FD9160
	|-VolumeParameter<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD7640 Offset: 0x2FD7741 VA: 0x2FD7640
	|-VolumeParameter<AnimationCurve>.Equals
	|-VolumeParameter<Cubemap>.Equals
	|-VolumeParameter<object>.Equals
	|-VolumeParameter<RenderTexture>.Equals
	|-VolumeParameter<Texture>.Equals
	|-VolumeParameter<TextureCurve>.Equals
	|
	|-RVA: 0x2FD54C0 Offset: 0x2FD55C1 VA: 0x2FD54C0
	|-VolumeParameter<bool>.Equals
	|
	|-RVA: 0x2FD5C50 Offset: 0x2FD5D51 VA: 0x2FD5C50
	|-VolumeParameter<Color>.Equals
	|
	|-RVA: 0x2FD6950 Offset: 0x2FD6A51 VA: 0x2FD6950
	|-VolumeParameter<DepthOfFieldMode>.Equals
	|-VolumeParameter<FilmGrainLookup>.Equals
	|-VolumeParameter<Int32Enum>.Equals
	|-VolumeParameter<MotionBlurMode>.Equals
	|-VolumeParameter<MotionBlurQuality>.Equals
	|-VolumeParameter<TonemappingMode>.Equals
	|
	|-RVA: 0x2FD6290 Offset: 0x2FD6391 VA: 0x2FD6290
	|-VolumeParameter<int>.Equals
	|
	|-RVA: 0x2FD7050 Offset: 0x2FD7151 VA: 0x2FD7050
	|-VolumeParameter<LayerMask>.Equals
	|
	|-RVA: 0x2FD7C90 Offset: 0x2FD7D91 VA: 0x2FD7C90
	|-VolumeParameter<float>.Equals
	|
	|-RVA: 0x2FD8320 Offset: 0x2FD8421 VA: 0x2FD8320
	|-VolumeParameter<Vector2>.Equals
	|
	|-RVA: 0x2FD8A50 Offset: 0x2FD8B51 VA: 0x2FD8A50
	|-VolumeParameter<Vector3>.Equals
	|
	|-RVA: 0x2FD91E0 Offset: 0x2FD92E1 VA: 0x2FD91E0
	|-VolumeParameter<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1
	public static T op_Explicit(VolumeParameter<T> prop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD55F0 Offset: 0x2FD56F1 VA: 0x2FD55F0
	|-VolumeParameter<bool>.op_Explicit
	|
	|-RVA: 0x2FD5D80 Offset: 0x2FD5E81 VA: 0x2FD5D80
	|-VolumeParameter<Color>.op_Explicit
	|
	|-RVA: 0x2FD63C0 Offset: 0x2FD64C1 VA: 0x2FD63C0
	|-VolumeParameter<int>.op_Explicit
	|
	|-RVA: 0x2FD6A80 Offset: 0x2FD6B81 VA: 0x2FD6A80
	|-VolumeParameter<Int32Enum>.op_Explicit
	|
	|-RVA: 0x2FD7180 Offset: 0x2FD7281 VA: 0x2FD7180
	|-VolumeParameter<LayerMask>.op_Explicit
	|
	|-RVA: 0x2FD7770 Offset: 0x2FD7871 VA: 0x2FD7770
	|-VolumeParameter<object>.op_Explicit
	|
	|-RVA: 0x2FD7DC0 Offset: 0x2FD7EC1 VA: 0x2FD7DC0
	|-VolumeParameter<float>.op_Explicit
	|
	|-RVA: 0x2FD8450 Offset: 0x2FD8551 VA: 0x2FD8450
	|-VolumeParameter<Vector2>.op_Explicit
	|
	|-RVA: 0x2FD8B80 Offset: 0x2FD8C81 VA: 0x2FD8B80
	|-VolumeParameter<Vector3>.op_Explicit
	|
	|-RVA: 0x2FD9310 Offset: 0x2FD9411 VA: 0x2FD9310
	|-VolumeParameter<Vector4>.op_Explicit
	*/
}

