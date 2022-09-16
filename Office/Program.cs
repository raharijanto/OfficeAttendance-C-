using System;

namespace Office
{
    class Program
    {
        string[] maleEmployees = {
            "Mr. 0",
            "Mr. 1",
            "Mr. 2",
            "Mr. 3",
            "Mr. 4",
            "Mr. 5"
        };
        
        string[] femaleEmployees = {
            "Miss All Sunday",
            "Miss Doublefinger",
            "Miss Goldenweek",
            "Miss Merry Christmas",
            "Miss Valentine"
        };
        
        static void Main(string[] args)
        {
            Program BW = new Program();
            BW.showEmployee();
            BW.todayMeeting();

            Console.WriteLine(BW.malePercentage());
            Console.WriteLine(BW.femalePercentage());
        }

        void showEmployee()
        {
            Console.WriteLine("Pegawai laki-laki yang masuk hari ini:");
            foreach (string m in maleEmployees)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine();

            Console.WriteLine("Pegawai perempuan yang masuk hari ini:");
            foreach (string f in femaleEmployees)
            {
                Console.WriteLine(f);
            }
        }

        void todayMeeting()
        {
            Console.WriteLine();

            if (maleEmployees.Length < 6 && femaleEmployees.Length < 6)
            {
                Console.WriteLine("Rapat tidak mencapai kuorum");
            }
            else
            {
                Console.WriteLine("Rapat berlangsung");
            }
        }

        float malePercentage()
        {
            return maleEmployees.Length/13F;
        }

        float femalePercentage()
        {
            return femaleEmployees.Length/12F;
        }
    }
}
