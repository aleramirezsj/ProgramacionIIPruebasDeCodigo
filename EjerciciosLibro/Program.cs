
public class Program
{
    private static void Main(string[] args)
    {
        //CompararNumeros();
        //HorasFaltantes();
        CalcularValorPago();
    }

    private static void CalcularValorPago()
    {
        int dia; 
        double cuotaReal;

        Console.Write("Ingrese el día de pago:");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el monto de la cuota:");
        cuotaReal = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case <3:
                cuotaReal=cuotaReal-(cuotaReal*0.03); 
                break;
            case >=6 and <=10:
                cuotaReal += (cuotaReal * 0.1);
                break;
            case  >= 11 and <= 20:
                cuotaReal = cuotaReal - (cuotaReal * 0.12);
                break;
            case  >= 21 and <= 31:
                cuotaReal = cuotaReal - (cuotaReal * 0.15);
                break;

        }
        Console.WriteLine($"La cuota a pagar es: {cuotaReal}");

    }

    public static void CompararNumeros()
    {
        //declarar las variables
        int numero1, numero2;

        //leer los valores
        Console.Write("Ingrese un número:");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese otro número:");
        numero2 = int.Parse(Console.ReadLine());
        //compararlos
        if (numero1 > numero2) {
            Console.WriteLine($"el mayor es {numero1}");
        }else if(numero2 > numero1)
        {
            Console.WriteLine($"el mayor es {numero2}");
        }else
        {
            Console.WriteLine("son iguales");
        }
    }
    public static void HorasFaltantes()
    {
        //definimos las variables
        int horasTrabajadas, horasFaltantes;
        string dia;

        //le pedimos al usuario que ingrese las horas trabajadas y el
        //día de la semana
        Console.Write("Ingrese las horas trabajadas(entre 1 y 5):");
        horasTrabajadas=int.Parse(Console.ReadLine());

        Console.Write("Ingrese el día de la semana:");
        dia = Console.ReadLine();

        horasFaltantes = 5 - horasTrabajadas;

        if(dia.ToUpper()=="JUEVES"  )
        {
            horasFaltantes += 2;
        }

        Console.WriteLine($"Las horas faltantes son {horasFaltantes}");
    }
}