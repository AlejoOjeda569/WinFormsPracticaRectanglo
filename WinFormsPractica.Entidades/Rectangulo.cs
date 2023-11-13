namespace WinFormsPractica.Entidades
{
    public class Rectangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public Borde Borde { get; set; }
        public Relleno Relleno { get; set; }
        public int GetPerimetro() => (Base + Altura) * 2;
        public int GetArea() => Base * Altura;
    }
}