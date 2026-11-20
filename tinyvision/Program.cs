namespace tinyvision
{
    public class TinyVision
    {
        static void Main(string[] args)
        {
            const string whiteFG = "\x1b[38;2;255;255;255m";
            const string redFG = "\x1b[38;2;255;0;0m";
            const string greenFG = "\x1b[38;2;0;255;0m";
            const string yellowFG = "\x1b[38;2;255;255;0m";

            const string blackBG = "\x1b[48;2;0;0;m";

            string? videoPath;
            string videoPathDisplay;
            string resumed = $"{greenFG}RESUMED";

            if (args.Length > 0)
                videoPath = args[0];
            else
                videoPath = null;

            if (videoPath == null)
                videoPathDisplay = $"[{redFG}NO FILE OPENED{whiteFG}]";
            else
            {
                string[] videoPathArray = videoPath.Split('/');
                videoPathDisplay = videoPathArray[videoPathArray.Length];
            }

            Console.WriteLine($"{whiteFG}{blackBG}-=[ {yellowFG}tinyvision player {whiteFG}]=- | {videoPathDisplay} | [{resumed}\x1b[38;2;255;255;255m] | ");
            // Console.Write($"\x1b[38;2;{r1};{g1};{b1}m\x1b[48;2;{r2};{g2};{b2}m▀");
        }
    }
}
