using System;

namespace ClassesAndProperties.Polymorphism
{
	public interface IBodyType
	{
	  string Body { get; set; }
	}
	public interface FuelInjector : IBodyType 
	{
		string Type { get; set; }
	}
	public interface ICar : FuelInjector
	{
		//public int CarId;  //Access modifiers are not allowed here
		//int CarId; // Data members are not allowed

		void Print();
		int CarID { get; set; }
	    //FuelInjector Injector { get; set; }
	}
	public class HondaCity : ICar
	{
		//public FuelInjector Injector { get; set; }
		public string Body { get; set; }
		public int CarID { get; set; }
		public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Print()
		{
			Console.WriteLine("Honda city implementation..." + CarID);
		}
	}
	public class HondaCivic : ICar
	{
		//public FuelInjector Injector { get; set; }
		public string Body { get; set; }

		public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public int CarID { get; set; }

		public void Print()
		{
			Console.WriteLine("Honda civic implementation..." + CarID);
		}
	}
	public class SuzukiAlto: ICar
	{
		//public FuelInjector Injector { get; set; }
		public string Body { get; set; }

		public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public int CarID { get; set; }
		public void Print()
		{
			Console.WriteLine("Suzuki Alto implementation..." + CarID);
		}
	}
	public static class Demo
	{
		public static void RunDemo()
		{
			HondaCity h = new HondaCity() { CarID = 1};
			h.Print();

			HondaCivic hc = new HondaCivic(){ CarID = 2};
			hc.Print();						
			SuzukiAlto sa = new SuzukiAlto() { CarID = 3 };
			sa.Print();
			Console.ReadKey();
		}
	}
}
