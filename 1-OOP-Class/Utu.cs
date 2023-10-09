using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OOP_Class
{
    public class Utu
    {
		public Utu(int su)
		{
			this.Su = su;
		}

		//Fields
		private string _marka;

		private int _fiyat;

		private int _su;

		private int _sicaklik;

		//Properties
		public int Sicaklik
		{
			get { return _sicaklik; }
			set 
			{
				if (value>0 && value<100)
				{
                    _sicaklik = value;
                }
				else
				{
					throw new Exception("Su sıcakliği 100 den büyük girilemez");
				}
			}
		}

		public int Su
		{
			get { return _su; }
			set 
			{
				if (value > 0)
				{
					_su = value;
				}
				else
				{
					_su = 0;
					Console.WriteLine("Su derecesi 0");
				}
			}
		}

		public string Renk { get; set; }
		public int Fiyat
		{
			get { return _fiyat; }
			set { _fiyat = value; }
		}

		public bool KazanliMi { get; set; }

		public string Marka
		{
			get { return _marka.ToUpper(); }
			set { _marka = value; }
		}

		public int Isit()
		{
			Su -= 5;
			Sicaklik += 10;
			Console.WriteLine($"Su Derecesi: {Su} Sicaklik: {Sicaklik}");

			return Sicaklik;
		}

		public void BilgiVer()
		{
			Console.WriteLine($"Ütünün Markası: {Marka} Kazanlı Mı: {KazanliMi} Fiyat: {Fiyat} Rengi: {Renk}");
		}

	}
}
