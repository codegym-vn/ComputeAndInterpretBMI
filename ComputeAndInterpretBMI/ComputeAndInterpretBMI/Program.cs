using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAndInterpretBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào cân nặng
            Console.Write("Please enter the weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            //Nhập vào chiều cao
            Console.Write("Please enter the height (m): ");
            double height = double.Parse(Console.ReadLine());

            //Tính chỉ số BMI
            double bmi = weight / (height * height);

            //Hiển thị kết quả
            Console.WriteLine("BMI is " + bmi);
            if (bmi < 18.5)
                Console.WriteLine("Underweight");
            else if (bmi < 25)
                Console.WriteLine("Normal");
            else if (bmi < 30)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");

            Console.ReadLine();
        }
    }
}
