using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfacePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			///  What we want to accomplish
			/// FileTransfer.Connect(..).onPort(..).AuthConfig().WithUsername(..).SetPassword(..).And().Download().toFile(..);
			/// FileTransfer.Connect(..).onPort(..).AuthConfig().WithUsername(..).SetPassword(..).And().Download().toStream(..);
			/// FileTransfer.Connect(..).onPort(..).AuthConfig().WithUsername(..).SetPassword(..).And().Upload().fromFile(..);
			/// FileTransfer.Connect(..).onPort(..).AuthConfig().WithUsername(..).SetPassword(..).And().Upload().FromStream(..);

			FileTransfer.Connect(new Uri("http://192.168.1.0")).onPort("80").AuthConfig().SetUsername("kiriyaga").SetPassword("Pa33word").And().Download("\thisFile").toFile("C:\\NewFolder");

			//Without Authentification

			FileTransfer.Connect("//Studenti/Marko").onPort("23").AuthConfig().And().Upload("\thisFile").fromFile("C:\\NewFolder");

			//Close application
			Console.ReadKey();

		}
	}
}
