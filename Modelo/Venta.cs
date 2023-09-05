namespace Modelo
{
    public class Venta
    {
        // Atributos
        public string Cliente { get; set; }
        public string RUC { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Producto { get; set; } 
        public int Cantidad { get; set; }

        // Métodos de la clase Venta
        public double AsignaPrecio()
        {
            switch(Producto)
            {
                case "Lavadora": return 1500;
                case "Refrigeradora": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "BluRay": return 250;
            }
            return 0;
        }

        // Método que calcula el subtotal
        public double CalculaSubtotal()
        {
            return AsignaPrecio() * Cantidad;
        }
    }
}