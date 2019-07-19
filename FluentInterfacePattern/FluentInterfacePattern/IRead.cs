using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfacePattern
{
	public interface IRead
	{

		void fromFile(String path);

		void fromStream(String stream);

	}
}
