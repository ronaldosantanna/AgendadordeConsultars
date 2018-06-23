using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Modelos;

namespace App1.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detalhes : ContentPage
	{
		public Detalhes (Consultas consulta)
		{
			InitializeComponent ();

            BindingContext = consulta;
		}
    }
}