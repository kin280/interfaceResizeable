using System;

public interface IResizeable
{
    void Resize(double percent);
}

public class HinhTron : IResizeable
{
    public double BanKinh { get; set; }

    public HinhTron(double banKinh)
    {
        BanKinh = banKinh;
    }

    public void Resize(double phanTram)
    {
        BanKinh *= 1 + phanTram / 100;
    }
}

public class HinhChuNhat : IResizeable
{
    public double ChieuRong { get; set; }
    public double ChieuDai { get; set; }

    public HinhChuNhat(double chieuRong, double chieuDai)
    {
        ChieuRong = chieuRong;
        ChieuDai = chieuDai;
    }

    public void Resize(double phanTram)
    {
        ChieuRong *= 1 + phanTram / 100;
        ChieuDai *= 1 + phanTram / 100;
    }
}

public class HinhVuong : IResizeable
{
    public double Canh { get; set; }

    public HinhVuong(double canh)
    {
        Canh = canh;
    }

    public void Resize(double phanTram)
    {
        Canh *= 1 + phanTram / 100;
    }
}

public class ChuongTrinh
{
    public static void Main()
    {
        HinhTron hinhTron = new HinhTron(5);
        HinhChuNhat hinhChuNhat = new HinhChuNhat(4, 6);
        HinhVuong hinhVuong = new HinhVuong(3);

        Console.WriteLine("Trước khi thay đổi kích thước:");
        Console.WriteLine($"Bán kính Hình tròn: {hinhTron.BanKinh}");
        Console.WriteLine($"Chiều rộng Hình chữ nhật: {hinhChuNhat.ChieuRong}, Chiều dài: {hinhChuNhat.ChieuDai}");
        Console.WriteLine($"Cạnh Hình vuông: {hinhVuong.Canh}");

    
        hinhTron.Resize(10);
        hinhChuNhat.Resize(20);
        hinhVuong.Resize(15);

        Console.WriteLine("\nSau khi thay đổi kích thước:");
        Console.WriteLine($"Bán kính Hình tròn: {hinhTron.BanKinh}");
        Console.WriteLine($"Chiều rộng Hình chữ nhật: {hinhChuNhat.ChieuRong}, Chiều dài: {hinhChuNhat.ChieuDai}");
        Console.WriteLine($"Cạnh Hình vuông: {hinhVuong.Canh}");
    }
}
