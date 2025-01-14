
namespace PVrepository.Entities
{
    public class Cajas
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaApertura { get; set; }
        public int SaldoInicial { get; set; }
        public DateTime FechaCierre { get; set; }
        public int SaldoFinal { get; set; }
        public string Condicion { get; set; } //Values: 'Abierta' / 'Cerrada'
        public int Resultado { get; set; }
    }
}

