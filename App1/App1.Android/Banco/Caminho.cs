using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using App1.Banco;
using System.IO;
using App1.Droid.Banco;

[assembly:Dependency(typeof(Caminho))]
namespace App1.Droid.Banco
{
    public class Caminho : Icaminho
    {
        public string GetCaminho(string NomeABanco)
        {
            string caminhodapasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhobanco = Path.Combine(caminhodapasta, NomeABanco);

            return caminhobanco;
        }
    }
}