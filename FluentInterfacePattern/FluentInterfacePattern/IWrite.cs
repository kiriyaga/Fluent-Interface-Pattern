using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfacePattern
{
	public interface IWrite
	{

		void toFile(String path);

		void toStream(String stream);

	}
}
