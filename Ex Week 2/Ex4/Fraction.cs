using System;

class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Mẫu số không được bằng 0");

        this.numerator = numerator;
        this.denominator = denominator;
        Normalize();
    }

    // Chuẩn hóa phân số
    private void Normalize()
    {
        int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
        numerator /= gcd;
        denominator /= gcd;

        // Đưa dấu âm lên tử
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
    }

    // Tìm ước chung lớn nhất
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    // Cộng
    public Fraction Add(Fraction other)
    {
        int num = numerator * other.denominator + other.numerator * denominator;
        int den = denominator * other.denominator;
        return new Fraction(num, den);
    }

    // Trừ
    public Fraction Subtract(Fraction other)
    {
        int num = numerator * other.denominator - other.numerator * denominator;
        int den = denominator * other.denominator;
        return new Fraction(num, den);
    }

    // Nhân
    public Fraction Multiply(Fraction other)
    {
        return new Fraction(numerator * other.numerator,
                            denominator * other.denominator);
    }

    // Chia
    public Fraction Divide(Fraction other)
    {
        if (other.numerator == 0)
            throw new ArgumentException("Không thể chia cho phân số 0");

        return new Fraction(numerator * other.denominator,
                            denominator * other.numerator);
    }

    // Hiển thị A/B
    public void Display()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

    // Hiển thị dạng thập phân
    public void DisplayDecimal()
    {
        double value = (double)numerator / denominator;
        Console.WriteLine(value);
    }
}
