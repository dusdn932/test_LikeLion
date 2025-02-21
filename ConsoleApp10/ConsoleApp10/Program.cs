using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//오후강의
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자 데이터 형식: char
            /*char letter = 'A'; // 문자 'A' 저장
            char symbol = '#'; // 특수 기호 저장
            char number = '9'; // 숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)
            Console.WriteLine(letter); // 출력: A
            Console.WriteLine(symbol); // 출력: #
            Console.WriteLine(number); // 출력: 9*/

            //문자열 데이터 형식 : string
            /* string greeting = "Hello, World!"; // 문자열 저장
             string name = "Alice"; // 이름 저장
             Console.WriteLine(greeting); // 출력: Hello, World!
             Console.WriteLine(name); // 출력: Alice
             Console.WriteLine(greeting +" " + name); //Hellom World! Alice*/

            //논리 데이터 형식 : bool
            /* bool isRunning = true; // 프로그램 실행 상태
             bool isFinished = false; // 프로그램 종료 상태
             Console.WriteLine(isRunning); // 출력: True
             Console.WriteLine(isFinished); // 출력: False*/

            //닷넷 데이터 형식
            //예: System.Int32 , System.Double
            /*System.Int32 number = 123; // int의 닷넷 형식
            System.String text = "Hello"; // string의 닷넷 형식
            System.Boolean flag = true; // bool의 닷넷 형식
            Console.WriteLine(number); // 출력: 123
            Console.WriteLine(text); // 출력: Hello
            Console.WriteLine(flag); // 출력: True*/

            //래퍼 형식
            /*int number = 123;
            string numberAsString = number.ToString(); // 정수를 문자열로 변환
            // bool 래퍼 형식의 메서드 활용
            bool flag = true;
            string flagAsString = flag.ToString(); // 논리값을 문자열로 변환
            Console.WriteLine(numberAsString); // 출력: "123"
            Console.WriteLine(flagAsString); // 출력: "True"*/


        }
    }
}
