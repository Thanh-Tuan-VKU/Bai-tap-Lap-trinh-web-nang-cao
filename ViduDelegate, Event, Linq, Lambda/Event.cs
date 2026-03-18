using System;

class SinhVien
{
    public string ten;
    public double diem;

    public delegate void CanhBaoHandler(string msg);
    public event CanhBaoHandler CanhBao;

    public void KiemTra()
    {
        if (diem < 5)
        {
            CanhBao?.Invoke("Sinh vien " + ten + " hoc luc yeu!");
        }
    }
}

class Program
{
    static void HienCanhBao(string msg)
    {
        Console.WriteLine("Thong bao: " + msg);
    }

    static void Main()
    {
        SinhVien sv = new SinhVien();
        sv.ten = "Tuan";
        sv.diem = 4.5;

        sv.CanhBao += HienCanhBao;

        sv.KiemTra();
    }
}