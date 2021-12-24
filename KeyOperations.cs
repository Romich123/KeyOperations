public static class KeyOperations
	{
		[DllImport("user32.dll", SetLastError = true)] private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
    
		[DllImport("user32.dll")] private static extern int GetAsyncKeyState(int i);
    
		public static void KeyDown(Keys key)
		{
			keybd_event((byte)key, 0, 0, 0);
		}
		public static void KeyUp(Keys key)
		{
			keybd_event((byte)key, 0, 0x2, 0);
		}
		public static bool IsKeyActive(Keys key)
		{
			return GetAsyncKeyState((int)key) != 0;
		}
		public static int GetKeyState(Keys key)
		{
			return GetAsyncKeyState((int)key);
		}
	}
