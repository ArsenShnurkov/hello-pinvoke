using System.Runtime.InteropServices;

public static class SharedObjects
{
	[DllImport("shared-objects.dll", EntryPoint = "calc")]
	public static extern int Calc(int a, int b);
}
