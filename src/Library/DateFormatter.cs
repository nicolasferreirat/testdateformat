namespace Ucu.Poo.TestDateFormat;

public class DateFormatter
{
    public static string ChangeFormat(string date)
    {
        //chequeo que el año no esté escrito entre guiones y si con barras.
        if (date.Length == 10 && date[2]=='/' && date[5]== '/')  
        {
            //Le pongo nombre a cada variable de acuerdo al índice que está escrito.
            string year = date.Substring(6);              
            string month = date.Substring(3,2);
            string day = date.Substring(0,2);

            //convierto las variables que están en string a int para poder comparar su tamaño.
            int numYear = int.Parse(year);               
            int numMonth = int.Parse(month);
            int numDay = int.Parse(day);

            //Chequeo que el año, el mes y el día sean válidos
            if (numYear > 0 && numYear < 10000 && numMonth > 0 && numMonth < 13 && numDay > 0 && numDay < 32)
            {
                return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
            }
            else {throw new Exception("Fecha inválida");}
        }
        else {throw new Exception("Fecha inválida");}
    }
}
