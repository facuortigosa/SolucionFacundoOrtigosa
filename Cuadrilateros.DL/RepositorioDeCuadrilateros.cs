using Cuadrilateros.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cuadrilateros.DL
{
    public class RepositorioDeCuadrilateros
    {
        public List<Cuadrilatero> ListaCuadrilateros { get; set; } = new List<Cuadrilatero>();

        public bool IsModified { get; set; } = false;

        public void GuardarDatosEnArchivo()
        {
            var archivo = Application.StartupPath + @"\ArchivoDeCuadrilateros.txt";
            StreamWriter escritor = new StreamWriter(archivo);

            foreach (var c in ListaCuadrilateros)
            {
                var linea = $"{c.Lado1};{c.Lado2}";
                escritor.WriteLine(linea);
            }
            escritor.Close();
        }

        public void LeerDatosEnArchivo()
        {
            var archivo = Application.StartupPath + @"\ArchivoDeCuadrilateros.txt";

            if (File.Exists(archivo))
            {
                StreamReader lector = new StreamReader(archivo);

                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    var campos = linea.Split(';');
                    Cuadrilatero cuadrilatero = new Cuadrilatero();
                    {
                        cuadrilatero.Lado1 = int.Parse(campos[0]);
                        cuadrilatero.Lado2 = int.Parse(campos[1]);
                    };
                    ListaCuadrilateros.Add(cuadrilatero);

                }

                lector.Close();
            }
        }

        public RepositorioDeCuadrilateros()
        {
            LeerDatosEnArchivo();
        }

        public List<Cuadrilatero> GetLista()
        {
            return ListaCuadrilateros;
        }

        public void Agregar(Cuadrilatero cuadrilatero)
        {
            ListaCuadrilateros.Add(cuadrilatero);
            IsModified = true;
        }
        public void Borrar(Cuadrilatero cuadrilatero)
        {
            ListaCuadrilateros.Remove(cuadrilatero);
            IsModified = true;
        }

        public int GetCantidad()
        {
            return ListaCuadrilateros.Count();
        }

        public List<Cuadrilatero> GetListaPerimetroAscendente()
        {
            return ListaCuadrilateros.OrderBy(c => c.GetPerimetro()).ToList();

        }

        public List<Cuadrilatero> GetListaPorLadoDescendente()
        {
            return ListaCuadrilateros.OrderByDescending(c => c.Lado1).ToList();
        }

        public void Editar(Cuadrilatero cuadrilatero)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Cuadrilatero cOriginal, Cuadrilatero cNuevo)
        {
            return true;
        }



    }
}
