namespace Domecek_Lepsi.Models
{
    public abstract class Obrazec
    {
        public Obrazec(int pozX, int pozY, int stranaA)
        {
            PozX = pozX;
            PozY = pozY;
            StranaA = stranaA;
        }

        public int PozX { get; set; }
        public int PozY { get; set; }
        public int StranaA { get; set; }
        public void PosunR(int krok, int svgWidth, int vychoziPozice)
        {
            PozX += krok;
            if (PozX >= svgWidth)
            {
                PozX = vychoziPozice;
            }
        }
        public void PosunL(int krok, int svgWidth, int vychoziPozice)
        {
            PozX -= krok;
            if (PozX <= 0)
            {
                PozX = 200;
            }
        }
    }
}
