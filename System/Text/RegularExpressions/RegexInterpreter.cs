// Namespace: System.Text.RegularExpressions
internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 2263
{
	// Fields
	internal int runoperator; // 0x80
	internal int[] runcodes; // 0x88
	internal int runcodepos; // 0x90
	internal string[] runstrings; // 0x98
	internal RegexCode runcode; // 0xA0
	internal RegexPrefix runfcPrefix; // 0xA8
	internal RegexBoyerMoore runbmPrefix; // 0xB0
	internal int runanchors; // 0xB8
	internal bool runrtl; // 0xBC
	internal bool runci; // 0xBD
	internal CultureInfo runculture; // 0xC0

	// Methods

	// RVA: 0x3C017F0 Offset: 0x3C018F1 VA: 0x3C017F0
	internal void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x3C0CAF0 Offset: 0x3C0CBF1 VA: 0x3C0CAF0 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x3C0CB00 Offset: 0x3C0CC01 VA: 0x3C0CB00
	private void Advance() { }

	// RVA: 0x3C0CB60 Offset: 0x3C0CC61 VA: 0x3C0CB60
	private void Advance(int i) { }

	// RVA: 0x3C0CBE0 Offset: 0x3C0CCE1 VA: 0x3C0CBE0
	private void Goto(int newpos) { }

	// RVA: 0x3C0CC60 Offset: 0x3C0CD61 VA: 0x3C0CC60
	private void Textto(int newpos) { }

	// RVA: 0x3C0CC70 Offset: 0x3C0CD71 VA: 0x3C0CC70
	private void Trackto(int newpos) { }

	// RVA: 0x3C0CC90 Offset: 0x3C0CD91 VA: 0x3C0CC90
	private int Textstart() { }

	// RVA: 0x3C0CCA0 Offset: 0x3C0CDA1 VA: 0x3C0CCA0
	private int Textpos() { }

	// RVA: 0x3C0CCB0 Offset: 0x3C0CDB1 VA: 0x3C0CCB0
	private int Trackpos() { }

	// RVA: 0x3C0CCD0 Offset: 0x3C0CDD1 VA: 0x3C0CCD0
	private void TrackPush() { }

	// RVA: 0x3C0CD20 Offset: 0x3C0CE21 VA: 0x3C0CD20
	private void TrackPush(int I1) { }

	// RVA: 0x3C0CD90 Offset: 0x3C0CE91 VA: 0x3C0CD90
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x3C0CE20 Offset: 0x3C0CF21 VA: 0x3C0CE20
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x3C0CED0 Offset: 0x3C0CFD1 VA: 0x3C0CED0
	private void TrackPush2(int I1) { }

	// RVA: 0x3C0CF40 Offset: 0x3C0D041 VA: 0x3C0CF40
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x3C0CFD0 Offset: 0x3C0D0D1 VA: 0x3C0CFD0
	private void Backtrack() { }

	// RVA: 0x3C0CBC0 Offset: 0x3C0CCC1 VA: 0x3C0CBC0
	private void SetOperator(int op) { }

	// RVA: 0x3C0D0B0 Offset: 0x3C0D1B1 VA: 0x3C0D0B0
	private void TrackPop() { }

	// RVA: 0x3C0D0C0 Offset: 0x3C0D1C1 VA: 0x3C0D0C0
	private void TrackPop(int framesize) { }

	// RVA: 0x3C0D0D0 Offset: 0x3C0D1D1 VA: 0x3C0D0D0
	private int TrackPeek() { }

	// RVA: 0x3C0D110 Offset: 0x3C0D211 VA: 0x3C0D110
	private int TrackPeek(int i) { }

	// RVA: 0x3C0D150 Offset: 0x3C0D251 VA: 0x3C0D150
	private void StackPush(int I1) { }

	// RVA: 0x3C0D190 Offset: 0x3C0D291 VA: 0x3C0D190
	private void StackPush(int I1, int I2) { }

	// RVA: 0x3C0D200 Offset: 0x3C0D301 VA: 0x3C0D200
	private void StackPop() { }

	// RVA: 0x3C0D210 Offset: 0x3C0D311 VA: 0x3C0D210
	private void StackPop(int framesize) { }

	// RVA: 0x3C0D220 Offset: 0x3C0D321 VA: 0x3C0D220
	private int StackPeek() { }

	// RVA: 0x3C0D260 Offset: 0x3C0D361 VA: 0x3C0D260
	private int StackPeek(int i) { }

	// RVA: 0x3C0D2A0 Offset: 0x3C0D3A1 VA: 0x3C0D2A0
	private int Operator() { }

	// RVA: 0x3C0D2B0 Offset: 0x3C0D3B1 VA: 0x3C0D2B0
	private int Operand(int i) { }

	// RVA: 0x3C0D2F0 Offset: 0x3C0D3F1 VA: 0x3C0D2F0
	private int Leftchars() { }

	// RVA: 0x3C0D300 Offset: 0x3C0D401 VA: 0x3C0D300
	private int Rightchars() { }

	// RVA: 0x3C0D310 Offset: 0x3C0D411 VA: 0x3C0D310
	private int Bump() { }

	// RVA: 0x3C0D330 Offset: 0x3C0D431 VA: 0x3C0D330
	private int Forwardchars() { }

	// RVA: 0x3C0D360 Offset: 0x3C0D461 VA: 0x3C0D360
	private char Forwardcharnext() { }

	// RVA: 0x3C0D410 Offset: 0x3C0D511 VA: 0x3C0D410
	private bool Stringmatch(string str) { }

	// RVA: 0x3C0D5A0 Offset: 0x3C0D6A1 VA: 0x3C0D5A0
	private bool Refmatch(int index, int len) { }

	// RVA: 0x3C0D740 Offset: 0x3C0D841 VA: 0x3C0D740
	private void Backwardnext() { }

	// RVA: 0x3C0D760 Offset: 0x3C0D861 VA: 0x3C0D760
	private char CharAt(int j) { }

	// RVA: 0x3C0D770 Offset: 0x3C0D871 VA: 0x3C0D770 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x3C0DB50 Offset: 0x3C0DC51 VA: 0x3C0DB50 Slot: 4
	protected override void Go() { }
}

