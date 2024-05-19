using Domecek_Lepsi.Models;

namespace Domecek_Lepsi.Pages
{
    public partial class Domecek
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
        public int SvgWidth { get; set; } = 800;
        public int SvgHeight { get; set; } = 600;
        public int Krok { get; set; } = 20;
        public List<Obrazec> ObrazceList { get; set; } = new List<Obrazec>();
        Obrazec obrazec { get; set; } = null;
        Random Random { get; set; } = new Random();
        public void PridejObrazec()
        {
            var rndX = Random.Next(0, 500);
            var rndY = Random.Next(0, 500);
            obrazec = new Obdelnik(rndX, rndY, 200, 150);
            ObrazceList.Add(obrazec);
            obrazec = new Ctverec(50+rndX, 50+rndY, 30);
            ObrazceList.Add(obrazec);
            obrazec = new Ctverec(50+rndX, 120+rndY, 30);
            ObrazceList.Add(obrazec);
        }
        public void PosunDoprava()
        {
            foreach (var item in ObrazceList)
            {
                item.PosunR(Krok, SvgWidth, 200);
            }
        }
        public void PosunDoleva()
        {
            
            ObrazceList.Clear();
        }
    }
}
