namespace Hgnim.ConsoleWriter
{
    /// <summary>
    /// 控制台写入器
    /// </summary>
    public class CWriter
    {
		/// <summary>
		/// 用于检测是否初始化
		/// </summary>
		private bool defBool = false;
        private int consTop;
        private int consLeft;
		
		private ConsoleColor defBack;
		/// <summary>
		/// 默认背景颜色
		/// </summary>
		public ConsoleColor DefBack
        {
            get => DefBack;
        }
		
		private ConsoleColor defFore;
		/// <summary>
		/// 默认字体颜色
		/// </summary>
		public ConsoleColor DefFore
        {
            get => defFore;
        }


        /// <summary>
        /// 在指定坐标中输出带有指定颜色和背景色的指定字符串
        /// </summary>
        /// <param name="str">输出的字符串</param>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        /// <param name="back">输出字符的背景颜色</param>
        /// <param name="fore">输出字符的字体颜色</param>
        /// <param name="writeLine">是否换行</param>
        public void ConsoleLocWrite(string str, int x, int y, ConsoleColor back, ConsoleColor fore, bool writeLine = false)
        {
            if (defBool)
            {
                if (x != -1 && y != -1)
                {
                    SetCursor(x, y);
                }
                Console.BackgroundColor = back;
                Console.ForegroundColor = fore;
                if (writeLine)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.Write(str);
                }
                Console.BackgroundColor = defBack;
                Console.ForegroundColor = defFore;
            }
            else
                throw new Exception("未初始化！使用前需要调用初始化方法。");
        }
        /// <summary>
        /// 在指定坐标中输出指定字符串
        /// </summary>
        /// <param name="str">输出的字符串</param>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        /// <param name="writeLine">是否换行</param>
        public void ConsoleLocWrite(string str, int x, int y, bool writeLine = false)
        {
            if (defBool)
            {
                if (x != -1 && y != -1)
                {
                    SetCursor(x, y);
                }
                if (writeLine)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.Write(str);
                }
            }
            else
                throw new Exception("未初始化！使用前需要调用初始化方法。");
        }
        /// <summary>
        /// 设置光标位置
        /// </summary>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        public void SetCursor(int x, int y)
        {
            Console.SetCursorPosition(consLeft + x - 1, consTop + y - 1);//因为 为了更好计算坐标值，所以进行减一
        }
        /// <summary>
        /// 初始化数据，在调用其他方法时需要初始化
        /// </summary>
        public void Def()
        {
            consTop = Console.CursorTop;
            consLeft = Console.CursorLeft;
            defBack = Console.BackgroundColor;
            defFore = Console.ForegroundColor;
            defBool = true;
        }
        /// <summary>
        /// 清除终端方法
        /// </summary>
        public void Clear(){
            Console.Clear();
        }
    }
}
