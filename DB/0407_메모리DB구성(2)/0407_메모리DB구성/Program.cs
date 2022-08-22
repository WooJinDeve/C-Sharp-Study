﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0407_메모리DB구성
{
    internal class Program
    {
        private Control con = Control.Instance;

        public bool Init()
        {
            WbPrint.Logo();

            return true;
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                con.PrintAll();
                ConsoleKey key = WbPrint.MenuPrint();
                Console.Write("\b");
                switch (key)
                {                    
                    case ConsoleKey.F1:     con.DesignTable();      break;
                    case ConsoleKey.F2:     con.TableSchemaPrint(); break;
                    case ConsoleKey.F3:     con.MemberAdd();        break;
                    case ConsoleKey.F4:     con.AccountAdd();       break;
                    case ConsoleKey.F5:     con.PrintAll();         break;
                    case ConsoleKey.Escape: return;
                }
                WbPrint.Pause();
            }
        }

        public void Exit()
        {
            WbPrint.Ending();
        }

        public static void Main()
        {
            Program pr = new Program();

            if (pr.Init() == true)
            {
                pr.Run();
            }

            pr.Exit();

            return;
        }

    }
}
