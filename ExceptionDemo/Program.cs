using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diem = -1;
            try
            {
                diem = NhapDiem();
            }catch (CheckScoreException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //do some thing
            }
            

            #region
            //try
            //{
            //    x = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Nhap lai du lieu");
            //    x = int.Parse(Console.ReadLine());
            //}
            //finally
            //{
            //    if (x >= 10)
            //        Console.WriteLine("x = " + x);
            //}
            #endregion


            Console.ReadLine();
        }


        static double NhapDiem()
        {
            double diem = -1;
            Console.WriteLine("Nhap diem:");
            diem = double.Parse(Console.ReadLine());
            if(diem<0||diem>10)
            {
                throw new CheckScoreException("Diem khong hop le");
            }
            return diem;
        }
    }
}
