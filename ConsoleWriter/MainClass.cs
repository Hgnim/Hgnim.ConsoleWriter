namespace Hgnim.ConsoleWriter
{
    /// <summary>
    /// 控制台写入器
    /// </summary>
    public class CWriter
    {
        private int consTop;
        private int consLeft;
		
		private ConsoleColor defBack;
		/// <summary>
		/// 默认背景颜色
		/// </summary>
		public ConsoleColor DefBack
        {
            get => defBack;
        }
		
		private ConsoleColor defFore;
		/// <summary>
		/// 默认字体颜色
		/// </summary>
		public ConsoleColor DefFore
        {
            get => defFore;
        }

        private static void ConWrite(string str,bool wl) {
			if (wl) {
				Console.WriteLine(str);
			}
			else {
				Console.Write(str);
			}
		}
        private void ColorWrite(string str,ConsoleColor? fore,ConsoleColor? back,bool wl) {
			fore ??= defFore;
			back ??= defBack;
			Console.ForegroundColor = (ConsoleColor)fore;
			Console.BackgroundColor = (ConsoleColor)back;
			ConWrite(str, wl);
			Console.BackgroundColor = defBack;
			Console.ForegroundColor = defFore;
		}

		/// <summary>
		/// 输出带有颜色的字符串
		/// </summary>
		/// <param name="str">输出的字符串</param>
		/// <param name="foreColor">输出字符的字体颜色，如果为null则使用默认值</param>
		/// <param name="backColor">输出字符的背景颜色，如果为null则使用默认值</param>
		public void Write(string str, ConsoleColor? foreColor = null, ConsoleColor? backColor = null) {
			ColorWrite(str, foreColor, backColor, false);
		}
		/// <summary>
		/// 输出一行带有颜色的字符串
		/// </summary>
		/// <param name="str">输出的字符串</param>
		/// <param name="foreColor">输出字符的字体颜色，如果为null则使用默认值</param>
		/// <param name="backColor">输出字符的背景颜色，如果为null则使用默认值</param>
		public void WriteLine(string str, ConsoleColor? foreColor = null, ConsoleColor? backColor = null) {
            ColorWrite(str, foreColor, backColor, true);
        }


		/// <summary>
		/// 在指定坐标中输出带有指定颜色和背景色的指定字符串
		/// </summary>
		/// <param name="str">输出的字符串</param>
		/// <param name="x">x坐标</param>
		/// <param name="y">y坐标</param>
		/// <param name="foreColor">输出字符的字体颜色，如果为null则使用默认值</param>
		/// <param name="backColor">输出字符的背景颜色，如果为null则使用默认值</param>
		public void LocWrite(string str, int x, int y, ConsoleColor? foreColor =null, ConsoleColor? backColor=null)
        {
                if (x != -1 && y != -1)
                {
                    SetCursor(x, y);
                }
            ColorWrite(str, foreColor, backColor, false);
        }
        /// <summary>
        /// 在指定坐标中输出指定字符串
        /// </summary>
        /// <param name="str">输出的字符串</param>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        public void LocWrite(string str, int x, int y)
        {
                if (x != -1 && y != -1)
                {
                    SetCursor(x, y);
                }
            ConWrite(str, false);
        }
		/// <summary>
		/// 在指定坐标中输出带有指定颜色和背景色的指定字符串
		/// </summary>
		/// <param name="str">输出的字符串</param>
		/// <param name="x">x坐标</param>
		/// <param name="y">y坐标</param>
		/// <param name="foreColor">输出字符的字体颜色，如果为null则使用默认值</param>
		/// <param name="backColor">输出字符的背景颜色，如果为null则使用默认值</param>
		public void LocWriteLine(string str, int x, int y, ConsoleColor? foreColor = null, ConsoleColor? backColor = null) {
			if (x != -1 && y != -1) {
				SetCursor(x, y);
			}
			ColorWrite(str, foreColor, backColor, true);
		}
		/// <summary>
		/// 在指定坐标中输出指定字符串
		/// </summary>
		/// <param name="str">输出的字符串</param>
		/// <param name="x">x坐标</param>
		/// <param name="y">y坐标</param>
		public void LocWriteLine(string str, int x, int y) {
			if (x != -1 && y != -1) {
				SetCursor(x, y);
			}
			ConWrite(str, true);
		}


		/// <summary>
		/// 设置光标位置
		/// </summary>
		/// <param name="x">x坐标</param>
		/// <param name="y">y坐标</param>
		public void SetCursor(int x, int y)
        {
            Console.SetCursorPosition(consLeft + x, consTop + y);
        }
        /// <summary>
        /// 初始化数据，在调用其他方法时需要初始化
        /// </summary>
        public CWriter()
        {
            consTop = Console.CursorTop;
            consLeft = Console.CursorLeft;
            defBack = Console.BackgroundColor;
            defFore = Console.ForegroundColor;
        }
        /// <summary>
        /// 清除终端方法
        /// </summary>
        public void Clear(){
            Console.Clear();
        }
    }
}
