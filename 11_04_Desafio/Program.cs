using System;
using System.Collections.Generic;

namespace _11_04_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alunos> listaAlunos = new List<Alunos>();
            int op = 0, escolha=0, exRA = 0;
            string exNome = "", encontrado = "";
            

            do
            {
                Console.WriteLine(" 1 - Incluir");
                Console.WriteLine(" 2 - Excluir");
                Console.WriteLine(" 3 - Consultar");
                Console.WriteLine(" 4 - Sair");
                
                do
                {
                    Console.Write("Oque deseja fazer? ");
                    op = Convert.ToInt32(Console.ReadLine());
                    
                } while (op != 1 && op != 2 && op != 3 && op != 4);
                Console.WriteLine("");

                if (op == 1)
                {
                    var aln = new Alunos();

                    Console.Write("RA do aluno: ");
                    aln.RA = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nome do aluno: ");
                    aln.Nome = Console.ReadLine();

                    Console.Write("Sexo do aluno: ");
                    aln.Sexo = Console.ReadLine();

                    Console.Write("E-mail do aluno: ");
                    aln.Email = Console.ReadLine();

                    Console.Write("Data de nascimento do aluno: ");
                    aln.DTnasc = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Curso do aluno: ");
                    aln.Curso = Console.ReadLine();
                    Console.WriteLine("Aluno Adicionado");
                    Console.ReadLine();
                    Console.Clear();
                    listaAlunos.Add(aln);
                }
                else if (op == 2)
                {
                    Console.Write("NOME do aluno que sera excluido: ");
                    exNome = Console.ReadLine();
                    encontrado = "N";
                    var exclu = new Alunos();
                    foreach (var item in listaAlunos)
                    {
                        if (item.Nome == exNome)
                        {
                            exclu = item;
                            encontrado = "S";
                        }
                    }
                    if (encontrado == "N")
                    {
                        Console.WriteLine("Aluno não encontrado");
                    }
                    else
                    {
                        Console.WriteLine("Aluno EXCLUIDO");
                        listaAlunos.Remove(exclu);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (op == 3)
                {
                    Console.WriteLine(" 1 - RA");
                    Console.WriteLine(" 2 - NOME");
                    Console.Write("Deseja consultar por? ");
                    escolha = Convert.ToInt32(Console.ReadLine());
                    if (escolha == 1)
                    {
                        Console.Write("RA do aluno que sera consultado: ");
                        exRA = Convert.ToInt32(Console.ReadLine());
                        encontrado = "N";
                        foreach (var item in listaAlunos)
                        {
                            if (item.RA == exRA)
                            {
                                Console.WriteLine("RA: "+item.RA);
                                Console.WriteLine("Nome: "+item.Nome);
                                Console.WriteLine("Sexo: "+item.Sexo);
                                Console.WriteLine("E-Mail "+item.Email);
                                Console.WriteLine("DT Nasc: "+item.DTnasc.ToShortDateString());
                                Console.WriteLine("Curso: "+item.Curso);
                                encontrado = "S";
                            }
                        }
                        if (encontrado == "N")
                        {
                            Console.WriteLine("Aluno não encontrado");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (escolha == 2)
                    {
                        Console.Write("NOME do aluno que sera consultar: ");
                        exNome = Console.ReadLine();
                        encontrado = "N";
                        foreach (var item in listaAlunos)
                        {
                            if (item.Nome == exNome)
                            {
                                Console.WriteLine("RA: " + item.RA);
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Sexo: " + item.Sexo);
                                Console.WriteLine("E-Mail " + item.Email);
                                Console.WriteLine("DT Nasc: " + item.DTnasc.ToShortDateString());
                                Console.WriteLine("Curso: " + item.Curso);
                                encontrado = "S";
                            }
                        }
                        if (encontrado == "N")
                        {
                            Console.WriteLine("Aluno não encontrado");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (op == 4)
                {
                    Console.WriteLine("Fim da Execução");
                }

            } while (op != 4);



            

            
        }
    }
}
