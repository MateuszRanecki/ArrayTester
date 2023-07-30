using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTester
{
    class AppScripts
    {
       public void AddOriginValue() {
            Random random = new Random();
            using (var context = new ArrayContext())
            {
                var array = new WholeArray();
                var partial = new PartialData();
               for(int i =0; i < array.ByteArray.Length; i++)
               {
                    array.ByteArray[i] = (byte)(random.Next(255));
               }
               partial.Value_0 = array.ByteArray[0];
               partial.Value_1 = array.ByteArray[1];
               partial.Value_2 = array.ByteArray[2];
               partial.Value_3 = array.ByteArray[3];
               partial.Value_4 = array.ByteArray[4];
               partial.Value_5 = array.ByteArray[5];
               partial.Value_6 = array.ByteArray[6];
               partial.Value_7 = array.ByteArray[7];
                context.Add(array);
                context.Add(partial);
                context.SaveChanges();
            }
        }

        public void EditValue()
        {
            Random random = new Random();
            using (var context = new ArrayContext())
            {
                // Tabela Zawierająca 8-elemetową tablicę ze zmiennymi typu byte
                var array = context.Array.FirstOrDefault();
                // Tabela w której znajdują się zmienne rozdzielone z tablicy
                var partial = context.PortionData.FirstOrDefault();
                if (array != null && partial != null) {
                    for (int i = 0; i < array.ByteArray.Length; i++)
                    {
                        array.ByteArray[i] = (byte)(random.Next(255));
                    }
                // Ta część skryptu przesyła elementy z tabeli z tablicą i przypisuje do osobnych kolumn  
                    partial.Value_0 = array.ByteArray[0];
                    partial.Value_1 = array.ByteArray[1];
                    partial.Value_2 = array.ByteArray[2];
                    partial.Value_3 = array.ByteArray[3];
                    partial.Value_4 = array.ByteArray[4];
                    partial.Value_5 = array.ByteArray[5];
                    partial.Value_6 = array.ByteArray[6];
                    partial.Value_7 = array.ByteArray[7];
                // W tym momencie każdy element tablicy jest przesłany do osobnej kolumny
                    context.SaveChanges();
                    Console.WriteLine(partial.Value_0);
                }  
            }
        }
    }
}
