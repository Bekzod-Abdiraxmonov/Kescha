﻿System.Console.WriteLine("Ismingizni kiriting : ");
string name = Console.ReadLine();
System.Console.WriteLine($"Salom {name}, meni ismim Kescha, tanishganimdan xursandman");
int keschasAge = 5;
System.Console.Write("Yoshingizni kiriting:");
int usersAge = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Demak {name}ning yoshi keschanikidan {usersAge - keschasAge} yoshga farq qiladi");
