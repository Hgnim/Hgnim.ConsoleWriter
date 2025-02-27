using Hgnim.ConsoleWriter;
namespace DebugConsole {
	internal class Program {
		static void Main(string[] args) {
			CWriter cr = new();
			cr.Write("a", ConsoleColor.Red);
			cr.Write("a", ConsoleColor.DarkRed);
			cr.Write("a", ConsoleColor.Yellow);
			cr.Write("a", ConsoleColor.DarkYellow);
			cr.Write("a", ConsoleColor.Green);
			cr.Write("a", ConsoleColor.DarkGreen);
			cr.Write("a", ConsoleColor.Gray);
			cr.Write("a", ConsoleColor.DarkGray);
			cr.Write("a", ConsoleColor.Blue);
			cr.Write("a", ConsoleColor.DarkBlue);
			cr.Write("a", ConsoleColor.Cyan);
			cr.Write("a", ConsoleColor.DarkCyan);
			cr.Write("a", ConsoleColor.White);
			cr.Write("a");
			Console.WriteLine();
			cr.LocWrite("b", 0, 1);
			cr.LocWrite("c", 0, 2);
			cr.LocWrite("e", 1, 2);
			cr.LocWrite("d", 1, 1);
			cr.SetCursor(0, 3);
			cr.WriteLine("1");
			cr.LocWriteLine("2", Console.CursorLeft, Console.CursorTop, backColor: ConsoleColor.White);
		}
	}
}
