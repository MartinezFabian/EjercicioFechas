namespace EjercicioFechas
{
    internal class GestionFechas
    {
        public int obtenerDiasCalendario(DateTime fechaUno, DateTime fechDos)
        {
            TimeSpan diferencia = TimeSpan.Zero;

            int resultado = DateTime.Compare(fechaUno, fechDos);

            if (resultado > 0)
            {
                diferencia = fechaUno - fechDos;
            }
            else if (resultado < 0)
            {
                diferencia = fechDos - fechaUno;
            }
            else if (resultado == 0)
            {
                diferencia = TimeSpan.Zero;
            }

            return diferencia.Days;
        }

        public int obtenerDiasLaborales(DateTime fechaUno, DateTime fechDos)
        {
            DateTime[] feriados =
            {
                new DateTime(2022, 01, 01),
                new DateTime(2022, 02, 28),
                new DateTime(2022, 03, 01),
                new DateTime(2022, 03, 24),
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 15),
                new DateTime(2022, 05, 01),
                new DateTime(2022, 05, 25),
            };

            int cont = 0;
            bool esFeriado = false;

            for (DateTime fecha1 = fechaUno; fecha1 <= fechDos; fecha1 = fecha1.AddDays(1))
            {
                if (fecha1.DayOfWeek != DayOfWeek.Saturday && fecha1.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int i = 0; i < feriados.Length; i++)
                    { 
                        if(fecha1 == feriados[i])
                        {
                            Console.WriteLine(fecha1.ToShortDateString() + " no es fin de semana pero es feriado");
                            esFeriado = true;
                            break;
                        }
                    }

                    if (esFeriado == false)
                    {
                        cont++;
                    }

                    esFeriado = false;
                }
            }

            return cont;
        }

        public DateTime sumarDias(DateTime fecha ,int diasAsumar)
        {
            DateTime fechaNueva = fecha.AddDays(diasAsumar);

            return fechaNueva;
        }
    }
}
