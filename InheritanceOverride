using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu utama = new Menu();
            utama.menu();
            Console.ReadLine();
        }
    }
    class Menu
    {
        public void menu()
        {
            Persegi persegi = new Persegi();

            Console.WriteLine("1. Menghitung Persegi");
            Console.WriteLine("-------------------------");
            Console.Write("Sisi : ");
            persegi.sisi = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas = {0} cm", persegi.hitungLuas());
            Console.WriteLine("Keliling = {0} cm", persegi.hitungKeliling());
            Console.WriteLine();

            Lingkaran lingkaran = new Lingkaran();

            Console.WriteLine("2. Menghitung Lingkaran");
            Console.WriteLine("-------------------------");
            Console.Write("Jari-Jari : ");
            lingkaran.jarijari = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas       = {0} cm", lingkaran.hitungLuas());
            Console.WriteLine("Keliling   = {0} cm", lingkaran.hitungKeliling());
            Console.WriteLine();

            PersegiPanjang persegiPanjang = new PersegiPanjang();

            Console.WriteLine("3. Menghitung Persegi Panjang");
            Console.WriteLine("---------------------------");
            Console.Write("Panjang : ");
            persegiPanjang.panjang = (int.Parse(Console.ReadLine()));
            Console.Write("Lebar   : ");
            persegiPanjang.lebar = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas    = {0} cm", persegiPanjang.hitungLuas());
            Console.WriteLine("Keliling   = {0} cm", persegiPanjang.hitungKeliling());
            Console.WriteLine();

            Segitiga segitiga = new Segitiga();

            Console.WriteLine("4. Menghitung Segitiga");
            Console.WriteLine("------------------------");
            Console.Write("Alas   : ");
            segitiga.alas = (int.Parse(Console.ReadLine()));
            Console.Write("Tinggi : ");
            segitiga.tinggi = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas   = {0} cm", segitiga.luas_segitiga());
        }

    }


    public abstract class BangunDatar
    {
        public double _hitung;

        public double Hitung
        {
            get { return _hitung; }
            set { _hitung = value; }
        }

        public abstract double hitungLuas();

        public abstract double hitungKeliling();
    }

    class Persegi : BangunDatar
    {
        private double s;

        public double sisi
        {
            get { return s; }
            set { s = value; }
        }

        public override double hitungLuas()
        {
            _hitung = s * s;
            return _hitung;
        }

        public override double hitungKeliling()
        {
            _hitung = s * 4;
            return _hitung;
        }

    }

    class Lingkaran : BangunDatar
    {
        private double r, luas;

        public double jarijari
        {
            get { return r; }
            set
            {
                r = value;
            }
        }

        public override double hitungLuas()
        {
            luas = 3.14 * r * r;
            return luas;
        }
        public override double hitungKeliling()
        {
            float k = (float)(2 * Math.PI * r);
            return k;
        }
    }

    class PersegiPanjang : BangunDatar
    {
        private float p, l, luas;

        public float panjang
        {
            get { return p; }
            set
            {
                p = value;
            }
        }

        public float lebar
        {
            get { return l; }
            set
            {
                l = value;
            }
        }

        public override double hitungLuas()
        {
            luas = p * l;
            return luas;
        }
        public override double hitungKeliling()
        {
            float k = 2 * panjang + 2 * lebar;
            return k;
        }
    }

    class Segitiga
    {
        private float a, t, luas;

        public float alas
        {
            get { return a; }
            set
            {
                a = value;
            }
        }

        public float tinggi
        {
            get { return t; }
            set
            {
                t = value;
            }
        }

        public float luas_segitiga()
        {
            luas = (a * t) / 2;
            return luas;
        }
    }
}
