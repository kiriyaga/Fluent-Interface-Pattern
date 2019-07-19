using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfacePattern
{
	public interface IAction
	{

		IWrite Download(string file);

		IRead Upload(string file);

	}
}
