using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Character
    {
        public void CharacterSelect(ref int character, ref string[] player_form)
        {
            int loop_count = 0;

            while (true)
            {
                if (loop_count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               [  캐릭터의 성향을 선택해주세요  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("          1. [  방 어 형  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("          2. [  공 격 형  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("          3. [  회 복 형  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo someting = Console.ReadKey();

                    if (someting.Key == ConsoleKey.D1 || someting.Key == ConsoleKey.NumPad1)
                    {
                        loop_count = 1;
                    }
                    else if (someting.Key == ConsoleKey.D2 || someting.Key == ConsoleKey.NumPad2)
                    {
                        loop_count = 2;
                    }
                    else if (someting.Key == ConsoleKey.D3 || someting.Key == ConsoleKey.NumPad3)
                    {
                        loop_count = 3;
                    }
                }
                else if (loop_count == 1)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               [  캐릭터의 성향을 선택해주세요  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               ┌───────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine("          1. [  방 어 형  ]");
                    Console.WriteLine();
                    Console.WriteLine("                                     [ 초 기 스 킬 ]     [ 철 갑 : 해당 턴에 방어력");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("          2. [  공 격 형  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                                                                   100 % 증가 ]");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("          3. [  회 복 형  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("                               └───────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo someting = Console.ReadKey();

                    if (someting.Key == ConsoleKey.D1 || someting.Key == ConsoleKey.NumPad1)
                    {
                        character = 1;
                        loop_count = 4;
                    }
                    else if (someting.Key == ConsoleKey.D2 || someting.Key == ConsoleKey.NumPad2)
                    {
                        loop_count = 2;
                    }
                    else if (someting.Key == ConsoleKey.D3 || someting.Key == ConsoleKey.NumPad3)
                    {
                        loop_count = 3;
                    }
                }
                else if (loop_count == 2)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               [  캐릭터의 성향을 선택해주세요  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               ┌───────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("          1. [  방 어 형  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("                                     [ 초 기 스 킬 ]     [ 연 격 : 해당 턴에 2 번 연속");
                    Console.WriteLine("          2. [  공 격 형  ]");
                    Console.WriteLine("                                                                   공격 ]");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("          3. [  회 복 형  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("                               └───────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo someting = Console.ReadKey();

                    if (someting.Key == ConsoleKey.D1 || someting.Key == ConsoleKey.NumPad1)
                    {
                        loop_count = 1;
                    }
                    else if (someting.Key == ConsoleKey.D2 || someting.Key == ConsoleKey.NumPad2)
                    {
                        character = 2;
                        loop_count = 5;
                    }
                    else if (someting.Key == ConsoleKey.D3 || someting.Key == ConsoleKey.NumPad3)
                    {
                        loop_count = 3;
                    }
                }
                else if (loop_count == 3)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               [  캐릭터의 성향을 선택해주세요  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               ┌───────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("          1. [  방 어 형  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("                                     [ 초 기 스 킬 ]     [ 활 력 : 해당 턴에 최대 HP 의");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("          2. [  공 격 형  ]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                                                                   10 % 만큼 HP 회복 ]");
                    Console.WriteLine();
                    Console.WriteLine("          3. [  회 복 형  ]");
                    Console.WriteLine();
                    Console.WriteLine("                               └───────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    ConsoleKeyInfo someting = Console.ReadKey();

                    if (someting.Key == ConsoleKey.D1 || someting.Key == ConsoleKey.NumPad1)
                    {
                        loop_count = 1;
                    }
                    else if (someting.Key == ConsoleKey.D2 || someting.Key == ConsoleKey.NumPad2)
                    {
                        loop_count = 2;
                    }
                    else if (someting.Key == ConsoleKey.D3 || someting.Key == ConsoleKey.NumPad3)
                    {
                        character = 3;
                        loop_count = 6;
                    }
                }
                else if (loop_count == 4)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               [  캐릭터의 성향 선택 완료  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("               ┌───────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                      [  방 어 형  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     [ 초 기 스 킬 ]     [ 철 갑 : 해당 턴에 방어력");
                    Console.WriteLine();
                    Console.WriteLine("                                                   100 % 증가 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("               └───────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Thread.Sleep(3000);
                    break;
                }
                else if (loop_count == 5)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               [  캐릭터의 성향 선택 완료  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("               ┌───────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                      [  공 격 형  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     [ 초 기 스 킬 ]     [ 연 격 : 해당 턴에 2 번 연속");
                    Console.WriteLine();
                    Console.WriteLine("                                                   공격 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("               └───────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Thread.Sleep(3000);
                    break;
                }
                else if (loop_count == 6)
                {
                    Console.Clear();
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < 16; i++)
                    {
                        Console.WriteLine("                                      {0}", player_form[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                               [  캐릭터의 성향 선택 완료  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("               ┌───────────────────────────────────────────────────────────┐");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                      [  회 복 형  ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                     [ 초 기 스 킬 ]     [ 활 력 : 해당 턴에 최대 HP 의");
                    Console.WriteLine();
                    Console.WriteLine("                                                   10 % 만큼 HP 회복 ]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("               └───────────────────────────────────────────────────────────┘");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                    Thread.Sleep(3000);
                    break;
                }
            }
        }
    }
}
