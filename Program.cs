using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UrnaEletronica
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------Variaveis publicas do Programa----------
            int[] NP = new int[3];
            int[] NS = new int[3];
            int[] ND = new int[3];
            String[] NNP = new string[3];
            String[] NNS = new string[3];
            String[] NND = new string[3];
            int voto1;
            int CVP1 = 0, CVP2 = 0, CVP3 = 0, CVN1 = 0, CVB1=0;
            int CVS1 = 0, CVS2 = 0, CVS3 = 0, CVN2 = 0, CVB2=0;
            int CVD1 = 0, CVD2 = 0, CVD3 = 0, CVN3 = 0, CVB3=0;
           
            int V1P, V1S, V1D;
            //Variáveis com "P" no final são referentes ao presidente, equanto as com "S" são referentes ao Senador 
            //e as com "D" são referentes ao Deputado Federalooooopa.
            




            //----------Fim das variaveis----------

            //----------Cadastro de Candidatos----------
            {
                Console.WriteLine("Digite o número e o nome do candidato a presidente: \n");
                
                for (int i = 0; i < 3; i++)
                {
                    do{

                        Console.Write("Número: ");
                        NP[i] = Convert.ToInt16(Console.ReadLine());
                        if (NP[i] == 99)
                        {

                            
                            Console.WriteLine("\nEste número é reservado para votos nulos\n");
                            V1P = 1;
                            i = 0;
                        }
                        else if (NP[i] == 88)
                        {
                            Console.WriteLine("\nEste número é reservado para votos em branco\n");
                            V1P = 1;
                            i = 0;
                        }
                        else
                        {
                              
                            Console.Write("Nome: ");
                            NNP[i] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("------------ \n");
                            V1P = 2;
                        }
                    } while (V1P < 2) ;
                }
                 
                Console.WriteLine("Digite o número e o nome do candidato a Senador: \n");


                for (int i = 0; i < 3; i++)
                {
                   
                    do
                    {
                        Console.Write("Número: ");
                        NS[i] = Convert.ToInt16(Console.ReadLine());
                        if (NS[i] == 99)
                        {


                            Console.WriteLine("\nEste número é reservado para votos nulos\n");
                            V1S = 1;
                            i = 0;
                        }
                        else if (NS[i] == 88)
                        {
                            Console.WriteLine("\nEste número é reservado para votos em branco\n");
                            V1S = 1;
                            i = 0;
                        }
                        else
                        {
                            
                            Console.Write("Nome: ");
                            NNS[i] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("------------\n");
                            V1S = 2;
                        }
                    } while (V1S < 2 );
                }

                Console.WriteLine("Digite o número e o nome do candidato a Deputado Federal: \n");

                for (int i = 0; i < 3; i++)
                {
                    
                    do
                    {
                        Console.Write("Número: ");
                        ND[i] = Convert.ToInt16(Console.ReadLine());
                        if (ND[i] == 99)
                        {
                            Console.WriteLine("\nEste número é reservado para votos nulos\n");
                            V1D = 1;
                            i = 0;
                        }
                        else if (ND[i] == 88)
                        {
                            Console.WriteLine("\nEste número é reservado para votos em branco\n");
                            V1D = 1;
                            i = 0;
                        }
                        else
                        {
                            Console.Write("Nome: ");
                            NND[i] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("------------\n");
                            V1D = 2;
                        }
                    } while (V1D < 2);
                }
            }
            //----------Fim do cadastro---------- 
            
            Console.Clear();
            
            //----------Apresentação dos candidatos----------
            {
                Console.WriteLine("Os candidatos dessa eleição são: \n");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(NP[i] + " - Presidente - ");
                    Console.WriteLine(NNP[i] + "\n");
                }

                Console.WriteLine("---------------------\n");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(NS[i] + " - Senador - ");
                    Console.WriteLine(NNS[i] + "\n");
                }

                Console.WriteLine("---------------------\n");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(ND[i] + " - Deputado Federal - ");
                    Console.WriteLine(NND[i] + "\n");
                }
            }
            //----------Fim da Apresentação---------- 
            
            //----------Captura de voto---------- 
            int ii = 1;
            while (ii < 2)
            {

                Console.WriteLine("\nVote em um candidato para Presidente.\n\n " +
                    "Para votar Nulo digite 99.\n"+"Para votar em Branco digite 88.\n\n");
                {
                    

                    voto1 = Convert.ToInt16(Console.ReadLine());
                    if (voto1 == NP[0])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVP1 = CVP1 + 1;
                    }
                    else if (voto1 == NP[1])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVP2 = CVP2 + 1;
                    }
                    else if (voto1 == NP[2])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVP3 = CVP3 + 1;
                    }
                    else if (voto1 == 99)
                    {
                        Console.WriteLine("\nVoto Nulo");
                        CVN1 = CVN1 + 1;
                    }
                    else if ( voto1 == 88 )
                    {
                        Console.WriteLine("\nVoto em branco.");
                        CVB1 = CVB1 + 1;
                    }
                    else {
                        Console.WriteLine("Voto Nulo");
                        CVN1 = CVN1 + 1;
                    }
                }

                Console.WriteLine("\nVote em um candidato para Senador.\n\n " +
                "Para votar Nulo digite 99.\n" + "Para votar em Branco digite 88.\n\n");
                {
                    voto1 = Convert.ToInt16(Console.ReadLine());
                    if (voto1 == NS[0])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVS1 = CVS1 + 1;
                    }
                    else if (voto1 == NS[1])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVS2 = CVS2 + 1;
                    }
                    else if (voto1 == NS[2])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVS3 = CVS3 + 1;
                    }
                    else if (voto1 == 99)
                    {
                        Console.WriteLine("\nVoto Nulo");
                        CVN2 = CVN2 + 1;
                    }
                    else if (voto1 == 88)
                    {
                        Console.WriteLine("\nVoto em branco.");
                        CVB2 = CVB2 + 1;
                    }
                    else
                    {
                        Console.WriteLine("\nVoto Nulo");
                        CVN2 = CVN2 + 1;
                    }
                }

                Console.WriteLine("\n\nVote em um candidato para Deputado Ferderal.\n\n " +
              "Para votar Nulo digite 99.\n" + "Para votar em Branco digite 88.\n\n");
                {
                    
                    voto1 = Convert.ToInt16(Console.ReadLine());
                    if (voto1 == ND[0])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVD1 = CVD1 + 1;
                    }
                    else if (voto1 == ND[1])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVD2 = CVD2 + 1;
                    }
                    else if (voto1 == ND[2])
                    {
                        Console.WriteLine("\nVoto Realizado com sucesso");
                        CVD3 = CVD3 + 1;
                    }
                    else if (voto1 == 99)
                    {
                        Console.WriteLine("\nVoto Nulo");
                        CVN3 = CVN3 + 1;
                    }
                    else if (voto1 == 88)
                    {
                        Console.WriteLine("\nVoto em branco.");
                        CVB3 = CVB3 + 1;
                    }
                    else
                    {
                        Console.WriteLine("Voto Nulo");
                        CVN3 = CVN3 + 1;
                    }
                }

                Console.WriteLine("Voto Finalizado.\n");
                Console.WriteLine("Deseja votar novamente?\n" + ">S ou N<");
                String decisao;
                int decisao2;
                decisao = Convert.ToString(Console.ReadLine());
                {
                    if (decisao == "S")
                    {
                        decisao2 = 1;
                    }
                    else if (decisao == "s")
                    {
                        decisao2 = 1;
                    }
                    else if (decisao == "N")
                    {
                        decisao2 = 2;
                    }
                    else if (decisao == "n")
                    {
                        decisao2 = 2;
                    }
                    else
                    {
                        decisao2 = 3;
                    }
                }
                if (decisao2 == 1)
                {
                    ii = 1;
                    Console.Clear();
                    {
                        Console.WriteLine("Os candidatos dessa eleição são: \n");

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(NP[i] + " - Presidente - ");
                            Console.WriteLine(NNP[i] + "\n");
                        }

                        Console.WriteLine("\n---------------------\n");

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(NS[i] + " - Senador - ");
                            Console.WriteLine(NNS[i] + "\n");
                        }

                        Console.WriteLine("\n---------------------\n");

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(ND[i] + " - Deputado Federal - ");
                            Console.WriteLine(NND[i] + "\n");
                        }
                    }

                }
                else if (decisao2 == 2)
                {
                    ii = 2;
                }
                else
                {
                    Console.WriteLine("Comando não Reconhecido.");
                    break;
                }
            }
            //----------Fim da Captura de votos---------- 
       
            //----------Apuração de votos----------
            {
                Console.Clear();
                Console.WriteLine("Quantidade de votos para Presidente.\n\n");
                Console.WriteLine(NP[0] + " " + NNP[0] + " " + CVP1 + "\n");
                Console.WriteLine(NP[1] + " " + NNP[1] + " " + CVP2 + "\n");
                Console.WriteLine(NP[2] + " " + NNP[2] + " " + CVP3 + "\n");
                Console.WriteLine("Votos Nulos: " + CVN1+"\n");
                Console.WriteLine("Votos Brancos: " + CVB1 + "\n");

                Console.WriteLine("\n\nQuantidade de votos para Senador.\n\n");
                Console.WriteLine(NS[0] + " " + NNS[0] + " " + CVS1 + "\n");
                Console.WriteLine(NS[1] + " " + NNS[1] + " " + CVS2 + "\n");
                Console.WriteLine(NS[2] + " " + NNS[2] + " " + CVS3+"\n");
                Console.WriteLine("Votos Nulos: " + CVN2+"\n");
                Console.WriteLine("Votos Brancos: " + CVB2 + "\n");

                Console.WriteLine("\n\nQuantidade de votos para Deputado Federal.\n\n");
                Console.WriteLine(ND[0] + " " + NND[0] + " " + CVD1 + "\n");
                Console.WriteLine(ND[1] + " " + NND[1] + " " + CVD2 + "\n");
                Console.WriteLine(ND[2] + " " + NND[2] + " " + CVD3+"\n");
                Console.WriteLine("Votos Nulos: " + CVN3 + "\n");
                Console.WriteLine("Votos Brancos: " + CVB3 + "\n\n");
            }
            //----------Fim da apuração de votos---------- 

            //----------Resultado da eleição---------- 
            //Presidenten
            { 
            if ((CVP1 > CVP2) && (CVP1 > CVP3))
            {
                Console.WriteLine("Presidente eleito: " + NP[0] + " " + NNP[0] + " " + CVP1);
            }
            else if ((CVP2 > CVP1) && (CVP2 > CVP3))
            {
                Console.WriteLine("Presidente eleito: " + NP[1] + " " + NNP[1] + " " + CVP2);
            }
            else if ((CVP3 > CVP1) && (CVP3 > CVP2))
            {
                Console.WriteLine("Presidente eleito: " + NP[2] + " " + NNP[2] + " " + CVP3);
            }
            else if ((CVP1 == CVP2) && (CVP1 == CVP3))
            {
                Console.WriteLine("Houve um empate entre: \n");
                Console.WriteLine(NP[0] + " " + NNP[0] + " " + CVP1 + "\n");
                Console.WriteLine(NP[1] + " " + NNP[1] + " " + CVP2 + "\n");
                Console.WriteLine(NP[2] + " " + NNP[2] + " " + CVP3);
            }
            else if (CVP1 == CVP2)
            {
                Console.WriteLine("Houve um empate entre: \n");
                Console.WriteLine(NP[0] + " " + NNP[0] + " " + CVP1 + "\n");
                Console.WriteLine(NP[1] + " " + NNP[1] + " " + CVP2);
            }
            else if (CVP1 == CVP3)
            {
                Console.WriteLine("Houve um empate entre: \n");
                Console.WriteLine(NP[0] + " " + NNP[0] + " " + CVP1 + "\n");
                Console.WriteLine(NP[2] + " " + NNP[2] + " " + CVP3);
            }
            else
            {
                Console.WriteLine("Houve um empate entre: \n");
                Console.WriteLine(NP[1] + " " + NNP[1] + " " + CVP2 + "\n");
                Console.WriteLine(NP[2] + " " + NNP[2] + " " + CVP3);
            }
        }
            //Fim presidente 
            //Senador
            {
                if ((CVS1 > CVS2) && (CVS1 > CVS3))
                {
                    Console.WriteLine("Senador eleito: " + NS[0] + " " + NNS[0] + " " + CVS1);
                }
                else if ((CVS2 > CVS1) && (CVS2 > CVS3))
                {
                    Console.WriteLine("Senador eleito: " + NS[1] + " " + NNS[1] + " " + CVS2);
                }
                else if ((CVS3 > CVS1) && (CVS3 > CVS2))
                {
                    Console.WriteLine("Senador eleito: " + NS[2] + " " + NNS[2] + " " + CVS3);
                }
                else if ((CVS1 == CVS2) && (CVS1 == CVS3))
                {
                    Console.WriteLine("Houve um empate entre: \n");
                    Console.WriteLine(NS[0] + " " + NNS[0] + " " + CVS1 + "\n");
                    Console.WriteLine(NS[1] + " " + NNS[1] + " " + CVS2 + "\n");
                    Console.WriteLine(NS[2] + " " + NNS[2] + " " + CVS3);
                }
                else if (CVS1 == CVS2)
                {
                    Console.WriteLine("Houve um empate entre: \n");
                    Console.WriteLine(NS[0] + " " + NNS[0] + " " + CVS1 + "\n");
                    Console.WriteLine(NS[1] + " " + NNS[1] + " " + CVS2);
                }
                else if (CVS1 == CVS3)
                {
                    Console.WriteLine("Houve um empate entre: \n");
                    Console.WriteLine(NS[0] + " " + NNS[0] + " " + CVS1 + "\n");
                    Console.WriteLine(NS[2] + " " + NNS[2] + " " + CVS3);
                }
                else
                {
                    Console.WriteLine("Houve um empate entre: \n");
                    Console.WriteLine(NS[1] + " " + NNS[1] + " " + CVS2 + "\n");
                    Console.WriteLine(NS[2] + " " + NNS[2] + " " + CVS3);
                }
            }
            //Fim Senador 
            //Deputado Federal 
            {
                if ((CVD1 > CVD2) && (CVD1 > CVD3))
                {
                    Console.WriteLine("Deputado Federal eleito: " + ND[0] + " " + NND[0] + " " + CVD1);
                }
                else if ((CVD2 > CVD1) && (CVD2 > CVD3))
                {
                    Console.WriteLine("\nDeputado Federal eleito: " + ND[1] + " " + NND[1] + " " + CVD2);
                }
                else if ((CVD3 > CVD1) && (CVD3 > CVD2))
                {
                    Console.WriteLine("\nDeputado Federal eleito: " + ND[2] + " " + NND[2] + " " + CVD3);
                }
                else if ((CVD1 == CVD2) && (CVD1 == CVD3))
                {
                    Console.WriteLine("Houve um empate entre: \n");
                    Console.WriteLine(ND[0] + " " + NND[0] + " " + CVD1 + "\n");
                    Console.WriteLine(ND[1] + " " + NND[1] + " " + CVD2 + "\n");
                    Console.WriteLine(ND[2] + " " + NND[2] + " " + CVD3);
                }
                else if (CVD1 == CVD2)
                {
                    Console.WriteLine("Houve um empate entre: \n");
                    Console.WriteLine(ND[0] + " " + NND[0] + " " + CVD1 + "\n");
                    Console.WriteLine(ND[1] + " " + NND[1] + " " + CVD2);
                }
                else if (CVP1 == CVP3)
                {
                    Console.WriteLine("Houve um empate entre: \n");
                    Console.WriteLine(ND[0] + " " + NND[0] + " " + CVD1 + "\n");
                    Console.WriteLine(ND[2] + " " + NND[2] + " " + CVD3);
                }
                else
                {
                    Console.WriteLine("Houve um empate entre: \n");
                    Console.WriteLine(ND[1] + " " + NND[1] + " " + CVD2 + "\n");
                    Console.WriteLine(ND[2] + " " + NND[2] + " " + CVD3);
                }
            }
            //Fim Deputado Federal 
           
        }
}
}
