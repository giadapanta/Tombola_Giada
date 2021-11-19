// punto 1. Dare il Benvenuto all'utente
Console.WriteLine("BENVENUTO a Tombola!");

//punto 2. L'utente deve inserire 5 numeri tra 1 e 90
//NB. i numeri devono essere diversi.
//mostrare a video i numeri scelti dall'utente

int[] numUtente = new int[5];

//devo andare a verificare che l'utente non inserisca due numeri uguali 
// + i numeri devono essere compresi tra 1 e 90 -> 0 e n>90 non sono accettati


// Console.WriteLine("Devi scegliere 5 numeri:");
Console.WriteLine("Devi scegliere 5 numeri:");
int t = 0;

//do
//{
bool flag =true;
do
{

    for (int w = 0; w < 5; w++)
    {
        int index;
        int n;
        do
        {
            n = numUtente[t];
            index = Array.IndexOf(numUtente, n);


            while (t < 5)
            {

                Console.WriteLine("Inserisci un numero:");
                numUtente[t] = int.Parse(Console.ReadLine());

                //if (numUtente[t] == numUtente[t - 1])
                //{
                //    Console.WriteLine("Hai scelto lo stesso numero");
                //    Console.WriteLine("Inserisci un altro numero");
                //    numUtente[t] = int.Parse(Console.ReadLine());
                //    NotEquals = true;
                //}


                if (numUtente[t] > 90 || numUtente[t] < 1)
                {
                    Console.WriteLine("Hai inserito un numero sbagliato");
                    Console.WriteLine("Inserisci un altro numero.");
                    flag = false;
                    t--;                        //fa un passo indietro se scrivo n>90 e me lo sovrascrive
                }
                else
                {
                    Console.WriteLine("Hai scelto un numero valido, continua");
                }
                if (t == 4)
                {
                    Console.WriteLine("Buona fortuna!");
                    break;
                }
                t++;
            }

            Console.WriteLine($"I numeri scelti sono:");


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" {numUtente[i]}");
                //stampo il vettore dei numeri scelti dall'utente
            }

            break;

        } while (index != -1);

        numUtente[w] = n;
        break;
    }




    Random random = new Random();

    int[] rnd = new int[20]; //scelgo di estrarre 20 numeri

    for (int w = 0; w < rnd.Length; w++)
    {
        int index;
        int n;
        do
        {
            n = random.Next(1, 91);
            //n = int.Parse(Console.ReadLine());
            index = Array.IndexOf(rnd, n);

        } while (index != -1);

        rnd[w] = n;
    }

    Console.WriteLine($"I numeri scelti sono:");


    for (int i = 0; i < rnd.Length; i++)
    {
        Console.WriteLine($" {rnd[i]}");
        //stampo il vettore dei numeri scelti dal PC, giusto per fare un controllo

    }

    //punto 3.
    // se i numeri corrispondenti sono 2, dovrà essere scritto a terminale la frase: “Hai fatto ambo!”
    //-se i numeri corrispondenti sono 3, dovrà essere scritto a terminale la frase: “Hai fatto terno!”
    //-se i numeri corrispondenti sono 4, dovrà essere scritto a terminale la frase “Hai fatto
    //quaterna!”
    //-se i numeri corrispondenti sono 5, dovrà essere scritto a terminale la frase “Hai fatto cinquina!”

    //confronto i numeri dell'utente con il PC
    //int a;
    //do
    //{
    //    a=Array.IndexOf(numUtente,rnd );
    //} while (a != -1);


        Console.WriteLine("Vuoi continuare a giocare? Premi 'Y' per continuare" +
        "o qualunque altro tasto per uscire");
} while (Console.ReadLine() == "Y");










