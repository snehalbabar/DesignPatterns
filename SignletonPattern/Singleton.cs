using System;
using System.Runtime.ConstrainedExecution;

namespace SingletonPattern
{
	public sealed class Singleton
	{
		private static int counter = 0;
		public static Singleton instance = null;

		public static Singleton getInstance {
			get {
				if (instance == null)
				{
					instance = new Singleton();
				}
				return instance;
			} 


		}

		private Singleton()
		{
			counter++;
			Console.WriteLine("Counter :" + counter);
		}

		public void printDetails(string msg)
		{
			Console.WriteLine(msg);
			
		}
	}
}

