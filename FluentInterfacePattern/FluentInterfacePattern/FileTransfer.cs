using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfacePattern
{
	/// <summary>
	/// C# Design Patterns – Fluent Builder Interface
	/// See <a href="https://en.wikipedia.org/wiki/Fluent_interface">this link</a> for more information.
	/// <example>
	/// <code>
	/// FileTransfer.Connect(new Uri("192.168.1.0")).onPort("80").AuthConfig().SetUsername("kiriyaga").SetPassword("Pa33word").And().Download("\thisFile").toFile("C:\\NewFolder");
	/// </code>
	/// </example>
	/// </summary>
	public sealed class FileTransfer : IServer, IWrite, IRead, IAction, IAuth
	{
		#region Params
		private string connectionAdressString;
		private Uri connectionAdressUri;
		private string portAdress;
		private string fileName;
		public Auth Auth { get; set; }
		#endregion

		#region Constructors
		private FileTransfer(string connectionAdress)
		{

			this.connectionAdressString = connectionAdress;
		}
		private FileTransfer(Uri connectionAdress)
		{

			this.connectionAdressUri = connectionAdress;
		}
		#endregion

		#region Connection
		public static IServer Connect(string connectionAdress)
		{

			return new FileTransfer(connectionAdress);
		}
		public static IServer Connect(Uri connectionAdress)
		{

			return new FileTransfer(connectionAdress);
		}
		#endregion

		#region Action
		public IWrite Download(string file)
		{

			this.fileName = file;
			return this;
		}

		public IRead Upload(string file)
		{

			this.fileName = file;
			return this;

		}
		#endregion

		#region Server
		public IAuth onPort(string portAdress)
		{

			this.portAdress = portAdress;
			return this;
		}
		#endregion

		#region Authentification
		public AuthBuilder AuthConfig()
		{

			this.Auth = new Auth();
			return new AuthBuilder(this);
		}
		#endregion

		#region Read
		public void fromFile(string path)
		{

			//some implementation...
			Console.WriteLine(this.ToString());
		}

		public void fromStream(string stream)
		{
			//some implementation...
			Console.WriteLine(this.ToString());
		}
		#endregion

		#region Write
		public void toFile(string path)
		{

			//some implementation...
			Console.WriteLine(this.ToString());
		}

		public void toStream(string stream)
		{

			//some implementation...
			Console.WriteLine(this.ToString());
		}
		#endregion


		public override string ToString()
		{

			return "Server adress: " + connectionAdressUri == null ? connectionAdressUri.ToString() : connectionAdressString + " Port: " + portAdress + " Username: " + Auth.Username + " Password: " + Auth.Password + " File: " + fileName; 
		}
	}
}
