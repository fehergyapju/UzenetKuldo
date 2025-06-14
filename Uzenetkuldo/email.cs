namespace Uzenetkuldo
{
    public class email
    {

        public string Szoveg {  get; set; }

        public string Kuldo { get; set; } //Ez az email cím lesz, aki elküldi az emailt.

        public string Fogado { get; set; } //Ez az email cím lesz, aki megkapja az emailt.

        public DateTime KuldesDatuma { get; set; } //Ez az email cím lesz, aki megkapja az emailt.
    }
}
