namespace Domecek_Lepsi.Models
{
    public class Obdelnik : Obrazec
    {
        public Obdelnik(int pozX, int pozY, int stranaA, int stranaB) : base(pozX, pozY, stranaA)
        {
            StranaB = stranaB;
        }
        public int StranaB { get; set; }
    }
}
