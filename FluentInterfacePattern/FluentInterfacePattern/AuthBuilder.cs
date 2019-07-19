using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfacePattern
{
	public class AuthBuilder
	{
		private FileTransfer fileTransfer;

		public AuthBuilder(FileTransfer fileTransfer)
		{

			this.fileTransfer = fileTransfer;
		}
		/// <summary>
		/// Set username to Auth object in fileTransfer who is placeholder for login informations
		/// </summary>
		/// <param name="username"></param>
		/// <returns>Authbuilder(this) so we can configure(set) another parameteres</returns>
		public AuthBuilder SetUsername(string username)
		{

			fileTransfer.Auth.Username = username;
			return this;
		}
		/// <summary>
		/// Set username to Auth object in fileTransfer who is placeholder for login informations
		/// </summary>
		/// <param name="password"></param>
		/// <returns>Authbuilder(this) so we can configure(set) another parameteres</returns>
		public AuthBuilder SetPassword(string password)
		{

			fileTransfer.Auth.Password = password;
			return this;
		}
		/// <summary>
		/// Continue to configure file transfer
		/// </summary>
		/// <returns>fileTransfer but like IAction (only can call methods from this interface)</returns>
		/// <see cref="IAction"/>
		public IAction And()
		{

			return fileTransfer;
		}
	}
}
