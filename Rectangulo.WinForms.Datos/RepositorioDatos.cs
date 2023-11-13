using WinFormsPractica.Entidades;

namespace WinForms.Datos
{
    public class RepositorioDatos
    {
        private readonly string _Archivo = Environment.CurrentDirectory + "\\Rectangulo.txt";
        private List<Rectangulo> rectangulos;
        public RepositorioDatos() 
        { 
          rectangulos=new List<Rectangulo>();
            LeerDatosArchivo();
        }

        private void LeerDatosArchivo()
        {

            if (File.Exists(_Archivo))
            {
                using (var lector = new StreamReader(_Archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        var lineaLeida = lector.ReadLine();
                        var rectangulo = construirRectangulo(lineaLeida);
                        rectangulos.Add(rectangulo);
                    }
                }
            }
            
        }
        public List<Rectangulo> GetLista() => rectangulos;
        private Rectangulo construirRectangulo(string? lineaLeida)
        {
            var campos = lineaLeida.Split("|");
            var baseRectangulo = int.Parse(campos[0]);
            var alturaRectangulo = int.Parse(campos[1]);
            var bordeRectangulo =(Borde) int.Parse(campos[2]);
            var rellenoRectangulo = (Relleno)int.Parse(campos[3]);
            return new Rectangulo
            {
                Base = baseRectangulo,
                Altura = alturaRectangulo,
                Borde = bordeRectangulo,
                Relleno = rellenoRectangulo,

            };
        }

        public void Agregar (Rectangulo rectangulo)
        {
            using (var escribir=new StreamWriter(_Archivo,true))
            {
                string lineaEscribir= construirLinea(rectangulo);
                escribir.WriteLine(lineaEscribir);
            }
        }

        private string construirLinea(Rectangulo rectangulo)
        {
            return $"{rectangulo.Base}|{rectangulo.Altura}|{rectangulo.Borde.GetHashCode()}|{rectangulo.Relleno.GetHashCode()}";
        }

        public void Borrar (Rectangulo rectangulo) 
        { 
        
        }
    }
}