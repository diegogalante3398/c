using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    class Conta
    {

		private Cliente _titutlar;

		public Cliente Titular
		{
			get { return _titutlar; }
			set { _titutlar = value; }
		}

	}
}
