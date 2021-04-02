﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nuri Serhat Arslan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demiroğ";
            musteri1.TcNo = "12345678911";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.MusteriNo = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri -- Tüzel Müşteri
            //SOLID
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}