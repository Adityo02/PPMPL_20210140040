using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Kasir
{
    /// <summary>
    /// Membuat public class
    /// </summary>
    public class Kasir
    {
        public void KasirCafe()
        {
            {
                Console.WriteLine("==============================");
                Console.WriteLine("      Program Kasir Cafe      ");
                Console.WriteLine("          Cafe Moon           ");
                Console.WriteLine("==============================");
                Console.Write("\n");
                Console.WriteLine("     Silahkan Pilih Menu     ");
                Console.Write("\n");
                /// <summary>
                /// /Menampilkan Menu Makanan
                /// </summary>
                //Menampilkan Menu Makanan
                Console.WriteLine("============MAKANAN============");
                Console.Write("\n");
                Console.WriteLine(" 1. Nasi Telor           : Rp 9000");
                Console.WriteLine(" 2. Nasi Ayam            : Rp 12000");
                Console.WriteLine(" 3. Nasi Goreng          : Rp 10000");
                Console.WriteLine(" 4. Mie Goreng           : Rp 7000");
                /// <summary>
                /// Menampilkan Menu Minuman
                /// </summary>
                Console.WriteLine("============MINUMAN============");
                Console.WriteLine(" 1. Es Teh               : Rp 3000");
                Console.WriteLine(" 2. Es Jeruk             : Rp 4000");
                Console.WriteLine(" 3. Kopi                 : Rp 5000");
                Console.WriteLine(" 4. Susu                 : Rp 6000");

                int jumlah;
                /// <summary>
                /// Looping dengan menginput jumlah Barang menggunakan kondisi do while
                /// </summary>
                do
                {
                    Console.Write("\nMasukkan Jumlah Barang : ");
                    jumlah = int.Parse(Console.ReadLine());

                } while (jumlah <= 0 || jumlah > 100);

                /// <summary>
                /// mendeklarasikan atau mendefinisikan variabel data
                /// </summary>
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;

                /// <summary>
                /// Display("Masukkan Nama Pelanggan")
                /// </summary>
                Console.WriteLine("==============================");
                Console.Write("Masukkan Nama Pelanggan : ");
                /// <summary>
                /// Deklarasi variabel data string
                /// </summary>
                string namapl = Console.ReadLine();

                /// <summary>
                /// Looping menggunakan kombinasi array
                /// </summary>
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        /// <summary>
                        /// Menampilkan inupt nama Barang
                        /// </summary>
                        Console.WriteLine("==============================");
                        Console.Write("Masukan Nama Barang ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());
                        /// <summary>
                        /// Pengguna harus menginput harga barang minimal 5000 sampai 1000000
                        /// </summary>
                    }
                    while (harga[i] <= 4000 || harga[i] >= 1000000);

                }
                /// <summary>
                /// Menampilkan barang dan harga yang sudah di pilih
                /// </summary>
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==============================");
                Console.WriteLine("  Daftar Barang Yang Dipilih  ");
                Console.WriteLine("==============================");
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);
                }
                foreach (int i in harga)
                {
                    total += i;
                }

                /// <summary>
                /// Menampilkan total barang
                /// </summary>
                Console.WriteLine("==============================");
                Console.WriteLine("Total Harga : Rp" + total);

                do
                {
                    Console.WriteLine("Masukkan Uang Tunai : Rp");
                    bayar = int.Parse(Console.ReadLine());

                    /// <summary>
                    /// Menampilkan kembalian uang dari uang yang dibayarkan dan dikurangi harga total
                    /// </summary>
                    kembalian = bayar - total;

                    /// <summary>
                    /// kondisi jika input uang yang dibayarkan kurang
                    /// </summary>
                    if (bayar < total)
                    {
                        Console.WriteLine("Maaf Uang Anda Tidak Mencukupi !");
                    }
                    /// <summary>
                    /// Kondisi jika uang yang dibayarkan lebih
                    /// </summary>
                    else /// <summary> menampilkan uang kembalian </summary>
                    {
                        Console.WriteLine("Uang Kembalian Anda : Rp" + kembalian);
                    }
                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan : {0}", namapl.ToString());
                Console.Write("\n");
                /// <summary>
                /// Menampilkan Tanggal dan Waktu Transaksi
                /// </summary>
                Console.WriteLine("Tanggal Transaksi : " + DateTime.Today.ToString("yyyy-MM--dd"));
                Console.WriteLine("Jam Transaksi : " + DateTime.Now.ToString("HH-mm-ss"));
                Console.WriteLine("==============================");
                Console.WriteLine("Nama Kasir : Fahmi ");
                Console.WriteLine("Terima Kasih");
                Console.WriteLine("==============================");

                /// <summary>
                /// Mencetak nota menggunakan streamwritter
                /// </summary>
                using (StreamWriter sw = new StreamWriter(@"C:\PAW\UAS-PAW\Nota Kasir.txt"))/// <summary> Lokasi tempat file nota dicetak </summary>
                {
                    sw.WriteLine("+========================================+");
                    sw.WriteLine("+=========== NOTA PEMBAYARAN ============+");
                    sw.WriteLine("+========================================+");
                    sw.WriteLine("          Nama Barang Yang Dibeli         ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + ". " + harga[i]);
                    }
                    sw.WriteLine("+========================================+");
                    sw.WriteLine("Total Harga       : Rp" + total);
                    sw.WriteLine("Tunai             : Rp" + bayar);
                    sw.WriteLine("Kembalian         : Rp" + kembalian);
                    /// <summary>
                    /// Menampilkan Nama pelanggan
                    /// </summary>
                    sw.WriteLine("Nama Pelanggan : {0}", namapl.ToString());
                    /// <summary>
                    /// Menampilkan Tanggal dan waktu transaksi
                    /// </summary>
                    sw.WriteLine("Tanggal Transaksi : " + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam Transaksi : " + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("+========================================+");
                    sw.WriteLine("Nama Kasir : Fahmi");
                    sw.WriteLine("  Terima Kasih    ");
                    sw.WriteLine("+========================================+");
                    Console.Write("\n");
                    Console.WriteLine("Nota Telah Di Cetak");

                }
                Console.WriteLine();
                Console.Write("Tekan 'ENTER' Untuk Keluar");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            /// <summary>
            /// Memanggil Kelas KasirCafe
            /// </summary>
            Kasir KasirC = new Kasir();
            KasirC.KasirCafe();
        }
    }
}
