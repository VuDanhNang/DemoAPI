namespace DemoAPI.Models
{
    public class TruyenTranhOfMe
    {
        public string TenTruyenTranh { get; set; }
        public double DonGia { get; set; }
    }

    public class TruyenTranh : TruyenTranhOfMe
    {
        public Guid SoTT { get; set; }
    }

}
