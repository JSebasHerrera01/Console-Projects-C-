using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa10
    {
        public void programa()
        {
            // Nomina de empleados 
         String nombre, recargo, continuar; 
         int cedula, salario, auxilio_transporte, dias, sueldo;
         double hed, hen, hefd, hefn, vhed, vhen, vhefd, vhefn;
         double total_devengado, salud, pension, fondo_solidaridad;
         int recargo_nocturno, prestamos;
         double total_deducido, neto_pagado;
            
        do
        {
        Console.Clear();
        Console.WriteLine("10. Nomina de Empleados\n");
        //Entradas
        Console.WriteLine("Digite la cedula de Ciudadania del Empleado");
        cedula = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite el Nombre del Empleado");
        nombre = Console.ReadLine();
        Console.WriteLine("Digite el Salario del Empleado");
        salario = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite los dias laborados por el Empleado");
        dias = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite las horas extras diurnas laboradas por el Empleado");
        hed = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite las horas extras nocturnas laboradas por el Empleado");
        hen = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite las horas extras festivas diurnas laboradas por el Empleado");
        hefd = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite las horas extras festivas nocturnas laboradas por el Empleado");
        hefn = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite los prestamos generados por el Empleado");
        prestamos = int.Parse(Console.ReadLine());
                //Procesos
                if (salario >= 1000000 && salario <= 2000000)
            auxilio_transporte = 117172 / 30 * dias;
        else
            auxilio_transporte = 0;
        sueldo = salario / 30 * dias;
        vhed = salario / 30 / 8 * 1.25 * hed;
        vhen = salario / 30 / 8 * 1.75 * hen;
        vhefd = salario / 30 / 8 * 2 * hefd;
        vhefn = salario / 30 / 8 * 2.25 * hefn;
        Console.WriteLine("El empleado tiene recargonocturno s / n");
        recargo = Console.ReadLine();
        if (recargo == "s")
            recargo_nocturno = salario * 35 / 100;
        else
            recargo_nocturno = 0;
        total_devengado = sueldo + auxilio_transporte + vhed + vhen + vhefd + vhefn;
        salud = (total_devengado - auxilio_transporte) * 4 / 100;
        pension = (total_devengado - auxilio_transporte) * 4 / 100;
        if(salario>=4000000 && salario <= 16000000)
            fondo_solidaridad = salario * 1 / 100;
        else if(salario > 16000000 && salario<= 17000000)
            fondo_solidaridad = salario * 1.2 / 100;
        else if (salario > 17000000 && salario <= 18000000)
            fondo_solidaridad = salario * 1.4 / 100;
        else if (salario > 18000000 && salario <= 19000000)
            fondo_solidaridad = salario * 1.6 / 100;
        else if (salario > 19000000 && salario <= 20000000)
            fondo_solidaridad = salario * 1.8 / 100;
        else if (salario >= 20000000)
            fondo_solidaridad = salario * 2 / 100;
        else
            fondo_solidaridad = 0;
        total_deducido = salud + pension + fondo_solidaridad + prestamos;
                neto_pagado = total_devengado - total_deducido;
                //Salidas
        Console.Clear();
        Console.WriteLine("Universidad Ecci");
        Console.WriteLine("Nomina de Empleados");
        Console.WriteLine("Informacion del Empleado");
        Console.WriteLine("Cedula de Ciudadania=" + cedula);
        Console.WriteLine("Nombre del empleado=" + nombre);
        Console.WriteLine("Salario del Empleado=" + salario);
        Console.WriteLine("Dias Laborados=" + dias);
        Console.WriteLine("Horas Extras Diurnas=" + hed);
        Console.WriteLine("Horas Extras Nocturnas=" + hen);
        Console.WriteLine("Horas Extras Festivas Diurnas=" + hefd);
        Console.WriteLine("Horas Extras Festivas Nocturnas=" + hefn);
        Console.WriteLine("Salario Devengado");
        Console.WriteLine("Sueldo Mes= "+sueldo);
        Console.WriteLine("Auxilio de Transporte="+auxilio_transporte);
        Console.WriteLine("Valor Horas Extras Diurnas=" + vhed);
        Console.WriteLine("Valor Horas Extras Diurnas=" + vhen);
        Console.WriteLine("Valor Horas Extras Festivas Diurnas=" + vhefd);
        Console.WriteLine("Valor Horas Extras Festivas Nocturnas=" + vhefn);
        Console.WriteLine("Recargo Nocturno=" + recargo_nocturno);
        Console.WriteLine("Total_Devengado=" + total_devengado);
        Console.WriteLine("Salario Deducido");
        Console.WriteLine("Salud=" + salud);
        Console.WriteLine("Pension=" + pension);
        Console.WriteLine("Fondo de Solidaridad=" + fondo_solidaridad);
        Console.WriteLine("Prestamos=" + prestamos);
        Console.WriteLine("Total Deducido=" + total_deducido);
        Console.WriteLine("Neto Pagado=" + neto_pagado);



        Console.WriteLine("Desea Repetir el Programa de Nomina De Empleados s / n");
        Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
        continuar = Console.ReadLine();
        } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");

        }
    }
}
