using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Latihan4
    {
        static void Main(string[] args)
        {
            Console.Title = "Penyetoran dan Penarikan";

            int saldo = 10000, kode, setoran, penarikan;
            char jawab;

            do
            {
                Console.WriteLine("Saldo : " + saldo.ToString("Rp #,##0"));
                Console.Write("Masukan Kode Transaksi [0. Setor / 1. Tarik]: ");
                kode = int.Parse(Console.ReadLine());

                switch (kode)
                {
                    case 0:
                    setorulang:
                        Console.Write("Masukan jumlah setoran tunai: ");
                        setoran = int.Parse(Console.ReadLine());
                        if (setoran <= 0)
                        {
                            Console.WriteLine("Nilai Setoran Tidak Valid");
                            goto setorulang;
                        }
                        else
                        {
                            saldo += setoran;
                            Console.WriteLine("Saldo : " + saldo.ToString("Rp #,##0"));
                        }
                        break;
                    case 1:
                    penarikanulang:
                        Console.Write("Masukan jumlah penarikan: ");
                        penarikan = int.Parse(Console.ReadLine());
                        if (penarikan <= 0)
                        {
                            Console.WriteLine("Nilai Penarikan Tidak Valid");
                            goto penarikanulang;
                        }
                        else
                        {
                            if ((saldo - penarikan) < 10000)
                            {
                                Console.WriteLine("Nilai penarikan terlalu besar/Tidak Valid");
                                goto penarikanulang;
                            }
                            else
                            {
                                saldo -= penarikan;
                                Console.WriteLine("Sisah Saldo : " + saldo.ToString("Rp #,##0"));
                            }


                        }
                        break;

                }
                Console.Write("Butuh transakasi lagi ? [Y/N] :");
                jawab = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (jawab == 'Y' || jawab == 'y');

            


            Console.ReadKey();
        }
    }
}
