using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modul_4
{
    class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T a, T b, T c) where T : IComparable
        {
            dynamic max = a;
            if (b.CompareTo(max) > 0) max = b;
            if (c.CompareTo(max) > 0) max = c;
            return max;
        }
    }



    //////////////////////////////////////////////////////////////////////////////////////////////////////



    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        // Konstruktor
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        // Method untuk menambahkan data
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }

        // Method untuk menampilkan semua data
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PemrosesData pemroses = new PemrosesData();

            // Tipe data long
            long angkaLong1 = 13;
            long angkaLong2 = 02;
            long angkaLong3 = 23;
            long nilaiTerbesarLong = pemroses.DapatkanNilaiTerbesar(angkaLong1, angkaLong2, angkaLong3);
            Console.WriteLine($"[long] Nilai terbesar adalah: {nilaiTerbesarLong}");

            // Tipe data int
            int angkaInt1 = 13;
            int angkaInt2 = 02;
            int angkaInt3 = 23;
            int nilaiTerbesarInt = pemroses.DapatkanNilaiTerbesar(angkaInt1, angkaInt2, angkaInt3);
            Console.WriteLine($"[int] Nilai terbesar adalah: {nilaiTerbesarInt}");

            // Tipe data double
            double angkaDouble1 = 13.7;
            double angkaDouble2 = 02.5;
            double angkaDouble3 = 23.3;
            double nilaiTerbesarDouble = pemroses.DapatkanNilaiTerbesar(angkaDouble1, angkaDouble2, angkaDouble3);
            Console.WriteLine($"[double] Nilai terbesar adalah: {nilaiTerbesarDouble}");

            // Tipe data float
            float angkaFloat1 = 13.7f;
            float angkaFloat2 = 02.5f;
            float angkaFloat3 = 23.3f;
            float nilaiTerbesarFloat = pemroses.DapatkanNilaiTerbesar(angkaFloat1, angkaFloat2, angkaFloat3);
            Console.WriteLine($"[float] Nilai terbesar adalah: {nilaiTerbesarFloat}");



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            Console.WriteLine("\n[long]");
            // Tipe data long // Membuat objek SimpleDataBase dengan tipe data long
            SimpleDataBase<long> databaseLong = new SimpleDataBase<long>();

            databaseLong.AddNewData(angkaLong1);
            Thread.Sleep(1000);
            databaseLong.AddNewData(angkaLong2);
            Thread.Sleep(1000);
            databaseLong.AddNewData(angkaLong3);
            Thread.Sleep(1000);

            databaseLong.PrintAllData();

            Console.WriteLine("\n[int]");
            // Tipe data int
            SimpleDataBase<int> databaseInt = new SimpleDataBase<int>();

            databaseInt.AddNewData(angkaInt1);
            Thread.Sleep(1000);
            databaseInt.AddNewData(angkaInt2);
            Thread.Sleep(1000);
            databaseInt.AddNewData(angkaInt3);
            Thread.Sleep(1000);

            databaseInt.PrintAllData();

            Console.WriteLine("\n[double]");
            // Tipe data double
            SimpleDataBase<double> databaseDouble = new SimpleDataBase<double>();

            databaseDouble.AddNewData(angkaDouble1);
            Thread.Sleep(1000);
            databaseDouble.AddNewData(angkaDouble2);
            Thread.Sleep(1000);
            databaseDouble.AddNewData(angkaDouble3);
            Thread.Sleep(1000);

            databaseDouble.PrintAllData();

            Console.WriteLine("\n[float]");
            // Tipe data int
            SimpleDataBase<float> databaseFloat = new SimpleDataBase<float>();

            databaseFloat.AddNewData(angkaFloat1);
            Thread.Sleep(1000);
            databaseFloat.AddNewData(angkaFloat2);
            Thread.Sleep(1000);
            databaseFloat.AddNewData(angkaFloat3);
            Thread.Sleep(1000);

            databaseFloat.PrintAllData();
        }
    }
}
