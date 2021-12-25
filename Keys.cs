namespace KeyPresser
{
	public enum Keys
	{
		None = 0,
		//
		// Description:
		//     The left mouse button.
		LButton = 1,
		//
		// Description:
		//     The right mouse button.
		RButton = 2,
		//
		// Description:
		//     The CANCEL key.
		Cancel = 3,
		//
		// Description:
		//     The middle mouse button (three-button mouse).
		MButton = 4,
		//
		// Description:
		//     The first x mouse button (five-button mouse).
		XButton1 = 5,
		//
		// Description:
		//     The second x mouse button (five-button mouse).
		XButton2 = 6,
		//
		// Description:
		//     The BACKSPACE key.
		Back = 8,
		//
		// Description:
		//     The TAB key.
		Tab = 9,
		//
		// Description:
		//     The LINEFEED key.
		LineFeed = 10,
		//
		// Description:
		//     The CLEAR key.
		Clear = 12,
		//
		// Description:
		//     The RETURN key.
		Return = 13,
		//
		// Description:
		//     The ENTER key.
		Enter = 13,
		//
		// Description:
		//     The SHIFT key.
		ShiftKey = 16,
		//
		// Description:
		//     The CTRL key.
		ControlKey = 17,
		//
		// Description:
		//     The ALT key.
		Menu = 18,
		//
		// Description:
		//     The PAUSE key.
		Pause = 19,
		//
		// Description:
		//     The CAPS LOCK key.
		Capital = 20,
		//
		// Description:
		//     The CAPS LOCK key.
		CapsLock = 20,
		//
		// Description:
		//     The IME Kana mode key.
		KanaMode = 21,
		//
		// Description:
		//     The IME Hanguel mode key. (maintained for compatibility; use HangulMode)
		HanguelMode = 21,
		//
		// Description:
		//     The IME Hangul mode key.
		HangulMode = 21,
		//
		// Description:
		//     The IME Junja mode key.
		JunjaMode = 23,
		//
		// Description:
		//     The IME final mode key.
		FinalMode = 24,
		//
		// Description:
		//     The IME Hanja mode key.
		HanjaMode = 25,
		//
		// Description:
		//     The IME Kanji mode key.
		KanjiMode = 25,
		//
		// Description:
		//     The ESC key.
		Escape = 27,
		//
		// Description:
		//     The IME convert key.
		IMEConvert = 28,
		//
		// Description:
		//     The IME nonconvert key.
		IMENonconvert = 29,
		//
		// Description:
		//     The IME accept key, replaces System.Windows.Forms.Keys.IMEAceept.
		IMEAccept = 30,
		//
		// Description:
		//     The IME accept key. Obsolete, use System.Windows.Forms.Keys.IMEAccept instead.
		IMEAceept = 30,
		//
		// Description:
		//     The IME mode change key.
		IMEModeChange = 31,
		//
		// Description:
		//     The SPACEBAR key.
		Space = 32,
		//
		// Description:
		//     The PAGE UP key.
		Prior = 33,
		//
		// Description:
		//     The PAGE UP key.
		PageUp = 33,
		//
		// Description:
		//     The PAGE DOWN key.
		Next = 34,
		//
		// Description:
		//     The PAGE DOWN key.
		PageDown = 34,
		//
		// Description:
		//     The END key.
		End = 35,
		//
		// Description:
		//     The HOME key.
		Home = 36,
		//
		// Description:
		//     The LEFT ARROW key.
		Left = 37,
		//
		// Description:
		//     The UP ARROW key.
		Up = 38,
		//
		// Description:
		//     The RIGHT ARROW key.
		Right = 39,
		//
		// Description:
		//     The DOWN ARROW key.
		Down = 40,
		//
		// Description:
		//     The SELECT key.
		Select = 41,
		//
		// Description:
		//     The PRINT key.
		Print = 42,
		//
		// Description:
		//     The EXECUTE key.
		Execute = 43,
		//
		// Description:
		//     The PRINT SCREEN key.
		Snapshot = 44,
		//
		// Description:
		//     The PRINT SCREEN key.
		PrintScreen = 44,
		//
		// Description:
		//     The INS key.
		Insert = 45,
		//
		// Description:
		//     The DEL key.
		Delete = 46,
		//
		// Description:
		//     The HELP key.
		Help = 47,
		//
		// Description:
		//     The 0 key.
		D0 = 48,
		//
		// Description:
		//     The 1 key.
		D1 = 49,
		//
		// Description:
		//     The 2 key.
		D2 = 50,
		//
		// Description:
		//     The 3 key.
		D3 = 51,
		//
		// Description:
		//     The 4 key.
		D4 = 52,
		//
		// Description:
		//     The 5 key.
		D5 = 53,
		//
		// Description:
		//     The 6 key.
		D6 = 54,
		//
		// Description:
		//     The 7 key.
		D7 = 55,
		//
		// Description:
		//     The 8 key.
		D8 = 56,
		//
		// Description:
		//     The 9 key.
		D9 = 57,
		//
		// Description:
		//     The A key.
		A = 65,
		//
		// Description:
		//     The B key.
		B = 66,
		//
		// Description:
		//     The C key.
		C = 67,
		//
		// Description:
		//     The D key.
		D = 68,
		//
		// Description:
		//     The E key.
		E = 69,
		//
		// Description:
		//     The F key.
		F = 70,
		//
		// Description:
		//     The G key.
		G = 71,
		//
		// Description:
		//     The H key.
		H = 72,
		//
		// Description:
		//     The I key.
		I = 73,
		//
		// Description:
		//     The J key.
		J = 74,
		//
		// Description:
		//     The K key.
		K = 75,
		//
		// Description:
		//     The L key.
		L = 76,
		//
		// Description:
		//     The M key.
		M = 77,
		//
		// Description:
		//     The N key.
		N = 78,
		//
		// Description:
		//     The O key.
		O = 79,
		//
		// Description:
		//     The P key.
		P = 80,
		//
		// Description:
		//     The Q key.
		Q = 81,
		//
		// Description:
		//     The R key.
		R = 82,
		//
		// Description:
		//     The S key.
		S = 83,
		//
		// Description:
		//     The T key.
		T = 84,
		//
		// Description:
		//     The U key.
		U = 85,
		//
		// Description:
		//     The V key.
		V = 86,
		//
		// Description:
		//     The W key.
		W = 87,
		//
		// Description:
		//     The X key.
		X = 88,
		//
		// Description:
		//     The Y key.
		Y = 89,
		//
		// Description:
		//     The Z key.
		Z = 90,
		//
		// Description:
		//     The left Windows logo key (Microsoft Natural Keyboard).
		LWin = 91,
		//
		// Description:
		//     The right Windows logo key (Microsoft Natural Keyboard).
		RWin = 92,
		//
		// Description:
		//     The application key (Microsoft Natural Keyboard).
		Apps = 93,
		//
		// Description:
		//     The computer sleep key.
		Sleep = 95,
		//
		// Description:
		//     The 0 key on the numeric keypad.
		NumPad0 = 96,
		//
		// Description:
		//     The 1 key on the numeric keypad.
		NumPad1 = 97,
		//
		// Description:
		//     The 2 key on the numeric keypad.
		NumPad2 = 98,
		//
		// Description:
		//     The 3 key on the numeric keypad.
		NumPad3 = 99,
		//
		// Description:
		//     The 4 key on the numeric keypad.
		NumPad4 = 100,
		//
		// Description:
		//     The 5 key on the numeric keypad.
		NumPad5 = 101,
		//
		// Description:
		//     The 6 key on the numeric keypad.
		NumPad6 = 102,
		//
		// Description:
		//     The 7 key on the numeric keypad.
		NumPad7 = 103,
		//
		// Description:
		//     The 8 key on the numeric keypad.
		NumPad8 = 104,
		//
		// Description:
		//     The 9 key on the numeric keypad.
		NumPad9 = 105,
		//
		// Description:
		//     The multiply key.
		Multiply = 106,
		//
		// Description:
		//     The add key.
		Add = 107,
		//
		// Description:
		//     The separator key.
		Separator = 108,
		//
		// Description:
		//     The subtract key.
		Subtract = 109,
		//
		// Description:
		//     The decimal key.
		Decimal = 110,
		//
		// Description:
		//     The divide key.
		Divide = 111,
		//
		// Description:
		//     The F1 key.
		F1 = 112,
		//
		// Description:
		//     The F2 key.
		F2 = 113,
		//
		// Description:
		//     The F3 key.
		F3 = 114,
		//
		// Description:
		//     The F4 key.
		F4 = 115,
		//
		// Description:
		//     The F5 key.
		F5 = 116,
		//
		// Description:
		//     The F6 key.
		F6 = 117,
		//
		// Description:
		//     The F7 key.
		F7 = 118,
		//
		// Description:
		//     The F8 key.
		F8 = 119,
		//
		// Description:
		//     The F9 key.
		F9 = 120,
		//
		// Description:
		//     The F10 key.
		F10 = 121,
		//
		// Description:
		//     The F11 key.
		F11 = 122,
		//
		// Description:
		//     The F12 key.
		F12 = 123,
		//
		// Description:
		//     The F13 key.
		F13 = 124,
		//
		// Description:
		//     The F14 key.
		F14 = 125,
		//
		// Description:
		//     The F15 key.
		F15 = 126,
		//
		// Description:
		//     The F16 key.
		F16 = 127,
		//
		// Description:
		//     The F17 key.
		F17 = 128,
		//
		// Description:
		//     The F18 key.
		F18 = 129,
		//
		// Description:
		//     The F19 key.
		F19 = 130,
		//
		// Description:
		//     The F20 key.
		F20 = 131,
		//
		// Description:
		//     The F21 key.
		F21 = 132,
		//
		// Description:
		//     The F22 key.
		F22 = 133,
		//
		// Description:
		//     The F23 key.
		F23 = 134,
		//
		// Description:
		//     The F24 key.
		F24 = 135,
		//
		// Description:
		//     The NUM LOCK key.
		NumLock = 144,
		//
		// Description:
		//     The SCROLL LOCK key.
		Scroll = 145,
		//
		// Description:
		//     The left SHIFT key.
		LShiftKey = 160,
		//
		// Description:
		//     The right SHIFT key.
		RShiftKey = 161,
		//
		// Description:
		//     The left CTRL key.
		LControlKey = 162,
		//
		// Description:
		//     The right CTRL key.
		RControlKey = 163,
		//
		// Description:
		//     The left ALT key.
		LMenu = 164,
		//
		// Description:
		//     The right ALT key.
		RMenu = 165,
		//
		// Description:
		//     The browser back key.
		BrowserBack = 166,
		//
		// Description:
		//     The browser forward key.
		BrowserForward = 167,
		//
		// Description:
		//     The browser refresh key.
		BrowserRefresh = 168,
		//
		// Description:
		//     The browser stop key.
		BrowserStop = 169,
		//
		// Description:
		//     The browser search key.
		BrowserSearch = 170,
		//
		// Description:
		//     The browser favorites key.
		BrowserFavorites = 171,
		//
		// Description:
		//     The browser home key.
		BrowserHome = 172,
		//
		// Description:
		//     The volume mute key.
		VolumeMute = 173,
		//
		// Description:
		//     The volume down key.
		VolumeDown = 174,
		//
		// Description:
		//     The volume up key.
		VolumeUp = 175,
		//
		// Description:
		//     The media next track key.
		MediaNextTrack = 176,
		//
		// Description:
		//     The media previous track key.
		MediaPreviousTrack = 177,
		//
		// Description:
		//     The media Stop key.
		MediaStop = 178,
		//
		// Description:
		//     The media play pause key.
		MediaPlayPause = 179,
		//
		// Description:
		//     The launch mail key.
		LaunchMail = 180,
		//
		// Description:
		//     The select media key.
		SelectMedia = 181,
		//
		// Description:
		//     The start application one key.
		LaunchApplication1 = 182,
		//
		// Description:
		//     The start application two key.
		LaunchApplication2 = 183,
		//
		// Description:
		//     The OEM Semicolon key on a US standard keyboard.
		OemSemicolon = 186,
		//
		// Description:
		//     The OEM 1 key.
		Oem1 = 186,
		//
		// Description:
		//     The OEM plus key on any country/region keyboard.
		Oemplus = 187,
		//
		// Description:
		//     The OEM comma key on any country/region keyboard.
		Oemcomma = 188,
		//
		// Description:
		//     The OEM minus key on any country/region keyboard.
		OemMinus = 189,
		//
		// Description:
		//     The OEM period key on any country/region keyboard.
		OemPeriod = 190,
		//
		// Description:
		//     The OEM question mark key on a US standard keyboard.
		OemQuestion = 191,
		//
		// Description:
		//     The OEM 2 key.
		Oem2 = 191,
		//
		// Description:
		//     The OEM tilde key on a US standard keyboard.
		Oemtilde = 192,
		//
		// Description:
		//     The OEM 3 key.
		Oem3 = 192,
		//
		// Description:
		//     The OEM open bracket key on a US standard keyboard.
		OemOpenBrackets = 219,
		//
		// Description:
		//     The OEM 4 key.
		Oem4 = 219,
		//
		// Description:
		//     The OEM pipe key on a US standard keyboard.
		OemPipe = 220,
		//
		// Description:
		//     The OEM 5 key.
		Oem5 = 220,
		//
		// Description:
		//     The OEM close bracket key on a US standard keyboard.
		OemCloseBrackets = 221,
		//
		// Description:
		//     The OEM 6 key.
		Oem6 = 221,
		//
		// Description:
		//     The OEM singled/double quote key on a US standard keyboard.
		OemQuotes = 222,
		//
		// Description:
		//     The OEM 7 key.
		Oem7 = 222,
		//
		// Description:
		//     The OEM 8 key.
		Oem8 = 223,
		//
		// Description:
		//     The OEM angle bracket or backslash key on the RT 102 key keyboard.
		OemBackslash = 226,
		//
		// Description:
		//     The OEM 102 key.
		Oem102 = 226,
		//
		// Description:
		//     The PROCESS KEY key.
		ProcessKey = 229,
		//
		// Description:
		//     Used to pass Unicode characters as if they were keystrokes. The Packet key value
		//     is the low word of a 32-bit virtual-key value used for non-keyboard input methods.
		Packet = 231,
		//
		// Description:
		//     The ATTN key.
		Attn = 246,
		//
		// Description:
		//     The CRSEL key.
		Crsel = 247,
		//
		// Description:
		//     The EXSEL key.
		Exsel = 248,
		//
		// Description:
		//     The ERASE EOF key.
		EraseEof = 249,
		//
		// Description:
		//     The PLAY key.
		Play = 250,
		//
		// Description:
		//     The ZOOM key.
		Zoom = 251,
		//
		// Description:
		//     A constant reserved for future use.
		NoName = 252,
		//
		// Description:
		//     The PA1 key.
		Pa1 = 253,
		//
		// Description:
		//     The CLEAR key.
		OemClear = 254
	}
}
