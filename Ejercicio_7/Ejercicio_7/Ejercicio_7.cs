using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_7
{
    public class Ejercicio_7
    {
        static void Main(string[] args)
        {

            DateTime hoy;
            hoy = DateTime.Now;

            int diaActual = hoy.Day;
            int mesActual = hoy.Month;
            int anioActual = hoy.Year;

            int diaNacimiento = 0;
            int mesNacimiento = 0;
            int anioNacimiento = 0;

            int acumulador = 0;

            string cadena = " ";
            Console.WriteLine("\n\nIngrese el DIA de Nacimiento\n\n");
            cadena = Console.ReadLine();
            diaNacimiento = Validacion.ValidarEntero(cadena);

            Console.WriteLine("\n\nIngrese el MES de Nacimiento\n\n");
            cadena = Console.ReadLine();
            mesNacimiento = Validacion.ValidarEntero(cadena);

            Console.WriteLine("\n\nIngrese el AÑO de Nacimiento\n\n");
            cadena = Console.ReadLine();
            anioNacimiento = Validacion.ValidarEntero(cadena);

           

            for (int anio = anioNacimiento; anio <= anioActual; anio++) 
            {
                //Desde el año de nacimiento hasta
                //año actual
                                                          
                if ((anio == anioNacimiento)&&(anio != anioActual))                                                                         
                {
                     #region   AÑO DE NACIMIENTO PERO NO AÑO ACTUAL   
                       
                    //Mientras este dentro del año Nac   
                    //y no sea el año actual ej. 1981  
                   
                    if (Validacion.AnioBisiesto(anio))                 
                    {
                        //Si es año Bisiesto
                        #region AÑO BISIESTO
                 
                        //Desde al mes de Nac hasta                                            
                        //dic de año Nac
                        #region AÑO NAC Y MES DE NAC HASTA AÑO NAC MES DICIEMBRE 

                        
                        for (int mes = mesNacimiento; mes <= 12;mes++)  
                        {  
                            if (mes == mesNacimiento)               
                            {
                                //si es el mes de Nac
                                //suma los dias de ese mes de Nac

                                #region AÑO NAC Y MES DE NAC                                           
                               
                                switch (mes)                            
                                {
                                    case 1:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 2:
                                        for (int dia = diaNacimiento; dia <= 29; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 3:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 4:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 5:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 6:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 7:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 8:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 9:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 10:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 11:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 12:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;


                                }
                                #endregion
                            }
                            //si no es el mes de Nac
                            //y estoy en el año de Nac
                            if (mes != mesNacimiento)   
                            {
                                //sumo los dias desde el SIGUIENTE mes, AL MES DE NAC
                                //hasta diciembre
                                #region AÑO NACIMIENTO Y MESES POSTERIORES AL MES NAC HASTA AÑO NAC MES DIC

                                switch (mes)            
                                {                       
                                    case 1:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 2:
                                        for (int dia = 1; dia <= 29; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 3:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 4:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 5:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 6:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 7:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 8:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 9:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 10:
                                        for (int dia = 1 ; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 11:
                                        for (int dia = 1 ; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 12:
                                        for (int dia = 1 ; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                               
                                }
                                #endregion
                            }
                           
                        }
                        #endregion
                    }
                    #endregion
                   
                    else
                    {
                        //Si no es año Bisiesto
                        #region NO AÑO BISIESTO
                        

                        #region AÑO NAC Y MES DE NAC HASTA AÑO NAC MES DICIEMBRE 

                        //Desde al mes de Nac hasta                                            
                        //dic de año Nac                                        
                        for (int mes = mesNacimiento; mes <= 12; anio++)
                        {
                            if (mes == mesNacimiento)
                            {   
                                //si es el mes de Nac
                                //suma los dias de ese mes de Nac
                                #region AÑO NAC Y MES DE NAC                                           
                                

                                switch (mes)
                                {
                                    case 1:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 2:
                                        for (int dia = diaNacimiento; dia <= 28; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 3:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 4:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 5:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 6:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 7:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 8:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 9:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 10:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 11:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 12:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;
                                }
                            #endregion

                            }

                            //si no es el mes de Nac
                            //y estoy en el año de Nac

                            if (mes != mesNacimiento)
                            {
                                //sumo los dias desde el SIGUIENTE mes, AL MES DE NAC
                                //hasta diciembre
                                #region AÑO NACIMIENTO Y MESES POSTERIORES AL MES NAC HASTA AÑO NAC MES DIC


                                switch (mes)
                                {
                                    case 1:
                                        for (int dia = 1 ; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 2:
                                        for (int dia = 1; dia <= 28; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 3:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 4:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 5:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 6:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 7:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 8:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 9:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 10:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 11:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 12:
                                        for (int dia = 1 ; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;
                                }
                                #endregion
                            }
                        }
                        #endregion
                        #endregion

                    }
                    #endregion
                }

               
                if ((anio>anioNacimiento) && (anio<anioActual))
                {
                    
                    #region ENTRE AÑO > AÑO DE NACIMIENTO Y AÑO < AÑO ACTUAL
                    // SIGUIENTE AÑO AL AÑO DE NACIMIENTO HASTA 
                    // UN AÑO ANTES AL AÑO ACTUAL

                    if (Validacion.AnioBisiesto(anio))
                    {
                        acumulador = acumulador + 366;
                    }
                    else
                    {
                        acumulador = acumulador + 365;
                    }
                    #endregion

                }

                if ((anio == anioActual) && (anioActual == anioNacimiento))
                {
                    if (mesNacimiento == mesActual)//Validacion.AnioBisiesto(anio)
                    {
                        //Si es año Bisiesto
                        #region AÑO BISIESTO

                        //Desde al dia de Nac hasta                                            
                        //ultimo dia del Mes de Nac
                        #region AÑO NAC = AÑO ACTUAL Y MES DE NAC = MES ACTUAL 

                        if (diaNacimiento <= diaActual)
                        {

                            for (int dia = diaNacimiento; dia <= diaActual; dia++)
                            {
                                acumulador = acumulador + 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\n ERROR, LA FECHA NO CORRESPONDE\n\n");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        if (Validacion.AnioBisiesto(anio))
                        {
                            if (mesNacimiento <= mesActual)
                            {
                                for (int mes = mesNacimiento; mes <= mesActual; mes++)
                                {
                                    if (mes == mesNacimiento)
                                    {
                                        switch (mes)
                                        {
                                            case 1:
                                                for (int dia = diaNacimiento; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 2:
                                                for (int dia = diaNacimiento; dia <= 29; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 3:
                                                for (int dia = diaNacimiento; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 4:
                                                for (int dia = diaNacimiento; dia <= 30; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 5:
                                                for (int dia = diaNacimiento; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 6:
                                                for (int dia = diaNacimiento; dia <= 30; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 7:
                                                for (int dia = diaNacimiento; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 8:
                                                for (int dia = diaNacimiento; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 9:
                                                for (int dia = diaNacimiento; dia <= 30; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 10:
                                                for (int dia = diaNacimiento; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 11:
                                                for (int dia = diaNacimiento; dia <= 30; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 12:
                                                for (int dia = diaNacimiento; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;
                                        }
                                    }
                                    if ((mes > mesNacimiento) && (mes < mesActual))
                                    {
                                        switch (mes)
                                        {
                                            case 1:
                                                for (int dia = 1; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 2:
                                                for (int dia = 1; dia <= 29; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 3:
                                                for (int dia = 1; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 4:
                                                for (int dia = 1; dia <= 30; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 5:
                                                for (int dia = 1; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 6:
                                                for (int dia = 1; dia <= 30; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 7:
                                                for (int dia = 1; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 8:
                                                for (int dia = 1; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 9:
                                                for (int dia = 1; dia <= 30; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 10:
                                                for (int dia = 1; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 11:
                                                for (int dia = 1; dia <= 30; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;

                                            case 12:
                                                for (int dia = 1; dia <= 31; dia++)
                                                {
                                                    acumulador = acumulador + 1;
                                                }
                                                break;
                                        }
                                    }
                                    if (mes == mesActual)
                                    {
                                        for (int dia = 1; dia <= diaNacimiento; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("\n\n ERROR, LA FECHA NO CORRESPONDE\n\n");
                                Console.ReadKey();
                            }
                        }




                    }
                }
                else
                    {
                        
                    }
    /////////////////////////////////////////////////////////////////////////////////////////////////
                        for (int mes = mesNacimiento; mes <= 12; mes++)
                        {
                            if (mes == mesNacimiento)
                            {
                                //si es el mes de Nac
                                //suma los dias de ese mes de Nac

                                #region AÑO NAC Y MES DE NAC                                           

                                switch (mes)
                                {
                                    case 1:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 2:
                                        for (int dia = diaNacimiento; dia <= 29; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 3:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 4:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 5:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 6:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 7:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 8:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 9:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 10:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 11:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 12:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;


                                }
                                #endregion
                            }
                            //si no es el mes de Nac
                            //y estoy en el año de Nac
                            if (mes != mesNacimiento)
                            {
                                //sumo los dias desde el SIGUIENTE mes, AL MES DE NAC
                                //hasta diciembre
                                #region AÑO NACIMIENTO Y MESES POSTERIORES AL MES NAC HASTA AÑO NAC MES DIC

                                switch (mes)
                                {
                                    case 1:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 2:
                                        for (int dia = 1; dia <= 29; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 3:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 4:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 5:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 6:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 7:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 8:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 9:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 10:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 11:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 12:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;


                                }
                                #endregion
                            }

                        }
                        #endregion
                    }
                    #endregion

                    else
                    {
                        //Si no es año Bisiesto
                        #region NO AÑO BISIESTO


                        #region AÑO NAC Y MES DE NAC HASTA AÑO NAC MES DICIEMBRE 

                        //Desde al mes de Nac hasta                                            
                        //dic de año Nac                                        
                        for (int mes = mesNacimiento; mes <= 12; anio++)
                        {
                            if (mes == mesNacimiento)
                            {
                                //si es el mes de Nac
                                //suma los dias de ese mes de Nac
                                #region AÑO NAC Y MES DE NAC                                           


                                switch (mes)
                                {
                                    case 1:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 2:
                                        for (int dia = diaNacimiento; dia <= 28; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 3:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 4:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 5:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 6:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 7:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 8:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 9:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 10:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 11:
                                        for (int dia = diaNacimiento; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 12:
                                        for (int dia = diaNacimiento; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;
                                }
                                #endregion

                            }

                            //si no es el mes de Nac
                            //y estoy en el año de Nac

                            if (mes != mesNacimiento)
                            {
                                //sumo los dias desde el SIGUIENTE mes, AL MES DE NAC
                                //hasta diciembre
                                #region AÑO NACIMIENTO Y MESES POSTERIORES AL MES NAC HASTA AÑO NAC MES DIC


                                switch (mes)
                                {
                                    case 1:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 2:
                                        for (int dia = 1; dia <= 28; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 3:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 4:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 5:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 6:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 7:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 8:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 9:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 10:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 11:
                                        for (int dia = 1; dia <= 30; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;

                                    case 12:
                                        for (int dia = 1; dia <= 31; dia++)
                                        {
                                            acumulador = acumulador + 1;
                                        }
                                        break;
                                }
                                #endregion
                            }
                        }
                        #endregion
                        #endregion

                    }



                }

            }
        }
    }
}