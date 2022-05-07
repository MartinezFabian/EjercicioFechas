namespace EjercicioFechas
{
    internal class Program
    {
        static void Main()
        {
            DateTime fechaUno = new DateTime(2022, 1, 1);
            DateTime fechaDos = new DateTime(2022, 12, 31);

            GestionFechas gf = new GestionFechas();

            Console.WriteLine("Dias entre fecha1 y fecha2: " + gf.obtenerDiasCalendario(fechaDos, fechaUno));

            Console.WriteLine("Dias laborales: " + gf.obtenerDiasLaborales(fechaUno, fechaDos));

            Console.WriteLine("Sumar 9 dias a 1/01: " + gf.sumarDias(fechaUno, 9));

        } 
    }
}
