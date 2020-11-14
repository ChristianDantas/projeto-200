using System;

namespace Projeto_200
{
    class Program
    {
        static void Main(string[] args)
        {





















           Console.WriteLine("Olá, gostaria de jogar um rpg?");
           string resposta1= Console.ReadLine();
           if(resposta1=="sim"){
               char classe;
               Console.WriteLine("escolha uma classe: [m]=mago | [g]=guerreiro | [a]=arqueiro ");
                classe = char.Parse(Console.ReadLine());
               switch(classe){
                   case 'm':
                   Console.WriteLine("você tem apenas: uma vestimenta de mago simples e  uma varinha com apenas 1 magia e ela é a bola de fogo pequena");
                   Console.WriteLine("vamos jogar!");
                    Console.WriteLine("-------------------------------------------------------------");
                   Console.WriteLine("você esta em sua casa, tranquilamente, quando servos do senhor feudal que mora ao lado da sua casa decidem invadir a sua vila");
                   Console.WriteLine("você gostaria de: [l] lutar contra eles | [f]fugir");
                  string escolham1= Console.ReadLine();

                  if(escolham1=="l"){
                      Console.WriteLine("Otimo");
                      Console.WriteLine("entao voce sai de sua casa e se depara com todos servos do senhor feudal");
                      Console.WriteLine("gostaria de jogar sua magia? se voce conseguir acertar sua magia, voce mata todos");
                       string escolham2=Console.ReadLine();

                       if(escolham2=="sim"){
                           char respostam1;
                           Console.WriteLine("para acertar voce tem que responder: a cor do ceu é [a] azul | [p]preto?");                        
                           respostam1 = char.Parse(Console.ReadLine());

                           switch(respostam1){
                               case 'a':
                               Console.WriteLine("parabens, voce devastou todos os servos e subiu o nivel de sua bola de fogo");
                               Console.WriteLine("gostaria de se vingar do senhor feudal?");
                               string escolham3 = Console.ReadLine();

                               if(escolham3== "sim"){
                                   char respostam2;
                                   Console.WriteLine("Então, voce esta indo em direçao ao reino do senhor feudal, quando dois guardas te param e dizem:");
                                   Console.WriteLine("guardas- o que esta procurando aqui?");
                                   Console.WriteLine("voce se lembra que este senhor feudal ama ser desafiado");
                                   Console.WriteLine("Você diz aos guardas que: [b] busca vingança | [d]que veio desafiar o senhor feudal");
                                    respostam2 = char.Parse(Console.ReadLine());

                                    switch(respostam2){
                                        case 'b':
                                        Console.WriteLine("entao os guardas, com suas lanças te matam por se achar de mais");
                                         Console.WriteLine("-------------------------------------------------------------");
                                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                        Console.WriteLine("-------------------------------------------------------------");
                                        break;

                                         case 'd':
                                         Console.WriteLine("entao os guardas riem de você, porem, te levam para a sala do senhor");
                                         Console.WriteLine("chegando la, os guardas dizem que voce esta desafiando o senhor, entao o senhor diz: ");
                                         Console.WriteLine(" senhor feudal- voce realmente esta me desafiando?");
                                        string escolham4= Console.ReadLine();

                                        if(escolham4=="sim"){
                                            Console.WriteLine("senhor feudal- bom, gostei da sua coragem, tudo bem, comece me atacando");
                                            Console.WriteLine("gostaria de jogar sua bola de fogo? precisara acertar duas bolas de fogo para o derrotar");
                                            char respostam3;

                           Console.WriteLine("para acertar voce tem que responder: a cor do sol é [o]=amarelo | [r]=rosa?");                        
                           respostam3 = char.Parse(Console.ReadLine());
                           switch(respostam3){
                               case 'o':
                              
                                Console.WriteLine("parabens, voce o acertou!");
                                 Console.WriteLine("senhor feudal- aghhhh!!!! parabens, mas ainda nao fui derrotado");
                                  Console.WriteLine("senhor feudal- tome isso!!!");
                                   Console.WriteLine("esta vindo uma magia de trovão em sua direçao, responda essa pergunta e conseguirá desviar");
                                   Console.WriteLine("qual a cor da uva: [r]=roxo | [a]=azul");
                                   string respostam4= Console.ReadLine();
                                   if(respostam4=="r"){
                                        char escolham5;
                                       Console.WriteLine("voce consegue desviar com excelencia");
                                       Console.WriteLine("senhor feudal- parabens meu rapaz, entao me finalize agora");
                                       Console.WriteLine("escolha: [p]=piedade | [m]=mata-lo");
                                        escolham5 = char.Parse(Console.ReadLine());
                           switch(escolham5){
                               case 'p':
                               Console.WriteLine("entao quando voce se vira, ele joga um raio e te mata");
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                Console.WriteLine("-------------------------------------------------------------");
                               break;
                               case 'm':
                               Console.WriteLine("ultima pergunta");
                               Console.WriteLine("qual a cor do limão: [v]verde | [a]amarelo");
                                string respostafinal= Console.ReadLine();
                                if(respostafinal=="v"){
                                    Console.WriteLine("parabens, voce derrotou o senhor feudal");
                                    Console.WriteLine("todos os guardas estao aos seus pés dizendo que por voce derrotar o senhor feudal, voce devera se tornar um");
                                    Console.WriteLine("voce gostaria de se tornar o mestre feudal?");
                                    string escolhamfinal= Console.ReadLine();
                                    if(escolhamfinal=="sim"){
                                        Console.WriteLine("Parabens, agora voce é um senhor feudal, e ate a sua morte, voce teve uma vida tranquila"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    if(escolhamfinal=="nao"){
                                       Console.WriteLine("entao voce sai do reino e vai para sua casa continuar seu descanço"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    else{
                                        Console.WriteLine("error 508: resposta invalida."); 
                                    }
                                }
                                 if(respostafinal=="a"){
                                      Console.WriteLine("parabens, voce derrotou o senhor feudal");
                                    Console.WriteLine("todos os guardas estao aos seus pés dizendo que por voce derrotar o senhor feudal, voce devera se tornar um");
                                    Console.WriteLine("voce gostaria de se tornar o mestre feudal?");
                                     string escolhamfinal2= Console.ReadLine();
                                       if(escolhamfinal2=="sim"){
                                        Console.WriteLine("Parabens, agora voce é um senhor feudal, e ate a sua morte, voce teve uma vida tranquila"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    if(escolhamfinal2=="nao"){
                                       Console.WriteLine("entao voce sai do reino e vai para sua casa continuar seu descanço"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    else{
                                        Console.WriteLine("error 508: resposta invalida."); 
                                    }
                                }
                                else{
                                    Console.WriteLine("error 508: resposta invalida."); 
                                }
                               break;
                               default:
                                Console.WriteLine("error 508: resposta invalida."); 
                                break;
                           }
                                   }
                                   if(respostam4=="a"){
                                        Console.WriteLine("entao a magia de trovão o acerta e te incinera");
                                             Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                   }
                                   else{
                                       Console.WriteLine("error 508: resposta invalida."); 
                                   }
                                   

                               break;
                               case 'r':
                                 Console.WriteLine("entao voce explode a bola de fogo em si mesmo e morre");
                                  Console.WriteLine("-------------------------------------------------------------");
                                 Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                Console.WriteLine("-------------------------------------------------------------"); 
                               break;
                               default:
                                 Console.WriteLine("error 508: resposta invalida."); 
                               break;
                           }

                                        }

                                        if(escolham4=="nao"){
                                            Console.WriteLine("senhor feudal- tudo bem entao, pode ir embora");
                                            Console.WriteLine("quando você esta passando pela porta vem raio em suas costas e te incinera");
                                             Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                        }

                                        else{
                                            Console.WriteLine("error 508: resposta invalida."); 
                                        }
                                        break;

                                        default:
                                        Console.WriteLine("error 508: resposta invalida.");
                                        break;
                                    }
                               }
                               if(escolham3== "nao"){
                                   Console.WriteLine("entao voce vai para sua casa e volta a dormir tranquilamente");
                                   Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                   Console.WriteLine("-------------------------------------------------------------");
                               }
                               else{
                                    Console.WriteLine("error 508: resposta invalida.");
                               }

                               break;
                               case 'p':
                               Console.WriteLine("infelizmente você foi devastado pelos servos");
                                Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                   Console.WriteLine("-------------------------------------------------------------");
                                   
                               break;

                               default:
                               Console.WriteLine("error 508: resposta invalida.");
                               break;
                           }
                    

                       }
                       if(escolham2=="nao"){
                            Console.WriteLine("entao os servos te matam por estar no caminho deles");
                                         Console.WriteLine("-------------------------------------------------------------");
                                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                        Console.WriteLine("-------------------------------------------------------------");
                       }

                       else{
                            Console.WriteLine("error 508: resposta invalida.");
                       }
                  }

                  if(escolham1=="f"){
                        Console.WriteLine("quando voce esta fugindo, alguns dos servos te puxam e te matam");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                        Console.WriteLine("-------------------------------------------------------------");
                  }


                  else{
                        Console.WriteLine("error 508: resposta invalida.");
                  }


                   break;







                   case 'g':
                   Console.WriteLine("você tem apenas:vestimenta de guerreiro simples e uma espada simples");
                     Console.WriteLine("vamos jogar!");
                    Console.WriteLine("-------------------------------------------------------------");
                   Console.WriteLine("você esta em sua casa, tranquilamente, quando servos do senhor feudal que mora ao lado da sua casa decidem invadir a sua vila");
                   Console.WriteLine("você gostaria de: [l] lutar contra eles | [f]fugir");
                  string escolhab1= Console.ReadLine();
                  

                  if(escolhab1=="l"){
                      Console.WriteLine("Otimo");
                      Console.WriteLine("entao voce sai de sua casa e se depara com todos servos do senhor feudal");
                      Console.WriteLine("gostaria de girar com sua espada? essa é a unica forma de conseguir derrotar todos de uma vez");
                       string escolham2=Console.ReadLine();

                       if(escolham2=="sim"){
                           char respostam1;
                           Console.WriteLine("para acertar voce tem que responder: a cor do ceu é [a] azul | [p]preto?");                        
                           respostam1 = char.Parse(Console.ReadLine());

                           switch(respostam1){
                               case 'a':
                               Console.WriteLine("parabens, voce devastou todos os servos e um deles tinha uma espada melhor que a sua, e claro que você a pegou");
                               Console.WriteLine("gostaria de se vingar do senhor feudal?");
                               string escolham3 = Console.ReadLine();

                               if(escolham3== "sim"){
                                   char respostam2;
                                   Console.WriteLine("Então, voce esta indo em direçao ao reino do senhor feudal, quando dois guardas te param e dizem:");
                                   Console.WriteLine("guardas- o que esta procurando aqui?");
                                   Console.WriteLine("voce se lembra que este senhor feudal ama ser desafiado");
                                   Console.WriteLine("Você diz aos guardas que: [b] busca vingança | [d]que veio desafiar o senhor feudal");
                                    respostam2 = char.Parse(Console.ReadLine());

                                    switch(respostam2){
                                        case 'b':
                                        Console.WriteLine("entao os guardas, com suas lanças te matam por se achar de mais");
                                         Console.WriteLine("-------------------------------------------------------------");
                                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                        Console.WriteLine("-------------------------------------------------------------");
                                        break;

                                         case 'd':
                                         Console.WriteLine("entao os guardas riem de você, porem, te levam para a sala do senhor");
                                         Console.WriteLine("chegando la, os guardas dizem que voce esta desafiando o senhor, entao o senhor diz: ");
                                         Console.WriteLine(" senhor feudal- voce realmente esta me desafiando?");
                                        string escolham4= Console.ReadLine();

                                        if(escolham4=="sim"){
                                            Console.WriteLine("senhor feudal- bom, gostei da sua coragem, tudo bem, comece me atacando");
                                            Console.WriteLine("gostaria de ataca-lo com sua espada? precisara acertar dois ataques para o derrotar");
                                            char respostam3;

                           Console.WriteLine("para acertar voce tem que responder: a cor do sol é [o]=amarelo | [r]=rosa?");                        
                           respostam3 = char.Parse(Console.ReadLine());
                           switch(respostam3){
                               case 'o':
                              
                                Console.WriteLine("parabens, voce o acertou!");
                                 Console.WriteLine("senhor feudal- aghhhh!!!! parabens, mas ainda nao fui derrotado");
                                  Console.WriteLine("senhor feudal- tome isso!!!");
                                   Console.WriteLine("o senhor feudal esta vindo em sua direçao com a intençao de te atacar com a espada dele, responda essa pergunta e conseguirá desviar");
                                   Console.WriteLine("qual a cor da uva: [r]=roxo | [a]=azul");
                                   string respostam4= Console.ReadLine();
                                   if(respostam4=="r"){
                                        char escolham5;
                                       Console.WriteLine("voce consegue desviar com excelencia");
                                       Console.WriteLine("senhor feudal- parabens meu rapaz, entao me finalize agora");
                                       Console.WriteLine("escolha: [p]=piedade | [m]=mata-lo");
                                        escolham5 = char.Parse(Console.ReadLine());
                                        switch(escolham5){
                                        case 'p':
                                        Console.WriteLine("entao quando voce se vira, ele te ataca e te mata");
                                         Console.WriteLine("-------------------------------------------------------------");
                                         Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                        Console.WriteLine("-------------------------------------------------------------");
                                        break;
                                        case 'm':
                                        Console.WriteLine("ultima pergunta");
                                        Console.WriteLine("qual a cor do limão: [v]verde | [a]amarelo");
                                            string respostafinal= Console.ReadLine();
                                        if(respostafinal=="v"){
                                                Console.WriteLine("parabens, voce derrotou o senhor feudal");
                                             Console.WriteLine("todos os guardas estao aos seus pés dizendo que por voce derrotar o senhor feudal, voce devera se tornar um");
                                                Console.WriteLine("voce gostaria de se tornar o mestre feudal?");
                                                string escolhamfinal= Console.ReadLine();
                                            if(escolhamfinal=="sim"){
                                        Console.WriteLine("Parabens, agora voce é um senhor feudal, e ate a sua morte, voce teve uma vida tranquila"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                        }
                                         if(escolhamfinal=="nao"){
                                             Console.WriteLine("entao voce sai do reino e vai para sua casa continuar seu descanço"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    else{
                                        Console.WriteLine("error 508: resposta invalida."); 
                                    }
                                }
                                 if(respostafinal=="a"){
                                      Console.WriteLine("parabens, voce derrotou o senhor feudal");
                                    Console.WriteLine("todos os guardas estao aos seus pés dizendo que por voce derrotar o senhor feudal, voce devera se tornar um");
                                    Console.WriteLine("voce gostaria de se tornar o mestre feudal?");
                                     string escolhamfinal2= Console.ReadLine();
                                       if(escolhamfinal2=="sim"){
                                        Console.WriteLine("Parabens, agora voce é um senhor feudal, e ate a sua morte, voce teve uma vida tranquila"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    if(escolhamfinal2=="nao"){
                                       Console.WriteLine("entao voce sai do reino e vai para sua casa continuar seu descanço"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    else{
                                        Console.WriteLine("error 508: resposta invalida."); 
                                    }
                                }
                                else{
                                    Console.WriteLine("error 508: resposta invalida."); 
                                }
                               break;
                               default:
                                Console.WriteLine("error 508: resposta invalida."); 
                                break;
                           }
                                   }
                                   if(respostam4=="a"){
                                        Console.WriteLine("entao ele acerta o ataque e te mata");
                                             Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                   }
                                   else{
                                       Console.WriteLine("error 508: resposta invalida."); 
                                   }
                                   

                               break;
                               case 'r':
                                 Console.WriteLine("entao voce erra seu ataque e o senhor feudal te mata");
                                  Console.WriteLine("-------------------------------------------------------------");
                                 Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                Console.WriteLine("-------------------------------------------------------------"); 
                               break;
                               default:
                                 Console.WriteLine("error 508: resposta invalida."); 
                               break;
                           }

                                        }

                                        if(escolham4=="nao"){
                                            Console.WriteLine("senhor feudal- tudo bem entao, pode ir embora");
                                            Console.WriteLine("quando você esta passando pela porta ele te ataca e te mata");
                                             Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                        }

                                        else{
                                            Console.WriteLine("error 508: resposta invalida."); 
                                        }
                                        break;

                                        default:
                                        Console.WriteLine("error 508: resposta invalida.");
                                        break;
                                    }
                               }
                               if(escolham3== "nao"){
                                   Console.WriteLine("entao voce vai para sua casa e volta a dormir tranquilamente");
                                   Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                   Console.WriteLine("-------------------------------------------------------------");
                               }
                               else{
                                    Console.WriteLine("error 508: resposta invalida.");
                               }

                               break;
                               case 'p':
                               Console.WriteLine("infelizmente você foi devastado pelos servos");
                                Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                   Console.WriteLine("-------------------------------------------------------------");
                                   
                               break;

                               default:
                               Console.WriteLine("error 508: resposta invalida.");
                               break;
                           }
                    

                       }
                       if(escolham2=="nao"){
                            Console.WriteLine("entao os servos te matam por estar no caminho deles");
                                         Console.WriteLine("-------------------------------------------------------------");
                                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                        Console.WriteLine("-------------------------------------------------------------");
                       }

                       else{
                            Console.WriteLine("error 508: resposta invalida.");
                       }
                  }

                  if(escolhab1=="f"){
                        Console.WriteLine("quando voce esta fugindo, alguns dos servos te puxam e te matam");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                        Console.WriteLine("-------------------------------------------------------------");
                  }


                  else{
                        Console.WriteLine("error 508: resposta invalida.");
                  }
                   break;



                   case 'a':
                   Console.WriteLine("você tem apenas: um arco e  20 flechas");
                   Console.WriteLine("você tem apenas:vestimenta de guerreiro simples e uma espada simples");
                     Console.WriteLine("vamos jogar!");
                    Console.WriteLine("-------------------------------------------------------------");
                   Console.WriteLine("você esta em sua casa, tranquilamente, quando servos do senhor feudal que mora ao lado da sua casa decidem invadir a sua vila");
                   Console.WriteLine("você gostaria de: [l] lutar contra eles | [f]fugir");
                  string escolhaa1= Console.ReadLine();
                  

                  if(escolhaa1=="l"){
                      Console.WriteLine("Otimo");
                      Console.WriteLine("entao voce sai de sua casa e se depara com todos servos do senhor feudal");
                      Console.WriteLine("gostaria de fazer uma chuva de flechas? essa é a unica forma de conseguir derrotar todos de uma vez");
                       string escolham2=Console.ReadLine();

                       if(escolham2=="sim"){
                           char respostam1;
                           Console.WriteLine("para acertar voce tem que responder: a cor do ceu é [a] azul | [p]preto?");                        
                           respostam1 = char.Parse(Console.ReadLine());

                           switch(respostam1){
                               case 'a':
                               Console.WriteLine("parabens, voce devastou todos os servos e um deles tinha um arco melhor que o seu, e claro que você a pegou");
                               Console.WriteLine("gostaria de se vingar do senhor feudal?");
                               string escolham3 = Console.ReadLine();

                               if(escolham3== "sim"){
                                   char respostam2;
                                   Console.WriteLine("Então, voce esta indo em direçao ao reino do senhor feudal, quando dois guardas te param e dizem:");
                                   Console.WriteLine("guardas- o que esta procurando aqui?");
                                   Console.WriteLine("voce se lembra que este senhor feudal ama ser desafiado");
                                   Console.WriteLine("Você diz aos guardas que: [b] busca vingança | [d]que veio desafiar o senhor feudal");
                                    respostam2 = char.Parse(Console.ReadLine());

                                    switch(respostam2){
                                        case 'b':
                                        Console.WriteLine("entao os guardas, com suas lanças te matam por se achar de mais");
                                         Console.WriteLine("-------------------------------------------------------------");
                                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                        Console.WriteLine("-------------------------------------------------------------");
                                        break;

                                         case 'd':
                                         Console.WriteLine("entao os guardas riem de você, porem, te levam para a sala do senhor");
                                         Console.WriteLine("chegando la, os guardas dizem que voce esta desafiando o senhor, entao o senhor diz: ");
                                         Console.WriteLine(" senhor feudal- voce realmente esta me desafiando?");
                                        string escolham4= Console.ReadLine();

                                        if(escolham4=="sim"){
                                            Console.WriteLine("senhor feudal- bom, gostei da sua coragem, tudo bem, comece me atacando");
                                            Console.WriteLine("gostaria de ataca-lo uma flecha? precisara acertar duas ataques para o derrotar");
                                            char respostam3;

                           Console.WriteLine("para acertar voce tem que responder: a cor do sol é [o]=amarelo | [r]=rosa?");                        
                           respostam3 = char.Parse(Console.ReadLine());
                           switch(respostam3){
                               case 'o':
                              
                                Console.WriteLine("parabens, voce o acertou!");
                                 Console.WriteLine("senhor feudal- aghhhh!!!! parabens, mas ainda nao fui derrotado");
                                  Console.WriteLine("senhor feudal- tome isso!!!");
                                   Console.WriteLine("o senhor feudal esta mirando em voce com o arco que ele tem, entao ele atira sua flecha, responda essa pergunta e conseguirá desviar");
                                   Console.WriteLine("qual a cor da uva: [r]=roxo | [a]=azul");
                                   string respostam4= Console.ReadLine();
                                   if(respostam4=="r"){
                                        char escolham5;
                                       Console.WriteLine("voce consegue desviar com excelencia");
                                       Console.WriteLine("senhor feudal- parabens meu rapaz, entao me finalize agora");
                                       Console.WriteLine("escolha: [p]=piedade | [m]=mata-lo");
                                        escolham5 = char.Parse(Console.ReadLine());
                                        switch(escolham5){
                                        case 'p':
                                        Console.WriteLine("entao quando voce se vira, ele te ataca uma flecha e te mata");
                                         Console.WriteLine("-------------------------------------------------------------");
                                         Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                        Console.WriteLine("-------------------------------------------------------------");
                                        break;
                                        case 'm':
                                        Console.WriteLine("ultima pergunta");
                                        Console.WriteLine("qual a cor do limão: [v]verde | [a]amarelo");
                                            string respostafinal= Console.ReadLine();
                                        if(respostafinal=="v"){
                                                Console.WriteLine("parabens, voce derrotou o senhor feudal");
                                             Console.WriteLine("todos os guardas estao aos seus pés dizendo que por voce derrotar o senhor feudal, voce devera se tornar um");
                                                Console.WriteLine("voce gostaria de se tornar o mestre feudal?");
                                                string escolhamfinal= Console.ReadLine();
                                            if(escolhamfinal=="sim"){
                                        Console.WriteLine("Parabens, agora voce é um senhor feudal, e ate a sua morte, voce teve uma vida tranquila"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                        }
                                         if(escolhamfinal=="nao"){
                                             Console.WriteLine("entao voce sai do reino e vai para sua casa continuar seu descanço"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    else{
                                        Console.WriteLine("error 508: resposta invalida."); 
                                    }
                                }
                                 if(respostafinal=="a"){
                                      Console.WriteLine("parabens, voce derrotou o senhor feudal");
                                    Console.WriteLine("todos os guardas estao aos seus pés dizendo que por voce derrotar o senhor feudal, voce devera se tornar um");
                                    Console.WriteLine("voce gostaria de se tornar o mestre feudal?");
                                     string escolhamfinal2= Console.ReadLine();
                                       if(escolhamfinal2=="sim"){
                                        Console.WriteLine("Parabens, agora voce é um senhor feudal, e ate a sua morte, voce teve uma vida tranquila"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    if(escolhamfinal2=="nao"){
                                       Console.WriteLine("entao voce sai do reino e vai para sua casa continuar seu descanço"); 
                                         Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                    }
                                    else{
                                        Console.WriteLine("error 508: resposta invalida."); 
                                    }
                                }
                                else{
                                    Console.WriteLine("error 508: resposta invalida."); 
                                }
                               break;
                               default:
                                Console.WriteLine("error 508: resposta invalida."); 
                                break;
                           }
                                   }
                                   if(respostam4=="a"){
                                        Console.WriteLine("entao ele acerta a flecha e te mata");
                                             Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                   }
                                   else{
                                       Console.WriteLine("error 508: resposta invalida."); 
                                   }
                                   

                               break;
                               case 'r':
                                 Console.WriteLine("entao voce erra sua flecha e o senhor feudal lhe mata com a flecha dele");
                                  Console.WriteLine("-------------------------------------------------------------");
                                 Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                Console.WriteLine("-------------------------------------------------------------"); 
                               break;
                               default:
                                 Console.WriteLine("error 508: resposta invalida."); 
                               break;
                           }

                                        }

                                        if(escolham4=="nao"){
                                            Console.WriteLine("senhor feudal- tudo bem entao, pode ir embora");
                                            Console.WriteLine("quando você esta passando pela porta ele te mata com uma flecha");
                                             Console.WriteLine("-------------------------------------------------------------");
                                            Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                            Console.WriteLine("-------------------------------------------------------------");
                                        }

                                        else{
                                            Console.WriteLine("error 508: resposta invalida."); 
                                        }
                                        break;

                                        default:
                                        Console.WriteLine("error 508: resposta invalida.");
                                        break;
                                    }
                               }
                               if(escolham3== "nao"){
                                   Console.WriteLine("entao voce vai para sua casa e volta a dormir tranquilamente");
                                   Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                   Console.WriteLine("-------------------------------------------------------------");
                               }
                               else{
                                    Console.WriteLine("error 508: resposta invalida.");
                               }

                               break;
                               case 'p':
                               Console.WriteLine("infelizmente você foi devastado pelos servos");
                                Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                   Console.WriteLine("-------------------------------------------------------------");
                                   
                               break;

                               default:
                               Console.WriteLine("error 508: resposta invalida.");
                               break;
                           }
                    

                       }
                       if(escolham2=="nao"){
                            Console.WriteLine("entao os servos te matam por estar no caminho deles");
                                         Console.WriteLine("-------------------------------------------------------------");
                                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                                        Console.WriteLine("-------------------------------------------------------------");
                       }

                       else{
                            Console.WriteLine("error 508: resposta invalida.");
                       }
                  }

                  if(escolhaa1=="f"){
                        Console.WriteLine("quando voce esta fugindo, alguns dos servos te puxam e te matam");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("|||||||||||||||||||||||||||| FIM ||||||||||||||||||||||||||||");
                        Console.WriteLine("-------------------------------------------------------------");
                  }


                  else{
                        Console.WriteLine("error 508: resposta invalida.");
                  }
                   break;

               }
           }
           else if(resposta1=="nao"){
               Console.WriteLine("entendo, vou me desligar entao");
           }
           else{
               Console.WriteLine("error 657: resposta nao econtrada em nosso sistema.");
           }
        }
    }
}
