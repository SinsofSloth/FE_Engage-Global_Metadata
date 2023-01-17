// Namespace: App
public abstract class Interpolator<T> : InterpolatorTime // TypeDefIndex: 9183
{
	// Fields
	protected T m_Prev; // 0x0
	protected T m_Next; // 0x0

	// Properties
	public virtual T Value { get; }
	public T Prev { get; set; }
	public T Next { get; set; }
	public T Goal { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(Curve.Type type, int num) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D879B0 Offset: 0x2D87AB1 VA: 0x2D879B0
	|-Interpolator<Color>..ctor
	|
	|-RVA: 0x2D87BA0 Offset: 0x2D87CA1 VA: 0x2D87BA0
	|-Interpolator<int>..ctor
	|
	|-RVA: 0x2D87CF0 Offset: 0x2D87DF1 VA: 0x2D87CF0
	|-Interpolator<float>..ctor
	|
	|-RVA: 0x2D87E40 Offset: 0x2D87F41 VA: 0x2D87E40
	|-Interpolator<Vector2>..ctor
	|
	|-RVA: 0x2D87FD0 Offset: 0x2D880D1 VA: 0x2D87FD0
	|-Interpolator<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D879C0 Offset: 0x2D87AC1 VA: 0x2D879C0
	|-Interpolator<Color>.get_Value
	|
	|-RVA: 0x2D87BB0 Offset: 0x2D87CB1 VA: 0x2D87BB0
	|-Interpolator<int>.get_Value
	|
	|-RVA: 0x2D87D00 Offset: 0x2D87E01 VA: 0x2D87D00
	|-Interpolator<float>.get_Value
	|
	|-RVA: 0x2D87E50 Offset: 0x2D87F51 VA: 0x2D87E50
	|-Interpolator<Vector2>.get_Value
	|
	|-RVA: 0x2D87FE0 Offset: 0x2D880E1 VA: 0x2D87FE0
	|-Interpolator<Vector3>.get_Value
	*/

	// RVA: -1 Offset: -1
	public T get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D879E0 Offset: 0x2D87AE1 VA: 0x2D879E0
	|-Interpolator<Color>.get_Prev
	|
	|-RVA: 0x2D87BC0 Offset: 0x2D87CC1 VA: 0x2D87BC0
	|-Interpolator<int>.get_Prev
	|
	|-RVA: 0x2D87D10 Offset: 0x2D87E11 VA: 0x2D87D10
	|-Interpolator<float>.get_Prev
	|
	|-RVA: 0x2D87E60 Offset: 0x2D87F61 VA: 0x2D87E60
	|-Interpolator<Vector2>.get_Prev
	|
	|-RVA: 0x2D87FF0 Offset: 0x2D880F1 VA: 0x2D87FF0
	|-Interpolator<Vector3>.get_Prev
	*/

	// RVA: -1 Offset: -1
	public void set_Prev(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D879F0 Offset: 0x2D87AF1 VA: 0x2D879F0
	|-Interpolator<Color>.set_Prev
	|
	|-RVA: 0x2D87BD0 Offset: 0x2D87CD1 VA: 0x2D87BD0
	|-Interpolator<int>.set_Prev
	|
	|-RVA: 0x2D87D20 Offset: 0x2D87E21 VA: 0x2D87D20
	|-Interpolator<float>.set_Prev
	|
	|-RVA: 0x2D87E70 Offset: 0x2D87F71 VA: 0x2D87E70
	|-Interpolator<Vector2>.set_Prev
	|
	|-RVA: 0x2D88000 Offset: 0x2D88101 VA: 0x2D88000
	|-Interpolator<Vector3>.set_Prev
	*/

	// RVA: -1 Offset: -1
	public T get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D87A10 Offset: 0x2D87B11 VA: 0x2D87A10
	|-Interpolator<Color>.get_Next
	|
	|-RVA: 0x2D87BE0 Offset: 0x2D87CE1 VA: 0x2D87BE0
	|-Interpolator<int>.get_Next
	|
	|-RVA: 0x2D87D30 Offset: 0x2D87E31 VA: 0x2D87D30
	|-Interpolator<float>.get_Next
	|
	|-RVA: 0x2D87E80 Offset: 0x2D87F81 VA: 0x2D87E80
	|-Interpolator<Vector2>.get_Next
	|
	|-RVA: 0x2D88010 Offset: 0x2D88111 VA: 0x2D88010
	|-Interpolator<Vector3>.get_Next
	*/

	// RVA: -1 Offset: -1
	public void set_Next(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D87A20 Offset: 0x2D87B21 VA: 0x2D87A20
	|-Interpolator<Color>.set_Next
	|
	|-RVA: 0x2D87BF0 Offset: 0x2D87CF1 VA: 0x2D87BF0
	|-Interpolator<int>.set_Next
	|
	|-RVA: 0x2D87D40 Offset: 0x2D87E41 VA: 0x2D87D40
	|-Interpolator<float>.set_Next
	|
	|-RVA: 0x2D87E90 Offset: 0x2D87F91 VA: 0x2D87E90
	|-Interpolator<Vector2>.set_Next
	|
	|-RVA: 0x2D88020 Offset: 0x2D88121 VA: 0x2D88020
	|-Interpolator<Vector3>.set_Next
	*/

	// RVA: -1 Offset: -1
	public T get_Goal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D87A40 Offset: 0x2D87B41 VA: 0x2D87A40
	|-Interpolator<Color>.get_Goal
	|
	|-RVA: 0x2D87C00 Offset: 0x2D87D01 VA: 0x2D87C00
	|-Interpolator<int>.get_Goal
	|
	|-RVA: 0x2D87D50 Offset: 0x2D87E51 VA: 0x2D87D50
	|-Interpolator<float>.get_Goal
	|
	|-RVA: 0x2D87EA0 Offset: 0x2D87FA1 VA: 0x2D87EA0
	|-Interpolator<Vector2>.get_Goal
	|
	|-RVA: 0x2D88030 Offset: 0x2D88131 VA: 0x2D88030
	|-Interpolator<Vector3>.get_Goal
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool IsEqual(T a, T b);

	// RVA: -1 Offset: -1 Slot: 6
	public virtual bool Set(T value, float time = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D87A80 Offset: 0x2D87B81 VA: 0x2D87A80
	|-Interpolator<Color>.Set
	|
	|-RVA: 0x2D87C20 Offset: 0x2D87D21 VA: 0x2D87C20
	|-Interpolator<int>.Set
	|
	|-RVA: 0x2D87D70 Offset: 0x2D87E71 VA: 0x2D87D70
	|-Interpolator<float>.Set
	|
	|-RVA: 0x2D87EE0 Offset: 0x2D87FE1 VA: 0x2D87EE0
	|-Interpolator<Vector2>.Set
	|
	|-RVA: 0x2D88070 Offset: 0x2D88171 VA: 0x2D88070
	|-Interpolator<Vector3>.Set
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(Interpolator<T> v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D87B90 Offset: 0x2D87C91 VA: 0x2D87B90
	|-Interpolator<Color>.op_Implicit
	|
	|-RVA: 0x2D87CE0 Offset: 0x2D87DE1 VA: 0x2D87CE0
	|-Interpolator<int>.op_Implicit
	|
	|-RVA: 0x2D87E30 Offset: 0x2D87F31 VA: 0x2D87E30
	|-Interpolator<float>.op_Implicit
	|
	|-RVA: 0x2D87FC0 Offset: 0x2D880C1 VA: 0x2D87FC0
	|-Interpolator<Vector2>.op_Implicit
	|
	|-RVA: 0x2D88160 Offset: 0x2D88261 VA: 0x2D88160
	|-Interpolator<Vector3>.op_Implicit
	*/
}

